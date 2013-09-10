using System;
using System.Windows.Forms;

namespace Helix_Antenna_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculateClick(object sender, EventArgs e)
        {
            //Make them vars
            string frequency = textBoxFrequency.Text;
            string turns = textBoxTurns.Text;

            //Check that the user did it right
            if (turns == null)
                MessageBox.Show("Oops!", "Please enter how many turns you would like before continuing.");
            if (frequency == null)
                MessageBox.Show("Oops!", "Please enter the frequency you wish to use");

            //Start crunching the numbers!
            double freq, turnCount;

            //Error Checking / Number Parsing
            bool freqChecker = double.TryParse(textBoxFrequency.Text, out freq);
            if (freqChecker == false)
                MessageBox.Show("Oh crud!", "Please enter a valid integer (only numbers)");
            bool turnChecker = double.TryParse(textBoxTurns.Text, out turnCount);
            if (turnChecker == false)
                MessageBox.Show("Darnit", "Please enter a valid integer for your turn count (only numbers)");

            //Begin with the math!    ...hate math ='(
            //First the PVC
            double pipeDiameterint = (3000/freq);
            double coilSpaceInt = (2790/freq);
            double pvcLengthInt = ((coilSpaceInt*turnCount) + 1);
            double reflectPlateInt = (11732/freq);
            double wavetrapLint = (1460/freq);
            double waveTrapWint = (730/freq);
            double wavetrapDist = (730/freq);

            textBoxPipeDiameter.Text = pipeDiameterint.ToString("0.####");
            textBoxPipeLength.Text = pvcLengthInt.ToString("0.####");
            textBoxRplate.Text = reflectPlateInt.ToString("0.####");
            textBoxTrapL.Text = wavetrapLint.ToString("0.####");
            textBoxTrapW.Text = waveTrapWint.ToString("0.####");
            textBoxFeedDist.Text = wavetrapDist.ToString("0.####");
            textBoxPVCCoilSpace.Text = coilSpaceInt.ToString("0.####");

            //Now the cross
            double crosspipeDiameterint = 3600/freq;
            double crosscoilSpaceInt = 2900/freq;
            double crossPvcLengthInt = (turnCount*crosscoilSpaceInt) + 1;
            double crossreflectPlateInt = 11732/freq;

            textBoxCrossD.Text = crosspipeDiameterint.ToString("0.####");
            textBoxCrossL.Text = crossPvcLengthInt.ToString("0.####");
            textBoxCrossCoilSpace.Text = crosscoilSpaceInt.ToString("0.####");
            textBoxCrossRplate.Text = crossreflectPlateInt.ToString("0.####");
            textBoxCrossWtrapL.Text = wavetrapLint.ToString("0.####");
            textBoxCrossWtrapW.Text = waveTrapWint.ToString("0.####");
            textBoxCrossFeedpointDist.Text = wavetrapDist.ToString("0.####");
        }
    }
}