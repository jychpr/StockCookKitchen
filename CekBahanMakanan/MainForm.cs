using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekBahanMakanan
{
    public partial class MainForm : Form //class MainForm yang merupakan turunan dari Form yang digunakan sebagai UI
    {
        public MainForm() //membuat constructor MainForm
        {
            InitializeComponent(); //digunakan untuk memuat komponen yang ada
        }

        private void btnCari_Click(object sender, EventArgs e) //method yang diterapkan pada tombol btnCari ketika dijalankan
        {
            try
            {
                Random r = new Random(); //membuat fungsi random dalam mencari resep masakan
                int rId = r.Next(0, 30); //fungsi random akan mengambil id dari query urutan data ke 0 hingga 30

                string ingredients = Recipe.GetTitle(tbCariResep.Text,rId) + "\n\n"; //menggunakan method GetTitle untuk mencari judul resep
                List<string> ingredientsList = new List<string>();
                ingredientsList = Recipe.GetIngredients(tbCariResep.Text,rId); //menggunakan method GetIngredients 
                for (int i = 0; i < ingredientsList.Count(); i++) //fungsi for untuk loop membuat list
                {
                    ingredients += ingredientsList[i] + "\n"; //bahan selanjutnya yang ada akan dimasukkan ke variable ingredients
                }
                rtbHasilPencarian.Text = ingredients; //menaruh hasil yang ada di variable ingredients ke rich text box
            }
            catch //jika fungsi try tidak berhasil dijalakan
            {
                MessageBox.Show("Tidak ditemukan " + tbCariResep.Text + " dalam daftar resep!"); //menampilkan messagebox
            }
        }

        private void BtnSuggest_Click(object sender, EventArgs e) //method yang diterapkan pada tombol btnSuggest ketika dijalankan
        {
            try
            {
                Random r = new Random(); //membuat fungsi random dalam mencari resep rekomendasi masakan
                int rId = r.Next(0, 30); //fungsi random akan mengambil id dari query urutan data ke 0 hingga 30

                string nama = "";
                string ingredients = "";
                List<string> ingredientsList = new List<string>();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows) //fungsi foreach untuk setiap data yang terpilih di datagridview
                {
                    nama = nama + "," + row.Cells[0].Value.ToString(); //dan nama bahan yang terpilih tadi akan dimasukkan ke dalam variable nama dan diconvert menjadi tipe string
                }
                ingredientsList = Recipe.GetIngredients(nama, rId); //variable nama akan digunakan di sini, method GetIngredients, untuk mencari rekomendasi resep dimana nama bahan di database juga tersedia di ingredients resep yang ada
                for (int i = 0; i < ingredientsList.Count(); i++) //fungsi for untuk loop membuat list
                {
                    ingredients += ingredientsList[i] + "\n"; //bahan selanjutnya yang ada akan dimasukkan ke variable ingredients
                }
                rtbIsiSuggest.Text = ingredients; //menaruh hasil yang ada di variable ingredients ke rich text box
                tbJudulSuggest.Text = Recipe.GetTitle(nama, rId); //mencari judul resep yang bersesuaian dengan id yang dicari dan bahan resep yang ada
            }
            catch //jika fungsi try tidak berhasil dijalakan
            {
                string nama = ""; //variable ini akan digunakan dalam messagebox
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    nama = nama + "," + row.Cells[0].Value.ToString();
                }
                MessageBox.Show("Tidak ditemukan " + nama + " dalam daftar resep!"); //menampilkan messagebox
            }
        }

        private void HowToToolStripMenuItem_Click(object sender, EventArgs e) //membuat menustrip yang menjelaskan fitur dan penggunaan aplikasi
        {
            MessageBox.Show("Fitur Aplikasi \n 1. Mencari resep dari nama resep (Masukkan Keyword pada Search Bar di bagian Resep \n " +
                "2. Membuat database stock bahan makanan (Masukkan bahan makanan pada tabel sesuai format tabel) \n " +
                "3. Mencari rekomendasi resep dari stock bahan makanan yang ada (Highlight bahan dari database yang ingin dicari " +
                "kemudian klik button Suggest Me! dan secara otomatis akan dicari resep dengan referensi data stock bahan makanan yang terhighlight) \n \n" + "Catatan:" +
                " Disarankan menggunakan keyword dalam bahasa inggris ketika akan mencari resep dan menginput bahan juga, karena layanan penyedia resep food2fork" +
                " menggunakan basis bahasa inggris \n" + "Contoh: 'telur' ditulis 'egg'", "Penjelasan Fitur");
        }
    }
}
