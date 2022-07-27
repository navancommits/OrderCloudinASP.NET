using OrderCloud.SDK;
using System;

namespace OrderCloudLibrary
{
    public class APIClientLibrary
    {
        public OrderCloudClient Get()
        {
            return new OrderCloudClient(new OrderCloudClientConfig
            {
                ClientId = "8DD363B7-217B-40F8-96F7-EB961136003D",
                // client credentials grant flow:
                ClientSecret = "ZsCfJKSC79Rn86oQFWuY3Rp8Toe9VidS2aM2rvCgZ0PYOo14hgip3kR8aDxl",
                GrantType = GrantType.ClientCredentials,

                Roles = new[] { ApiRole.FullAccess },
                ApiUrl = "https://sandboxapi.ordercloud.io",
                AuthUrl = "https://sandboxapi.ordercloud.io"
            });

        }
    }
}
