using BeerCup.Bootstrap;
using BeerCup.Contracts.Services.General;
using BeerCup.ViewModels;
using BeerCup.ViewModels.Base;
using BeerCup.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeerCup.Services.General
{
    public class NavigationService : INavigationService
    {
        private readonly Dictionary<Type, Type> _mappings;

        protected Application CurrentApplication = Application.Current;

        //todo: konstruktor injection of IAuthenticationService
        public NavigationService()
        {
            _mappings = new Dictionary<Type, Type>();

            CreatePageViewModelMappings();
        }

        private void CreatePageViewModelMappings()
        {
            _mappings.Add(typeof(MainViewModel), typeof(MainView));
        }

        public async Task InitializeAsync()
        {
            //todo: warunek jeśli user jest zalogowany to wyświetl inny page

            await NavigateToAsync<MainViewModel>();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            return InternalNavigateToAsync(typeof(TViewModel), null);
        }

        protected virtual async Task InternalNavigateToAsync(Type viewModelType, object parameter)
        {
            Page page = CreateAndBindPage(viewModelType, parameter);

            CurrentApplication.MainPage = page;

            await (page.BindingContext as ViewModelBase).InitializeAsync(parameter);
        }

        private Page CreateAndBindPage(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);

            if (pageType == null)
            {
                throw new Exception($"Mapping type for {viewModelType} is not a page");
            }

            Page page = Activator.CreateInstance(pageType) as Page;
            ViewModelBase viewModel = AppContainer.Resolve(viewModelType) as ViewModelBase;
            page.BindingContext = viewModel;

            return page;
        }

        private Type GetPageTypeForViewModel(Type viewModelType)
        {
            if (!_mappings.ContainsKey(viewModelType))
            {
                throw new KeyNotFoundException($"No map for {viewModelType} was found on navigation mappings");
            }

            return _mappings[viewModelType];
        }
    }
}
