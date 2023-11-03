using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("Filmin Türü")]
        [Required(ErrorMessage ="Lütfen bir film türü seçiniz!")]
        public int? GenreId { get; set; }

        [Required(ErrorMessage ="Filmin adını girmelisiniz")]
        [DisplayName("Filmin Adı")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Filmin adı 3-50 karater aralığında olmalıdır")]

        public string? Title { get; set; }


        [Required(ErrorMessage ="Lütfen kısa bir açıklama giriniz!")]
        [DisplayName("Açıklama")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Açıklama 20-500 karater aralığında olmalıdır")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Lütfen yönetmenin adını giriniz!")]
        [DisplayName("Yönetmen Adı")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Yönetmen adı 3-50 karater aralığında olmalıdır")]
        public string? Director { get; set; }
        public string[]? Players { get; set; }
        public string?  ImageUrl { get; set; }
    }
}