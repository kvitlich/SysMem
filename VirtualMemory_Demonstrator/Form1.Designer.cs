namespace VirtualMemory_Demonstrator
{
    partial class Form1
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
            this.button_free = new System.Windows.Forms.Button();
            this.button_alloc = new System.Windows.Forms.Button();
            this.alloc_value = new System.Windows.Forms.TextBox();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.RamCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RamApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.comboBoxFill = new System.Windows.Forms.ComboBox();
            this.statGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button_free
            // 
            this.button_free.Location = new System.Drawing.Point(441, 414);
            this.button_free.Name = "button_free";
            this.button_free.Size = new System.Drawing.Size(371, 34);
            this.button_free.TabIndex = 0;
            this.button_free.Text = "Освободить";
            this.button_free.UseVisualStyleBackColor = true;
            this.button_free.Click += new System.EventHandler(this.Free);
            // 
            // button_alloc
            // 
            this.button_alloc.Location = new System.Drawing.Point(14, 413);
            this.button_alloc.Name = "button_alloc";
            this.button_alloc.Size = new System.Drawing.Size(371, 35);
            this.button_alloc.TabIndex = 1;
            this.button_alloc.Text = "Выделить";
            this.button_alloc.UseVisualStyleBackColor = true;
            this.button_alloc.Click += new System.EventHandler(this.Alloc);
            // 
            // alloc_value
            // 
            this.alloc_value.Location = new System.Drawing.Point(14, 376);
            this.alloc_value.Name = "alloc_value";
            this.alloc_value.Size = new System.Drawing.Size(371, 22);
            this.alloc_value.TabIndex = 2;
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RamCom,
            this.RamApp});
            this.mainGrid.Location = new System.Drawing.Point(14, 12);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowHeadersWidth = 51;
            this.mainGrid.RowTemplate.Height = 24;
            this.mainGrid.Size = new System.Drawing.Size(584, 274);
            this.mainGrid.TabIndex = 3;
            this.mainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGrid_CellContentClick);
            // 
            // RamCom
            // 
            this.RamCom.HeaderText = "Память (компьютер)";
            this.RamCom.MinimumWidth = 6;
            this.RamCom.Name = "RamCom";
            this.RamCom.Width = 200;
            // 
            // RamApp
            // 
            this.RamApp.HeaderText = "Память (приложение)";
            this.RamApp.MinimumWidth = 6;
            this.RamApp.Name = "RamApp";
            this.RamApp.Width = 200;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(394, 294);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(204, 37);
            this.button_refresh.TabIndex = 4;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.Refresh);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(12, 301);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(204, 24);
            this.comboBoxMode.TabIndex = 5;
            this.comboBoxMode.Text = "Единица резервирования";
            // 
            // comboBoxFill
            // 
            this.comboBoxFill.FormattingEnabled = true;
            this.comboBoxFill.Location = new System.Drawing.Point(222, 301);
            this.comboBoxFill.Name = "comboBoxFill";
            this.comboBoxFill.Size = new System.Drawing.Size(163, 24);
            this.comboBoxFill.TabIndex = 6;
            this.comboBoxFill.Text = "Заполнять";
            this.comboBoxFill.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // statGrid
            // 
            this.statGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.statGrid.Location = new System.Drawing.Point(604, 12);
            this.statGrid.Name = "statGrid";
            this.statGrid.RowHeadersWidth = 51;
            this.statGrid.RowTemplate.Height = 24;
            this.statGrid.Size = new System.Drawing.Size(208, 386);
            this.statGrid.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "C";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "A";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 460);
            this.Controls.Add(this.statGrid);
            this.Controls.Add(this.comboBoxFill);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.alloc_value);
            this.Controls.Add(this.button_alloc);
            this.Controls.Add(this.button_free);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_free;
        private System.Windows.Forms.Button button_alloc;
        private System.Windows.Forms.TextBox alloc_value;
        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RamCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RamApp;
        private System.Windows.Forms.ComboBox comboBoxFill;
        private System.Windows.Forms.DataGridView statGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

