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
using AQ.GameSaver.GUI.Views.Windows;

namespace AQ.GameSaver.GUI.Views.User_Controls
{
    /// <summary>
    /// Interaction logic for EditTeamUC.xaml
    /// </summary>
    public partial class EditTeamUC : UserControl
    {
        private EditGames _editGamesWindow;

        public EditTeamUC()
        {
            InitializeComponent();
            Window parentWindow = Window.GetWindow(this);
            _editGamesWindow = (EditGames)parentWindow;
        }

        public string Hej { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
