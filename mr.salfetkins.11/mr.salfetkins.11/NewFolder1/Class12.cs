public class Product
{
    public string Name { get; set; }
    public Category ProductCategory { get; set; }

    public class Category
    {
        public string CategoryName { get; set; }
    }
}