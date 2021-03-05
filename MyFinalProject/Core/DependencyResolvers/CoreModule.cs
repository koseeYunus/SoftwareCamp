using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {           
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddMemoryCache(); // Redis'e geçtiğimizde bu kısma gerek kalmıyor.

            serviceCollection.AddSingleton<Stopwatch>(); // PerformanceAspect için kronometre eklendi.
        }
    }
}
