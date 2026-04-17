using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiAIFinancialSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using System;
            using System.Windows.Forms;

namespace TaxiAIFinancialSystem
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnEvaluate_Click(object sender, EventArgs e)
            {
                double cashUp, diesel, rankFee, maintenance;

                // Validate inputs
                if (!double.TryParse(txtCashUp.Text, out cashUp) ||
                    !double.TryParse(txtDiesel.Text, out diesel) ||
                    !double.TryParse(txtRankFee.Text, out rankFee) ||
                    !double.TryParse(txtMaintenance.Text, out maintenance))
                {
                    MessageBox.Show("Please enter valid numeric values in all fields.",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate profit
                double profit = cashUp - (diesel + rankFee + maintenance);
                txtProfit.Text = profit.ToString("F2");

                // Clear previous insights
                rtbInsights.Clear();

                // Rule-based AI logic (Knowledge Representation)
                if (cashUp < 3000)
                {
                    rtbInsights.AppendText("Low Revenue Warning\n");
                }

                if (diesel > 1000)
                {
                    rtbInsights.AppendText("High Diesel Cost Alert\n");
                }

                if (profit < 2000)
                {
                    rtbInsights.AppendText("Low Profit Warning\n");
                }

                if (profit > 3000)
                {
                    rtbInsights.AppendText("High Profit Day\n");
                }

                if (rtbInsights.Text == "")
                {
                    rtbInsights.Text = "Financial performance is within normal range.";
                }
            }
        }
    }
    private void btnClear_Click(object sender, EventArgs e)
    {
        txtCashUp.Clear();
        txtDiesel.Clear();
        txtRankFee.Clear();
        txtMaintenance.Clear();
        txtProfit.Clear();
        rtbInsights.Clear();
        txtCashUp.Focus();
    }
}