using System.ComponentModel.DataAnnotations;

public class CreateDriverLicenseDto
{
    [Required(ErrorMessage = "The Serial field is required.")]
    [StringLength(15, ErrorMessage = "The Serial field must not exceed 15 chars.")]
    public string Serial { get; set; }

    [Required(ErrorMessage = "The IssueDate field is required.")]
    [DataType(DataType.Date)]
    [IssueDateTrue(ErrorMessage = "The IssueDate must not be a future date.")]
    public DateTime IssueDate { get; set; }

    [Required(ErrorMessage = "The ExpiryDate field is required.")]
    [DataType(DataType.Date)]
    [ExpiryDateTrue(ErrorMessage = "The IssueDate must be a future date.")]
    public DateTime ExpiryDate { get; set; }
}
