using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using GroupBox = System.Windows.Forms.GroupBox;

namespace ac
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // GroupBox'ların içindeki checkbox'ların CheckedChanged olayına tek bir olay işleyicisi ekleme.
            foreach (GroupBox groupBox in Controls.OfType<GroupBox>())
            {
                foreach (CheckBox checkBox in groupBox.Controls.OfType<CheckBox>())
                {
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }
            }
            total.Text = "0";


        }
        // CheckBox_CheckedChanged metodu seçilen checkbox'ların metnini label'lara atma.
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null && checkBox.Checked)
            {//işaretlenenlerin metnini virgülle ayırma.
                string selectedText = string.Join(", ", checkBox.Parent.Controls.OfType<CheckBox>()
                                                                                .Where(cb => cb.Checked)
                                                                                .Select(cb => cb.Text));



                // Hangi grup belirleme ve ilgili label'a metni yazma.
                if (checkBox.Parent == soguk)
                {
                    seçilensoguk.Text = selectedText;
                }

                else if (checkBox.Parent == sicak)
                {
                    seçilensicak.Text = selectedText;
                } 

                else if (checkBox.Parent == atıstırma)
                {
                    seçilenatistirma.Text = selectedText;
                }

                else if (checkBox.Parent == tatli)
                {
                    seçilentatli.Text = selectedText;
                }



            }
        }


        private void Onay_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // Form2'yi göster
            form2.Show();
            this.Hide();

        }


        private void sicak_Enter(object sender, EventArgs e)
        {
            // Seçilen checkbox'ların metnini bir stringde toplayalım.
            string secilikutusicak = string.Join(", ", Controls.OfType<CheckBox>()
                                                            .Where(cb => cb.Checked)
                                                            .Select(cb => cb.Text));

            // Bu metni label'a atayalım.
            seçilensicak.Text = secilikutusicak;
        }

        private void soguk_Enter(object sender, EventArgs e)
        {
            // Seçilen checkbox'ların metnini bir stringde toplayalım.
            string secilikutusoguk = string.Join(", ", Controls.OfType<CheckBox>()
                                                            .Where(cb => cb.Checked)
                                                            .Select(cb => cb.Text));

            // Bu metni label'a atayalım.
            seçilensoguk.Text =  secilikutusoguk;
        }

        private void atıstırma_Enter(object sender, EventArgs e)
        {
            // Seçilen checkbox'ların metnini bir stringde toplayalım.
            string secilikutuatistirma = string.Join(", ", Controls.OfType<CheckBox>()
                                                            .Where(cb => cb.Checked)
                                                            .Select(cb => cb.Text));

            // Bu metni label'a atayalım.
            seçilenatistirma.Text = secilikutuatistirma;
        }

        private void tatli_Enter(object sender, EventArgs e)
        {
            // Seçilen checkbox'ların metnini bir stringde toplayalım.
            string secilikututatli = string.Join(", ", Controls.OfType<CheckBox>()
                                                            .Where(cb => cb.Checked)
                                                            .Select(cb => cb.Text));

            // Bu metni label'a atayalım.
            seçilentatli.Text = secilikututatli;
        }

        private void seçilensoguk_Click(object sender, EventArgs e)
        {

        }

        private void seçilensicak_Click(object sender, EventArgs e)
        {

        }

        private void seçilentatli_Click(object sender, EventArgs e)
        {

        }

        private void seçilenatistirma_Click(object sender, EventArgs e)
        {

        }

       

        private void ıce_latte_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void macchiato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void refresha_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void ıce_mocha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frap_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Fiyat_latte_Click(object sender, EventArgs e)
        {

        }

        private void Fiyat_macchiato_Click(object sender, EventArgs e)
        {

        }

        private void fiyat_refresha_Click(object sender, EventArgs e)
        {

        }

        private void Fiyat_mocha_Click(object sender, EventArgs e)
        {

        }

        private void fiyat_americano_Click(object sender, EventArgs e)
        {

        }

        private void fiyat_frappuccino_Click(object sender, EventArgs e)
        {

        }

        private void sicaklatte_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void sicaklatte_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void sicak_macchiato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sicakmac_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void SicakÇikolata_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void s_çikolata_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void sicakmocha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sicakmocha_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void sicakamricano_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sicakamericano_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void cay_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void cay_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void tiramisu_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void ches_fiyat_Click(object sender, EventArgs e)
        {

        }

       

        private void brownie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void brownie_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void muffin_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void muffin_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void kek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kek_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lapa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lapa_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void wrap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wrap_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void simit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simit_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void baget_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void baget_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void kruvasan_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void kuruyemis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kuruyemis_fiyat_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int totalFiyat = 0;

            // CheckBox'ların fiyatlarına göre toplam fiyatı hesapla
            if (ıce_latte.Checked)
                totalFiyat += 130;
            if (macchiato.Checked)
                totalFiyat += 115;
            if (refresha.Checked)
                totalFiyat += 120;
            if (ıce_mocha.Checked)
                totalFiyat += 125;
            if (ıce_americano.Checked)
                totalFiyat += 110;
            if (frap.Checked)
                totalFiyat += 130;

            if (sicaklatte.Checked)
                totalFiyat += 120;
            if (sicakamricano.Checked)
                totalFiyat += 110;
            if (sicakmocha.Checked)
                totalFiyat += 120;
            if (sicak_macchiato.Checked)
                totalFiyat += 115;
            if (SicakÇikolata.Checked)
                totalFiyat += 110;
            if (cay.Checked)
                totalFiyat += 55;

            if (tiramisu.Checked)
                totalFiyat += 130;
            if (cheescake.Checked)
                totalFiyat += 120;
            if (brownie.Checked)
                totalFiyat += 130;
            if (muffin.Checked)
                totalFiyat += 90;
            if (checkBox12.Checked)
                totalFiyat += 70;
            if (kek.Checked)
                totalFiyat += 110;

            if (lapa.Checked)
                totalFiyat += 100;
            if (wrap.Checked)
                totalFiyat += 140;
            if (simit.Checked)
                totalFiyat += 80;
            if (baget.Checked)
                totalFiyat += 120;
            if (kruvasan.Checked)
                totalFiyat += 80;
            if (kuruyemis.Checked)
                totalFiyat += 70;



            total.Text = totalFiyat.ToString();

        }
    }
}
