
namespace D3HelperX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_state = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbp1 = new System.Windows.Forms.CheckBox();
            this.cbp2 = new System.Windows.Forms.CheckBox();
            this.cbp3 = new System.Windows.Forms.CheckBox();
            this.cbp4 = new System.Windows.Forms.CheckBox();
            this.cbpL = new System.Windows.Forms.CheckBox();
            this.cbpR = new System.Windows.Forms.CheckBox();
            this.btn_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(33, 130);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(50, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(89, 130);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(50, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "4";
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(146, 163);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(11, 15);
            this.lb_state.TabIndex = 10;
            this.lb_state.Text = " ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "250",
            "500",
            "1000"});
            this.comboBox1.Location = new System.Drawing.Point(33, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "250",
            "500",
            "1000"});
            this.comboBox2.Location = new System.Drawing.Point(33, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 23);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            this.comboBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "250",
            "500",
            "1000"});
            this.comboBox3.Location = new System.Drawing.Point(33, 69);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(106, 23);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            this.comboBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "250",
            "500",
            "1000"});
            this.comboBox4.Location = new System.Drawing.Point(33, 99);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(106, 23);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            this.comboBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "pause( ` )";
            // 
            // cbp1
            // 
            this.cbp1.AutoSize = true;
            this.cbp1.Location = new System.Drawing.Point(146, 30);
            this.cbp1.Name = "cbp1";
            this.cbp1.Size = new System.Drawing.Size(33, 19);
            this.cbp1.TabIndex = 16;
            this.cbp1.Text = "1";
            this.cbp1.UseVisualStyleBackColor = true;
            // 
            // cbp2
            // 
            this.cbp2.AutoSize = true;
            this.cbp2.Location = new System.Drawing.Point(146, 50);
            this.cbp2.Name = "cbp2";
            this.cbp2.Size = new System.Drawing.Size(33, 19);
            this.cbp2.TabIndex = 17;
            this.cbp2.Text = "2";
            this.cbp2.UseVisualStyleBackColor = true;
            // 
            // cbp3
            // 
            this.cbp3.AutoSize = true;
            this.cbp3.Location = new System.Drawing.Point(146, 70);
            this.cbp3.Name = "cbp3";
            this.cbp3.Size = new System.Drawing.Size(33, 19);
            this.cbp3.TabIndex = 18;
            this.cbp3.Text = "3";
            this.cbp3.UseVisualStyleBackColor = true;
            // 
            // cbp4
            // 
            this.cbp4.AutoSize = true;
            this.cbp4.Location = new System.Drawing.Point(146, 90);
            this.cbp4.Name = "cbp4";
            this.cbp4.Size = new System.Drawing.Size(33, 19);
            this.cbp4.TabIndex = 19;
            this.cbp4.Text = "4";
            this.cbp4.UseVisualStyleBackColor = true;
            // 
            // cbpL
            // 
            this.cbpL.AutoSize = true;
            this.cbpL.Location = new System.Drawing.Point(146, 110);
            this.cbpL.Name = "cbpL";
            this.cbpL.Size = new System.Drawing.Size(32, 19);
            this.cbpL.TabIndex = 20;
            this.cbpL.Text = "L";
            this.cbpL.UseVisualStyleBackColor = true;
            // 
            // cbpR
            // 
            this.cbpR.AutoSize = true;
            this.cbpR.Location = new System.Drawing.Point(146, 130);
            this.cbpR.Name = "cbpR";
            this.cbpR.Size = new System.Drawing.Size(33, 19);
            this.cbpR.TabIndex = 21;
            this.cbpR.Text = "R";
            this.cbpR.UseVisualStyleBackColor = true;
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(33, 159);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(106, 23);
            this.btn_about.TabIndex = 22;
            this.btn_about.Text = "about";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 193);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.cbpR);
            this.Controls.Add(this.cbpL);
            this.Controls.Add(this.cbp4);
            this.Controls.Add(this.cbp3);
            this.Controls.Add(this.cbp2);
            this.Controls.Add(this.cbp1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "D3HelperX";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbp1;
        private System.Windows.Forms.CheckBox cbp2;
        private System.Windows.Forms.CheckBox cbp3;
        private System.Windows.Forms.CheckBox cbp4;
        private System.Windows.Forms.CheckBox cbpL;
        private System.Windows.Forms.CheckBox cbpR;
        private System.Windows.Forms.Button btn_about;
    }
}

