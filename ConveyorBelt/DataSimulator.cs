using System;
using System.Threading;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace ConveyorBelt
{
    public class DataSimulator
    {
        private string timestamp;
        private double currentWeight;
        private string equipmentState;
        private Timer beltTimer;
        private System.Timers.Timer machineTimer;
        private readonly ConveyorBeltInterface view;

        /**
         * Data simulator to store time, weight, and equipment status
         */
        public DataSimulator(ConveyorBeltInterface view)
        {
            this.view = view;
            timestamp = "";
            currentWeight = 0;
            equipmentState = "Okay";
            SetMachineTimers();
        }

        /**
         * Send data to interface every 1 second.
         * The frequency of sends could be increased on beltTimer initialization
         */
        private void DataTimer_Tick(object sender, EventArgs e)
        {
            // Simulate either increased (>0), the same (=0), or decreased (<0) weight from conveyor.
            // 10% chance the weight doesn't change. About the same chance it goes down.
            if (GetRandomDouble(0, 100) > 10)
            {
                currentWeight += Math.Round(GetRandomDouble(-1, 10), 2);
            }

            if (currentWeight > 500)
            {
                equipmentState = "Okay - 500lb+ load out of 1000lb max.";
            }
            else if (currentWeight > 1000)
            {
                equipmentState = "MAX CAPACITY - Clear belt or stop machine.";
            }

            view.ReadData(currentWeight, equipmentState, timestamp);
        }

        /**
         * Every second increase machine time and store it in the data sim
         */
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            try
            {
                timestamp = e.SignalTime.ToString();
            }
            catch (Exception exception)
            {
                ThreadPool.QueueUserWorkItem(
                    _ => { throw new Exception("Exception on conveyor belt timer.", exception); });
            }
        }

        /**
         * Setup timers for conveyor belt data
         */
        public void SetMachineTimers()
        {
            machineTimer = new System.Timers.Timer();
            machineTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            machineTimer.Enabled = true;

            // How quickly the belt updates
            beltTimer = new Timer();
            beltTimer.Interval = 1000;
            beltTimer.Tick += DataTimer_Tick;

            beltTimer.Start();
        }

        /**
         * Helper method to give a range of random doubles for the possiblility of decreased weight in data sim
         */
        public double GetRandomDouble(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
