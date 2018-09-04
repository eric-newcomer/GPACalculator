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
            double myFinalGPA;
            double Sum = 0.0;
            int count = 0;

            if (!String.IsNullOrEmpty(Class1Name.Text))
            {
                if (Class1Grade.SelectedItem != null)
                {
                    string gpa = GradeToGPA(Class1Grade.Text);
                    double gpaAsDouble = Convert.ToDouble(gpa);
                    double credits1 = Convert.ToDouble(Class1Credits.Text);
                    double FinalGPA1 = (gpaAsDouble * credits1) / credits1;
                    Sum += FinalGPA1;
                    count += 1;
                }
            }
            if (!String.IsNullOrEmpty(Class2Name.Text))
            {
                if (Class2Grade.SelectedItem != null)
                {
                    string gpa2 = GradeToGPA(Class2Grade.Text);
                    double gpa2AsDouble = Convert.ToDouble(gpa2);
                    double credits2 = Convert.ToDouble(Class2Credits.Text);
                    double FinalGPA2 = (gpa2AsDouble * credits2) / credits2;
                    Sum += FinalGPA2;
                    count += 1;
                }

            }
            if (!String.IsNullOrEmpty(Class3Name.Text))
            {
                if (Class3Grade.SelectedItem != null)
                {
                    string gpa3 = GradeToGPA(Class3Grade.Text);
                    double gpa3AsDouble = Convert.ToDouble(gpa3);
                    double credits3 = Convert.ToDouble(Class3Credits.Text);
                    double FinalGPA3 = (gpa3AsDouble * credits3) / credits3;
                    Sum += FinalGPA3;
                    count += 1;
                }

            }
            if (!String.IsNullOrEmpty(Class4Name.Text))
            {
                if (Class4Grade.SelectedItem != null)
                {
                    string gpa4 = GradeToGPA(Class4Grade.Text);
                    double gpa4AsDouble = Convert.ToDouble(gpa4);
                    double credits4 = Convert.ToDouble(Class4Credits.Text);
                    double FinalGPA4 = (gpa4AsDouble * credits4) / credits4;
                    Sum += FinalGPA4;
                    count += 1;
                }
            }
            myFinalGPA = Sum / count;
            FinalGPA.Text = myFinalGPA.ToString();
        }
        private string GradeToGPA(string grade)
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
            return dict[grade];
        }
    }
}
