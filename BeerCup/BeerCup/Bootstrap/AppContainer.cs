using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using BeerCup.ViewModels;
using BeerCup.Services.Data;
using BeerCup.Contracts.Services.Data;

namespace BeerCup.Bootstrap
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<BaseViewModel>();
            builder.RegisterType<VotingViewModel>();

            //Services - Data
            builder.RegisterType<BattleDataService>().As<IBattleDataService>();

            _container = builder.Build();
        }
    }
}
