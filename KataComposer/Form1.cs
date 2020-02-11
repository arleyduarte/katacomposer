using KataComposer.Kata;
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KataComposer
{
    public partial class Form1 : Form
    {


        public Form1()
        {


            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            Orchestrator orchestrator = new Orchestrator();




          
            orchestrator.AddMovement(new Movement(Movement.Type.SpinningJump));
            orchestrator.AddMovement(new Movement(Movement.Type.ShortPause));
            orchestrator.AddMovement(new Movement(Movement.Type.SpinningJump));
            orchestrator.AddMovement(new Movement(Movement.Type.Slow));
            orchestrator.AddMovement(new Movement(Movement.Type.SpinningJump));
            //  orchestrator.AddMovement(new Movement(Movement.Type.SpinningJump));
            //   orchestrator.AddMovement(new Movement(Movement.Type.FullDisplacement));
            //   orchestrator.AddMovement(new Movement(Movement.Type.NoDisplacement));

            orchestrator.Play();

        }
    }
}
