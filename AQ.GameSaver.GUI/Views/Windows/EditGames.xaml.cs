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
using System.Windows.Shapes;
using AQ.GameSaver.GUI.Views.User_Controls;
using AQ.GameSaver.Repositories;
using AQ.GameSaver.Score_Card;

namespace AQ.GameSaver.GUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for EditGames.xaml
    /// </summary>
    public partial class EditGames : Window
    {
        private ScoreCardRepository _scoreCardRepository;
        private GuildRepository _guildRepository;
        private ScoreCard _selectedGame;

        public EditGames()
        {
            InitializeComponent();

            _scoreCardRepository = ScoreCardRepository._instance;
            _guildRepository = GuildRepository._instance;

            if (_scoreCardRepository.GetAll().Count() != 0)
            {
                ListOfAllGames.ItemsSource = _scoreCardRepository.GetAll();
            }
        }

        private void AddTeamButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddTeamControlView.Content = new AddTeamUC();
            GuildDropDown.Visibility = Visibility.Hidden;
        }

        private void EditGuildsButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddTeamControlView.Content = new EditTeamUC();
            GuildDropDown.Visibility = Visibility.Visible;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Window currentMainWindow = Window.GetWindow(Application.Current.MainWindow);
            var mainWindow = (MainWindow)currentMainWindow;

            mainWindow.AllGames.ItemsSource = _scoreCardRepository.GetAll();
            this?.Close();
        }

        private void ListOfAllGames_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedGame = (ScoreCard)ListOfAllGames.SelectedItem;
            if (_selectedGame != null)
            {
                ListOfAllGuildsInGame.ItemsSource = _guildRepository.GetAll().Where(x => x.GameId == _selectedGame.Id);
            }
        }


        private void ListOfAllGuildsInGame_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var loadedTeam = new EditTeamUC();
            var allHeroes = _guildRepository.GetAll().Where(x => x.GameId == _selectedGame.Id);

            loadedTeam.HeroOne.SelectedItem = allHeroes.ElementAt(0);

            AddTeamControlView.Content = loadedTeam;
        }
    }
}
