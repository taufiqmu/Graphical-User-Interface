﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        bool on = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button1.Text = ("ON");
                    serialPort1.Write("Lampu ON\r\n");
                    on = false;
                }
                else
                {
                    button1.Text = ("OFF");
                    serialPort1.Write("Lampu OFF\r\n");
                    on = true;
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button2.Text = ("ON\r\n");
                    serialPort1.Write("Kipas ON\r\n");
                    on = false;
                }
                else
                {
                    button2.Text = ("OFF");
                    serialPort1.Write("Kipas OFF\r\n");
                    on = true;
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button3.Text = ("ON");
                    serialPort1.Write("AC ON\r\n");
                    on = false;
                }
                else
                {
                    button3.Text = ("OFF");
                    serialPort1.Write("AC OFF\r\n");
                    on = true;
                }
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button4.Text = ("ON");
                    serialPort1.Write("CCTV ON\r\n");
                    on = false;
                }
                else
                {
                    button4.Text = ("OFF");
                    serialPort1.Write("CCTV OFF\r\n");
                    on = true;
                }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button5.Text = ("ON");
                    serialPort1.Write("TV ON\r\n");
                    on = false;
                }
                else
                {
                    button5.Text = ("OFF");
                    serialPort1.Write("TV OFF\r\n");
                    on = true;
                }
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (button7.Text == ("Connect"))
                {
                    button7.Text = ("Connected");
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    label1.Text = serialPort1.PortName + (" is Connected");
                }
                else
                {
                    button7.Text = ("Connect");
                    serialPort1.Close();
                    label1.Text = ("Not Connected");
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] portlist = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string portName in portlist)
                comboBox1.Items.Add(portName);
        }
    }
}