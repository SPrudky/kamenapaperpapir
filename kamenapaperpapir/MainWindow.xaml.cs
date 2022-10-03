using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace kamenapaperpapir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        player1 _1 = new player1(10);
        player1 _2 = new player1(10);

        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timer.Tick += new EventHandler(tah) ;
        }
        public void tah(object sender, EventArgs e)
        {
            _1.tah();
            _2.tah();

            switch (_1.last)
            {
                case 0:
                    o1.Source = new BitmapImage(new Uri("Images/R.png", UriKind.Relative));
                    break;
                case 1:
                    o1.Source = new BitmapImage(new Uri("Images/S.png", UriKind.Relative));
                    break;
                case 2:
                    o1.Source = new BitmapImage(new Uri("Images/P.png", UriKind.Relative));
                    break;
                    

            }
            switch (_2.last)
            {
                case 0:
                    o2.Source = new BitmapImage(new Uri("Images/R.png" , UriKind.Relative));
                    break;

                case 1:
                    o2.Source = new BitmapImage(new Uri("Images/S.png", UriKind.Relative));
                    break;
                case 2:
                    o2.Source = new BitmapImage(new Uri("Images/P.png", UriKind.Relative));
                    break;



            }



            



        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
   

