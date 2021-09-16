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
    public partial class AddRouteForm : Form
    {

        #region Attributes
        private const string ConnectionString = "Data Source=database.db";
        private readonly List<Company> _companies;
        private readonly List<Route> _routes;
        private Company _company;
        private int noOffers = 0;
        private long currId = 0;
        #endregion

        public AddRouteForm()
        {
            InitializeComponent();
            _companies = new List<Company>();
            _routes = new List<Route>();
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


                        Company company = new Company(id, code, name, addr, contact, phone);
                        _companies.Add(company);
                    }
                }
            }
        }

        private void AddRoute(Route route)
        {
            var query = "INSERT INTO Routes(StartCity, DestCity, CompanyID) " +
               " VALUES (@startCity, @destCity, @companyId);" +
               " SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
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
        #endregion

        #region Events
        private void AddRouteForm_Load(object sender, EventArgs e)
        {
            if (grpOfferedRoutes.Enabled == true)
                grpOfferedRoutes.Enabled = false;
            LoadCompanies();
            DisplayCompanies();
        }

        private void lvCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grpOfferedRoutes.Enabled == false)
                grpOfferedRoutes.Enabled = true;

            var last = lvCompanies.SelectedItems.Count;
            if (last >= 1)
            {
                _company = (Company)lvCompanies.SelectedItems[0].Tag;
                currId = _company.Id;
            }
        }

        #endregion

        private void btnAddOffers_Click(object sender, EventArgs e)
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
            if (noOffers > 0)
            {
                for (int i = 1; i <= noOffers; i++)
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
                    else MessageBox.Show("Choose the company first!");

                }
            }
        }
    }
}
