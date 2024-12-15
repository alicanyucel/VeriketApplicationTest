using NLog;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace VeriketForm
{
    public partial class Form1 : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private Timer _timer;

        public Form1()
        {

            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 60000; // 1 dakika
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadLogs();
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void LoadLogs()
        {
            string logFilePath = @"C:\Logs\log.csv";

            if (File.Exists(logFilePath))
            {
                var logLines = File.ReadAllLines(logFilePath);
                var dataTable = new System.Data.DataTable();

                // DataGridView i�in s�tunlar ekleyelim
                dataTable.Columns.Add("Tarih");
                dataTable.Columns.Add("Kullan�c� Ad�");
                dataTable.Columns.Add("Bilgisayar Ad�");

                // Her bir sat�r i�in veriyi tabloya ekleyelim
                foreach (var line in logLines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        dataTable.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }

                // DataGridView'e veri bind etme
                dtgList.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Log dosyas� bulunamad�.");
            }
        }
    

        // button1 t�klama olay�, t�m sat�rlara log mesaj� yazacak
        private void button1_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }
    }
}
