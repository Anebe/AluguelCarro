using AluguelCarro.DAO;
using AluguelCarro.Interface;
using AluguelCarro.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro
{
    internal class Startup
    {
        public static IServiceProvider GetServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            /*string appDirectory = Path.GetDirectoryName(Assembly.().Location);
            string appSettingsPath = Path.Combine(appDirectory, "appsettings.json");*/

            /*IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(appSettingsPath)
                .AddJsonFile("appsettings.json")
                .Build();*/

            //serviceCollection.AddSingleton<IConfiguration>(config);
            string connectionString = "server=localhost;uid=root;pwd=;database=aluguel_carro";
            serviceCollection.AddSingleton<IClienteService, ClienteService>();
            serviceCollection.AddSingleton(typeof(IGenericDAO<>), typeof(GenericDAO<>));
            serviceCollection.AddSingleton(typeof(IMySqlStringFactory<>), typeof(MySqlStringFactory<>));
            serviceCollection.AddSingleton<IDbConnection>(new MySqlConnection(connectionString));
            serviceCollection.AddSingleton<IClienteDAO, ClienteDAO>();
            return serviceCollection.BuildServiceProvider();
        }
    }
}
