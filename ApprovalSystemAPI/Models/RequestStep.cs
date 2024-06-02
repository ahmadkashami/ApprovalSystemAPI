namespace ApprovalSystemAPI.Models
{
    public class RequestStep
    {
        public int StepId { get; set; }
        public int RequestId { get; set; }
        public int StepNumber { get; set; }
        public int StatusId { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? CompletedBy { get; set; }

        public virtual Request Request { get; set; }
        public virtual RequestStatus Status { get; set; }
        public virtual Employee CompletedByEmployee { get; set; }
    }
}
