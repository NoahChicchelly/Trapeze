using ConveyorBelt;
using NUnit.Framework;
using System;

namespace ConveyorBeltTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HappyPath()
        {
            ConveyorBeltInterface view = new ConveyorBeltInterface();
            new DataSimulator(view);
            view.SetResetTimers();
            view.ReadData(1, "Okay", "1");
            Assert.IsTrue(view.elapsedWeight == 1);
        }

        [Test]
        public void DecreaseWeight()
        {
            ConveyorBeltInterface view = new ConveyorBeltInterface();
            new DataSimulator(view);
            view.SetResetTimers();
            view.ReadData(1, "Okay", "1");
            view.ReadData(2, "Okay", "2");
            view.ReadData(1, "Okay", "3");
            Assert.IsTrue(view.elapsedWeight == 2);
        }

        [Test]
        public void SameWeight()
        {
            ConveyorBeltInterface view = new ConveyorBeltInterface();
            new DataSimulator(view);
            view.SetResetTimers();
            view.ReadData(1, "Okay", "1");
            view.ReadData(2, "Okay", "2");
            view.ReadData(2, "Okay", "3");
            Assert.IsTrue(view.sameWeightCount == 1);
        }

        [Test]
        public void ResetAndElapsedWeight()
        {
            ConveyorBeltInterface view = new ConveyorBeltInterface();
            new DataSimulator(view);
            object sender = null;
            EventArgs e = null;
            view.SetResetTimers();
            view.ReadData(1, "Okay", "1");
            view.ReadData(2, "Okay", "2");
            view.ReadData(3, "Okay", "3");
            view.Reset(sender, e);
            Assert.IsTrue(view.resetWeight == 3);
            view.ReadData(1, "Okay", "1");
            Assert.IsTrue(view.elapsedWeight == 3);
            view.ReadData(4, "Okay", "4");
            Assert.IsTrue(view.elapsedWeight == 1);
            view.Reset(sender, e);
            Assert.IsTrue(view.resetWeight == 4);
        }
    }
}