public class Driverlicense
{
    public Guid Id {get;set;}
    public string Serial {get;set;}
    public DateTime IssueDate {get;set;}
    public DateTime ExpiryDate {get;set;}

    public virtual User Holder {get;set;}
}