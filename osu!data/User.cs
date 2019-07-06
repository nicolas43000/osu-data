using System;
using System.Collections.Generic;
using System.Text;

namespace osu_data
{
    class User
    {
        private int user_id;
        private string username;
        private DateTime join_date;
        private int count300;
        private int count100;
        private int count50;
        private int playcount;
        private string ranked_score;
        private string total_score;
        private string pp_rank;
        private double level;
        private double pp_raw;
        private double accuracy;
        private int count_rank_ss;
        private int count_rank_ssh;
        private int count_rank_s;
        private int count_rank_sh;
        private int count_rank_a;
        private string country;
        private int total_seconds_played;
        private string pp_county_rank;

        public void user(int user_id, string username, DateTime join_date, int count300, int count100, int count50, int playcount, string ranked_score, string total_score, string pp_rank, double level, double pp_raw, double accuracy, int count_rank_ss, int count_rank_ssh, int count_rank_s, int count_rank_sh, int count_rank_a, string country, int total_seconds_played, string pp_county_rank)
        {
            this.User_id = user_id;
            this.Username = username;
            this.Join_date = join_date;
            this.Count300 = count300;
            this.Count100 = count100;
            this.Count50 = count50;
            this.Playcount = playcount;
            this.Ranked_score = ranked_score;
            this.Total_score = total_score;
            this.Pp_rank = pp_rank;
            this.Level = level;
            this.Pp_raw = pp_raw;
            this.Accuracy = accuracy;
            this.Count_rank_ss = count_rank_ss;
            this.Count_rank_ssh = count_rank_ssh;
            this.Count_rank_s = count_rank_s;
            this.Count_rank_sh = count_rank_sh;
            this.Count_rank_a = count_rank_a;
            this.Country = country;
            this.Total_seconds_played = total_seconds_played;
            this.Pp_county_rank = pp_county_rank;
        }

        public int User_id { get => user_id; set => user_id = value; }
        public string Username { get => username; set => username = value; }
        public DateTime Join_date { get => join_date; set => join_date = value; }
        public int Count300 { get => count300; set => count300 = value; }
        public int Count100 { get => count100; set => count100 = value; }
        public int Count50 { get => count50; set => count50 = value; }
        public int Playcount { get => playcount; set => playcount = value; }
        public string Ranked_score { get => ranked_score; set => ranked_score = value; }
        public string Total_score { get => total_score; set => total_score = value; }
        public string Pp_rank { get => pp_rank; set => pp_rank = value; }
        public double Level { get => level; set => level = value; }
        public double Pp_raw { get => pp_raw; set => pp_raw = value; }
        public double Accuracy { get => accuracy; set => accuracy = value; }
        public int Count_rank_ss { get => count_rank_ss; set => count_rank_ss = value; }
        public int Count_rank_ssh { get => count_rank_ssh; set => count_rank_ssh = value; }
        public int Count_rank_s { get => count_rank_s; set => count_rank_s = value; }
        public int Count_rank_sh { get => count_rank_sh; set => count_rank_sh = value; }
        public int Count_rank_a { get => count_rank_a; set => count_rank_a = value; }
        public string Country { get => country; set => country = value; }
        public int Total_seconds_played { get => total_seconds_played; set => total_seconds_played = value; }
        public string Pp_county_rank { get => pp_county_rank; set => pp_county_rank = value; }
    }
}
