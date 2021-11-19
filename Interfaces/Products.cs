using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*
     1. In an interface you cannot provide access specifies 
        to the members
     2. If a class in implementing an interface. Class has to provide
        defenition to all methods and properties
     3. We can have interface inheriting from another interface
     */
    public interface IMediaPlayer
    {
        void Stop();
        void Pause();
    }

    public interface IVideoPlayer : IMediaPlayer
    {
        void Play(string fileName);
    }

    public interface IAudioPlayer : IMediaPlayer { }
    public class AirPods 
    {
    }
    public class Phone : IVideoPlayer
    {
        public void Pause()
        {
            Console.WriteLine("Pausing Media on phone");
        }

        public void Play(string fileName)
        {
            Console.WriteLine("Pllaying Video on phone");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping Media on phone");
        }
    }

    public class Tablet : IVideoPlayer
    {
        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play(string fileName)
        {
            Console.WriteLine("Playing Video on Tablet");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Tv : IVideoPlayer
    {
        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play(string fileName)
        {
            Console.WriteLine("Playing Video on Tv");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
