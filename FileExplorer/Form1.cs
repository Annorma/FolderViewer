using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // изменяем количество бит палитры
            galery.ColorDepth = ColorDepth.Depth32Bit;
            // добавляем изображения к списку
            Image img = Image.FromFile(@"..\..\folder.png"); // png
            galery.Images.Add(img);

            // папка, в якій знаходиться exe файл
            // Environment.CurrentDirectory;

            // системна папка (system32)
            // Environment.SystemDirectory;

            // ім'я поточного Windows користувача 
            // Environment.UserName;

            // шлях до користувацької папки Documents
            // Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
