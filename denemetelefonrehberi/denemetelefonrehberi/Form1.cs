using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemetelefonrehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=telefon_rehberi; user ID=postgres; password=dry_7596");

        private void numaraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonNumarasi telefonNumarasi = new TelefonNumarasi();
            telefonNumarasi.ShowDialog();
            telefonNumaralariniAl();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            telefonNumaralariniAl();
        }

        void telefonNumaralariniAl()
        {
            
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter("select adsoyad,email,telefonno from numaralar ", baglanti);
            NpgsqlCommand command = new NpgsqlCommand("select * from numaralar ", baglanti);
            try
            {
                baglanti.Open();
                NpgsqlDataReader dataReader = command.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3));
                }   
            }
            catch(Exception)
            {
                MessageBox.Show("Numaralar alınamadı..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
           
            
            
            
        }

        private void seçilenNumarayiSilToolStripMenuItem_Click(object sender, EventArgs e)

        {

            int sonuc = -1;
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }



            DialogResult dialogResult = MessageBox.Show("Numara silinecek onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }
            //id alıyorum.
            object value = dataGridView1.SelectedRows[0].Cells[0].Value;
            int id = (int)value;
            NpgsqlCommand command2 = new NpgsqlCommand("delete from numaralar where Id=@id", baglanti);
            command2.Parameters.AddWithValue("@id", id);


            try
            {
                baglanti.Open();
                sonuc = command2.ExecuteNonQuery();
                MessageBox.Show($"Telefon numarası silin{(sonuc > 0 ? "di" : "emedi")}", sonuc > 0 ? "Bilgilendirme" : "Hata", MessageBoxButtons.OK,
                    sonuc > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);



            }
            catch(Exception exception)
            {

            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
            if (sonuc > 0)
            {
                telefonNumaralariniAl();
            }
        }

        private void seçilenNumarayiGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sonuc = -1;
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }



            //id alıyorum.
            object value = dataGridView1.SelectedRows[0].Cells[0].Value;
            int id = (int)value;

            TelefonNumarasi telefonNumarasi = new TelefonNumarasi(id);
            telefonNumarasi.ShowDialog();
            telefonNumaralariniAl();

             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Select adsoyad,telefonno,email from numaralar where adsoyad like '%" + textAra.Text + "%'", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(npgsqlCommand);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            telefonNumaralariniAl();
        }
    }
}
