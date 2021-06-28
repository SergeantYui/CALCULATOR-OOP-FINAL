using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CALCULATOR_OOP_FINAL
{
    public partial class Form1 : Form
    {
        double results = 0;
        string operation = "";
        bool enter_value = false;
        byte i = 0;


        public Form1()
        {
            InitializeComponent();
        }

      

        private void number_btn_click(object sender, EventArgs e)
        {
            if ((result_box.Text == "0") || (enter_value))
                result_box.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!result_box.Text.Contains("."))
                    result_box.Text = result_box.Text + num.Text;
            }
            else
                result_box.Text = result_box.Text + num.Text;
        }

        private void backspace_btn_Click(object sender, EventArgs e)
        {
            if (result_box.Text.Length > 0)
            {
                result_box.Text = result_box.Text.Remove(result_box.Text.Length - 1, 1);
            }
            if (result_box.Text.Length < 1)
            {
                result_box.Text = "0";
            }
        }

        private void CE_btn_Click(object sender, EventArgs e)
        {
            result_box.Text = "0";
            i += 1;
            if (i == 2)
            {
                lbl_operation.Text = "";
                if (lbl_operation.Text == "" && result_box.Text == "0")
                {
                    CE_btn.Text = "C";
                    i = 0;
                }
             }

        }

        private void arithmetic_operators(object sender, EventArgs e)
        {
            CE_btn.Text = "CE";
            Button num = (Button)sender;
            operation = num.Text;
            results = double.Parse(result_box.Text);
            result_box.Text = "";
            lbl_operation.Text = System.Convert.ToString(results) + " " + operation;

        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            lbl_operation.Text = "";
            switch (operation)
            {
                case "+":
                    result_box.Text = (results + double.Parse(result_box.Text)).ToString();
                    break;
                case "-":
                    result_box.Text = (results - double.Parse(result_box.Text)).ToString();
                    break;
                case "x":
                    result_box.Text = (results * double.Parse(result_box.Text)).ToString();
                    break;
                case "÷":
                    result_box.Text = (results / double.Parse(result_box.Text)).ToString();
                    break;
                case "mod":
                    result_box.Text = (results % double.Parse(result_box.Text)).ToString();
                    break;
                case "exp":
                    double i = double.Parse(result_box.Text);
                    double q;
                    q = (results);
                    result_box.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void pi_btn_Click(object sender, EventArgs e)
        {
            result_box.Text = "3.1415926535 8979323";
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("log" + "(" + result_box.Text + ")");
            log = Math.Log10(log);
            result_box.Text = System.Convert.ToString(log);
        }

        private void sqrt_btn_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Sqrt" + "(" + result_box.Text + ")");
            sqrt = Math.Sqrt(sqrt);
            result_box.Text = System.Convert.ToString("±" + sqrt);
        }
       
        private void sinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.sinh = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Sinh" + "(" + result_box.Text + ")");
            hyp.sinH();
            result_box.Text = System.Convert.ToString(hyp.sinh);
        }

        private void coshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.cosh = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Cosh" + "(" + result_box.Text + ")");
            hyp.cosH();
            result_box.Text = System.Convert.ToString(hyp.cosh);
        }

        private void tanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.tanh = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Tanh" + "(" + result_box.Text + ")");
            hyp.tanH();
            result_box.Text = System.Convert.ToString(hyp.tanh);
        }

        private void sinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.asin = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Sin⁻¹" + "(" + result_box.Text + ")");
            hyp.Asin();
            result_box.Text = System.Convert.ToString(hyp.asin);
        }

        private void cosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.acos = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Cos⁻¹" + "(" + result_box.Text + ")");
            hyp.Acos();
            result_box.Text = System.Convert.ToString(hyp.acos);
        }

        private void tanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.atan = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Tan⁻¹" + "(" + result_box.Text + ")");
            hyp.Atan();
            result_box.Text = System.Convert.ToString(hyp.atan);
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.sin = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Sin" + "(" + result_box.Text + ")");
            hyp.Sin();
            result_box.Text = System.Convert.ToString(hyp.sin);
        }

        private void tanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.cos = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Cos" + "(" + result_box.Text + ")");
            hyp.Cos();
            result_box.Text = System.Convert.ToString(hyp.cos);
        }

        private void cotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trigonometry hyp = new trigonometry();

            hyp.tan = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("Tan" + "(" + result_box.Text + ")");
            hyp.Tan();
            result_box.Text = System.Convert.ToString(hyp.tan);
        }

        private void sqrd_button_Click(object sender, EventArgs e)
        {
            double sqrd;
            sqrd = Convert.ToDouble(result_box.Text) * Convert.ToDouble(result_box.Text);
            result_box.Text = Convert.ToString(sqrd);
        }

        private void fraction_btn_Click(object sender, EventArgs e)
        {
            double fraction;
            fraction = Convert.ToDouble(1.0 / Convert.ToDouble(result_box.Text));
            result_box.Text = Convert.ToString(fraction);
        }

        private void in_btn_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(result_box.Text);
            lbl_operation.Text = System.Convert.ToString("log" + "(" + result_box.Text + ")");
            log = Math.Log(log);
            result_box.Text = System.Convert.ToString(log);
        }
    }
}
