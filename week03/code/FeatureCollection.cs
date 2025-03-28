using System.ComponentModel;
using System.Dynamic;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string type { get; set; } = "FeatureCollection";
    public long generated { get; set; }
    public string url { get; set; }
    public string title { get; set; }
    public string api { get; set; }
    public int count { get; set; }
    public int status { get; set; }
    public List<Feature> features { get; set; }
}

public class Feature
{
    public string type { get; set; } = "Feature";
    public Informations properties { get; set; }
    public Geometry geometry { get; set; }
}

public class Informations
{
    public double mag { get; set; }
    public string place { get; set; }
}

public class Geometry
{
    public string type { get; set; } = "Point";
    public List<double> coordinates { get; set; } // [longitude, latitude, depth]
} 