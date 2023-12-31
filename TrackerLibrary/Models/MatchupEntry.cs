﻿namespace TrackerLibrary.Models
{
    public class MatchupEntry
    {
        /// <summary>
        /// Unique ID of the Matchup Entry
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the Team ID from the database to look up the TeamCompeting
        /// </summary>
        public int TeamCompetingID { get; set; }

        /// <summary>
        /// Represents one Team in the matchup
        /// </summary>
        public Team TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the Matchup ID from the database to look up the ParentMatchup
        /// </summary>
        public int ParentMatchupID { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from as the winner
        /// </summary>
        public Matchup ParentMatchup { get; set; }

        /// <summary>
        /// Generates a string to display for the matchup
        /// </summary>
        public string DisplayName
        {
            get
            {
                string s = "";

                if (TeamCompeting != null)
                {
                    s += $"{TeamCompeting.TeamName}";
                }
                else if (ParentMatchup != null)
                {
                    s += $"Winner of {ParentMatchup.ID}";
                }

                return s;
            }
        }

        public MatchupEntry()
        {

        }

    }
}
