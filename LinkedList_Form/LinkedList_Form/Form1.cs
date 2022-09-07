namespace LinkedList_Form
{
    public partial class Form1 : Form
    {
        LinkedList <string> airline_list = new LinkedList<string> ();
        public Form1()
        {
            InitializeComponent();
        }


        private void AddDataBtn_Click(object sender, EventArgs e)
        {
            airline_list.AddFirst("Air New Zealand");
            airline_list.AddLast("Cathay Pacific");
            airline_list.AddLast("JetStar");
            airline_list.AddLast("Fiji Airways");

        }
    }
}