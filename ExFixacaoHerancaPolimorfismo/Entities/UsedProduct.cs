
using System.Globalization;
using System.Text;

namespace ExFixacaoHerancaPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct() 
        {
        }

        public UsedProduct (string name, double price, DateTime manufactureddate) : base(name, price)
        {
            ManuFactureDate = manufactureddate;
        }


        public override string PriceTag()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price.ToString("F2",CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date: ");
            sb.Append(ManuFactureDate.ToString("dd/MM/yyyy"));
            sb.Append(")");
       
            return sb.ToString();
        }

    }


}
