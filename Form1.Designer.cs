namespace Time_Clock
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            totalHoursWorkedlbl = new Label();
            label4 = new Label();
            checkinlbl = new Label();
            label3 = new Label();
            checkoutlbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(185, 199);
            button1.Name = "button1";
            button1.Size = new Size(146, 62);
            button1.TabIndex = 2;
            button1.Text = "Clock In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(434, 204);
            button2.Name = "button2";
            button2.Size = new Size(152, 52);
            button2.TabIndex = 3;
            button2.Text = "Clock Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 306);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 4;
            label2.Text = "Time Worked";
            // 
            // totalHoursWorkedlbl
            // 
            totalHoursWorkedlbl.BorderStyle = BorderStyle.FixedSingle;
            totalHoursWorkedlbl.Location = new Point(322, 340);
            totalHoursWorkedlbl.Name = "totalHoursWorkedlbl";
            totalHoursWorkedlbl.Size = new Size(158, 46);
            totalHoursWorkedlbl.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 9);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 6;
            label4.Text = "Time Checked-In";
            // 
            // checkinlbl
            // 
            checkinlbl.BorderStyle = BorderStyle.FixedSingle;
            checkinlbl.Location = new Point(31, 40);
            checkinlbl.Name = "checkinlbl";
            checkinlbl.Size = new Size(120, 32);
            checkinlbl.TabIndex = 7;
            checkinlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 9);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 8;
            label3.Text = "Time Checked-Out";
            // 
            // checkoutlbl
            // 
            checkoutlbl.BorderStyle = BorderStyle.FixedSingle;
            checkoutlbl.Location = new Point(583, 47);
            checkoutlbl.Name = "checkoutlbl";
            checkoutlbl.Size = new Size(132, 30);
            checkoutlbl.TabIndex = 9;
            checkoutlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 410);
            Controls.Add(checkoutlbl);
            Controls.Add(label3);
            Controls.Add(checkinlbl);
            Controls.Add(label4);
            Controls.Add(totalHoursWorkedlbl);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "ClockInAndOut";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label2;
        private Label totalHoursWorkedlbl;
        private Label label4;
        private Label checkinlbl;
        private Label label3;
        private Label checkoutlbl;
    }
}
