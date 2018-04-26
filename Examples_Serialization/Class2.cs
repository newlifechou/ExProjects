namespace HelloWorld
{
    public class Rootobject
    {
        public string id { get; set; }
        public string alt { get; set; }
        public Rating rating { get; set; }
        public Author[] author { get; set; }
        public string alt_title { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string mobile_link { get; set; }
        public string summary { get; set; }
        public Attrs attrs { get; set; }
        public Tag[] tags { get; set; }
    }

    public class Rating
    {
        public int max { get; set; }
        public string average { get; set; }
        public int numRaters { get; set; }
        public int min { get; set; }
    }

    public class Attrs
    {
        public string[] publisher { get; set; }
        public string[] pubdate { get; set; }
        public string[] author { get; set; }
        public string[] price { get; set; }
        public string[] title { get; set; }
        public string[] binding { get; set; }
        public string[] translator { get; set; }
        public string[] pages { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
    }

    public class Tag
    {
        public int count { get; set; }
        public string name { get; set; }
    }

}
