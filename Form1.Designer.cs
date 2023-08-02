namespace BlukuploadWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TbSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            btnUploadDB = new Button();
            dateTimePicker1 = new DateTimePicker();
            openFileDialog1 = new OpenFileDialog();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TbSearch
            // 
            TbSearch.BackColor = SystemColors.ControlLightLight;
            TbSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TbSearch.Location = new Point(12, 12);
            TbSearch.Multiline = true;
            TbSearch.Name = "TbSearch";
            TbSearch.Size = new Size(477, 38);
            TbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(504, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 38);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 288);
            dataGridView1.TabIndex = 2;
            // 
            // btnUploadDB
            // 
            btnUploadDB.FlatStyle = FlatStyle.Flat;
            btnUploadDB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUploadDB.Location = new Point(347, 388);
            btnUploadDB.Name = "btnUploadDB";
            btnUploadDB.Size = new Size(107, 33);
            btnUploadDB.TabIndex = 3;
            btnUploadDB.Text = "UploadDB";
            btnUploadDB.UseVisualStyleBackColor = true;
            btnUploadDB.Click += btnUploadDB_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(637, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(138, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(694, 396);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(94, 17);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total Rows : 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnUploadDB);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(TbSearch);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnUploadDB;
        private DateTimePicker dateTimePicker1;
        private OpenFileDialog openFileDialog1;
        private Label lblTotal;
    }
}