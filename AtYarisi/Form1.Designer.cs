namespace AtYarisi
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerRace = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxFinishLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxHorse2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHorse4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHorse3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHorse5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHorse1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStartLine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartLine)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(527, 309);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 65);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerRace
            // 
            this.timerRace.Tick += new System.EventHandler(this.timerRace_Tick);
            // 
            // pictureBoxFinishLine
            // 
            this.pictureBoxFinishLine.Image = global::AtYarisi.Properties.Resources.f1;
            this.pictureBoxFinishLine.Location = new System.Drawing.Point(608, 12);
            this.pictureBoxFinishLine.Name = "pictureBoxFinishLine";
            this.pictureBoxFinishLine.Size = new System.Drawing.Size(44, 285);
            this.pictureBoxFinishLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFinishLine.TabIndex = 5;
            this.pictureBoxFinishLine.TabStop = false;
            // 
            // pictureBoxHorse2
            // 
            this.pictureBoxHorse2.Image = global::AtYarisi.Properties.Resources.h2;
            this.pictureBoxHorse2.Location = new System.Drawing.Point(31, 80);
            this.pictureBoxHorse2.Name = "pictureBoxHorse2";
            this.pictureBoxHorse2.Size = new System.Drawing.Size(59, 43);
            this.pictureBoxHorse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHorse2.TabIndex = 4;
            this.pictureBoxHorse2.TabStop = false;
            // 
            // pictureBoxHorse4
            // 
            this.pictureBoxHorse4.Image = global::AtYarisi.Properties.Resources.h4;
            this.pictureBoxHorse4.Location = new System.Drawing.Point(31, 178);
            this.pictureBoxHorse4.Name = "pictureBoxHorse4";
            this.pictureBoxHorse4.Size = new System.Drawing.Size(59, 43);
            this.pictureBoxHorse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHorse4.TabIndex = 3;
            this.pictureBoxHorse4.TabStop = false;
            // 
            // pictureBoxHorse3
            // 
            this.pictureBoxHorse3.Image = global::AtYarisi.Properties.Resources.h3;
            this.pictureBoxHorse3.Location = new System.Drawing.Point(31, 129);
            this.pictureBoxHorse3.Name = "pictureBoxHorse3";
            this.pictureBoxHorse3.Size = new System.Drawing.Size(59, 43);
            this.pictureBoxHorse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHorse3.TabIndex = 2;
            this.pictureBoxHorse3.TabStop = false;
            // 
            // pictureBoxHorse5
            // 
            this.pictureBoxHorse5.Image = global::AtYarisi.Properties.Resources.h5;
            this.pictureBoxHorse5.Location = new System.Drawing.Point(31, 227);
            this.pictureBoxHorse5.Name = "pictureBoxHorse5";
            this.pictureBoxHorse5.Size = new System.Drawing.Size(59, 43);
            this.pictureBoxHorse5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHorse5.TabIndex = 1;
            this.pictureBoxHorse5.TabStop = false;
            // 
            // pictureBoxHorse1
            // 
            this.pictureBoxHorse1.Image = global::AtYarisi.Properties.Resources.h1;
            this.pictureBoxHorse1.Location = new System.Drawing.Point(31, 31);
            this.pictureBoxHorse1.Name = "pictureBoxHorse1";
            this.pictureBoxHorse1.Size = new System.Drawing.Size(59, 43);
            this.pictureBoxHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHorse1.TabIndex = 0;
            this.pictureBoxHorse1.TabStop = false;
            // 
            // pictureBoxStartLine
            // 
            this.pictureBoxStartLine.Location = new System.Drawing.Point(96, 12);
            this.pictureBoxStartLine.Name = "pictureBoxStartLine";
            this.pictureBoxStartLine.Size = new System.Drawing.Size(14, 285);
            this.pictureBoxStartLine.TabIndex = 7;
            this.pictureBoxStartLine.TabStop = false;
            this.pictureBoxStartLine.Click += new System.EventHandler(this.pictureBoxStartLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 406);
            this.Controls.Add(this.pictureBoxStartLine);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxFinishLine);
            this.Controls.Add(this.pictureBoxHorse2);
            this.Controls.Add(this.pictureBoxHorse4);
            this.Controls.Add(this.pictureBoxHorse3);
            this.Controls.Add(this.pictureBoxHorse5);
            this.Controls.Add(this.pictureBoxHorse1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerRace;
        private System.Windows.Forms.PictureBox pictureBoxFinishLine;
        private System.Windows.Forms.PictureBox pictureBoxHorse2;
        private System.Windows.Forms.PictureBox pictureBoxHorse4;
        private System.Windows.Forms.PictureBox pictureBoxHorse3;
        private System.Windows.Forms.PictureBox pictureBoxHorse5;
        private System.Windows.Forms.PictureBox pictureBoxHorse1;
        private System.Windows.Forms.PictureBox pictureBoxStartLine;
    }
}

