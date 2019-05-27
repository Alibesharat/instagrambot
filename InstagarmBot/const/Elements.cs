using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagarmBot
{
    public class Elements
    {
        IWebDriver driver;
        public Elements(IWebDriver driver)
        {
            this.driver = driver;

        }

        public IWebElement UserName { get { return driver.FindElement(By.Name("username")); } }
        public IWebElement Password { get { return driver.FindElement(By.Name("password")); } }
        public IWebElement EmailOrPhone { get { return driver.FindElement(By.Name("emailOrPhone")); } }
        public IWebElement FullName { get { return driver.FindElement(By.Name("fullName")); } }


        public IWebElement Hp6_Coverd_Element { get { return driver.FindElement(By.ClassName("uDNXD")); } }
        public IWebElement CommentArea { get { return driver.FindElement(By.XPath("//textarea[@placeholder ='Add a comment…']")); } }
        public IWebElement WEbSiteLink { get { return driver.FindElement(By.XPath("/html/body/span/section/main/div/header/section/div[2]/a")); } }

        public IWebElement Btn_TakenBy { get { return driver.FindElement(By.XPath("/html/body/span/section/main/div/div/article/header/div[2]/div[1]/div[1]/h2/a")); } }
                                                                                  
        public IWebElement Btn_signUp { get { return driver.FindElement(By.XPath("/html/body/span/section/main/article/div[2]/div[1]/div/form/div[5]/span/button")); } }
        public IWebElement Btn_login { get { return driver.FindElement(By.XPath("/html/body/span/section/main/div/article/div/div[1]/div/form/div[4]/button/div")); } }
        public IWebElement Btn_Followe { get { return driver.FindElement(By.XPath("//html/body/span/section/main/div/div/article/header/div[2]/div[1]/div[2]/button")); } }
        public IWebElement Btn_Like { get { return driver.FindElement(By.XPath("/html/body/span/section/main/div/div/article/div[2]/section[1]/span[1]/button")); } }
        public IWebElement Btn_Stories { get { return driver.FindElement(By.XPath("/html/body/span/section/main/section/div[3]/div[2]/a")); } }
        public IWebElement Btn_Followers { get { return driver.FindElement(By.XPath("/html/body/span/section/main/div/header/section/ul/li[2]/a")); } }
        public IWebElement Btn_Following { get { return driver.FindElement(By.XPath("/html/body/span/section/main/div/header/section/ul/li[3]/a")); } }
        public IList<IWebElement> list_Followers { get { return driver.FindElements(By.ClassName("BW116")); } }

        public IList<IWebElement> List_user_posts { get { return driver.FindElements(By.XPath("//div[@Class='v1Nh3 kIKUG  _bz0w']/a")); } }

        public IList<IWebElement> List_following_post { get { return driver.FindElements(By.TagName("article")); } }

        public IWebElement GetDivsMedia(int index)
        {
            IWebElement webElement;
            webElement = driver.FindElements(By.XPath("//div[@Class='v1Nh3 kIKUG  _bz0w']/a"))[index];
            return webElement;
        }


        public IWebElement HashTagCount { get { return driver.FindElement(By.XPath("/html/body/span/section/main/article/header/div[2]/span/span")); } }

        public bool IsLiked()
        {
            return Btn_Like.Text == "Unlike" ? true : false;
        }

        public bool IsFollowed()
        {

            return Btn_Followe.Text == "Following" ? true : false;
        }
    }
}
