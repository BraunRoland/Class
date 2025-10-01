using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Feladatok f;
        List<Merkozes> lista;
        List<string> szoveg = new List<string>();
		public MainWindow()
        {
            InitializeComponent();
            f = new Feladatok();
            lista = f.Lista;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            lb_adatok.ItemsSource = lista;   
		}

		private void harmadik_Click(object sender, RoutedEventArgs e)
		{           
            //MessageBox.Show(this,f.F3(),"Harmadik feladat",MessageBoxButton.OK,MessageBoxImage.Information);
            kiiras(f.F3());
		}

        private void kiiras(string adat)
        {
            lb_szoveg.ItemsSource = null;
			if (szoveg.Contains(adat) == false)
            {
                szoveg.Add(adat);
				lb_szoveg.ItemsSource = szoveg;
			}
		}

		private void negyedik_Click(object sender, RoutedEventArgs e)
		{
            kiiras(f.F4());
		}

		private void otodik_Click(object sender, RoutedEventArgs e)
		{
            kiiras(f.F5());
		}

		private void btn_torles_Click(object sender, RoutedEventArgs e)
		{
			szoveg.Clear();
			lb_szoveg.ItemsSource = szoveg;
		}

		private void hatodik_Click(object sender, RoutedEventArgs e)
		{
			kiiras(f.F6());
		}

		private void hetedik_Click(object sender, RoutedEventArgs e)
		{
			kiiras(f.F7());
		}
	}
}