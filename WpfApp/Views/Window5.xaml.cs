﻿using WpfApp.ViewModels;
using System.Windows;

namespace WpfApp.Views
{
    public partial class Window5 : Window
    {
        public Window5(Window5ViewModel window5ViewModel)
        {
            InitializeComponent();
            DataContext = window5ViewModel;
        }
    }
}
