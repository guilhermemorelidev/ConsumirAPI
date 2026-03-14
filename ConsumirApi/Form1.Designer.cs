namespace ConsumirApi
{
    partial class FrmApi
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnBuscar = new Button();
            txtBuscarApi = new TextBox();
            dgvFeriados = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(186, 25);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 33);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarApi
            // 
            txtBuscarApi.AccessibleDescription = "Informe um ano";
            txtBuscarApi.AccessibleName = "";
            txtBuscarApi.BackColor = SystemColors.Window;
            txtBuscarApi.Location = new Point(13, 31);
            txtBuscarApi.Margin = new Padding(4, 3, 4, 3);
            txtBuscarApi.Name = "txtBuscarApi";
            txtBuscarApi.Size = new Size(167, 23);
            txtBuscarApi.TabIndex = 2;
            txtBuscarApi.TextChanged += txtBuscarApi_TextChanged;
            // 
            // dgvFeriados
            // 
            dgvFeriados.AllowUserToAddRows = false;
            dgvFeriados.AllowUserToDeleteRows = false;
            dgvFeriados.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvFeriados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeriados.Columns.AddRange(new DataGridViewColumn[] { Data, Nome, Tipo });
            dgvFeriados.Location = new Point(12, 63);
            dgvFeriados.Margin = new Padding(4, 3, 4, 3);
            dgvFeriados.Name = "dgvFeriados";
            dgvFeriados.ReadOnly = true;
            dgvFeriados.Size = new Size(518, 348);
            dgvFeriados.TabIndex = 3;
            dgvFeriados.CellContentClick += dgvFeriados_CellContentClick;
            // 
            // Data
            // 
            Data.DataPropertyName = "date";
            dataGridViewCellStyle1.Format = "d";
            Data.DefaultCellStyle = dataGridViewCellStyle1;
            Data.HeaderText = "Data Feriado";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.ToolTipText = "Data do Feriado Brasil";
            Data.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "name";
            Nome.HeaderText = "Descrição ";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "type";
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 150;
            // 
            // FrmApi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(539, 410);
            Controls.Add(dgvFeriados);
            Controls.Add(txtBuscarApi);
            Controls.Add(btnBuscar);
            Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmApi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "API";
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtBuscarApi;
        private DataGridView dgvFeriados;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tipo;
    }
}
