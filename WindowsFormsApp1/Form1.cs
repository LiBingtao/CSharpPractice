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
using Account;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Accounts accounts;
        private string fileName = "MyAccountData.txt";
        public Form1()
        {
            InitializeComponent();
            accounts = new Accounts();
            
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string line;
                while((line = streamReader.ReadLine()) != null)
                {
                    var infos = line.Split(';');
                    var amount = double.Parse(infos[0]);
                    var content = infos[1];
                    var note = infos[2];
                    var category = infos[3] == "Spending" ? Category.Spending : Category.Income;
                    var name = infos[4];
                    var time = DateTime.Parse(infos[5]);
                    var account = new AccountItem(name, category, content, note, amount, time);
                    accounts.Add(account);
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var amount = double.Parse(amountBox.Text);
            var content = contentBox.Text;
            var note = noteBox.Text;
            var category = (categoryBox.Text == "Spending") ? Category.Spending : Category.Income;
            var name = nameBox.Text;
            var time = DateTime.Now;
            var account = new AccountItem(name, category, content, note, amount, time);
            accounts.Add(account);
            using (StreamWriter streamWriter = new StreamWriter(fileName, true))
            {
                string line = $"{amount.ToString()};{content};{note};{category.ToString()};{name};{time.ToString()}";
                streamWriter.WriteLine(line);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            var info = accounts.DisplayTotalIncome(DateTime.Now);
            infoBox.Text = info;
        }

        private void expenditureButton_Click(object sender, EventArgs e)
        {
            var info = accounts.DisplayTotalExpenditure(DateTime.Now);
            infoBox.Text = info;
        }

        private void revenueButton_Click(object sender, EventArgs e)
        {
            var info = accounts.DisplayTotalRevenue(DateTime.Now);
            infoBox.Text = info;
        }
    }
}
