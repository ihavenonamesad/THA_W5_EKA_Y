namespace THA_W5_EKA_Y
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Prod_lbl = new System.Windows.Forms.Label();
            this.All_btn = new System.Windows.Forms.Button();
            this.Filt_btn = new System.Windows.Forms.Button();
            this.Filt_comb = new System.Windows.Forms.ComboBox();
            this.Cate_lbl = new System.Windows.Forms.Label();
            this.ProdDat_Grid = new System.Windows.Forms.DataGridView();
            this.Cat_data = new System.Windows.Forms.DataGridView();
            this.Deta_lbl = new System.Windows.Forms.Label();
            this.Nama_lbl = new System.Windows.Forms.Label();
            this.Harga_lbl = new System.Windows.Forms.Label();
            this.CateDet_lbl = new System.Windows.Forms.Label();
            this.Stock_lbl = new System.Windows.Forms.Label();
            this.DetNam_txt = new System.Windows.Forms.TextBox();
            this.DetStock_txt = new System.Windows.Forms.TextBox();
            this.DatPri_txt = new System.Windows.Forms.TextBox();
            this.DetCat_comb = new System.Windows.Forms.ComboBox();
            this.NamCat_lbl = new System.Windows.Forms.Label();
            this.CatName_txt = new System.Windows.Forms.TextBox();
            this.AddPro_btn = new System.Windows.Forms.Button();
            this.EditPord_btn = new System.Windows.Forms.Button();
            this.RemoveProd_btn = new System.Windows.Forms.Button();
            this.RemCat_btn = new System.Windows.Forms.Button();
            this.AddCat_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDat_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prod_lbl
            // 
            this.Prod_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_lbl.ForeColor = System.Drawing.Color.Black;
            this.Prod_lbl.Location = new System.Drawing.Point(12, 16);
            this.Prod_lbl.Name = "Prod_lbl";
            this.Prod_lbl.Size = new System.Drawing.Size(110, 36);
            this.Prod_lbl.TabIndex = 0;
            this.Prod_lbl.Text = "Product";
            this.Prod_lbl.UseCompatibleTextRendering = true;
            this.Prod_lbl.Visible = false;
            // 
            // All_btn
            // 
            this.All_btn.Location = new System.Drawing.Point(186, 23);
            this.All_btn.Name = "All_btn";
            this.All_btn.Size = new System.Drawing.Size(54, 23);
            this.All_btn.TabIndex = 1;
            this.All_btn.Text = "All";
            this.All_btn.UseVisualStyleBackColor = true;
            this.All_btn.Click += new System.EventHandler(this.All_btn_Click);
            // 
            // Filt_btn
            // 
            this.Filt_btn.Location = new System.Drawing.Point(246, 23);
            this.Filt_btn.Name = "Filt_btn";
            this.Filt_btn.Size = new System.Drawing.Size(54, 23);
            this.Filt_btn.TabIndex = 2;
            this.Filt_btn.Text = "Filter";
            this.Filt_btn.UseVisualStyleBackColor = true;
            this.Filt_btn.Click += new System.EventHandler(this.Filt_btn_Click);
            // 
            // Filt_comb
            // 
            this.Filt_comb.AllowDrop = true;
            this.Filt_comb.CausesValidation = false;
            this.Filt_comb.Enabled = false;
            this.Filt_comb.Location = new System.Drawing.Point(306, 25);
            this.Filt_comb.Name = "Filt_comb";
            this.Filt_comb.Size = new System.Drawing.Size(121, 21);
            this.Filt_comb.TabIndex = 3;
            this.Filt_comb.SelectedIndexChanged += new System.EventHandler(this.Filt_comb_SelectedIndexChanged);
            // 
            // Cate_lbl
            // 
            this.Cate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cate_lbl.ForeColor = System.Drawing.Color.Black;
            this.Cate_lbl.Location = new System.Drawing.Point(489, 16);
            this.Cate_lbl.Name = "Cate_lbl";
            this.Cate_lbl.Size = new System.Drawing.Size(140, 36);
            this.Cate_lbl.TabIndex = 4;
            this.Cate_lbl.Text = "Category";
            this.Cate_lbl.UseCompatibleTextRendering = true;
            this.Cate_lbl.Visible = false;
            // 
            // ProdDat_Grid
            // 
            this.ProdDat_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDat_Grid.Location = new System.Drawing.Point(30, 55);
            this.ProdDat_Grid.Name = "ProdDat_Grid";
            this.ProdDat_Grid.RowHeadersVisible = false;
            this.ProdDat_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDat_Grid.Size = new System.Drawing.Size(440, 200);
            this.ProdDat_Grid.TabIndex = 5;
            this.ProdDat_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDat_Grid_CellContentClick);
            this.ProdDat_Grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.click);
            // 
            // Cat_data
            // 
            this.Cat_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cat_data.Location = new System.Drawing.Point(505, 55);
            this.Cat_data.Name = "Cat_data";
            this.Cat_data.RowHeadersVisible = false;
            this.Cat_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cat_data.Size = new System.Drawing.Size(260, 160);
            this.Cat_data.TabIndex = 6;
            // 
            // Deta_lbl
            // 
            this.Deta_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deta_lbl.ForeColor = System.Drawing.Color.Black;
            this.Deta_lbl.Location = new System.Drawing.Point(30, 289);
            this.Deta_lbl.Name = "Deta_lbl";
            this.Deta_lbl.Size = new System.Drawing.Size(110, 36);
            this.Deta_lbl.TabIndex = 7;
            this.Deta_lbl.Text = "Details";
            this.Deta_lbl.UseCompatibleTextRendering = true;
            this.Deta_lbl.Visible = false;
            // 
            // Nama_lbl
            // 
            this.Nama_lbl.AutoSize = true;
            this.Nama_lbl.Location = new System.Drawing.Point(27, 337);
            this.Nama_lbl.Name = "Nama_lbl";
            this.Nama_lbl.Size = new System.Drawing.Size(38, 13);
            this.Nama_lbl.TabIndex = 8;
            this.Nama_lbl.Text = "Nama:";
            // 
            // Harga_lbl
            // 
            this.Harga_lbl.AutoSize = true;
            this.Harga_lbl.Location = new System.Drawing.Point(27, 392);
            this.Harga_lbl.Name = "Harga_lbl";
            this.Harga_lbl.Size = new System.Drawing.Size(39, 13);
            this.Harga_lbl.TabIndex = 9;
            this.Harga_lbl.Text = "Harga:";
            // 
            // CateDet_lbl
            // 
            this.CateDet_lbl.AutoSize = true;
            this.CateDet_lbl.Location = new System.Drawing.Point(27, 364);
            this.CateDet_lbl.Name = "CateDet_lbl";
            this.CateDet_lbl.Size = new System.Drawing.Size(52, 13);
            this.CateDet_lbl.TabIndex = 10;
            this.CateDet_lbl.Text = "Category:";
            // 
            // Stock_lbl
            // 
            this.Stock_lbl.AutoSize = true;
            this.Stock_lbl.Location = new System.Drawing.Point(27, 417);
            this.Stock_lbl.Name = "Stock_lbl";
            this.Stock_lbl.Size = new System.Drawing.Size(38, 13);
            this.Stock_lbl.TabIndex = 11;
            this.Stock_lbl.Text = "Stock:";
            // 
            // DetNam_txt
            // 
            this.DetNam_txt.Location = new System.Drawing.Point(91, 337);
            this.DetNam_txt.Name = "DetNam_txt";
            this.DetNam_txt.Size = new System.Drawing.Size(182, 20);
            this.DetNam_txt.TabIndex = 12;
            // 
            // DetStock_txt
            // 
            this.DetStock_txt.Location = new System.Drawing.Point(91, 417);
            this.DetStock_txt.Name = "DetStock_txt";
            this.DetStock_txt.Size = new System.Drawing.Size(87, 20);
            this.DetStock_txt.TabIndex = 13;
            this.DetStock_txt.TextChanged += new System.EventHandler(this.DetStock_txt_TextChanged);
            this.DetStock_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DetStock_txt_KeyPress);
            // 
            // DatPri_txt
            // 
            this.DatPri_txt.Location = new System.Drawing.Point(91, 391);
            this.DatPri_txt.Name = "DatPri_txt";
            this.DatPri_txt.Size = new System.Drawing.Size(87, 20);
            this.DatPri_txt.TabIndex = 14;
            this.DatPri_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DatPri_txt_KeyPress);
            // 
            // DetCat_comb
            // 
            this.DetCat_comb.FormattingEnabled = true;
            this.DetCat_comb.Location = new System.Drawing.Point(91, 364);
            this.DetCat_comb.Name = "DetCat_comb";
            this.DetCat_comb.Size = new System.Drawing.Size(121, 21);
            this.DetCat_comb.TabIndex = 15;
            this.DetCat_comb.SelectedIndexChanged += new System.EventHandler(this.DetCat_comb_SelectedIndexChanged);
            // 
            // NamCat_lbl
            // 
            this.NamCat_lbl.AutoSize = true;
            this.NamCat_lbl.Location = new System.Drawing.Point(502, 234);
            this.NamCat_lbl.Name = "NamCat_lbl";
            this.NamCat_lbl.Size = new System.Drawing.Size(38, 13);
            this.NamCat_lbl.TabIndex = 16;
            this.NamCat_lbl.Text = "Nama:";
            // 
            // CatName_txt
            // 
            this.CatName_txt.Location = new System.Drawing.Point(546, 231);
            this.CatName_txt.Name = "CatName_txt";
            this.CatName_txt.Size = new System.Drawing.Size(149, 20);
            this.CatName_txt.TabIndex = 17;
            // 
            // AddPro_btn
            // 
            this.AddPro_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.AddPro_btn.Location = new System.Drawing.Point(227, 392);
            this.AddPro_btn.Name = "AddPro_btn";
            this.AddPro_btn.Size = new System.Drawing.Size(61, 46);
            this.AddPro_btn.TabIndex = 18;
            this.AddPro_btn.Text = "Add Product";
            this.AddPro_btn.UseVisualStyleBackColor = false;
            this.AddPro_btn.Click += new System.EventHandler(this.AddPro_btn_Click);
            // 
            // EditPord_btn
            // 
            this.EditPord_btn.BackColor = System.Drawing.Color.Yellow;
            this.EditPord_btn.Location = new System.Drawing.Point(294, 391);
            this.EditPord_btn.Name = "EditPord_btn";
            this.EditPord_btn.Size = new System.Drawing.Size(61, 46);
            this.EditPord_btn.TabIndex = 19;
            this.EditPord_btn.Text = "Edit Product";
            this.EditPord_btn.UseVisualStyleBackColor = false;
            this.EditPord_btn.Click += new System.EventHandler(this.EditPord_btn_Click);
            // 
            // RemoveProd_btn
            // 
            this.RemoveProd_btn.BackColor = System.Drawing.Color.Red;
            this.RemoveProd_btn.Location = new System.Drawing.Point(361, 391);
            this.RemoveProd_btn.Name = "RemoveProd_btn";
            this.RemoveProd_btn.Size = new System.Drawing.Size(61, 46);
            this.RemoveProd_btn.TabIndex = 20;
            this.RemoveProd_btn.Text = "Remove Product";
            this.RemoveProd_btn.UseVisualStyleBackColor = false;
            this.RemoveProd_btn.Click += new System.EventHandler(this.RemoveProd_btn_Click);
            // 
            // RemCat_btn
            // 
            this.RemCat_btn.BackColor = System.Drawing.Color.Red;
            this.RemCat_btn.Location = new System.Drawing.Point(607, 257);
            this.RemCat_btn.Name = "RemCat_btn";
            this.RemCat_btn.Size = new System.Drawing.Size(61, 46);
            this.RemCat_btn.TabIndex = 23;
            this.RemCat_btn.Text = "Remove Category";
            this.RemCat_btn.UseVisualStyleBackColor = false;
            this.RemCat_btn.Click += new System.EventHandler(this.RemCat_btn_Click);
            // 
            // AddCat_btn
            // 
            this.AddCat_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.AddCat_btn.Location = new System.Drawing.Point(540, 257);
            this.AddCat_btn.Name = "AddCat_btn";
            this.AddCat_btn.Size = new System.Drawing.Size(61, 46);
            this.AddCat_btn.TabIndex = 21;
            this.AddCat_btn.Text = "Add Category";
            this.AddCat_btn.UseVisualStyleBackColor = false;
            this.AddCat_btn.Click += new System.EventHandler(this.AddCat_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemCat_btn);
            this.Controls.Add(this.AddCat_btn);
            this.Controls.Add(this.RemoveProd_btn);
            this.Controls.Add(this.EditPord_btn);
            this.Controls.Add(this.AddPro_btn);
            this.Controls.Add(this.CatName_txt);
            this.Controls.Add(this.NamCat_lbl);
            this.Controls.Add(this.DetCat_comb);
            this.Controls.Add(this.DatPri_txt);
            this.Controls.Add(this.DetStock_txt);
            this.Controls.Add(this.DetNam_txt);
            this.Controls.Add(this.Stock_lbl);
            this.Controls.Add(this.CateDet_lbl);
            this.Controls.Add(this.Harga_lbl);
            this.Controls.Add(this.Nama_lbl);
            this.Controls.Add(this.Deta_lbl);
            this.Controls.Add(this.Cat_data);
            this.Controls.Add(this.ProdDat_Grid);
            this.Controls.Add(this.Cate_lbl);
            this.Controls.Add(this.Filt_comb);
            this.Controls.Add(this.Filt_btn);
            this.Controls.Add(this.All_btn);
            this.Controls.Add(this.Prod_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDat_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Prod_lbl;
        private System.Windows.Forms.Button All_btn;
        private System.Windows.Forms.Button Filt_btn;
        private System.Windows.Forms.ComboBox Filt_comb;
        public System.Windows.Forms.Label Cate_lbl;
        private System.Windows.Forms.DataGridView ProdDat_Grid;
        private System.Windows.Forms.DataGridView Cat_data;
        public System.Windows.Forms.Label Deta_lbl;
        private System.Windows.Forms.Label Nama_lbl;
        private System.Windows.Forms.Label Harga_lbl;
        private System.Windows.Forms.Label CateDet_lbl;
        private System.Windows.Forms.Label Stock_lbl;
        private System.Windows.Forms.TextBox DetNam_txt;
        private System.Windows.Forms.TextBox DetStock_txt;
        private System.Windows.Forms.TextBox DatPri_txt;
        private System.Windows.Forms.ComboBox DetCat_comb;
        private System.Windows.Forms.Label NamCat_lbl;
        private System.Windows.Forms.TextBox CatName_txt;
        private System.Windows.Forms.Button AddPro_btn;
        private System.Windows.Forms.Button EditPord_btn;
        private System.Windows.Forms.Button RemoveProd_btn;
        private System.Windows.Forms.Button RemCat_btn;
        private System.Windows.Forms.Button AddCat_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

