using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void ProductID_7_ValidID()
        {
            // Arrange
            var product = new Product(7, "product1", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void ProductID_6_InvalidID()
        {
            // Arrange
            var product = new Product(6, "product1", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Product ID is Invalid."));
        }
        [Test]
        public void ProductID_8_ValidID()
        {
            // Arrange
            var product = new Product(8, "product1", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void ProductID_70000_ValidID()
        {
            // Arrange
            var product = new Product(70000, "product1", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void ProductID_70001_InvalidID()
        {
            // Arrange
            var product = new Product(70001, "product1", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Product ID is Invalid."));
        }

        [Test]
        public void ProductID_69999_ValidID()
        {
            // Arrange
            var product = new Product(69999, "product1", 500, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Price_7_ValidPrice()
        {
            // Arrange
            var product = new Product(500, "product1", 7, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Price_6_InvalidPrice()
        {
            // Arrange
            var product = new Product(500, "product1", 6, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Price is Invalid."));
        }

        [Test]
        public void Price_8_ValidPrice()
        {
            // Arrange
            var product = new Product(500, "product1",8, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Price_7000_ValidPrice()
        {
            // Arrange
            var product = new Product(500, "product1", 7000, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Price_7001_InvalidPrice()
        {
            // Arrange
            var product = new Product(500, "product1", 7001, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Price is Invalid."));
        }

        [Test]
        public void Price_6999_ValidPrice()
        {
            // Arrange
            var product = new Product(500, "product1", 6999, 500);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Stock_7_ValidStock()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 7);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Stock_6_InValidStock()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 6);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Stock is Invalid."));
        }

        [Test]
        public void Stock_8_ValidStock()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 8);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Stock_700001_InvalidStock()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 700001);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Stock is Invalid."));
        }

        [Test]
        public void Stock_700000_ValidStock()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 700000);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }

        [Test]
        public void Stock_699999_ValidStock()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 699999);

            // Act
            var result = product.ValidateProduct();

            // Assert
            Assert.That(result, Is.EqualTo("Valid Product."));
        }
        [Test]
        public void IncreaseStock_100_IncreaseStock()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 500);
            int increaseAmount = 100;

            // Act
            product.IncreaseStock(increaseAmount);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(600));
        }
        [Test]
        public void IncreaseStock_Zero_ThrowsException()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 500);
            int increaseAmount = 0;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.IncreaseStock(increaseAmount));
            Assert.That(result.Message, Is.EqualTo("Amount is less than 0"));
        }
        [Test]
        public void IncreaseStock_NegativeAmount_ThrowsException()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 500);
            int increaseAmount = -10;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.IncreaseStock(increaseAmount));
            Assert.That(result.Message, Is.EqualTo("Amount is less than 0"));
        }

        [Test]
        public void DecreaseStock_100_DecreaseStock()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 500);
            int decreaseAmount = 100;

            // Act
            product.DecreaseStock(decreaseAmount);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(400));
        }

        [Test]
        public void DecreaseStock_Zero_ThrowsException()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 500);
            int decreaseAmount = 0;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.DecreaseStock(decreaseAmount));
            Assert.That(result.Message, Is.EqualTo("Amount is less than 0"));
        }         

        [Test]
        public void DecreaseStock_NegativeAmount_ShouldThrowsException()
        {
            // Arrange
            var product = new Product(500, "product1", 500, 500);
            int decreaseAmount = -10;

            // Act & Assert
            var result = Assert.Throws<Exception>(() => product.DecreaseStock(decreaseAmount));
            Assert.That(result.Message, Is.EqualTo("Amount is less than 0"));
        }

        [Test]
        public void ProductName_SetName_IsCorrect()
        {
            // Arrange
            var product = new Product(6, "product1", 50, 500);

            // Act
            var result = product.ProductName;

            // Assert
            Assert.That(result, Is.EqualTo("product1"));
        }

        [Test]
        public void ProductName_Null_ThrowsException()
        {
            // Arrange, Act & Assert
            var result = Assert.Throws<Exception>(() => new Product(6, null, 50, 500));
            Assert.That(result.Message, Is.EqualTo("Product Name is null"));
        }

        [Test]
        public void ProductName_Empty_ThrowsException()
        {
            // Arrange, Act & Assert
            var result = Assert.Throws<Exception>(() => new Product(6, "", 50, 500));
            Assert.That(result.Message, Is.EqualTo("Product Name is null"));
        }

    }
}
