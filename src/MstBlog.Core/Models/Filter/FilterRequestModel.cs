namespace MstBlog.Core.Models.Filter;

public class FilterRequestModel
{
    public int Start { get; set; }
    public int Limit { get; set; }
    public string Search { get; set; }
}