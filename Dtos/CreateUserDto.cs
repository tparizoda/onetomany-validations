using System.ComponentModel.DataAnnotations;

public class CreateUserDto
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Required(ErrorMessage ="Date is required")]
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; }

    [Range (15,45,ErrorMessage ="Email should have maximum 45, minimum 15 items")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }
}