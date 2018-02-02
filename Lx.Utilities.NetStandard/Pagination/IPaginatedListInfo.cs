namespace Lx.Utilities.NetStandard.Pagination {
    public interface IPaginatedListInfo : IPaginationInfo {
        int? PageCount { get; set; }
        long? ItemCount { get; set; }
    }
}