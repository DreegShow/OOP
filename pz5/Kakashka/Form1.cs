using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kakashka
{
    public partial class Form1 : Form
    {
        private List<MenuItem> menuItems;
        private int currentItemIndex = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeMenuItems();
            ShowCurMenuItem();
        }

/*        private void InitializeMenuItems()
        {
            if (menuItems == null) {  menuItems = new List<MenuItem>(); }
            menuItems = new List<MenuItem>
            {
                new MenuItem("12312", 123, Properties.Resources.Koza),
            };
        }*/

        private void InitializeMenuItems()
        {
            menuItems = new List<MenuItem>
            {
                new MenuItem("Смажена коза", 105, Properties.Resources.Koza),
                new MenuItem("якась фігня", 24, Properties.Resources.SCI),
                new MenuItem("квадрат Малєвіча", 9999, Properties.Resources.WallPaper)
            };
        }

        private void ShowCurMenuItem()
        {
            MenuItem currentItem = menuItems[currentItemIndex];
            label1.Text = currentItem.Name;
            label2.Text = $"цена: {currentItem.Price} грн";
            pictureBox1.Image = currentItem.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentItemIndex = (currentItemIndex - 1 + menuItems.Count) % menuItems.Count;
            ShowCurMenuItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentItemIndex = (currentItemIndex + 1) % menuItems.Count;
            ShowCurMenuItem();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("1211496");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ресторант";
        }

    }

    public class MenuItem
    {
        public string Name { get; }
        public decimal Price { get; }
        public Image Image { get; }


        public MenuItem(string name, decimal price, Image image)
        {
            Name = name;
            Price = price;
            Image = image;
        }
    }
}