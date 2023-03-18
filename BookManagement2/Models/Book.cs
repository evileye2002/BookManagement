using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookManagement2.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [DisplayName("Tên Sách")]
        [DataType(DataType.Text)]
        [MinLength(5, ErrorMessage = "Tên quá ngắn!")]
        [Required(ErrorMessage = "Trường bắt buộc")]
        public string? BookName { get; set; }

        [DisplayName("Mô tả")]
        [DataType(DataType.MultilineText)]
        [MinLength(10, ErrorMessage = "Mô tả ít nhất 10 ký tự!")]
        [Required(ErrorMessage = "Trường bắt buộc")]
        public string? BookDesc { get; set; }

        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Trường bắt buộc")]
        [Range(1, 99, ErrorMessage = "Số lượng từ 1-99")]
        public int BookQuantity { get; set; }

        [DisplayName("Giá (VNĐ)")]
        [DataType(DataType.Currency, ErrorMessage = "Chỉ được nhập số!")]
        [Required(ErrorMessage = "Trường bắt buộc")]
        public int BookPrice { get; set; }

        [DisplayName("Ảnh")]
        [DataType(DataType.Upload, ErrorMessage = "Không hỗ trợ tệp tin này!")]
        [Required(ErrorMessage = "Trường bắt buộc")]
        public string? BookImage { get; set; }
    }
}
