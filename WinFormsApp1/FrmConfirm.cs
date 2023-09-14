using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmConfirm : Form
    {
        private delegateNumber DelAge, DelConNo, DelStudNo;
        private delegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAdress;
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new delegateText(StudentInfoClass.GetProgram);
            DelLastName = new delegateText(StudentInfoClass.GetlastName);
            DelFirstName = new delegateText(StudentInfoClass.GetfirstName);
            DelMiddleName = new delegateText(StudentInfoClass.GetmiddleName);
            DelAdress = new delegateText(StudentInfoClass.GetAdress);
            DelAge = new delegateNumber(StudentInfoClass.GetAge);
            DelConNo = new delegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new delegateNumber(StudentInfoClass.GetStudentNo);

            label9.Text = DelStudNo(StudentInfoClass.studentNo).ToString();
            label10.Text = DelProgram(StudentInfoClass.program).ToString();
            label11.Text = DelLastName(StudentInfoClass.lastName).ToString();
            label12.Text = DelFirstName(StudentInfoClass.firstName).ToString();
            label13.Text = DelMiddleName(StudentInfoClass.middleName).ToString();
            label14.Text = DelAge(StudentInfoClass.age).ToString();
            label15.Text = DelConNo(StudentInfoClass.contactNo).ToString();
            label16.Text = DelAdress(StudentInfoClass.adress).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
