using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organism_Population_Predictor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            double startingNum;
            double dailyIncrease;
            int daysNum;

            double population;

            if(double.TryParse(tboxStartingNum.Text, out startingNum)
                && double.TryParse(tboxDailyIncrease.Text, out dailyIncrease)
                && int.TryParse(tboxNumDays.Text, out daysNum)) 
            {
                population = startingNum;

                lboxPredictionTable.Items.Add("At day 1: " + population);

                for(int i = 2; i <= daysNum; i++)
                {
                    population += population * dailyIncrease / 100;

                    lboxPredictionTable.Items.Add("At day " + i + ": "+ population);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxStartingNum.Text = "";
            tboxDailyIncrease.Text = "";
            tboxNumDays.Text = "";
            lboxPredictionTable.Items.Clear();

            tboxStartingNum.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
