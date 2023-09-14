namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        delegateNumber DelgateNumber;
        delegateText DelgateText;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StudentInfoClass.studentNo = long.Parse(stunotextBox.Text);
            StudentInfoClass.program = programcomboBox.Text.ToString();
            StudentInfoClass.lastName = lastnametextBox.Text.ToString();
            StudentInfoClass.firstName = firstnametextBox.Text.ToString();
            StudentInfoClass.middleName = middlenametextBox.Text.ToString();
            StudentInfoClass.age = long.Parse(agetextBox.Text.ToString());
            StudentInfoClass.contactNo = long.Parse(contacttextBox.Text.ToString());
            StudentInfoClass.adress = adresstextBox.Text.ToString();

            DialogResult result;
            FrmConfirm frmConfirm = new FrmConfirm();
            result = frmConfirm.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                stunotextBox.Clear();
                programcomboBox.SelectedIndex = -1;
                lastnametextBox.Clear();
                firstnametextBox.Clear();
                middlenametextBox.Clear();
                agetextBox.Clear();
                contacttextBox.Clear();
                adresstextBox.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}