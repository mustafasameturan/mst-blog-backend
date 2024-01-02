namespace MstBlog.Core.Models.Filter;

public class FilterResponseModel<T> where T : class
{
    public FilterResponseModel(List<T> data, int recordsTotal, int recordsFiltered)
    {
        Data = data;
        RecordsTotal = recordsTotal;
        RecordsFiltered = recordsFiltered;
    }
    
    public int RecordsTotal { get; set; }
    public int RecordsFiltered { get; set; }
    public List<T> Data { get; set; }
}