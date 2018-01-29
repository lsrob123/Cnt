namespace Lx.Utilities.Contracts.Mapping {
    public interface IMappingService {
        TDestination Map<TDestination>(object source);
    }
}