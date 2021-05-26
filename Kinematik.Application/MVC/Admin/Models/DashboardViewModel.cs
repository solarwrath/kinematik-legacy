using System.Collections.Generic;

namespace Kinematik.Application.MVC.Admin.Models
{
    public class DashboardViewModel
    {
        public IEnumerable<AreaLink> Areas { get; set; }
        
        public class AreaLink
        {
            public string Title { get; set; }
            public string Link { get; set; }
        }
    }
}