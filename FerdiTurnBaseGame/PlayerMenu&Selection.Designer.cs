namespace FerdiTurnBaseGame
{
    partial class PlayerMenu_Selection
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(184, 392);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 351);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(313, 331);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(456, 331);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(235, 214);
            listBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(284, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 161);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // PlayerMenu_Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 563);
            Controls.Add(pictureBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "PlayerMenu_Selection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayerMenu_Selection";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private PictureBox pictureBox1;
    }
}