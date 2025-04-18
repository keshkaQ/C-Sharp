using C_.HomeWork._9_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.HomeWork._7_8;

public class Album
{
    public string Title { get; }
    public string Artist { get; }
    public string Genre { get; }
    public int ReleaseYear { get; }

    public Album(string title, string artist, string genre, int releaseYear)
    {
        ValidationHelper.ValidateNotNullOrWhiteSpace(title, nameof(title));
        ValidationHelper.ValidateNotNullOrWhiteSpace(artist, nameof(artist));
        ValidationHelper.ValidateNotNullOrWhiteSpace(genre, nameof(genre));

        Title = title;
        Artist = artist;
        Genre = genre;
        ReleaseYear = releaseYear;
    }

    public override string ToString()
    {
        return $"Информация об альбоме: {Title} - {Artist} ({Genre}, {ReleaseYear})";
    }

    public static bool operator ==(Album album1, Album album2)
    {

        return album1.Title == album2.Title && album1.ReleaseYear == album2.ReleaseYear;
    }

    public static bool operator !=(Album album1, Album album2)
    {
        return !(album1 == album2);
    }
    public override bool Equals(object obj)
    {
        if (obj is Album otherAlbum)
        {
            return this == otherAlbum;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, ReleaseYear);
    }
}