using System.Collections.Generic;

namespace Adele_Health_App.Models
{
    public class EntryModel
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string Reading { get; set; }
        public string MealTiming { get; set; }
        public string Date { get; set; }
        public string GlucoseResponse { get; set; }
        public List<string> Tags { get; set; }
        public string Notes { get; set; }

        // NEW ADDITION
        public Dictionary<string, string> Measurements { get; set; } = new();

    }
}
