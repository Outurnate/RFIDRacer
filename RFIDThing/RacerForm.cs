using RoboticsConnection.RFIDLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RFIDThing
{
    public partial class RacerForm : Form
    {
        RFIDReader reader;
        UInt32 count;

        public RacerForm()
        {
            InitializeComponent();
            reader = new RFIDReader();
            reader.TagSwipedEvent += reader_TagSwipedEvent;
        }

        private void start_Click(object sender, EventArgs e)
        {
            reader.PortName = comBox.Text;
            reader.SetBoardBaudRate(RFIDReader.RfidReaderBaudRate.BAUD_9600);
            reader.StartCommunication();
        }

        void reader_TagSwipedEvent(byte deviceId, string tag, byte valid)
        {
            ++count;
            this.Invoke((MethodInvoker)delegate()
            {
                laps.Text = count.ToString();
            });
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            reader.StopCommunication();
        }
    }
}