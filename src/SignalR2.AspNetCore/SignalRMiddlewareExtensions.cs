namespace SignalR2.AspNetCore
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Owin.Builder;
    using Owin;

    public static class SignalRMiddlewareExtensions
    {
        public static IApplicationBuilder UseSignalR2(this IApplicationBuilder app)
        {
            app.UseOwin(configure =>
            {
                configure(next =>
                {
                    var appBuilder = new AppBuilder();
                    appBuilder.Properties["builder.DefaultApp"] = next;

                    appBuilder.MapSignalR();

                    return appBuilder.Build<Func<IDictionary<string, object>, Task>>();
                });
            });

            return app;
        }
    }
}
