namespace dotnet_store.Models;

public class Slider
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string Image { get; set; } = null!;
    public int Index { get; set; }
    public bool IsActive { get; set; }

}