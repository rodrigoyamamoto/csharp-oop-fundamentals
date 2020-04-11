namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Saves the current Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call as Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }

        /// <summary>
        /// Retrieve one Product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested id

            Product product = new Product(productId);

            // Code that retrieves the defined product

            // Temporary hard-coded values to return
            // a popular product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }
    }
}
