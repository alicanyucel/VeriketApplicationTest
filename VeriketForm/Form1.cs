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
            buttonColumn.HeaderText = "Log Mesajý";
            buttonColumn.Name = "btnLog";
            buttonColumn.Text = "Log Yaz";
            buttonColumn.UseColumnTextForButtonValue = true;
            dtgList.Columns.Add(buttonColumn);

            // DataGridView'e örnek veri ekliyoruz
            dtgList.Rows.Add("Örnek Veri 1");
            dtgList.Rows.Add("Örnek Veri 2");

            // DataGridView'deki buton týklama olayýný baðlama
            dtgList.CellClick += dtgList_CellClick;
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Buton kolonu týklanmýþsa, loglarý yazdýr
            if (e.ColumnIndex == dtgList.Columns["btnLog"].Index)
            {
                // Log mesajlarýný yazdýrýyoruz
                string logMessage = "Debug: Debug mesajý\nInfo: Info mesajý\nWarn: Warn mesajý\nError: Error mesajý";

                // DataGridView'deki ilgili satýra log mesajý yazdýrýyoruz
                dtgList.Rows[e.RowIndex].Cells["btnLog"].Value = logMessage;

                // Loglarý NLog ile konsola yazdýrýyoruz
                logger.Debug("Debug mesajý");
                logger.Info("Info mesajý");
                logger.Warn("Warn mesajý");
                logger.Error("Error mesajý");
            }
        }

        // button1 týklama olayý, tüm satýrlara log mesajý yazacak
        private void button1_Click(object sender, EventArgs e)
        {
            // Tüm satýrlara log mesajý ekliyoruz
            string logMessage = $"Debug: Debug mesajý\nInfo: Info mesajý\nWarn: Warn mesajý\nError: Error mesajý";

            // DataGridView'e log mesajlarýný yazdýrýyoruz
            foreach (DataGridViewRow row in dtgList.Rows)
            {
                // Log mesajýný her satýra yazýyoruz
                row.Cells["btnLog"].Value = logMessage;
            }

            // Loglarý NLog ile konsola yazdýrýyoruz
            logger.Debug("Debug mesajý");
            logger.Info("Info mesajý");
            logger.Warn("Warn mesajý");
            logger.Error("Error mesajý");
        }
    }
}
