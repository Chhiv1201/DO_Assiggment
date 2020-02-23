using DeliveryOrder.Model.SingleTon;
using DeliveryOrder.Model.SqlCmdBuilder;
using DeliveryOrder.Model.SqlModel;
using DeliveryOrder.Pattern;
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
    public partial class PickUp : Form
    {
        string productID = "";
        Database db_ = Database.Instance;

        public PickUp(string productID)
        {
            this.productID = productID;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                db_.DefaultConnect();
                string queryProduct = "";
                string queryDriver = "";
                string driverType = "";
                Dictionary<string, dynamic> dicDriver = new Dictionary<string, dynamic>() { { "Working", true } };

                Product product = new Product()
                {
                    Status = "Delivering",
                    TakeDate = DateTime.Now,
                    TakeBy = cboDriver.Text,
                    TakerID = cboDriver.SelectedValue.ToString(),
                    Note= cboDriverType.Text
                };


                SqlQueryBuilder Update = new SqlQueryBuilder(new SqlUpdate());
                queryProduct = Update.Fields(product.FieldNotNullAsDictionary().Keys.ToArray())
                                     .Table("Product")
                                     .Where("ID = '"+productID+"'")
                                     .GetQueryString();

                queryDriver = Update.Fields(dicDriver.Keys.ToArray())
                                     .Table(cboDriverType.Text)
                                     .Where("ID = '" + product.TakerID+"'")
                                     .GetQueryString();



                //Using Single Tone
                db_.Transaction(queryProduct, product.FieldNotNullAsDictionary());
                db_.Transaction(queryDriver, dicDriver);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db_.Disconnect();
            }



            this.Close();
        }

        private void PickUp_Load(object sender, EventArgs e)
        {
            cboDriverType.Items.Add("CarDriver");
            cboDriverType.Items.Add("MotoDriver");
        }

        private void cboDriverType_TextChanged(object sender, EventArgs e)
        {


            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Select = new SqlQueryBuilder(new SqlSelect());
                //Using Builder
                string query = Select.Fields("*")
                                     .Table(cboDriverType.Text)
                                     .GetQueryString();
                //Using Single Tone
                var table =  db_.Read(query);



                //driver
                cboDriver.DataSource = table;
                cboDriver.DisplayMember = "StaffName";
                cboDriver.ValueMember = "ID";

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
    }
}
