using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Name { get; set; }      // [Required(ErrorMessage ="Fild is required"), MinLength(3)]
        public decimal Price { get; set; }        //[Range(0,double.MaxValue, ErrorMessage ="Price must be bigger than 0")]
        public string? ImagePath { get; set; }        //[Url]
        public Category? Category { get; set; }    
        public int CategoryId { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
