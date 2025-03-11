using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UiTestFrameworkFrNumbersQuiz.Models;

namespace UiTestFrameworkFrNumbersQuiz.Utilities
{
    public static class FileIO
    {
        public static List<T> ReadTranslationFile<T>(string fileName)
        {
            // Read number translation from a CSV file
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetName().Name + "." + fileName;

            List<T> translations;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (var fileReader = new StreamReader(stream))
            {
                var csv = new CsvReader(fileReader, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"));
                translations = csv.GetRecords<T>().ToList();
            }

            return translations;
        }
    }
}
