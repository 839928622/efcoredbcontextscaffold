using System;
using System.Collections.Generic;
using System.Linq;
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
                var Students= SeedData.getStudent();

               
                 var res=  _context.Students.ToList();
                if(!res.Any())
                {
                var view =   _context.Students.AddRangeAsync(Students);
                _context.SaveChanges();

                }
 
               
                foreach (var item in res)
                {
                    Console.WriteLine("年龄：" + item.Age + "姓名 ：" + item.StudentName);
                }
            }

            Console.ReadKey();

           
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

    public static  class SeedData
    {
       public static List<Students> getStudent()
       {
       var xx =    new List<Students>();
       
           xx.Add(new Students {StudentName = "张三",Age="18"});
       return xx;
       }

    }
}
