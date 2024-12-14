using NLog;

namespace VeriketForms
{
    public partial class Form1 : Form
    {
        // Logger'� burada tan�ml�yoruz, s�n�f�n her yerinde eri�ilebilir.
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

            // DataGridView'e �rnek veri ekliyoruz (iste�e ba�l�)
            dtgList.Rows.Add("�rnek Veri 1");
            dtgList.Rows.Add("�rnek Veri 2");

            // Buton t�klama olay�n� DataGridView i�in ba�lama
            dtgList.CellContentClick += dtgList_CellContentClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Butona t�kland���nda log mesajlar�n� yazd�r�yoruz.
         
            logger.Debug("Debug mesaj�");
            logger.Info("Info mesaj�");
            logger.Warn("Warn mesaj�");
            logger.Error("Error mesaj�");
        }

        private void dtgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgList.Columns["btnLog"].Index)
            {
                // Log mesajlar�n� yazd�r�yoruz
                logger.Debug("Debug mesaj�");
                logger.Info("Info mesaj�");
                logger.Warn("Warn mesaj�");
                logger.Error("Error mesaj�");
            }
        }
    }
}
