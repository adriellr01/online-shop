namespace OnlineShop.Entities
{ 
public class card
{

		public int Id { get; set; }
	public int nro { get; set; }

	public int tipoid { get; set; }  //tipo de tarjeta(visa, metropolitano, etc)
		                             //este tipo es llave foranea 
									 //hay que crear un nomenclador para ese tipo de tarjeta

		public bool vigente { get; set; }  //saber si la tarjeta esta activa
	}
}
