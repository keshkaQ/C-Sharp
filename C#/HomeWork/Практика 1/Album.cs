//using c_.homework._9_10;
//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace c_.homework._7_8;

//public class album
//{
//    public string title { get; }
//    public string artist { get; }
//    public string genre { get; }
//    public int releaseyear { get; }

//    public album(string title, string artist, string genre, int releaseyear)
//    {
//        validationhelper.validatenotnullorwhitespace(title, nameof(title));
//        validationhelper.validatenotnullorwhitespace(artist, nameof(artist));
//        validationhelper.validatenotnullorwhitespace(genre, nameof(genre));

//        title = title;
//        artist = artist;
//        genre = genre;
//        releaseyear = releaseyear;
//    }

//    public override string tostring()
//    {
//        return $"информация об альбоме: {title} - {artist} ({genre}, {releaseyear})";
//    }

//    public static bool operator ==(album album1, album album2)
//    {

//        return album1.title == album2.title && album1.releaseyear == album2.releaseyear;
//    }

//    public static bool operator !=(album album1, album album2)
//    {
//        return !(album1 == album2);
//    }
//    public override bool equals(object obj)
//    {
//        if (obj is album otheralbum)
//        {
//            return this == otheralbum;
//        }
//        return false;
//    }

//    public override int gethashcode()
//    {
//        return hashcode.combine(title, releaseyear);
//    }
//}