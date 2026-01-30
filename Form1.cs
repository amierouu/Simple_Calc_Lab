using System.Data;

namespace Simple_Calc_Lab
{
    public partial class Calc_Mod : Form
    {
        private System.Windows.Forms.Timer historyShowTimer; // History Animation
        private int historyTargetWidth = 200; // Width
        private int historyAnimationStep = 20; // Pixels per timer tick

        private void InitializeHistoryAnimation()
        {
            // Set up the ListBox for animation
            historyListBox.Visible = false;
            historyListBox.Width = 0;

            // Set up the timer
            historyShowTimer = new System.Windows.Forms.Timer();
            historyShowTimer.Interval = 15; // ms, adjust for speed
            historyShowTimer.Tick += HistoryShowTimer_Tick;
        }
        public Calc_Mod()
        {
            InitializeComponent();
            InitializeHistoryAnimation();
        }

        private void AppendToCalcString(object sender, EventArgs e)
        {
            Button pressedBtn = sender as Button;
            if (pressedBtn != null)
            {
                string btnText = pressedBtn.Text;

                if (btnText == ")")
                {
                    int openCount = inpbx.Text.Count(c => c == '(');
                    int closeCount = inpbx.Text.Count(c => c == ')');
                    if (closeCount >= openCount)
                    {
                        return;
                    }
                }

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
            string text = inpbx.Text;

            // If empty -> start a negative number
            if (string.IsNullOrEmpty(text))
            {
                inpbx.Text = "-";
                return;
            }

            // If the expression currently ends with an operator, append a unary minus
            char lastChar = text[text.Length - 1];
            if ("+-*/".Contains(lastChar))
            {
                // Prevent "--"
                if (lastChar == '-') return;
                inpbx.Text = text + "-";
                return;
            }

            // Find start index of the last numeric token (digits and decimal)
            int i = text.Length - 1;
            while (i >= 0 && (char.IsDigit(text[i]) || text[i] == '.'))
                i--;
            int start = i + 1;

            // If there's a unary '-' immediately before the digits and it's a unary (start of text or after operator),
            // include it as part of the number.
            if (start - 1 >= 0 && text[start - 1] == '-')
            {
                if (start - 2 < 0 || "+-*/".Contains(text[start - 2]))
                {
                    start = start - 1;
                }
            }

            string before = text.Substring(0, start);
            string number = text.Substring(start);

            if (string.IsNullOrEmpty(number))
            {
                // nothing to toggle; allow starting a negative number
                inpbx.Text = text + "-";
                return;
            }

            if (number.StartsWith("-"))
                number = number.Substring(1); // remove unary minus
            else
                number = "-" + number; // add unary minus

            inpbx.Text = before + number;
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
            string expression = PreprocessExpression(inpbx.Text);
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
                else
                {
                    historyListBox.Items.Add($"{expression} = {evaluatedResult}");
                }
            }
            catch
            {
                MessageBox.Show("Error: Invalid expression.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inpbx.Text = "0";
                resbx.Text = "";
            }
        }

        private void historyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            if (!historyListBox.Visible)
            {
                historyListBox.Width = 0;
                historyListBox.Visible = true;
                label_history.Visible = true;
                label_history.Text = "History";
                historyShowTimer.Start();
            }
            else
            {
                // Hiding Animation
                historyShowTimer.Tick -= HistoryShowTimer_Tick;
                historyShowTimer.Tick += HistoryHideTimer_Tick;
                historyShowTimer.Start();
            }
        }
        // Animation for showing
        private void HistoryShowTimer_Tick(object sender, EventArgs e)
        {
            if (historyListBox.Width < historyTargetWidth)
            {
                historyListBox.Width += historyAnimationStep;
                label_history.Width = historyAnimationStep;
                if (historyListBox.Width > historyTargetWidth)
                {
                    historyListBox.Width = historyTargetWidth;
                    label_history.Width = historyTargetWidth;
                }
            }
            else
            {
                historyShowTimer.Stop();
                historyShowTimer.Tick -= HistoryShowTimer_Tick;
            }
        }

        // Animation for hiding
        private void HistoryHideTimer_Tick(object sender, EventArgs e)
        {
            if (historyListBox.Width > 0)
            {
                historyListBox.Width -= historyAnimationStep;
                label_history.Width = historyAnimationStep;
                if (historyListBox.Width < 0)
                {
                    historyListBox.Width = 0;
                    label_history.Width = 0;
                }
            }
            else
            {
                historyShowTimer.Stop();
                historyListBox.Visible = false;
                label_history.Visible = false;
                historyShowTimer.Tick -= HistoryHideTimer_Tick;
                historyShowTimer.Tick += HistoryShowTimer_Tick;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            string text = inpbx.Text;
            int lastOp = text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });

            string before = lastOp >= 0 ? text.Substring(0, lastOp + 1) : "";
            string currentNum = lastOp >= 0 ? text.Substring(lastOp + 1) : text;

            if (double.TryParse(currentNum, out double num))
            {
                double percentValue = num / 100.0;
                inpbx.Text = before + percentValue.ToString();
            }
        }

        private string PreprocessExpression(string expression)
        {
            // Handle square roots: replace √number with the computed value
            expression = System.Text.RegularExpressions.Regex.Replace(
                expression, @"√(\d+(\.\d+)?)", match =>
                {
                    double val = double.Parse(match.Groups[1].Value);
                    return Math.Sqrt(val).ToString();
                });

            // Handle powers: replace a^b with the computed value
            expression = System.Text.RegularExpressions.Regex.Replace(
                expression, @"(\d+(\.\d+)?)\^(\d+(\.\d+)?)", match =>
                {
                    double baseVal = double.Parse(match.Groups[1].Value);
                    double expVal = double.Parse(match.Groups[3].Value);
                    return Math.Pow(baseVal, expVal).ToString();
                });

            return expression;
        }
    }
}
