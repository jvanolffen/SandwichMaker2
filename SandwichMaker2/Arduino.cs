using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace SandwichMaker2
{
    class Arduino
    {
        private SerialPort serialPort;
        private int[] sandwich = new int[10];
        
        public void Send(int[] input)
        {
            sandwich = input;
            serialPort.Open();
            //stuur bericht
            serialPort.Close();
            
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs args)
        {

        }

        public Arduino(String com)
        {
            serialPort = new SerialPort(com);
            serialPort.BaudRate = 9600;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceived);
        }

        public Arduino(String com, int baud)
        {
            serialPort = new SerialPort(com);
            serialPort.BaudRate = baud;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceived);
        }
    }
}
