namespace hex_architecture_class;

public class Product : IProduct
{
    public bool IsValid(ProductModel product) 
    {
        if(product.Status.Equals(""))
        {
            product.Status = Status.Disabled;
        }
        
        if (product.Status != Status.Enabled && product.Status != Status.Disabled) 
        {
		    return false;
	    }

        if (product.Price < 0)
        {
		    return false;
	    }

        return true;
    }

    public void Enable() {}

    public void Disable() {}

    public string GetID() 
    {
        return "";
    }

    public string GetName()
    {
        return "";
    }

    public string GetStatus()
    {
        return "";
    }

    public float GetPrice()
    {
        return 0;
    }

    public void ChangePrice(float price) {}
}
