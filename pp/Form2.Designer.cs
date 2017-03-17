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
            this.SuspendLayout();
            // 
            // lT2
            // 
            this.lT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lT2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lT2.Location = new System.Drawing.Point(2, 3);
            this.lT2.Name = "lT2";
            this.lT2.Size = new System.Drawing.Size(110, 38);
            this.lT2.TabIndex = 0;
            this.lT2.Text = "00:00:00";
            this.lT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lT2.DoubleClick += new System.EventHandler(this.lT2_DoubleClick);
            // 
            // lMny2
            // 
            this.lMny2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lMny2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lMny2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMny2.ForeColor = System.Drawing.Color.Red;
            this.lMny2.Location = new System.Drawing.Point(2, 41);
            this.lMny2.Name = "lMny2";
            this.lMny2.Size = new System.Drawing.Size(83, 38);
            this.lMny2.TabIndex = 1;
            this.lMny2.Text = "00000";
            this.lMny2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bttnAddT
            // 
            this.bttnAddT.Location = new System.Drawing.Point(118, 2);
            this.bttnAddT.Name = "bttnAddT";
            this.bttnAddT.Size = new System.Drawing.Size(19, 21);
            this.bttnAddT.TabIndex = 13;
            this.bttnAddT.Text = "+";
            this.bttnAddT.UseVisualStyleBackColor = true;
            this.bttnAddT.Click += new System.EventHandler(this.bttnAddT_Click);
            // 
            // bttnDeffT
            // 
            this.bttnDeffT.Location = new System.Drawing.Point(118, 21);
            this.bttnDeffT.Name = "bttnDeffT";
            this.bttnDeffT.Size = new System.Drawing.Size(19, 21);
            this.bttnDeffT.TabIndex = 14;
            this.bttnDeffT.Text = "-";
            this.bttnDeffT.UseVisualStyleBackColor = true;
            this.bttnDeffT.Click += new System.EventHandler(this.bttnDeffT_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(136, 81);
            this.Controls.Add(this.bttnDeffT);
            this.Controls.Add(this.bttnAddT);
            this.Controls.Add(this.lMny2);
            this.Controls.Add(this.lT2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lT2;
        private System.Windows.Forms.Label lMny2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttnAddT;
        private System.Windows.Forms.Button bttnDeffT;
    }
}