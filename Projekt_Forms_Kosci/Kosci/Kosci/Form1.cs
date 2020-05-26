using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Kosci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region deklaracje
        Random rnd = new Random();

        public int punkty = 0; // punktacja


        bool czy_start = false;
        bool wiecej = false;
        bool mniej = false;


        int[] sumaOczek = new int[999];
        int kosc1 = 0;
        int kosc2 = 0;
        int rzut = 1;
        int postawOczko = 0;

        #endregion

        #region przyciski
        private void b_start_Click(object sender, EventArgs e)
        {
            b_start.Text = "Rzuć";

            #region wlasciwosci
            b_wiecej.Visible = true;
            b_mniej.Visible = true;
            b_1.Visible = true;
            b_2.Visible = true;
            b_3.Visible = true;
            b_4.Visible = true;
            b_5.Visible = true;
            b_6.Visible = true;
            pic_1.Visible = true;
            pic_2.Visible = true;
            l_obstawienie.Visible = true;
            l_obstawienie2.Visible = true;
            l_obstawiles1.Visible = true;
            l_numerki.Visible = true;
            #endregion

            czy_start = true;

            if (czy_start == true)
            {
                rzucKoscia();
                if(wiecej == true)
                {
                    f_wiecej();
                }
                if(mniej == true)
                {
                    f_mniej();
                }
                if(postawOczko != 0)
                {
                    f_postawOczko();
                }
            }
            
        }

        #region wiecejMniej
        private void b_wiecej_Click(object sender, EventArgs e)
        {
            wiecej = true;
            b_mniej.Enabled = false;
            if(postawOczko != 0)
            {
                l_obstawienie2.Text = "i suma oczek będzie większa";
            }
            if(postawOczko == 0)
            {
                l_obstawienie.Text = "Suma oczek będzie większa";
            }

        }

        private void b_mniej_Click(object sender, EventArgs e)
        {
            mniej = true;
            b_wiecej.Enabled = false;
            if (postawOczko != 0)
            {
                l_obstawienie2.Text = "i suma oczek będzie mniejsza";
            }
            if (postawOczko == 0)
            {
                l_obstawienie.Text = "Suma oczek będzie mniejsza";
            }
        }
        #endregion

        #region numerki
        private void b_1_Click(object sender, EventArgs e)
        {
            postawOczko = 1;
            b_2.Enabled = false;
            b_3.Enabled = false;
            b_4.Enabled = false;
            b_5.Enabled = false;
            b_6.Enabled = false;

            if (wiecej == true || mniej == true)
            {
                l_obstawienie2.Text = "i numer 1";
            }
            else
            {
                l_obstawienie.Text = "Numer 1";
            }
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            postawOczko = 2;
            b_1.Enabled = false;
            b_3.Enabled = false;
            b_4.Enabled = false;
            b_5.Enabled = false;
            b_6.Enabled = false;
            if (wiecej == true || mniej == true)
            {
                l_obstawienie2.Text = "i numer 2";
            }
            else
            {
                l_obstawienie.Text = "Numer 2";
            }
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            postawOczko = 3;
            b_1.Enabled = false;
            b_2.Enabled = false;
            b_4.Enabled = false;
            b_5.Enabled = false;
            b_6.Enabled = false;
            if (wiecej == true || mniej == true)
            {
                l_obstawienie2.Text = "i numer 3";
            }
            else
            {
                l_obstawienie.Text = "Numer 3";
            }

        }

        private void b_4_Click(object sender, EventArgs e)
        {
            postawOczko = 4;
            b_1.Enabled = false;
            b_2.Enabled = false;
            b_3.Enabled = false;
            b_5.Enabled = false;
            b_6.Enabled = false;
            if (wiecej == true || mniej == true)
            {
                l_obstawienie2.Text = "i numer 4";
            }
            else
            {
                l_obstawienie.Text = "Numer 4";
            }

        }

        private void b_5_Click(object sender, EventArgs e)
        {
            postawOczko = 5;
            b_1.Enabled = false;
            b_2.Enabled = false;
            b_3.Enabled = false;
            b_4.Enabled = false;
            b_6.Enabled = false;
            if (wiecej == true || mniej == true)
            {
                l_obstawienie2.Text = "i numer 5";
            }
            else
            {
                l_obstawienie.Text = "Numer 5";
            }

        }

        private void b_6_Click(object sender, EventArgs e)
        {
            postawOczko = 6;
            b_1.Enabled = false;
            b_2.Enabled = false;
            b_3.Enabled = false;
            b_4.Enabled = false;
            b_5.Enabled = false;
            if (wiecej == true || mniej == true)
            {
                l_obstawienie2.Text = "i numer 6";
            }
            else
            {
                l_obstawienie.Text = "Numer 6";
            }
        }
        #endregion

        private void b_wyjdz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region funkcje
        private void rzucKoscia() //funkcja odpowiadajaca za losowanie kosci i zmiane obrazkow
        {
            kosc1 = rnd.Next(1, 6);
            kosc2 = rnd.Next(1, 6);

            string kosc1src = "kosc" + kosc1 + ".png";
            string kosc2src = "kosc" + kosc2 + ".png";
            pic_1.ImageLocation = kosc1src;
            pic_2.ImageLocation = kosc2src;
            SoundPlayer simpleSound = new SoundPlayer("dice.wav");
            simpleSound.Play();

            rzut++;
            sumaOczek[rzut] = kosc1 + kosc2;

            #region wlasciwosci
            l_obstawienie.Text = "Nic";
            l_obstawienie2.Text = "";
            l_numer_dobrze.Visible = false;
            l_numer_zle.Visible = false;
            l_mniej_dobrze.Visible = false;
            l_mniej_zle.Visible = false;
            l_wiecej_dobrze.Visible = false;
            l_wiecej_zle.Visible = false;
            #endregion

        }
        private void f_wiecej()
        {
            if (sumaOczek[rzut] > sumaOczek[rzut - 1])
            {
                l_wiecej_dobrze.Visible = true;
                punkty = punkty + 5;
            }
            else
            {
                l_wiecej_zle.Visible = true;
                punkty = punkty - 5;
            }
            //aktualizacja punktacji
            l_punkty.Text = ("Punkty: " + punkty);

            //odblokowanie przyciskow
            b_wiecej.Enabled = true;
            b_mniej.Enabled = true;

            wiecej = false;
            mniej = false;
        }
        private void f_mniej()
        {
            if (sumaOczek[rzut] < sumaOczek[rzut - 1])
            {
                l_mniej_dobrze.Visible = true;
                punkty = punkty + 5;
            }
            else
            {
                l_mniej_zle.Visible = true;
                punkty = punkty - 5;
            }
            //aktualizacja punktacji
            l_punkty.Text = ("Punkty: " + punkty);

            //odblokowanie przyciskow
            b_wiecej.Enabled = true;
            b_mniej.Enabled = true;

            wiecej = false;
            mniej = false;
        }
        private void f_postawOczko()
        {
            if(kosc1 == postawOczko || kosc2 == postawOczko)
            {
                l_numer_dobrze.Visible = true;
                punkty = punkty + 10;
            }
            else
            {
                l_numer_zle.Visible = true;
                punkty = punkty - 10;
            }
            //aktualizacja punktacji
            l_punkty.Text = ("Punkty: " + punkty);

            //odblokowanie przyciskow
            b_1.Enabled = true;
            b_2.Enabled = true;
            b_3.Enabled = true;
            b_4.Enabled = true;
            b_5.Enabled = true;
            b_6.Enabled = true;
            postawOczko = 0;
        }
        #endregion

    }
}
