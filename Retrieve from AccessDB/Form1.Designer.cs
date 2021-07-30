
namespace Retrieve_from_AccessDB
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
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(159, 66);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(107, 36);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(12, 108);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(386, 158);
            this.ResultBox.TabIndex = 1;
            this.ResultBox.Text = "";
            // 
            // QueryBox
            // 
            this.QueryBox.Location = new System.Drawing.Point(119, 40);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(189, 20);
            this.QueryBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 278);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.TextBox QueryBox;
    }
}

