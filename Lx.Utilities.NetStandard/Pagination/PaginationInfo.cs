namespace Lx.Utilities.NetStandard.Pagination {
    public class PaginationInfo : IPaginationInfo {
        public bool InDescendingOrder { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}