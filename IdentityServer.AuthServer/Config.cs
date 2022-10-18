using IdentityServer4.Models;

namespace IdentityServer.AuthServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>()
            {
                new ApiResource("resource_api1")
                {
                    Scopes={ "api1.read" , "api1.write", "api1.update" } 
                },
                new ApiResource("resource_api2")
                {
                    Scopes={ "api2.read" , "api2.write", "api2.update" } 
                }
            };
        }
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>()
            {
                new ApiScope("api1.read","API 1 İçin Okuma İzni"),
                new ApiScope("api1.write","API 1 İçin Yazma İzni"),
                new ApiScope("api1.update","API 1 İçin Güncelleme İzni"),
                new ApiScope("api2.read","API 2 İçin Okuma İzni"),
                new ApiScope("api2.write","API 2 İçin Yazma İzni"),
                new ApiScope("api2.update","API 2 İçin Güncelleme İzni"),

            };
        }
        public static IEnumerable<Client> GetClients()
        {
            return new  List<Client>(){
                new Client()
                {
                    ClientId ="Client1",
                    ClientName ="Client 1 app uygulaması",
                    ClientSecrets = new [] {new Secret("secret".Sha256())},
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    AllowedScopes={ "api1.read" }

                },
                new Client()
                {
                    ClientId ="Client2",
                    ClientName ="Client 2 appuygulaması",
                    ClientSecrets = new [] {new Secret("secret".Sha256())},
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    AllowedScopes={ "api1.read" , "api2.write","api2.update" }

                }
            };
        }
    }
}
