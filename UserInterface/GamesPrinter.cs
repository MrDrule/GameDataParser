using GameDataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.UserInterface
{

    public class GamesPrinter : IGamesPrinter
    {
        private readonly IUserInteractor _userInteractor;

        public GamesPrinter(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public void Print(List<VideoGame> videoGames)
        {
            if (videoGames.Count > 0)
            {

                _userInteractor.PrintMessage(
                    Environment.NewLine +
                    "Loaded Games are:");
                foreach (var videoGame in videoGames)
                {
                    _userInteractor.PrintMessage(videoGame.ToString());
                }
            }
        }
    }

}
