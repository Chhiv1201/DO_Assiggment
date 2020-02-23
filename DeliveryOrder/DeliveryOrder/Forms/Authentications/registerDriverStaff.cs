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
    public partial class registerDriverStaff : Form
    {
        string Driver = "";
        public registerDriverStaff(string driver)
        {
            InitializeComponent();
            Driver = driver;
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
                    BirthDate = db.Value.Date,
                    Contact = tbContact.Text,
                    Gender = user.Gender,
                    HiredDate = DateTime.Now,
                    Phone = tbPhone.Text,
                    Position = user.RoleID,
                    Salary = Decimal.Parse(tbSalary.Text),
                    StaffName = user.FirstName + "_" + user.LastName,
                    StopWork = false
                };
                Main.userBuilder.AddInfo(staff);

                if (labelDriver.Text.ToLower() == "cardriver")
                {
                    var carDriver = new CarDriver()
                    {
                        UserID =user.ID,
                        ID =op.NewID(),
                        StaffName = staff.StaffName,
                        Gender = staff.Gender,
                        BirthDate = staff.BirthDate,
                        drivingLicenceNumber = tbDrivingLicenece.Text,
                        expiryDate = expireLicence.Value,
                        Working = false
                    };
                    Main.userBuilder.AddInfo(carDriver).SubmitDB();

                }
                else if(labelDriver.Text.ToLower() == "motodriver")
                {
                    var motoDriver = new MotoDriver()
                    {
                        UserID = user.ID,
                        ID = op.NewID(),
                        StaffName = staff.StaffName,
                        Gender = staff.Gender,
                        BirthDate = staff.BirthDate,
                        drivingLicenceNumber = tbDrivingLicenece.Text,
                        expiryDate = expireLicence.Value,
                        Working = false
                    };
                    Main.userBuilder.AddInfo(motoDriver).SubmitDB();

                }

                Program.main.OpenLogin();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void registerDriverStaff_Load(object sender, EventArgs e)
        {
            this.labelDriver.Text = this.Driver;
        }
    }
}
