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
            cbOperations = new ComboBox();
            btnCompute = new Button();
            panel1 = new Panel();
            lblResult = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
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
            btnCompute.Location = new Point(136, 423);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(137, 44);
            btnCompute.TabIndex = 4;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(37, 306);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 101);
            panel1.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Sylfaen", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Chartreuse;
            lblResult.Location = new Point(89, 28);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 52);
            lblResult.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(71, 31);
            label2.TabIndex = 6;
            label2.Text = "Total:";
            // 
            // frmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 494);
            Controls.Add(panel1);
            Controls.Add(btnCompute);
            Controls.Add(cbOperations);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "frmBasicCalculator";
            Text = "frmBasicCalculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cbOperations;
        private Button btnCompute;
        private Panel panel1;
        private Label lblResult;
        private Label label2;
    }
}
