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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;

namespace DatabaseApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection cn;
        cn = new OleDbConnection(C:\Users\brayl\Desktop\DatabaseProject.accdb)
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = “”;
            while (read.Read())
            {
                data += read[0].ToString() + “\n”;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Employees";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = “”;
            while (read.Read())
            {
                data += read[0].ToString() + “\n”;
            }
        }
    }
}
