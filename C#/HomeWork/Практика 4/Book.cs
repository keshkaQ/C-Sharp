using System.Text.Json.Serialization;

public class Book
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("author")]
    public string Author { get; set; }
    [JsonPropertyName("publishedDate")]
    public DateTime PublishedDate { get; set; }
    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Date: {PublishedDate.ToString()}";
    }
   // public List<Book> SomeBooks { get; set; } //  свойство для вызова циклической ссылки для того, чтобы не получилось сериализация
}