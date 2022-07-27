using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderCloud.SDK;
using OrderCloudLibrary;


namespace ConsoleApp6
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var client = new OrderCloudClient(new OrderCloudClientConfig
            //{
            //    ClientId = "3BB348F6-6316-444A-9610-DE01C6F91374",
            //    // client credentials grant flow:
            //    ClientSecret = "oHKBN1McjiUKfX1vIiVTUEPpcKWJq16wyGi8MBlvGtkrH1hi1aMTzQiXksAh",
            //    GrantType=GrantType.ClientCredentials,

            //    Roles = new[] { ApiRole.OrderAdmin },
            //    ApiUrl = "https://sandboxapi.ordercloud.io",
            //    AuthUrl = "https://sandboxapi.ordercloud.io"
            //});

            //Console.WriteLine(client.Config.Roles.Length);

            //var orders = await client.Orders.ListAsync(OrderDirection.Incoming);

            //Console.WriteLine($"{orders.Meta.TotalCount} open orders found.");
            //Console.WriteLine($"Fetched page {orders.Meta.Page} of {orders.Meta.TotalPages}.");
            //foreach (var order in orders.Items)
            //{
            //    Console.WriteLine($"ID: {order.ID}, Total: {order.Total:C}");
            //}
            APIClientLibrary apiClient = new APIClientLibrary();

            var client = apiClient.Get();

            //SecurityProfile securityProfile = new SecurityProfile();
            //securityProfile.Name = "myordersecprof";
            //var securityProfileResult = await client.SecurityProfiles.CreateAsync(securityProfile);

            //SecurityProfileAssignment securityProfileAssignment = new SecurityProfileAssignment
            //{
            //    SecurityProfileID = securityProfileResult.ID,

            //};

            //User user = new User
            //{
            //    Active = true,
            //    FirstName = "nk",
            //    LastName = "sr",
            //    Username = "nksr",
            //    Email = "contactnavaneeth@gmail.com"
            //};

            //var result=await client.AdminUsers.CreateAsync(user);

            //SecurityProfileAssignment securityProfileAssignment = new SecurityProfileAssignment
            //{
            //    SecurityProfileID = "4-9b0rnQ7U6tA1Vs1YLuAA",
            //    UserID= result.ID
            //};

            //Order order = new Order();
            //order.

            Product product = new Product();
            product.Name = "Product 2";
            var result=client.Products.CreateAsync(product);

            var products = await client.Products.ListAsync();


            //var orders = await client.Orders.ListAsync(OrderDirection.Incoming, filters: new { Status = OrderStatus.Open });

            //Console.WriteLine($"{orders.Meta.TotalCount} open orders found.");
            //Console.WriteLine($"Fetched page {orders.Meta.Page} of {orders.Meta.TotalPages}.");
            //foreach (var order in orders.Items)
            //{

            //    Console.WriteLine($"ID: {order.ID}, Total: {order.Total:C}");
            //}
        }
    }
}
