using System.Collections.Generic;
using Isams.BatchApiClient.Core.DTO.Filters;

namespace Isams.BatchApiClient.Core.Requests
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