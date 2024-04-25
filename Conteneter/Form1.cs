using System.Security.Cryptography;
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

                string artist = TxtArtist.Text.Trim().ToLower().ToUpper(); // Obtener el nombre del artista ingresado por el usuario

                // Search for rows related to the artist
                for (int i = 1; i < lines.Length; i++) // Empezamos desde 1 para omitir la línea de encabezado
                {
                    string[] fields = lines[i].Split(',');

                    // Check if the first field (assuming it's the artist name) matches the searched artist
                    if (fields.Length > 0 && fields[2].Trim().ToLower().ToUpper() == artist)
                    {
                        ListViewItem lvi = new ListViewItem(fields);
                        lstvData.Items.Add(lvi);
                    }
                }
            }

        }

        private void DateSearchBtn_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in lstvData.Items)
            {
                // Obtener la fecha de la séptima columna del ListView
                string dateString = item.SubItems[6].Text.Trim();
                DateTime date;

                if (DateTime.TryParse(dateString, out date)) // Verificar si la fecha es válida
                {
                    // Verificar si la fecha está dentro del rango especificado
                    if (!(date >= dateTimePicker1.Value && date <= dateTimePicker2.Value))
                    {
                        // La fecha está dentro del rango, mostrar el elemento en el ListView
                        lstvData.Items.Remove(item);
                    }
                }
                
            }

        }
    }
}