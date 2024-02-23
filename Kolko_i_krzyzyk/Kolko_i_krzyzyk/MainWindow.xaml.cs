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

namespace Kolko_i_krzyzyk
{
    public partial class MainWindow : Window
    {
        private Button[] btns = new Button[9];
        private bool IsPlayerTurn { get; set; }



        public MainWindow()
        {
            InitializeComponent();
            InitializeBtnArray();
        }

        private void InitializeBtnArray()
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i] = FindName($"btn{i}") as Button;
                btns[i].Background = Brushes.White;
                btns[i].Content = "?";
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}