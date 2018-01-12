﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Authorization
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public MainWindow mainWindow;


        public Registration(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = System.IO.Path.GetFullPath("."),
                Title = "Выберите картинку",
                Filter = "Portable Network Graphic (*.png)|*.png"
            };

            if (dialog.ShowDialog() == true)
            {
                avatar.Source = new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string welcomeStr = login.Text;

            mainWindow.Content = new WelcomePage(this.mainWindow, welcomeStr);
        }
    }
}
