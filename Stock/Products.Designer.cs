namespace Stock
{
    partial class Products
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.productcodeLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.productCodeValue = new System.Windows.Forms.TextBox();
            this.productNameValue = new System.Windows.Forms.TextBox();
            this.statusValue = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(560, 69);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(685, 69);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productcodeLabel
            // 
            this.productcodeLabel.AutoSize = true;
            this.productcodeLabel.Location = new System.Drawing.Point(37, 33);
            this.productcodeLabel.Name = "productcodeLabel";
            this.productcodeLabel.Size = new System.Drawing.Size(94, 17);
            this.productcodeLabel.TabIndex = 2;
            this.productcodeLabel.Text = "Product Code";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(197, 33);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(98, 17);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Product Name";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(388, 33);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status";
            // 
            // productCodeValue
            // 
            this.productCodeValue.Location = new System.Drawing.Point(40, 68);
            this.productCodeValue.Name = "productCodeValue";
            this.productCodeValue.Size = new System.Drawing.Size(100, 22);
            this.productCodeValue.TabIndex = 5;
            // 
            // productNameValue
            // 
            this.productNameValue.Location = new System.Drawing.Point(200, 68);
            this.productNameValue.Name = "productNameValue";
            this.productNameValue.Size = new System.Drawing.Size(100, 22);
            this.productNameValue.TabIndex = 6;
            // 
            // statusValue
            // 
            this.statusValue.FormattingEnabled = true;
            this.statusValue.Items.AddRange(new object[] {
            "Active",
            "Deactivate"});
            this.statusValue.Location = new System.Drawing.Point(382, 68);
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(121, 24);
            this.statusValue.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(40, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(720, 308);
            this.listBox1.TabIndex = 8;
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.productGridView.Location = new System.Drawing.Point(40, 135);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(720, 308);
            this.productGridView.TabIndex = 9;
            this.productGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productGridView_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 597);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusValue);
            this.Controls.Add(this.productNameValue);
            this.Controls.Add(this.productCodeValue);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productcodeLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label productcodeLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox productCodeValue;
        private System.Windows.Forms.TextBox productNameValue;
        private System.Windows.Forms.ComboBox statusValue;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}