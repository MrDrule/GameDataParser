using GameDataParser.Model;

namespace GameDataParser.DataAccess
{
    public interface IVideoGamesDesializer
    {
        List<VideoGame> DeserializeVideoGamesFrom(string fileName, string fileContents);
    }
}
