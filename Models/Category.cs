using System.ComponentModel.DataAnnotations;

namespace BTVN5.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên chủ đề")]
        [StringLength(100)]
        [Display(Name = "Tên chủ đề")]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
