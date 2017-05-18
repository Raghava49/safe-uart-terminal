using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace Com_tool
{
    public partial class mainForm : Form
    {
        string InputData = String.Empty;
        Random random = new Random();
        SerialPort ComPort = new SerialPort();
        delegate void SetTextCallback(string text);
        private delegate void ObjectDelegate(object obj);
        bool stopThreads = false;
        public mainForm()
        {
            InitializeComponent();
            load_COM();
            this.KeyPreview = true;
            RxTx_box.KeyPress += new KeyPressEventHandler(RxTx_box_keyPress);
            this.FormClosing  += new FormClosingEventHandler(mainForm_FormClosed);
            this.KeyDown += new KeyEventHandler(mainForm_keyDown);
            ObjectDelegate del = new ObjectDelegate(Set_RX);
            ObjectDelegate del1 = new ObjectDelegate(Set_TX);
            Thread RX_SY = new Thread(new ThreadStart(Rx_symbol));
            Thread TX_SY = new Thread(new ThreadStart(Tx_symbol));
            RX_SY.Start();
            TX_SY.Start();
        }

        void mainForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            DialogResult window = 0;
            if ((ComPort.IsOpen))
            {
                window = MessageBox.Show(
                "Com Port is open do you want to close?",
                "Close window",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (window == DialogResult.Yes)
                {
                    stopThreads = true;
                    ComPort.DataReceived -= new SerialDataReceivedEventHandler(ComPort_DataReceived);
                    RxTx_box.KeyPress -= new KeyPressEventHandler(RxTx_box_keyPress);
                    this.FormClosing -= new FormClosingEventHandler(mainForm_FormClosed);
                    this.KeyDown -= new KeyEventHandler(mainForm_keyDown);
                    ComPort.Close();
                }
                e.Cancel = (window == DialogResult.No);
            }

        }

        public void mainForm_keyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                e.SuppressKeyPress = true;
                RxTx_box.Clear();
            }
            if (e.KeyCode == Keys.E && e.Control)
            {
                e.SuppressKeyPress = true;
                Encryption.Checked = !Encryption.Checked;
            }
            if (e.KeyCode == Keys.Escape || e.Control) 
            {
                e.SuppressKeyPress = true;
            }
        }

        

        private void SetText(string text)
        {
            if (this.RxTx_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text == "\b")
                {
                    try
                    {
                        if (this.RxTx_box.Text[this.RxTx_box.Text.Length-1] == 13)
                        {
                            this.RxTx_box.Text = this.RxTx_box.Text.Remove(this.RxTx_box.Text.Length - 1, 1);
                        }
                        this.RxTx_box.Text = this.RxTx_box.Text.Remove(this.RxTx_box.Text.Length - 1, 1);
                        this.RxTx_box.SelectionStart = this.RxTx_box.Text.Length;
                        RxTx_box.ScrollToCaret();
                    }
                    catch (System.Exception)
                    {

                    }
                }
                else
                {
                    this.RxTx_box.Text += text;
                    this.RxTx_box.SelectionStart = this.RxTx_box.Text.Length;
                    RxTx_box.ScrollToCaret();
                }
            }
        }

        private void load_COM()
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            Sel_com.Items.Clear();
            ArrayComPortsNames = SerialPort.GetPortNames();
            try
            {
                do
                {
                    index++;
                    Sel_com.Items.Add(ArrayComPortsNames[index]);
                }
                while (!((ArrayComPortsNames[index] == ComPortName) ||
                            (index == ArrayComPortsNames.GetUpperBound(0))));
                Sel_com.Text = ArrayComPortsNames[0];
            }
            catch (System.Exception)
            {

            }
            Sel_baud.Items.Clear();
            Sel_baud.Items.Add(300);
            Sel_baud.Items.Add(600);
            Sel_baud.Items.Add(1200);
            Sel_baud.Items.Add(2400);
            Sel_baud.Items.Add(9600);
            Sel_baud.Items.Add(14400);
            Sel_baud.Items.Add(19200);
            Sel_baud.Items.Add(38400);
            Sel_baud.Items.Add(57600);
            Sel_baud.Items.Add(115200);
            Sel_baud.Items.ToString();
            Sel_baud.Text = Sel_baud.Items[4].ToString();

            Hand_shake.Items.Clear();
            Hand_shake.Items.Add("None");
            Hand_shake.Items.ToString();
            Hand_shake.Text = Hand_shake.Items[0].ToString();
            ComPort.RtsEnable = false;
            ComPort.DtrEnable = false;

        }
        
        private void Refresh_com_Click(object sender, EventArgs e)
        {
            load_COM();
        }

        private void Set_RX(object obj)
        {
            if (InvokeRequired)
            {
                try
                {
                    ObjectDelegate method = new ObjectDelegate(Set_RX);
                    Invoke(method, obj);
                    return;
                }
                catch (System.Exception) 
                {
                    stopThreads = true;
                }
            }
            if ((ComPort.IsOpen))
            {
                Rx.Visible = Rx_flag;
            }
        }

        private void Set_TX(object obj)
        {
            if (InvokeRequired)
            {
                try
                {
                    ObjectDelegate method = new ObjectDelegate(Set_TX);
                    Invoke(method, obj);
                    return;
                }
                catch (System.Exception) 
                {
                    stopThreads = true;
                };
            }
            if ((ComPort.IsOpen))
            {
                Tx.Visible = Tx_flag;
            }
        }

        bool Rx_flag = false, Tx_flag = false;
        private void Rx_symbol()
        {
            while (!stopThreads)
            {
                Set_RX(true);
                if (Rx_flag)
                {
                    Rx_flag = false;
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);

            }
        }

        private void Tx_symbol()
        {
            while (!stopThreads)
            {
                Set_TX(true);
                if (Tx_flag)
                {
                    Tx_flag = false;
                    Thread.Sleep(100);
                }
                Thread.Sleep(50);

            }
        }

        string Rx_string = "";
        private void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Int16 Rx_data, Rx_key1, Rx_key2;
            string Rx_str = "";
            Rx_flag = true;            
            if (Encryption.Checked != true)
            {
                try
                {
                    Rx_str = ComPort.ReadExisting();
                    SetText(Rx_str);

                }
                catch (System.Exception) { }
            }
            else
            {
                try
                {
                    Rx_str = "";
                    Rx_string = ComPort.ReadLine();
                    //ComPort.DiscardInBuffer();
                    Rx_key2 = (Int16)Rx_string[2];
                    if ((Rx_key2 & (0x01 << 4)) == 0)
                    {
                        Rx_data = (Int16)Rx_string[0];
                        Rx_key1 = (Int16)Rx_string[1];
                    }
                    else
                    {
                        Rx_data = (Int16)Rx_string[1];
                        Rx_key1 = (Int16)Rx_string[0];
                    }
                    Rx_key2 ^= 0x2F;
                    Rx_key1 ^= Rx_key2;
                    Rx_data ^= Rx_key2;
                    Rx_data ^= Rx_key1;
                    
                    if (Rx_data == 13)
                    {
                        SetText("\r\n");
                    }
                    else if (Rx_data == 8)
                    {
                        SetText("\b");
                    }
                    else
                    {
                        SetText(((char)Rx_data).ToString());
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ((int)Tx_string[0]).ToString() + "\r\n"  +((int)Tx_string[1]).ToString()
                        + "\r\n"+((int)Tx_string[2]).ToString());
                }
            }            
        }

        string Tx_string = "";
        private void RxTx_box_keyPress(object sender, KeyPressEventArgs e)
        {
            Int16 key1, key2, En_data = 0;
            Tx_flag = true;            
            char temp = e.KeyChar;
            if (Encryption.Checked == true)
            {
                do
                {
                    Tx_string = "";
                    key2 = 0;
                    key1 = 0;
                    En_data = (Int16)temp;
                    key1 = (Int16)random.Next(1, 120);
                    key2 = (Int16)random.Next(1, 120);
                    En_data ^= key1;
                    En_data ^= key2;
                    key1 ^= key2;
                    key2 ^= 0x2F;

                    if ((key2 & (0x01 << 4)) == 0)
                    {
                        Tx_string += (char)En_data;
                        Tx_string += (char)key1;
                        Tx_string += (char)key2;

                    }
                    else
                    {
                        Tx_string += (char)key1;
                        Tx_string += (char)En_data;
                        Tx_string += (char)key2;
                    }
                    Console.WriteLine("\r\n" + ((int)Tx_string[0]).ToString() + "\r\n" + ((int)Tx_string[1]).ToString()
                        + "\r\n" + ((int)Tx_string[2]).ToString());
                }
                while ((Tx_string[0] == 13) || (Tx_string[1] == 13) || (Tx_string[2] == 13) 
                    || (Tx_string[0] == 10) || (Tx_string[1] == 10) || (Tx_string[2] == 10)
                    || (Tx_string[0] == 0) || (Tx_string[1] == 0) || (Tx_string[2] == 0)
                    || (Tx_string[0] == 8) || (Tx_string[1] == 8) || (Tx_string[2] == 8)
                    || (Tx_string[0] == 9) || (Tx_string[1] == 9) || (Tx_string[2] == 9)
                    || (Tx_string[0] == 6) || (Tx_string[1] == 6) || (Tx_string[2] == 6)
                    || (Tx_string[0] == 13) || (Tx_string[1] == 13) || (Tx_string[2] == 13));
                if ((ComPort.IsOpen))
                {
                    ComPort.DiscardOutBuffer();
                    ComPort.WriteLine(Tx_string);
                }
                else
                {
                    Open_comport.Text = "Open comport";
                    Open_comport.BackColor = System.Drawing.Color.Chartreuse;
                    ComPort.DataReceived -= new SerialDataReceivedEventHandler(ComPort_DataReceived);
                    ComPort.Close();
                    MessageBox.Show("Please click the Open Comport Button",
                            "Com port is Not Opend",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((ComPort.IsOpen))
                {
                    ComPort.Write(temp.ToString());
                }
                else
                {
                    Open_comport.Text = "Open comport";
                    Open_comport.BackColor = System.Drawing.Color.Chartreuse;
                    ComPort.DataReceived -= new SerialDataReceivedEventHandler(ComPort_DataReceived);
                    ComPort.Close();
                    MessageBox.Show("Please click the Open Comport Button",
                            "Com port is Not Opend",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
            }
            
            
            

            e.Handled = true;
            
        }

        private void Open_comport_Click(object sender, EventArgs e)
        {
            if (Open_comport.Text == "Open comport")
            {
                try
                {
                    ComPort.PortName = Convert.ToString(Sel_com.Text);
                    ComPort.BaudRate = Convert.ToInt32(Sel_baud.Text);
                    ComPort.DataBits = Convert.ToInt16(8);
                    ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                    ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");
                    ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), Hand_shake.Text);
                    ComPort.DataReceived += new SerialDataReceivedEventHandler(ComPort_DataReceived);
                    ComPort.Open();
                    Open_comport.Text = "Close comport";
                    Open_comport.BackColor = System.Drawing.Color.Red;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Please close the other application",
                        "COM port is busy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Make sure COM port is connected properly",
                        "No available COM ports",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Make sure COM port is connected properly",
                     "No available COM ports",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
            }
            else if (Open_comport.Text == "Close comport")
            {
                Open_comport.Text = "Open comport";
                Open_comport.BackColor = System.Drawing.Color.Chartreuse;
                ComPort.DataReceived -= new SerialDataReceivedEventHandler(ComPort_DataReceived);
                try
                {
                    ComPort.Close();
                }
                catch(Exception)
                {
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            RxTx_box.Clear();
        }

        private void Raghava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/raghava49");
        }

        private void Encryption_CheckedChanged(object sender, EventArgs e)
        {
            if (Encryption.Checked == true)
            {
                Unlock.Visible = false;
                Lock.Visible = true;
                RxTx_box.BackColor = Color.DarkOliveGreen;
                RxTx_box.ForeColor = Color.White;

            }
            else
            {
                Lock.Visible = false;
                Unlock.Visible = true;
                RxTx_box.BackColor = Color.White;
                RxTx_box.ForeColor = Color.Black;
            }
        }
    }
}
