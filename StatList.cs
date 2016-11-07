using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class StatList<T> : IEnumerable

    {
        string player;
        int ponits;
        int rebounds;
        List<string> topPlayers;
        List<int> playerPonits;
        List<int> playerRebounds;
        

        public StatList()
        {
            topPlayers = new List<string>() { "Lebron James", "Russell Westbrook", "Kevin Durant", "James Harden", "Stephen Curry", "Anthony Davis" };
            playerPonits = new List<int>() { 22, 34, 30, 32, 25, 30 };
            playerRebounds = new List<int>() { 10, 10, 9, 7, 2, 12 };
          

        }

        public static StatList<T> operator + (StatList<T> statlist_1, StatList<T> statlist_2)
        {
            StatList<T> stat = new StatList<T>();

            stat.player = statlist_1.player + statlist_2.player;
            stat.ponits = statlist_1.ponits + statlist_2.ponits;
            stat.rebounds = statlist_1.rebounds + statlist_2.rebounds;
          
            return stat;
        }
        public static StatList<T> operator - (StatList<T> statlist_1, StatList<T> statlist_2)
        {
            StatList<T> stat = new StatList<T>();

            stat.player = statlist_1.player + statlist_2.player;
            stat.ponits = statlist_1.ponits + statlist_2.ponits;
            stat.rebounds = statlist_1.rebounds + statlist_1.rebounds;

            return stat;

        }

        public void PlayerStats()
        {
            Console.WriteLine(player + "," + ponits + "," + rebounds);
            Console.ReadLine();
        }


        public void Add(string name)
        {
          
           
        }
        public void Remove(string name)
        {

        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i <6; i++)
            {
               yield return i;
            }
        
        }
    }
}
