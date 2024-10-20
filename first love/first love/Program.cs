using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {


        static void Main(string[] args)
        {
            //Hamid......H_dtnb in telegram
            //Just a little Stopwatch ...
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //Everything in this Region will be counted by the Stopwatch
            #region Time
            GermanHym();
            //TetrisSound();
            //GermanHym();
            #endregion
            //End of Time

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                                                ts.Minutes,
                                                ts.Seconds,
                                                ts.Milliseconds / 10);
            Console.WriteLine("\n\nDuration of this Song was  " + elapsedTime);
            Console.ReadKey();
            Console.WriteLine("Press any Key to exit ...");


            //Some other Stuff you like to mess up with ...
            //System.Media.SystemSounds.Beep.Play();
            //System.Media.SystemSounds.Asterisk.Play();      
            //System.Media.SystemSounds.Exclamation.Play();


        }

        private static void GermanHym()
        {
            //The German Hymne

            Console.WriteLine("maybe german ...");

            Console.Beep(704, 750);
            Console.Beep(792, 250);
            Console.Beep(880, 500);
            Console.Beep(792, 500);
            Console.Beep(940, 500);
            Console.Beep(880, 500);
            Console.Beep(792, 250);
            Console.Beep(660, 250);
            Console.Beep(704, 500);
            Console.Beep(1188, 500);
            Console.Beep(1056, 500);
            Console.Beep(940, 500);
            Console.Beep(880, 500);
            Console.Beep(792, 500);
            Console.Beep(880, 250);
            Console.Beep(704, 250);
            Console.Beep(1056, 1000);
            Console.Beep(704, 750);
            Console.Beep(792, 250);
            Console.Beep(880, 500);
            Console.Beep(792, 500);
            Console.Beep(940, 500);
            Console.Beep(880, 500);
            Console.Beep(792, 250);
            Console.Beep(660, 250);
            //Hamid......H_dtnb in telegram
            Console.Beep(704, 500);
            Console.Beep(1188, 500);
            Console.Beep(1056, 500);
            Console.Beep(940, 500);
            Console.Beep(880, 500);
            Console.Beep(792, 500);
            Console.Beep(880, 250);
            Console.Beep(704, 250);
            Console.Beep(1056, 1000);
            Console.Beep(792, 500);
            Console.Beep(880, 500);
            Console.Beep(792, 250);
            Console.Beep(660, 250);
            Console.Beep(528, 500);
            Console.Beep(940, 500);
            Console.Beep(880, 500);
            Console.Beep(792, 250);
            Console.Beep(660, 250);
            Console.Beep(528, 500);
            Console.Beep(1056, 500);
            Console.Beep(940, 500);
            Console.Beep(880, 750);
            Console.Beep(880, 250);
            Console.Beep(990, 500);
            Console.Beep(940, 250);
            Console.Beep(1056, 250);
            Console.Beep(1056, 1000);
            Console.Beep(1408, 750);
            Console.Beep(1320, 250);
            Console.Beep(1320, 250);
            Console.Beep(1188, 250);
            Console.Beep(1056, 500);
            Console.Beep(1188, 750);
            Console.Beep(1056, 250);
            Console.Beep(1056, 250);
            Console.Beep(940, 250);
            Console.Beep(880, 500);
            Console.Beep(792, 750);
            Console.Beep(880, 125);
            Console.Beep(940, 125);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(940, 250);
            Console.Beep(792, 250);
            Console.Beep(704, 500);
            Console.Beep(880, 250);
            Console.Beep(792, 250);
            Console.Beep(704, 1000);
            Console.Beep(1408, 750);
            Console.Beep(1320, 250);
            Console.Beep(1320, 250);
            Console.Beep(1188, 250);
            Console.Beep(1056, 500);
            Console.Beep(1188, 750);
            Console.Beep(1056, 250);
            Console.Beep(1056, 250);
            Console.Beep(940, 250);
            Console.Beep(880, 500);
            Console.Beep(792, 750);
            Console.Beep(880, 125);
            Console.Beep(940, 125);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(940, 250);
            Console.Beep(792, 250);
            Console.Beep(704, 500);
            Console.Beep(880, 250);
            Console.Beep(792, 250);
            Console.Beep(704, 1000);
        }

        private static void TetrisSound()
        {
            Console.WriteLine("maybe tetris");

            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            System.Threading.Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            System.Threading.Thread.Sleep(500);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            //Hamid......H_dtnb in telegram
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            System.Threading.Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            System.Threading.Thread.Sleep(500);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
        }


    }
}