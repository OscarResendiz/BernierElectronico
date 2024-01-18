using System.ComponentModel;
using System.Data;

namespace Medidor
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort port;
        string error = "";
        public Form1()
        {
            InitializeComponent();
            port = new System.IO.Ports.SerialPort();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] puertos = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string puerto in puertos)
            {
                comboPuerto.Items.Add(puerto);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool iniciar = true;
            bool detener = false;
            if (comboPuerto.SelectedIndex == -1)
                iniciar = false;
            if (port.IsOpen)
            {
                detener = true;
                iniciar = false;
            }
            bntIniciar.Enabled = iniciar;
            bntDetener.Enabled = detener;
        }

        private void bntIniciar_Click(object sender, EventArgs e)
        {
            port.BaudRate = 9600;
            port.DataBits = 8;
            port.PortName = comboPuerto.SelectedItem.ToString();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            error = "";
            try
            {
                port.Open();
                while (port.IsOpen)
                {
                    string linea = port.ReadLine();
                    backgroundWorker1.ReportProgress(0, linea);
                }
            }
            catch (System.Exception ex)
            {
                error = ex.Message;
                if (port.IsOpen)
                    port.Close();
                return;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (error != "")
            {
                MessageBox.Show(error, "Error de comunicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bntDetener_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            System.Data.DataRow row = data1.Tables[0].NewRow();
            row[0] = e.UserState.ToString();
            data1.Tables[0].Rows.Add(row);

        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
            foreach (DataRow row in data1.Tables[0].Rows)
            {
                string s = row[0].ToString();
                sw.WriteLine(s.Replace("\r",""));
            }
            sw.Close();
            MessageBox.Show("Archivo Guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            data1.Clear();
        }
    }
}