/*namespace BookShoppingCartMvcUI.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}*/

using System.ComponentModel.DataAnnotations;

namespace BookShoppingCartMvcUI.Models
{
    public class ErrorViewModel
    {
        [MaxLength(50, ErrorMessage = "Request ID cannot be longer than 50 characters")]
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
