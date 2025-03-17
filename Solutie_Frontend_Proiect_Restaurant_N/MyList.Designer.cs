namespace Solutie_Frontend_Proiect_Restaurant_N
{
    partial class MyList
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button3 = new Button();
            OrderNowButton = new Button();
            BackButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            totalDeliveryTotal = new Label();
            TotalPriceDeliveryLabel = new Label();
            deliveryPriceLabel = new Label();
            TotalLabel = new Label();
            totalPriceLabel = new Label();
            PriceDeliveryLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 88);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(83, 20);
            label1.Name = "label1";
            label1.Size = new Size(141, 48);
            label1.TabIndex = 0;
            label1.Text = "My List";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(763, 220);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(OrderNowButton);
            panel2.Controls.Add(BackButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 431);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 65);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(763, 47);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(567, 10);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Order Now";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OrderNowButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(57, 10);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 0;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BackButton_Click;
            // 
            // OrderNowButton
            // 
            OrderNowButton.Location = new Point(546, 19);
            OrderNowButton.Name = "OrderNowButton";
            OrderNowButton.Size = new Size(112, 34);
            OrderNowButton.TabIndex = 1;
            OrderNowButton.Text = "Order Now";
            OrderNowButton.UseVisualStyleBackColor = true;
            OrderNowButton.Click += OrderNowButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(112, 19);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.27916F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.72084F));
            tableLayoutPanel1.Controls.Add(totalDeliveryTotal, 1, 2);
            tableLayoutPanel1.Controls.Add(TotalPriceDeliveryLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(deliveryPriceLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(TotalLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(totalPriceLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(PriceDeliveryLabel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 308);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(763, 123);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_2;
            // 
            // totalDeliveryTotal
            // 
            totalDeliveryTotal.AutoSize = true;
            totalDeliveryTotal.Dock = DockStyle.Fill;
            totalDeliveryTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalDeliveryTotal.ForeColor = Color.DarkSlateGray;
            totalDeliveryTotal.Location = new Point(379, 80);
            totalDeliveryTotal.Name = "totalDeliveryTotal";
            totalDeliveryTotal.Size = new Size(381, 43);
            totalDeliveryTotal.TabIndex = 5;
            totalDeliveryTotal.Text = "<total_delivery_Price>";
            totalDeliveryTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // TotalPriceDeliveryLabel
            // 
            TotalPriceDeliveryLabel.AutoSize = true;
            TotalPriceDeliveryLabel.BackColor = Color.DarkSlateGray;
            TotalPriceDeliveryLabel.Dock = DockStyle.Fill;
            TotalPriceDeliveryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TotalPriceDeliveryLabel.ForeColor = Color.White;
            TotalPriceDeliveryLabel.Location = new Point(3, 80);
            TotalPriceDeliveryLabel.Name = "TotalPriceDeliveryLabel";
            TotalPriceDeliveryLabel.Size = new Size(370, 43);
            TotalPriceDeliveryLabel.TabIndex = 4;
            TotalPriceDeliveryLabel.Text = "TOTAL";
            TotalPriceDeliveryLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // deliveryPriceLabel
            // 
            deliveryPriceLabel.AutoSize = true;
            deliveryPriceLabel.Dock = DockStyle.Fill;
            deliveryPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            deliveryPriceLabel.ForeColor = Color.DarkSlateGray;
            deliveryPriceLabel.Location = new Point(379, 36);
            deliveryPriceLabel.Name = "deliveryPriceLabel";
            deliveryPriceLabel.Size = new Size(381, 44);
            deliveryPriceLabel.TabIndex = 3;
            deliveryPriceLabel.Text = "<delivery_price>";
            deliveryPriceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.BackColor = Color.DarkSlateGray;
            TotalLabel.Dock = DockStyle.Fill;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TotalLabel.ForeColor = Color.White;
            TotalLabel.Location = new Point(3, 0);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(370, 36);
            TotalLabel.TabIndex = 0;
            TotalLabel.Text = "Total items ";
            TotalLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Dock = DockStyle.Fill;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalPriceLabel.ForeColor = Color.DarkSlateGray;
            totalPriceLabel.Location = new Point(379, 0);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(381, 36);
            totalPriceLabel.TabIndex = 1;
            totalPriceLabel.Text = "<total_Price>";
            totalPriceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PriceDeliveryLabel
            // 
            PriceDeliveryLabel.AutoSize = true;
            PriceDeliveryLabel.BackColor = Color.DarkSlateGray;
            PriceDeliveryLabel.Dock = DockStyle.Fill;
            PriceDeliveryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PriceDeliveryLabel.ForeColor = Color.White;
            PriceDeliveryLabel.Location = new Point(3, 36);
            PriceDeliveryLabel.Name = "PriceDeliveryLabel";
            PriceDeliveryLabel.Size = new Size(370, 44);
            PriceDeliveryLabel.TabIndex = 2;
            PriceDeliveryLabel.Text = "Delivery price";
            PriceDeliveryLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MyList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 496);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MyList";
            Text = "Form1";
            Load += MyList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button OrderNowButton;
        private Button BackButton;
        private Panel panel3;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label TotalLabel;
        private Label totalPriceLabel;
        private Label PriceDeliveryLabel;
        private Label deliveryPriceLabel;
        private Label totalDeliveryTotal;
        private Label TotalPriceDeliveryLabel;
    }
}