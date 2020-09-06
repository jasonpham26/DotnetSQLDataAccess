using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DataSource = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            
            people =  db.GetPeople(lastNameText.Text);
            UpdateBinding();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertPerson(FirstNameInsText.Text, LastNameInsText.Text, 
                            EmailInsText.Text, PhoneNumberInsText.Text);

            FirstNameInsText.Text = "";
            LastNameInsText.Text = "";
            EmailInsText.Text = "";
            PhoneNumberInsText.Text = "";

        }
    }
}
