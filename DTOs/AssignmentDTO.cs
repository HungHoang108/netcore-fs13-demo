namespace NETCoreDemo.DTOs;

using NETCoreDemo.Models;

public class AssignmentDTO : BaseDTO<Assignment>
{
    public DateTime Deadline { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public override void UpdateModel(Assignment model)
    {
        // TODO: Implement this
    }
}