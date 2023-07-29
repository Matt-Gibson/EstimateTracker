using System.ComponentModel.DataAnnotations;
namespace EstimateTracker.Data.Models;

public class Estimate : DataItemBase
{
    [Required]
    public DateOnly DateCreated { get; set; }

    [Required]
    public DateOnly DateUpdated { get; set; }

    [Required]
    [StringLength(50)]
    public String JobType { get; set; } = "";

    [Required]
    [StringLength(20)]
    [MinLength(2)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    [MinLength(2)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string PhoneNumber { get; set; } = string.Empty;

    public bool IsRush { get; set; } = false;
}


