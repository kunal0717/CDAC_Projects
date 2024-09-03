/*using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }

        [Required]
        [MaxLength(40)]
        public string? AuthorName { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }
        public Stock Stock { get; set; }

        [NotMapped]
        public string GenreName { get; set; }
        [NotMapped]
        public int Quantity { get; set; }


    }
}
*/


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Book Name is required")]
        [MaxLength(40, ErrorMessage = "Book Name cannot be longer than 40 characters")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Author Name is required")]
        [MaxLength(40, ErrorMessage = "Author Name cannot be longer than 40 characters")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public double Price { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL for the image")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Genre Id is required")]
        public int GenreId { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public List<OrderDetail> OrderDetail { get; set; } = new List<OrderDetail>();

        public List<CartDetail> CartDetail { get; set; } = new List<CartDetail>();

        [Required]
        public Stock Stock { get; set; }

        [NotMapped]
        public string GenreName { get; set; }

        [NotMapped]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }
    }
}
