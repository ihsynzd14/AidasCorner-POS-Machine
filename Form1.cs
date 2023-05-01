namespace POS_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (parisCB.Checked == true)
            {
                parisTB.Enabled = true;
            }
            if (parisCB.Checked == false)
            {
                parisTB.Enabled = false;
                parisTB.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timenowlbl.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void newyorkCB_CheckedChanged(object sender, EventArgs e)
        {
            if (newyorkCB.Checked == true)
            {
                newyorkTB.Enabled = true;
            }
            if (newyorkCB.Checked == false)
            {
                newyorkTB.Enabled = false;
                newyorkTB.Text = "0";
            }
        }

        private void caramelCB_CheckedChanged(object sender, EventArgs e)
        {
            if (caramelCB.Checked == true)
            {
                caramelTB.Enabled = true;
            }
            if (caramelCB.Checked == false)
            {
                caramelTB.Enabled = false;
                caramelTB.Text = "0";
            }
        }

        private void chocolateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (chocolateCB.Checked == true)
            {
                chocolateTB.Enabled = true;
            }
            if (chocolateCB.Checked == false)
            {
                chocolateTB.Enabled = false;
                chocolateTB.Text = "0";
            }
        }

        private void pistachioCB_CheckedChanged(object sender, EventArgs e)
        {
            if (pistachioCB.Checked == true)
            {
                pistachioTB.Enabled = true;
            }
            if (pistachioCB.Checked == false)
            {
                pistachioTB.Enabled = false;
                pistachioTB.Text = "0";
            }
        }

        private void oreoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (oreoCB.Checked == true)
            {
                oreoTB.Enabled = true;
            }
            if (oreoCB.Checked == false)
            {
                oreoTB.Enabled = false;
                oreoTB.Text = "0";
            }
        }

        private void sansebastianCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sansebastianCB.Checked == true)
            {
                sansebastianTB.Enabled = true;
            }
            if (sansebastianCB.Checked == false)
            {
                sansebastianTB.Enabled = false;
                sansebastianTB.Text = "0";
            }
        }

        private void keivCB_CheckedChanged(object sender, EventArgs e)
        {
            if (keivCB.Checked == true)
            {
                kievTB.Enabled = true;
            }
            if (keivCB.Checked == false)
            {
                kievTB.Enabled = false;
                kievTB.Text = "0";
            }
        }

        private void rocherCB_CheckedChanged(object sender, EventArgs e)
        {
            if (rocherCB.Checked == true)
            {
                rocherTB.Enabled = true;
            }
            if (rocherCB.Checked == false)
            {
                rocherTB.Enabled = false;
                rocherTB.Text = "0";
            }
        }

        private void esterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (esterCB.Checked == true)
            {
                esterTB.Enabled = true;
            }
            if (esterCB.Checked == false)
            {
                esterTB.Enabled = false;
                esterTB.Text = "0";
            }
        }

        private void pragueCB_CheckedChanged(object sender, EventArgs e)
        {
            if (pragueCB.Checked == true)
            {
                pragueTB.Enabled = true;
            }
            if (pragueCB.Checked == false)
            {
                pragueTB.Enabled = false;
                pragueTB.Text = "0";
            }
        }

        private void havucCB_CheckedChanged(object sender, EventArgs e)
        {
            if (havucCB.Checked == true)
            {
                havucTB.Enabled = true;
            }
            if (havucCB.Checked == false)
            {
                havucTB.Enabled = false;
                havucTB.Text = "0";
            }
        }
        private void parisCB_CheckedChanged(object sender, EventArgs e)
        {
            if (parisCB.Checked == true)
            {
                parisTB.Enabled = true;
            }
            if (parisCB.Checked == false)
            {
                parisTB.Enabled = false;
                parisTB.Text = "0";
            }
        }

        private void profiterolCB_CheckedChanged(object sender, EventArgs e)
        {
            if (profiterolCB.Checked == true)
            {
                profiterolTB.Enabled = true;
            }
            if (profiterolCB.Checked == false)
            {
                profiterolTB.Enabled = false;
                profiterolTB.Text = "0";
            }
        }

        private void sokoladCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sokoladCB.Checked == true)
            {
                sokoladTB.Enabled = true;
            }
            if (sokoladCB.Checked == false)
            {
                sokoladTB.Enabled = false;
                sokoladTB.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double newyork = 5, caramel = 6, chocolatech = 6, oreo = 7, pistachio = 7, sansebastian = 12;
        double kiev = 8, rocher = 8, esterhazy = 9, prague = 8, havuclu = 5, paris = 4, profiterol = 3, choco = 15;

        private void button1_Click(object sender, EventArgs e)
        {
            newyorkCB.Checked = false;
            caramelCB.Checked = false;
            chocolateCB.Checked = false;
            oreoCB.Checked = false;
            pistachioCB.Checked = false;
            sansebastianCB.Checked = false;
            keivCB.Checked = false;
            rocherCB.Checked = false;
            esterCB.Checked = false;
            pragueCB.Checked = false;
            havucCB.Checked = false;
            parisCB.Checked = false;
            profiterolCB.Checked = false;
            sokoladCB.Checked = false;

        }

        double newyorktp, carameltp, chocolatechtp, oreotp, pistachiotp, sansebastiantp, kievtp, rochertp, esterhazytp, praguetp, havuclutp, paristp, profiteroltp, chocotp;
        double Subtotal = 0;

        private void ReceiptTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            newyorktp = newyork * Convert.ToDouble(newyorkTB.Text);
            carameltp = caramel * Convert.ToDouble(caramelTB.Text);
            chocolatechtp = chocolatech * Convert.ToDouble(chocolateTB.Text);
            oreotp = oreo * Convert.ToDouble(oreoTB.Text);
            pistachiotp = pistachio * Convert.ToDouble(pistachioTB.Text);
            sansebastiantp = sansebastian * Convert.ToDouble(sansebastianTB.Text);
            kievtp = kiev * Convert.ToDouble(kievTB.Text);
            rochertp = rocher * Convert.ToDouble(rocherTB.Text);
            esterhazytp = esterhazy * Convert.ToDouble(esterTB.Text);
            praguetp = prague * Convert.ToDouble(pragueTB.Text);
            havuclutp = havuclu * Convert.ToDouble(havucTB.Text);
            paristp = paris * Convert.ToDouble(parisTB.Text);
            profiteroltp = profiterol * Convert.ToDouble(profiterolTB.Text);
            chocotp = choco * Convert.ToDouble(sokoladTB.Text);
            Subtotal = 0;
            ReceiptTB.Clear();
            ReceiptTB.AppendText(Environment.NewLine);
            ReceiptTB.AppendText("\tAIDAS CORNERS POS \t" + "\t\t\t\t" + timenowlbl.Text + Environment.NewLine);
            ReceiptTB.AppendText("\t\t\t\t\t****************************" + Environment.NewLine);

            if (newyorkCB.Checked == true)
            {
                ReceiptTB.AppendText("\tCheesecake New York: \t" + newyorktp + " AZN" + " Eded: " + newyorkTB.Text + Environment.NewLine);
                Subtotal = Subtotal + newyorktp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (caramelCB.Checked == true)
            {
                ReceiptTB.AppendText("\tCheesecake Caramel: \t" + carameltp + " AZN" + "  Eded: " + caramelTB.Text + Environment.NewLine);
                Subtotal = Subtotal + carameltp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (chocolateCB.Checked == true)
            {
                ReceiptTB.AppendText("\tCheesecake Chocolate: \t" + chocolatechtp + " AZN" + "    Eded: " + chocolateTB.Text + Environment.NewLine);
                Subtotal = Subtotal + chocolatechtp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (oreoCB.Checked == true)
            {
                ReceiptTB.AppendText("\tCheesecake Oreo: \t" + oreotp + " AZN" + "    Eded: " + oreoTB.Text + Environment.NewLine);
                Subtotal = Subtotal + oreotp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (pistachioCB.Checked == true)
            {
                ReceiptTB.AppendText("\tCheesecake Pistachio: \t" + pistachiotp + " AZN" + "    Eded: " + pistachioTB.Text + Environment.NewLine);
                Subtotal = Subtotal + pistachiotp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (keivCB.Checked == true)
            {
                ReceiptTB.AppendText("\tKiev Cake: \t" + kievtp + " AZN" + "    Eded: " + kievTB.Text + Environment.NewLine);
                Subtotal = Subtotal + kievtp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (rocherCB.Checked == true)
            {
                ReceiptTB.AppendText("\tRocher: \t" + rochertp + " AZN" + "    Eded: " + rocherTB.Text + Environment.NewLine);
                Subtotal = Subtotal + rochertp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (esterCB.Checked == true)
            {
                ReceiptTB.AppendText("\tEsterhazy: \t" + esterhazytp + " AZN" + "    Eded: " + esterTB.Text + Environment.NewLine);
                Subtotal = Subtotal + esterhazytp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (pragueCB.Checked == true)
            {
                ReceiptTB.AppendText("\tPrague: \t" + praguetp + " AZN" + "    Eded: " + pragueTB.Text + Environment.NewLine);
                Subtotal = Subtotal + praguetp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (sansebastianCB.Checked == true)
            {
                ReceiptTB.AppendText("\tSan Sebastian: \t" + sansebastiantp + " AZN" + "    Eded: " + sansebastianTB.Text + Environment.NewLine);
                Subtotal = Subtotal + sansebastiantp;
                Subtotallbl.Text = "" + Subtotal;
            }


            if (havucCB.Checked == true)
            {
                ReceiptTB.AppendText("\tHavuclu Kek: \t" + havuclutp + " AZN" + "    Eded: " + havucTB.Text + Environment.NewLine);
                Subtotal = Subtotal + havuclutp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (parisCB.Checked == true)
            {
                ReceiptTB.AppendText("\tParis Brest: \t" + paristp + " AZN" + "    Eded: " + parisTB.Text + Environment.NewLine);
                Subtotal = Subtotal + paristp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (profiterolCB.Checked == true)
            {
                ReceiptTB.AppendText("\tProfiterol: \t" + profiteroltp + " AZN" + "    Eded: " + profiterolTB.Text + Environment.NewLine);
                Subtotal = Subtotal + profiteroltp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (sokoladCB.Checked == true)
            {
                ReceiptTB.AppendText("\tSokolad: \t" + chocotp + " AZN" + "    Eded: " + sokoladTB.Text + Environment.NewLine);
                Subtotal = Subtotal + chocotp;
                Subtotallbl.Text = "" + Subtotal;
            }


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTB.Text + " Toplam " + Subtotallbl.Text + "AZN", new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }

}