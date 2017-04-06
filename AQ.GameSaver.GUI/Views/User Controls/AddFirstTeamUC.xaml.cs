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
using AQ.GameSaver.Cards;
using AQ.GameSaver.Guilds;
using AQ.GameSaver.Guilds.Enums;
using AQ.GameSaver.GUI.Views.Windows;
using AQ.GameSaver.Repositories;
using AQ.GameSaver.Score_Card;

namespace AQ.GameSaver.GUI.Views.User_Controls
{
    /// <summary>
    /// Interaction logic for AddFirstTeamUC.xaml
    /// </summary>
    public partial class AddFirstTeamUC : UserControl
    {
        public AddFirstTeamUC()
        {
            InitializeComponent();
            InitializeComponent();
            _heroCardRepository = HeroCardRepository._instance;
            _guildRepository = GuildRepository._instance;
            _scoreCardRepository = ScoreCardRepository._instance;

            var allHeroes = _heroCardRepository.GetAll();


            HeroOne.ItemsSource = allHeroes;
            HeroTwo.ItemsSource = allHeroes;
            HeroThree.ItemsSource = allHeroes;

            GuildTeam.ItemsSource = Enum.GetValues(typeof(Team));
        }

        private HeroCardRepository _heroCardRepository;
        private GuildRepository _guildRepository;
        private ScoreCardRepository _scoreCardRepository;


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            var newGameWindow = (NewGame)parentWindow;


            string gameName = newGameWindow.GameName.Text;

            var scoreCard = new ScoreCard(gameName);

            if (gameName != "" && GuildTeam.SelectedItem != null)
            {
                SaveGame(scoreCard);

                CloseWindowAndUpdateAllGamesList();
            }
            else
            {
                MessageBox.Show("Must add a team color and a game name.");
            }
        }

        private void SaveGame(ScoreCard scoreCard)
        {
            Guild guild;
            if (IsScoreCardNameAvailable(scoreCard))
            {
                guild = new Guild((Team)GuildTeam.SelectedItem, scoreCard.Id, PlayerName.Text);
                AddHeroes(guild);
                _guildRepository.Add(guild);
                _scoreCardRepository.Add(scoreCard);
            }
            else
            {
                MessageBox.Show("Game is already created.");
            }
        }

        private void AddHeroes(Guild guild)
        {
            var heroOne = (HeroCard)HeroOne.SelectedItem;
            var heroTwo = (HeroCard)HeroOne.SelectedItem;
            var heroThree = (HeroCard)HeroOne.SelectedItem;
            if (heroOne != null && heroTwo != null && heroThree != null)
            {
                guild.AddHero(heroOne);
                guild.AddHero(heroTwo);
                guild.AddHero(heroThree);
            }
            else
            {
                MessageBox.Show("Must add all three heroes.");
            }

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            CloseWindowAndUpdateAllGamesList();
        }

        private void CloseWindowAndUpdateAllGamesList()
        {
            Window parentWindow = Window.GetWindow(this);

            Window currentMainWindow = Window.GetWindow(Application.Current.MainWindow);
            var mainWindow = (MainWindow)currentMainWindow;

            mainWindow.AllGames.ItemsSource = _scoreCardRepository.GetAll();

            parentWindow?.Close();
        }

        private bool IsScoreCardNameAvailable(ScoreCard scoreCard)
        {
            var allScoreCards = _scoreCardRepository.GetAll();

            if (allScoreCards.FirstOrDefault(sc => sc.Name == scoreCard.Name) == null)
            {
                return true;
            }
            return false;
        }
    }
}
