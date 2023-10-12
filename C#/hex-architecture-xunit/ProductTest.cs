using hex_architecture_class;

namespace hex_architecture_xunit;

public class ProductTest
{
    [Fact]
    public void IsValid_StatusBlank_ReturnFalse()
    {
        var product = new Product();
        var productModel = new ProductModel();
        productModel.Status = Status.Enabled;
        productModel.Price = 10;

        bool result = product.IsValid(productModel);

        Assert.True(result);
 
    }
}