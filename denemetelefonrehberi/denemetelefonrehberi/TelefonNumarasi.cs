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
    public partial class TelefonNumarasi : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=telefon_rehberi; user ID=postgres; password=dry_7596");
        private int Id;
        private bool updateIcin;
        public TelefonNumarasi()
        {   
            
            InitializeComponent();
        }
        public TelefonNumarasi(int id)
        {
            
            InitializeComponent();
            Id = id;
            updateIcin = true;
            NpgsqlCommand command1 = new NpgsqlCommand("select * from numaralar where Id =@id", baglanti);
            command1.Parameters.AddWithValue("@id", Id);

            try
            {
                baglanti.Open();
                NpgsqlDataReader npgsqlDataReader = command1.ExecuteReader();
                while (npgsqlDataReader.Read())
                {
                    textBoxAdSoyad.Text = npgsqlDataReader.GetString(1);
                    textBoxMail.Text = npgsqlDataReader.GetString(2);
                    maskedTextBoxTelefon.Text = npgsqlDataReader.GetString(3);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Telefon numarası alınamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
        }

       

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
         
            baglanti.Open();
            NpgsqlCommand komut1;

            if (updateIcin)
            {
                komut1 = new NpgsqlCommand("update  numaralar set adsoyad=@p1, email=@p2, telefonno=@p3 where Id=@id", baglanti);

                komut1.Parameters.AddWithValue("@id", Id);
                MessageBox.Show("Güncelleme yapıldı");
            }
            else
            {
                try
                {
                    komut1 = new NpgsqlCommand("insert into numaralar (adsoyad, email,telefonno) values(@p1, @p2, @p3)", baglanti);
                    komut1.Parameters.AddWithValue("@p1", textBoxAdSoyad.Text);
                    komut1.Parameters.AddWithValue("@p2", textBoxMail.Text);
                    komut1.Parameters.AddWithValue("@p3", maskedTextBoxTelefon.Text);
                    komut1.ExecuteNonQuery();
                    MessageBox.Show("kayıt yapıldı");
                    this.Close();
                }
                catch(Exception exeption)
                {
                    MessageBox.Show("Telefon numarası iki kez kaydedilemez....", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    if (baglanti.State != ConnectionState.Closed)
                    {
                        baglanti.Close();
                    }
                }
                 
            }
            
            
           
            
        }
    }
}
