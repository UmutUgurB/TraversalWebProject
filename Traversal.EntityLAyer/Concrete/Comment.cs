namespace Traversal.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string UserName { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }
        public bool CommentIsActive { get; set; }

        public int DestinationID { get; set; }
        public Destination Destination { get; set; }

    }
}
