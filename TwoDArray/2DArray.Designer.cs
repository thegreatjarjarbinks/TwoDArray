namespace TwoDArray
{
    partial class frmArray
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.lstArray = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(13, 32);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(234, 13);
            this.lblEnter.TabIndex = 3;
            this.lblEnter.Text = "Please enter the size of the array you would like:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 219);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(81, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "The average is:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(16, 85);
            this.nudWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(71, 20);
            this.nudWidth.TabIndex = 5;
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(15, 59);
            this.nudLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(72, 20);
            this.nudLength.TabIndex = 6;
            // 
            // lstArray
            // 
            this.lstArray.FormattingEnabled = true;
            this.lstArray.Location = new System.Drawing.Point(137, 59);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(120, 95);
            this.lstArray.TabIndex = 7;
            // 
            // frmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstArray);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmArray";
            this.Text = "2D Array";
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.ListBox lstArray;
    }
}

