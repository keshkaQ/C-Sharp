using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Threading;
using C_.HomeWork._9_10;
using C_.HomeWork._7_8;

class Program
{
    static void Main()
    {
        var collection = new MusicCollection();

        //Создаем тестовые альбомы
        var album1 = new Album("Album1", "Artist1", "Rock", 2000);
        var album2 = new Album("Album2", "Artist2", "Pop", 1980);
        var album3 = new Album("Album3", "Artist3", "Сlassical", 1986);
        var album4 = new Album("Album4", "Artist4", "Jazz", 1979);
        var album5 = new Album("Album5", "Artist1", "Pop", 1987);

        //Добавляем альбомы в коллекцию
        Console.WriteLine("Добавляем альбомы.");
        collection.AddAlbum(album1);
        collection.AddAlbum(album2);
        collection.AddAlbum(album3);
        collection.AddAlbum(album4);
        collection.AddAlbum(album5);

        // Попытка добавить дубликат
        Console.WriteLine("\nПопытка добавить существующий альбом:");
        var duplicate = new Album("Album1", "Artist1", "Rock", 2000);
        collection.AddAlbum(duplicate);

        // Удаление альбома
        Console.WriteLine("\nУдаляем 'Album4':");
        collection.RemoveAlbum("Album4", 1979);

        // Проверка индексатора
        Console.WriteLine("\nПроверка индексатора [0]:");
        Console.WriteLine(collection[0]);

        // Поиск по исполнителю
        Console.WriteLine("\nАльбомы Artist1:");
        var artistAlbums = collection.FindAlbumsByArtist("Artist1");
        foreach (var album in artistAlbums)
        {
            Console.WriteLine(album);
        }

        // Поиск по жанру
        Console.WriteLine("\nПоп-альбомы:");
        var popAlbums = collection.GetAlbumsByGenre("Pop");
        foreach (var album in popAlbums)
        {
            Console.WriteLine(album);
        }

        // Получение альбома по названию
        Console.WriteLine("\nПоиск альбома 'Album1':");
        Console.WriteLine(collection.GetAlbumByTitle("Album1"));

        // Сортировка по году выпуска
        Console.WriteLine("\nАльбомы, отсортированные по году:");
        List<Album> sortedAlbums = collection.SortAlbumsByReleaseYear();
        foreach (var album in sortedAlbums)
        {
            Console.WriteLine($"{album.ReleaseYear} год: {album.Title}");
        }

        // Группировка альбомов по году, используя метод расширения
        Console.WriteLine("\nГруппировка альбомов по году:");
        Dictionary<int, List<Album>> albumsByYear = sortedAlbums.GroupByReleaseYear();

        // Выводим результат
        foreach (var year in albumsByYear)
        {
            Console.WriteLine($"\nГод : {year.Key}");
            foreach (var album in year.Value)
            {
                Console.WriteLine($"{album.Title} - {album.Artist}");
            }
        }

        // Группировка альбомов по жанру, используя метод расширения
        Console.WriteLine("\nГруппировка альбомов по жанру:");
        Dictionary<string, List<Album>> albumsByGenre = sortedAlbums.GroupByGenre();

        // Выводим результат
        foreach (var genre in albumsByGenre)
        {
            Console.WriteLine($"\nЖанр : {genre.Key}");
            foreach (var album in genre.Value)
            {
                Console.WriteLine($"{album.Title} - {album.Artist}");
            }
        }

        // Группировка альбомов по артисту, используя метод расширения
        Console.WriteLine("\nГруппировка альбомов по артисту:");
        Dictionary<string, List<Album>> albumsByArtist = sortedAlbums.GroupByArtist();

        // Выводим результат
        foreach (var artist in albumsByArtist)
        {
            Console.WriteLine($"\nАртист : {artist.Key}");
            foreach (var album in artist.Value)
            {
                Console.WriteLine($"{album.Title} - {album.Artist}");
            }
        }

        // Попытка удалить несуществующий альбом
        Console.WriteLine("\nУдаляем 'Album6':");
        collection.RemoveAlbum("Album6", 2000);
    }
}
public class AlbumNotFoundException : Exception
{
    public AlbumNotFoundException(Album album) : base($"Альбом с названием {album.Title} и годом выпуска {album.ReleaseYear} не был найден в коллекции")
    {
    }
}


