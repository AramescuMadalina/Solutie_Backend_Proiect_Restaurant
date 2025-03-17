namespace Solutie_Frontend_Proiect_Restaurant_N
{
    partial class MainMenu
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ViewMyListButton = new Button();
            CloseButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 88);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(90, 24);
            label1.Name = "label1";
            label1.Size = new Size(309, 48);
            label1.TabIndex = 0;
            label1.Text = "Restaurant Menu";
            // 
            // panel2
            // 
            panel2.Controls.Add(ViewMyListButton);
            panel2.Controls.Add(CloseButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 393);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 57);
            panel2.TabIndex = 1;
            // 
            // ViewMyListButton
            // 
            ViewMyListButton.Location = new Point(589, 11);
            ViewMyListButton.Name = "ViewMyListButton";
            ViewMyListButton.Size = new Size(112, 34);
            ViewMyListButton.TabIndex = 1;
            ViewMyListButton.Text = "My List";
            ViewMyListButton.UseVisualStyleBackColor = true;
            ViewMyListButton.Click += button2_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(116, 11);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(112, 34);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 305);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainMenu";
            Text = "Form1";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button ViewMyListButton;
        private Button CloseButton;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
