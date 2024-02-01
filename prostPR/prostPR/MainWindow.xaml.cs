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

namespace prostPR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void versionbtn_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"{InfoCoomputer.GetHardwareInfo("Win32_Processor", "Name")[0]}\n{InfoCoomputer.GetHardwareInfo("Win32_VideoController", "Name")[0]}\n{InfoCoomputer.GetHardwareInfo("Win32_DiskDrive", "Caption")[0]}", "Конфигурация ПК", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
