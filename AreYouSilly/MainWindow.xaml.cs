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

namespace AreYouSilly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            imgTrollface.Visibility = Visibility.Hidden;
            lblKnewIt.Visibility = Visibility.Hidden;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            ShowTheKnewItMessage();
        }


        private void btnYes2_Click(object sender, RoutedEventArgs e)
        {
            ShowTheKnewItMessage();
        }

        private void ShowTheKnewItMessage()
        {
            lblKnewIt.Visibility = Visibility.Visible;
        }

        private void btnYes2_MouseEnter(object sender, MouseEventArgs e)
        {
            ChangeImageVisibility(imgTrollface);
            ChangeYesNoContent(btnYes2);
        }
        private void btnYes2_MouseLeave(object sender, MouseEventArgs e)
        {
            ChangeImageVisibility(imgTrollface);
            ChangeYesNoContent(btnYes2);
        }
        private void ChangeYesNoContent(Button btn)
        {
            if ((string)btn.Content == "No!")
            {
                btn.Content = "Yes!";
            }

            else {
                btn.Content = "No!";
                }
        }
        private void ChangeImageVisibility(Image image)
        {
            switch (image.Visibility)
            {
                case Visibility.Visible:
                    image.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    image.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

    }
}
