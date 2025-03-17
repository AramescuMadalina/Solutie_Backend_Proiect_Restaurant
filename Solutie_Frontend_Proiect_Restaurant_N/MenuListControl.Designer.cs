namespace Solutie_Frontend_Proiect_Restaurant_N
{
    partial class MenuListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            _ingredientListPriceLabel = new Label();
            RemoveItemButton = new Label();
            _ingredientListNameLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.5508881F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.4491119F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Controls.Add(_ingredientListPriceLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(RemoveItemButton, 3, 0);
            tableLayoutPanel1.Controls.Add(_ingredientListNameLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(678, 74);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _ingredientListPriceLabel
            // 
            _ingredientListPriceLabel.AutoSize = true;
            _ingredientListPriceLabel.Dock = DockStyle.Fill;
            _ingredientListPriceLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _ingredientListPriceLabel.Location = new Point(332, 0);
            _ingredientListPriceLabel.Name = "_ingredientListPriceLabel";
            _ingredientListPriceLabel.Size = new Size(200, 74);
            _ingredientListPriceLabel.TabIndex = 1;
            _ingredientListPriceLabel.Text = "<ingredientlist_price>";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.AutoSize = true;
            RemoveItemButton.Dock = DockStyle.Top;
            RemoveItemButton.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveItemButton.ForeColor = Color.DarkSlateGray;
            RemoveItemButton.Location = new Point(600, 0);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(75, 74);
            RemoveItemButton.TabIndex = 2;
            RemoveItemButton.Text = "-";
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // _ingredientListNameLabel
            // 
            _ingredientListNameLabel.AutoSize = true;
            _ingredientListNameLabel.Dock = DockStyle.Fill;
            _ingredientListNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _ingredientListNameLabel.Location = new Point(3, 0);
            _ingredientListNameLabel.Name = "_ingredientListNameLabel";
            _ingredientListNameLabel.Size = new Size(323, 74);
            _ingredientListNameLabel.TabIndex = 0;
            _ingredientListNameLabel.Text = "<ingredientlist_name>";
            // 
            // MenuListControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MenuListControl";
            Size = new Size(678, 74);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label _ingredientListNameLabel;
        private Label _ingredientListPriceLabel;
        private Label RemoveItemButton;
    }
}
