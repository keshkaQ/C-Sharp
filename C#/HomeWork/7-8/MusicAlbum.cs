//using System.Collections.Generic;
//using System.Diagnostics;
//using System;
//using System.Collections.Generic;
//using System.Threading;

//class Program
//{
//    static void Main()
//    {
//        var collection = new MusicCollection();

//        //Создаем тестовые альбомы
//        var album1 = new Album("Album1", "Artist1", "Rock", 2000);
//        var album2 = new Album("Album2", "Artist2", "Pop", 1980);
//        var album3 = new Album("Album3", "Artist3", "Сlassical", 1986);
//        var album4 = new Album("Album4", "Artist4", "Jazz", 1979);
//        var album5 = new Album("Album5", "Artist1", "Pop", 1987);

//        //Добавляем альбомы в коллекцию
//        Console.WriteLine("Добавляем альбомы.");
//        collection.AddAlbum(album1);
//        collection.AddAlbum(album2);
//        collection.AddAlbum(album3);
//        collection.AddAlbum(album4);
//        collection.AddAlbum(album5);

//        // Попытка добавить дубликат
//        Console.WriteLine("\nПопытка добавить существующий альбом:");
//        var duplicate = new Album("Album1", "Artist1", "Rock", 2000);
//        collection.AddAlbum(duplicate);

//        // Удаление альбома
//        Console.WriteLine("\nУдаляем 'Album4':");
//        collection.RemoveAlbum("Album4", 1979);

//        // Проверка индексатора
//        Console.WriteLine("\nПроверка индексатора [0]:");
//        Console.WriteLine(collection[0]);

//        // Поиск по исполнителю
//        Console.WriteLine("\nАльбомы Artist1:");
//        var artistAlbums = collection.FindAlbumsByArtist("Artist1");
//        foreach (var album in artistAlbums)
//        {
//            Console.WriteLine(album);
//        }

//        // Поиск по жанру
//        Console.WriteLine("\nПоп-альбомы:");
//        var popAlbums = collection.GetAlbumsByGenre("Pop");
//        foreach (var album in popAlbums)
//        {
//            Console.WriteLine(album);
//        }

//        // Получение альбома по названию
//        Console.WriteLine("\nПоиск альбома 'Album1':");
//        Console.WriteLine(collection.GetAlbumByTitle("Album1"));

//        // Сортировка по году выпуска
//        Console.WriteLine("\nАльбомы, отсортированные по году:");
//        List<Album> sortedAlbums = collection.SortAlbumsByReleaseYear();
//        foreach (var album in sortedAlbums)
//        {
//            Console.WriteLine($"{album.ReleaseYear} год: {album.Title}");
//        }

//        // Группировка альбомов по году, используя метод расширения
//        Console.WriteLine("\nГруппировка альбомов по году:");
//        Dictionary<int, List<Album>> albumsByYear = sortedAlbums.GroupByReleaseYear();

//        // Выводим результат
//        foreach (var year in albumsByYear)
//        {
//            Console.WriteLine($"\nГод : {year.Key}");
//            foreach (var album in year.Value)
//            {
//                Console.WriteLine($"{album.Title} - {album.Artist}");
//            }
//        }

//        // Группировка альбомов по жанру, используя метод расширения
//        Console.WriteLine("\nГруппировка альбомов по жанру:");
//        Dictionary<string, List<Album>> albumsByGenre = sortedAlbums.GroupByGenre();

//        // Выводим результат
//        foreach (var genre in albumsByGenre)
//        {
//            Console.WriteLine($"\nЖанр : {genre.Key}");
//            foreach (var album in genre.Value)
//            {
//                Console.WriteLine($"{album.Title} - {album.Artist}");
//            }
//        }

//        // Группировка альбомов по артисту, используя метод расширения
//        Console.WriteLine("\nГруппировка альбомов по артисту:");
//        Dictionary<string, List<Album>> albumsByArtist = sortedAlbums.GroupByArtist();

//        // Выводим результат
//        foreach (var artist in albumsByArtist)
//        {
//            Console.WriteLine($"\nАртист : {artist.Key}");
//            foreach (var album in artist.Value)
//            {
//                Console.WriteLine($"{album.Title} - {album.Artist}");
//            }
//        }

//        // Попытка удалить несуществующий альбом
//        Console.WriteLine("\nУдаляем 'Album6':");
//        collection.RemoveAlbum("Album6", 2000);
//    }
//}

//public class Album
//{
//    public string Title { get; }
//    public string Artist { get; }
//    public string Genre { get; }
//    public int ReleaseYear { get; }

//    public Album(string title, string artist, string genre, int releaseYear)
//    {
//        if (string.IsNullOrWhiteSpace(title))
//        {
//            throw new ArgumentNullException(nameof(title), "Название альбома не может быть пустым.");
//        }

//        if (string.IsNullOrWhiteSpace(artist))
//        {
//            throw new ArgumentNullException(nameof(artist), "Имя артиста не может быть пустым.");
//        }

//        if (string.IsNullOrWhiteSpace(genre))
//        {
//            throw new ArgumentNullException(nameof(genre), "Жанр не может быть пустым.");
//        }

//        Title = title;
//        Artist = artist;
//        Genre = genre;
//        ReleaseYear = releaseYear;
//    }

//    public override string ToString()
//    {
//        return $"Информация об альбоме: {Title} - {Artist} ({Genre}, {ReleaseYear})";
//    }

//    public static bool operator ==(Album album1, Album album2)
//    {

//        return album1.Title == album2.Title && album1.ReleaseYear == album2.ReleaseYear;
//    }

//    public static bool operator !=(Album album1, Album album2)
//    {
//        return !(album1 == album2);
//    }
//}

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
//        if (album is null)
//        {
//            throw new ArgumentNullException(nameof(album), "Альбом не может быть пустым.");
//        }

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
//        if (string.IsNullOrWhiteSpace(title))
//        {
//            throw new ArgumentNullException(nameof(title), "Название не может быть пустым.");
//        }

//        bool albumFound = false;
//        Album albumToRemove = null;
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
//        if (string.IsNullOrWhiteSpace(artist))
//        {
//            throw new ArgumentNullException(nameof(artist), "Имя артиста не может быть пустым.");
//        }

//        var result = new List<Album>();

//        if (albumsByArtist.ContainsKey(artist))
//        {
//            foreach (var album in albumsByArtist[artist])
//            {
//                result.Add(album);
//            }
//        }
//        if (result.Count == 0)
//        {
//            throw new Exception($"Альбомы {artist} не найдены в коллекции.");
//        }

//        return result;
//    }
//    public Album GetAlbumByTitle(string title)
//    {
//        if (string.IsNullOrWhiteSpace(title))
//        {
//            throw new ArgumentNullException(nameof(title), "Название не может быть пустым.");
//        }
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
//        if (string.IsNullOrWhiteSpace(genre))
//        {
//            throw new ArgumentNullException(nameof(genre), "Жанр не может быть пустым.");
//        }

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

//public class AlbumNotFoundException : Exception
//{
//    public AlbumNotFoundException(Album album) : base($"Альбом с названием {album.Title} и годом выпуска {album.ReleaseYear} не был найден в коллекции")
//    {
//    }
//}

//public static class ExtensionDictionary
//{
//    public static Dictionary<int, List<Album>> GroupByReleaseYear(this List<Album> albums)
//    {
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


