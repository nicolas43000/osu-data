using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace osu_data
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, std = "osu! Standard", taiko = "osu! Taiko", ctb = "osu! Catch the beat", mania = "osu! Mania", osuPath = "https://osu.ppy.sh/api/";
            int mode;

            //Please put your api key here
            string apiKey = "52e6d0d12d86b81d54028320b68fdacc577c59c4";

            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("Please provide a valid api key in Program.cs before using");
            }
            else
            {
                Console.WriteLine("Welcome, please chose a player name :");

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

                List<User> myUser = new List<User>();
                myUser = JsonConvert.DeserializeObject<List<User>>(rawJson);

                Console.WriteLine("\nPseudo : " + myUser[0].Username);
                Console.WriteLine("\nRank : " + myUser[0].Pp_rank);
                Console.WriteLine("\nPP : " + myUser[0].Pp_raw);
                Console.WriteLine("\nAccuracy : " + myUser[0].Accuracy + "%");
            }
        }
    }
}
