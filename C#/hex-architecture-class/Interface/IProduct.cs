namespace hex_architecture_class;

public interface IProduct
{
    public bool IsValid(ProductModel product);
    public void Enable();
	public void Disable();
	public string GetID();
	public string GetName();
	public string GetStatus();
	public float GetPrice();
	public void ChangePrice(float price);

}
