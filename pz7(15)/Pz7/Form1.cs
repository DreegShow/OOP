using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace Pz7
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();
        private string filePath = "dictionary.txt";

        public Form1()
        {
            InitializeComponent();
            LoadDictionaryFromFile();
            foreach (var pair in dictionary)
            {
                lstDictionary.Items.Add($"{pair.Key} - {pair.Value}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*InitializeComponent();*/
            //LoadDictionaryFromFile();
        }
       

        private void LoadDictionaryFromFile()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string word = parts[0].Trim();
                        string translation = parts[1].Trim();
                        dictionary[word] = translation;
                    }
                }
            }
        }

        private void SaveDictionaryToFile()
        {
            List<string> lines = new List<string>();
            foreach (var pair in dictionary)
            {
                lines.Add($"{pair.Key}: {pair.Value}");
            }
            File.WriteAllLines(filePath, lines);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim();
            string translation = txtTrnslation.Text.Trim();
            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(translation))
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = translation;
                    lstDictionary.Items.Add($"{word} - {translation}");
                    txtWord.Clear();
                    txtTrnslation.Clear();
                }
                else
                {
                    MessageBox.Show("Це слово вже існує в словнику.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть слово та його переклад.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDictionaryToFile(); 
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrnslation_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}