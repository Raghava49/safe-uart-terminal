namespace Com_tool
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.Clear = new System.Windows.Forms.Button();
            this.RxTx_box = new System.Windows.Forms.TextBox();
            this.Open_comport = new System.Windows.Forms.Button();
            this.Refresh_com = new System.Windows.Forms.Button();
            this.Hand_shake = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sel_baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sel_com = new System.Windows.Forms.ComboBox();
            this.Raghava = new System.Windows.Forms.LinkLabel();
            this.Encryption = new System.Windows.Forms.CheckBox();
            this.Unlock = new System.Windows.Forms.PictureBox();
            this.Rx = new System.Windows.Forms.PictureBox();
            this.Tx = new System.Windows.Forms.PictureBox();
            this.Lock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Unlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(288, 140);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(115, 32);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RxTx_box
            // 
            this.RxTx_box.AcceptsReturn = true;
            this.RxTx_box.BackColor = System.Drawing.SystemColors.Window;
            this.RxTx_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RxTx_box.ForeColor = System.Drawing.Color.Black;
            this.RxTx_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RxTx_box.Location = new System.Drawing.Point(14, 178);
            this.RxTx_box.Multiline = true;
            this.RxTx_box.Name = "RxTx_box";
            this.RxTx_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RxTx_box.Size = new System.Drawing.Size(389, 399);
            this.RxTx_box.TabIndex = 22;
            this.RxTx_box.WordWrap = false;
            // 
            // Open_comport
            // 
            this.Open_comport.BackColor = System.Drawing.Color.Chartreuse;
            this.Open_comport.Location = new System.Drawing.Point(11, 140);
            this.Open_comport.Name = "Open_comport";
            this.Open_comport.Size = new System.Drawing.Size(255, 32);
            this.Open_comport.TabIndex = 21;
            this.Open_comport.Text = "Open comport";
            this.Open_comport.UseVisualStyleBackColor = false;
            this.Open_comport.Click += new System.EventHandler(this.Open_comport_Click);
            // 
            // Refresh_com
            // 
            this.Refresh_com.Location = new System.Drawing.Point(288, 47);
            this.Refresh_com.Name = "Refresh_com";
            this.Refresh_com.Size = new System.Drawing.Size(115, 25);
            this.Refresh_com.TabIndex = 20;
            this.Refresh_com.Text = "Refresh";
            this.Refresh_com.UseVisualStyleBackColor = true;
            this.Refresh_com.Click += new System.EventHandler(this.Refresh_com_Click);
            // 
            // Hand_shake
            // 
            this.Hand_shake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hand_shake.FormattingEnabled = true;
            this.Hand_shake.Location = new System.Drawing.Point(161, 110);
            this.Hand_shake.Name = "Hand_shake";
            this.Hand_shake.Size = new System.Drawing.Size(105, 24);
            this.Hand_shake.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hand shake";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Baudrate";
            // 
            // Sel_baud
            // 
            this.Sel_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sel_baud.FormattingEnabled = true;
            this.Sel_baud.Location = new System.Drawing.Point(161, 79);
            this.Sel_baud.Name = "Sel_baud";
            this.Sel_baud.Size = new System.Drawing.Size(105, 24);
            this.Sel_baud.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select com Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(-3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "COMPORT Tool";
            // 
            // Sel_com
            // 
            this.Sel_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sel_com.FormattingEnabled = true;
            this.Sel_com.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sel_com.Location = new System.Drawing.Point(161, 48);
            this.Sel_com.Name = "Sel_com";
            this.Sel_com.Size = new System.Drawing.Size(105, 24);
            this.Sel_com.TabIndex = 13;
            // 
            // Raghava
            // 
            this.Raghava.AutoSize = true;
            this.Raghava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raghava.Location = new System.Drawing.Point(287, 18);
            this.Raghava.Name = "Raghava";
            this.Raghava.Size = new System.Drawing.Size(94, 20);
            this.Raghava.TabIndex = 25;
            this.Raghava.TabStop = true;
            this.Raghava.Text = "Raghava \'S";
            this.Raghava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Raghava_LinkClicked);
            // 
            // Encryption
            // 
            this.Encryption.AutoSize = true;
            this.Encryption.Location = new System.Drawing.Point(288, 108);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(97, 21);
            this.Encryption.TabIndex = 26;
            this.Encryption.Text = "Encryption";
            this.Encryption.UseVisualStyleBackColor = true;
            this.Encryption.CheckedChanged += new System.EventHandler(this.Encryption_CheckedChanged);
            // 
            // Unlock
            // 
            this.Unlock.Image = global::Com_tool.Properties.Resources.unlock;
            this.Unlock.Location = new System.Drawing.Point(288, 79);
            this.Unlock.Name = "Unlock";
            this.Unlock.Size = new System.Drawing.Size(25, 24);
            this.Unlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Unlock.TabIndex = 30;
            this.Unlock.TabStop = false;
            // 
            // Rx
            // 
            this.Rx.Image = global::Com_tool.Properties.Resources.key_down;
            this.Rx.Location = new System.Drawing.Point(377, 79);
            this.Rx.Name = "Rx";
            this.Rx.Size = new System.Drawing.Size(26, 25);
            this.Rx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rx.TabIndex = 29;
            this.Rx.TabStop = false;
            this.Rx.Visible = false;
            // 
            // Tx
            // 
            this.Tx.Image = global::Com_tool.Properties.Resources.key_up__1_;
            this.Tx.Location = new System.Drawing.Point(333, 79);
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(25, 24);
            this.Tx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tx.TabIndex = 28;
            this.Tx.TabStop = false;
            this.Tx.Visible = false;
            // 
            // Lock
            // 
            this.Lock.Image = global::Com_tool.Properties.Resources.padlock__1_;
            this.Lock.Location = new System.Drawing.Point(288, 79);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(25, 24);
            this.Lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lock.TabIndex = 27;
            this.Lock.TabStop = false;
            this.Lock.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(415, 589);
            this.Controls.Add(this.Unlock);
            this.Controls.Add(this.Rx);
            this.Controls.Add(this.Tx);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.Raghava);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.RxTx_box);
            this.Controls.Add(this.Open_comport);
            this.Controls.Add(this.Refresh_com);
            this.Controls.Add(this.Hand_shake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sel_baud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sel_com);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM Tool";
            ((System.ComponentModel.ISupportInitialize)(this.Unlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox RxTx_box;
        private System.Windows.Forms.Button Open_comport;
        private System.Windows.Forms.Button Refresh_com;
        private System.Windows.Forms.ComboBox Hand_shake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Sel_baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sel_com;
        private System.Windows.Forms.LinkLabel Raghava;
        private System.Windows.Forms.CheckBox Encryption;
        private System.Windows.Forms.PictureBox Lock;
        private System.Windows.Forms.PictureBox Tx;
        private System.Windows.Forms.PictureBox Rx;
        private System.Windows.Forms.PictureBox Unlock;
    }
}

