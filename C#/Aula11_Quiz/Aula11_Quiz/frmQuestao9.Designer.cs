﻿namespace Aula11_Quiz
{
    partial class frmQuestao9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestao9));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radCerto = new System.Windows.Forms.RadioButton();
            this.ss = new System.Windows.Forms.RadioButton();
            this.fff = new System.Windows.Forms.RadioButton();
            this.fsasafsfa = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radCerto);
            this.groupBox1.Controls.Add(this.ss);
            this.groupBox1.Controls.Add(this.fff);
            this.groupBox1.Controls.Add(this.fsasafsfa);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 246);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questão 9";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(130, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radCerto
            // 
            this.radCerto.AutoSize = true;
            this.radCerto.Location = new System.Drawing.Point(293, 157);
            this.radCerto.Name = "radCerto";
            this.radCerto.Size = new System.Drawing.Size(96, 33);
            this.radCerto.TabIndex = 5;
            this.radCerto.TabStop = true;
            this.radCerto.Text = "Hisoka";
            this.radCerto.UseVisualStyleBackColor = true;
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Location = new System.Drawing.Point(6, 157);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(129, 33);
            this.ss.TabIndex = 4;
            this.ss.TabStop = true;
            this.ss.Text = "Black Star";
            this.ss.UseVisualStyleBackColor = true;
            // 
            // fff
            // 
            this.fff.AutoSize = true;
            this.fff.Location = new System.Drawing.Point(293, 97);
            this.fff.Name = "fff";
            this.fff.Size = new System.Drawing.Size(96, 33);
            this.fff.TabIndex = 3;
            this.fff.TabStop = true;
            this.fff.Text = "Fubuki";
            this.fff.UseVisualStyleBackColor = true;
            // 
            // fsasafsfa
            // 
            this.fsasafsfa.AutoSize = true;
            this.fsasafsfa.Location = new System.Drawing.Point(6, 97);
            this.fsasafsfa.Name = "fsasafsfa";
            this.fsasafsfa.Size = new System.Drawing.Size(121, 33);
            this.fsasafsfa.TabIndex = 2;
            this.fsasafsfa.TabStop = true;
            this.fsasafsfa.Text = "Jonathan";
            this.fsasafsfa.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(0, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(530, 55);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Adivinhe o nome do personagem que esta nesta foto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Aula11_Quiz.Properties.Resources._8ba53fc58194314196724843f14aff2b;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(519, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 221);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuestao9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 270);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuestao9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestao9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radCerto;
        private System.Windows.Forms.RadioButton ss;
        private System.Windows.Forms.RadioButton fff;
        private System.Windows.Forms.RadioButton fsasafsfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}