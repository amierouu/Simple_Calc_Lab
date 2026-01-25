using System.Data;

namespace Simple_Calc_Lab
{
    public partial class Calc_Mod : Form
    {
        public Calc_Mod()
        {
            InitializeComponent();
        }

        private void AppendToCalcString(object sender, EventArgs e)
        {
            Button pressedBtn = sender as Button;
            if (pressedBtn != null)
            {
                string btnText = pressedBtn.Text;

                if (btnText == ".")
                {
                    string text = inpbx.Text;
                    int lastOperator = text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
                    string lastNumber = lastOperator >= 0 ? text.Substring(lastOperator + 1) : text;

                    if (lastNumber.Contains("."))
                    {
                        return;
                    }
                }

                if (inpbx.Text.Length >= 1)
                {
                    char lastChar = inpbx.Text[inpbx.Text.Length - 1];
                    if ("+-*/".Contains(btnText) && "+-*/".Contains(lastChar))
                    {
                        inpbx.Text = inpbx.Text.Substring(0, inpbx.Text.Length - 1);
                    }
                }

                if (inpbx.Text == "0" && btnText != ".")
                {
                    inpbx.Text = "";
                }
                inpbx.Text += pressedBtn.Text;
            }
        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            inpbx.Text = "0";
            resbx.Text = "";
        }

        private void btn_posneg_Click(object sender, EventArgs e)
        {
            if (inpbx.Text == "0" || inpbx.Text == "")
            {
                return;
            }

            string text = inpbx.Text;
            int lastOp = text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });

            string before = lastOp >= 0 ? text.Substring(0, lastOp + 1) : "";
            string currentNum = lastOp >= 0 ? text.Substring(lastOp + 1) : text;

            if (string.IsNullOrEmpty(currentNum) || currentNum == "0")
            {
                return;
            }

            if (currentNum.StartsWith("-"))
            {
                currentNum = currentNum.Substring(1);
            }
            else
            {
                currentNum = "-" + currentNum;
            }
            inpbx.Text = before + currentNum;
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            if (inpbx.Text.Length > 1)
            {
                inpbx.Text = inpbx.Text.Substring(0, inpbx.Text.Length - 1);
            }
            else
            {
                inpbx.Text = "0";
            }
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            string expression = inpbx.Text;
            var result = new DataTable();
            try
            {
                double evaluatedResult = Convert.ToDouble(result.Compute(expression, null));
                resbx.Text = evaluatedResult.ToString();
                if (double.IsInfinity(evaluatedResult) || double.IsNaN(evaluatedResult))
                {
                    MessageBox.Show("Error: Division by zero is not allowed.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inpbx.Text = "0";
                    resbx.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error: Invalid expression.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inpbx.Text = "0";
                resbx.Text = "";
            }
        }
    }
}
