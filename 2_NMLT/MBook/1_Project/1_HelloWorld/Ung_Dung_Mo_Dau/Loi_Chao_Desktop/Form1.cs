using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loi_Chao_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dongy.Click += (Th, Ts) =>
             {
                 var Ho_Ten = Th_Ho_Ten.Text;
                 var Loi_Chao = "Xin Chào " + Ho_Ten + "\n"
                    + "Đây là chương trình C# đầu tiên của tui";

                 Th_Loi_Chao.Text = Loi_Chao;

             };
        }
    }
}
