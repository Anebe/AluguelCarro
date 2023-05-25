using AluguelCarro.DAO;
using AluguelCarro.Interface;
using AluguelCarro.src.DAO;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Interface;
using AluguelCarro.src.Service;
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
    public class Startup
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

            //string connectionString = "server=localhost;uid=root;pwd=;database=aluguel_carro";



            serviceCollection.AddScoped<ICrudService<Funcionario>, FuncionarioService>();
            serviceCollection.AddSingleton<IFuncionarioService, FuncionarioService>();
            serviceCollection.AddSingleton<IFuncionarioDAO, FuncionarioDAO>();

            serviceCollection.AddScoped<ICrudService<Cliente>, ClienteService>();
            serviceCollection.AddSingleton<IClienteService, ClienteService>();
            serviceCollection.AddSingleton<IClienteDAO, ClienteDAO>();

            serviceCollection.AddScoped<ICrudService<Carro>, CarroService>();
            serviceCollection.AddSingleton<ICarroService, CarroService>();
            serviceCollection.AddSingleton<ICarroDAO, CarroDAO>();

            serviceCollection.AddSingleton(typeof(IGenericDAO<>), typeof(GenericDAO<>));
            //serviceCollection.AddSingleton(typeof(IMySqlStringFactory<>), typeof(MySqlStringFactory<>));
            //serviceCollection.AddSingleton<IDbConnection>(new MySqlConnection(connectionString));

            return serviceCollection.BuildServiceProvider();
        }
    }
}
