using System.IO;
using System.Net;
using NflSurvivior.Core.Utility;

namespace NflSurvivior.Core.Tasks
{
    public interface IEspnFeedService
    {
        string GetScoreBoard();
    }

    public class EspnFeedService : IEspnFeedService
    {
        public string GetScoreBoard()
        {
            var request = WebRequest.Create(Settings.EspnFeedUrl);
            var response = request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());

            return reader.ReadToEnd();
        }
    }
}