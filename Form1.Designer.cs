namespace Gui_Demo
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            no = new Button();
            Yes = new Button();
            radioButton1 = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(423, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Good job you clicked the red button";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(423, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Good job you clicked the blue button";
            // 
            // no
            // 
            no.BackColor = Color.Blue;
            no.Cursor = Cursors.Hand;
            no.Location = new Point(249, 297);
            no.Name = "no";
            no.Size = new Size(147, 82);
            no.TabIndex = 2;
            no.Text = "Blue";
            no.UseVisualStyleBackColor = false;
            // 
            // Yes
            // 
            Yes.BackColor = Color.Red;
            Yes.Cursor = Cursors.Hand;
            Yes.Location = new Point(645, 297);
            Yes.Name = "Yes";
            Yes.Size = new Size(164, 82);
            Yes.TabIndex = 3;
            Yes.Text = "Red";
            Yes.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Brown;
            radioButton1.Location = new Point(474, 426);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Radio Comms";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1130, 615);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton1);
            Controls.Add(Yes);
            Controls.Add(no);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Sullys GUI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button no;
        private Button button1;
        private Button Yes;
        private RadioButton radioButton1;
        private PictureBox pictureBox1;
    }
}
