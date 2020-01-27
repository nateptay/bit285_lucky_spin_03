using System;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random = new Random();

        //The Conroller to receive the Luck number from the Route
        public IActionResult Index(int luck = 7) //Default value for luck is 7
        {
            LuckySpin.Models.Spin spin = new LuckySpin.Models.Spin();
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);

            // Load up the ViewBag for use by the Spinner View "Index.cshtml"
            spin.ImgDisplay = (a == luck || b == luck || c == luck)?"block":"none";
            spin.SpinNum1 = a;
            spin.SpinNum2 = b;
            spin.SpinNum3 = c;
            spin.LuckyNumber = luck;

            return View(spin);
        }
    }
}