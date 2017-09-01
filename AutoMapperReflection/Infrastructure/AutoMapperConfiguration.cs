using AutoMapper;
using AutoMapperCommon.Infrastructure;
using System;
using System.Linq;

namespace AutoMapperReflection.Infrastructure
{
    public class AutoMapperConfiguration
    {
        public IMapper Configure()
        {
            var profiles = AppDomain.CurrentDomain.GetAssemblies()
              .SelectMany(s => s.GetTypes())
              .Where(a => typeof(AutoMapperProfile).IsAssignableFrom(a));

            // Initialize AutoMapper with each instance of the profiles found.
            var mapperConfiguration = new MapperConfiguration(a => profiles.ForEach(a.AddProfile));

            return mapperConfiguration.CreateMapper();
        }
    }
}