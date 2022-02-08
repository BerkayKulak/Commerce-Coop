using System.Collections;
using System.Collections.Generic;

namespace ECommerce.NET_Angular.API.Errors
{
    public class ApiValidatorErrorResponse:ApiResponse
    {
        public ApiValidatorErrorResponse() : base(400)
        {
        }

        public IEnumerable<string> Errors { get; set; }
    }
}
