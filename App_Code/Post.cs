using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ThreadId { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public string ImageFile { get; set; }
    public int RepliedPostId { get; set; }
}