using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using ConsoleApp.DonvvModels;
using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
             var res =    System.Text.Encoding.UTF8.GetBytes("111111");
            Console.WriteLine("转换为byte数组："+res);
            MD5 md5 = new MD5CryptoServiceProvider();
          var hashres =      md5.ComputeHash(res);
         string hash2string =  hashres.ToString();
         Console.WriteLine("取md6之后再转换为base64:"+ Convert.ToBase64String(hashres));
            

          var   HttpClient = new  HttpClient();
            using ( var DbContext = new DonvvDbcontext())
            {
             var user =    DbContext.SysUsers.FirstOrDefault(x => x.Id == 10002);
             byte[] passwordbytes =  Convert.FromBase64String(user.PassWord);

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
