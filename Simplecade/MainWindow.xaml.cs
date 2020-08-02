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
using Simplecade.Data;
using Simplecade.ViewModel;

namespace Simplecade
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
        }

        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else if (e.Key == Key.D1 && GameList.SelectedItem != null)
            {
                var viewModel = DataContext as MainViewModel;
                viewModel.StartGame(GameList.SelectedItem as Game);
            }
        }

        private void OnActivated(object? sender, EventArgs e)
        {
            Video.LoadedBehavior = MediaState.Play;
        }

        private void OnDeactivated(object? sender, EventArgs e)
        {
            Video.LoadedBehavior = MediaState.Stop;
        }
    }
}
