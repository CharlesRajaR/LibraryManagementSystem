public class Book{
	public string Id { get; }
	public string Title { get; }
	public string Author { get; }
	public int PublicationYear { get; }
	public bool IsAvailable { get; set; }

	public Book(string id, string title, string author, int publicationYear, bool isAvailable ){
	   Id = id;
	   Title = title;
	   Author = author;
	   PublicationYear = publicationYear;
	   IsAvailable = isAvailable;
	}
}