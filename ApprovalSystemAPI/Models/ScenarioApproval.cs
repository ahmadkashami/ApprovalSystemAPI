namespace ApprovalSystemAPI.Models
{
    public class ScenarioApproval
    {
        public int ScenarioApprovalId { get; set; }
        public int ApprovalTypeId { get; set; }
        public int LevelId { get; set; }
        public int ApproverId { get; set; }

        public virtual ApprovalType ApprovalType { get; set; }
        public virtual ApprovalLevel Level { get; set; }
        public virtual Employee Approver { get; set; }
    }
}
