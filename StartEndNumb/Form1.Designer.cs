namespace StartEndNumb
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startNumInput = new System.Windows.Forms.TextBox();
            this.endNumInput = new System.Windows.Forms.TextBox();
            this.valueButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Starting Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a Ending Number";
            // 
            // startNumInput
            // 
            this.startNumInput.Location = new System.Drawing.Point(303, 44);
            this.startNumInput.Name = "startNumInput";
            this.startNumInput.Size = new System.Drawing.Size(42, 20);
            this.startNumInput.TabIndex = 2;
            // 
            // endNumInput
            // 
            this.endNumInput.Location = new System.Drawing.Point(303, 76);
            this.endNumInput.Name = "endNumInput";
            this.endNumInput.Size = new System.Drawing.Size(42, 20);
            this.endNumInput.TabIndex = 3;
            // 
            // valueButton
            // 
            this.valueButton.Location = new System.Drawing.Point(220, 119);
            this.valueButton.Name = "valueButton";
            this.valueButton.Size = new System.Drawing.Size(88, 23);
            this.valueButton.TabIndex = 4;
            this.valueButton.Text = "Show Values";
            this.valueButton.UseVisualStyleBackColor = true;
            this.valueButton.Click += new System.EventHandler(this.valueButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(55, 191);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 263);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.valueButton);
            this.Controls.Add(this.endNumInput);
            this.Controls.Add(this.startNumInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startNumInput;
        private System.Windows.Forms.TextBox endNumInput;
        private System.Windows.Forms.Button valueButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

