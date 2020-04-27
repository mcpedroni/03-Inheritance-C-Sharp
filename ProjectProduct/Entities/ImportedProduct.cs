using System.Globalization;

namespace ProjectProduct.Entities {

    class ImportedProduct : Product {

        public double customsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            this.customsFee = customsFee;
        }

        public override string PriceTag() {
            return name + " $ " + (price + customsFee).ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + customsFee + ")"; 
        }
    }
}
