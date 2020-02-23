using DeliveryOrder.Model;
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

namespace DeliveryOrder.Forms.Authentications
{
    public partial class registerCoperator : Form
    {
        public registerCoperator()
        {
            InitializeComponent();
        }
        operation op = new operation();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var user = (User)Main.userBuilder.GetUserInfo().user;
                Coperator copUser = new Coperator()
                {
                    UserID = user.ID,
                    CopID = op.NewID(),
                    CopDate = DateTime.Now,
                    Gender = user.Gender,
                    ComContact= tbComContact.Text,
                    ComLocation= tbComLocation.Text,
                    ComName=tbCompanyName.Text,
                    StaffName= user.FirstName + "_" + user.LastName
                    
                };



                Main.userBuilder.AddInfo(copUser).SubmitDB();

                Program.main.OpenLogin();
                this.Close();



            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
