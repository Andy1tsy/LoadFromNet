using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Web;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Forms;


namespace DownloadingFromInternet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Utility Utility { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Utility = new Utility();

        }

        private void LoadPic_Click(object sender, RoutedEventArgs e)
        {

            Utility.LoadPicture();
            PictureBox1.Source = new BitmapImage(new Uri("D://picture.jpg", UriKind.Absolute));
        }
    }
}
