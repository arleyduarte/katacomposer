using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataComposer.Kata
{
    public class Orchestrator
    {




        private IList<Movement> movements = new List<Movement>();

        public void AddMovement(Movement movement)
        {
            movements.Add(movement);
        }


        public int Miliseconds(int centiseconds)
        {
            return centiseconds * 10;
        }

        private String GetSoundFile(String fileName)
        {

            return  AppDomain.CurrentDomain.BaseDirectory + "\\Sounds\\"+fileName;
        }

        public void Play()
        {
            foreach(Movement movement in movements)
            {

                String filePath = GetSoundFile(movement.Sound.FileName);

                var file = new AudioFileReader(filePath);
                var trimmed = new OffsetSampleProvider(file);
                trimmed.SkipOver = TimeSpan.FromMilliseconds(movement.SkipOver);
              //  trimmed.Take = TimeSpan.FromMilliseconds(movement.Sound.Time);

                var player = new WaveOutEvent();
                player.Init(trimmed);


                long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();

                Debug.WriteLine("Play "+ JsonConvert.SerializeObject(movement),Convert.ToString(milliseconds));
                player.Play();

                System.Threading.Thread.Sleep(Miliseconds(movement.Sound.Centiseconds));

                player.Stop();
                Debug.WriteLine("Stop ");




            }





        }
    }
}
