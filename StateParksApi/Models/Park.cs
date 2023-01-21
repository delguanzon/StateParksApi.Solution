namespace StateParksApi.Models;

public class Park
{
    public int Id { get; set; }
    public string ParkId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int Rating { get; set; }
}