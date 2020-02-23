using DeliveryOrder.Model;
using DeliveryOrder.Model.SingleTon;
using DeliveryOrder.Model.SqlCmdBuilder;
using DeliveryOrder.Model.SqlModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryOrder.Forms.Menu
{
    public partial class MainMenu : Form
    {
        Database db_ = Database.Instance;

        List<Product> lstProducts = new List<Product>();

        operation op = new operation();

        public Product product_ = new Product();
        public MainMenu()
        {
            InitializeComponent();
            lbUser.Text = Program.main.user.LastName;


        }
        public void RefreshProduct()
        {

            RefreshDatasource();

            GetNewItem();
            GetDeliveringItem();
            GetClosedItem();


            product_ = new Product();
            ClearTextBox();
            lbltest.Text = "None Selected";
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            PickUp pickUp = new PickUp(product_.ID);




            pickUp.ShowDialog();

            RefreshProduct();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                db_.DefaultConnect();
                var item = new Product()
                {
                    ID = op.NewID(),
                    Name = tbProductName.Text,
                    Description = tbDescribtion.Text,
                    //ProductType=
                    SalerID = Program.main.user.ID,
                    SalerName = Program.main.user.LastName,
                    CheckInDate = DateTime.Now,
                    ToLocation = tbToLocation.Text,
                    CusPhone = tbCusPhone.Text,
                    CusAddress = tbCusAddress.Text,
                    //TakeBy
                    //TakeDate
                    //CloseDate
                    Status = "Hold",
                    Note = ""
                }.FieldNotNullAsDictionary();
                SqlQueryBuilder Insert = new SqlQueryBuilder(new SqlInsert());
                //Using Builder
                string query = Insert.Fields(item.Keys.ToArray())
                                     .Table("Product")
                                     .GetQueryString();
                //Using Single Tone
                db_.Transaction(query, item);

                RefreshProduct();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db_.Disconnect();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ID = product_.ID,
                Name = tbProductName.Text,
                Description = tbDescribtion.Text,
                //ProductType
                //SalerID = Main.user.ID,
                //SalerName = Main.user.LastName,
                //CheckInDate = DateTime.Now,
                ToLocation = tbToLocation.Text,
                CusPhone = tbCusPhone.Text,
                CusAddress = tbCusAddress.Text,
                //TakeBy
                //TakeDate
                //CloseDate
                //Status = product.Status;
                //Note = product.Note;
            };
            UpdateProduct(product);
            product_ = new Product();
            ClearTextBox();
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Update = new SqlQueryBuilder(new SqlUpdate());
                //Using Builder
                string query = Update.Fields(product.FieldNotNullAsDictionary().Keys.ToArray())
                                     .Table("Product")
                                     .Where("ID = '" + product.ID + "'")
                                     .GetQueryString();
                //Using Single Tone
                db_.Transaction(query, product.FieldNotNullAsDictionary());

                RefreshProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db_.Disconnect();
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ID = product_.ID,
                Status = Status.Cancel.ToString(),
                CloseDate = DateTime.Now
            };
            UpdateProduct(product);
            product_ = new Product();
            ClearTextBox();
        }

        
        void LoadPermission()
        {
            var userRole = Program.main.UserRoles.Where(x=>x.ID==Program.main.user.RoleID).FirstOrDefault();
            if (userRole.Role.ToLower() != "admin")
            {
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is Button)
                    {
                        var tag = ((Button)control).Tag;
                        if (tag != null && tag.ToString() == "admin")
                        {
                            ((Button)control).Visible = false;
                        }
                    }

                }
                foreach (Control control in tabDeliveringItem.Controls)
                {
                    if (control is Button)
                    {
                        var tag = ((Button)control).Tag;
                        if (tag != null && tag.ToString() == "admin")
                        {
                            ((Button)control).Visible = false;
                        }
                    }

                }
            }
        }

        void RefreshDatasource()
        {
            Product product = null;
            string condition = "";
            if (Program.main.user.RoleID != "423DAC41-7E15-4EAC-BAF1-7B2421BE5CBB") //Check RolID != RoleAdmin
            {
                condition = "SalerID = '" + Program.main.user.ID + "'";
            }
            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Select = new SqlQueryBuilder(new SqlSelect());
                //Using Builder
                string query = Select.Fields("*")
                                     .Table("Product")
                                     .Where(condition)
                                     .GetQueryString();
                //Using Single Tone

                var product_ = db_.Read(query);





                if (product_.Rows.Count > 0)
                {
                    lstProducts = new List<Product>();
                    foreach (DataRow item in product_.Rows)
                    {

                        product = new Product()
                        {
                            ID = item.Field<string>("ID"),
                            Name = item.Field<string>("Name"),
                            Description = item.Field<string>("Description"),
                            ProductType = item.Field<string>("ProductType"),
                            SalerID = item.Field<string>("SalerID"),
                            SalerName = item.Field<string>("SalerName"),
                            CheckInDate = item.Field<DateTime?>("CheckInDate"),
                            ToLocation = item.Field<string>("ToLocation"),
                            CusPhone = item.Field<string>("CusPhone"),
                            CusAddress = item.Field<string>("CusAddress"),
                            TakerID= item.Field<string>("TakerID"),
                            TakeBy = item.Field<string>("TakeBy"),
                            TakeDate = item.Field<DateTime?>("TakeDate"),
                            CloseDate = item.Field<DateTime?>("CloseDate"),
                            Status = item.Field<string>("Status"),
                            Note = item.Field<string>("Note")
                        };
                        lstProducts.Add(product);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db_.Disconnect();
            }


            
        }

        public void GetNewItem()
        {


            var source = lstProducts.Where(x => x.Status == Status.Hold.ToString()).ToList() ;


            gdNewItem.DataSource = source;
            gdNewItem.ClearSelection();


        }

        public void GetDeliveringItem()
        {
                var source = lstProducts.Where(x => x.Status == Status.Delivering.ToString()).ToList();


                gdDeliveringItem.DataSource = source;
                gdDeliveringItem.ClearSelection();

        }

        public void GetClosedItem()
        {
                var source = lstProducts.Where(x => x.Status == Status.Completed.ToString() || x.Status == Status.Cancel.ToString()).ToList();
            
                gdCompleteItem.DataSource = source;
                gdCompleteItem.ClearSelection();
        }

        enum Status
        {
            Hold=1,
            Delivering=2,
            Completed=3,
            Cancel=4
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            RefreshProduct();
            LoadPermission();
        }

        private void tab_Selecting(object sender, TabControlCancelEventArgs e)
        {

            RefreshProduct();

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ID = product_.ID,
                Status = Status.Completed.ToString(),
                CloseDate = DateTime.Now
            };

            DriverIsFree(product_.TakerID, product_.Note);

            UpdateProduct(product);
            product_ = new Product();
            ClearTextBox();
        }

        public void DriverIsFree(string driverID, string DriverType)
        {
            try
            {
                db_.DefaultConnect();
                Dictionary<string, dynamic> dicDriver = new Dictionary<string, dynamic>() { { "Working", false } };
                
                SqlQueryBuilder Update = new SqlQueryBuilder(new SqlUpdate());
                //Using Builder

                string query = Update.Fields(dicDriver.Keys.ToArray())
                                     .Table(DriverType)
                                     .Where("ID = '" + driverID+"'" )
                                     .GetQueryString();



                //Using Single Tone
                db_.Transaction(query, dicDriver);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db_.Disconnect();
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel_Click(sender, e);
        }

        private void gdNewItem_SelectionChanged(object sender, EventArgs e)
        {

            if (sender is DataGridView)
            {
                
                var gridView = (DataGridView)sender;
                if (gridView.Rows.Count > 0 && gridView.SelectedRows.Count>0)
                {
                    try
                    {
                        int selectedrowindex = gridView.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = gridView.Rows[selectedrowindex];
                        product_.ID = selectedRow.Cells["ID"].Value.ToString();

                        UpdateTBFromDB();

                        lbltest.Text = product_.Name;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        void UpdateTBFromDB()
        {
            product_ = GetProduct(product_.ID);
            UpdateTextBox(product_);

        }

        Product GetProduct(string itemID)
        {
            Product product = null;

            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Select = new SqlQueryBuilder(new SqlSelect());
                    //Using Builder
                    string query = Select.Fields("*")
                                         .Table("Product")
                                         .Where("ID = '"+ itemID+"'")
                                         .GetQueryString();
                    //Using Single Tone

                    var products_ = db_.Read(query);
                    if (products_.Rows.Count > 0)
                    {
                        product = new Product()
                        {
                            ID             = products_ .Rows[0].Field<string>("ID"),
                            Name           = products_ .Rows[0].Field<string>("Name"),
                            Description    = products_ .Rows[0].Field<string>("Description"),
                            ProductType    = products_ .Rows[0].Field<string>("ProductType"),
                            SalerID        = products_ .Rows[0].Field<string>("SalerID"),
                            SalerName      = products_ .Rows[0].Field<string>("SalerName"),
                            CheckInDate    = products_ .Rows[0].Field<DateTime?>("CheckInDate"),
                            ToLocation     = products_ .Rows[0].Field<string>("ToLocation"),
                            CusPhone       = products_ .Rows[0].Field<string>("CusPhone"),
                            CusAddress     = products_ .Rows[0].Field<string>("CusAddress"),
                            TakerID        = products_. Rows[0].Field<string>("TakerID"),
                            TakeBy         = products_ .Rows[0].Field<string>("TakeBy"),
                            TakeDate       = products_ .Rows[0].Field<DateTime?>("TakeDate"),
                            CloseDate      = products_ .Rows[0].Field<DateTime?>("CloseDate"),
                            Status         = products_ .Rows[0].Field<string>("Status"),
                            Note           = products_ .Rows[0].Field<string>("Note")
                        };             
                    }
    
            }                                         
            catch (Exception ex)                                     
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db_.Disconnect();
            }
            return product;

        }

        public void UpdateTextBox(Product product)
        {
            tbProductName.Text = product.Name;
            tbCusPhone.Text = product.CusPhone;
            tbCusAddress.Text = product.CusAddress;
            tbToLocation.Text = product.ToLocation;
            tbDescribtion.Text = product.Description;
        }
        public void ClearTextBox()
        {
            tbProductName.Text ="";
            tbCusPhone.Text = "";
            tbCusAddress.Text = "";
            tbToLocation.Text = "";
            tbDescribtion.Text = "";
        }

        private void gdDeliveringItem_SelectionChanged(object sender, EventArgs e)
        {
            gdNewItem_SelectionChanged(sender, e);
        }

        private void gdCompleteItem_SelectionChanged(object sender, EventArgs e)
        {

            gdNewItem_SelectionChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Program.main.OpenLogin();
            this.Close();
            
        }
         
    }
}
