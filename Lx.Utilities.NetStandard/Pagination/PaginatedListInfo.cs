namespace Lx.Utilities.NetStandard.Pagination {
    public class PaginatedListInfo : PaginationInfo, IPaginatedListInfo {
        public int? PageCount { get; set; }
        public long? ItemCount { get; set; }
    }
}