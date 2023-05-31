using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory.FullName;
                node.Nodes.Add(new TreeNode());
                treeView1.Nodes.Add(node);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node.Nodes.Count == 1 && node.Nodes[0].Tag == null)
            {
                node.Nodes.Clear();

                string path = node.Tag.ToString();
                DirectoryInfo directory = new DirectoryInfo(path);
                try
                {
                    foreach (DirectoryInfo subdirectory in directory.GetDirectories())
                    {
                        TreeNode subnode = new TreeNode(subdirectory.Name);
                        subnode.Tag = subdirectory.FullName;
                        subnode.Nodes.Add(new TreeNode());
                        node.Nodes.Add(subnode);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Доступ обмежений.");
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    TreeNode subnode = new TreeNode(file.Name);
                    subnode.Tag = file.FullName;
                    node.Nodes.Add(subnode);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            DirectoryInfo directory = new DirectoryInfo(path);
            proper proper = new proper();
            proper.direc = directory;
            proper.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            DirectoryInfo directory = new DirectoryInfo(path);
            Atributes_txt.Text = directory.Attributes.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            DirectoryInfo directory = new DirectoryInfo(path);
            if(directory.Extension == ".txt")
            {
                try
                {
                    Process.Start("notepad.exe", path);
                }
                catch
                {
                    MessageBox.Show("Упс! щось пішло не так.");
                }
            }
            else
                MessageBox.Show("Потрібне ррозширення: txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            DirectoryInfo directory = new DirectoryInfo(path);
            if (directory.Extension == ".png" || directory.Extension == ".jpg")
            {
                try
                {
                    Process.Start("iexplore.exe", path);
                }
                catch
                {
                    MessageBox.Show("Упс! щось пішло не так.");
                }
            }
            else
                MessageBox.Show("Потрібне розширення: jpg та png");
        }
    }

}
