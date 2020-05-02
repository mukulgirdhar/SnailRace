using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnailRace;
using System.Threading;
namespace SnailRaceTests
{

    [TestClass()]
    public class Form1Tests
    {
        public Form1 MyTestForm1 = new Form1();
        private System.Timers.Timer t = new System.Timers.Timer() { AutoReset = false, Enabled = false, Interval = 0.001 };//to trigger events without the usual requirements
        [TestMethod()]
        public void Form1ResizesOnLoad()
        {
            int[] unexpected = { MyTestForm1.Width, MyTestForm1.Height };
            t.Elapsed += MyTestForm1.Form1_Load;//adding event to timer
            t.Enabled = true;
            Thread.Sleep(200);//waiting for timer to trigger and do work
            int[] actual = { MyTestForm1.Width, MyTestForm1.Height };
            t.Elapsed -= MyTestForm1.Form1_Load;//removing event from timer
            t.Enabled = false;
            Assert.AreEqual(unexpected[0], actual[0]);//width should stay the same
            Assert.AreNotEqual(unexpected[1], actual[1]);//height should change from the default
        }
    }
}
