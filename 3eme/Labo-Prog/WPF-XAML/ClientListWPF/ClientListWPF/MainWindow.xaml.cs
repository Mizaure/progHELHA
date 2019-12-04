﻿using ClientListWPF.MVVM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
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

namespace ClientListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UserDataList Users { get; set; }
        public MainWindow()
        {
            Users = new UserDataList();
            InitializeComponent();
            DataContext = Users;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(@"https://localhost:44391/api/users/");
                if(response.IsSuccessStatusCode){
                    Users.Users = await response.Content.ReadAsAsync<ObservableCollection<UserData>>();
                }
            }
        }
    }
}
