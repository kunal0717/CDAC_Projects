/*using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        public int Id { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required,MaxLength(20)]
        public string ?StatusName { get; set; }
    }
}
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Status ID is required")]
        public int StatusId { get; set; }

        [Required(ErrorMessage = "Status Name is required")]
        [MaxLength(20, ErrorMessage = "Status Name cannot be longer than 20 characters")]
        public string? StatusName { get; set; }
    }
}
