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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "";
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            //Adds choice to the selected courses
            choice = (Course)(this.comboBox.SelectedItem);
            
            //Determines if you are already registered for the class
            if (choice.IsRegisteredAlready() == true)

                MessageBox.Show("User is already registered in this course");
            //Stops user after 9 credits
            else if (this.textBox.Text == "9")

                MessageBox.Show("User is already registered in 3 courses");

            else

            {
                this.listBox.Items.Add(choice);
                choice.SetToRegistered();

                if (this.textBox.Text == "")

                    this.textBox.Text = "3";

                else if (this.textBox.Text == "3")

                    this.textBox.Text = "6";

                else if (this.textBox.Text == "6")

                    this.textBox.Text = "9";

                MessageBox.Show("Congratulations! User registered in " + choice + ".");

            }
        }
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

                this.listBox.Items.Add(choice);
            
            }
    }
}
