using System;
using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var _context = new consoleAppDbcontext())
            {
               var view =   _context.ViewStudent.ToListAsync();
            }
        }
    }

    // public class consoleAppDbcontext: DbContext
    // {
    //     public consoleAppDbcontext(DbContextOptions<consoleAppDbcontext> options) : base(options)
    //     {
            
    //     }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     {
    //         optionsBuilder.UseSqlServer(System.Environment.GetEnvironmentVariable("LocalDb"));
    //     }

    //     protected override void OnModelCreating(ModelBuilder builder)
    //     {
    //         base.OnModelCreating(builder);
        
    //     }
    // }
}
