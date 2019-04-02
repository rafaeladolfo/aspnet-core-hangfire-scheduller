using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using scheduller.data.DAO.Interfaces;
using scheduller.data.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace scheduller.data.DAO.Implementation
{
    public class ComplexJobDAO : IComplexJobDAO
    {               
        public void SaveComplexJob(string propertyValue)
        {
            const string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            var database = client.GetDatabase("test");
            
            var collection = database.GetCollection<ComplexJob>("test");
            collection.InsertOne(new ComplexJob { ComplexProperty = propertyValue });
        }
    }
}
