using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LiveServerTime.Pages
{
    public class ServerTimeModel : PageModel
    {
        public string ServerTime { get; private set; }

        public void OnGet()
        {
            ServerTime = DateTime.Now.ToString("T"); // formats to "HH:mm:ss"
        }
    }
}
