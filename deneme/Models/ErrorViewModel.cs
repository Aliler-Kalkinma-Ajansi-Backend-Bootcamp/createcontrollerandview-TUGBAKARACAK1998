using System;

namespace deneme.Models
{
    public class ErrorViewModel
    {
        
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
