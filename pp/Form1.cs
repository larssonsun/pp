using System;
using System.Drawing;
using System.Windows.Forms;

namespace pp
{
    public partial class Form1 : Form
    {
        bool canSetResult = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            tbAddMny.Text = "10";
            tbHeadAndEnd.Text = "900";

            //
            int begin = 17;
            int end = 50;
            for (int i = 0; i < (end - begin + 1); i++)
            {
                Label bttn = new Label();
                bttn.BorderStyle = BorderStyle.FixedSingle;
                bttn.Margin = new Padding(3, 3, 3, 3);
                bttn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                bttn.Text = (begin + i).ToString();
                bttn.Size = new Size(59, 47);
                bttn.Location = new Point(0 + i * 58, 42);
                bttn.MouseHover += Bttn_MouseHover;
                bttn.MouseLeave += Bttn_MouseLeave;
                //bttn.Click += Bttn_Click;


                if (i < 10)
                    bttn.BackColor = Color.Silver;
                else if (i < 20)
                    bttn.BackColor = Color.SlateGray;
                else if (i < 30)
                    bttn.BackColor = Color.WhiteSmoke;
                flowLayoutPanel1.Controls.Add(bttn);
            }

            //
            ShowForm2();
        }

        
        //private void Bttn_Click(object sender, EventArgs e)
        //{

        //    if (canSetResult)
        //        canSetResult = false;
        //    else
        //    {
        //        canSetResult = true;
        //        SetResult(sender);
        //    }

        //}

        private void Bttn_MouseHover(object sender, EventArgs e)
        {
            if (canSetResult)
                SetResult(sender);
        }

        private void Bttn_MouseLeave(object sender, EventArgs e)
        {
            Label tb = sender as Label;
            
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.ForeColor = Color.Black;
        }

        private void SetResult(object sender)
        {
            Label tb = sender as Label;
            tb.BorderStyle = BorderStyle.Fixed3D;
            tb.ForeColor = Color.Red;
            lResult.Text = (int.Parse(tb.Text) + int.Parse(tbAddMny.Text)).ToString();
            lMny.Text = tbHeadAndEnd.Text.Substring(0, 1) + lResult.Text + tbHeadAndEnd.Text.Substring(1, 2);

            if (this.OwnedForms.Length != 0)
                (this.OwnedForms[0] as Form2).SetMny = lMny.Text;

            SendKeys.SendWait("^a");
            SendKeys.Send("{DELETE}");
            SendKeys.Send(tbHeadAndEnd.Text.Substring(0, 1) + lResult.Text + tbHeadAndEnd.Text.Substring(1, 2));
        }

        private void buttonAddMny_Click(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            string flg = bttn.Text;
            if (flg == "+")
                tbAddMny.Text = (int.Parse(tbAddMny.Text) + 1).ToString();
            else
                tbAddMny.Text = (int.Parse(tbAddMny.Text) - 1).ToString();

            if (int.Parse(tbAddMny.Text) <= 0 ||
                int.Parse(tbAddMny.Text) > 99)
                tbAddMny.Text = "8";
        }

        private void bttnAddHE_Click(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            string flg = bttn.Text;
            if (flg == "+")
                tbHeadAndEnd.Text = (int.Parse(tbHeadAndEnd.Text) + 100).ToString();
            else
                tbHeadAndEnd.Text = (int.Parse(tbHeadAndEnd.Text) - 100).ToString();

            if (int.Parse(tbHeadAndEnd.Text) < 100 ||
                int.Parse(tbHeadAndEnd.Text) > 1000)
                tbHeadAndEnd.Text = "800";
        }

        private void CreateTwoFrm()
        {
            Form frm = new Form();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.BackColor = Color.Black;
            frm.TopMost = true;
            frm.Size = new Size(10, 10);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MouseUp += Frm_MouseUp;
            frm.MouseMove += Frm_MouseMove;
            frm.MouseDown += Frm_MouseDown;
            frm.DoubleClick += Frm_DoubleClick;
            frm.Show();
        }

        private void Frm_DoubleClick(object sender, EventArgs e)
        {
            ((Form)sender).Close();
        }

        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                ((Form)sender).Location = mouseSet;
            }
        }

        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
                leftFlag = false;//释放鼠标后标注为false;
        }

        private void bttnAddF_Click(object sender, EventArgs e)
        {
            CreateTwoFrm();
        }

        private void ShowForm2()
        {
            Form frm = new Form2();
            frm.Owner = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopMost = true;
            frm.MouseUp += Frm_MouseUp;
            frm.MouseMove += Frm_MouseMove;
            frm.MouseDown += Frm_MouseDown;
            //frm.DoubleClick += Frm_DoubleClick;
            frm.Show();
        }
    }
}
