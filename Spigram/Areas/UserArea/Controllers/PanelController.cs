using InstagarmBot;
using InstagarmBot.Data;
using InstagarmBot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Spigram.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;



namespace Spigram.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    public class PanelController : Controller
    {
        Bot api;
        private user currentuser;
        private readonly SpigramContext _context;
        public PanelController(Bot botService, SpigramContext context)
        {
            api = botService;
            _context = context;


        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userId = HttpContext.getuserId();
            if (userId != null) currentuser = _context.users.Find(int.Parse(userId));


            base.OnActionExecuting(context);


        }

        [CheckLoginUserFilter]
        public IActionResult Index()
        {
            return View(currentuser);
        }


        [HttpPost]
        public async Task<IActionResult> Index(user model)
        {
            try
            {
                currentuser.InstagramUserName = model.InstagramUserName;
                currentuser.InstagramPassword = model.InstagramPassword;
                currentuser.Commentlist = "";
                _context.users.Update(currentuser);
                await _context.SaveChangesAsync();
                ViewBag.IsUpdate = true;

            }
            catch (DbUpdateConcurrencyException ex)
            {
                ViewBag.IsUpdate = false;
            }
            return View(model);

        }

        [HttpGet]
        public IActionResult trace()
        {
            if (currentuser.BotState)
            {
                return View(nameof(Index), currentuser);
            }

            ViewBag.commentlist = currentuser.Commentlist;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> trace([FromForm] Trace trace)
        {
            if (trace.traceBy == TraceBy.Location)
            {
                var s = trace.parameter.ToEnum<Locations>(Locations.Abadan_Iran);
                trace.parameter = s.GetShortName().Trim(); ;

            }
            if (string.IsNullOrWhiteSpace(trace.CommentList) || trace.CommentList.Split(',').Count() < 10)
            {
                ViewBag.message = "حداقل ده کامنت مختلف وارد کنید";
                ViewBag.commentlist = currentuser.Commentlist;
                return View(trace);
            }
          
            var oldlist = new List<string>();
            foreach (var item in currentuser.Commentlist.Split(','))
            {
                oldlist.Add(item);

            }
            var newList = new List<string>();
            foreach (var text in trace.CommentList.Split(','))
            {
                if (!oldlist.Contains(text))
                    oldlist.Add(text);
            }
            string data = "";
            foreach (var item in oldlist)
            {
                data += $",{item}";
            }
            data = data.TrimStart(',').TrimEnd(',');
          
            trace.UserId = currentuser.Id;
            new Thread(delegate ()
            {
                api.Start_Trace(trace);
            }).Start();

            currentuser.Commentlist = data;
            currentuser.BotState = true;
            _context.Update(currentuser);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Likeownfollowing()
        {
            if (currentuser.BotState)
            {
                return View(nameof(Index));
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Likeownfollowing(BaseModel model = null)
        {
            model = new BaseModel()
            {
                UserId = currentuser.Id

            };
            new Thread(delegate ()
            {
                api.Start_Like_Following(model);
            }).Start();
            currentuser.BotState = true;
            _context.Update(currentuser);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




        [HttpGet]
        public IActionResult follow()
        {
            if (currentuser.BotState)
            {
                return View(nameof(Index));
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> follow(Follow follow)
        {
            follow.UserId = currentuser.Id;
            new Thread(delegate ()
            {
                api.Start_Follow(follow);
            }).Start();
            currentuser.BotState = true;
            _context.Update(currentuser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }


        [HttpGet]
        public IActionResult unfollow()
        {
            if (currentuser.BotState)

            {
                return View(nameof(Index));
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> unfollow(UnFollow unfollow)
        {
            unfollow.UserId = currentuser.Id;
            new Thread(delegate ()
            {
                api.Start_Unfollow(unfollow);

            }).Start();
            currentuser.BotState = true;
            _context.Update(currentuser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        public async Task<IActionResult> StopBot()
        {
            currentuser.BotState = false;
            _context.Update(currentuser);
            await _context.SaveChangesAsync();
            new Thread(delegate ()
            {
                api.StopBotAsync("توقف دستی", currentuser.Id);

            }).Start();
           
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> GetReports()
        {
            var reposts = await _context.Reports.Where(c => c.UserId == currentuser.Id).ToListAsync();

            return View(reposts);
        }






    }
}