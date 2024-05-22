// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace IdentityServerAspNetIdentity
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                    new IdentityResources.OpenId(),
                    new IdentityResources.Profile(),
            
                   };
        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource("Web2Api", "Events.API")
                {
                    Scopes =
                    {
                        "web2ApiScope"
                    }
                },
                new ApiResource("WEB4.UI", "Events.API")
                {
                    Scopes =
                    {
                        "web2ApiScope"
                    }
                }
            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("scope1"),
                new ApiScope("scope2"),
                new ApiScope("web2ApiScope", userClaims: new []{ JwtClaimTypes.Role}),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                // m2m client credentials flow client
                new Client
                {
                    ClientId = "swagger_ui",
                    AllowedGrantTypes = GrantTypes.Code,

                    // where to redirect to after login
                    RedirectUris = {"https://localhost:7132/swagger/oauth2-redirect.html" },
                    AllowedCorsOrigins = {"https://localhost:7132"},
                    RequireClientSecret = false,
                    RequirePkce = false,

                    AllowedScopes = 
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "web2ApiScope"
                    }
                },
                new Client
                 {
                     ClientId = "web4_ui",
                     ClientName = "Web4.UI Vuejs oidc client",
                     ClientSecrets = {new Secret("secret".Sha256())}, // change me!
                     AllowedGrantTypes = GrantTypes.Code,
                     RequireClientSecret = false,
                     RedirectUris = {
                         "http://localhost:8080/auth/signinsilent/vuejs",
                         "http://localhost:8080/auth/signinwin/vuejs",
                         "http://localhost:8080/auth/signinpop/vuejs"
                         },
                     PostLogoutRedirectUris = {"http://localhost:8080/" },
                     AllowedCorsOrigins = {"http://localhost:8080"},
                     AllowedScopes = 
                    { 
                        "web2ApiScope",
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                    
                    }
                 },
            };
    }
}