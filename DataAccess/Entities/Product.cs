using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    /*
     * DataAnnotations Attributes
     * Required
     * MaxLenght, MinLenght
     * Range
     * Phone
     * CreditCard
     * EmailAddress
     * Url
     * RegularExpression    
     
     */
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Fild is required"), MinLength(3)]
        public string Name { get; set; }

        [Range(0,double.MaxValue, ErrorMessage ="Price must be bigger than 0")]
        public decimal Price { get; set; }

        [Url]
        public string? ImagePath { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
