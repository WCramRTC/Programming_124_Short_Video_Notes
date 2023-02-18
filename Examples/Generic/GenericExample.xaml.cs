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

namespace Programming_124_Short_Video_Notes.Examples.Generic
{
    /// <summary>
    /// Interaction logic for GenericExample.xaml
    /// </summary>
    public partial class GenericExample : Window
    {
        public GenericExample()
        {
            InitializeComponent();
            TeamRoster<BaseballPlayer> baseBallRoster = new TeamRoster<BaseballPlayer>();
            baseBallRoster.AddPlayer(new BaseballPlayer("Ichiro Susuki", "51", 1000,1000,1000));

            Display<BaseballPlayer>(baseBallRoster);
        }

        void Display<T>(TeamRoster<T> roster) where T : Player
        {
            lbDisplay.Items.Clear();

            foreach (T item in roster)
            {
                lbDisplay.Items.Add(item);
            }
        }
    }
}
