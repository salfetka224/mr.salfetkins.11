public class Person
{
    public string Name { get; set; }
    public Address PersonAddress { get; set; }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}