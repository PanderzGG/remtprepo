using System;
using System.Collections.Generic;
using System.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Person> person = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveName_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person(tbname.Text, Convert.ToInt32(tbAlter.Text));
            person.Add(p);

            // Listen triggered bei der Aktualisierung die Benutzerfläche nicht.
            GridName.Items.Refresh();


            GridName.ItemsSource = person;
            tbname.Text = "";
            tbAlter.Text = "";
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
