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
using Lib;
namespace WpfApp2
{
     public class Info
    {
        public string info { get; set; }
}
public partial class MainWindow : Window
    {
        public string json;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TbxC(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            Info info = Cl<Info>.DeserializeObject<Info>(json);
            Tbx.Text = info.info;
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            Info info = new Info();
            info.info = Tbx.Text;
            json = Cl<Info>.SerializeObject(info);
        }
    }
}
