namespace OOP12thProject
{
    partial class Form6
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
            label1 = new Label();
            label2 = new Label();
            NamEma = new TextBox();
            PassEmp = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 106);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Name or Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 169);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // NamEma
            // 
            NamEma.Location = new Point(442, 98);
            NamEma.Name = "NamEma";
            NamEma.Size = new Size(207, 23);
            NamEma.TabIndex = 2;
            NamEma.TextChanged += NamEma_TextChanged;
            // 
            // PassEmp
            // 
            PassEmp.Location = new Point(442, 169);
            PassEmp.Name = "PassEmp";
            PassEmp.Size = new Size(207, 23);
            PassEmp.TabIndex = 3;
            PassEmp.TextChanged += PassEmp_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(659, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e3ebc6f5_bfad_4514_a8e9_62abccc963a0;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(PassEmp);
            Controls.Add(NamEma);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NamEma;
        private TextBox PassEmp;
        private Button button1;
    }
}