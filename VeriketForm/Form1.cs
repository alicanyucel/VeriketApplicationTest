using NLog;
using System;
using System.Windows.Forms;

namespace VeriketForm
{
    public partial class Form1 : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView'e buton ekliyoruz
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Log Mesaj�";
            buttonColumn.Name = "btnLog";
            buttonColumn.Text = "Log Yaz";
            buttonColumn.UseColumnTextForButtonValue = true;
            dtgList.Columns.Add(buttonColumn);

            // DataGridView'e �rnek veri ekliyoruz
            dtgList.Rows.Add("�rnek Veri 1");
            dtgList.Rows.Add("�rnek Veri 2");

            // DataGridView'deki buton t�klama olay�n� ba�lama
            dtgList.CellClick += dtgList_CellClick;
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Buton kolonu t�klanm��sa, loglar� yazd�r
            if (e.ColumnIndex == dtgList.Columns["btnLog"].Index)
            {
                // Log mesajlar�n� yazd�r�yoruz
                string logMessage = "Debug: Debug mesaj�\nInfo: Info mesaj�\nWarn: Warn mesaj�\nError: Error mesaj�";

                // DataGridView'deki ilgili sat�ra log mesaj� yazd�r�yoruz
                dtgList.Rows[e.RowIndex].Cells["btnLog"].Value = logMessage;

                // Loglar� NLog ile konsola yazd�r�yoruz
                logger.Debug("Debug mesaj�");
                logger.Info("Info mesaj�");
                logger.Warn("Warn mesaj�");
                logger.Error("Error mesaj�");
            }
        }

        // button1 t�klama olay�, t�m sat�rlara log mesaj� yazacak
        private void button1_Click(object sender, EventArgs e)
        {
            // T�m sat�rlara log mesaj� ekliyoruz
            string logMessage = $"Debug: Debug mesaj�\nInfo: Info mesaj�\nWarn: Warn mesaj�\nError: Error mesaj�";

            // DataGridView'e log mesajlar�n� yazd�r�yoruz
            foreach (DataGridViewRow row in dtgList.Rows)
            {
                // Log mesaj�n� her sat�ra yaz�yoruz
                row.Cells["btnLog"].Value = logMessage;
            }

            // Loglar� NLog ile konsola yazd�r�yoruz
            logger.Debug("Debug mesaj�");
            logger.Info("Info mesaj�");
            logger.Warn("Warn mesaj�");
            logger.Error("Error mesaj�");
        }
    }
}
