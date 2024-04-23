namespace OOP12thProject
{
    partial class Form5
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
            panel1 = new Panel();
            Account = new Button();
            button2 = new Button();
            AvailableTrips = new Button();
            menu = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(Account);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(AvailableTrips);
            panel1.Controls.Add(menu);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 447);
            panel1.TabIndex = 0;
            // 
            // Account
            // 
            Account.BackColor = SystemColors.ActiveCaptionText;
            Account.ForeColor = SystemColors.ButtonHighlight;
            Account.Location = new Point(-2, 193);
            Account.Name = "Account";
            Account.Size = new Size(124, 23);
            Account.TabIndex = 1;
            Account.Text = "Account";
            Account.UseVisualStyleBackColor = false;
            Account.Click += Account_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 128);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 1;
            button2.Text = "Search Trips";
            button2.UseVisualStyleBackColor = false;
            // 
            // AvailableTrips
            // 
            AvailableTrips.BackColor = SystemColors.ActiveCaptionText;
            AvailableTrips.ForeColor = SystemColors.ButtonHighlight;
            AvailableTrips.Location = new Point(-2, 68);
            AvailableTrips.Name = "AvailableTrips";
            AvailableTrips.Size = new Size(124, 23);
            AvailableTrips.TabIndex = 1;
            AvailableTrips.Text = "Available Trips";
            AvailableTrips.UseVisualStyleBackColor = false;
            AvailableTrips.Click += AvailableTrips_Click;
            // 
            // menu
            // 
            menu.AutoSize = true;
            menu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menu.ForeColor = SystemColors.ActiveCaptionText;
            menu.Location = new Point(11, 22);
            menu.Name = "menu";
            menu.Size = new Size(42, 15);
            menu.TabIndex = 1;
            menu.Text = "Menu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 24);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 78);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click_1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_airplane_airplane_cloud_business_cloud_layer_image_7926251;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label menu;
        private Button Account;
        private Button button2;
        private Button AvailableTrips;
        private Label label1;
        private Label label2;
    }
}