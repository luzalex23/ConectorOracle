using ConectorOracle;
using Microsoft.EntityFrameworkCore;

using System;
using Oracle.ManagedDataAccess.Client;
using ConectorOracle.Domain.Entities;

namespace ConectorOracle
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                db.Database.OpenConnection();
            }
            Console.ReadLine();
        }
    }
    
}
    
