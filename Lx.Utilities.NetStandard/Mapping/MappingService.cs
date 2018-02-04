using AutoMapper;
using Lx.Utilities.Contracts.Mapping;

namespace Lx.Utilities.NetStandard.Mapping {
    public class MappingService : IMappingService {
        protected readonly IMapper BackingMapper;

        public MappingService(IConfigurationProvider mapperConfiguration) {
            BackingMapper = new Mapper(mapperConfiguration);
        }

        public TDestination Map<TDestination>(object source) {
            var destination = BackingMapper.Map<TDestination>(source);
            return destination;
        }
    }
}