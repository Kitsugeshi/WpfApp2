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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> MyList;
        public MainWindow()
        {
            InitializeComponent();

            MyList = new List<string>()
            {
                "str_1",
                "str_2",
                "str_3",
                "str_4",
            };

            ListBoxView.ItemsSource = MyList;
            ListBoxView.FontSize = 45;

            List<User> user = new List<User>
            {
                new User(0,"Ivan", "zxc@gmail.com"),
                new User(1,"Semen", "asdf@gmail.com"),
                new User(2,"Vlad", "ert@gmail.com"),
            };
            MyListView.ItemsSource = user;
            MyListView.FontSize = 30;
            table.ItemsSource = user;

            MyList.Add("new striing");
            MyList.Add("new striing");
            MyList.Add("new striing");

        }

        private void AddItemInList(object sender, RoutedEventArgs e)
        {
            MyList.Add(TextBoxAddList.Text);
            ListBoxView.Items.Refresh();
        }

        private void MyListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           var item = MyListView.SelectedItem as User;
            TextID.Text = Convert.ToString(item.id);
            TextName.Text = item.name;
            TextEmail.Text = item.email;

        }
    }
}
