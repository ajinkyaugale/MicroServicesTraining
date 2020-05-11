using Microsoft.Extensions.Configuration;
using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Product.Services
{
    public class ProdService
    {
        private IMongoCollection<Prod> product;
        public ProdService(IConfiguration configration)
        {
            MongoClient client = new MongoClient(configration.GetConnectionString("mongoUrl"));
            IMongoDatabase database = client.GetDatabase("productsdb");
            product= database.GetCollection<Prod>("Product");
        }
        public List<Prod> Get()
        {
            return product.Find(product => true).ToList();
        }
        public IMongoCollection<Prod> Product { get; }
    }
}

