using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTConnectStepNCConverter
{
    public partial class MainWindow : Form
    {
        String mtconnectData;
        String writeLocationPath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void browseForMTConnectFile(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            mtconnectData = new System.IO.StreamReader(openFileDialog1.OpenFile()).ReadToEnd();
            input_field.Text = openFileDialog1.FileName;
        }

        private void browseForSteoNCOutput(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            writeLocationPath = saveFileDialog1.FileName;
            output_field.Text = saveFileDialog1.FileName;
        }
    }
}
