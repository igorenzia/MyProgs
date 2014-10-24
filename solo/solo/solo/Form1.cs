using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace solo
{
    public partial class Form1 : Form
    {

        int total_symbols;
        int typed_symbols;
        DateTime startime;
        DateTime curenty_tame;
        int speed;
        string[] dict ;
        int i = 0;
        public bool Error;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

  
        private void Init()
        {
            dict = File.ReadAllLines("slova.txt");
            label5.Text = ""+ i+" / " + dict.Length ;
            lbl_text.Text = dict[0].ToLower();

            

        }

        private void txt_typed_KeyUp(object sender, KeyEventArgs e)
        {
            showStat();
        }

        
        private void showStat()
        {
            if (txt_typed.Text.Length >0)
            {
                if (lbl_text.Text.StartsWith(txt_typed.Text))
                {
                    Error = false;
                    
                }else
            {
                Error = true;
            }
               
            }

            txt_typed.BackColor = Error ? Color.Red : Color.White;

            if (lbl_text.Text.Length == txt_typed.Text.Length )
            {
                lbl_text.Text = txt_typed.Text = "";
                lbl_text.Text = dict[++i].ToLower();
                label5.Text = "" + i + " / " + dict.Length;

            }
            
        }

    }
}
