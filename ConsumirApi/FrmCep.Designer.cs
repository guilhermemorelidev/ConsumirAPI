namespace ConsumirApi
{
    partial class FrmCep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            dgvCep = new DataGridView();
            btnBuscarCep = new Button();
            txtBuscarCep = new TextBox();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Rua = new DataGridViewTextBoxColumn();
            Neighborhood = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCep).BeginInit();
            SuspendLayout();
            // 
            // dgvCep
            // 
            dgvCep.AllowUserToAddRows = false;
            dgvCep.AllowUserToDeleteRows = false;
            dgvCep.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvCep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCep.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Rua, Neighborhood });
            dgvCep.Location = new Point(43, 72);
            dgvCep.Margin = new Padding(4, 3, 4, 3);
            dgvCep.Name = "dgvCep";
            dgvCep.ReadOnly = true;
            dgvCep.Size = new Size(718, 348);
            dgvCep.TabIndex = 9;
            dgvCep.CellContentClick += dgvCep_CellContentClick;
            // 
            // btnBuscarCep
            // 
            btnBuscarCep.Location = new Point(266, 33);
            btnBuscarCep.Margin = new Padding(4, 3, 4, 3);
            btnBuscarCep.Name = "btnBuscarCep";
            btnBuscarCep.Size = new Size(66, 33);
            btnBuscarCep.TabIndex = 8;
            btnBuscarCep.Text = "Buscar";
            btnBuscarCep.UseVisualStyleBackColor = true;
            btnBuscarCep.Click += btnBuscarCep_Click;
            // 
            // txtBuscarCep
            // 
            txtBuscarCep.AccessibleDescription = "Buscar CEP";
            txtBuscarCep.AccessibleName = "";
            txtBuscarCep.BackColor = SystemColors.Window;
            txtBuscarCep.Location = new Point(91, 39);
            txtBuscarCep.Margin = new Padding(4, 3, 4, 3);
            txtBuscarCep.Name = "txtBuscarCep";
            txtBuscarCep.Size = new Size(167, 23);
            txtBuscarCep.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Cep";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn1.HeaderText = "CEP";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.ToolTipText = "cep da residencia";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "estado";
            dataGridViewTextBoxColumn2.HeaderText = "Estado";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "cidade";
            dataGridViewTextBoxColumn3.HeaderText = "Cidade";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Rua
            // 
            Rua.DataPropertyName = "rua";
            Rua.HeaderText = "Rua ";
            Rua.Name = "Rua";
            Rua.ReadOnly = true;
            // 
            // Neighborhood
            // 
            Neighborhood.DataPropertyName = "nei";
            Neighborhood.HeaderText = "Neigborhood";
            Neighborhood.Name = "Neighborhood";
            Neighborhood.ReadOnly = true;
            // 
            // FrmCep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCep);
            Controls.Add(btnBuscarCep);
            Controls.Add(txtBuscarCep);
            Name = "FrmCep";
            Text = "FrmCep";
            ((System.ComponentModel.ISupportInitialize)dgvCep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCep;
        private Button btnBuscarCep;
        private TextBox txtBuscarCep;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Rua;
        private DataGridViewTextBoxColumn Neighborhood;
    }
}