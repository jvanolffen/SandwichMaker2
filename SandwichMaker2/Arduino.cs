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
        
        
        public void Send(int[] input)
        {
            byte[] sandwich = new byte[10];
            for (int i = 0; i < input.Length; i++) sandwich[i] = Convert.ToByte(input[i]);
            serialPort.Open();
            //stuur bericht
            serialPort.Write(sandwich, 0, 10);
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
