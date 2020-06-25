namespace RandomValues
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.difMinMax = new System.Windows.Forms.Label();
            this.tableView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 9);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(46, 13);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "Размер";
            this.sizeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(64, 9);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(100, 20);
            this.sizeBox.TabIndex = 1;
            this.sizeBox.TextChanged += new System.EventHandler(this.sizeBox_TextChanged);
            this.sizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Разница между мин и макс равна:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // difMinMax
            // 
            this.difMinMax.AutoSize = true;
            this.difMinMax.Location = new System.Drawing.Point(159, 60);
            this.difMinMax.Name = "difMinMax";
            this.difMinMax.Size = new System.Drawing.Size(0, 13);
            this.difMinMax.TabIndex = 4;
            this.difMinMax.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(12, 97);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(306, 211);
            this.tableView.TabIndex = 5;
            this.tableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 320);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.difMinMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.sizeLabel);
            this.Name = "Form1";
            this.Text = "Таблица с разницей";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label difMinMax;
        private System.Windows.Forms.DataGridView tableView;
    }
}

