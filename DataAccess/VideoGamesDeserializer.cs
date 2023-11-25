
using GameDataParser.Model;
using GameDataParser.UserInterface;
using System.Text.Json;

namespace GameDataParser.DataAccess
{
    public class VideoGamesDesializer : IVideoGamesDesializer
    {
        private readonly IUserInteractor _userInteractor;

        public VideoGamesDesializer(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public List<VideoGame> DeserializeVideoGamesFrom(string fileName, string fileContents)
        {

            try
            {

                return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch (JsonException ex)
            {

                _userInteractor.PrintError($"JSON inf {fileName} file was not in a valid format. JSON body:");
                _userInteractor.PrintError(fileContents);

                throw new JsonException($"{ex.Message} The file is: {fileName}", ex);

            }

        }
    }
}
