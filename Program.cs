using GameDataParser.App;
using GameDataParser.DataAccess;
using GameDataParser.Logging;
using GameDataParser.UserInterface;
using System.IO.Enumeration;
using System.Text.Json;



var userInterctor = new ConsoleUserInteractor();
var app = new GameDataParserApp(userInterctor,
    new GamesPrinter(userInterctor),
    new VideoGamesDesializer(userInterctor),
    new LocalFileReader());
   
var logger = new Logger("log.txt");



try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("The application experienced an unexpexter error and will have to be closed.");
    logger.Log(ex);
}



Console.WriteLine("Press any key to close.");
Console.ReadKey();












