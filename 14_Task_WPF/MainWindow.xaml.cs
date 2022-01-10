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

namespace _14_Task_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product>products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Молоко",
                Prise = 75,
                Image = 1,
                Category =Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Хлеб",
                Prise = 30,
                Image = 2,
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Микроволновая печь",
                Prise = 7000,
                Image = 3,
                Category = Categories.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
