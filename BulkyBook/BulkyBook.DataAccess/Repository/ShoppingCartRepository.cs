﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _context;

        public ShoppingCartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public int DecrementCount(ShoppingCart cart, int count)
        {
            cart.Count -= count;
            return cart.Count;
        }

        public int IncrementCount(ShoppingCart cart, int count)
        {
            cart.Count += count;
            return cart.Count;
        }
    }
}
