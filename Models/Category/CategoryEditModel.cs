using System.ComponentModel.DataAnnotations;

namespace dotnet_store.Models;

public class CategoryEditModel
{
    public int Id { get; set; }
    [Display(Name = "Category Name")]
    public string CategoryName { get; set; } = null!;
    [Display(Name = "Url")]
    public string Url { get; set; } = null!;

}