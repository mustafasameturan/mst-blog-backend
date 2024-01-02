using MstBlog.Core.Models.Filter;

namespace MstBlog.Core.Models.Post;

public class ListPostFilterModel : FilterResponseModel<ListPostModel>
{
    public ListPostFilterModel(List<ListPostModel> data, int recordsTotal, int recordsFiltered) 
        : base(data, recordsTotal, recordsFiltered)
    {
    }
}