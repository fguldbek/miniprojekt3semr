namespace minireddit.Model
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Content { get; set; }
        public int Votes { get; set; }
        public string? User { get; set; }

        public DateTime Date { get; set; }

        public Comment(string content, string user, int votes, DateTime date)
        {
            Content = content;
            User = user;
            Votes = votes;
            Date = date;

        }
        public Comment()
        {
        }

    }
}