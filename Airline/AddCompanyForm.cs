using Airline.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Airline
{
    public partial class AddCompanyForm : Form
    {
        #region Attributes
        private int noOffers = 0;
        private long currId = 0;
        private readonly List<Company> _companies;
        private readonly List<Route> _routes;
        private string connectionString = "Data Source=database.db";
        #endregion

        public AddCompanyForm()
        {
            InitializeComponent();
            _companies = new List<Company>();
            _routes = new List<Route>();
        }

        #region Methods
        private void AddRoute(Route route)
        {
            var query = "INSERT INTO Routes(StartCity, DestCity, CompanyID) " +
               " VALUES (@startCity, @destCity, @companyId);" +
               " SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@startCity", route.StartCity);
                command.Parameters.AddWithValue("@destCity", route.DestinationCity);
                command.Parameters.AddWithValue("@companyId", (int)route.companyId);
                

                connection.Open();

                long id = (long)command.ExecuteScalar();
                route.Id = id;

                _routes.Add(route);

            }
        }

        private void AddCompany(Company company)
        {
            var query = "INSERT INTO Company(Code, Name, Address, Contact, Phone) " +
               " VALUES (@coCode, @coName, @coAddress, @coContact, @coPhone);" +
               " SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@coCode", company.CompanyCode);
                command.Parameters.AddWithValue("@coName", company.Name);
                command.Parameters.AddWithValue("@coAddress", company.Address);
                command.Parameters.AddWithValue("@coContact", company.ContactPerson);
                command.Parameters.AddWithValue("@coPhone", company.ContactPhone);


                connection.Open();

                long id = (long)command.ExecuteScalar();
                company.Id = id;
                currId = id;

                _companies.Add(company);

                grpOfferedRoutes.Enabled = true;

            }
        }

        private bool IsFieldValid(TextBox tb)
        {            
            return !string.IsNullOrWhiteSpace(tb.Text.Trim());
        }
        #endregion

        #region Events
        private void AddCompanyForm_Load(object sender, EventArgs e)
        {
            if (grpOfferedRoutes.Enabled == true)
                grpOfferedRoutes.Enabled = false;
        }

        private void addOfferRoute(object sender, EventArgs e)
        {
            noOffers = noOffers + 1;
            Label lbStart = new Label();
            TextBox tbStart = new TextBox();
            Label lbDest = new Label();
            TextBox tbDest = new TextBox();
            grpOfferedRoutes.Controls.Add(lbStart);
            grpOfferedRoutes.Controls.Add(tbStart);
            grpOfferedRoutes.Controls.Add(lbDest);
            grpOfferedRoutes.Controls.Add(tbDest);

            lbStart.Top = noOffers * 25;
            tbStart.Top = noOffers * 25;
            lbDest.Top = noOffers * 25;
            tbDest.Top = noOffers * 25;

            lbStart.Left = 80;
            tbStart.Left = 180;
            lbDest.Left = 290;
            tbDest.Left = 390;

            lbStart.Name = "lbStartCity" + this.noOffers.ToString();
            tbStart.Name = "tbStartCity" + this.noOffers.ToString();
            lbDest.Name = "lbDestCity" + this.noOffers.ToString();
            tbDest.Name = "tbDestCity" + this.noOffers.ToString();

            lbStart.Text = "Start city";
            lbDest.Text = "Destination city";            
        }
       

        private void btnCoSave_Click(object sender, EventArgs e)
        { 
            

            if( noOffers > 0)
            {
                for(int i = 1; i <= noOffers; i++)
                {
                    var ctrlName = "tbStartCity" + i.ToString();
                    Control ctn = grpOfferedRoutes.Controls[ctrlName];
                    var startCity = ctn.Text;
                    ctrlName = "tbDestCity" + i.ToString();
                    ctn = grpOfferedRoutes.Controls[ctrlName];
                    var destCity = ctn.Text;
                    if (currId != 0 && grpOfferedRoutes.Enabled == true)
                    {
                        var route = new Route(startCity, destCity, currId);
                        try
                        {
                            AddRoute(route);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else MessageBox.Show("Add the company first!");
                                      
                }
            }
        }
        

        private void btnAddCompany_Click(object sender, EventArgs e)
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
                string coCode = tbCoCode.Text;
                string coName = tbCoName.Text;
                string coAddress = tbCoAddress.Text;
                string coContact = tbCoContact.Text;
                string coPhone = tbCoPhone.Text;

                var company = new Company(coCode, coName, coAddress, coContact, coPhone);
                AddCompany(company);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        #region ErrorHandling
        private void tbCoName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoName))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Company name is empty!");
            }
        }

        private void tbCoName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbCoCode_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoCode))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Company code is empty!");
            }
        }

        private void tbCoCode_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbCoAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoAddress))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Company address is empty!");
            }
        }

        private void tbCoAddress_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbCoContact_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoContact))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Company contact is empty!");
            }
        }

        private void tbCoContact_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbCoPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFieldValid(tbCoPhone))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Company phone is empty!");
            }
        }

        private void tbCoPhone_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }
        #endregion

        #endregion


    }
}
