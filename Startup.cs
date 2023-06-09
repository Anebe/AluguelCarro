﻿using AluguelCarro.src.DAO;
using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.Service;
using AluguelCarro.src.Service.Interface;
using AluguelCarro.src.Util;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using System.Data;

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

            string connectionString = "server=localhost;uid=root;pwd=;database=aluguel_carro";

            serviceCollection.AddSingleton<IClienteService, ClienteService>();
            serviceCollection.AddSingleton<ICarroService, CarroService>();
            serviceCollection.AddSingleton<IAluguelService, AluguelService>();
            

            serviceCollection.AddSingleton<IClienteDAO, ClienteDAO>();
            serviceCollection.AddSingleton<ICarroDAO, CarroDAO>();
            serviceCollection.AddSingleton<IAluguelDAO, AluguelDAO>();

            serviceCollection.AddSingleton<ISelectCommandString, SelectCommandString>();

            //serviceCollection.AddSingleton(typeof(IGenericDAO<>), typeof(GenericDAO<>));

            serviceCollection.AddSingleton(typeof(IMySqlStringFactory<>), typeof(MySqlStringFactory<>));
            serviceCollection.AddSingleton<IDbConnection>(new MySqlConnection(connectionString));

            return serviceCollection.BuildServiceProvider();
        }
    }
}
