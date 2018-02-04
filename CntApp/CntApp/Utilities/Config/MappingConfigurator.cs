using AutoMapper;
using CntApp.Domains.Contacts;

namespace CntApp.Utilities.Config
{
    public static class MappingConfigurator
    {
        public static MapperConfiguration CreateMapperConfiguration()
        {
            var config = new MapperConfiguration(SetMapperConfigurationExpression);

            return config;
        }

        private static void SetMapperConfigurationExpression(IMapperConfigurationExpression x)
        {
            x.CreateMissingTypeMaps = true;
            x.CreateMap<Contact, ContactPm>().ReverseMap();
        }
    }
}