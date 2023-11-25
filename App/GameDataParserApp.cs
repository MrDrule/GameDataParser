using GameDataParser.DataAccess;
using GameDataParser.Model;
using GameDataParser.UserInterface;
using System;

namespace GameDataParser.App
{
    public class GameDataParserApp
    {
        private readonly IUserInteractor _userInteractor;
        private readonly IGamesPrinter _gamesPrinter;
        private readonly IVideoGamesDesializer _videoGamesDesializer;
        private readonly IFileReader _fileReader;

        public GameDataParserApp(
            IUserInteractor userInteractor,
            IGamesPrinter gamesPrinter,
            IVideoGamesDesializer videoGamesDesializer,
            IFileReader fileReader)
        {
            _userInteractor = userInteractor;
            _gamesPrinter = gamesPrinter;
            _videoGamesDesializer = videoGamesDesializer;
            _fileReader = fileReader;
        }

        public void Run()
        {
            string fileName = _userInteractor.ReadValidFilePath();
            var fileContents = _fileReader.Read(fileName);
            List<VideoGame> videoGames = _videoGamesDesializer.DeserializeVideoGamesFrom(fileName, fileContents);
            _gamesPrinter.Print(videoGames);

        }

    }
}
