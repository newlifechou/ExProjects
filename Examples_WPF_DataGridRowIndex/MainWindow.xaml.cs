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

namespace Examples_WPF_DataGridRowIndex
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //对现有对象构造一层比较好
            NameList = new List<NameItem>();
            for (int i = 0; i < 100; i++)
            {
                NameList.Add(new NameItem
                {
                    Index = i + 1,
                    Name = "Peter " + i
                });
            }

            this.DataContext = this;
        }

        public List<NameItem> NameList { get; set; }


    }
}
