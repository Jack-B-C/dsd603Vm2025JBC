using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace dsd603Vm2025JBC.Services
{
    public class TextFileOperations : ITextFileOperations
    {
        private readonly IWebHostEnvironment _env;

        public TextFileOperations(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IEnumerable<string> LoadConditionsForAcceptanceText()
        {
            // Get the absolute path to the wwwroot directory
            string rootPath = _env.WebRootPath;
            // Combine the path with the filename
            FileInfo filePath = new FileInfo(Path.Combine(rootPath, "ConditionsForAcceptance.txt"));
            // Read all lines from the file
            string[] lines = System.IO.File.ReadAllLines(filePath.ToString());
            // Return as IEnumerable<string>
            return lines.ToList();
        }
    }


}
