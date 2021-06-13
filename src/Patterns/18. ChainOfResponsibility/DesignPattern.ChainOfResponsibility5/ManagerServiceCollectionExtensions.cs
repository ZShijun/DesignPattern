using Microsoft.Extensions.DependencyInjection;

namespace DesignPattern.ChainOfResponsibility5
{
    public static class ManagerServiceCollectionExtensions
    {
        public static IManagerBuilder AddManagers(this IServiceCollection services)
        {
            IManagerBuilder managerBuilder = new ManagerBuilder();
            managerBuilder.AddManager(new TL("李四"));
            managerBuilder.AddManager(new PM("王五"));
            managerBuilder.AddManager(new CTO("赵六"));
            services.AddSingleton(managerBuilder);
            return managerBuilder;
        }
    }
}
