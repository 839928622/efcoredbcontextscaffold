using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{
    public class ioc {
    IServiceCollection  services = new ServiceCollection ().AddTransient<Parent,sonA>();
     
     
    }

}