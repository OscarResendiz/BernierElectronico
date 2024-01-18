namespace Medidor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            bntLimpiar = new Button();
            bntGuardar = new Button();
            bntDetener = new Button();
            bntIniciar = new Button();
            comboPuerto = new ComboBox();
            label1 = new Label();
            data1 = new Data();
            dataGridView1 = new DataGridView();
            datoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bntLimpiar);
            panel1.Controls.Add(bntGuardar);
            panel1.Controls.Add(bntDetener);
            panel1.Controls.Add(bntIniciar);
            panel1.Controls.Add(comboPuerto);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 81);
            panel1.TabIndex = 0;
            // 
            // bntLimpiar
            // 
            bntLimpiar.Location = new Point(748, 19);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(75, 23);
            bntLimpiar.TabIndex = 5;
            bntLimpiar.Text = "Limpia";
            bntLimpiar.UseVisualStyleBackColor = true;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // bntGuardar
            // 
            bntGuardar.Location = new Point(657, 19);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(75, 23);
            bntGuardar.TabIndex = 4;
            bntGuardar.Text = "Guardar";
            bntGuardar.UseVisualStyleBackColor = true;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // bntDetener
            // 
            bntDetener.Location = new Point(563, 19);
            bntDetener.Name = "bntDetener";
            bntDetener.Size = new Size(75, 23);
            bntDetener.TabIndex = 3;
            bntDetener.Text = "Detener";
            bntDetener.UseVisualStyleBackColor = true;
            bntDetener.Click += bntDetener_Click;
            // 
            // bntIniciar
            // 
            bntIniciar.Location = new Point(464, 19);
            bntIniciar.Name = "bntIniciar";
            bntIniciar.Size = new Size(75, 23);
            bntIniciar.TabIndex = 2;
            bntIniciar.Text = "Iniciar";
            bntIniciar.UseVisualStyleBackColor = true;
            bntIniciar.Click += bntIniciar_Click;
            // 
            // comboPuerto
            // 
            comboPuerto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPuerto.FormattingEnabled = true;
            comboPuerto.Location = new Point(93, 19);
            comboPuerto.Name = "comboPuerto";
            comboPuerto.Size = new Size(349, 23);
            comboPuerto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Puerto serial";
            // 
            // data1
            // 
            data1.DataSetName = "Data";
            data1.Namespace = "http://tempuri.org/Data.xsd";
            data1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { datoDataGridViewTextBoxColumn });
            dataGridView1.DataMember = "Datos";
            dataGridView1.DataSource = data1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(947, 369);
            dataGridView1.TabIndex = 1;
            // 
            // datoDataGridViewTextBoxColumn
            // 
            datoDataGridViewTextBoxColumn.DataPropertyName = "Dato";
            datoDataGridViewTextBoxColumn.HeaderText = "Dato";
            datoDataGridViewTextBoxColumn.Name = "datoDataGridViewTextBoxColumn";
            datoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "excel|.csv";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bntDetener;
        private Button bntIniciar;
        private ComboBox comboPuerto;
        private Label label1;
        private Data data1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bntGuardar;
        private SaveFileDialog saveFileDialog1;
        private Button bntLimpiar;
    }
}