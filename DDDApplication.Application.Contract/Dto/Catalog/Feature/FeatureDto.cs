namespace DDDApplication.Application.Contract.Dto.Catalog.Feature;

public class FeatureDto
{
    public Guid   id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int order { get; set; }
}