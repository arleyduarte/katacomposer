using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataComposer.Kata
{




    public class Movement
    {

        public enum Type
        {
            Slow,
            NoDisplacement,
            HalfDisplacement,

            FullDisplacement,
            SpinningJump,
            VeryShortPause,
            ShortPause,
            LongPause,

            Fast
        }

        public Movement(Type type)
        {


            Sound sound = new Sound();

            switch (type)
            {
                case Type.Slow:
                    {
                        sound.FileName = "slow.m4a";
                        sound.Centiseconds = 600;
                        break;
                    }
                case Type.NoDisplacement:
                    {
                        sound.FileName = "NoDisplacement.m4a";

                        //20 centecimas no alcanzan a sonar
                        sound.Centiseconds = 50;
                        this.SkipOver = 1000;
                        break;
                    }



                case Type.HalfDisplacement:
                    {
                        sound.FileName = "HalfDisplacement.m4a";
                        sound.Centiseconds = 60;
                        this.SkipOver = 1000;
                        break;
                    }

                case Type.FullDisplacement:
                    {
                        sound.FileName = "FullDisplacement.m4a";
                        sound.Centiseconds = 80;
                        this.SkipOver = 1000;
                        break;
                    }


                case Type.SpinningJump:
                    {
                        sound.FileName = "SpinningJump.m4a";
                        sound.Centiseconds = 100;
                        this.SkipOver = 2000;
                        break;
                    }



                case Type.VeryShortPause:
                    {
                        sound.FileName = "Silence.m4a";
                        sound.Centiseconds = 50;
                        break;
                    }



                case Type.ShortPause:
                    {
                        sound.FileName = "Silence.m4a";
                        sound.Centiseconds = 100;
                        break;
                    }


                case Type.LongPause:
                    {
                        sound.FileName = "Silence.m4a";
                        sound.Centiseconds = 150;
                        break;
                    }

                default: break;
            }


            this.Sound = sound;
        }
        public string Name { get; set; }
        public int Time { get; set; }


        public int SkipOver { get; set; }

        public Sound Sound { get; set; }
    }
}
