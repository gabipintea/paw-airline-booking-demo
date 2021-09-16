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
    public partial class EditRouteForm : Form
    {

        #region Attributes
        private const string ConnectionString = "Data Source=database.db";
        private readonly List<Company> _companies;        
        private Company _company;
        private int noOffers = 0;
        private long currId = 0;
        #endregion

        public EditRouteForm()
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


                        Company company = new Company(id, code, name, addr, contact, phone);
                        _companies.Add(company);
                    }
                }
            }
        }

        private void EditRoute(Route route)
        {
            var query = "UPDATE Routes SET StartCity = @startCity, DestCity = @destCity WHERE  ID = @routeID";            

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@startCity", route.StartCity);
                command.Parameters.AddWithValue("@destCity", route.DestinationCity);
                command.Parameters.AddWithValue("@routeID", route.Id);


                connection.Open();

                command.ExecuteNonQuery();                

            }
        }

        private void DeleteRoute(Route route)
        {
            const string stringSql = "DELETE FROM Routes WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

               
                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@id", route.Id);

                command.ExecuteNonQuery();               
            }
        }

        private void DisplayRoutes(long coId)
        {
            noOffers = 0;
            ClearRoutes();

            const string stringSql = "SELECT * FROM Routes WHERE CompanyID = @coId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);

                command.Parameters.AddWithValue("@coId", coId);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["ID"];
                        string startCity = (string)sqlReader["StartCity"];
                        string destCity = (string)sqlReader["DestCity"];
                        long compId = (long)sqlReader["CompanyID"];
                        
                        Route route = new Route(id, startCity, destCity, compId);
                        DisplayOneRoute(route);
                    }
                }
            }
        }

        private void DisplayOneRoute(Route route)
        {
            noOffers = noOffers + 1;
            Label lbStart = new Label();
            TextBox tbStart = new TextBox();
            Label lbDest = new Label();
            TextBox tbDest = new TextBox();
            Label lbDel = new Label();
            CheckBox ckDelRoute = new CheckBox();
            grpOfferedRoutes.Controls.Add(lbStart);
            grpOfferedRoutes.Controls.Add(tbStart);
            grpOfferedRoutes.Controls.Add(lbDest);
            grpOfferedRoutes.Controls.Add(tbDest);
            grpOfferedRoutes.Controls.Add(lbDel);
            grpOfferedRoutes.Controls.Add(ckDelRoute);

            lbStart.Top = noOffers * 25;
            tbStart.Top = noOffers * 25;
            lbDest.Top = noOffers * 25;
            tbDest.Top = noOffers * 25;
            lbDel.Top = noOffers * 25;
            ckDelRoute.Top = noOffers * 25;

            lbStart.Left = 80;
            tbStart.Left = 180;
            lbDest.Left = 290;
            tbDest.Left = 390;
            lbDel.Left = 500;
            ckDelRoute.Left = 550;

            lbStart.Name = "lbStartCity" + this.noOffers.ToString();
            tbStart.Name = "tbStartCity" + this.noOffers.ToString();
            lbDest.Name = "lbDestCity" + this.noOffers.ToString();
            tbDest.Name = "tbDestCity" + this.noOffers.ToString();
            lbDel.Name = "lbDel" + this.noOffers.ToString();
            ckDelRoute.Name = "ckDelRoute" + this.noOffers.ToString();

            lbStart.Text = "Start city";
            lbStart.Tag = route;
            lbDest.Text = "Destination city";
            lbDel.Text = "Delete?";
            lbDel.Width = 45;

            tbStart.Text = route.StartCity;
            tbDest.Text = route.DestinationCity;
        }

        private void ClearRoutes()
        {
            grpOfferedRoutes.Controls.Clear();
        }
        #endregion

        #region Events

        private void EditRouteForm_Load(object sender, EventArgs e)
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
                DisplayRoutes(currId);
            }
        }

        private void btnCoSave_Click(object sender, EventArgs e)
        {
            if (noOffers > 0)
            {
                for (int i = 1; i <= noOffers; i++)
                {
                    var delRoute = false;
                    var ctrlName = "tbStartCity" + i.ToString();
                    Control ctn = grpOfferedRoutes.Controls[ctrlName];
                    var startCity = ctn.Text;
                    ctrlName = "tbDestCity" + i.ToString();
                    ctn = grpOfferedRoutes.Controls[ctrlName];
                    var destCity = ctn.Text;
                    ctrlName = "ckDelRoute" + i.ToString();
                    ctn = grpOfferedRoutes.Controls[ctrlName];
                    CheckBox del = new CheckBox();
                    del = (CheckBox)ctn;
                    delRoute = del.Checked;
                    ctrlName = "lbStartCity" + i.ToString();
                    ctn = grpOfferedRoutes.Controls[ctrlName];
                    Route route = (Route)ctn.Tag;
                    if (currId != 0 && grpOfferedRoutes.Enabled == true)
                    {
                        var newRoute = new Route(route.Id, startCity, destCity, currId);
                        try
                        {
                            if (delRoute == false)
                            {
                                EditRoute(newRoute);
                            }
                            else
                            {
                                DeleteRoute(newRoute);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else MessageBox.Show("Choose the company first!");

                }
                MessageBox.Show("Routes have been updated!");
                DisplayRoutes(currId);
            }
        }
        #endregion


    }
}
