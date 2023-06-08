using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello INFIERNO!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReferenciaWeb.IService service = new ReferenciaWeb.ServiceClient();
            service.GetData(5);
            MessageBox.Show(service.GetData(5));
        }
    }
}
