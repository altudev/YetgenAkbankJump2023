using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using YetGenAkbankJump.Shared.Utilities;

namespace YetGenAkbankJump.Shared
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSharedServices(this IServiceCollection services)
        {
            services.AddSingleton<IDGenerator>();

            return services;
        }
    }
}
