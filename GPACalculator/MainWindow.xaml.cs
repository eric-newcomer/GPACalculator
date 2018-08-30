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
        public class Course
        {
            public string Name { get; set; }
            public string Grade { get; set; }
            public double GPAGrade { get; set; }
            public int Credits { get; set; }
        }

        public double GradeToGPA(string grade)
        {
            if (grade == "A")
            {
                return 4.0;
            }
            else if (grade == "B")
            {
                return 3.0;
            }
            else if (grade == "C")
            {
                return 2.0;
            }
            else if (grade == "D")
            {
                return 1.0;
            }
            else
            {
                return 0.0;
            }
        }

        public ObservableCollection<Course> Courses = new ObservableCollection<Course>();

        public void CalculateGPA_Click(object sender, RoutedEventArgs e)
        {
            if (Class1Name != null)
            {
                Course course = new Course()
                {
                    Name = Class1Name.Text,
                    Grade = Class1Grade.Text,
                    GPAGrade = GradeToGPA(Class1Grade.Text),
                    Credits = int.Parse(Class1Credits.Text)

                };
                Courses.Add(course);
            }

        }
    }
}
