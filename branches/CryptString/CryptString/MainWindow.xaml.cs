﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelpersLib;

namespace CryptString
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            txtText.Text = new CryptKeys().Encrypt(txtText.Text, "sharexmod", "fedecda6893b798b6efb7b9fdfbfe990", "71GHqITtU6b5ww7b");
        }

        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            txtText.Text = new CryptKeys().Decrypt(txtText.Text, "sharexmod", "fedecda6893b798b6efb7b9fdfbfe990", "71GHqITtU6b5ww7b");
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtText.Text);
        }
    }
}