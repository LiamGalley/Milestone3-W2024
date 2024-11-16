/*Course: 		Web Programming 3
* Assessment: 	Milestone 3
* Created by: 	LIAM GALLEY - 2167120
* Date: 		15 11 2024
* Class Name: 	HomeController.cs
* Description: 	Explain what the class stores and its functionality. 
* Time Task B):	3
*/

using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
