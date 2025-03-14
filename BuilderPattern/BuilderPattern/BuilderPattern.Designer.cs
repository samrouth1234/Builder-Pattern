namespace BuilderPattern_01
{
    partial class BuilderPattern
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
            panel1 = new Panel();
            buildButton_Click = new Button();
            label5 = new Label();
            osTextBox = new TextBox();
            label4 = new Label();
            gpuTextBox = new TextBox();
            label3 = new Label();
            hddTextBox = new TextBox();
            label2 = new Label();
            ramTextBox = new TextBox();
            label1 = new Label();
            cpuTextBox = new TextBox();
            gamingRadioButton = new CheckBox();
            officeRadioButton = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(officeRadioButton);
            panel1.Controls.Add(gamingRadioButton);
            panel1.Controls.Add(buildButton_Click);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(osTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(gpuTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(hddTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ramTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cpuTextBox);
            panel1.Location = new Point(71, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 346);
            panel1.TabIndex = 0;
            // 
            // buildButton_Click
            // 
            buildButton_Click.BackColor = Color.DarkTurquoise;
            buildButton_Click.FlatStyle = FlatStyle.System;
            buildButton_Click.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buildButton_Click.Location = new Point(531, 285);
            buildButton_Click.Name = "buildButton_Click";
            buildButton_Click.Size = new Size(93, 41);
            buildButton_Click.TabIndex = 10;
            buildButton_Click.Text = "Submit";
            buildButton_Click.UseVisualStyleBackColor = false;
            buildButton_Click.Click += buildButton_Click_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 206);
            label5.Name = "label5";
            label5.Size = new Size(25, 17);
            label5.TabIndex = 9;
            label5.Text = "OS";
            // 
            // osTextBox
            // 
            osTextBox.Location = new Point(37, 228);
            osTextBox.Multiline = true;
            osTextBox.Name = "osTextBox";
            osTextBox.Size = new Size(267, 36);
            osTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(371, 121);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(34, 17);
            label4.TabIndex = 7;
            label4.Text = "GPU";
            // 
            // gpuTextBox
            // 
            gpuTextBox.Location = new Point(367, 143);
            gpuTextBox.Multiline = true;
            gpuTextBox.Name = "gpuTextBox";
            gpuTextBox.Size = new Size(261, 36);
            gpuTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(370, 43);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 5;
            label3.Text = "HDD";
            // 
            // hddTextBox
            // 
            hddTextBox.Location = new Point(367, 65);
            hddTextBox.Multiline = true;
            hddTextBox.Name = "hddTextBox";
            hddTextBox.Size = new Size(261, 36);
            hddTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 121);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 3;
            label2.Text = "RAM";
            // 
            // ramTextBox
            // 
            ramTextBox.Location = new Point(37, 143);
            ramTextBox.Multiline = true;
            ramTextBox.Name = "ramTextBox";
            ramTextBox.Size = new Size(267, 36);
            ramTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 43);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 1;
            label1.Text = "CPU";
            // 
            // cpuTextBox
            // 
            cpuTextBox.Location = new Point(37, 65);
            cpuTextBox.Multiline = true;
            cpuTextBox.Name = "cpuTextBox";
            cpuTextBox.Size = new Size(267, 36);
            cpuTextBox.TabIndex = 0;
            // 
            // gamingRadioButton
            // 
            gamingRadioButton.AutoSize = true;
            gamingRadioButton.Location = new Point(39, 285);
            gamingRadioButton.Name = "gamingRadioButton";
            gamingRadioButton.Size = new Size(68, 19);
            gamingRadioButton.TabIndex = 11;
            gamingRadioButton.Text = "Gaming";
            gamingRadioButton.UseVisualStyleBackColor = true;
            // 
            // officeRadioButton
            // 
            officeRadioButton.AutoSize = true;
            officeRadioButton.Location = new Point(118, 286);
            officeRadioButton.Name = "officeRadioButton";
            officeRadioButton.Size = new Size(62, 19);
            officeRadioButton.TabIndex = 12;
            officeRadioButton.Text = "Officer";
            officeRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Builder Pattern";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox cpuTextBox;
        private Label label1;
        private Label label5;
        private TextBox osTextBox;
        private Label label4;
        private TextBox gpuTextBox;
        private Label label3;
        private TextBox hddTextBox;
        private Label label2;
        private TextBox ramTextBox;
        private Button buildButton_Click;
        private CheckBox gamingRadioButton;
        private CheckBox officeRadioButton;
    }
}
