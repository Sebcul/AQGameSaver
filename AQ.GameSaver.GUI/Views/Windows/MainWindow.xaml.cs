using System.Windows;
using AQ.GameSaver.GUI.Views.Windows;
using AQ.GameSaver.Repositories;
using AQ.GameSaver.Score_Card;

namespace AQ.GameSaver.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var scoreCardRepository = ScoreCardRepository._instance;
        }

        private void NewGame_Button(object sender, RoutedEventArgs e)
        {
            var newGameWindow = new NewGame();
            newGameWindow.Show();
        }

        private void EditGuild_Button(object sender, RoutedEventArgs e)
        {

        }

        private void SaveScoreCard_Button(object sender, RoutedEventArgs e)
        {

        }
    }
}
