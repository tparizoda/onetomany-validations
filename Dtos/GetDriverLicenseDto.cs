public class GetDriverLicenseDto
{
    public GetDriverLicenseDto(Driverlicense entity)
    {
        Id = entity.Id;
        Serial = entity.Serial;
        IssuedDate = entity.IssueDate;
        ExpirationDate = entity.ExpiryDate;
    }

    public Guid Id { get; set; }
    public string Serial { get; set; }
    public DateTime IssuedDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsExpired => ExpirationDate < DateTime.UtcNow;
}