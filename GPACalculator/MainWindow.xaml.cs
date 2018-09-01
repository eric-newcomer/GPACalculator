using System;
using System.Collections.ObjectModel;
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

namespace GPACalculator
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

        private void CalculateGPA_Click(object sender, RoutedEventArgs e)
        {
            double FinalGPA;
            double SumGPA = 0.0;
            int count = 0;

            if (Class1Name.Text != null)
            {
                if (Class1Grade.SelectedItem != null)
                {
                    SumGPA += GradeToGPA(Class1Grade.SelectedItem.ToString());
                }
            }
            if (Class2Name.Text != null)
            {
                
            }
            if (Class3Name.Text != null)
            {
                
            }
            if (Class4Name.Text != null)
            {
                
            }           
        }
        private double GradeToGPA(string grade)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"A", "4.0"},
                {"A-", "3.7"},
                {"B+", "3.3" },
                {"B", "3.0" },
                {"B-", "2.7" },
                {"C+", "2.3" },
                {"C", "2.0" },
                {"C-", "1.7" },
                {"D+", "1.3" },
                {"D", "1.0" },
                {"F", "0.0" },
            };
        }
    }
}
