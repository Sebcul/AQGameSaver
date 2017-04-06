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
using AQ.GameSaver.Score_Card;

namespace AQ.GameSaver.GUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : Window
    {
        public NewGame()
        {
            InitializeComponent();
            ControlView.Content = new AddFirstTeamUC();
        }

    }
}
