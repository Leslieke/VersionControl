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
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {

        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.FullName;  
            btnAdd.Text = Resource1.Add;
            btnFajlba.Text = Resource1.Fajlba;
            btnDelete.Text = Resource1.Delete;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtLastName.Text
                
            };
            users.Add(u);
        }

        private void btnFajlba_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Adatok.txt"))
            {
                foreach (var item in listUsers.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            users.Remove((User)listUsers.SelectedItem);
        }
    }
}
