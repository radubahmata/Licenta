﻿using System;
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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace CRMAgentieImobiliara
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLoginSubmit_Click(object sender, RoutedEventArgs e)
        {
            /// SqlConnection sqlCon = new SqlConnection(@"Datasource="); 
            MainWindow dashboard = new MainWindow();
            dashboard.Show();
            this.Close();
        }
    }
}
