using App.Models;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Neo4JConnector
{
    public class N4jConnector
    {
        [Obsolete]
        public async Task<List<Customer>> GetListAyncCustomers()
        {
            List<Customer> l = new List<Customer>();
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              @"
              match (c:Customer) return c.Id as Id, c.Name as Name, c.DoB as DoB, c.PhoneNumber as PhoneNumber, c.Email as Email, c.Address as Address, c.CitizenId as CitizenId
              ";

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.ReadTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery,
                        new { limit = "10" });
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
            {
                var customer = new Customer
                {
                    Id = row["Id"].As<string>(),
                    Name = row["Name"].As<string>(),
                    DoB = row["DoB"].As<string>(),
                    PhoneNumber = row["PhoneNumber"].As<string>(),
                    Email = row["Email"].As<string>(),
                    Address = row["Address"].As<string>(),
                    CitizenId = row["CitizenId"].As<string>()
                };
                l.Add(customer);
            }
            return l;
        }

        [Obsolete]
        public async Task<List<Customer>> GetListAyncServices()
        {
            List<Customer> l = new List<Customer>();
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              @"
              match (c:Customer) return c.Id as Id, c.Name as Name, c.DoB as DoB, c.PhoneNumber as PhoneNumber, c.Email as Email, c.Address as Address, c.CitizenId as CitizenId
              ";

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.ReadTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery,
                        new { limit = "10" });
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
            {
                var customer = new Customer
                {
                    Id = row["Id"].As<string>(),
                    Name = row["Name"].As<string>(),
                    DoB = row["DoB"].As<string>(),
                    PhoneNumber = row["PhoneNumber"].As<string>(),
                    Email = row["Email"].As<string>(),
                    Address = row["Address"].As<string>(),
                    CitizenId = row["CitizenId"].As<string>()
                };
                l.Add(customer);
            }
            return l;
        }
    }
}
