using NLog;

namespace VeriketForms
{
    public partial class Form1 : Form
    {
        // Logger'ý burada tanýmlýyoruz, sýnýfýn her yerinde eriþilebilir.
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

            // DataGridView'e örnek veri ekliyoruz (isteðe baðlý)
            dtgList.Rows.Add("Örnek Veri 1");
            dtgList.Rows.Add("Örnek Veri 2");

            // Buton týklama olayýný DataGridView için baðlama
            dtgList.CellContentClick += dtgList_CellContentClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Butona týklandýðýnda log mesajlarýný yazdýrýyoruz.
         
            logger.Debug("Debug mesajý");
            logger.Info("Info mesajý");
            logger.Warn("Warn mesajý");
            logger.Error("Error mesajý");
        }

        private void dtgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgList.Columns["btnLog"].Index)
            {
                // Log mesajlarýný yazdýrýyoruz
                logger.Debug("Debug mesajý");
                logger.Info("Info mesajý");
                logger.Warn("Warn mesajý");
                logger.Error("Error mesajý");
            }
        }
    }
}
