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

namespace CharactersExample
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

        private void btnShowChar_Click(object sender, RoutedEventArgs e)
        {
            char chrInput = txtInput.Text[0];
            int intInput = (int)chrInput;
            txtOutput.Text = "you entered" + chrInput.ToString() + System.Environment.NewLine +
                " it has a vaue of " + int intInput.ToString() + System.Environment.NewLine +
                " the next charcater is " + ((char)(intInput + 1)).ToString() + System.Environment.NewLine +
                " the previous charcater is " + ((char)(intInput - 1)).ToString(); 
        } 
    }
}
