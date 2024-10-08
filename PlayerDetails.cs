using System;

namespace Helloworld
{
    class Welcome
    {
        public static void Main(String[] args)
        {
            int pno,nom,run,wic;
            String name,team;
            float batavg,bowavg;
            Console.WriteLine("Enter the Player Details");
            Console.WriteLine("Player no:");
            pno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            name=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Team:");
            team=Convert.ToString(Console.ReadLine());
            Console.WriteLine("No of Matches:");
            nom=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Runs:");
            run=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wickets:");
            wic=Convert.ToInt32(Console.ReadLine());
            batavg=run/nom;
            bowavg=wic/nom;
            Console.WriteLine("Player Details");
            Console.WriteLine("Player no:"+pno);
            Console.WriteLine("name:"+name);
            Console.WriteLine("team:"+team);
            Console.WriteLine("No of Matches:"+nom);
            Console.WriteLine("runs:"+run);
            Console.WriteLine("Wickets:"+wic);
            Console.WriteLine("bat average:"+batavg);
            Console.WriteLine("bow average:"+bowavg);
        }
    }
}