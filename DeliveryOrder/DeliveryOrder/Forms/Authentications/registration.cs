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
using DeliveryOrder.Pattern;

namespace DeliveryOrder.Forms.Authentications
{
    public partial class registration : Form
    {
        Database db_ = Database.Instance;
        operation op = new operation();
        //List<UserRole> UsersRole = new List<UserRole>(); 
        public registration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.main.OpenLogin();
            this.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string roleID = cboRole.SelectedValue.ToString();
            User user = new User()
            {
                ID = op.NewID(),
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                UserName = tbUserName.Text,
                Email = tbEmail.Text,
                Gender = cboGender.Text,
                password = tbPassword.Text,
                RoleID = roleID
            };


            Main.userBuilder = new Pattern.UserBuilder.UserBuilder(cboRole.Text);

            Main.userBuilder.AddInfo(user);
            NextStep();



        }

        void NextStep()
        {
            switch(cboRole.Text.ToLower())
            {
                case "cardriver":
                case "motodriver":
                    Program.main.OpenDriverRegister(cboRole.Text);

                    break;
                case "admin":
                    Program.main.OpenStaffRegister();
                    break;
                case "saler":
                    Program.main.OpenSalerRegister();
                    break;
            }
        }

        private void registration_Load(object sender, EventArgs e)
        {
            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Select = new SqlQueryBuilder(new SqlSelect());
                //Using Builder
                string query = Select.Fields("*")
                                     .Table("UserRole")
                                     .GetQueryString();
                //Using Single Tone
                var table= db_.Read(query);

                if (table.Rows.Count > 0)
                {
                    cboRole.DataSource = table;

                    cboRole.DisplayMember = "Role";
                    cboRole.ValueMember = "ID";
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
    }
}
