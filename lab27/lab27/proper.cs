using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab27
{
    public partial class proper : Form
    {
        public proper()
        {
            InitializeComponent();
        }
        public DirectoryInfo direc;

        private void proper_Load(object sender, EventArgs e)
        {
            Name_txt.Text = direc.Name;
            Date_txt.Text = direc.CreationTime.ToString();
            DateAccess_txt.Text = direc.LastAccessTime.ToString();
            Format_txt.Text = direc.Extension == string.Empty ? "Каталог" : direc.Extension;
            Path_txt.Text = direc.FullName;
        }
    }
}
