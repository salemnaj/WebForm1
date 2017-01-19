using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebForm1
{
    public partial class _Default : Page
    {
        public static double[] cnstts = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public static double[] arraycnstts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string cnsttsstr = "";
        public static string varistr = " ";

        //public static short counter = 0;
        public static short precedent = 0;
        public static int degree = 0;
        public static int counthits = 0;
        public static bool isdegree = false;
        public static bool novalp = false;
        public static bool novaln = false;
        public static bool isvari = false;

        Calculus Cal = new Calculus();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(isvari == true)
            {
                varistr += '1';
                TextBox1.Text += '1';
                return;
            }
         switch (precedent)
         {
                case 14:
                    MessageBox.Show("Error");
                    break;
                default:
                   cnsttsstr += '1';
                   TextBox1.Text += '1';
                    counthits++;
                    precedent = 1;
                    break;
         }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '2';
                TextBox1.Text += '2';
                return;
            }
            switch (precedent)
            {
                case 14:
                   degree = 2;
                    TextBox1.Text += '2';
                    isdegree = false;
                    break;
                default:

                    cnsttsstr += '2';
                    TextBox1.Text += '2';
                    counthits++;
                    break;
            }
            precedent = 2;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '3';
                TextBox1.Text += '3';
                return;
            }
            switch (precedent)
            {
                case 14:
                    degree = 3;
                    TextBox1.Text += '3';
                    isdegree = false;
                    break;
                default:
                    cnsttsstr += '3';
                    TextBox1.Text += '3';
                    counthits++;
                    break;
            }
            precedent = 3;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '4';
                TextBox1.Text += '4';
                return;
            }
            switch (precedent)
            {
                case 14:
                    degree = 4;
                    TextBox1.Text += '4';
                    isdegree = false;
                    break;
                default:
                    cnsttsstr += '4';
                    TextBox1.Text += '4';
                    counthits++;
                    break;
            }
            precedent = 4;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '5';
                TextBox1.Text += '5';
                return;
            }
            switch (precedent)
            {
                case 14:
                    degree = 5;
                    TextBox1.Text += '5';
                    isdegree = false;
                    break;
                default:
                    cnsttsstr += '5';
                    TextBox1.Text += '5';
                    counthits++;
                    break;
            }
            precedent = 5;

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '6';
                TextBox1.Text += '6';
                return;
            }
            switch (precedent)
            {
               /* case 13:
                    cnsttsstr += "-6";
                    TextBox1.Text += '6';
                    counthits++;
                    break;
                    */
                case 14:
                    degree = 6;
                    TextBox1.Text += '6';
                    isdegree = false;
                    break;
                default:
                    cnsttsstr += '6';
                    TextBox1.Text += '6';
                    counthits++;
                    break;
            }
            precedent = 6;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '7';
                TextBox1.Text += '7';
                return;
            }
            switch (precedent)
            {
                case 14:
                    degree = 7;
                    TextBox1.Text += '7';
                    isdegree = false;
                    break;
                default:
                    cnsttsstr += '7';
                    TextBox1.Text += '7';
                    counthits++;
                    break;
            }
            precedent = 7;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '8';
                TextBox1.Text += '8';
                return;
            }
            switch (precedent)
            {
                case 14:
                    degree = 8;
                    TextBox1.Text += '8';
                    break;
                default:
                    cnsttsstr += '8';
                    TextBox1.Text += '8';
                    counthits++;
                    break;
            }
            precedent = 8;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '9';
                TextBox1.Text += '9';
                return;
            }
            switch (precedent)
            {
                case 14:
                    degree = 9;
                    TextBox1.Text += '9';
                    isdegree = false;
                    break;
                default:
                    cnsttsstr += '9';
                    TextBox1.Text += '9';
                    counthits++;
                    break;
            }
            precedent = 9;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '0';
                TextBox1.Text += '0';
                return;
            }
            switch (precedent)
            {
                case 14:
                    MessageBox.Show("Error");
                    break;
                default:

                    cnsttsstr += '0';
                    TextBox1.Text += '0';
                    counthits++;
                    precedent = 10;
                    break;
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr += '.';
                TextBox1.Text += '.';
                return;
            }
            switch (precedent)
            {
                case 0:
                    cnsttsstr += "0.";
                    TextBox1.Text += "0.";
                    counthits++;
                    precedent = 11;

                    break;
                case 14:
                    MessageBox.Show("Error");
                    break;
                default:

                    cnsttsstr += '.';
                    TextBox1.Text += '.';
                    counthits++;
                    precedent = 11;
                    break;
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            switch (precedent)
            {
                case 14:
                    MessageBox.Show("Error");
                    break;
                case 15:
                    TextBox1.Text += '+';
                    counthits = 0;
                    //  novalp = true;
                    if (novalp == true)
                    {
                        cnstts[1] = 1; //Convert.ToDouble(cnsttsstr);
                        novalp = false;
                        break;
                    }
                    if (novaln == true)
                    {
                        cnstts[1] = -1; //Convert.ToDouble(cnsttsstr);
                        novaln = false;
                        break;
                    }
                    try
                    {
                        cnstts[1] = Convert.ToDouble(cnsttsstr);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error from 15");
                    }
                    degree = 1;
                    break;

                default:
                    TextBox1.Text += '+';
                    counthits = 0;
                    if (novalp == true)
                    {
                        cnstts[degree] = 1;
                        novalp = false;
                        break;
                    }
                    if (novaln == true)
                    {
                        cnstts[degree] = -1;
                        novaln = false;
                        break;
                    }
                    try
                    {
                        cnstts[degree] = Convert.ToDouble(cnsttsstr);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error default");
                    }
                    break;
            }
            precedent = 12;
            cnsttsstr = "";
            isdegree = false;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (isvari == true)
            {
                varistr = "-";
                TextBox1.Text += "-";
                return;
            }
            switch (precedent)
            {
                case 0:
                    cnsttsstr = "-";
                    TextBox1.Text += '-';
                    break;
                case 14:
                    MessageBox.Show("Error");
                    break;
                case 15:
                    TextBox1.Text += '-';
                    counthits = 0;
                    degree = 1;
                  
                    if (novalp == true)
                    {
                        cnstts[1] = 1; //Convert.ToDouble(cnsttsstr);
                        novalp = false;
                        break;
                    }
                    if (novaln == true)
                    {
                        cnstts[1] = -1; //Convert.ToDouble(cnsttsstr);
                        novaln = false;
                        break;
                    }
                    try
                    {
                       cnstts[1] = Convert.ToDouble(cnsttsstr);
                    }
                    catch (FormatException)
                    {
                       MessageBox.Show("Error 15");
                    }
                    cnsttsstr = "-";
                    break;

                default:
                    TextBox1.Text += '-';
                    if (novalp == true)
                    {
                        cnstts[degree] = 1;
                        novalp = false;
                        break;
                    }
                    if (novaln == true)
                    {
                        cnstts[degree] = -1;
                        novaln = false;
                        break;
                    }
                    try
                    {
                        cnstts[degree] = Convert.ToDouble(cnsttsstr);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error default");
                    }
                    counthits = 0;
                    cnsttsstr = "-";
                    break;
            }
            precedent = 13;
            isdegree = false;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            switch (precedent)
            {
                case 14:
                    MessageBox.Show("Error");
                    break;
                default:
                    isdegree = true;
                    TextBox1.Text += '^';
                    break;
            }
            precedent = 14;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            switch (precedent)
            {
                case 0:
                    novalp = true;
                    break;
                case 1:
                    if (counthits == 1) MessageBox.Show("not significant");
                    break;
                case 12:
                    novalp = true;
                    break;
                case 13:
                    novaln = true;
                    break;
            }
            counthits++;
            TextBox1.Text += 'x';
            precedent = 15;
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            switch (precedent)
            {
                case 14:
                    MessageBox.Show("Error");
                    break;
                case 15:
                    cnstts[0] = 0;
                    TextBox1.Text += "= 0\n x0 = ";
                    isvari = true;
                    break;
                default:
                    
                    if (isdegree == true)
                    {
                        try
                        {
                            cnstts[degree] = Convert.ToDouble(cnsttsstr);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        try
                        {
                            cnstts[0] = Convert.ToDouble(cnsttsstr);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Error");
                        }
                    }

                    TextBox1.Text += "= 0\n x0 = ";
                    isvari = true;
                    break;
            }
            precedent = 16;
            cnsttsstr = "";
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
           
            cnsttsstr = "";
            //counter = 0;
            precedent = 0;
            degree = 0;
            isdegree = false;
            novaln = false;
            novalp = false;
            isvari = false;
            varistr = "";

            for (int i = 0; i < 10; i++)
            {
                cnstts[i] = 0;
                arraycnstts[i] = 0;
            }
            TextBox1.Text = "";
    }

    protected void Button18_Click(object sender, EventArgs e)
        {
            //degree = 2;
            double varie = 0;



           // double[] arraycnstts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for(int i = 0; i < 10; i++)
            {
                arraycnstts[i] = cnstts[9 - i];
            }
            try
            {
                varie = Convert.ToDouble(varistr);

            }
            catch (FormatException)
            {
                MessageBox.Show("Error convert to double");
            }
            double valeur = Cal.polycal(varie, arraycnstts);
            try
            {
                TextBox1.Text = Convert.ToString(valeur);
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Error convert to double");
            }

           // TextBox1.Text = str1;
        }
    }
}