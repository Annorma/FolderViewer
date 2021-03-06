using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeViewExample
{
    public partial class Form1 : Form
    {
        TreeView tree;// программно добавляемое дерево
        ImageList galery;
        ListBox lb1;
        public Form1()
        {
            InitializeComponent();
            this.SetBounds(300, 300, 600, 600);
            // добавляем управляющий элемент 
            tree = new TreeView();
            this.Controls.Add(tree);
            tree.SetBounds(300, 30, 300, 400);

            // создаем узел
            TreeNode node1 = new TreeNode("Новый узел lvl-1");
            // добавляем к коллекции узлов
            tree.Nodes.Add(node1);

            try
            {
                // создаем и привязываем список изображений
                galery = new ImageList();
                tree.ImageList = galery;
                // увеличиваем размеры изображений
                galery.ImageSize = new Size(65, 100);
                // изменяем количество бит палитры
                galery.ColorDepth = ColorDepth.Depth24Bit;
                // добавляем изображения к списку

                Bitmap bmp = new Bitmap("bitmap13.bmp");
                galery.Images.Add(bmp);
                bmp = new Bitmap("bitmap14.bmp");
                galery.Images.Add(bmp);
                bmp = new Bitmap("bitmap15.bmp");
                galery.Images.Add(bmp);
                bmp = new Bitmap("bitmap16.bmp");
                galery.Images.Add(bmp);

                //  добавляем еще 1 узел
                node1 = new TreeNode("Изображение lvl-1", 1, 2);
                tree.Nodes.Add(node1);

                var subNode = new TreeNode("Изображение lvl-2", 3, 2);

                node1.Nodes.Add(subNode);

                subNode.Nodes.Add(new TreeNode("Изображение lvl-3", 1, 2));

                tree.Nodes.Add(new TreeNode("Изображение lvl-1", 3, 2));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //добавляем обработчик двойного щелчка
            tree.BeforeExpand += (s, e) => { MessageBox.Show("Before!"); };
            tree.AfterExpand += (s, e) => { MessageBox.Show("After!"); };
            tree.DoubleClick += new EventHandler(tree_DoubleClick);

            //добавляем листбокс
            lb1 = new ListBox();
            lb1.SetBounds(20, 250, 250, 300);
            this.Controls.Add(lb1);
            //обход дерева
            recurse_list(treeView1.Nodes, "");

        }
        private void tree_DoubleClick(object sender, EventArgs e)
        {
            TreeView tree = (TreeView)sender;
            // удаляем выбранный узел
            tree.Nodes.Remove(tree.SelectedNode);
        }
        private void recurse_list(TreeNodeCollection nodes, string QName)
        {
            foreach (TreeNode node in nodes)
            {
                // добавляем элемент к списку
                lb1.Items.Add(QName + node.Text);
                if (node.Nodes.Count > 0)
                    //добавляем все дочерние элементы к списку
                    recurse_list(node.Nodes, QName + node.Text + ":");
            }
        }
    }
}