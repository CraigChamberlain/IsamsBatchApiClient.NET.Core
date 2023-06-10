using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using Isams.BatchApiClient.Core.Errors;

namespace Isams.BatchApiClient.Core.Services
{
    public static class ApiErrorHandler
    {
        public static async Task<Exception> ErrorFromStream(Stream stream)
        {
            stream.Position = 0;
            XmlReaderSettings settings = new ()
            {
                Async = true,
            };
            Dictionary<string, string> errors = new ();

            // required to stop exception due to incorrect encoding in document type meta.
            var sr = new StreamReader(stream);
            using (var reader = XmlReader.Create(sr, settings))
            {
                if (reader.ReadToFollowing("Message") & await reader.ReadAsync())
                {
                    while (await reader.MoveToContentAsync() == XmlNodeType.Element)
                    {
                        var title = reader.Name;
                        try
                        {
                            var content = await reader.ReadElementContentAsStringAsync();
                            errors.Add(title.Trim(), content.Trim());
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }

            if (!errors.ContainsKey("Title") || !errors.ContainsKey("Description"))
            {
                return new Exception("API originated error with unexpected format");
            }

            if (errors["Title"] == "Unknown Error" && (
                 errors["Description"].EndsWith("Rerun the transaction.") ||
                 errors["Description"].StartsWith("Lock request time out period exceeded.")))
            {
                return new RecoverableException(errors["Title"], errors["Description"]);
            }
            if (errors["Title"] == "Unknown Error")
            {
                return new Exception($"Unknown API originated error :{System.Environment.NewLine}{errors["Description"]}");
            }

            return new Exception($"{errors["Title"]}:{System.Environment.NewLine}{errors["Description"]}");
        }
    }
}