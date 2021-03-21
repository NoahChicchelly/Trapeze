
namespace ConveyorBelt
{
    partial class ConveyorBeltInterface
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timeSinceResetTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.machineTimerTextBox = new System.Windows.Forms.TextBox();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.equipmentStateTextBox = new System.Windows.Forms.TextBox();
            this.elapsedWeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalWeightTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Reset);
            // 
            // timeSinceResetTextBox
            // 
            this.timeSinceResetTextBox.Location = new System.Drawing.Point(314, 197);
            this.timeSinceResetTextBox.Name = "timeSinceResetTextBox";
            this.timeSinceResetTextBox.Size = new System.Drawing.Size(100, 23);
            this.timeSinceResetTextBox.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.ResetTimer_Tick);
            // 
            // machineTimerTextBox
            // 
            this.machineTimerTextBox.Location = new System.Drawing.Point(305, 128);
            this.machineTimerTextBox.Name = "machineTimerTextBox";
            this.machineTimerTextBox.Size = new System.Drawing.Size(147, 23);
            this.machineTimerTextBox.TabIndex = 2;
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(267, 266);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.currentWeightTextBox.TabIndex = 3;
            // 
            // equipmentStateTextBox
            // 
            this.equipmentStateTextBox.Location = new System.Drawing.Point(415, 266);
            this.equipmentStateTextBox.Name = "equipmentStateTextBox";
            this.equipmentStateTextBox.Size = new System.Drawing.Size(314, 23);
            this.equipmentStateTextBox.TabIndex = 4;
            // 
            // elapsedWeightTextBox
            // 
            this.elapsedWeightTextBox.Location = new System.Drawing.Point(80, 266);
            this.elapsedWeightTextBox.Name = "elapsedWeightTextBox";
            this.elapsedWeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.elapsedWeightTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Machine Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Elapsed time since reset:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current weight moved (lbs/s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Elapsed weight since reset (lbs):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Machine Status:";
            // 
            // errorTextBox
            // 
            this.errorTextBox.Location = new System.Drawing.Point(155, 341);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errorTextBox.Size = new System.Drawing.Size(574, 83);
            this.errorTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Error Log";
            // 
            // totalWeightTextBox
            // 
            this.totalWeightTextBox.Location = new System.Drawing.Point(80, 196);
            this.totalWeightTextBox.Name = "totalWeightTextBox";
            this.totalWeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.totalWeightTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Weight (lbs):";
            // 
            // ConveyorBeltInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalWeightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elapsedWeightTextBox);
            this.Controls.Add(this.equipmentStateTextBox);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.machineTimerTextBox);
            this.Controls.Add(this.timeSinceResetTextBox);
            this.Controls.Add(this.button1);
            this.Name = "ConveyorBeltInterface";
            this.Text = "Conveyor Belt Sim";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox timeSinceResetTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox machineTimerTextBox;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox equipmentStateTextBox;
        private System.Windows.Forms.TextBox elapsedWeightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalWeightTextBox;
        private System.Windows.Forms.Label label7;
    }
}

