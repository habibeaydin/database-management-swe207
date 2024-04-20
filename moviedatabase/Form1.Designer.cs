namespace moviedatabase
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.txtBox_year = new System.Windows.Forms.TextBox();
            this.txtBox_title = new System.Windows.Forms.TextBox();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.label_year = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(595, 385);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 38);
            this.btn_update.TabIndex = 32;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.Location = new System.Drawing.Point(595, 344);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 38);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_insert.Location = new System.Drawing.Point(595, 298);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(82, 38);
            this.btn_insert.TabIndex = 30;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.White;
            this.btn_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.Location = new System.Drawing.Point(595, 254);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(82, 38);
            this.btn_list.TabIndex = 29;
            this.btn_list.Text = "Search";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // txtBox_year
            // 
            this.txtBox_year.Location = new System.Drawing.Point(644, 187);
            this.txtBox_year.Name = "txtBox_year";
            this.txtBox_year.Size = new System.Drawing.Size(133, 22);
            this.txtBox_year.TabIndex = 28;
            // 
            // txtBox_title
            // 
            this.txtBox_title.Location = new System.Drawing.Point(644, 150);
            this.txtBox_title.Name = "txtBox_title";
            this.txtBox_title.Size = new System.Drawing.Size(133, 22);
            this.txtBox_title.TabIndex = 27;
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(644, 108);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(133, 22);
            this.txtBox_id.TabIndex = 26;
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.BackColor = System.Drawing.Color.White;
            this.label_year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_year.Location = new System.Drawing.Point(497, 189);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(120, 23);
            this.label_year.TabIndex = 25;
            this.label_year.Text = "Release Year";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.White;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_title.Location = new System.Drawing.Point(497, 152);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(108, 23);
            this.label_title.TabIndex = 24;
            this.label_title.Text = "Movie Title";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.White;
            this.label_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.Location = new System.Drawing.Point(497, 110);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(89, 23);
            this.label_id.TabIndex = 23;
            this.label_id.Text = "Movie ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 381);
            this.dataGridView1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "\"Movies\"",
            "\"Actors\"",
            "\"Genres\"",
            "\"Directors\"",
            "\"Studios\"",
            "\"Reviewer\"",
            "\"Ratings\"",
            "\"MovieActor\"",
            "\"MovieDirector\"",
            "\"MovieGenre\"",
            "\"MovieStudio\""});
            this.comboBox1.Location = new System.Drawing.Point(644, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(498, 66);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(110, 23);
            this.lbl_name.TabIndex = 34;
            this.lbl_name.Text = "Table Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "MovieDB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(897, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.txtBox_year);
            this.Controls.Add(this.txtBox_title);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.dataGridView1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.TextBox txtBox_year;
        private System.Windows.Forms.TextBox txtBox_title;
        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
    }
}

