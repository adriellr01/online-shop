//using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Core.Entities
{

    public class Payment
{
    
    [Key]
    public long Id { get; set; }

	public DateTime Date { get; set; }
	[Required]

	public decimal Aumont { get; set; }
	[Required]

	public bool Billed { get; set; }
	[Required]
	public bool Refunded { get; set; }
	[Required]
	public string Productids { get; set; }
	[MaxLength(256)]
	
	public long? OrderId { get; set; }

        //public ICollection <Product> products { get; set}






    }
}
