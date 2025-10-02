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
using System.Diagnostics;

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
		List<int> feladatSzamok = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            f = new Feladatok();
            lista = f.Lista;
			feladatSzamok.Clear();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            lb_adatok.ItemsSource = lista;   
		}

		private void harmadik_Click(object sender, RoutedEventArgs e)
		{           
            //MessageBox.Show(this,f.F3(),"Harmadik feladat",MessageBoxButton.OK,MessageBoxImage.Information);
			feladatSzamok.Add(3);
            kiiras(f.F3(),3);
        }

        private void kiiras(string adat, int feladatSzam)
        {
			szoveg.Add(adat);
            szoveg = szoveg.Distinct().ToList();
            lb_szoveg.ItemsSource = szoveg;
            lb_szoveg.Items.Refresh();
        }

		private void negyedik_Click(object sender, RoutedEventArgs e)
		{
            kiiras(f.F4(),4);
			feladatSzamok.Add(4);
        }

		private void otodik_Click(object sender, RoutedEventArgs e)
		{
            kiiras(f.F5(),5);
			feladatSzamok.Add(5);
        }

		private void btn_torles_Click(object sender, RoutedEventArgs e)
		{
			szoveg.Clear();
			lb_szoveg.ItemsSource = szoveg;
			lb_szoveg.Items.Refresh();
        }

		private void hatodik_Click(object sender, RoutedEventArgs e)
		{
			kiiras(f.F6(),6);
			feladatSzamok.Add(6);
        }

		private void hetedik_Click(object sender, RoutedEventArgs e)
		{
			kiiras(f.F7(),7);
			feladatSzamok.Add(7);
        }
	}
}