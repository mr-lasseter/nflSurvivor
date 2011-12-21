using System.Configuration;

namespace NflSurvivior.Core.Utility
{
    public class Settings
    {
        public static string EspnFeedUrl { get { return ConfigurationManager.AppSettings["EspnFeedUrl"]; } }
    }
}