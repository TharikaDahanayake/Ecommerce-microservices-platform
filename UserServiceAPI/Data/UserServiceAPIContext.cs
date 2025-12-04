using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using UserServiceAPI.Models;

namespace UserServiceAPI.Data
{
    public class UserServiceAPIContext : DbContext
    {
        public UserServiceAPIContext(DbContextOptions<UserServiceAPIContext> options)
            : base(options)
        {
        }

        public DbSet<UserServiceAPI.Models.User> User { get; set; } = default;
    }
    
}
