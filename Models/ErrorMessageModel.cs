using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models
{
    internal class ErrorMessageModel
    {
        public string code { get; set; }
        public string description { get; set; }

        public string GetPrettyJson(string j)
        {
            string json = j;

            // Deserialize the JSON array into a list of objects
            List<ErrorMessageModel> errors = JsonConvert.DeserializeObject<List<ErrorMessageModel>>(json);

            // Extract descriptions and concatenate them into a single string
            StringBuilder descriptionBuilder = new StringBuilder();
            foreach (var error in errors)
            {
                descriptionBuilder.AppendLine(error.description);
            }

            // Get the final string without square brackets and quotes
            string prettyDescriptions = descriptionBuilder.ToString().Trim();

            return prettyDescriptions;
        }



        //public string GetPrettyJson(string j)
        //{
        //    string json = j;

        //    // Deserialize the JSON array into a list of objects
        //    List<ErrorMessageModel> errors = JsonConvert.DeserializeObject<List<ErrorMessageModel>>(json);

        //    // Pretty-print the list as a string
        //    string prettyJson = JsonConvert.SerializeObject(errors, Formatting.Indented);

        //    return prettyJson;
        //}

        //public string GetPrettyJson(string j)
        //{
        //    string json = j;

        //    // Deserialize the JSON array into a list of objects
        //    List<ErrorMessageModel> errors = JsonConvert.DeserializeObject<List<ErrorMessageModel>>(json);

        //    // Extract descriptions and store them in a list
        //    List<string> descriptions = new List<string>();
        //    foreach (var error in errors)
        //    {
        //        descriptions.Add(error.description);
        //    }

        //    // Pretty-print the list of descriptions
        //    string prettyDescriptions = JsonConvert.SerializeObject(descriptions, Formatting.Indented);

        //    return prettyDescriptions;
        //}



    }
}
