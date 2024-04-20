using static System.Windows.Forms.LinkLabel;

namespace Conteneter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // Open a file dialog to open a csv file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {


                // Read the csv file
                string[] lines = File.ReadAllLines(ofd.FileName);
                string[] headers = lines[0].Split(',');
                lstvData.Columns.Clear();
                lstvData.Items.Clear();
                foreach (string header in headers)
                {
                    lstvData.Columns.Add(header);
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    ListViewItem lvi = new ListViewItem(fields);
                    lstvData.Items.Add(lvi);
                }
            }
        }

        private void BtnArtist_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files|*.csv";
            string artist = TxtArtist.Text;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lstvData.Columns.Clear();
                lstvData.Items.Clear();

                // Read the csv file
                string[] lines = File.ReadAllLines(ofd.FileName);
                string[] headers = lines[0].Split(',');

                // Add headers to ListView
                foreach (string header in headers)
                {
                    lstvData.Columns.Add(header);
                }

                // Search for rows related to the artist
                foreach (string line in lines.Skip(1)) // Skip the header line
                {
                    string[] fields = line.Split(',');

                    // Check if the first field (assuming it's the artist name) matches the searched artist
                    if (fields.Length > 0 && fields[0] == artist)
                    {
                        ListViewItem lvi = new ListViewItem(fields);
                        lstvData.Items.Add(lvi);
                    }
                }
            }
        }
    }
}