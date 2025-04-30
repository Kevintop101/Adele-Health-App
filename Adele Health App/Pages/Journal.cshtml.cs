using Microsoft.AspNetCore.Mvc.RazorPages;
using Adele_Health_App.Models;
using System.Collections.Generic;

namespace Adele_Health_App.Pages
{
    public class JournalModel : PageModel
    {
        public List<EntrySectionModel> EntrySections { get; set; } = new();

        public void OnGet()
        {
            EntrySections.Add(new EntrySectionModel
            {
                DateText = "Today, Feb 27, 2025",
                Entries = new List<EntryModel>
                {
                    new EntryModel
                    {
                        Id = 1,
                        Time = "9:05 PM",
                        Reading = "90",
                        MealTiming = "Before Breakfast",
                        Date = "Feb 27, 2025",
                        GlucoseResponse = "Feeling okay",
                        Notes = "Slight headache",
                        Tags = new List<string> { "Fasting", "Morning" },
                        Measurements = new Dictionary<string, string>
                        {
                            { "Glucose", "120 mg/dL" },
                            { "Ketones", "0.5 mmol/L" },
                            { "Blood Pressure", "120/80 mmHg" }
                        }
                    },

                    new EntryModel
                    {
                        Id = 2,
                        Time = "9:05 PM",
                        Reading = "200",
                        MealTiming = "Before Breakfast",
                        Date = "Feb 27, 2025",
                        GlucoseResponse = "Feeling okay",
                        Notes = "Slight headache",
                        Tags = new List<string> { "Fasting", "Morning" },
                        Measurements = new Dictionary<string, string>
                        {
                            { "Glucose", "120 mg/dL" },
                            { "Ketones", "0.5 mmol/L" },
                            { "Blood Pressure", "120/80 mmHg" }
                        }
                    },
                    new EntryModel
                    {
                        Id = 3,
                        Time = "9:05 PM",
                        Reading = "50",
                        MealTiming = "Before Breakfast",
                        Date = "Feb 27, 2025",
                        GlucoseResponse = "Feeling okay",
                        Notes = "Slight headache",
                        Tags = new List<string> { "Fasting", "Morning" },
                        Measurements = new Dictionary<string, string>
                        {
                            { "Glucose", "120 mg/dL" },
                            { "Ketones", "0.5 mmol/L" },
                            { "Blood Pressure", "120/80 mmHg" }
                        }
                    }
                }
            });

            EntrySections.Add(new EntrySectionModel
            {
                DateText = "Yesterday, Feb 26, 2025",
                Entries = new List<EntryModel>
                {
                    new EntryModel
                    {
                        Id = 4,
                        Time = "9:05 PM",
                        Reading = "70",
                        MealTiming = "Before Breakfast",
                        Date = "Feb 27, 2025",
                        GlucoseResponse = "Feeling okay",
                        Notes = "Slight headache",
                        Tags = new List<string> { "Fasting", "Morning" },
                        Measurements = new Dictionary<string, string>
                        {
                            { "Glucose", "120 mg/dL" },
                            { "Ketones", "0.5 mmol/L" },
                            { "Blood Pressure", "120/80 mmHg" }
                        }
                    },
                }
            });
        }
    }
}