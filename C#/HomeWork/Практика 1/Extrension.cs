//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_.HomeWork._7_8;

//public static class ExtensionDictionary
//{
//    public static Dictionary<int, List<Album>> GroupByReleaseYear(this List<Album> albums)
//    {
//        // return albums.GroupBy(album => album.ReleaseYear).ToDictionary(g => g.Key, g => g.ToList());
//        var result = new Dictionary<int, List<Album>>();

//        foreach (var album in albums)
//        {
//            if (!result.ContainsKey(album.ReleaseYear))
//            {
//                result[album.ReleaseYear] = new List<Album>();
//            }
//            result[album.ReleaseYear].Add(album);
//        }
//        return result;
//    }
//    public static Dictionary<string, List<Album>> GroupByGenre(this List<Album> albums)
//    {
//        // return albums.GroupBy(album => album.Genre).ToDictionary(g => g.Key, g => g.ToList());
//        var result = new Dictionary<string, List<Album>>();

//        foreach (var album in albums)
//        {
//            if (!result.ContainsKey(album.Genre))
//            {
//                result[album.Genre] = new List<Album>();
//            }
//            result[album.Genre].Add(album);
//        }
//        return result;
//    }

//    public static Dictionary<string, List<Album>> GroupByArtist(this List<Album> albums)
//    {
//        //return albums.GroupBy(album => album.Artist).ToDictionary(g => g.Key, g => g.ToList());
//        var result = new Dictionary<string, List<Album>>();

//        foreach (var album in albums)
//        {
//            if (!result.ContainsKey(album.Artist))
//            {
//                result[album.Artist] = new List<Album>();
//            }
//            result[album.Artist].Add(album);
//        }
//        return result;
//    }
//}