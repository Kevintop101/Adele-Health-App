using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Adele_Health_App.Models;

namespace Adele_Health_App.Pages
{
    public class DiscoverModel : PageModel
    {

        public string RawEntryJson { get; set; }
        public void OnGet(string entry)
        {
            if (!string.IsNullOrEmpty(entry))
            {
                RawEntryJson = entry;
            }
        }
    }
}
