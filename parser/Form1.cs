using parser.Core;
using parser.Core.Dota2ru;
using parser.Core.Habra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parser
{
    public partial class Form1 : Form
    {

        ParserWorker<string[]> parser;

        public Form1()
        {
            InitializeComponent();
            SelectCiteBox.SelectedIndex = 0;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            DateTime localDate = DateTime.Now;
            LastUpdateLbl.Text = localDate.ToString() + "\r\nCite: " + parser.Settings.BaseUrl;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            Parser_Initialize();

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;                       
            ListTitles.Items.Clear();         
            parser.Start();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            //parser.Abort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Parser_Initialize()
        {
            switch (SelectCiteBox.SelectedIndex)
            {
                case 0:
                    InitializeHabraParser();
                    break;

                case 1:
                    InitializeDota2ruParser();
                    break;

            }
        }

        private void InitializeHabraParser()
        {
            parser = new ParserWorker<string[]>(new HabraParser());
            parser.Settings = new HabraSettings((int)NumericStart.Value, (int)NumericEnd.Value);
        }

        private void InitializeDota2ruParser()
        {
            parser = new ParserWorker<string[]>(new Dota2ruParser());
            parser.Settings = new Dota2ruSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
