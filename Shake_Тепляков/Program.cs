using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shake_Тепляков
{
    internal class Program
    {
        public static List<Leaders> Leaders = new List<Leaders>();
        public static List<ViewModelUserSettings> ViewModelUserSettings = new List<ViewModelUserSettings>();
        public static List<ViewModelGames> ViewModelGames = new List<ViewModelGames>();
        private static int localPort = 5001;
        public static int MaxSpeed = 15;

        static void Main(string[] args)
        {
        }
    }
}
