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
    public partial class registerStaff : Form
    {
        public registerStaff()
        {
            InitializeComponent();
        }
        operation op = new operation();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var user = Main.userBuilder.GetUserInfo().user;
                Staff staff = new Staff()
                {
                    ID = op.NewID(),
                    UserID = user.ID,
                    Address = tbAddress.Text,
                    BirthDate = DateTime.Parse(dateTimePicker1.Text),
                    Contact = tbContact.Text,
                    Gender = user.Gender,
                    HiredDate = DateTime.Now,
                    Phone = tbPhone.Text,
                    Position = user.RoleID,
                    Salary = Decimal.Parse(tbSalary.Text),
                    StaffName = user.FirstName + "_" + user.LastName,
                    StopWork = false
                };
                Main.userBuilder.AddInfo(staff).SubmitDB();
                
                Program.main.OpenLogin();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }


        }
    }
}
