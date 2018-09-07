using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Autofac;
using Awesomekit.Helpers.Extentions;
using Awesomekit.ViewModels;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;
using XLabs.Ioc.Autofac;

namespace Awesomekit
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeResolver();

            // Create view model from view factory

            //MainPage = new NavigationPage(new MainPage());
            NavigationPage.SetHasNavigationBar(this, false);

            //MainPage = new Controls.TransitionNavigationPage((Page)ViewFactory.CreatePage<MainViewModel, MainPage>());

            MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainViewModel, MainPage>());

        }

        private void InitializeResolver()
        {
            var builder = new ContainerBuilder();

            var autofacContainer = builder.AutoRegisterMvvmComponents(typeof(App).GetTypeInfo().Assembly)
                .Finish();

            // That container will use XLabs for resolver
            var container = new AutofacContainer(autofacContainer);

            //Here we can register PCL services
            container.Register<IDependencyContainer>(container);

            // And now, we will set resolver
            if (!Resolver.IsSet)
                Resolver.SetResolver(container.GetResolver());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
