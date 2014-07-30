using System.Collections.Generic;
using System.Linq;

namespace Ploeh.Samples.Commerce.Data.Sql {
    public class SqlProductRepository : Domain.ProductRepository {
        private readonly CommerceObjectContext context;

        public SqlProductRepository(string connString) {
            this.context = new CommerceObjectContext(connString);
        }

        public override IEnumerable<Domain.Product> GetFeaturedProducts() {
            var products = (from p in this.context.Products
                            where p.IsFeatured
                            select p).AsEnumerable();
            return from p in products
                   select p.ToDomainProduct();
        }
    }
}
