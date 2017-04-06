using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Guilds;
using AQ.GameSaver.Guilds.Enums;
using AQ.GameSaver.GUI.Views.Windows;
using AQ.GameSaver.Repositories;
using AQ.GameSaver.Score_Card;

namespace AQ.GameSaver.GUI.Views.User_Controls
{
    /// <summary>
    /// Interaction logic for AddTeamUC.xaml
    /// </summary>
    public partial class AddTeamUC : UserControl
    {
        private HeroCardRepository _heroCardRepository;
        private GuildRepository _guildRepository;

        public AddTeamUC()
        {
            InitializeComponent();
            _heroCardRepository = HeroCardRepository._instance;
            _guildRepository = GuildRepository._instance;

            var allHeroes = _heroCardRepository.GetAll();

            GuildTeam.ItemsSource = Enum.GetValues(typeof(Team));

            HeroOne.ItemsSource = allHeroes;
            HeroTwo.ItemsSource = allHeroes;
            HeroThree.ItemsSource = allHeroes;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            var editGamesWindow = (EditGames)parentWindow;

            var game = (ScoreCard)editGamesWindow.ListOfAllGames.SelectedItem;

            if (game != null && GuildTeam.SelectedItem != null && PlayerName.Text != "")
            {
                var selectedTeam = (Team)GuildTeam.SelectedItem;

                AddTeamToGame(game, selectedTeam, PlayerName.Text);
                ClearWindow();
            }
            else
            {
                MessageBox.Show("Must add a team color and a game.");
            }
        }

        private void AddTeamToGame(ScoreCard game, Team team, string playerName)
        {
            var guild = new Guild(team, game.Id, playerName);
            var allGuildsInGame =_guildRepository.GetAll().Where(x => x.GameId == game.Id);


            if (allGuildsInGame.Count(x => x.Team == guild.Team) > 0)
            {
                MessageBox.Show("There is already a team with that color in this game.");
            }
            else
            {
                AddHeroes(guild);
                _guildRepository.Add(guild);
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

        private void ClearWindow()
        {
            Window parentWindow = Window.GetWindow(this);
            var editGamesWindow = (EditGames)parentWindow;

            editGamesWindow.AddTeamControlView.Content = null;
        }

    }
}
