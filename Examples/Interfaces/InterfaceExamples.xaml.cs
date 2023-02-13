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
using System.Windows.Shapes;

namespace Programming_124_Short_Video_Notes.Examples.Interfaces
{
    /// <summary>
    /// Interaction logic for InterfaceExamples.xaml
    /// </summary>
    public partial class InterfaceExamples : Window
    {

        ClassRoster prog124 = new ClassRoster();

        public InterfaceExamples()
        {
            InitializeComponent();
            DisplayStudents();
        }

        public void DisplayStudents()
        {
            lbCohort.Items.Clear();


            foreach (Student student in prog124)
            {
                lbCohort.Items.Add(student);
            }

        }

        private void btnSortByAverage_Click(object sender, RoutedEventArgs e)
        {
            prog124.SortStudentsByAverage();
            DisplayStudents();
        }

        private void btnFirstName_Click(object sender, RoutedEventArgs e)
        {
            prog124.SortByFirstName();
            DisplayStudents();
        }

        private void btnDescending_Click(object sender, RoutedEventArgs e)
        {
            prog124.SortByAverageDescending();
            DisplayStudents();
        }
    }
}
