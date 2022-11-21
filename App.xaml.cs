using AutoMapper;
using KPZ_Lab02.Model;
using KPZ_Lab02_UI.Base;
using KPZ_Lab02_UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KPZ_Lab02_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel _model;
        private DataViewModel _viewModel;
        public App()
        {
            _model = DataModel.Load();
            _viewModel = Mapping.Create().Map<DataModel, DataViewModel>(_model);
            var nWindow = new MainWindow() { DataContext = _viewModel };
            nWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                _model = Mapping.Create().Map<DataViewModel, DataModel>(_viewModel);
                _model.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
