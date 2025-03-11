namespace minireddit.Model
{
    public class Post
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }

        public int Votes { get; set; }

        public string? User { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public DateTime Date { get; set; }

        public Post(string title, string content, string user, int votes, DateTime date, List<Comment> comments)
        {
            Title = title;
            Content = content;
            User = User;
            Votes = votes;
            Date = date;
            Comments = comments;
        }
        public Post()
        {
        }
    }
}