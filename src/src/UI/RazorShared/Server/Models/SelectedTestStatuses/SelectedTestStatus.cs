using RazorShared.Server.Enums;
namespace RazorShared.Server.Models.SelectedTestStatuses;
public class SelectedTestStatus
{
    public string TransactionNumber { get; set; } = null!;
    public TestStatus TestStatus { get; set; }
    public string? LastModifiedBy { get; set; }
}

public class UpdateAssignedUser
{
    public string TransactionNumber { get; set; } = null!;
    public   string? AssignedUser { get; set; }
}
public class UpdateSelectedTestSample
{
    public string? TransactionNumber { get; set; } = null!;
    public bool IsSampleTaken { get; set; }
}

