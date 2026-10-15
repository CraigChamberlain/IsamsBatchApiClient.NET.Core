using System.Collections.Generic;
using IsamsBatchApiClient.DTO.Filters;

namespace IsamsBatchApiClient.Requests
{
    public class Filters
    {
        public Filters()
        {
        }

        public Filters(Method method)
        {
            MethodsToRun = new List<Method> { method };
        }

        public List<Method> MethodsToRun { get; set; }
    }
}