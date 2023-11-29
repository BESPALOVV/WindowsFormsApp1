using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(double X, double X1, double Dx, double A, double B,double C)
        {
            InitializeComponent();
            double F;
            for (double x = X; x <= X1; x += Dx)
            {

                if (x < 0 & B != 0)
                {
                    F = A * x * x + B;
                }
                else if (x > 0 & B == 0)
                {
                    F = (x - A) / (x - C);
                }
                else
                    F = x / C;
                x = Math.Round(x, 2, MidpointRounding.AwayFromZero);
                F = Math.Round(F, 2, MidpointRounding.AwayFromZero);

                dataGridView1.Rows.Add(x,F);
               
            }
        }
          
       
    }

       

        
    }

