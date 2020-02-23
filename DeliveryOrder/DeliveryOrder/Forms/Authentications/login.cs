using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryOrder.Model;
using DeliveryOrder.Model.SingleTon;
using DeliveryOrder.Model.SqlCmdBuilder;
using DeliveryOrder.Model.SqlModel;

namespace DeliveryOrder.Forms.Authentications
{
    public partial class login : Form
    {
        Database db_ = Database.Instance;
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                db_.DefaultConnect();

                string userName = tbUserName.Text;
                string password = tbPassword.Text;
                SqlQueryBuilder Select = new SqlQueryBuilder(new SqlSelect());
                //Using Builder
                string query = Select.Fields("*")
                                     .Table("User")
                                     .Where("UserName like '"+userName+"'")
                                     .GetQueryString();
                //Using Single Tone
                var table = db_.Read(query);

                if(table.Rows.Count>0)
                {
                    var u = table.Rows[0];
                    User user = new User()
                    {
                        ID =        u.Field<string>("ID"),
                        FirstName = u.Field<string>("FirstName"),
                        LastName =  u.Field<string>("LastName"),
                        UserName =  u.Field<string>("UserName"),
                        Email =     u.Field<string>("Email"),
                        Gender =    u.Field<string>("Gender"),
                        password =  u.Field<string>("password"),
                        RoleID =    u.Field<string>("RoleID"),
                    };


                    if (user != null)
                    {

                        if (user.password == password)
                        {
                            //Login Success
                            Program.main.user = user;
                            Program.main.OpenMainMenu();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password!");
                            tbPassword.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("UserName not found!");
                        tbUserName.Text = "";
                        tbPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("UserName not found!");
                    tbUserName.Text = "";
                    tbPassword.Text = "";
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Program.main.OpenRegister();
        }
    }
}
