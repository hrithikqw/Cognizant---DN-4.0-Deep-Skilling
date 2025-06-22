public class Product
{
    public int ProductId { get; private set; }
    public string ProductName { get; private set; }
    public string Category { get; private set; }

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName ?? "Unnamed Product";
        Category = category ?? "General";
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}
