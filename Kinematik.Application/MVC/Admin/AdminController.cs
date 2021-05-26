using Kinematik.Application.MVC.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kinematik.Application.MVC.Admin
{
    [Route("admin")]
    public class AdminController: Controller
    {
        public IActionResult Index()
        {
            DashboardViewModel viewModel = new DashboardViewModel
            {
                Areas = new[]
                {
                    new DashboardViewModel.AreaLink
                    {
                        Title = "Test",
                        Link = "whataver"
                    }
                }
            };
            
            return View("Dashboard", viewModel);
        }
    }
}