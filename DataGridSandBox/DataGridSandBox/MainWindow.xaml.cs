using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataGridSandBox
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Item
        {
            public string Name { get; set; }
            public bool IsFruits { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            var data = new ObservableCollection<Item>()
            {
                new Item()
                {
                    Name = "みかん",
                    IsFruits = true
                },
                new Item()
                {
                    Name = "キャベツ",
                    IsFruits = false
                }
            };
            this.dataGrid.ItemsSource = data;
        }
    }
}
