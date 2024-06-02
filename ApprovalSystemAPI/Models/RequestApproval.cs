namespace ApprovalSystemAPI.Models
{
    public class RequestApproval
    {
        public int RequestApprovalId { get; set; }
        public int RequestId { get; set; }
        public int ApprovalLevelId { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string Status { get; set; }

        public virtual Request Request { get; set; }
        public virtual ApprovalLevel ApprovalLevel { get; set; }
    }
}
