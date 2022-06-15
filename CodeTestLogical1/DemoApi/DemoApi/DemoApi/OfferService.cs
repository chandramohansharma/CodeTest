namespace DemoApi
{
    public class OfferService
    {
        Product product = new Product();
        Offer offer = new Offer();
        public OfferService(Product _product)
        {
            this.product = _product;
           
        }
        public List<Product> ListOfProducts()
        {
            List<Product> products = new List<Product>
                {
                    new Product { ProductName = "P1", ProductPrice = 1000,, ProductDescription = "P1 Desc" },
                    new Product { ProductName = "P2", ProductPrice = 2000,, ProductDescription = "P2 Desc" },
                    new Product { ProductName = "P3", ProductPrice = 3000,, ProductDescription = "P3 Desc" },
                };
   
            return products;
        }
    }
}
