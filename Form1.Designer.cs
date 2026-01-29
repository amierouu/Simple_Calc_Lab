namespace Simple_Calc_Lab
{
    partial class Calc_Mod
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inpbx = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btn_canc = new Button();
            btn_dec = new Button();
            btn_pls = new Button();
            btn_min = new Button();
            btn_mult = new Button();
            btn_posneg = new Button();
            btn_erase = new Button();
            btn_div = new Button();
            btnres = new Button();
            resbx = new TextBox();
            btnShowHistory = new Button();
            historyListBox = new ListBox();
            label_history = new Label();
            btnSqrt = new Button();
            btnPower = new Button();
            btnPercent = new Button();
            btnOpenParen = new Button();
            btnCloseParen = new Button();
            SuspendLayout();
            // 
            // inpbx
            // 
            inpbx.BackColor = Color.FromArgb(45, 45, 45);
            inpbx.BorderStyle = BorderStyle.None;
            inpbx.Enabled = false;
            inpbx.Font = new Font("Gadugi", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inpbx.ForeColor = Color.White;
            inpbx.Location = new Point(9, 58);
            inpbx.Name = "inpbx";
            inpbx.Size = new Size(338, 39);
            inpbx.TabIndex = 0;
            inpbx.Text = "0";
            inpbx.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(45, 45, 45);
            btn7.BackgroundImageLayout = ImageLayout.None;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(9, 240);
            btn7.Margin = new Padding(0);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 60);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += AppendToCalcString;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(45, 45, 45);
            btn8.BackgroundImageLayout = ImageLayout.None;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(74, 240);
            btn8.Margin = new Padding(0);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 60);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += AppendToCalcString;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(45, 45, 45);
            btn9.BackgroundImageLayout = ImageLayout.None;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(139, 240);
            btn9.Margin = new Padding(0);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 60);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += AppendToCalcString;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(45, 45, 45);
            btn4.BackgroundImageLayout = ImageLayout.None;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(9, 310);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 60);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += AppendToCalcString;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(45, 45, 45);
            btn5.BackgroundImageLayout = ImageLayout.None;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(74, 310);
            btn5.Margin = new Padding(0);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 60);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += AppendToCalcString;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(45, 45, 45);
            btn6.BackgroundImageLayout = ImageLayout.None;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(139, 310);
            btn6.Margin = new Padding(0);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 60);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += AppendToCalcString;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(45, 45, 45);
            btn1.BackgroundImageLayout = ImageLayout.None;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(9, 380);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 60);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += AppendToCalcString;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(45, 45, 45);
            btn2.BackgroundImageLayout = ImageLayout.None;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(74, 380);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 60);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += AppendToCalcString;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(45, 45, 45);
            btn3.BackgroundImageLayout = ImageLayout.None;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(139, 380);
            btn3.Margin = new Padding(0);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 60);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += AppendToCalcString;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(45, 45, 45);
            btn0.BackgroundImageLayout = ImageLayout.None;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(74, 450);
            btn0.Margin = new Padding(0);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 60);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += AppendToCalcString;
            // 
            // btn_canc
            // 
            btn_canc.BackColor = Color.FromArgb(45, 45, 45);
            btn_canc.BackgroundImageLayout = ImageLayout.None;
            btn_canc.FlatStyle = FlatStyle.Popup;
            btn_canc.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn_canc.ForeColor = Color.White;
            btn_canc.Location = new Point(9, 450);
            btn_canc.Margin = new Padding(0);
            btn_canc.Name = "btn_canc";
            btn_canc.Size = new Size(60, 60);
            btn_canc.TabIndex = 11;
            btn_canc.Text = "C";
            btn_canc.UseVisualStyleBackColor = false;
            btn_canc.Click += btn_canc_Click;
            // 
            // btn_dec
            // 
            btn_dec.BackColor = Color.FromArgb(45, 45, 45);
            btn_dec.BackgroundImageLayout = ImageLayout.None;
            btn_dec.FlatStyle = FlatStyle.Popup;
            btn_dec.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn_dec.ForeColor = Color.White;
            btn_dec.Location = new Point(139, 450);
            btn_dec.Margin = new Padding(0);
            btn_dec.Name = "btn_dec";
            btn_dec.Size = new Size(60, 60);
            btn_dec.TabIndex = 12;
            btn_dec.Text = ".";
            btn_dec.UseVisualStyleBackColor = false;
            btn_dec.Click += AppendToCalcString;
            // 
            // btn_pls
            // 
            btn_pls.BackColor = Color.FromArgb(45, 45, 45);
            btn_pls.BackgroundImageLayout = ImageLayout.None;
            btn_pls.FlatStyle = FlatStyle.Popup;
            btn_pls.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn_pls.ForeColor = Color.White;
            btn_pls.Location = new Point(222, 450);
            btn_pls.Margin = new Padding(0);
            btn_pls.Name = "btn_pls";
            btn_pls.Size = new Size(60, 60);
            btn_pls.TabIndex = 13;
            btn_pls.Text = "+";
            btn_pls.UseVisualStyleBackColor = false;
            btn_pls.Click += AppendToCalcString;
            // 
            // btn_min
            // 
            btn_min.BackColor = Color.FromArgb(45, 45, 45);
            btn_min.BackgroundImageLayout = ImageLayout.None;
            btn_min.FlatStyle = FlatStyle.Popup;
            btn_min.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn_min.ForeColor = Color.White;
            btn_min.Location = new Point(222, 380);
            btn_min.Margin = new Padding(0);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(60, 60);
            btn_min.TabIndex = 14;
            btn_min.Text = "-";
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += AppendToCalcString;
            // 
            // btn_mult
            // 
            btn_mult.BackColor = Color.FromArgb(45, 45, 45);
            btn_mult.BackgroundImageLayout = ImageLayout.None;
            btn_mult.FlatStyle = FlatStyle.Popup;
            btn_mult.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn_mult.ForeColor = Color.White;
            btn_mult.Location = new Point(222, 310);
            btn_mult.Margin = new Padding(0);
            btn_mult.Name = "btn_mult";
            btn_mult.Size = new Size(60, 60);
            btn_mult.TabIndex = 15;
            btn_mult.Text = "*";
            btn_mult.UseVisualStyleBackColor = false;
            btn_mult.Click += AppendToCalcString;
            // 
            // btn_posneg
            // 
            btn_posneg.BackColor = Color.FromArgb(45, 45, 45);
            btn_posneg.BackgroundImageLayout = ImageLayout.None;
            btn_posneg.FlatStyle = FlatStyle.Popup;
            btn_posneg.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn_posneg.ForeColor = Color.White;
            btn_posneg.Location = new Point(222, 240);
            btn_posneg.Margin = new Padding(0);
            btn_posneg.Name = "btn_posneg";
            btn_posneg.Size = new Size(60, 60);
            btn_posneg.TabIndex = 16;
            btn_posneg.Text = "+/-";
            btn_posneg.UseVisualStyleBackColor = false;
            btn_posneg.Click += btn_posneg_Click;
            // 
            // btn_erase
            // 
            btn_erase.BackColor = Color.FromArgb(45, 45, 45);
            btn_erase.BackgroundImageLayout = ImageLayout.None;
            btn_erase.FlatStyle = FlatStyle.Popup;
            btn_erase.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn_erase.ForeColor = Color.White;
            btn_erase.Location = new Point(287, 240);
            btn_erase.Margin = new Padding(0);
            btn_erase.Name = "btn_erase";
            btn_erase.Size = new Size(60, 60);
            btn_erase.TabIndex = 17;
            btn_erase.Text = "→";
            btn_erase.UseVisualStyleBackColor = false;
            btn_erase.Click += btn_erase_Click;
            // 
            // btn_div
            // 
            btn_div.BackColor = Color.FromArgb(45, 45, 45);
            btn_div.BackgroundImageLayout = ImageLayout.None;
            btn_div.FlatStyle = FlatStyle.Popup;
            btn_div.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btn_div.ForeColor = Color.White;
            btn_div.Location = new Point(287, 310);
            btn_div.Margin = new Padding(0);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(60, 60);
            btn_div.TabIndex = 18;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = false;
            btn_div.Click += AppendToCalcString;
            // 
            // btnres
            // 
            btnres.BackColor = Color.FromArgb(45, 45, 45);
            btnres.BackgroundImageLayout = ImageLayout.None;
            btnres.FlatStyle = FlatStyle.Popup;
            btnres.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnres.ForeColor = Color.White;
            btnres.Location = new Point(287, 380);
            btnres.Margin = new Padding(0);
            btnres.Name = "btnres";
            btnres.Size = new Size(60, 130);
            btnres.TabIndex = 19;
            btnres.Text = "=";
            btnres.UseVisualStyleBackColor = false;
            btnres.Click += btnres_Click;
            // 
            // resbx
            // 
            resbx.BackColor = Color.FromArgb(45, 45, 45);
            resbx.BorderStyle = BorderStyle.None;
            resbx.Enabled = false;
            resbx.Font = new Font("Gadugi", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resbx.Location = new Point(9, 97);
            resbx.Name = "resbx";
            resbx.Size = new Size(338, 39);
            resbx.TabIndex = 20;
            resbx.TextAlign = HorizontalAlignment.Right;
            // 
            // btnShowHistory
            // 
            btnShowHistory.BackgroundImage = Properties.Resources.historique_icone_de_l_historique_gris;
            btnShowHistory.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowHistory.FlatStyle = FlatStyle.Flat;
            btnShowHistory.ForeColor = Color.FromArgb(32, 32, 32);
            btnShowHistory.ImageAlign = ContentAlignment.TopCenter;
            btnShowHistory.Location = new Point(307, 12);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(40, 40);
            btnShowHistory.TabIndex = 21;
            btnShowHistory.UseVisualStyleBackColor = true;
            btnShowHistory.Click += btnShowHistory_Click;
            // 
            // historyListBox
            // 
            historyListBox.BackColor = Color.FromArgb(32, 32, 32);
            historyListBox.BorderStyle = BorderStyle.None;
            historyListBox.ForeColor = Color.White;
            historyListBox.FormattingEnabled = true;
            historyListBox.Location = new Point(-1, 37);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(220, 475);
            historyListBox.TabIndex = 22;
            historyListBox.Visible = false;
            // 
            // label_history
            // 
            label_history.AutoSize = true;
            label_history.ForeColor = Color.White;
            label_history.Location = new Point(10, 15);
            label_history.Name = "label_history";
            label_history.Size = new Size(59, 19);
            label_history.TabIndex = 23;
            label_history.Text = "History";
            label_history.Visible = false;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.FromArgb(45, 45, 45);
            btnSqrt.BackgroundImageLayout = ImageLayout.None;
            btnSqrt.FlatStyle = FlatStyle.Popup;
            btnSqrt.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnSqrt.ForeColor = Color.White;
            btnSqrt.Location = new Point(9, 170);
            btnSqrt.Margin = new Padding(0);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(60, 60);
            btnSqrt.TabIndex = 24;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += AppendToCalcString;
            // 
            // btnPower
            // 
            btnPower.BackColor = Color.FromArgb(45, 45, 45);
            btnPower.BackgroundImageLayout = ImageLayout.None;
            btnPower.FlatStyle = FlatStyle.Popup;
            btnPower.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnPower.ForeColor = Color.White;
            btnPower.Location = new Point(74, 170);
            btnPower.Margin = new Padding(0);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(60, 60);
            btnPower.TabIndex = 25;
            btnPower.Text = "^";
            btnPower.UseVisualStyleBackColor = false;
            btnPower.Click += AppendToCalcString;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.FromArgb(45, 45, 45);
            btnPercent.BackgroundImageLayout = ImageLayout.None;
            btnPercent.FlatStyle = FlatStyle.Popup;
            btnPercent.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnPercent.ForeColor = Color.White;
            btnPercent.Location = new Point(139, 170);
            btnPercent.Margin = new Padding(0);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(60, 60);
            btnPercent.TabIndex = 26;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnOpenParen
            // 
            btnOpenParen.BackColor = Color.FromArgb(45, 45, 45);
            btnOpenParen.BackgroundImageLayout = ImageLayout.None;
            btnOpenParen.FlatStyle = FlatStyle.Popup;
            btnOpenParen.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnOpenParen.ForeColor = Color.White;
            btnOpenParen.Location = new Point(222, 170);
            btnOpenParen.Margin = new Padding(0);
            btnOpenParen.Name = "btnOpenParen";
            btnOpenParen.Size = new Size(60, 60);
            btnOpenParen.TabIndex = 27;
            btnOpenParen.Text = "(";
            btnOpenParen.UseVisualStyleBackColor = false;
            btnOpenParen.Click += AppendToCalcString;
            // 
            // btnCloseParen
            // 
            btnCloseParen.BackColor = Color.FromArgb(45, 45, 45);
            btnCloseParen.BackgroundImageLayout = ImageLayout.None;
            btnCloseParen.FlatStyle = FlatStyle.Popup;
            btnCloseParen.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnCloseParen.ForeColor = Color.White;
            btnCloseParen.Location = new Point(287, 170);
            btnCloseParen.Margin = new Padding(0);
            btnCloseParen.Name = "btnCloseParen";
            btnCloseParen.Size = new Size(60, 60);
            btnCloseParen.TabIndex = 28;
            btnCloseParen.Text = ")";
            btnCloseParen.UseVisualStyleBackColor = false;
            btnCloseParen.Click += AppendToCalcString;
            // 
            // Calc_Mod
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(359, 519);
            Controls.Add(historyListBox);
            Controls.Add(btnCloseParen);
            Controls.Add(btnOpenParen);
            Controls.Add(btnPercent);
            Controls.Add(btnPower);
            Controls.Add(btnSqrt);
            Controls.Add(label_history);
            Controls.Add(btnShowHistory);
            Controls.Add(resbx);
            Controls.Add(btnres);
            Controls.Add(btn_div);
            Controls.Add(btn_erase);
            Controls.Add(btn_posneg);
            Controls.Add(btn_mult);
            Controls.Add(btn_min);
            Controls.Add(btn_pls);
            Controls.Add(btn_dec);
            Controls.Add(btn_canc);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(inpbx);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Calc_Mod";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inpbx;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btn_canc;
        private Button btn_dec;
        private Button btn_pls;
        private Button btn_min;
        private Button btn_mult;
        private Button btn_posneg;
        private Button btn_erase;
        private Button btn_div;
        private Button btnres;
        private TextBox resbx;
        private Button btnShowHistory;
        private ListBox historyListBox;
        private Label label_history;
        private Button btnSqrt;
        private Button btnPower;
        private Button btnPercent;
        private Button btnOpenParen;
        private Button btnCloseParen;
    }
}
