using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            StatList<string> player = new StatList<string>();
            player.Add("Lebron James");
            player.Add("Russell Westbrook");
            player.Add("Kevin Durant");
            player.Add("James Harden");
            player.Add("Stephen Curry");
            player.Remove("Anthony Davis");
            

            StatList<int> ponits = new StatList<int>();
            ponits.Add("22");
            ponits.Add("34");
            ponits.Add("30");
            ponits.Add("32");
            ponits.Add("25");
            ponits.Remove("30");
           

            StatList<int> rebounds = new StatList<int>();
            rebounds.Add("10");
            rebounds.Add("10");
            rebounds.Add("9");
            rebounds.Add("7");
            rebounds.Add("2");
            rebounds.Remove("12");

            List<string> playerList = new List<string> { "Lebron James", "Russell Wesbrook", "Kevin Durrant", "James Harden", "Stephen Curry", "Anthony Davis" };
            List<string> ponitsAverage = new List<string> { "22", "34", "30", "32", "25", "30" };
            List<string> reboundsAverage = new List<string> { "10", "10", "9", "7", "2", "12" };

            var result = CombineListsByLayers(playerList, ponitsAverage, reboundsAverage);
        }

        public static List<string>[] CombineListsByLayers(params List<string>[] sourceLists)
        {
            var results = new List<string>[sourceLists[0].Count];

            for (var i = 0; i < results.Length; i++)
            {
                results[i] = new List<string>();
                foreach (var sourceList in sourceLists)
                    results[i].Add(sourceList[i]);
            }
            return results;
        }


    }
    }

