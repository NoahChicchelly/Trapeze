using System;
using System.Diagnostics;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ConveyorBelt
{
    public partial class ConveyorBeltInterface : Form
    {
        // Public for testing
        public Timer resetTimer;
        public Stopwatch resetStopwatch;
        public double elapsedWeight;
        public double previousWeight;
        public double resetWeight;
        public int sameWeightCount;

        // Configure how long you want to allow no weight change (in seconds)
        private const int weightChangeLimit = 1;

        public ConveyorBeltInterface()
        {
            InitializeComponent();
        }

        /**
         * Initialization of components with the interface
         */
        private void Interface_Load(object sender, EventArgs e)
        {
            SetResetTimers();

            elapsedWeight = 0;
            sameWeightCount = 0;

            currentWeightTextBox.Text = "--";
            elapsedWeightTextBox.Text = "--";
            equipmentStateTextBox.Text = "--";
        }

        /**
         * Reset button for elapsed timer and weight
         * 
         * Public for tests
         */
        public void Reset(object sender, EventArgs e)
        {
            resetTimer.Stop();
            resetStopwatch.Restart();
            // Remember 'total weight' from before a reset click
            resetWeight = previousWeight;
            elapsedWeightTextBox.Text = "--";
            currentWeightTextBox.Text = "--";
            SetResetTimers();
        }

        /**
         * Timer for reset data to run on milliseconds for more precise counting.
         */
        private void ResetTimer_Tick(object sender, EventArgs e)
        {
            timeSinceResetTextBox.Text = resetStopwatch.Elapsed.ToString("hh\\:mm\\:ss\\:fff");
        }

        /**
         * Main functionality logic
         * 
         * Take in data from the machine and display:
         * - Machine time
         * - Errors
         * - Machine Status (0 = Okay, 500 = Half full, 1k+ = Overweight) -- Added these as placeholders for real statuses
         * - Time since last reset
         * - Weight since last reset
         * - Weight per second since last reset (can also be changed to total weight per second)
         * 
         * -- Added total weight display
         */
        public void ReadData(double currentWeight, string equipmentState, string timestamp)
        {
            // Display time/state, wait for error handling before displaying weight
            machineTimerTextBox.Text = timestamp;
            equipmentStateTextBox.Text = equipmentState;

            // If the current weight is < previous weight, display error
            bool checkDecrease = currentWeight < previousWeight;

            // If weight hasn't changed, monitor it.
            if (currentWeight == previousWeight)
            {
                sameWeightCount++;
            }
            else
            {
                sameWeightCount = 0;
            }

            if (checkDecrease)
            {
                errorTextBox.Text += "Error: Weight decreased at " + timestamp + " " + resetStopwatch.Elapsed.ToString("ss\\:fff") + " seconds after reset" + Environment.NewLine;
                errorTextBox.SelectionStart = errorTextBox.Text.Length;
                errorTextBox.ScrollToCaret();
            }
            // If the monitored sameWeightCount has reached weightChangeLimit (configurable in code), display error
            else if (sameWeightCount >= weightChangeLimit)
            {
                errorTextBox.Text += "Error: Weight hasn't increased in at least " + weightChangeLimit.ToString() + " seconds at " + timestamp + " " + resetStopwatch.Elapsed.ToString("ss\\:fff") + " seconds after reset" + Environment.NewLine;
                errorTextBox.SelectionStart = errorTextBox.Text.Length;
                errorTextBox.ScrollToCaret();
            }
            else
            {
                // Display raw total weight
                totalWeightTextBox.Text = Math.Round(currentWeight, 2).ToString();

                // Calculate the 'elapsed weight since reset' by calculating current weight minus the 'total weight' we had when we reset
                elapsedWeight = Math.Round(currentWeight - resetWeight, 2);

                // Store weight to error check next call
                previousWeight = currentWeight;

                // Display the 'elapsed weight since reset' divided by 'elapsed time since reset'
                // This is an assumption on what should be done. If it was meant to be 'total weight' / s, that is a 1 var change here.
                currentWeightTextBox.Text = Math.Round(elapsedWeight / resetStopwatch.Elapsed.TotalSeconds, 2).ToString();

                elapsedWeightTextBox.Text = elapsedWeight.ToString();
            }
        }


        /**
         * Setup timers/stopwatches for reset data
         */
        public void SetResetTimers()
        {
            resetStopwatch = new Stopwatch();
            resetTimer = new Timer();
            resetTimer.Interval = 1;
            resetTimer.Tick += ResetTimer_Tick;

            resetTimer.Start();
            resetStopwatch.Start();
        }
    }
}
