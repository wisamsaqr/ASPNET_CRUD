using System.ComponentModel.DataAnnotations;

namespace Tsak.Dtos
{
    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public float Cost { get; set; }
        
        [Required]
        public float Price { get; set; }
    }
}