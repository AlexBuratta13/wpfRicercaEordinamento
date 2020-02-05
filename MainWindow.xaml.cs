using System;
using System.Collections.Generic;
using System.IO;
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

namespace wpfRicercaEordinamento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> ListaNomi = new List<string>();
        public const string FILE = "file.txt";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_inserisci_Click(object sender, RoutedEventArgs e)
        {
            string nomi = txt_nome.Text;
            ListaNomi.Add(nomi);
            ListaNomi.Sort();
            txt_nome.Clear();
            txtRis.Clear();
            foreach (string name in ListaNomi)
            {
                txtRis.Text += $"{name}\n";
            }
        }
        private void btn_salva_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("file.txt", false, Encoding.UTF8);
            {
                for(int i = 0; i < ListaNomi.Count; i++)
                {
                    sw.Write($"{ListaNomi}");
                }
            }
        }
    }
}
