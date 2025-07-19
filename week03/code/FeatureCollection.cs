public class FeatureCollection
{
    public Feature[] Features { get; set; } // Array of Feature objects

    public class Feature // Class representing each earthquake feature
    {
        public Properties Properties { get; set; }
    }

    public class Properties // Class representing properties of each earthquake
    {
        public string Place { get; set; }
        public double Mag { get; set; }
    }
}
