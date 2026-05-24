using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTVN5.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sách")]
        [StringLength(200)]
        [Display(Name = "Tên sách")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên tác giả")]
        [StringLength(100)]
        [Display(Name = "Tác giả")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá bán")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá bán phải lớn hơn 0")]
        [Display(Name = "Giá bán")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Hình ảnh")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn chủ đề")]
        [Display(Name = "Chủ đề")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidateNever]
        public Category? Category { get; set; }
    }
}
