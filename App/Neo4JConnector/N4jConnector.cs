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
                var r = await tx.RunAsync(cypherQuery);
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
        public async Task<List<Employee>> GetListAyncEmployees()
        {
            List<Employee> l = new List<Employee>();
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              @"
              match (e:Employee) return e.Id as Id, e.Name as Name, e.DoB as DoB, e.PhoneNumber as PhoneNumber, e.Email as Email, e.Address as Address, e.CitizenId as CitizenId, e.EmployeeRole as EmployeeRole
              ";

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.ReadTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery);
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
            {
                var employee = new Employee
                {
                    Id = row["Id"].As<string>(),
                    Name = row["Name"].As<string>(),
                    DoB = row["DoB"].As<string>(),
                    PhoneNumber = row["PhoneNumber"].As<string>(),
                    Email = row["Email"].As<string>(),
                    Address = row["Address"].As<string>(),
                    CitizenId = row["CitizenId"].As<string>(),
                    EmployeeRole = row["EmployeeRole"].As<string>()
                };
                l.Add(employee);
            }
            return l;
        }

        [Obsolete]
        public async Task<List<Service>> GetListAyncServices()
        {
            List<Service> l = new List<Service>();
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              @"
              match (s:Service) return s.Id as Id, s.Name as Name
              ";

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.ReadTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery);
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
            {
                var service = new Service
                {
                    Id = row["Id"].As<string>(),
                    Name = row["Name"].As<string>(),
                };
                l.Add(service);
            }
            return l;
        }

        [Obsolete]
        public async Task<List<Request>> GetListAyncRequests()
        {
            List<Request> l = new List<Request>();
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              @"
              match (rq:Request) return rq.CusId as CusId, rq.CusName as CusName, rq.EmpId as EmpId, rq.EmpName as EmpName, rq.ServiceId as ServiceId, rq.ServiceName as ServiceName, rq.Title as Title, rq.Detail as Detail, rq.DateCreated as DateCreated, rq.ProcessStatus as ProcessStatus 
              ";

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.ReadTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery);
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
            {
                var request = new Request
                {
                    CusId = row["CusId"].As<string>(),
                    CusName = row["CusName"].As<string>(),
                    EmpId = row["EmpId"].As<string>(),
                    EmpName = row["EmpName"].As<string>(),
                    ServiceId = row["ServiceId"].As<string>(),
                    ServiceName = row["ServiceName"].As<string>(),
                    Title = row["Title"].As<string>(),
                    Detail = row["Detail"].As<string>(),
                    DateCreated = row["DateCreated"].As<string>(),
                    ProcessStatus = row["ProcessStatus"].As<string>(),
                };
                l.Add(request);
            }
            return l;
        }

        [Obsolete]
        public async Task<Employee> GetObjectAyncLogin(string username, string password)
        {
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              @"
              match (e:Employee{Username:'" + username + "', Password:'" + password + "'}) return e.Id as Id, e.Name as Name, e.DoB as DoB, e.PhoneNumber as PhoneNumber, e.Email as Email, e.Address as Address, e.CitizenId as CitizenId, e.EmployeeRole as EmployeeRole"
              ;

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.ReadTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery);
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
            {
                var employee = new Employee
                {
                    Id = row["Id"].As<string>(),
                    Name = row["Name"].As<string>(),
                    DoB = row["DoB"].As<string>(),
                    PhoneNumber = row["PhoneNumber"].As<string>(),
                    Email = row["Email"].As<string>(),
                    Address = row["Address"].As<string>(),
                    CitizenId = row["CitizenId"].As<string>(),
                    EmployeeRole = row["EmployeeRole"].As<string>()
                };
                return employee;
            }
            return null;
        }

        [Obsolete]
        public async Task<Employee> CreateEmployee(Employee emp)
        {
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              "create (e:Employee{Id:'" + emp.Id + "',"+ 
              "Name:'" + emp.Name + "',"+ 
              "DoB:date('" + emp.DoB + "')," +
              "Email:'" + emp.Email + "'," +
              "PhoneNumber:'" + emp.PhoneNumber + "'," +
              "Address:'" + emp.Address + "'," +
              "CitizenId: '" + emp.CitizenId + "'," +
              "EmployeeRole:'Nhân viên E1', Username:'" + emp.Username + "', Password:'" + emp.Password + "'})" +
              " return e.Id as Id, e.Name as Name, e.DoB as DoB, e.PhoneNumber as PhoneNumber, e.Email as Email, e.Address as Address, e.CitizenId as CitizenId, e.EmployeeRole as EmployeeRole"
              ;

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.WriteTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery);
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
            {
                var employee = new Employee
                {
                    Id = row["Id"].As<string>(),
                    Name = row["Name"].As<string>(),
                    DoB = row["DoB"].As<string>(),
                    PhoneNumber = row["PhoneNumber"].As<string>(),
                    Email = row["Email"].As<string>(),
                    Address = row["Address"].As<string>(),
                    CitizenId = row["CitizenId"].As<string>(),
                    EmployeeRole = row["EmployeeRole"].As<string>()
                };
                return employee;
            }
            return null;
        }

        [Obsolete]
        public async Task<Employee> UpdateEmployee(Employee emp)
        {
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              "match (e:Employee{Id:'" + emp.Id + "'}) " +
              "set e = {" +
              "Id:'" + emp.Id + "'," + 
              "Name:'" + emp.Name + "'," +
              "DoB:date('" + emp.DoB + "')," +
              "Email:'" + emp.Email + "'," +
              "PhoneNumber:'" + emp.PhoneNumber + "'," +
              "Address:'" + emp.Address + "'," +
              "CitizenId: '" + emp.CitizenId + "'," +
              "EmployeeRole:'" + emp.EmployeeRole + "', Username:'" + emp.Username + "', Password:'" + emp.Password + "'}" +
              " return e.Id as Id, e.Name as Name, e.DoB as DoB, e.PhoneNumber as PhoneNumber, e.Email as Email, e.Address as Address, e.CitizenId as CitizenId, e.EmployeeRole as EmployeeRole"
              ;

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.WriteTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery);
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
            {
                var employee = new Employee
                {
                    Id = row["Id"].As<string>(),
                    Name = row["Name"].As<string>(),
                    DoB = row["DoB"].As<string>(),
                    PhoneNumber = row["PhoneNumber"].As<string>(),
                    Email = row["Email"].As<string>(),
                    Address = row["Address"].As<string>(),
                    CitizenId = row["CitizenId"].As<string>(),
                    EmployeeRole = row["EmployeeRole"].As<string>()
                };
                return employee;
            }
            return null;
        }

        [Obsolete]
        public async Task DeleteEmployee(Employee emp)
        {
            var driver = GraphDatabase.Driver("bolt://44.192.129.157:7687",
                    AuthTokens.Basic("neo4j", "wholesale-liver-keyword"));
            var cypherQuery =
              "match (e:Employee{Id:'" + emp.Id + "'}) " +
              "detach delete e";
              ;

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.WriteTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery);
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
        }
    }
}
