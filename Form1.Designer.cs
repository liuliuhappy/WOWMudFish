namespace MudFish
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loopjump = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudIntervalTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWndSwitchTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer_jump = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWndSwitchTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Q:这是干啥的？ A:来，给哥跳一下";
            // 
            // btn_loopjump
            // 
            this.btn_loopjump.Location = new System.Drawing.Point(241, 56);
            this.btn_loopjump.Name = "btn_loopjump";
            this.btn_loopjump.Size = new System.Drawing.Size(75, 59);
            this.btn_loopjump.TabIndex = 1;
            this.btn_loopjump.Text = "开始";
            this.btn_loopjump.UseVisualStyleBackColor = true;
            this.btn_loopjump.Click += new System.EventHandler(this.btn_loopjump_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudWndSwitchTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudIntervalTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // nudIntervalTime
            // 
            this.nudIntervalTime.Location = new System.Drawing.Point(79, 32);
            this.nudIntervalTime.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nudIntervalTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudIntervalTime.Name = "nudIntervalTime";
            this.nudIntervalTime.Size = new System.Drawing.Size(55, 21);
            this.nudIntervalTime.TabIndex = 0;
            this.nudIntervalTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "动作间隔：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "秒";
            // 
            // nudWndSwitchTime
            // 
            this.nudWndSwitchTime.Location = new System.Drawing.Point(78, 67);
            this.nudWndSwitchTime.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudWndSwitchTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudWndSwitchTime.Name = "nudWndSwitchTime";
            this.nudWndSwitchTime.Size = new System.Drawing.Size(56, 21);
            this.nudWndSwitchTime.TabIndex = 6;
            this.nudWndSwitchTime.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "窗口切换：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "毫秒";
            // 
            // timer_jump
            // 
            this.timer_jump.Interval = 5000;
            this.timer_jump.Tick += new System.EventHandler(this.timer_jump_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 174);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_loopjump);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "世界上最活跃的泥鱼 1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWndSwitchTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_loopjump;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudIntervalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudWndSwitchTime;
        private System.Windows.Forms.Timer timer_jump;
    }
}

