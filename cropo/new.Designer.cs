namespace cropo
{
    partial class @new
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
            this.butExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.butOpen = new System.Windows.Forms.Button();
            this.butProcessing = new System.Windows.Forms.Button();
            this.butTest = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxSoil = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OutputPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoil)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // butExit
            // 
            this.butExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butExit.Location = new System.Drawing.Point(971, 0);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(58, 75);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "X";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 75);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(470, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "New";
            // 
            // butOpen
            // 
            this.butOpen.BackColor = System.Drawing.Color.Black;
            this.butOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.butOpen.FlatAppearance.BorderSize = 0;
            this.butOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOpen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butOpen.Location = new System.Drawing.Point(0, 0);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(191, 89);
            this.butOpen.TabIndex = 3;
            this.butOpen.Text = "Open Image";
            this.butOpen.UseVisualStyleBackColor = false;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            this.butOpen.MouseEnter += new System.EventHandler(this.butOpen_MouseEnter);
            this.butOpen.MouseLeave += new System.EventHandler(this.butOpen_MouseLeave);
            // 
            // butProcessing
            // 
            this.butProcessing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butProcessing.Dock = System.Windows.Forms.DockStyle.Left;
            this.butProcessing.FlatAppearance.BorderSize = 0;
            this.butProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProcessing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butProcessing.Location = new System.Drawing.Point(191, 0);
            this.butProcessing.Name = "butProcessing";
            this.butProcessing.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.butProcessing.Size = new System.Drawing.Size(191, 89);
            this.butProcessing.TabIndex = 5;
            this.butProcessing.Text = "Processing";
            this.butProcessing.UseVisualStyleBackColor = false;
            this.butProcessing.Click += new System.EventHandler(this.butProcessing_Click);
            this.butProcessing.MouseEnter += new System.EventHandler(this.butProcessing_MouseEnter);
            this.butProcessing.MouseLeave += new System.EventHandler(this.butProcessing_MouseLeave);
            // 
            // butTest
            // 
            this.butTest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTest.FlatAppearance.BorderSize = 0;
            this.butTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butTest.Location = new System.Drawing.Point(382, 0);
            this.butTest.Name = "butTest";
            this.butTest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.butTest.Size = new System.Drawing.Size(191, 89);
            this.butTest.TabIndex = 4;
            this.butTest.Text = "Test";
            this.butTest.UseVisualStyleBackColor = false;
            this.butTest.Click += new System.EventHandler(this.butTest_Click);
            this.butTest.MouseEnter += new System.EventHandler(this.butTest_MouseEnter);
            this.butTest.MouseLeave += new System.EventHandler(this.butTest_MouseLeave);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.butSave.FlatAppearance.BorderSize = 0;
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butSave.Location = new System.Drawing.Point(838, 0);
            this.butSave.Name = "butSave";
            this.butSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.butSave.Size = new System.Drawing.Size(191, 89);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Save Image";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            this.butSave.MouseEnter += new System.EventHandler(this.butSave_MouseEnter);
            this.butSave.MouseLeave += new System.EventHandler(this.butSave_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.butSave);
            this.panel4.Controls.Add(this.butTest);
            this.panel4.Controls.Add(this.butProcessing);
            this.panel4.Controls.Add(this.butOpen);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1029, 89);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBoxSoil
            // 
            this.pictureBoxSoil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSoil.Location = new System.Drawing.Point(76, 43);
            this.pictureBoxSoil.Name = "pictureBoxSoil";
            this.pictureBoxSoil.Size = new System.Drawing.Size(377, 312);
            this.pictureBoxSoil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSoil.TabIndex = 5;
            this.pictureBoxSoil.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 431);
            this.panel2.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.OutputPictureBox);
            this.panel8.Controls.Add(this.pictureBoxSoil);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(32, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(973, 376);
            this.panel8.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1005, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(24, 376);
            this.panel7.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(32, 407);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(997, 24);
            this.panel6.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 400);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 31);
            this.panel3.TabIndex = 6;
            // 
            // OutputPictureBox
            // 
            this.OutputPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputPictureBox.Location = new System.Drawing.Point(479, 43);
            this.OutputPictureBox.Name = "OutputPictureBox";
            this.OutputPictureBox.Size = new System.Drawing.Size(376, 312);
            this.OutputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutputPictureBox.TabIndex = 6;
            this.OutputPictureBox.TabStop = false;
            // 
            // @new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1029, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(728, 485);
            this.Name = "@new";
            this.Text = "@new";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoil)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.Button butProcessing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.PictureBox pictureBoxSoil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox OutputPictureBox;
    }
}