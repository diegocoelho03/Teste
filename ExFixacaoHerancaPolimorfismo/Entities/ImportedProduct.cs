using System.Globalization;
using System.Security.AccessControl;
using System.Text;

namespace ExFixacaoHerancaPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price) 
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Customs fee: $ ");
            sb.Append(CustomFee.ToString("F2",CultureInfo.InvariantCulture));
            sb.Append(")");

            return sb.ToString();   
        }
    }
}
