using DeliveryOrder.Model;
using DeliveryOrder.Model.SingleTon;
using DeliveryOrder.Model.SqlCmdBuilder;
using DeliveryOrder.Model.SqlModel;
using DeliveryOrder.Pattern;
using DeliveryOrder.Pattern.UserBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryOrder.Forms
{
    public partial class Main : Form
    {
        public static UserBuilder userBuilder;
        public User user = new User();
        public List<UserRole> UserRoles = new List<UserRole>();
        Database db_ = Database.Instance;
        public Main()
        {
            InitializeComponent();
        }
        Authentications.login login;
        Authentications.registration register; 
        Authentications.registerStaff registerStaff; 
        Authentications.registerDriverStaff registerStaffDriver; 
        Authentications.registerCoperator registerSaler;

        Menu.MainMenu mainMenu;
        private void Main_Load(object sender, EventArgs e)
        {
            login = new Authentications.login();
            
            login.Show();
            LoadUserRole();
        }

        void LoadUserRole()
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
                var userRoles_ = db_.Read(query);

                if (userRoles_.Rows.Count > 0)
                {
                    foreach (DataRow role in userRoles_.Rows)
                    {
                        UserRole userrole = new UserRole()
                        {
                            ID = role.Field<string>("ID"),
                            Role = role.Field<string>("Role"),
                            Desc = role.Field<string>("Desc")
                        };
                        UserRoles.Add(userrole);
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
        public void OpenLogin()
        {
            login = new Authentications.login();
            login.Show();
        }
        public void OpenRegister()
        {

            register = new Authentications.registration();
            register.Show();
            login.Close();
        }
        public void OpenStaffRegister()
        {

            registerStaff = new Authentications.registerStaff();
            registerStaff.Show();

            register.Close();
        }
        public void OpenDriverRegister(string Driver)
        {
            registerStaffDriver = new Authentications.registerDriverStaff(Driver);
            registerStaffDriver.Show();

            register.Close();
        }
        public void OpenSalerRegister()
        {
            registerSaler = new Authentications.registerCoperator();
            registerSaler.Show();

            register.Close();
        }



        public void OpenMainMenu()
        {
            mainMenu = new Menu.MainMenu();
            mainMenu.Show();

            login.Close();
        }

        
    }
}
