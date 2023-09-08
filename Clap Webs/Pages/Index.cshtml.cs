using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Clap_Webs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //my Filepath
        string filePath = @"C:\Users\rune1\Desktop\output.txt";

        public int Counter { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Counter = CountClaps(LoadFile(filePath));
        }

        //Here we count the claps from the string made from LoadFile
        public IActionResult OnGetGetClapCount()
        {
            Counter = CountClaps(LoadFile(filePath));
            return new JsonResult(new { count = Counter });
        }
        //We convert the file to a string
        private string LoadFile(string filePath)
        {
            StringBuilder fileContents = new StringBuilder();
            using (var sr = new StreamReader(filePath))
            {
                fileContents.Append(sr.ReadToEnd());
            }

            return fileContents.ToString();
        }
        //We count the amount of claps and split and lay it in an array
        private int CountClaps(string content)
        {
            string[] claps = content.Split(new char[] { ' ','\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] clapArray = claps.Where(word => string.Equals(word, "clap", StringComparison.OrdinalIgnoreCase)).ToArray();
            return clapArray.Length;
        }
    }
}
