using InstagarmBot.Data;
using InstagarmBot.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpiLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InstagarmBot
{
    public class Bot
    {
        IWebDriver driver;
        Elements Elements;
        ISpiloggerService report;
        private IJavaScriptExecutor js;
        private bool IsStopeddBot = false;
        private readonly IHostingEnvironment _env;
        private readonly SpigramContext _context;
        private user currentuser;

        public readonly IConfiguration _Configuration;
        List<string> VisitedPage;

        public Bot(ISpiloggerService reportService, IHostingEnvironment env, IConfiguration Configuration, SpigramContext myContext)
        {
            report = reportService;
            _env = env;
            VisitedPage = new List<string>();
            _context = myContext;
            _Configuration = Configuration;


        }



        public void InitDrive()
        {
            try
            {

                var driverpath = $"{_env.WebRootPath}\\MyDriver\\";
                //var Firefoxpath = $"{_env.WebRootPath}\\Firefox\\firefox.exe";
                var Firefoxpath = _Configuration.GetSection("Firefoxpath").Value;
                //var driverpath = _Configuration.GetSection("driverpath").Value;
                driver = Drivers.init(driverpath, Firefoxpath);
                report.Write("شروع فعالیت ربات");
                driver.Manage().Cookies.DeleteAllCookies();
                //Cookie c = new Cookie("user", userId.ToString(), DateTime.Now.AddDays(3).ToString());
                // driver.Manage().Cookies.AddCookie(c);
                IsStopeddBot = false;
                Elements = new Elements(driver);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                js = (IJavaScriptExecutor)driver;
                try
                {
                    Elements.Hp6_Coverd_Element.Click();
                }
                catch
                {

                    ;
                }
            }
            catch (Exception ex)
            {

                report.Write(ex.Message);
                // StopBot();
            }



        }

        /// <summary>
        /// دریافت   آیتم های پنجره ی مودال فالوورز
        ///و آنفالو انها
        /// </summary>
        /// <param name="count"></param>
        public void GetFollowersAndUnfollow(int count)
        {
            /* report.Write("Follwer Count : Is " + Elements.list_Followers.Count);*/
            int index = 1;
            foreach (var item in Elements.list_Followers)
            {
                if (index % 10 == 0) Thread.Sleep(TimeSpan.FromMinutes(10));
                item.Click();
                RandomWaite();
                index++;
            }
        }

        public void Start_Login(int UserId)
        {
            try
            {
                GetCurrentUser(UserId);
                if (driver == null) driver = null;
                InitDrive();
                driver.Url = Address.LoginUrl;

                RandomWaite();
                Elements.UserName.SendKeys(currentuser.InstagramUserName);
                Elements.Password.SendKeys(currentuser.InstagramPassword);
                RandomWaite();
                Elements.Btn_login.SendKeys(Keys.Enter);
                RandomWaite();


                if (IsLoginSuccess())
                {
                    if (IsVeryfiEmailOrPhoneNeed())
                    {
                        report.Write("به کد امنیتی برای وورد احتیاج است");
                        report.Write("برای حل این مشکل با پشتیبانی تماس حاصل فرمایید");
                        // StopBot();


                    }
                    report.Write("ورود موفقیت آمیز");

                }
                else
                {
                    report.Write("ورود ناموفق");
                    StopBotAsync();
                }
            }
            catch (Exception ex)
            {
                report.Write(ex.Message);
                StopBotAsync();

            }

        }

        /// <summary>
        /// ثبت نام حساب جدید
        /// </summary>
        public void Start_Register(Models.Register register)
        {
            //driver.Url = Address.RegisterUrl;
            //RandomWaite();
            //Elements.UserName.SendKeys(register.username);
            //RandomWaite();
            //Elements.FullName.SendKeys(register.fullname);
            //RandomWaite();
            //Elements.EmailOrPhone.SendKeys(register.emailorphone);
            //RandomWaite();
            //Elements.Password.SendKeys(register.InstagramPassword);
            //RandomWaite();
            //Elements.Btn_signUp.Click();
            //RandomWaite();

        }

        /// <summary>
        /// لایک ، کامنت ، فالو خودکار
        /// </summary>
        /// <param name="username">نام کاربری برای لاگین</param>
        /// <param name="password">رمز عبور برای لاگین</param>
        /// <param name="TraceBy">نوع کاوش</param>
        /// <param name="trace.parameter">هشتگ ، لوکیشن یا نام پروفایل</param>
        /// <param name="count">تعداد</param>
        public void Start_Trace(Models.Trace trace)
        {

            Start_Login(trace.UserId);
            if (!IsStopeddBot)
            {
                int Post_index = 1;
                string NavigationAddress;
                switch (trace.traceBy)
                {
                    case TraceBy.Hashtag:
                        report.Write("جستجوی برای هشتگ", $"{trace.parameter}");
                        NavigationAddress = Address.Explore(trace.parameter);
                        break;
                    case TraceBy.Location:
                        report.Write("جستجوی برای لوکیشن", $"{trace.parameter}");
                        NavigationAddress = Address.LocationUrl(trace.parameter);
                        break;
                    case TraceBy.Username:
                        report.Write("جستجوی برای پیج", $"{trace.parameter}");
                        NavigationAddress = Address.UserAddress(trace.parameter);
                        break;
                    default:
                        report.Write("مشکل در آدرس دهی", $"{trace.parameter}");
                        StopBotAsync("مشکل در آدرس دهی", currentuser.Id);
                        return;
                }
                driver.Navigate().GoToUrl(NavigationAddress);

                if (!IsFound())
                {

                    StopBotAsync($"هیچ پستی برای {trace.parameter}  پیدا نشد  ");
                }
                else
                {
                    try
                    {
                        RandomWaite();
                        Elements.Hp6_Coverd_Element.Click();
                    }
                    catch
                    {

                        ;
                    }
                    int PostsCount = 0;
                    try
                    {

                        PostsCount = int.Parse(Elements.HashTagCount.Text.Replace(",", string.Empty));
                        report.Write("تعداد پست های یافت شده   ", PostsCount.ToString());
                    }
                    catch
                    {

                        PostsCount = trace.count;
                    }
                    if (PostsCount < trace.count)
                    {
                        trace.count = PostsCount;

                    }


                    for (int i = 0; i < trace.count; i++)
                    {

                        try
                        {
                            driver.Navigate().GoToUrl(NavigationAddress);
                            RandomWaite();
                            var link = Elements.GetDivsMedia(i).GetAttribute("href");
                            if (!VisitedPage.Contains(link))
                            {
                                driver.Navigate().GoToUrl(link);
                                VisitedPage.Add(link);

                                RandomWaite();
                                string _Takenby = Elements.Btn_TakenBy.GetAttribute("title");
                                if (!Elements.IsFollowed())
                                {

                                    try
                                    {

                                        Elements.Btn_Followe.Click();
                                        report.Write("کاربر فالوو شد ", _Takenby);
                                        Scroll_To_End();
                                    }
                                    catch (Exception ex)
                                    {
                                        try
                                        {
                                            js.ExecuteScript("arguments[0].click()", Elements.Btn_Followe);
                                        }
                                        catch (Exception exep)
                                        {

                                            report.Write("EX : " + ex.Message);
                                            report.Write("javscript : " + exep.Message);
                                            //TODO : Log ex
                                            report.Write("کاربر  متاسفانه فالوو نشد ", _Takenby);

                                        }

                                    }

                                }
                                else
                                {
                                    report.Write("کاربر از قبل فالوو شده بود", _Takenby);
                                }
                                RandomWaite();
                                if (!Elements.IsLiked())
                                {
                                    try
                                    {

                                        report.Write("تلاش برای لایک پست", link);
                                        Elements.Btn_Like.Click();
                                        report.Write("پست لایک شد", link);
                                    }
                                    catch (Exception ex)
                                    {
                                        try
                                        {
                                            js.ExecuteScript("arguments[0].click()", Elements.Btn_Like);
                                        }
                                        catch (Exception exep)
                                        {

                                            report.Write("EX : " + ex.Message);
                                            report.Write("javScript  Ex:" + exep.Message);
                                            //TODO : Log Ex
                                            report.Write("متاسفانه پست  ، لایک نشد", link);
                                        }

                                    }

                                }
                                else
                                {
                                    report.Write("این پست از قبل لایک شده بود", link);
                                }


                                RandomWaite();
                                Post_index += 1;
                                if (Post_index <= 3)
                                {
                                    try
                                    {


                                        Elements.CommentArea.Click();
                                        RandomWaite();
                                        string comment = RandomComment(trace.CommentList);
                                        //string CommentList = "سلام ربات اسپایگرام هشتگ زیبایی را دنبال کرد و این متن را بصورت اتوماتیک پست کرد ،اگر دنبال توسعه کسب وکار خود در اینستاگرام هستید اسپایگرام را دنبال کتید ،عجب پستی ، تو واقعا حرف نداری تو بی نظیری  خوشحال میشم ما را هم دنبال کنید ،اگه میخواین بک ربات به جای ادمین اینستگرام براتون فعالیت کنه  #اسپایگرام رو از دست ندید،این کامنت بصورت خودکار ارسال شده است ،واو چه پست خوبی،اسپایگرام ربات فعالیت زمانبدی شده برای اینستاگرام";
                                        //string comment = RandomComment(CommentList);
                                        Elements.CommentArea.SendKeys(comment);
                                        Elements.CommentArea.Submit();
                                        report.Write("کامنت ارسال شد", comment);
                                        RandomWaite();
                                    }
                                    catch (Exception ex)
                                    {
                                        if (ex.Message.StartsWith("Unable"))
                                        {
                                            report.Write("کاربر کامنت های این پست را بسته بود");
                                        }
                                        else
                                        {
                                            report.Write(ex.Message);
                                            report.Write("کامنت ارسال نشد ", "محدودیت  از طرف اینستاگرام");

                                        }

                                    }
                                }
                                else
                                {
                                    Post_index = 1;
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            report.Write("مشکلی بوجود آمد");
                            report.Write(ex.Message);

                        }
                        finally
                        {
                            report.CreateLogAsync(ReportFolder.instagarm, "");
                        }


                    }
                    StopBotAsync("عملیات با موفقیت به اتمام رسید", trace.UserId);
                }
            }



        }

        /// <summary>
        ///  فالو خودکار
        /// </summary>
        /// <param name="follow"></param>
        public void Start_Follow(Models.Follow follow)
        {
            Start_Login(follow.UserId);
            if (driver != null)
            {
                driver.Navigate().GoToUrl(Address.UserAddress(follow.parameter));
                RandomWaite();
                switch (follow.followFrom)
                {
                    case FollowFrom.followers:
                        Elements.Btn_Followers.Click();
                        break;
                    case FollowFrom.following:
                        Elements.Btn_Following.Click();
                        break;
                    default:
                        break;
                }
                RandomWaite();
                GetFollowersAndUnfollow(follow.count);
            }


        }

        /// <summary>
        /// آنفالو خودکار
        /// </summary>
        /// <param name="unFollow"></param>
        public void Start_Unfollow(Models.UnFollow unFollow)
        {
            //TOOD Unfolow
            Start_Login(unFollow.UserId);
            driver.Navigate().GoToUrl(Address.UserAddress(currentuser.InstagramUserName));

            Elements.Btn_Following.Click();
            RandomWaite();
            GetFollowersAndUnfollow(unFollow.count);
        }

        /// <summary>
        /// لایک کسانی را که فالو کرده ام
        /// </summary>
        /// <param name="baseModel"></param>
        public void Start_Like_Following(Models.BaseModel baseModel)
        {
            Start_Login(baseModel.UserId);
            driver.Navigate().GoToUrl(Address.url);
            try
            {
                report.Write("Start Loop");
                for (int i = 0; i < 5; i++)
                {
                    report.Write($"Start Loop[{i}]");
                    Scroll_To_End();
                    report.Write($"Scroll to end ");

                    RandomWaite();
                }
                report.Write($"get list ");
                var el = Elements.List_following_post;
            }
            catch (Exception ex)
            {
                report.Write(ex.Message);
                //StopBot();
            }

            //TODO : 
        }

        #region Validations
        private bool IsVeryfiEmailOrPhoneNeed()
        {
            return driver.Url.Contains("challenge");
        }

        private bool IsFound()
        {
            return driver.Title.Contains("Page Not Found") ? false : true;
        }

        private bool IsLoginSuccess()
        {
            return driver.Title.Contains("Login ") ? false : true;
        }

        #endregion


        public string RandomComment(string commentsList)
        {
            var comments = commentsList.Split(',');
            //var comments = commentsList.Split('،');
            Random r = new Random();
            return comments[r.Next(0, (comments.Length - 1))];
        }


        private void RandomWaite()
        {
            Random r = new Random();
            int sleep = r.Next(1000, 3000);
            Thread.Sleep(sleep);
            report.Write("تاخیر عمدی ", $"{sleep} میلی ثانیه");
        }


        public void Scroll_To_End()
        {
            js.ExecuteScript("window.scrollTo(0, 3000)");
        }

        public void Scroll_Step_By_Step()
        {
            js.ExecuteScript("document.documentElement.scrollTop+=400");
        }


        //دریافت کاربر جاری
        private void GetCurrentUser(int userID)
        {
            try
            {
                var user = _context.users.Find(userID);
                if (user == null) StopBotAsync("کاربر یافت نشد");
                currentuser = user;
            }
            catch (Exception ex)
            {

                StopBotAsync("dispose", userID);
            }
        }

        public void StopBotAsync(string Reason = "", int UserId = 1)
        {
            try
            {
                if (Reason != "dispose")
                {
                    report.Write(Reason);
                    report.Write("فعالیت  ربات به پایان رسید");
                    report.Write("ربات خاموش شد");
                    var logs = report.GetLogsExistInMemmory();
                    GetCurrentUser(UserId);
                    currentuser.BotState = false;
                    Report r = new Report() { Datetime = DateTime.Now.ToLongDateString(), UserId = UserId, ReportData = logs };
                    _context.Reports.Add(r);
                    _context.Update(currentuser);
                    _context.SaveChangesAsync();
                }

                driver.Close();

            }
            catch (Exception ex)
            {


            }
            finally
            {

            }



        }




    }
}
