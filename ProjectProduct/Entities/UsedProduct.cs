using System;
using System.Globalization;

namespace ProjectProduct.Entities {

    class UsedProduct : Product {

        public DateTime manufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            this.manufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            return name + " (used) $ " + price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date:  " + manufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
