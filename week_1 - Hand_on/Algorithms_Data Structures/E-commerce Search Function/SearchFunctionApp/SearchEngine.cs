using System;

public static class SearchEngine
{
    public static Product LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (string.Equals(product.ProductName, name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] sortedProducts, int productId)
    {
        int left = 0, right = sortedProducts.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int currentId = sortedProducts[mid].ProductId;

            if (currentId == productId)
                return sortedProducts[mid];
            else if (currentId < productId)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}
