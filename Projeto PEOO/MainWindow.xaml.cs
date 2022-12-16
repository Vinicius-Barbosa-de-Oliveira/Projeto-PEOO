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

namespace Projeto_PEOO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Time time;

        private void AddTime_Click(object sender, RoutedEventArgs e)
        {
            time = new Time(NomeTime.Text, EstadoTime.Text);

            MessageBox.Show("Time Cadastrado.");
        }

        private void AddJogador_Click(object sender, RoutedEventArgs e)
        {
            Jogador j = new Jogador(NomeJogador.Text, Camisa.Text, int.Parse(Gols.Text));
            time.Inserir(j);

            MessageBox.Show("Jogador Cadastrado.");

            list.ItemsSource = null;
            list.ItemsSource = time.Listar();
        }


        private void artilheiro(object sender, RoutedEventArgs e)
        {
            art.Items.Clear();
            art.Items.Add(time.Artilheiro());
        }
    }
}
