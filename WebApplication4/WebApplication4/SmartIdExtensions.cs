using System;
using AspNetCore.Authentication.SK.SmartID.Helpers;
using AspNetCore.Authentication.SK.SmartID.SmartID;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication4
{
    public static class SmartIdExtensions
    {
      

        public static AuthenticationBuilder AddSmartId<TUser>(this AuthenticationBuilder builder,
            string serverCertificatePublicKey,
            Action<SmartIdOptions> configureOptions) where TUser : class =>
            builder.AddSmartId<TUser>(SmartIdDefaults.AuthenticationScheme, serverCertificatePublicKey, configureOptions);

        public static AuthenticationBuilder AddSmartId<TUser>(this AuthenticationBuilder builder, string authenticationScheme,
            string serverCertificatePublicKey,
            Action<SmartIdOptions> configureOptions) where TUser : class =>
            builder.AddSmartId<TUser>(authenticationScheme, SmartIdDefaults.DisplayName, serverCertificatePublicKey, configureOptions);

        public static AuthenticationBuilder AddSmartId<TUser>(this AuthenticationBuilder builder,
            string authenticationScheme, string displayName,
            string serverCertificatePublicKey,
            Action<SmartIdOptions> configureOptions) where TUser : class
        {
            builder.Services.AddHttpClient<SmartIdClient>(client => {})
                .ConfigurePrimaryHttpMessageHandler(() => new SmartIdHttpClientHandler(serverCertificatePublicKey));
            

            return builder.AddScheme<SmartIdOptions, SmartIdHandler>(authenticationScheme, displayName,
                configureOptions);
        }
    }
}