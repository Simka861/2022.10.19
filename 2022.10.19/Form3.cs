using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022._10._19
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Флажок CheckBox";

            checkBox1.Text = "Полужирный"; checkBox1.Focus();
            label1.Text = "Выбери стиль шрифта";
            label1.TextAlign = ContentAlignment.BottomRight;
            label1.Font = new System.Drawing.Font("Courier New", 14.0F);
            var tabPage3 = new TabPage();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label1.Font = new Font("Courier New", 14.0F, FontStyle.Bold);
            if (checkBox1.Checked == false)
                label1.Font = new Font("Courier New", 14.0F, FontStyle.Regular);
        }
    }
}
