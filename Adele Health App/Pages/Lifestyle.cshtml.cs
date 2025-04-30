using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Adele_Health_App.Models;
using System;

namespace Adele_Health_App.Pages
{
    public class LifestyleModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        // Constructor to inject the ApplicationDbContext
        public LifestyleModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // BindProperties to capture form values from query parameters or form submissions.
        [BindProperty(SupportsGet = true)]
        public string Date { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Time { get; set; }  // Time will be handled as a string initially, to be converted to TimeSpan

        [BindProperty(SupportsGet = true)]
        public string Glucose { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MealTiming { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Notes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string GlucoseStatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ExerciseLevel { get; set; }

        [BindProperty(SupportsGet = true)]
        public string NutritionStatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MedicationStatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public string HydrationStatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SleepStatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public string StressStatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Tags { get; set; }
        public List<string> HydrationTags { get; set; } = new List<string>();
        public List<string> NutritionTags { get; set; } = new List<string>();
        public List<string> ExerciseTags { get; set; } = new List<string>();
        public List<string> MedicationTags { get; set; } = new List<string>();
        public List<string> SleepTags { get; set; } = new List<string>();
        public List<string> StressTags { get; set; } = new List<string>();
        public List<string> GlucoseTags { get; set; } = new List<string>();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string glucose = Request.Form["selectedGlucose"];
            string exercise = Request.Form["selectedExercise"];
            string nutrition = Request.Form["selectedNutrition"];
            string medication = Request.Form["selectedMedication"];
            string hydration = Request.Form["selectedHydration"];
            string sleep = Request.Form["selectedSleep"];
            string stress = Request.Form["selectedStress"];
            string addedTags = Request.Form["addedTags"];

        List<string> tagsList = addedTags.Split(',').ToList();


            return RedirectToPage();
        }

    }
}

