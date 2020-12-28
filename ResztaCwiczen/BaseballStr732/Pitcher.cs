﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballStr732
{
    class Pitcher
    {
        public ObservableCollection<string> PitcherSays = new ObservableCollection<string>();
        private int pitchNumber = 0;
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
        }
        void ball_BallInPlay(object sender, EventArgs e)
        {
            pitchNumber++;
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }
        private void CatchBall()
        {
            PitcherSays.Add("Rzut nr" + pitchNumber + ": Złapałem piłkę");
        }
        private void CoverFirstBase()
        {
            PitcherSays.Add("Pitch #" + pitchNumber + ": Pokryłem pierwszą bazę");
        }
    }
}
