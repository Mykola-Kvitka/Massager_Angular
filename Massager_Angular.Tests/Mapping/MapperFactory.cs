using AutoMapper;
using Massager_Angular.Tests;

namespace Massager_Angular.Tests.Mapping
{
    public static class MapperFactory
    {
        private static readonly Mapper _mapper;

        static MapperFactory()
        {
            var configuration = new MapperConfiguration(options =>
                options.AddMaps(typeof(Startup).Assembly));
        }

        public static IMapper InitMapper()
        {
            return _mapper;
        }
    }
}
