namespace Web.UI.Server.Models.Categories;

public class CategoryDetail
{
    public string Name { get; set; } = null!;
    public string Lab { get; set; } = null!;
    public string Id { get; set; } = null!;
    public bool IsActive { get; set; }
    public string LabId { get; set; } = null!;

}
public class Category
{
    public  string Name { get; set; } = null!;
    public string LabId { get; set; } = null!;
}


