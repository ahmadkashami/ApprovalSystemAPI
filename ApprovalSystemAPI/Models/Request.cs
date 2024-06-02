namespace ApprovalSystemAPI.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public string Description { get; set; }
        public int EmployeeId { get; set; }
        public int ApprovalTypeId { get; set; }
        public int? PreviousStepId { get; set; }
        public int? CurrentStepId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ApprovalType ApprovalType { get; set; }
        public virtual RequestStep PreviousStep { get; set; }
        public virtual RequestStep CurrentStep { get; set; }
    }
}
