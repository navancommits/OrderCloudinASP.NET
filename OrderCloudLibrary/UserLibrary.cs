using OrderCloud.SDK;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderCloudLibrary
{
    public class UserLibrary
    {
        public async Task<User> Create(OrderCloudClient client)
        {
            if (client == null) return null;

            User user = new User
            {
                Active = true,
                FirstName = "navannew",
                LastName = "ksrnew",
                Username = "navannewuser"
            };

            return await client.AdminUsers.CreateAsync(user);
        }
    }
}
