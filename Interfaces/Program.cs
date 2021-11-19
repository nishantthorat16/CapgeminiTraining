using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVideoPlayer player = new Phone();
            player.Play("C:\test.mp3");

            IVideoPlayer tablet = new Tablet();
            tablet.Play("c:\test.mp3");

            IVideoPlayer tv = new Tv();
            tv.Play("c:\test.mp3");
        }
    }
}
