namespace Domain.Filters;

public class MovieFilter: PaginationFilter
{

    public string? Name { get; set; }
    public int? Category { get; set; }
    public MovieFilter():base()
    {
        
    }
    public MovieFilter(string name, int pageNumber, int pageSize) :base(pageNumber,pageSize)
    {
        
    }
}

