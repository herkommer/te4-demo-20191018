using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            VHS v = new VHS();
            v.Play();
            v.Stop();

            Bluray b = new Bluray();
            b.Play();

            //
            IPlay anka;
            anka = v;
            anka.Play();

            anka = b;
            anka.Play();
        }
    }

    public interface IPlay
    {
        void Stop();
        void FastForward();
        void Play();

    }

    public interface ITechnical
    {
        void SettingRegion();
    }

    public class VHS : IPlay
    {
        public void FastForward()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            Console.WriteLine("VHS is playing");
        }

        public void Stop()
        {
            Console.WriteLine("VHS is stopping");
        }
    }

    public class Bluray : IPlay, ITechnical
    {
        private string regionDecoder;

        public void FastForward()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            Console.WriteLine("Bluray is playing");
        }

        public void SettingRegion()
        {
            regionDecoder="EU";
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Netflix
    {

    }
}
