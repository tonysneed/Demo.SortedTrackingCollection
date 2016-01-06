using System.Linq;
using System.Linq.Dynamic;
using TrackableEntities.Client;
using Xunit;

namespace Demo.SortedTrackingCollection
{
    public class ChangeTrackingCollectionTests
    {
        [Fact]
        public void Can_sort_ChangeTrackingCollection_using_dynamic_linq()
        {
            // Arrange
            var product1 = new Product {Id = 1, ProductName = "Espresso"};
            var product2 = new Product { Id = 1, ProductName = "Chai" };
            var changeTracker = new ChangeTrackingCollection<Product>(product1, product2);
            var queryable = changeTracker.AsQueryable().OrderBy("ProductName asc");

            // Act
            var sortedEntities = queryable.ToList();

            // Assert
            Assert.Equal("Chai", sortedEntities.ElementAt(0).ProductName);
            Assert.Equal("Espresso", sortedEntities.ElementAt(1).ProductName);
        }
    }
}
