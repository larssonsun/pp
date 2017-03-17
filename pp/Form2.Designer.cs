namespace pp
{
    partial class Form2
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
            this.lT2 = new System.Windows.Forms.Label();
            this.lMny2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bttnAddT = new System.Windows.Forms.Button();
            this.bttnDeffT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lT2
            // 
            this.lT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lT2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lT2.ForeColor = System.Drawing.Color.Red;
            this.lT2.Location = new System.Drawing.Point(89, 2);
            this.lT2.Name = "lT2";
            this.lT2.Size = new System.Drawing.Size(87, 19);
            this.lT2.TabIndex = 0;
            this.lT2.Text = "00:00:00";
            this.lT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lT2.DoubleClick += new System.EventHandler(this.lT2_DoubleClick);
            // 
            // lMny2
            // 
            this.lMny2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lMny2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lMny2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lMny2.ForeColor = System.Drawing.Color.Red;
            this.lMny2.Location = new System.Drawing.Point(158, 33);
            this.lMny2.Name = "lMny2";
            this.lMny2.Size = new System.Drawing.Size(58, 19);
            this.lMny2.TabIndex = 1;
            this.lMny2.Text = "00000";
            this.lMny2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bttnAddT
            // 
            this.bttnAddT.Location = new System.Drawing.Point(185, 2);
            this.bttnAddT.Name = "bttnAddT";
            this.bttnAddT.Size = new System.Drawing.Size(19, 21);
            this.bttnAddT.TabIndex = 13;
            this.bttnAddT.Text = "+";
            this.bttnAddT.UseVisualStyleBackColor = true;
            this.bttnAddT.Click += new System.EventHandler(this.bttnAddT_Click);
            // 
            // bttnDeffT
            // 
            this.bttnDeffT.Location = new System.Drawing.Point(210, 2);
            this.bttnDeffT.Name = "bttnDeffT";
            this.bttnDeffT.Size = new System.Drawing.Size(19, 21);
            this.bttnDeffT.TabIndex = 14;
            this.bttnDeffT.Text = "-";
            this.bttnDeffT.UseVisualStyleBackColor = true;
            this.bttnDeffT.Click += new System.EventHandler(this.bttnDeffT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(127, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "我出";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(217, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "可出";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(247, 57);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnDeffT);
            this.Controls.Add(this.bttnAddT);
            this.Controls.Add(this.lMny2);
            this.Controls.Add(this.lT2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lT2;
        private System.Windows.Forms.Label lMny2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttnAddT;
        private System.Windows.Forms.Button bttnDeffT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}