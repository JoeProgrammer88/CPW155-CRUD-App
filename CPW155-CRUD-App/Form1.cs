namespace CPW155_CRUD_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TennisRacket> allRackets = TennisRacketDb.GetAllTennisRackets();

            foreach (TennisRacket currRacket in allRackets)
            {
                lstTennisRackets.Items.Add(currRacket);
            }
        }
    }
}
