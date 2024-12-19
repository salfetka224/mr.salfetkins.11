using System.Collections.Generic;
using System.Linq;

public class Products
{
    public string Name { get; set; }
    public List<Review> Reviews { get; set;  } = new List<Review>();

    public class Review
    {
        public string Reviewer { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }

    public double GetAverageRating()
    {
        return Reviews.Average(r => r.Rating);
    }
}
 