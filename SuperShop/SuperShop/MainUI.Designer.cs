namespace SuperShop
{
    partial class MainUI
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
            this.shopButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.shopDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(40, 32);
            this.shopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(273, 98);
            this.shopButton.TabIndex = 0;
            this.shopButton.Text = "Add Shop";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // itemButton
            // 
            this.itemButton.Location = new System.Drawing.Point(357, 32);
            this.itemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(263, 98);
            this.itemButton.TabIndex = 1;
            this.itemButton.Text = "Add Item";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // shopDataGridView
            // 
            this.shopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopDataGridView.Location = new System.Drawing.Point(40, 158);
            this.shopDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shopDataGridView.Name = "shopDataGridView";
            this.shopDataGridView.Size = new System.Drawing.Size(578, 269);
            this.shopDataGridView.TabIndex = 2;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 440);
            this.Controls.Add(this.shopDataGridView);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.shopButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainUI";
            this.Text = "MainUI";
            ((System.ComponentModel.ISupportInitialize)(this.shopDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.DataGridView shopDataGridView;
    }
}