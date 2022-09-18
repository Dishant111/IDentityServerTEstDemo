
using IdentityServer4.Models;

namespace ItdentityServerTest
{
    public static class Config
    {

        public static IEnumerable<ApiScope> ApiScopes => new[]
        {
            new ApiScope("demoapi.read"),
            new ApiScope("demoapi.write"),
        };
        
        public static IEnumerable<Client> Clients => new[]
        {
            new Client()
            {
                ClientId = "CapServer",
                ClientName = " cap identitiy server",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("MyClientSecret".Sha256())},
                AllowedScopes = { "demoapi.read", "demoapi.write" }
            }
        };
        public static IEnumerable<ApiResource> ApiResources=> new[]
        {
            new ApiResource("demoapi")
            {
             Scopes = { "demoapi.read", "demoapi.write" },
             ApiSecrets = { new Secret("ScopeSecret".Sha256())},
             UserClaims = { "roles"}
            }
        };


    }
}
