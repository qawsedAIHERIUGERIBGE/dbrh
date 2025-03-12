
namespace турагенство_бдд
{
    partial class Form6
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
            this.названиетураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видтранспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияжильянаночьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видпитанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценатуравсуткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.турыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new турагенство_бдд.DataSet1();
            this.турыTableAdapter = new турагенство_бдд.DataSet1TableAdapters.турыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиетураDataGridViewTextBoxColumn,
            this.видтранспортаDataGridViewTextBoxColumn,
            this.категорияжильянаночьDataGridViewTextBoxColumn,
            this.видпитанияDataGridViewTextBoxColumn,
            this.ценатуравсуткиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.турыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // названиетураDataGridViewTextBoxColumn
            // 
            this.названиетураDataGridViewTextBoxColumn.DataPropertyName = "названиетура";
            this.названиетураDataGridViewTextBoxColumn.HeaderText = "названиетура";
            this.названиетураDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиетураDataGridViewTextBoxColumn.Name = "названиетураDataGridViewTextBoxColumn";
            this.названиетураDataGridViewTextBoxColumn.Width = 125;
            // 
            // видтранспортаDataGridViewTextBoxColumn
            // 
            this.видтранспортаDataGridViewTextBoxColumn.DataPropertyName = "видтранспорта";
            this.видтранспортаDataGridViewTextBoxColumn.HeaderText = "видтранспорта";
            this.видтранспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.видтранспортаDataGridViewTextBoxColumn.Name = "видтранспортаDataGridViewTextBoxColumn";
            this.видтранспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // категорияжильянаночьDataGridViewTextBoxColumn
            // 
            this.категорияжильянаночьDataGridViewTextBoxColumn.DataPropertyName = "категорияжильянаночь";
            this.категорияжильянаночьDataGridViewTextBoxColumn.HeaderText = "категорияжильянаночь";
            this.категорияжильянаночьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.категорияжильянаночьDataGridViewTextBoxColumn.Name = "категорияжильянаночьDataGridViewTextBoxColumn";
            this.категорияжильянаночьDataGridViewTextBoxColumn.Width = 125;
            // 
            // видпитанияDataGridViewTextBoxColumn
            // 
            this.видпитанияDataGridViewTextBoxColumn.DataPropertyName = "видпитания";
            this.видпитанияDataGridViewTextBoxColumn.HeaderText = "видпитания";
            this.видпитанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.видпитанияDataGridViewTextBoxColumn.Name = "видпитанияDataGridViewTextBoxColumn";
            this.видпитанияDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценатуравсуткиDataGridViewTextBoxColumn
            // 
            this.ценатуравсуткиDataGridViewTextBoxColumn.DataPropertyName = "ценатуравсутки";
            this.ценатуравсуткиDataGridViewTextBoxColumn.HeaderText = "ценатуравсутки";
            this.ценатуравсуткиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценатуравсуткиDataGridViewTextBoxColumn.Name = "ценатуравсуткиDataGridViewTextBoxColumn";
            this.ценатуравсуткиDataGridViewTextBoxColumn.Width = 125;
            // 
            // турыBindingSource
            // 
            this.турыBindingSource.DataMember = "туры";
            this.турыBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // турыTableAdapter
            // 
            this.турыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(377, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button2.Location = new System.Drawing.Point(608, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button3.Location = new System.Drawing.Point(687, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "туры";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button4.Location = new System.Drawing.Point(187, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "обновить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button5.Location = new System.Drawing.Point(12, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "изменить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "поиск";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 8;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "туры";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource турыBindingSource;
        private DataSet1TableAdapters.турыTableAdapter турыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиетураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видтранспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияжильянаночьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видпитанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценатуравсуткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}