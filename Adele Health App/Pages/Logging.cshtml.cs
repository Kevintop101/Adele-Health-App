using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Adele_Health_App.Pages
{
    public class LoggingModel : PageModel
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Glucose { get; set; }
        public string MealTiming { get; set; }
        public string Notes { get; set; }

        public IActionResult OnPost()
        {
            TempData["Date"] = Date;
            TempData["Time"] = Time;
            TempData["Glucose"] = Glucose;
            TempData["MealTiming"] = MealTiming;
            TempData["Notes"] = Notes;

            return RedirectToPage("/Lifestyle"); // return is important!
        }

    }

}
