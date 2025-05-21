//using C_.HomeWork._9_10;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_.HomeWork._7_8;

//public class MusicCollection
//{
//    private List<Album> albums;
//    private Dictionary<string, List<Album>> albumsByArtist;
//    private HashSet<string> uniqueAlbums;

//    public MusicCollection()
//    {
//        albums = new List<Album>();
//        albumsByArtist = new Dictionary<string, List<Album>>();
//        uniqueAlbums = new HashSet<string>();
//    }

//    public Album this[int index]
//    {
//        get
//        {
//            if (index < 0 || index >= albums.Count)
//            {
//                throw new IndexOutOfRangeException("Index is out of range.");
//            }
//            return albums[index];
//        }
//        set
//        {
//            if (index < 0 || index >= albums.Count)
//            {
//                throw new IndexOutOfRangeException("Index is out of range.");
//            }
//            albums[index] = value;
//        }
//    }

//    public void AddAlbum(Album album)
//    {
//        ValidationHelper.ValidateNotNull(album, nameof(album));
//        if (uniqueAlbums.Add(album.Title))
//        {
//            albums.Add(album);

//            if (!albumsByArtist.ContainsKey(album.Artist))
//            {
//                albumsByArtist[album.Artist] = new List<Album>();
//            }

//            albumsByArtist[album.Artist].Add(album);
//        }
//        else
//        {
//            Console.WriteLine("Альбом с таким названием уже существует.");
//        }
//    }
//    public void RemoveAlbum(string title, int releaseYear)
//    {
//        ValidationHelper.ValidateNotNullOrWhiteSpace(title, nameof(title));

//        bool albumFound = false;
//        Album albumToRemove = null;
//        //Album albumToRemove = albums.First(album => album.Title == title && album.ReleaseYear == releaseYear);
//        string artistOfAlbum = null;

//        foreach (var album in albums)
//        {
//            if (album.Title == title && album.ReleaseYear == releaseYear)
//            {
//                albumFound = true;
//                albumToRemove = album;
//                artistOfAlbum = album.Artist;
//                break;
//            }
//        }

//        if (!albumFound)
//        {
//            throw new AlbumNotFoundException(new Album(title, "Not found", "Not found", releaseYear));
//        }

//        albums.Remove(albumToRemove);

//        if (albumsByArtist.ContainsKey(artistOfAlbum))
//        {
//            var artistAlbums = albumsByArtist[artistOfAlbum];
//            artistAlbums.Remove(albumToRemove);

//            if (artistAlbums.Count == 0)
//            {
//                albumsByArtist.Remove(artistOfAlbum);
//            }
//        }

//        uniqueAlbums.Remove(title);

//        Console.WriteLine($"Альбом с названием {title} и годом выпуска {releaseYear} удален");
//    }


//    public List<Album> FindAlbumsByArtist(string artist)
//    {
//        ValidationHelper.ValidateNotNullOrWhiteSpace(artist, nameof(artist));

//        if (!albumsByArtist.ContainsKey(artist))
//        {
//            throw new Exception($"Альбомы {artist} не найдены в коллекции.");
//        }

//        return albumsByArtist[artist];
//    }
//    public Album GetAlbumByTitle(string title)
//    {
//        ValidationHelper.ValidateNotNullOrWhiteSpace(title, nameof(title));
//        //Album album = albums.First(album => album.Title == title);
//        foreach (var album in albums)
//        {
//            if (album.Title == title)
//            {
//                return album;
//            }
//        }

//        throw new AlbumNotFoundException(new Album(title, "Not Found", "Not Found", 0));
//    }

//    public List<Album> GetAlbumsByGenre(string genre)
//    {
//        ValidationHelper.ValidateNotNullOrWhiteSpace(genre, nameof(genre));
//        //return albums.Where(album => album.Genre == genre).ToList();

//        var result = new List<Album>();

//        foreach (var album in albums)
//        {
//            if (album.Genre == genre)
//            {
//                result.Add(album);
//            }
//        }

//        return result;
//    }
//    public List<Album> SortAlbumsByReleaseYear()
//    {
//        //return albums.OrderBy(album => album.ReleaseYear).ToList();

//        List<Album> sortedAlbums = new List<Album>(albums);

//        for (int i = 0; i < sortedAlbums.Count - 1; i++)
//        {
//            for (int j = 0; j < sortedAlbums.Count - i - 1; j++)
//            {
//                if (sortedAlbums[j].ReleaseYear > sortedAlbums[j + 1].ReleaseYear)
//                {
//                    Album temp = sortedAlbums[j];
//                    sortedAlbums[j] = sortedAlbums[j + 1];
//                    sortedAlbums[j + 1] = temp;
//                }
//            }
//        }
//        return sortedAlbums;
//    }
//}

