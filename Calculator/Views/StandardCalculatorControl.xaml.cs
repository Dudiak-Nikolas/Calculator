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

namespace Calculator.Views
{
    /// <summary>
    /// Interaction logic for StandardCalculatorControl.xaml
    /// </summary>
    public partial class StandardCalculatorControl : UserControl
    {
        public StandardCalculatorControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Pad_Memory(object sender, RoutedEventArgs e)
        {
            if (MemoruGrid.Visibility == Visibility.Hidden)
            {
                MemoruGrid.Visibility = Visibility.Visible;
                MemoryClear.IsEnabled = false;
                MemoryRead.IsEnabled = false;
                MemoryPlus.IsEnabled = false;
                MemoryMinus.IsEnabled = false;
                MemorySave.IsEnabled = false;
            }
            else
            {
                MemoruGrid.Visibility = Visibility.Hidden;
                MemoryClear.IsEnabled = true;
                MemoryRead.IsEnabled = true;
                MemoryPlus.IsEnabled = true;
                MemoryMinus.IsEnabled = true;
                MemorySave.IsEnabled = true;
            }
        }

        private void InitializeComponentMemoryClear(object sender, RoutedEventArgs e)
        {
            MemoryClear.IsEnabled = false;
            MemoryRead.IsEnabled = false;
            MemoryPad.IsEnabled = false;
            MemoryPlus.IsEnabled = true;
            MemoryMinus.IsEnabled = true;
            MemorySave.IsEnabled = true;
            MemoruGrid.Visibility = Visibility.Hidden;
        }

        private void InitializeComponentMemory(object sender, RoutedEventArgs e)
        {
            MemoryClear.IsEnabled = true;
            MemoryRead.IsEnabled = true;
            MemoryPad.IsEnabled = true;
        }
    }
}
