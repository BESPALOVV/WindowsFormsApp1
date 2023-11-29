using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
            midlebutton.Enabled = false;
           
        }
          bool marker1,marker2,marker3,marker4,marker5, marker6;
        private void midlebutton_Click(object sender, EventArgs e)
        {   double X = double.Parse(TB_X0.Text);
            double X1= double.Parse(TB_XK.Text);
            double Dx= Convert.ToDouble(TB_DX.Text);
            double A= double.Parse(TB_A.Text);
            double B= double.Parse(TB_B.Text);
            double C= double.Parse(TB_C.Text);
            double F;
            if (X >= X1) { MessageBox.Show("X0 не должно быть больше или равно  X1"); }
            if ( Dx<=0) { MessageBox.Show("Dx должно быть больше нуля"); }
            if (C==0) { MessageBox.Show("C не должно быть равно нулю"); }
            if (X < X1 & Dx > 0 & C != 0) 
            {
                var MyForm = new Form2(X,X1,Dx,A,B,C);
                MyForm.Show();
                
                 
                
                
            }

           
           
            
        }

        private void TB_X0_TextChanged(object sender, EventArgs e)
        {
          
           if(TB_X0.ContainCharacter()) 
            {
                MessageBox.Show("This field can contain only digits");
                TB_X0.Text = "";
                marker1 = false;
            }
           else if (TB_X0.ContainWhiteSpace()|| TB_X0.Text == "") { marker1 = false; }
            else { marker1 = true; } 
                

            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (marker1 & marker2 & marker3 & marker4 & marker5 & marker6)
            {midlebutton.Enabled = true; }
            else
                midlebutton.Enabled = false;
        }

        private void TB_XK_TextChanged(object sender, EventArgs e)
        {

            if (TB_XK.ContainCharacter())
            {
                MessageBox.Show("This field can contain only digits");
                TB_XK.Text = "";
                marker2 = false;
            }
            else if (TB_XK.ContainWhiteSpace() || TB_XK.Text == "") { marker2 = false; }
            else { marker2 = true; }
        }

        private void TB_DX_TextChanged(object sender, EventArgs e)
        {

            if (TB_DX.ContainCharacter())
            {
                MessageBox.Show("This field can contain only digits");
                TB_DX.Text = "";
                marker3 = false;
            }
            else if (TB_DX.ContainWhiteSpace() || TB_DX.Text == "") { marker3 = false; }
            else { marker3 = true; }
        }

        private void TB_A_TextChanged(object sender, EventArgs e)
        {

            if (TB_A.ContainCharacter())
            {
                MessageBox.Show("This field can contain only digits");
                TB_A.Text = "";
                marker4 = false;
            }
            else if (TB_A.ContainWhiteSpace() || TB_A.Text == "") { marker4 = false; }
            else { marker4 = true; }
        }

        private void TB_B_TextChanged(object sender, EventArgs e)
        {
            if (TB_B.ContainCharacter())
            {
                MessageBox.Show("This field can contain only digits");
                TB_B.Text = "";
                marker5 = false;
            }
            else if (TB_B.ContainWhiteSpace() || TB_B.Text == "") { marker5 = false; }
            else { marker5 = true; }
        }

        private void TB_C_TextChanged(object sender, EventArgs e)
        {

            
            
            if (TB_C.ContainCharacter())
            {
                MessageBox.Show("This field can contain only digits");
                TB_C.Text = "";
                marker6 = false;
            }
            else if (TB_C.ContainWhiteSpace() || TB_C.Text == "") { marker6 = false; }
            else { marker6 = true; }

        }
    }
}
