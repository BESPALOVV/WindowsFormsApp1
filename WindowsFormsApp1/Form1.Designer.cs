namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.midlebutton = new System.Windows.Forms.Button();
            this.labelTopLeft = new System.Windows.Forms.Label();
            this.labelMidleLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_C = new System.Windows.Forms.TextBox();
            this.TB_B = new System.Windows.Forms.TextBox();
            this.TB_A = new System.Windows.Forms.TextBox();
            this.TB_DX = new System.Windows.Forms.TextBox();
            this.TB_XK = new System.Windows.Forms.TextBox();
            this.TB_X0 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // midlebutton
            // 
            this.midlebutton.FlatAppearance.BorderSize = 0;
            this.midlebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.midlebutton.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midlebutton.Location = new System.Drawing.Point(174, 355);
            this.midlebutton.Name = "midlebutton";
            this.midlebutton.Size = new System.Drawing.Size(94, 23);
            this.midlebutton.TabIndex = 0;
            this.midlebutton.Text = "Рассчитать";
            this.midlebutton.UseVisualStyleBackColor = true;
            this.midlebutton.Click += new System.EventHandler(this.midlebutton_Click);
            // 
            // labelTopLeft
            // 
            this.labelTopLeft.BackColor = System.Drawing.SystemColors.Control;
            this.labelTopLeft.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopLeft.Location = new System.Drawing.Point(47, 200);
            this.labelTopLeft.Name = "labelTopLeft";
            this.labelTopLeft.Size = new System.Drawing.Size(43, 18);
            this.labelTopLeft.TabIndex = 1;
            this.labelTopLeft.Text = "Xнач";
            this.labelTopLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMidleLeft
            // 
            this.labelMidleLeft.AutoSize = true;
            this.labelMidleLeft.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMidleLeft.Location = new System.Drawing.Point(47, 231);
            this.labelMidleLeft.Name = "labelMidleLeft";
            this.labelMidleLeft.Size = new System.Drawing.Size(43, 18);
            this.labelMidleLeft.TabIndex = 2;
            this.labelMidleLeft.Text = "Xкон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dх";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "A";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._7XMDE0syvuI;
            this.panel1.Controls.Add(this.TB_C);
            this.panel1.Controls.Add(this.TB_B);
            this.panel1.Controls.Add(this.TB_A);
            this.panel1.Controls.Add(this.TB_DX);
            this.panel1.Controls.Add(this.TB_XK);
            this.panel1.Controls.Add(this.TB_X0);
            this.panel1.Controls.Add(this.midlebutton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 437);
            this.panel1.TabIndex = 7;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // TB_C
            // 
            this.TB_C.Location = new System.Drawing.Point(325, 254);
            this.TB_C.Name = "TB_C";
            this.TB_C.Size = new System.Drawing.Size(100, 20);
            this.TB_C.TabIndex = 13;
            this.TB_C.TextChanged += new System.EventHandler(this.TB_C_TextChanged);
            // 
            // TB_B
            // 
            this.TB_B.Location = new System.Drawing.Point(325, 219);
            this.TB_B.Name = "TB_B";
            this.TB_B.Size = new System.Drawing.Size(100, 20);
            this.TB_B.TabIndex = 12;
            this.TB_B.TextChanged += new System.EventHandler(this.TB_B_TextChanged);
            // 
            // TB_A
            // 
            this.TB_A.Location = new System.Drawing.Point(325, 186);
            this.TB_A.Name = "TB_A";
            this.TB_A.Size = new System.Drawing.Size(100, 20);
            this.TB_A.TabIndex = 11;
            this.TB_A.TextChanged += new System.EventHandler(this.TB_A_TextChanged);
            // 
            // TB_DX
            // 
            this.TB_DX.Location = new System.Drawing.Point(84, 254);
            this.TB_DX.Name = "TB_DX";
            this.TB_DX.Size = new System.Drawing.Size(100, 20);
            this.TB_DX.TabIndex = 10;
            this.TB_DX.TextChanged += new System.EventHandler(this.TB_DX_TextChanged);
            // 
            // TB_XK
            // 
            this.TB_XK.Location = new System.Drawing.Point(84, 219);
            this.TB_XK.Name = "TB_XK";
            this.TB_XK.Size = new System.Drawing.Size(100, 20);
            this.TB_XK.TabIndex = 9;
            this.TB_XK.TextChanged += new System.EventHandler(this.TB_XK_TextChanged);
            // 
            // TB_X0
            // 
            this.TB_X0.Location = new System.Drawing.Point(84, 188);
            this.TB_X0.Name = "TB_X0";
            this.TB_X0.Size = new System.Drawing.Size(100, 20);
            this.TB_X0.TabIndex = 8;
            this.TB_X0.TextChanged += new System.EventHandler(this.TB_X0_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMidleLeft);
            this.Controls.Add(this.labelTopLeft);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Laba";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button midlebutton;
        private System.Windows.Forms.Label labelTopLeft;
        private System.Windows.Forms.Label labelMidleLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_C;
        private System.Windows.Forms.TextBox TB_B;
        private System.Windows.Forms.TextBox TB_A;
        private System.Windows.Forms.TextBox TB_DX;
        private System.Windows.Forms.TextBox TB_XK;
        private System.Windows.Forms.TextBox TB_X0;
    }
}

