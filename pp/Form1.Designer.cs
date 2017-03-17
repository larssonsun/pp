namespace pp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbAddMny = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.tbHeadAndEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnAddMny = new System.Windows.Forms.Button();
            this.bttnDiffMny = new System.Windows.Forms.Button();
            this.bttnAddHE = new System.Windows.Forms.Button();
            this.bttnDiffHE = new System.Windows.Forms.Button();
            this.bttnAddF = new System.Windows.Forms.Button();
            this.lMny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 345);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tbAddMny
            // 
            this.tbAddMny.Enabled = false;
            this.tbAddMny.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddMny.Location = new System.Drawing.Point(222, 6);
            this.tbAddMny.MaxLength = 2;
            this.tbAddMny.Name = "tbAddMny";
            this.tbAddMny.ReadOnly = true;
            this.tbAddMny.Size = new System.Drawing.Size(32, 30);
            this.tbAddMny.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "百";
            // 
            // lResult
            // 
            this.lResult.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.ForeColor = System.Drawing.Color.Red;
            this.lResult.Location = new System.Drawing.Point(322, 4);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(71, 34);
            this.lResult.TabIndex = 6;
            this.lResult.Text = "0";
            this.lResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHeadAndEnd
            // 
            this.tbHeadAndEnd.Enabled = false;
            this.tbHeadAndEnd.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeadAndEnd.Location = new System.Drawing.Point(71, 5);
            this.tbHeadAndEnd.MaxLength = 3;
            this.tbHeadAndEnd.Name = "tbHeadAndEnd";
            this.tbHeadAndEnd.ReadOnly = true;
            this.tbHeadAndEnd.Size = new System.Drawing.Size(50, 30);
            this.tbHeadAndEnd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "首尾";
            // 
            // bttnAddMny
            // 
            this.bttnAddMny.Location = new System.Drawing.Point(178, 10);
            this.bttnAddMny.Name = "bttnAddMny";
            this.bttnAddMny.Size = new System.Drawing.Size(19, 21);
            this.bttnAddMny.TabIndex = 9;
            this.bttnAddMny.Text = "-";
            this.bttnAddMny.UseVisualStyleBackColor = true;
            this.bttnAddMny.Click += new System.EventHandler(this.buttonAddMny_Click);
            // 
            // bttnDiffMny
            // 
            this.bttnDiffMny.Location = new System.Drawing.Point(277, 9);
            this.bttnDiffMny.Name = "bttnDiffMny";
            this.bttnDiffMny.Size = new System.Drawing.Size(19, 21);
            this.bttnDiffMny.TabIndex = 10;
            this.bttnDiffMny.Text = "+";
            this.bttnDiffMny.UseVisualStyleBackColor = true;
            this.bttnDiffMny.Click += new System.EventHandler(this.buttonAddMny_Click);
            // 
            // bttnAddHE
            // 
            this.bttnAddHE.Location = new System.Drawing.Point(10, 9);
            this.bttnAddHE.Name = "bttnAddHE";
            this.bttnAddHE.Size = new System.Drawing.Size(19, 21);
            this.bttnAddHE.TabIndex = 11;
            this.bttnAddHE.Text = "-";
            this.bttnAddHE.UseVisualStyleBackColor = true;
            this.bttnAddHE.Click += new System.EventHandler(this.bttnAddHE_Click);
            // 
            // bttnDiffHE
            // 
            this.bttnDiffHE.Location = new System.Drawing.Point(124, 9);
            this.bttnDiffHE.Name = "bttnDiffHE";
            this.bttnDiffHE.Size = new System.Drawing.Size(19, 21);
            this.bttnDiffHE.TabIndex = 12;
            this.bttnDiffHE.Text = "+";
            this.bttnDiffHE.UseVisualStyleBackColor = true;
            this.bttnDiffHE.Click += new System.EventHandler(this.bttnAddHE_Click);
            // 
            // bttnAddF
            // 
            this.bttnAddF.Location = new System.Drawing.Point(10, 42);
            this.bttnAddF.Name = "bttnAddF";
            this.bttnAddF.Size = new System.Drawing.Size(19, 18);
            this.bttnAddF.TabIndex = 13;
            this.bttnAddF.Text = "f";
            this.bttnAddF.UseVisualStyleBackColor = true;
            this.bttnAddF.Click += new System.EventHandler(this.bttnAddF_Click);
            // 
            // lMny
            // 
            this.lMny.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMny.ForeColor = System.Drawing.Color.Maroon;
            this.lMny.Location = new System.Drawing.Point(282, 38);
            this.lMny.Name = "lMny";
            this.lMny.Size = new System.Drawing.Size(111, 34);
            this.lMny.TabIndex = 14;
            this.lMny.Text = "0";
            this.lMny.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 422);
            this.Controls.Add(this.lMny);
            this.Controls.Add(this.bttnAddF);
            this.Controls.Add(this.bttnDiffHE);
            this.Controls.Add(this.bttnAddHE);
            this.Controls.Add(this.bttnDiffMny);
            this.Controls.Add(this.bttnAddMny);
            this.Controls.Add(this.tbHeadAndEnd);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddMny);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbAddMny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.TextBox tbHeadAndEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnAddMny;
        private System.Windows.Forms.Button bttnDiffMny;
        private System.Windows.Forms.Button bttnAddHE;
        private System.Windows.Forms.Button bttnDiffHE;
        private System.Windows.Forms.Button bttnAddF;
        private System.Windows.Forms.Label lMny;
    }
}

