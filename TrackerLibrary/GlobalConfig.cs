﻿using System.Configuration;
using TrackerLibrary.Connections;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizesFile.csv";
        public const string PersonsFile = "PersonsFile.csv";
        public const string TeamsFile = "TeamsFile.csv";
        public const string TournamentsFile = "TournamentsFile.csv";
        public const string MatchupsFile = "MatchupsFile.csv";
        public const string MatchupEntriesFile = "MatchupEntriesFile.csv";

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType dbType)
        {
            switch (dbType)
            {
                case DatabaseType.SQL:
                    Connection = new SQLConnector();
                    break;
                case DatabaseType.FILES:
                    Connection = new FileConnector();
                    break;
                default:
                    break;
            }
        }

        public static string WinnerDetermination()
        {
            return ConfigurationManager.AppSettings["winnerDetermination"];
        }

        public static string UserEmail()
        {
            return ConfigurationManager.AppSettings["userEmail"];
        }

        public static string AppKey()
        {
            return ConfigurationManager.AppSettings["appKey"];
        }

        public static string FromName()
        {
            return ConfigurationManager.AppSettings["fromName"];
        }

        public static string EmailHost()
        {
            return ConfigurationManager.AppSettings["emailHost"];
        }

        public static int EmailPort()
        {
            return int.Parse(ConfigurationManager.AppSettings["emailPort"]);
        }

        public static string ConnectionString(string dbName)
        {
            return ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
        }

    }
}
