using System;
using System.Drawing;
using System.Windows.Forms;

namespace Skocko
{
    public partial class Form1 : Form
    {
        int GAMESTATE = 1;

        Image SRCE = Image.FromFile(@"Simboli\SRCE.png");
        Image TREF = Image.FromFile(@"Simboli\TREF.png");
        Image KARO = Image.FromFile(@"Simboli\KARO.png");
        Image PIK = Image.FromFile(@"Simboli\PIK.png");
        Image ZVEZDA = Image.FromFile(@"Simboli\ZVEZDA.png");
        Image SKOCKO = Image.FromFile(@"Simboli\SKOCKO.png");

        int TIME = 120;
        int RED = 1;
        int KONACANSIMBOL1, KONACANSIMBOL2, KONACANSIMBOL3, KONACANSIMBOL4;
        int TRENUTNISIMBOL1, TRENUTNISIMBOL2, TRENUTNISIMBOL3, TRENUTNISIMBOL4;
        int BROJCRVENIH = 0, BROJZUTIH = 0, BROJCRNIH = 4;
        int COUNTER = 0;

        Image KRUGCRN = Image.FromFile(@"Simboli\KRUG_CRN.png");
        Image KRUGZUTI = Image.FromFile(@"Simboli\KRUG_ZUT.png");
        Image KRUGCRVENI = Image.FromFile(@"Simboli\KRUG_CRVEN.png");

        void POSTAVLJANJE(Image a, int red)
        {
            if (red == 1)
            {
                if (BOX1.BackgroundImage == null) BOX1.BackgroundImage = a;
                else if (BOX2.BackgroundImage == null) BOX2.BackgroundImage = a;
                else if (BOX3.BackgroundImage == null) BOX3.BackgroundImage = a;
                else if (BOX4.BackgroundImage == null) BOX4.BackgroundImage = a;
            }
            else if (red == 2)
            {
                if (BOX5.BackgroundImage == null) BOX5.BackgroundImage = a;
                else if (BOX6.BackgroundImage == null) BOX6.BackgroundImage = a;
                else if (BOX7.BackgroundImage == null) BOX7.BackgroundImage = a;
                else if (BOX8.BackgroundImage == null) BOX8.BackgroundImage = a;
            }
            else if (red == 3)
            {
                if (BOX9.BackgroundImage == null) BOX9.BackgroundImage = a;
                else if (BOX10.BackgroundImage == null) BOX10.BackgroundImage = a;
                else if (BOX11.BackgroundImage == null) BOX11.BackgroundImage = a;
                else if (BOX12.BackgroundImage == null) BOX12.BackgroundImage = a;
            }
            else if (red == 4)
            {
                if (BOX13.BackgroundImage == null) BOX13.BackgroundImage = a;
                else if (BOX14.BackgroundImage == null) BOX14.BackgroundImage = a;
                else if (BOX15.BackgroundImage == null) BOX15.BackgroundImage = a;
                else if (BOX16.BackgroundImage == null) BOX16.BackgroundImage = a;
            }
            else if (red == 5)
            {
                if (BOX17.BackgroundImage == null) BOX17.BackgroundImage = a;
                else if (BOX18.BackgroundImage == null) BOX18.BackgroundImage = a;
                else if (BOX19.BackgroundImage == null) BOX19.BackgroundImage = a;
                else if (BOX20.BackgroundImage == null) BOX20.BackgroundImage = a;
            }
            else if (red == 6)
            {
                if (BOX21.BackgroundImage == null) BOX21.BackgroundImage = a;
                else if (BOX22.BackgroundImage == null) BOX22.BackgroundImage = a;
                else if (BOX23.BackgroundImage == null) BOX23.BackgroundImage = a;
                else if (BOX24.BackgroundImage == null) BOX24.BackgroundImage = a;
            }
        }
        void REZULTAT(int red, int crveni, int zuti, int crni)
        {
            if (red == 1)
            {
                while (crveni > 0)
                {

                    crveni--;
                    if (RESULTBOX1.BackgroundImage == null) RESULTBOX1.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX2.BackgroundImage == null) RESULTBOX2.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX3.BackgroundImage == null) RESULTBOX3.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX4.BackgroundImage == null) RESULTBOX4.BackgroundImage = KRUGCRVENI;
                }
                while (zuti > 0)
                {
                    zuti--;
                    if (RESULTBOX1.BackgroundImage == null) RESULTBOX1.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX2.BackgroundImage == null) RESULTBOX2.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX3.BackgroundImage == null) RESULTBOX3.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX4.BackgroundImage == null) RESULTBOX4.BackgroundImage = KRUGZUTI;
                }
                while (crni > 0)
                {
                    crni--;
                    if (RESULTBOX1.BackgroundImage == null) RESULTBOX1.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX2.BackgroundImage == null) RESULTBOX2.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX3.BackgroundImage == null) RESULTBOX3.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX4.BackgroundImage == null) RESULTBOX4.BackgroundImage = KRUGCRN;
                }
            }
            else if (red == 2)
            {
                while (crveni > 0)
                {

                    crveni--;
                    if (RESULTBOX5.BackgroundImage == null) RESULTBOX5.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX6.BackgroundImage == null) RESULTBOX6.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX7.BackgroundImage == null) RESULTBOX7.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX8.BackgroundImage == null) RESULTBOX8.BackgroundImage = KRUGCRVENI;
                }
                while (zuti > 0)
                {
                    zuti--;
                    if (RESULTBOX5.BackgroundImage == null) RESULTBOX5.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX6.BackgroundImage == null) RESULTBOX6.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX7.BackgroundImage == null) RESULTBOX7.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX8.BackgroundImage == null) RESULTBOX8.BackgroundImage = KRUGZUTI;
                }
                while (crni > 0)
                {
                    crni--;
                    if (RESULTBOX5.BackgroundImage == null) RESULTBOX5.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX6.BackgroundImage == null) RESULTBOX6.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX7.BackgroundImage == null) RESULTBOX7.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX8.BackgroundImage == null) RESULTBOX8.BackgroundImage = KRUGCRN;
                }
            }
            else if (red == 3)
            {
                while (crveni > 0)
                {

                    crveni--;
                    if (RESULTBOX9.BackgroundImage == null) RESULTBOX9.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX10.BackgroundImage == null) RESULTBOX10.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX11.BackgroundImage == null) RESULTBOX11.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX12.BackgroundImage == null) RESULTBOX12.BackgroundImage = KRUGCRVENI;
                }
                while (zuti > 0)
                {
                    zuti--;
                    if (RESULTBOX9.BackgroundImage == null) RESULTBOX9.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX10.BackgroundImage == null) RESULTBOX10.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX11.BackgroundImage == null) RESULTBOX11.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX12.BackgroundImage == null) RESULTBOX12.BackgroundImage = KRUGZUTI;
                }
                while (crni > 0)
                {
                    crni--;
                    if (RESULTBOX9.BackgroundImage == null) RESULTBOX9.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX10.BackgroundImage == null) RESULTBOX10.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX11.BackgroundImage == null) RESULTBOX11.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX12.BackgroundImage == null) RESULTBOX12.BackgroundImage = KRUGCRN;
                }
            }
            else if (red == 4)
            {
                while (crveni > 0)
                {

                    crveni--;
                    if (RESULTBOX13.BackgroundImage == null) RESULTBOX13.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX14.BackgroundImage == null) RESULTBOX14.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX15.BackgroundImage == null) RESULTBOX15.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX16.BackgroundImage == null) RESULTBOX16.BackgroundImage = KRUGCRVENI;
                }
                while (zuti > 0)
                {
                    zuti--;
                    if (RESULTBOX13.BackgroundImage == null) RESULTBOX13.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX14.BackgroundImage == null) RESULTBOX14.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX15.BackgroundImage == null) RESULTBOX15.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX16.BackgroundImage == null) RESULTBOX16.BackgroundImage = KRUGZUTI;
                }
                while (crni > 0)
                {
                    crni--;
                    if (RESULTBOX13.BackgroundImage == null) RESULTBOX13.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX14.BackgroundImage == null) RESULTBOX14.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX15.BackgroundImage == null) RESULTBOX15.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX16.BackgroundImage == null) RESULTBOX16.BackgroundImage = KRUGCRN;
                }
            }
            else if (red == 5)
            {
                while (crveni > 0)
                {

                    crveni--;
                    if (RESULTBOX17.BackgroundImage == null) RESULTBOX17.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX18.BackgroundImage == null) RESULTBOX18.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX19.BackgroundImage == null) RESULTBOX19.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX20.BackgroundImage == null) RESULTBOX20.BackgroundImage = KRUGCRVENI;
                }
                while (zuti > 0)
                {
                    zuti--;
                    if (RESULTBOX17.BackgroundImage == null) RESULTBOX17.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX18.BackgroundImage == null) RESULTBOX18.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX19.BackgroundImage == null) RESULTBOX19.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX20.BackgroundImage == null) RESULTBOX20.BackgroundImage = KRUGZUTI;
                }
                while (crni > 0)
                {
                    crni--;
                    if (RESULTBOX17.BackgroundImage == null) RESULTBOX17.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX18.BackgroundImage == null) RESULTBOX18.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX19.BackgroundImage == null) RESULTBOX19.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX20.BackgroundImage == null) RESULTBOX20.BackgroundImage = KRUGCRN;
                }
            }
            else if (red == 6)
            {
                while (crveni > 0)
                {

                    crveni--;
                    if (RESULTBOX21.BackgroundImage == null) RESULTBOX21.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX22.BackgroundImage == null) RESULTBOX22.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX23.BackgroundImage == null) RESULTBOX23.BackgroundImage = KRUGCRVENI;
                    else if (RESULTBOX24.BackgroundImage == null) RESULTBOX24.BackgroundImage = KRUGCRVENI;
                }
                while (zuti > 0)
                {
                    zuti--;
                    if (RESULTBOX21.BackgroundImage == null) RESULTBOX21.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX22.BackgroundImage == null) RESULTBOX22.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX23.BackgroundImage == null) RESULTBOX23.BackgroundImage = KRUGZUTI;
                    else if (RESULTBOX24.BackgroundImage == null) RESULTBOX24.BackgroundImage = KRUGZUTI;
                }
                while (crni > 0)
                {
                    crni--;
                    if (RESULTBOX21.BackgroundImage == null) RESULTBOX21.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX22.BackgroundImage == null) RESULTBOX22.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX23.BackgroundImage == null) RESULTBOX23.BackgroundImage = KRUGCRN;
                    else if (RESULTBOX24.BackgroundImage == null) RESULTBOX24.BackgroundImage = KRUGCRN;
                }
            }
        }
        void VRATIPOLJE()
        {
            int TRENUTNOMESTO = RED * 4 + COUNTER;
            if (TRENUTNOMESTO == 5) BOX1.BackgroundImage = null;
            else if (TRENUTNOMESTO == 6) BOX2.BackgroundImage = null;
            else if (TRENUTNOMESTO == 7) BOX3.BackgroundImage = null;
            else if (TRENUTNOMESTO == 8) BOX4.BackgroundImage = null;
            else if (TRENUTNOMESTO == 9) BOX5.BackgroundImage = null;
            else if (TRENUTNOMESTO == 10) BOX6.BackgroundImage = null;
            else if (TRENUTNOMESTO == 11) BOX7.BackgroundImage = null;
            else if (TRENUTNOMESTO == 12) BOX8.BackgroundImage = null;
            else if (TRENUTNOMESTO == 13) BOX9.BackgroundImage = null;
            else if (TRENUTNOMESTO == 14) BOX10.BackgroundImage = null;
            else if (TRENUTNOMESTO == 15) BOX11.BackgroundImage = null;
            else if (TRENUTNOMESTO == 16) BOX12.BackgroundImage = null;
            else if (TRENUTNOMESTO == 17) BOX13.BackgroundImage = null;
            else if (TRENUTNOMESTO == 18) BOX14.BackgroundImage = null;
            else if (TRENUTNOMESTO == 19) BOX15.BackgroundImage = null;
            else if (TRENUTNOMESTO == 20) BOX16.BackgroundImage = null;
            else if (TRENUTNOMESTO == 21) BOX17.BackgroundImage = null;
            else if (TRENUTNOMESTO == 22) BOX18.BackgroundImage = null;
            else if (TRENUTNOMESTO == 23) BOX19.BackgroundImage = null;
            else if (TRENUTNOMESTO == 24) BOX20.BackgroundImage = null;
            else if (TRENUTNOMESTO == 25) BOX21.BackgroundImage = null;
            else if (TRENUTNOMESTO == 26) BOX22.BackgroundImage = null;
            else if (TRENUTNOMESTO == 27) BOX23.BackgroundImage = null;
            else if (TRENUTNOMESTO == 28) BOX24.BackgroundImage = null;
        }
        void RESETOVANJE()
        {
            BOX1.BackgroundImage = null;
            BOX2.BackgroundImage = null;
            BOX3.BackgroundImage = null;
            BOX4.BackgroundImage = null;
            BOX5.BackgroundImage = null;
            BOX6.BackgroundImage = null;
            BOX7.BackgroundImage = null;
            BOX8.BackgroundImage = null;
            BOX9.BackgroundImage = null;
            BOX10.BackgroundImage = null;
            BOX11.BackgroundImage = null;
            BOX12.BackgroundImage = null;
            BOX13.BackgroundImage = null;
            BOX14.BackgroundImage = null;
            BOX15.BackgroundImage = null;
            BOX16.BackgroundImage = null;
            BOX17.BackgroundImage = null;
            BOX18.BackgroundImage = null;
            BOX19.BackgroundImage = null;
            BOX20.BackgroundImage = null;
            BOX21.BackgroundImage = null;
            BOX22.BackgroundImage = null;
            BOX23.BackgroundImage = null;
            BOX24.BackgroundImage = null;

            RESULTBOX1.BackgroundImage = null;
            RESULTBOX2.BackgroundImage = null;
            RESULTBOX3.BackgroundImage = null;
            RESULTBOX4.BackgroundImage = null;
            RESULTBOX5.BackgroundImage = null;
            RESULTBOX6.BackgroundImage = null;
            RESULTBOX7.BackgroundImage = null;
            RESULTBOX8.BackgroundImage = null;
            RESULTBOX9.BackgroundImage = null;
            RESULTBOX10.BackgroundImage = null;
            RESULTBOX11.BackgroundImage = null;
            RESULTBOX12.BackgroundImage = null;
            RESULTBOX13.BackgroundImage = null;
            RESULTBOX14.BackgroundImage = null;
            RESULTBOX15.BackgroundImage = null;
            RESULTBOX16.BackgroundImage = null;
            RESULTBOX17.BackgroundImage = null;
            RESULTBOX18.BackgroundImage = null;
            RESULTBOX19.BackgroundImage = null;
            RESULTBOX20.BackgroundImage = null;
            RESULTBOX21.BackgroundImage = null;
            RESULTBOX22.BackgroundImage = null;
            RESULTBOX23.BackgroundImage = null;
            RESULTBOX24.BackgroundImage = null;
        }
        public Form1()
        {
            InitializeComponent();
            this.Text = "Igra Skočko";

            Random r = new Random();
            KONACANSIMBOL1 = r.Next(0, 6);
            KONACANSIMBOL2 = r.Next(0, 6);
            KONACANSIMBOL3 = r.Next(0, 6);
            KONACANSIMBOL4 = r.Next(0, 6);

            timer1.Start();
            TIMER.Font = new Font("Arial", 24, FontStyle.Bold);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TIMER.Text = TIME.ToString();
            progressBar1.Value = TIME;
            TIME--;

            if (TIME == -1)
            {
                END();
                timer1.Stop();
                MessageBox.Show("Žao nam je, vreme vam je isteklo!");
            }
        }
        private void DUGME_UNAZAD_Click(object sender, EventArgs e)
        {
            if (COUNTER != 0)
            {
                VRATIPOLJE();
                COUNTER--;
                if (COUNTER < 0) COUNTER = 0;
            }
        }
        private void END()
        {
            GAMESTATE = 0;
            if (KONACANSIMBOL1 == 0) ENDBOX1.BackgroundImage = SRCE;
            else if (KONACANSIMBOL1 == 1) ENDBOX1.BackgroundImage = KARO;
            else if (KONACANSIMBOL1 == 2) ENDBOX1.BackgroundImage = TREF;
            else if (KONACANSIMBOL1 == 3) ENDBOX1.BackgroundImage = PIK;
            else if (KONACANSIMBOL1 == 4) ENDBOX1.BackgroundImage = ZVEZDA;
            else if (KONACANSIMBOL1 == 5) ENDBOX1.BackgroundImage = SKOCKO;

            if (KONACANSIMBOL2 == 0) ENDBOX2.BackgroundImage = SRCE;
            else if (KONACANSIMBOL2 == 1) ENDBOX2.BackgroundImage = KARO;
            else if (KONACANSIMBOL2 == 2) ENDBOX2.BackgroundImage = TREF;
            else if (KONACANSIMBOL2 == 3) ENDBOX2.BackgroundImage = PIK;
            else if (KONACANSIMBOL2 == 4) ENDBOX2.BackgroundImage = ZVEZDA;
            else if (KONACANSIMBOL2 == 5) ENDBOX2.BackgroundImage = SKOCKO;

            if (KONACANSIMBOL3 == 0) ENDBOX3.BackgroundImage = SRCE;
            else if (KONACANSIMBOL3 == 1) ENDBOX3.BackgroundImage = KARO;
            else if (KONACANSIMBOL3 == 2) ENDBOX3.BackgroundImage = TREF;
            else if (KONACANSIMBOL3 == 3) ENDBOX3.BackgroundImage = PIK;
            else if (KONACANSIMBOL3 == 4) ENDBOX3.BackgroundImage = ZVEZDA;
            else if (KONACANSIMBOL3 == 5) ENDBOX3.BackgroundImage = SKOCKO;

            if (KONACANSIMBOL4 == 0) ENDBOX4.BackgroundImage = SRCE;
            else if (KONACANSIMBOL4 == 1) ENDBOX4.BackgroundImage = KARO;
            else if (KONACANSIMBOL4 == 2) ENDBOX4.BackgroundImage = TREF;
            else if (KONACANSIMBOL4 == 3) ENDBOX4.BackgroundImage = PIK;
            else if (KONACANSIMBOL4 == 4) ENDBOX4.BackgroundImage = ZVEZDA;
            else if (KONACANSIMBOL4 == 5) ENDBOX4.BackgroundImage = SKOCKO;
        }
        private void progressBar1_Click(object sender, EventArgs e){}
        private void SRCE_BOX_Click(object sender, EventArgs e)
        {
            if (GAMESTATE == 1)
            {
                POSTAVLJANJE(SRCE, RED);
                if (COUNTER < 4) COUNTER++;
                if (COUNTER == 1) TRENUTNISIMBOL1 = 0;
                else if (COUNTER == 2) TRENUTNISIMBOL2 = 0;
                else if (COUNTER == 3) TRENUTNISIMBOL3 = 0;
                else if (COUNTER == 4) TRENUTNISIMBOL4 = 0;
            }
        }
        private void KARO_BOX_Click(object sender, EventArgs e)
        {
            if (GAMESTATE == 1)
            {
                POSTAVLJANJE(KARO, RED);
                if (COUNTER < 4) COUNTER++;
                if (COUNTER == 1) TRENUTNISIMBOL1 = 1;
                else if (COUNTER == 2) TRENUTNISIMBOL2 = 1;
                else if (COUNTER == 3) TRENUTNISIMBOL3 = 1;
                else if (COUNTER == 4) TRENUTNISIMBOL4 = 1;
            }
        }
        private void TREF_BOX_Click(object sender, EventArgs e)
        {
            if (GAMESTATE == 1)
            {
                POSTAVLJANJE(TREF, RED);
                if (COUNTER < 4) COUNTER++;
                if (COUNTER == 1) TRENUTNISIMBOL1 = 2;
                else if (COUNTER == 2) TRENUTNISIMBOL2 = 2;
                else if (COUNTER == 3) TRENUTNISIMBOL3 = 2;
                else if (COUNTER == 4) TRENUTNISIMBOL4 = 2;
            }
        }
        private void PIK_BOX_Click(object sender, EventArgs e)
        {
            if (GAMESTATE == 1)
            {
                POSTAVLJANJE(PIK, RED);
                if (COUNTER < 4) COUNTER++;
                if (COUNTER == 1) TRENUTNISIMBOL1 = 3;
                else if (COUNTER == 2) TRENUTNISIMBOL2 = 3;
                else if (COUNTER == 3) TRENUTNISIMBOL3 = 3;
                else if (COUNTER == 4) TRENUTNISIMBOL4 = 3;
            }
        }
        private void ZVEZDA_BOX_Click(object sender, EventArgs e)
        {
            if (GAMESTATE == 1)
            {
                POSTAVLJANJE(ZVEZDA, RED);
                if (COUNTER < 4) COUNTER++;
                if (COUNTER == 1) TRENUTNISIMBOL1 = 4;
                else if (COUNTER == 2) TRENUTNISIMBOL2 = 4;
                else if (COUNTER == 3) TRENUTNISIMBOL3 = 4;
                else if (COUNTER == 4) TRENUTNISIMBOL4 = 4;
            }
        }
        private void SKOCKO_BOX_Click(object sender, EventArgs e)
        {
            if (GAMESTATE == 1)
            {
                POSTAVLJANJE(SKOCKO, RED);
                if (COUNTER < 4) COUNTER++;
                if (COUNTER == 1) TRENUTNISIMBOL1 = 5;
                else if (COUNTER == 2) TRENUTNISIMBOL2 = 5;
                else if (COUNTER == 3) TRENUTNISIMBOL3 = 5;
                else if (COUNTER == 4) TRENUTNISIMBOL4 = 5;
            }
        }
        private void DUGME_PRIJAVA_Click(object sender, EventArgs e)
        {
            if (COUNTER == 4)
            {
                
                int MEMORY1 = KONACANSIMBOL1, MEMORY2 = KONACANSIMBOL2, MEMORY3 = KONACANSIMBOL3, MEMORY4 = KONACANSIMBOL4;
                int TRMEMORY1 = TRENUTNISIMBOL1, TRMEMORY2 = TRENUTNISIMBOL2, TRMEMORY3 = TRENUTNISIMBOL3, TRMEMORY4 = TRENUTNISIMBOL4;

                if (TRENUTNISIMBOL1 == KONACANSIMBOL1) { BROJCRVENIH++; KONACANSIMBOL1 = 10; TRENUTNISIMBOL1 = 26; }
                if (TRENUTNISIMBOL2 == KONACANSIMBOL2) { BROJCRVENIH++; KONACANSIMBOL2 = 11; TRENUTNISIMBOL2 = 27; }
                if (TRENUTNISIMBOL3 == KONACANSIMBOL3) { BROJCRVENIH++; KONACANSIMBOL3 = 12; TRENUTNISIMBOL3 = 28; }
                if (TRENUTNISIMBOL4 == KONACANSIMBOL4) { BROJCRVENIH++; KONACANSIMBOL4 = 13; TRENUTNISIMBOL4 = 29; }

                if (TRENUTNISIMBOL1 == KONACANSIMBOL2) { BROJZUTIH++; KONACANSIMBOL2 = 14; TRENUTNISIMBOL1 = 30; }
                if (TRENUTNISIMBOL1 == KONACANSIMBOL3) { BROJZUTIH++; KONACANSIMBOL3 = 15; TRENUTNISIMBOL1 = 31; }
                if (TRENUTNISIMBOL1 == KONACANSIMBOL4) { BROJZUTIH++; KONACANSIMBOL4 = 16; TRENUTNISIMBOL1 = 32; }
                if (TRENUTNISIMBOL2 == KONACANSIMBOL1) { BROJZUTIH++; KONACANSIMBOL1 = 17; TRENUTNISIMBOL2 = 33; }
                if (TRENUTNISIMBOL2 == KONACANSIMBOL3) { BROJZUTIH++; KONACANSIMBOL3 = 18; TRENUTNISIMBOL2 = 34; }
                if (TRENUTNISIMBOL2 == KONACANSIMBOL4) { BROJZUTIH++; KONACANSIMBOL4 = 19; TRENUTNISIMBOL2 = 35; }
                if (TRENUTNISIMBOL3 == KONACANSIMBOL1) { BROJZUTIH++; KONACANSIMBOL1 = 20; TRENUTNISIMBOL3 = 36; }
                if (TRENUTNISIMBOL3 == KONACANSIMBOL2) { BROJZUTIH++; KONACANSIMBOL2 = 21; TRENUTNISIMBOL3 = 37; }
                if (TRENUTNISIMBOL3 == KONACANSIMBOL4) { BROJZUTIH++; KONACANSIMBOL4 = 22; TRENUTNISIMBOL3 = 38; }
                if (TRENUTNISIMBOL4 == KONACANSIMBOL1) { BROJZUTIH++; KONACANSIMBOL1 = 23; TRENUTNISIMBOL4 = 39; }
                if (TRENUTNISIMBOL4 == KONACANSIMBOL2) { BROJZUTIH++; KONACANSIMBOL2 = 24; TRENUTNISIMBOL4 = 40; }
                if (TRENUTNISIMBOL4 == KONACANSIMBOL3) { BROJZUTIH++; KONACANSIMBOL3 = 25; TRENUTNISIMBOL4 = 41; }

                BROJCRNIH = BROJCRNIH - BROJCRVENIH - BROJZUTIH;
                REZULTAT(RED, BROJCRVENIH, BROJZUTIH, BROJCRNIH);

                KONACANSIMBOL1 = MEMORY1;
                KONACANSIMBOL2 = MEMORY2;
                KONACANSIMBOL3 = MEMORY3;
                KONACANSIMBOL4 = MEMORY4;

                TRENUTNISIMBOL1 = TRMEMORY1;
                TRENUTNISIMBOL2 = TRMEMORY2;
                TRENUTNISIMBOL3 = TRMEMORY3;
                TRENUTNISIMBOL4 = TRMEMORY4;

                RED++;
                COUNTER = 0;

                if (RED == 7 || BROJCRVENIH == 4 || TIME == 0)
                {
                    timer1.Stop();
                    END();

                    if(BROJCRVENIH == 4) MessageBox.Show("Čestitamo, pobedili ste!");
                    else if(RED == 7) MessageBox.Show("Žao nam je, više sreće sledeći put!");
                }

                BROJCRVENIH = 0;
                BROJZUTIH = 0;
                BROJCRNIH = 4;
            }
        }
        private void DUGME_ISPOCETKA_Click(object sender, EventArgs e)
        {
            RESETOVANJE();
            GAMESTATE = 1;
            RED = 1;
            COUNTER = 0;
            TIME = 120;
            timer1.Start();

            Random r = new Random();
            KONACANSIMBOL1 = r.Next(0, 6);
            KONACANSIMBOL2 = r.Next(0, 6);
            KONACANSIMBOL3 = r.Next(0, 6);
            KONACANSIMBOL4 = r.Next(0, 6);

            ENDBOX1.BackgroundImage = null;
            ENDBOX2.BackgroundImage = null;
            ENDBOX3.BackgroundImage = null;
            ENDBOX4.BackgroundImage = null;

            BROJCRNIH = 4;
            BROJCRVENIH = 0;
            BROJZUTIH = 0;
        }
    }
}