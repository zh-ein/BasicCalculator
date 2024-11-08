namespace BasicCalculator
{
    partial class frmBasicCalculator
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
            label1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            rtbResult = new RichTextBox();
            cbOperations = new ComboBox();
            btnCompute = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(233, 29);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(31, 92);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(342, 46);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(31, 213);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(342, 46);
            txtNum2.TabIndex = 1;
            // 
            // rtbResult
            // 
            rtbResult.BackColor = Color.Black;
            rtbResult.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbResult.ForeColor = Color.LawnGreen;
            rtbResult.Location = new Point(32, 293);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(339, 106);
            rtbResult.TabIndex = 2;
            rtbResult.Text = "";
            // 
            // cbOperations
            // 
            cbOperations.FormattingEnabled = true;
            cbOperations.Location = new Point(174, 161);
            cbOperations.Name = "cbOperations";
            cbOperations.Size = new Size(64, 33);
            cbOperations.TabIndex = 3;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(136, 429);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(128, 38);
            btnCompute.TabIndex = 4;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // frmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 494);
            Controls.Add(btnCompute);
            Controls.Add(cbOperations);
            Controls.Add(rtbResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "frmBasicCalculator";
            Text = "frmBasicCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private RichTextBox rtbResult;
        private ComboBox cbOperations;
        private Button btnCompute;
    }
}
