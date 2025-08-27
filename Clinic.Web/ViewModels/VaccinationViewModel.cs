namespace Clinic.Web.ViewModels;

public class VaccinationViewModel
{
    public string VaccineName { get; set; } = string.Empty;
    public string BatchNumber { get; set; } = string.Empty;
    public DateTime NextDueDate { get; set; } = DateTime.Today.AddYears(1);
}