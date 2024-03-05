using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            twitchStream.name = "markiplier";
            twitchStream.LastStreamName = "laying Scary Games Don't Come";
            twitchStream.streamGame = (new Game("Random scray games and demo's"));
            twitchStream.followers = 2500000;
            twitchStream.automod = true;

            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?


            Console.WriteLine("Hello, World!");
        }
    }
}