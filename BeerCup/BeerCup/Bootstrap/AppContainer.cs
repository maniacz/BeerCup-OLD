using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using BeerCup.ViewModels;
using BeerCup.Services.General;
using BeerCup.Contracts.Services.General;

namespace BeerCup.Bootstrap
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<VotingViewModel>();

            //Services - Data

            //Services - General
            builder.RegisterType<NavigationService>().As<INavigationService>();

            _container = builder.Build();
        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
