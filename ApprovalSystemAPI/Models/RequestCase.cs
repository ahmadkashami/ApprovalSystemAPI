namespace ApprovalSystemAPI.Models
{
    public class RequestCase
    {
        public int RequestCaseId { get; set; }
        public int RequestTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int ApprovalTypeId { get; set; }

        public virtual ApprovalType ApprovalType { get; set; }
    }
}
