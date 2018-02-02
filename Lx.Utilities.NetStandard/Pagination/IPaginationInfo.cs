namespace Lx.Utilities.NetStandard.Pagination {
    public interface IPaginationInfo {
        bool InDescendingOrder { get; set; }
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}