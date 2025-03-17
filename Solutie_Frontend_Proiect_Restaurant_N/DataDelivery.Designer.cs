namespace Solutie_Frontend_Proiect_Restaurant_N
{
    partial class DataDelivery
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
            panel2 = new Panel();
            DetailsAddresGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            StreetLabel = new Label();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            CashDeliveryRadioButton = new RadioButton();
            OnlineCardRadioButton = new RadioButton();
            StreetTextBox = new TextBox();
            OrderButton = new Button();
            CancelButton = new Button();
            DetailsNameGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            PhoneLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            DetailsAddresGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            DetailsNameGroupBox.SuspendLayout();
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
            panel1.Size = new Size(690, 133);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(353, 133);
            label1.TabIndex = 0;
            label1.Text = "Add Data Delivery";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(DetailsAddresGroupBox);
            panel2.Controls.Add(OrderButton);
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(DetailsNameGroupBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 490);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // DetailsAddresGroupBox
            // 
            DetailsAddresGroupBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DetailsAddresGroupBox.Controls.Add(tableLayoutPanel2);
            DetailsAddresGroupBox.Font = new Font("Segoe UI", 12F);
            DetailsAddresGroupBox.Location = new Point(25, 222);
            DetailsAddresGroupBox.Name = "DetailsAddresGroupBox";
            DetailsAddresGroupBox.Size = new Size(635, 204);
            DetailsAddresGroupBox.TabIndex = 1;
            DetailsAddresGroupBox.TabStop = false;
            DetailsAddresGroupBox.Text = "Details Address";
            DetailsAddresGroupBox.Enter += DetailsAddresGroupBox_Enter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 352F));
            tableLayoutPanel2.Controls.Add(StreetLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(CityLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(CityTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(CashDeliveryRadioButton, 0, 2);
            tableLayoutPanel2.Controls.Add(OnlineCardRadioButton, 1, 2);
            tableLayoutPanel2.Controls.Add(StreetTextBox, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(610, 165);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // StreetLabel
            // 
            StreetLabel.Dock = DockStyle.Fill;
            StreetLabel.Location = new Point(3, 0);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(252, 70);
            StreetLabel.TabIndex = 0;
            StreetLabel.Text = "Street";
            // 
            // CityLabel
            // 
            CityLabel.Dock = DockStyle.Fill;
            CityLabel.Location = new Point(3, 70);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(252, 45);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.Dock = DockStyle.Fill;
            CityTextBox.Location = new Point(261, 73);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(346, 39);
            CityTextBox.TabIndex = 5;
            // 
            // CashDeliveryRadioButton
            // 
            CashDeliveryRadioButton.AutoSize = true;
            CashDeliveryRadioButton.Location = new Point(3, 118);
            CashDeliveryRadioButton.Name = "CashDeliveryRadioButton";
            CashDeliveryRadioButton.Size = new Size(212, 36);
            CashDeliveryRadioButton.TabIndex = 9;
            CashDeliveryRadioButton.TabStop = true;
            CashDeliveryRadioButton.Text = "cash on delivery";
            CashDeliveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // OnlineCardRadioButton
            // 
            OnlineCardRadioButton.AutoSize = true;
            OnlineCardRadioButton.Location = new Point(261, 118);
            OnlineCardRadioButton.Name = "OnlineCardRadioButton";
            OnlineCardRadioButton.Size = new Size(311, 36);
            OnlineCardRadioButton.TabIndex = 10;
            OnlineCardRadioButton.TabStop = true;
            OnlineCardRadioButton.Text = "card payment on delivery";
            OnlineCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(261, 15);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(346, 39);
            StreetTextBox.TabIndex = 2;
            // 
            // OrderButton
            // 
            OrderButton.FlatStyle = FlatStyle.Flat;
            OrderButton.Location = new Point(478, 444);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(112, 34);
            OrderButton.TabIndex = 2;
            OrderButton.Text = "Order";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Location = new Point(113, 444);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // DetailsNameGroupBox
            // 
            DetailsNameGroupBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DetailsNameGroupBox.Controls.Add(tableLayoutPanel1);
            DetailsNameGroupBox.Font = new Font("Segoe UI", 12F);
            DetailsNameGroupBox.Location = new Point(25, 24);
            DetailsNameGroupBox.Name = "DetailsNameGroupBox";
            DetailsNameGroupBox.Size = new Size(635, 192);
            DetailsNameGroupBox.TabIndex = 0;
            DetailsNameGroupBox.TabStop = false;
            DetailsNameGroupBox.Text = "Details Name";
            DetailsNameGroupBox.Enter += groupBox1_Enter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 372F));
            tableLayoutPanel1.Controls.Add(PhoneLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(NameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(PhoneTextBox, 1, 1);
            tableLayoutPanel1.Location = new Point(6, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(629, 145);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PhoneLabel
            // 
            PhoneLabel.Dock = DockStyle.Fill;
            PhoneLabel.Location = new Point(3, 71);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(251, 74);
            PhoneLabel.TabIndex = 1;
            PhoneLabel.Text = "Phone";
            // 
            // NameLabel
            // 
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Location = new Point(3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(251, 71);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(260, 16);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(366, 39);
            NameTextBox.TabIndex = 2;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PhoneTextBox.Location = new Point(260, 88);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(366, 39);
            PhoneTextBox.TabIndex = 3;
            // 
            // DataDelivery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(690, 623);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DataDelivery";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            DetailsAddresGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            DetailsNameGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button OrderButton;
        private Button CancelButton;
        private GroupBox DetailsNameGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label NameLabel;
        private Label PhoneLabel;
        private TextBox NameTextBox;
        private TextBox PhoneTextBox;
        private GroupBox DetailsAddresGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label StreetLabel;
        private TextBox StreetTextBox;
        private RadioButton CashDeliveryRadioButton;
        private RadioButton OnlineCardRadioButton;
    }
}