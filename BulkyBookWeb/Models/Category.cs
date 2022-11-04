using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [DisplayName("Category Name")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Out of acceptable range")]
        public int DisplayOrder { get; set; } = -1;
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
