using System.ComponentModel.DataAnnotations;

public class ExpiryDateTrue : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value is DateTime date)
        {
            if (date > DateTime.Now)
                return true;

            else 
            {
                ErrorMessage = "Issue date should be in future time";
                return false;
            }
        }
        else
        {
            ErrorMessage = "IssuedDate should be DateTime type.";
            return false;
        }

        
    }
}