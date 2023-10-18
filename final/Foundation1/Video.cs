public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> comments;

    public int NumberOfComments(){
        return comments.Count;
    }
}