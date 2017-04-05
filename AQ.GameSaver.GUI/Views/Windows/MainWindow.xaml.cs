using System.Collections.ObjectModel;
using System.Linq;
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
        private ScoreCardRepository _scoreCardRepository;
        private ScoreCardRepository _guildRepository;

        public ObservableCollection<ScoreCard> ScoreCards { get; }

        public MainWindow()
        {
            InitializeComponent();
            ScoreCards = new ObservableCollection<ScoreCard>();
            _scoreCardRepository = ScoreCardRepository._instance;
            var allGames =_scoreCardRepository.GetAll();

            ScoreCards.Concat(allGames);
            AllGames.ItemsSource = ScoreCards;
        }

        private void NewGame_Button(object sender, RoutedEventArgs e)
        {
            var newGameWindow = new NewGame();
            newGameWindow.ShowDialog();
        }

        private void EditGuild_Button(object sender, RoutedEventArgs e)
        {

        }

        private void SaveScoreCard_Button(object sender, RoutedEventArgs e)
        {

        }
    }
}
