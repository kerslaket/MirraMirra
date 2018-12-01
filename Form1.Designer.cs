namespace MirraMirraForms
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weather1 = new System.Windows.Forms.Label();
            this.weather2 = new System.Windows.Forms.Label();
            this.weather3 = new System.Windows.Forms.Label();
            this.complimentLabel = new System.Windows.Forms.Label();
            this.secondTimer = new System.Windows.Forms.Timer(this.components);
            this.MinuteTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(850, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLabel.Size = new System.Drawing.Size(217, 78);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "label1";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLabel.Location = new System.Drawing.Point(850, 87);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(217, 78);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "label1";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // weather1
            // 
            this.weather1.AutoSize = true;
            this.weather1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weather1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weather1.Location = new System.Drawing.Point(12, 23);
            this.weather1.Name = "weather1";
            this.weather1.Size = new System.Drawing.Size(217, 78);
            this.weather1.TabIndex = 2;
            this.weather1.Text = "label1";
            // 
            // weather2
            // 
            this.weather2.AutoSize = true;
            this.weather2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weather2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weather2.Location = new System.Drawing.Point(12, 117);
            this.weather2.Name = "weather2";
            this.weather2.Size = new System.Drawing.Size(217, 78);
            this.weather2.TabIndex = 3;
            this.weather2.Text = "label1";
            // 
            // weather3
            // 
            this.weather3.AutoSize = true;
            this.weather3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weather3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weather3.Location = new System.Drawing.Point(12, 210);
            this.weather3.Name = "weather3";
            this.weather3.Size = new System.Drawing.Size(217, 78);
            this.weather3.TabIndex = 4;
            this.weather3.Text = "label1";
            // 
            // complimentLabel
            // 
            this.complimentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.complimentLabel.AutoSize = true;
            this.complimentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complimentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.complimentLabel.Location = new System.Drawing.Point(850, 1298);
            this.complimentLabel.Name = "complimentLabel";
            this.complimentLabel.Size = new System.Drawing.Size(217, 78);
            this.complimentLabel.TabIndex = 5;
            this.complimentLabel.Text = "label1";
            this.complimentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondTimer
            // 
            this.secondTimer.Enabled = true;
            this.secondTimer.Interval = 1000;
            this.secondTimer.Tick += new System.EventHandler(this.secondTimer_Tick_1);
            // 
            // MinuteTimer
            // 
            this.MinuteTimer.Enabled = true;
            this.MinuteTimer.Interval = 60000;
            this.MinuteTimer.Tick += new System.EventHandler(this.MinuteTimer_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1096, 1476);
            this.Controls.Add(this.complimentLabel);
            this.Controls.Add(this.weather3);
            this.Controls.Add(this.weather2);
            this.Controls.Add(this.weather1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label weather1;
        private System.Windows.Forms.Label weather2;
        private System.Windows.Forms.Label weather3;
        private System.Windows.Forms.Label complimentLabel;
        private System.Windows.Forms.Timer secondTimer;
        private System.Windows.Forms.Timer MinuteTimer;
    }
}

