namespace PWBucket
{
    partial class Buttons
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
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.passwoerterDataSet = new PWBucket.PasswoerterDataSet();
            this.passwoerterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwoerterDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwoerterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwoerterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwoerterDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(167, 88);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(117, 49);
            this.btnCreateDB.TabIndex = 0;
            this.btnCreateDB.Text = "Datenbank erstellen";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(681, 93);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(196, 44);
            this.btnShowTable.TabIndex = 1;
            this.btnShowTable.Text = "Tabelle zeigen";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.passwoerterDataSetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(466, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(665, 208);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // passwoerterDataSet
            // 
            this.passwoerterDataSet.DataSetName = "PasswoerterDataSet";
            this.passwoerterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwoerterDataSetBindingSource
            // 
            this.passwoerterDataSetBindingSource.DataSource = this.passwoerterDataSet;
            this.passwoerterDataSetBindingSource.Position = 0;
            // 
            // passwoerterDataSetBindingSource1
            // 
            this.passwoerterDataSetBindingSource1.DataSource = this.passwoerterDataSet;
            this.passwoerterDataSetBindingSource1.Position = 0;
            // 
            // Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowTable);
            this.Controls.Add(this.btnCreateDB);
            this.Name = "Buttons";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwoerterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwoerterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwoerterDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource passwoerterDataSetBindingSource1;
        private PasswoerterDataSet passwoerterDataSet;
        private System.Windows.Forms.BindingSource passwoerterDataSetBindingSource;
    }
}