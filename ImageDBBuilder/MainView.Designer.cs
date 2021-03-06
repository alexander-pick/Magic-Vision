﻿namespace ImageDBBuilder
{
    partial class MainView
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
            this.buildButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.postfixBox = new System.Windows.Forms.TextBox();
            this.Postfix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buildButton
            // 
            this.buildButton.BackColor = System.Drawing.Color.DarkOrange;
            this.buildButton.Location = new System.Drawing.Point(12, 399);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(572, 53);
            this.buildButton.TabIndex = 1;
            this.buildButton.Text = "Build new pHash Image DB";
            this.buildButton.UseVisualStyleBackColor = false;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(13, 376);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(29, 13);
            this.Label.TabIndex = 2;
            this.Label.Text = "Path";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(16, 12);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(568, 355);
            this.logBox.TabIndex = 3;
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(48, 373);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(335, 20);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "E:\\";
            // 
            // postfixBox
            // 
            this.postfixBox.Location = new System.Drawing.Point(483, 373);
            this.postfixBox.Name = "postfixBox";
            this.postfixBox.Size = new System.Drawing.Size(100, 20);
            this.postfixBox.TabIndex = 5;
            this.postfixBox.Text = ".xlhq";
            // 
            // Postfix
            // 
            this.Postfix.AutoSize = true;
            this.Postfix.Location = new System.Drawing.Point(439, 376);
            this.Postfix.Name = "Postfix";
            this.Postfix.Size = new System.Drawing.Size(38, 13);
            this.Postfix.TabIndex = 6;
            this.Postfix.Text = "Postfix";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 464);
            this.Controls.Add(this.Postfix);
            this.Controls.Add(this.postfixBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.pathBox);
            this.Name = "MainView";
            this.Text = "ImageDBBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox postfixBox;
        private System.Windows.Forms.Label Postfix;
    }
}

