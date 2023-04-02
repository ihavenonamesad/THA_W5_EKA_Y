using System;
using System.Data;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace THA_W5_EKA_Y
{
    public partial class Form1 : Form
    {
        DataTable dtproduksimpan = new DataTable();
        DataTable dtprodukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        public string id = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Filt_btn_Click(object sender, EventArgs e)
        {
            Filt_comb.Enabled = true;
            Filt_comb.DisplayMember = "Nama Category";
        }

        private void All_btn_Click(object sender, EventArgs e)
        {
            Filt_comb.Enabled = false;
            Filt_comb.Text = "";
            displayitem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtproduksimpan.Columns.Add("ID Product");
            dtproduksimpan.Columns.Add("Nama Product");
            dtproduksimpan.Columns.Add("Harga");
            dtproduksimpan.Columns.Add("Stock");
            dtproduksimpan.Columns.Add("ID Category");
            dtproduksimpan.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dtproduksimpan.Rows.Add("T001", "T-Shirt Black", 70000, 20, "C2");
            dtproduksimpan.Rows.Add("T002", "T-Shirt CHAD", 75000, 16, "C2");
            dtproduksimpan.Rows.Add("R001", "Rok mini", 90000, 26, "C3");
            dtproduksimpan.Rows.Add("J002", "Jeans Biru", 82000, 5, "C4");
            dtproduksimpan.Rows.Add("C001", "Celana Pendek Coklat", 82000, 11, "C4");
            dtproduksimpan.Rows.Add("C002", "Cawat Blink-blink", 82000, 1, "C5");
            dtproduksimpan.Rows.Add("R002", "Rocca Shirt", 50000, 8, "C2");
            
            ProdDat_Grid.DataSource = dtprodukTampil;

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");
            Cat_data.DataSource = dtCategory;
            //DetCat_comb.DataSource = dtCategory;
            DetCat_comb.ValueMember = "ID Category";
            Filt_comb.ValueMember = "ID Category";
            DetCat_comb.DisplayMember = "Nama Category";

            dtprodukTampil.Columns.Add("ID Product");
            dtprodukTampil.Columns.Add("Nama Product");
            dtprodukTampil.Columns.Add("Harga");
            dtprodukTampil.Columns.Add("Stock");
            dtprodukTampil.Columns.Add("ID Category");
            //ProdDat_Grid.DataSource = dtprodukTampil;
            displayitem();
            ProdDat_Grid.ClearSelection();
            Cat_data.ClearSelection();
            displaycategory();
        }
        private void displayitem()
        {
            dtprodukTampil.Clear();
            for (int i = 0; i < dtproduksimpan.Rows.Count; i++)
            {
                dtprodukTampil.Rows.Add(dtproduksimpan.Rows[i][0].ToString(), dtproduksimpan.Rows[i][1].ToString(), 
                    dtproduksimpan.Rows[i][2].ToString(), dtproduksimpan.Rows[i][3].ToString(), dtproduksimpan.Rows[i][4].ToString());
            }
            ProdDat_Grid.DataSource = dtprodukTampil;
        }
        private void displaycategory()
        {
            DetCat_comb.Items.Clear();
            Filt_comb.Items.Clear();
            for (int i = 0; i< dtCategory.Rows.Count; i++)
            {
                DetCat_comb.Items.Add(dtCategory.Rows[i][1].ToString());
                Filt_comb.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }
        private void displayfilter()
        {
            ProdDat_Grid.DataSource = dtprodukTampil;
        }

        private string nametoid(string name)
        {
            string id = "";
            for(int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][1].ToString() == name)
                {
                   id = dtCategory.Rows[i][0].ToString();
                }
            }
            return id;
        }
        private string idtoname(string id)
        {
            string name = "";
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][0].ToString() == id)
                {
                    name = dtCategory.Rows[i][1].ToString();
                }
            }
            return name;
        }
       
        private void AddCat_btn_Click(object sender, EventArgs e)
        {
            int IDNumber = 1;
            string newcat = CatName_txt.Text;
            bool check = true;
            if (CatName_txt.Text == "")
            {
                MessageBox.Show("Masukkan nama dulu");
            }
            else
            {
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (newcat == dtCategory.Rows[i][1].ToString())
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    if (dtCategory.Rows.Count != 0)
                    {
                        string Previous_ID = dtCategory.Rows[dtCategory.Rows.Count - 1][0].ToString();
                        int IDlength = Previous_ID.Length - 1;
                        IDNumber = Convert.ToInt32(Previous_ID.Substring(1, IDlength)) + 1;
                    }
                    dtCategory.Rows.Add("C" + IDNumber, newcat);
                    Filt_comb.Items.Add(newcat);
                    DetCat_comb.Items.Add(newcat);
                }
                else
                {
                    MessageBox.Show("Sudah ada");
                }
                CatName_txt.Clear();
                displayitem();
            }
        }

        private void RemCat_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dtproduksimpan.Rows.Count; i++)
            {
                
                if (dtproduksimpan.Rows[i][4].ToString() == dtCategory.Rows[Cat_data.CurrentCell.RowIndex][0].ToString())
                {
                    dtproduksimpan.Rows.RemoveAt(i);
                    i--;
                }
            }
            Filt_comb.Items.RemoveAt(Cat_data.CurrentRow.Index);
            DetCat_comb.Items.RemoveAt(Cat_data.CurrentRow.Index);
            dtCategory.Rows.RemoveAt(Cat_data.CurrentCell.RowIndex);
            
            displayitem();
        }

        private void AddPro_btn_Click(object sender, EventArgs e)
        {
            string Namedet = DetNam_txt.Text;
            string Catdet = nametoid(DetCat_comb.Text);
            string price = DatPri_txt.Text;
            string stok = DetStock_txt.Text;
           
            if (DetNam_txt.Text == "" && DatPri_txt.Text == "" && DetStock_txt.Text == "")
            {
                MessageBox.Show("Please input the product");
            } else if (DetStock_txt.Text == "0" || DatPri_txt.Text == "0")
            {

            }
            else
            {
                string ID = Namedet.ToUpper().Substring(0, 1);
                string IDreal = ID;
                int counter = 1;
                for (int i = 0; i < dtproduksimpan.Rows.Count; i++)
                {
                    if (dtproduksimpan.Rows[i][1].ToString().ToUpper().Substring(0, 1) == ID)
                    {
                        counter++;
                    }
                }
                if (counter < 10)
                {
                    IDreal = IDreal + "0";
                }
                if (counter < 100)
                {
                    IDreal = IDreal + "0";
                }
                IDreal = IDreal + counter.ToString();
                dtproduksimpan.Rows.Add(IDreal, Namedet, price, stok, Catdet);
                displayitem();
                DetNam_txt.Clear();
                DetCat_comb.SelectedIndex = -1;
                DatPri_txt.Clear();
                DetStock_txt.Clear();
            }    
        }

        private void DetCat_comb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveProd_btn_Click(object sender, EventArgs e)
        {
            if (ProdDat_Grid.SelectedRows.Count > 0 && !ProdDat_Grid.SelectedRows[0].IsNewRow)
            {
                ProdDat_Grid.Rows.Remove(ProdDat_Grid.SelectedRows[0]);
            }
        }

        private void Filt_comb_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtprodukTampil.Clear();
            for (int i = 0; i < dtproduksimpan.Rows.Count; i++)
            {
          
                if (dtproduksimpan.Rows[i][4].ToString() ==  nametoid(Filt_comb.SelectedItem.ToString()) && dtproduksimpan.Rows.Count != 0)
                {
                    dtprodukTampil.Rows.Add(dtproduksimpan.Rows[i][0], dtproduksimpan.Rows[i][1], dtproduksimpan.Rows[i][2], 
                        dtproduksimpan.Rows[i][3], dtproduksimpan.Rows[i][4]);
                }
            }
            displayfilter();
        }

        private void EditPord_btn_Click(object sender, EventArgs e)
        {
            if (DetNam_txt.Text == "" && DatPri_txt.Text == "" && DetStock_txt.Text == "")
            {
                MessageBox.Show("Please click product to edit");
            }
            else
            {
                for (int i = 0; i < dtproduksimpan.Rows.Count; i++)
                {
                    if (dtproduksimpan.Rows[i][0].ToString() == id)
                    {
                        dtproduksimpan.Rows[i][1] = DetNam_txt.Text;
                        dtproduksimpan.Rows[i][2] = DatPri_txt.Text;
                        dtproduksimpan.Rows[i][3] = DetStock_txt.Text;
                        dtproduksimpan.Rows[i][4] = nametoid(DetCat_comb.Text);
                        displayitem();
                        nostock();
                    } 
                }
            }
        }
        private void nostock()
        {
            for (int i = 0; i < dtproduksimpan.Rows.Count; i++)
            {
                if (dtproduksimpan.Rows[i][3].ToString() == "0")
                {
                    dtproduksimpan.Rows.RemoveAt(i);
                }
            }
            displayitem();
        }

        private void click(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dtproduksimpan.Rows[ProdDat_Grid.CurrentCell.RowIndex][0].ToString();
            DetNam_txt.Text = dtproduksimpan.Rows[ProdDat_Grid.CurrentCell.RowIndex][1].ToString();
            DatPri_txt.Text = dtproduksimpan.Rows[ProdDat_Grid.CurrentCell.RowIndex][2].ToString();
            DetStock_txt.Text = dtproduksimpan.Rows[ProdDat_Grid.CurrentCell.RowIndex][3].ToString();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][0].ToString() == dtproduksimpan.Rows[ProdDat_Grid.CurrentCell.RowIndex][4].ToString())
                {
                    DetCat_comb.Text = dtCategory.Rows[i][1].ToString();
                }
            }
        }

        private void DatPri_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DetStock_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DetStock_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ProdDat_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
