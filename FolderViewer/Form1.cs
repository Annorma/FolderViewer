using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Clear();
                LoadDirectories(folderBrowser.SelectedPath, treeView1.Nodes);
            }
        }

        void LoadDirectories(string rootPath, TreeNodeCollection nodes)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(rootPath);

                foreach (var d in dir.GetDirectories())
                {
                    //if (d.Attributes.HasFlag(FileAttributes.Hidden | FileAttributes.System))
                    //    continue;

                    TreeNode node = new TreeNode(d.Name)
                    {
                        ImageIndex = 0,
                        SelectedImageIndex = 1,
                        Tag = d.FullName
                    };
                    nodes.Add(node);

                    try
                    {
                        if (d.GetDirectories().Any())
                        {
                            LoadDirectories(d.FullName, node.Nodes);
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }
        
        private void LoadFilesToListBox(string dirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            listBox1.Items.Clear();
            //var fileData = dir.GetFiles().Select(f => f.Name). + dir.GetFiles().Select(f => f.CreationTime);
            listBox1.Items.AddRange(dir.GetFiles().Select(f => f.Name).ToArray());
            //dir.GetFiles().SelectMany(f => f.Name).ToArray();
            //listBox1.Items.AddRange();
        }

        private void LoadFilesToTextBox(string dirPath)
        {
            //textBox1.Clear();
            listBox2.Items.Clear();
            string newDirPath = dirPath + @"\" + listBox1.SelectedItem.ToString();
            DirectoryInfo dir = new DirectoryInfo(newDirPath);
            List<string> list = new List<string>();
            list.Add($"Full Name: {dir.FullName}");
            list.Add($"Name: {dir.Name}");
            list.Add($"Creation Time: {dir.CreationTime.ToString()}");
            list.Add($"Last Write Time: {dir.LastWriteTime.ToString()}");
            list.Add($"Last Access Time: {dir.LastAccessTime.ToString()}");
            //string info = $"Full Name: {dir.FullName}\nName: {dir.Name}\nCreation Time: {dir.CreationTime.ToString()}\nLast Write Time: {dir.LastWriteTime.ToString()}\nLast Access Time: {dir.LastAccessTime.ToString()}";
            foreach (var item in list)
            {
                listBox2.Items.Add(item);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(treeView1.SelectedNode.Tag?.ToString());
            LoadFilesToListBox(treeView1.SelectedNode.Tag?.ToString());
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadFilesToTextBox(treeView1.SelectedNode.Tag?.ToString());
        }
    }
}
