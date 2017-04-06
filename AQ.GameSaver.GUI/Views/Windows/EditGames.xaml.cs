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

namespace AQ.GameSaver.GUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for EditGames.xaml
    /// </summary>
    public partial class EditGames : Window
    {
        private ScoreCardRepository _scoreCardRepository;

        public EditGames()
        {
            InitializeComponent();

            _scoreCardRepository = ScoreCardRepository._instance;

            if (_scoreCardRepository.GetAll().Count() != 0)
            {
                ListOfAllGames.ItemsSource = _scoreCardRepository.GetAll();
            }
        }

        private void AddTeamButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddTeamControlView.Content = new AddTeamUC();
        }

        private void EditGuildsButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddTeamControlView.Content = new AddTeamUC();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);

            Window currentMainWindow = Window.GetWindow(Application.Current.MainWindow);
            var mainWindow = (MainWindow)currentMainWindow;

            mainWindow.AllGames.ItemsSource = _scoreCardRepository.GetAll();
            this?.Close();
        }
    }
}
