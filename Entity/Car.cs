public class Car
{
    public Guid Id {get;set;}
    public string Brand {get;set;}
    public string Model {get;set;}
    public DateTime ManufacturedAt {get;set;}
    public string Color {get;set;}

    public Guid OWnerId {get;set;}
    public virtual User Owner {get;set;}
}