using AutoMapper;
using Nav.Application.Responses;
using Nav.Core.Entities;
using System;

namespace Nav.Application.Mappers
{
    public static  class StoreMapper 
    {
        //https://www.abhith.net/blog/using-automapper-in-a-net-core-class-library/
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<StoreMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
