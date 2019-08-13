namespace Propuesta2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.dataGridPedido = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalPedidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de pedidos por cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del cliente";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(625, 72);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(136, 31);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Consultar";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(257, 77);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(362, 24);
            this.comboBoxClient.TabIndex = 3;
            // 
            // dataGridPedido
            // 
            this.dataGridPedido.AllowUserToAddRows = false;
            this.dataGridPedido.AllowUserToDeleteRows = false;
            this.dataGridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedido.Location = new System.Drawing.Point(18, 124);
            this.dataGridPedido.Name = "dataGridPedido";
            this.dataGridPedido.ReadOnly = true;
            this.dataGridPedido.RowHeadersWidth = 51;
            this.dataGridPedido.RowTemplate.Height = 24;
            this.dataGridPedido.Size = new System.Drawing.Size(743, 150);
            this.dataGridPedido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(342, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL DE PEDIDOS";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // labelTotalPedidos
            // 
            this.labelTotalPedidos.AutoSize = true;
            this.labelTotalPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelTotalPedidos.Location = new System.Drawing.Point(641, 314);
            this.labelTotalPedidos.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelTotalPedidos.Name = "labelTotalPedidos";
            this.labelTotalPedidos.Size = new System.Drawing.Size(120, 33);
            this.labelTotalPedidos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridPedido);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de Negocios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.DataGridView dataGridPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalPedidos;
    }
}

