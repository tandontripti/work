using DeveloperDashboard.web.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeveloperDashboard.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<AchievementModel> achievements = new List<AchievementModel>();
            
            AchievementModel achievement = new AchievementModel();
            achievement.Title = "Extensions Junkie";
            achievement.Category= "Customizing Visual Studio";
            achievement.ShortDescription = "Install 5 extensions to Visual Studio. Extensibility rocks! ";
            
            Image icon = Image.FromFile(Server.MapPath(Url.Content("~/Content/Images/icon.png")));


            achievement.Icon = ImageToByteArray(icon); 
            achievement.Points = 5;

            achievements.Add(achievement);

            achievement.Title = "Extensions Junkie Deluxe";
            achievement.Category = "Customizing Visual Studio";
            achievement.ShortDescription = "Install 10 extensions to Visual Studio. How can you find anything on a menu? ";
            achievement.Points = 10;
            achievements.Add(achievement);

            achievement.Title = "Gotta Be Different";
            achievement.Category = "Customizing Visual Studio";
            achievement.ShortDescription = "Load custom Visual Studio settings. I swear, they never get the default settings right. ";
            achievement.Points = 5;
            achievements.Add(achievement);
            return View(achievements);
        }


        //convert image to bytearray
        private byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, img.RawFormat);
                return stream.ToArray();
            }
        }

    }
}