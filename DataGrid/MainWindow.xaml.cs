using System;
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
using System.Reflection;

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void GetSelectedCells(object sender, RoutedEventArgs e)
        {
            string selectedData = "";
            foreach (var dataGridCellInfo in selectedCellsGrid.SelectedCells)
            {
                PropertyInfo pi = dataGridCellInfo.Item.GetType().GetProperty(dataGridCellInfo.Column.Header.ToString());
                var value =pi.GetValue(dataGridCellInfo.Item, null);
                selectedData += dataGridCellInfo.Column.Header + ": " + value.ToString() + "\n";
            }
            MessageBox.Show(selectedData);
        }
    }
}
