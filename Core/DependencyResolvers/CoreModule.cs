﻿using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Diagnostics;
=======
>>>>>>> test
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
           serviceCollection.AddMemoryCache();
           serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
           serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
<<<<<<< HEAD
           serviceCollection.AddSingleton<Stopwatch>();

=======
           //serviceCollection.AddSingleton<Stopwatch>();
>>>>>>> test
        }
    }
}
