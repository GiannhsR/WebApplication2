public class Post
{
	public int Id { get; set; }
    public List<Tag> Tags { get; } = new();
    public List<PostTag> PostTags { get; } = new();
}

public class Tag
{
	public int Id { get; set; }
    public List<Post> Posts { get; } = new();
    public List<PostTag> PostTags { get; } = new();
}

public class PostTag
{
	public int PostId { get; set; }
	public int TagId { get; set; }
	public string SomePayload { get; set; }
}