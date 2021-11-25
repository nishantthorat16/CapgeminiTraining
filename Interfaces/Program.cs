using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            IVideoPlayer player = new Phone();
            player.Play("C:\test.mp3");

            IVideoPlayer tablet = new Tablet();
            tablet.Play("c:\test.mp3");

            IVideoPlayer tv = new Tv();
            tv.Play("c:\test.mp3");*/

            Console.Write("Enter the file name :");
            string fileName = Console.ReadLine();

            Console.Write("Where do you want to play this : ");
            string deviceName = Console.ReadLine();

            /*
            if(deviceName == "Phone")
            {
                Phone p = new Phone();
                p.Play(fileName);
            }
            else if(deviceName== "Tablet")
            {
                Tablet tablet = new Tablet();
                tablet.Play(fileName);
            }*/

            IVideoPlayer player = GetPlayer(deviceName);
            player.Play(fileName);
        }

        //Dependency Container
        static IVideoPlayer GetPlayer(string name)
        {
            IVideoPlayer player = null;

            switch (name)
            {
                case "Phone": player    = new Phone();break;
                case "Tablet": player   = new Tablet(); break;
                case "Tv": player       = new Tv(); break;
            }

            return player;
        }
    }
}
