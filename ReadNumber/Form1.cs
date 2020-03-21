using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] Tens = { "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };

            int so = int.Parse(textSo.Text);
            string strWords = "";

            if(so>999 && so < 10000)
            {
                int i= so/ 1000;
                strWords = strWords + Ones[i - 1] + " Ngàn ";
                so = so % 1000;
            }
            if(so>100 && so < 999)
            {
                int i = so / 100;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                so = so % 100;
            }
            if (so>19 && so <100)
            {
                int i = so / 10;
                strWords = strWords + Tens[i - 1] + " Mươi ";
                so = so % 10;
            }
            if (so > 0 && so < 20)
            {
                strWords = strWords + Ones[so - 1] ;   
            }
            textChu.Text = strWords;

        }
    }
}
