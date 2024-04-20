namespace moviedatabase
{
    partial class MoviesForm
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(566, 350);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 38);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.Location = new System.Drawing.Point(566, 309);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 38);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_insert.Location = new System.Drawing.Point(566, 263);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(82, 38);
            this.btn_insert.TabIndex = 19;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.White;
            this.btn_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.Location = new System.Drawing.Point(566, 219);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(82, 38);
            this.btn_list.TabIndex = 18;
            this.btn_list.Text = "List";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // txtBox_year
            // 
            this.txtBox_year.Location = new System.Drawing.Point(598, 156);
            this.txtBox_year.Name = "txtBox_year";
            this.txtBox_year.Size = new System.Drawing.Size(100, 22);
            this.txtBox_year.TabIndex = 17;
            // 
            // txtBox_title
            // 
            this.txtBox_title.Location = new System.Drawing.Point(598, 119);
            this.txtBox_title.Name = "txtBox_title";
            this.txtBox_title.Size = new System.Drawing.Size(100, 22);
            this.txtBox_title.TabIndex = 16;
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(598, 77);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(100, 22);
            this.txtBox_id.TabIndex = 15;
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_year.Location = new System.Drawing.Point(469, 156);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(120, 23);
            this.label_year.TabIndex = 14;
            this.label_year.Text = "Release Year";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_title.Location = new System.Drawing.Point(469, 119);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(108, 23);
            this.label_title.TabIndex = 13;
            this.label_title.Text = "Movie Title";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.Location = new System.Drawing.Point(469, 77);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(89, 23);
            this.label_id.TabIndex = 12;
            this.label_id.Text = "Movie ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(372, 333);
            this.dataGridView1.TabIndex = 11;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 438);
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
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
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
    }
}