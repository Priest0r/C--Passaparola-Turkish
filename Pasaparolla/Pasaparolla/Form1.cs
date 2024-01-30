using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasaparolla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonA.Visible = false;
            buttonB.Visible = false;
            buttonC.Visible = false;
            buttonD.Visible = false;
            buttonE.Visible = false;
            buttonF.Visible = false;
            buttonG.Visible = false;
            buttonH.Visible = false;
            buttonI.Visible = false;
            buttonİ.Visible = false;
            buttonJ.Visible = false;
            buttonK.Visible = false;
            buttonL.Visible = false;
            buttonM.Visible = false;
            buttonN.Visible = false;
            buttonO.Visible = false;
            buttonP.Visible = false;
            buttonR.Visible = false;
            buttonS.Visible = false;
            buttonT.Visible = false;
            buttonU.Visible = false;
            buttonV.Visible = false;
            buttonY.Visible = false;
            buttonZ.Visible = false;
            button25.Text = " ";
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        int soru2=0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                
                
                
               
                switch(soruno)
                {
                    //cevap 1
                    case 1:
                        if(textBox1.Text == "Atina")
                        {

                            
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
           
                        
                        else
                        {
                            
                            buttonA.BackColor= Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        
                        break;
                        //cevap 2
                    case 2:
                        if(textBox1.Text == "Benelüks")
                        {
                            buttonB.BackColor= Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 3
                    case 3:
                        if (textBox1.Text == "Cezayir")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 4
                    case 4:
                        if (textBox1.Text == "Danimarka")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                        //cevap 5
                    case 5:
                        if (textBox1.Text == "Ermenistan")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 6
                    case 6:
                        if (textBox1.Text == "Filipinler")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 7
                    case 7:
                        if (textBox1.Text == "Güney Amerika")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 8
                    case 8:
                        if (textBox1.Text == "Hindistan")
                        {
                            buttonH.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                    //cevap 9
                    case 9:
                        if (textBox1.Text == "Irak")
                        {
                            buttonI.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                    //cevap 10
                    case 10:
                        if (textBox1.Text == "İspanya")
                        {
                            buttonİ.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonİ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                    //cevap 11
                    case 11:
                        if (textBox1.Text == "Junta")
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 12
                    case 12:
                        if (textBox1.Text == "Kaiser")
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 13
                    case 13:
                        if (textBox1.Text == "Litvanya")
                        {
                            buttonL.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 14
                    case 14:
                        if (textBox1.Text == "Moskova")
                        {
                            buttonM.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 15
                    case 15:
                        if (textBox1.Text == "Normandiya" || textBox1.Text=="Normandiya Çıkarması")
                        {
                            buttonN.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                    //cevap 16
                    case 16:
                        if (textBox1.Text == "Osmanlı İmparatorluğu" || textBox1.Text=="Osmanlı" || textBox1.Text=="Osmanlı Devleti")
                        {
                            buttonO.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                    //cevap 17
                    case 17:
                        if (textBox1.Text == "Polonya")
                        {
                            buttonP.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;

                    //cevap 18
                    case 18:
                        if (textBox1.Text == "Romanya")
                        {
                            buttonR.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                    //cevap 19
                    case 19:
                        if (textBox1.Text == "Sakarya Meydan Muharebesi" || textBox1.Text=="Sakarya Savaşı" || textBox1.Text=="Sakarya Meydan Savaşı"|| textBox1.Text=="Sakarya")
                        {
                            buttonS.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                    //cevap 20
                    case 20:
                        if (textBox1.Text == "Trablusgarp Savaşı")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                            linkLabel1.Focus();
                        }
                        break;
                    //cevap 21
                    case 21:
                        if (textBox1.Text == "Ukrayna")
                        {
                            buttonU.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                        }
                        
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                        }
                        break;
                    //cevap 22
                    case 22:
                        if (textBox1.Text == "Vietnam Savaşı" || textBox1.Text=="Vietnam")
                        {
                            buttonV.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                        }
                        break;
                    //cevap 23
                    case 23:
                        if (textBox1.Text == "Yunanistan")
                        {
                            buttonY.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                        }
                        break;
                    //cevap 24
                    case 24:
                        if (textBox1.Text == "Zeplin")
                        {
                            buttonZ.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Visible = false;
                            linkLabel1.Visible = true;
                        }
                        break;
                    





                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text=soruno.ToString();
            
            if (soruno == 1) 
            {
                linkLabel1.Visible = false;
                richTextBox1.Text = "Yunanistan'ın Başkenti?";
                button25.Text = "A";
                buttonA.Visible = true;
                
                textBox1.Focus();
                
                buttonA.BackColor = Color.Yellow;

            }
            if(soruno==2)
            { richTextBox1.Text = "Belçika, Hollanda ve Lüksemburg'u kapsayan ülkeleri ifade etmek amacıyla kullanılan kelime?";
                button25.Text = "B";
                buttonB.BackColor = Color.Yellow;
                buttonB.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Kuzey Afrikada Bulunan Ülke?";
                buttonC.BackColor = Color.Yellow;
                button25.Text = "C";
                buttonC.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Bir İskandinav Ülkesi?";
                buttonD.BackColor = Color.Yellow;
                button25.Text = "D";
                buttonD.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Türkiye ile komşu olan kuzey kafkas ülkesi?";
                buttonE.BackColor = Color.Yellow;
                button25.Text = "E";
                buttonE.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "1899-1902 tarihleri arasında bağımsızlığını ilan etmek için Amerika ile savaşan ülke ? ";
                buttonF.BackColor = Color.Yellow;
                button25.Text = "F";
                buttonF.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Brezilya'nın bulunduğu kıta?  ";
                buttonG.BackColor = Color.Yellow;
                button25.Text = "G";
                buttonG.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "1858'den 1947'ye kadar Birleşik Krallık'ın kolonisi olan ülke?  ";
                buttonH.BackColor = Color.Yellow;
                button25.Text = "H";
                buttonH.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Bir Ortadoğu ülkesi?  ";
                buttonI.BackColor = Color.Yellow;
                button25.Text = "I";
                buttonI.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "17 Tem 1936 – 1 Nis 1939 tarihleri arasında iç savaş yaşayan ülke? ";
                buttonİ.BackColor = Color.Yellow;
                button25.Text = "İ";
                buttonİ.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri liderler komitesi tarafından yönetilen hükümete verilen isim?  ";
                buttonJ.BackColor = Color.Yellow;
                button25.Text = "J";
                buttonJ.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Almanyada İmparator anlamına gelen kelime? ";
                buttonK.BackColor = Color.Yellow;
                button25.Text = "K";
                buttonK.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "16 Şubat 1918'de Rusyadan bağımsız olan ülke? ";
                buttonL.BackColor = Color.Yellow;
                button25.Text = "L";
                buttonL.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Rusya'nın başkenti? ";
                buttonM.BackColor = Color.Yellow;
                button25.Text = "M";
                buttonM.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "İngiltere tarafından 1944'ün haziran-eylül aylarında yapılan hücüm harekatı?";
                buttonN.BackColor = Color.Yellow;
                button25.Text = "N";
                buttonN.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "1299 yılında kurulan eski Türkiye Devleti ";
                buttonO.BackColor = Color.Yellow;
                button25.Text = "O";
                buttonO.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Almanya'nın işgal etmesiyle 2.Dünya Savaşını başlatan ülke? ";
                buttonP.BackColor = Color.Yellow;
                button25.Text = "P";
                buttonP.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Ion Antonescu önderliğinde Mihver ittifakında savaşa giren ülke? ";
                buttonR.BackColor = Color.Yellow;
                button25.Text = "R";
                buttonR.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "23 Ağu 1921 – 13 Eyl 1921 yıllarında Mustafa Kemal Atatürk önderliğinde yapılan kurtuluş savaşının dönüm noktası olan savaş? ";
                buttonS.BackColor = Color.Yellow;
                button25.Text = "S";
                buttonS.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "1911-1912 Osmanlı-İtalyan Savaşı?";
                buttonT.BackColor = Color.Yellow;
                button25.Text = "T";
                buttonT.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "1991 yılında Sovyetlerin yıkılması ile bağımsız olan ülke ?";
                buttonU.BackColor = Color.Yellow;
                button25.Text = "U";
                buttonU.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "1 Kas 1955 – 30 Nis 1975 yılları arasında Amerika'nın bulunduğu savaş?";
                buttonV.BackColor = Color.Yellow;
                button25.Text = "V";
                buttonV.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "1829 yılında Edirne Antlaşmasını imzalayarak bağımsız olan ülke?";
                buttonY.BackColor = Color.Yellow;
                button25.Text = "Y";
                buttonY.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                textBox1.Focus();
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Almanlar tarafınan bugüne kadar yapılmış olan en büyük hava taşıtıdır.";
                buttonZ.BackColor = Color.Yellow;
                button25.Text = "Z";
                buttonZ.Visible = true;
                textBox1.Visible = true;
                linkLabel1.Text = "Bitir";
                textBox1.Clear();
                textBox1.Focus();


            }
            if (soruno == 25)
            {
                this.Text = "Sorular Bitti".ToString();
                MessageBox.Show("Tebrikler Doğru Sayın: " + dogru +" "+ "Yanlış Sayın: " + yanlis);
                linkLabel1.Text = "Çıkış";
            }
            if(soruno==26)
            {
                this.Close();
            }

        }
    }
}
