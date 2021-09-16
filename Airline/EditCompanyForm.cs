using Airline.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class EditCompanyForm : Form
    {
        #region Attributes
        private const string ConnectionString = "Data Source=database.db";
        private readonly List<Company> _companies;
        private Company _company;
        #endregion

        public EditCompanyForm()
        {
            InitializeComponent();
            _companies = new List<Company>();
        }

        #region Methods
        private void DisplayCompanies()
        {
            lvCompanies.Items.Clear();

            foreach (Company company in _companies)
            {
                var listViewItem = new ListViewItem(company.CompanyCode);
                listViewItem.SubItems.Add(company.Name);
                listViewItem.SubItems.Add(company.Address);
                listViewItem.SubItems.Add(company.ContactPerson);
                listViewItem.SubItems.Add(company.ContactPhone);

                listViewItem.Tag = company;

                lvCompanies.Items.Add(listViewItem);
            }
        }

        private void LoadCompanies()
        {
            const string stringSql = "SELECT * FROM Company";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["ID"];
                        string code = (string)sqlReader["Code"];
                        string name = (string)sqlReader["Name"];
                        string addr = (string)sqlReader["Address"];
                        string contact = (string)sqlReader["Contact"];
                        string phone = (string)sqlReader["Phone"];
                        

                        Company company = new Company(id, code, name, addr,contact, phone);
                        _companies.Add(company);
                    }
                }
            }
        }

        private bool IsFieldValid(TextBox tb)
        {
            return !string.IsNullOrWhiteSpace(tb.Text.Trim());
        }
        #endregion

        #region Events
        private void EditCompanyForm_Load(object sender, EventArgs e)
        {
            LoadCompanies();
            DisplayCompanies();
        }

        private void btnSaveCo_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                
                MessageBox.Show("The form contains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            try
            {
                _company.CompanyCode = tbCoCode.Text;
                _company.Name = tbCoName.Text;
                _company.Address = tbCoAddress.Text;
                _company.ContactPerson = tbCoContact.Text;
                _company.ContactPhone = tbCoPhone.Text;

                const string queryString = "UPDATE Company SET Code=@coCode, Name=@coName, Address=@coAddress, Contact=@coContact, Phone=@coPhone  WHERE ID = @coId";

                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {

                    var command = new SQLiteCommand(queryString, connection);

                    command.Parameters.AddWithValue("@coCode", _company.CompanyCode);
                    command.Parameters.AddWithValue("@coName", _company.Name);
                    command.Parameters.AddWithValue("@coAddress", _company.Address);
                    command.Parameters.AddWithValue("@coContact", _company.ContactPerson);
                    command.Parameters.AddWithValue("@coPhone", _company.ContactPhone);
                    command.Parameters.AddWithValue("@coId", _company.Id);

                    connection.Open();

                    command.ExecuteNonQuery();

                    DisplayCompanies();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception encountered:" + ex.Message);
            }
            

        }

        private void btnDeleteCo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {            
                const string stringSql = "DELETE FROM Company WHERE Id=@id";

                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                
                    SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                    command.Parameters.AddWithValue("@id", _company.Id);

                    command.ExecuteNonQuery();

                
                    _companies.Remove(_company);

                    DisplayCompanies();
                }
            }
        }

        private void lvCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(grpCoDetails.Enabled == false)
                grpCoDetails.Enabled = true;

            var last = lvCompanies.SelectedItems.Count;
            if (last >= 1)
            {
                _company = (Company)lvCompanies.SelectedItems[last - 1].Tag;
                tbCoCode.Text = _company.CompanyCode;
                tbCoName.Text = _company.Name;
                tbCoAddress.Text = _company.Address;
                tbCoContact.Text = _company.ContactPerson;
                tbCoPhone.Text = _company.ContactPhone;
            }
        }

        #region ErrorHandling
        private void tbCoName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoName))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Company name is empty!");
            }
        }

        private void tbCoName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }

        private void tbCoCode_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoCode))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Company code is empty!");
            }
        }

        private void tbCoCode_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }

        private void tbCoAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoAddress))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Company address is empty!");
            }
        }

        private void tbCoAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }

        private void tbCoContact_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoContact))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Company contact is empty!");
            }
        }

        private void tbCoContact_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }

        private void tbCoPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoPhone))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Company phone is empty!");
            }
        }

        private void tbCoPhone_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }
        #endregion


        #endregion

        private void btnDoneEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
