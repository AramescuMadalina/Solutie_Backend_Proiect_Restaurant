namespace Solutie_Frontend_Proiect_Restaurant_N
{
    partial class MenuItem
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
            _ingredientNameLabel = new Label();
            _ingredientPriceLabel = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4841F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5159F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(_ingredientNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(_ingredientPriceLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(763, 74);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _ingredientNameLabel
            // 
            _ingredientNameLabel.AutoSize = true;
            _ingredientNameLabel.Dock = DockStyle.Fill;
            _ingredientNameLabel.Font = new Font("Segoe UI", 11F);
            _ingredientNameLabel.Location = new Point(3, 0);
            _ingredientNameLabel.Name = "_ingredientNameLabel";
            _ingredientNameLabel.Size = new Size(337, 74);
            _ingredientNameLabel.TabIndex = 0;
            _ingredientNameLabel.Text = "<ingredient_name>";
            // 
            // _ingredientPriceLabel
            // 
            _ingredientPriceLabel.AutoSize = true;
            _ingredientPriceLabel.Dock = DockStyle.Fill;
            _ingredientPriceLabel.Font = new Font("Segoe UI", 11F);
            _ingredientPriceLabel.Location = new Point(346, 0);
            _ingredientPriceLabel.Name = "_ingredientPriceLabel";
            _ingredientPriceLabel.Size = new Size(209, 74);
            _ingredientPriceLabel.TabIndex = 1;
            _ingredientPriceLabel.Text = "<ingredient_price>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(705, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 74);
            label2.TabIndex = 2;
            label2.Text = "+";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(561, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 68);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MenuItem";
            Size = new Size(763, 74);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label _ingredientNameLabel;
        private Label _ingredientPriceLabel;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
