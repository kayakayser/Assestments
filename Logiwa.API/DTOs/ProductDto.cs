using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa.API.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "{0} alanı 0'dan büyük bir değer olmalıdır.")]
        public int StockQuantity { get; set; }

        
    }
}
