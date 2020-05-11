using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cart.Models
{
    public class CartContext : DbContext
    {
        public CartContext (DbContextOptions<CartContext> options)
            : base(options)
        {
        }

        public DbSet<Cart.Models.Carts> Carts { get; set; }
    }
}
