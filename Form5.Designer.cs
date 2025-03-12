
namespace турагенство_бдд
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пансионатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.виджильяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаотъездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиедетейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиемедстраховкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествочеловекDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.путевкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new турагенство_бдд.DataSet1();
            this.путевкиTableAdapter = new турагенство_бдд.DataSet1TableAdapters.путевкиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.путевкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.клиентDataGridViewTextBoxColumn,
            this.пансионатDataGridViewTextBoxColumn,
            this.виджильяDataGridViewTextBoxColumn,
            this.датазаездаDataGridViewTextBoxColumn,
            this.датаотъездаDataGridViewTextBoxColumn,
            this.наличиедетейDataGridViewTextBoxColumn,
            this.наличиемедстраховкиDataGridViewTextBoxColumn,
            this.количествочеловекDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.путевкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "клиент";
            this.клиентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            this.клиентDataGridViewTextBoxColumn.Width = 125;
            // 
            // пансионатDataGridViewTextBoxColumn
            // 
            this.пансионатDataGridViewTextBoxColumn.DataPropertyName = "пансионат";
            this.пансионатDataGridViewTextBoxColumn.HeaderText = "пансионат";
            this.пансионатDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пансионатDataGridViewTextBoxColumn.Name = "пансионатDataGridViewTextBoxColumn";
            this.пансионатDataGridViewTextBoxColumn.Width = 125;
            // 
            // виджильяDataGridViewTextBoxColumn
            // 
            this.виджильяDataGridViewTextBoxColumn.DataPropertyName = "виджилья";
            this.виджильяDataGridViewTextBoxColumn.HeaderText = "виджилья";
            this.виджильяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.виджильяDataGridViewTextBoxColumn.Name = "виджильяDataGridViewTextBoxColumn";
            this.виджильяDataGridViewTextBoxColumn.Width = 125;
            // 
            // датазаездаDataGridViewTextBoxColumn
            // 
            this.датазаездаDataGridViewTextBoxColumn.DataPropertyName = "датазаезда";
            this.датазаездаDataGridViewTextBoxColumn.HeaderText = "датазаезда";
            this.датазаездаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датазаездаDataGridViewTextBoxColumn.Name = "датазаездаDataGridViewTextBoxColumn";
            this.датазаездаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаотъездаDataGridViewTextBoxColumn
            // 
            this.датаотъездаDataGridViewTextBoxColumn.DataPropertyName = "датаотъезда";
            this.датаотъездаDataGridViewTextBoxColumn.HeaderText = "датаотъезда";
            this.датаотъездаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаотъездаDataGridViewTextBoxColumn.Name = "датаотъездаDataGridViewTextBoxColumn";
            this.датаотъездаDataGridViewTextBoxColumn.Width = 125;
            // 
            // наличиедетейDataGridViewTextBoxColumn
            // 
            this.наличиедетейDataGridViewTextBoxColumn.DataPropertyName = "наличиедетей";
            this.наличиедетейDataGridViewTextBoxColumn.HeaderText = "наличиедетей";
            this.наличиедетейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наличиедетейDataGridViewTextBoxColumn.Name = "наличиедетейDataGridViewTextBoxColumn";
            this.наличиедетейDataGridViewTextBoxColumn.Width = 125;
            // 
            // наличиемедстраховкиDataGridViewTextBoxColumn
            // 
            this.наличиемедстраховкиDataGridViewTextBoxColumn.DataPropertyName = "наличиемедстраховки";
            this.наличиемедстраховкиDataGridViewTextBoxColumn.HeaderText = "наличиемедстраховки";
            this.наличиемедстраховкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наличиемедстраховкиDataGridViewTextBoxColumn.Name = "наличиемедстраховкиDataGridViewTextBoxColumn";
            this.наличиемедстраховкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествочеловекDataGridViewTextBoxColumn
            // 
            this.количествочеловекDataGridViewTextBoxColumn.DataPropertyName = "количествочеловек";
            this.количествочеловекDataGridViewTextBoxColumn.HeaderText = "количествочеловек";
            this.количествочеловекDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествочеловекDataGridViewTextBoxColumn.Name = "количествочеловекDataGridViewTextBoxColumn";
            this.количествочеловекDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "сумма";
            this.суммаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.Width = 125;
            // 
            // путевкиBindingSource
            // 
            this.путевкиBindingSource.DataMember = "путевки";
            this.путевкиBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // путевкиTableAdapter
            // 
            this.путевкиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(416, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button2.Location = new System.Drawing.Point(628, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button3.Location = new System.Drawing.Point(671, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "путевки";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button4.Location = new System.Drawing.Point(220, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "обновить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button5.Location = new System.Drawing.Point(12, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "изменить";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "поиск";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "путевки";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.путевкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource путевкиBindingSource;
        private DataSet1TableAdapters.путевкиTableAdapter путевкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пансионатDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn виджильяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаотъездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиедетейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиемедстраховкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествочеловекDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}