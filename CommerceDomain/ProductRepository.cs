using System.Collections.Generic;

namespace Ploeh.Samples.Commerce.Domain
{
    public abstract class ProductRepository
    {
        public abstract IEnumerable<Product> GetFeaturedProducts();
    }
}
