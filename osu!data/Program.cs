using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using static osu_data.Methods;

namespace osu_data
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, std = "osu! Standard", taiko = "osu! Taiko", ctb = "osu! Catch the beat", mania = "osu! Mania", osuPath = "https://osu.ppy.sh/api/";
            int mode;

            string apiKey;
            
            Console.WriteLine("Welcome !");
            Console.WriteLine("In order to use this program, you need an API key. Get one here :");
            Console.WriteLine("https://osu.ppy.sh/p/api");
            Console.WriteLine("Once you have your API key, put it here and you will be able to use this program.");
            apiKey = Console.ReadLine();
            
            Console.WriteLine("Now chose a player name :");

            userName = Console.ReadLine();

            Console.WriteLine("\nNow chose a game mode : ");
            Console.WriteLine("0 for osu!Standard");
            Console.WriteLine("1 for osu!Taiko");
            Console.WriteLine("2 for osu!Catch the beat");
            Console.WriteLine("3 for osu!Mania");

            mode = Convert.ToInt32(Console.ReadLine());

            while (mode < 0 || mode > 3)
            {
                Console.WriteLine("\nPlease chose a value between 0 and 3 !");
                mode = Convert.ToInt32(Console.ReadLine());
            }

            switch (mode)
            {
                case 0:
                    Console.WriteLine("\nThe player is " + userName + " and the game mode is " + std);
                    break;
                case 1:
                    Console.WriteLine("\nThe player is " + userName + " and the game mode is " + taiko);
                    break;
                case 2:
                    Console.WriteLine("\nThe player is " + userName + " and the game mode is " + ctb);
                    break;
                case 3:
                    Console.WriteLine("\nThe player is " + userName + " and the game mode is " + mania);
                    break;
            }

            string fullPath = osuPath + "get_user?u=" + userName + "&m=" + mode + "&k=" + apiKey;
            Console.WriteLine("\nHere is the player's data path : " + fullPath);

            var client = new WebClient();
            String rawJson = client.DownloadString(fullPath);
            rawJson = removeFirstLastChar(rawJson);
            User myUser = JsonConvert.DeserializeObject<User>(rawJson);

            string player = myUser.Username;
            DateTime joined = myUser.Join_date;
            string country = myUser.Country;
            string rank = addSpace(myUser.Pp_rank);
            // string countryRank = addSpace(myUser.Pp_county_rank);
            double pp = Math.Round(myUser.Pp_raw, 0);
            double acc = Math.Round(myUser.Accuracy, 2);
            double playCount = myUser.Playcount;

            Console.WriteLine("\nPlayer : " + player);
            Console.WriteLine("Joined : " + joined.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine("Country : " + country);
            Console.WriteLine("Rank : " + rank);
            // Console.WriteLine("Country rank : " + countryRank);
            Console.WriteLine("PP : " + pp);
            Console.WriteLine("Accuracy : " + acc + "%");
            Console.WriteLine("Playcount : " + playCount);
            
            Console.WriteLine("\nPress enter to exit.");
            Console.Read();
        }
    }
}
