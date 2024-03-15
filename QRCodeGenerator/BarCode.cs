using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Zen.Barcode;

namespace QRCodeGenerator
{
    public partial class BarCode : Form
    {
        public BarCode()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(richTextBox1.Text, 70);
        }

        private void btnVariableBarCode_Click(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            string QRString = $"Name: {txtName.Text} and PhonNo: {txtNo.Text}";
            pictureBox1.Image = qrcode.Draw(QRString, 70);
        }
    }
}
