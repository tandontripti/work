using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperDashboard.web.Models
{
    public class AchievementModel
    {
        public string Title { get; set; }

        public int Points { get; set; }

        public string ShortDescription { get; set; }

        public string Category { get; set; }

        public byte[] Icon { get; set; } 

    }
}