namespace PatientLIst
{
    public partial class Form1 : Form
    {

        Appointmnet app=new Appointmnet();


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = name_textBox.Text;
            string address = address_box.Text;
            string gender = gender_box.SelectedItem.ToString();
            Patient p = new Patient(name, address, gender);

            app.addPatientToList(p);

            waitingList.DataSource = app.getAllWaitingPatients().ToList();



        }

        private void NextBt_Click(object sender, EventArgs e)
        {
            Patient p = app.seeDoctor();
            DoctorViewBox.Items.Add(p);
            waitingList.DataSource=app.getAllWaitingPatients().ToList();
        }
    }
}