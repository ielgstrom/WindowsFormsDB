
namespace WindowsFormsDB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInsertJob = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSalarioMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSalarioMIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombreJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.deletePosicion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInsertJob
            // 
            this.buttonInsertJob.Enabled = false;
            this.buttonInsertJob.Location = new System.Drawing.Point(442, 19);
            this.buttonInsertJob.Name = "buttonInsertJob";
            this.buttonInsertJob.Size = new System.Drawing.Size(51, 48);
            this.buttonInsertJob.TabIndex = 3;
            this.buttonInsertJob.Text = "Insertar Trabajo";
            this.buttonInsertJob.UseVisualStyleBackColor = true;
            this.buttonInsertJob.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Enabled = false;
            this.buttonSelect.Location = new System.Drawing.Point(14, 129);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(103, 23);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Mostrar Trabajos";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.Location = new System.Drawing.Point(14, 158);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(498, 134);
            this.listBoxJobs.TabIndex = 5;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSalarioMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textSalarioMIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNombreJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonInsertJob);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Trabajo";
            // 
            // textSalarioMax
            // 
            this.textSalarioMax.Enabled = false;
            this.textSalarioMax.Location = new System.Drawing.Point(234, 47);
            this.textSalarioMax.Name = "textSalarioMax";
            this.textSalarioMax.Size = new System.Drawing.Size(100, 20);
            this.textSalarioMax.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "salario Maximo";
            // 
            // textSalarioMIN
            // 
            this.textSalarioMIN.Enabled = false;
            this.textSalarioMIN.Location = new System.Drawing.Point(128, 47);
            this.textSalarioMIN.Name = "textSalarioMIN";
            this.textSalarioMIN.Size = new System.Drawing.Size(100, 20);
            this.textSalarioMIN.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salario Minimo";
            // 
            // textNombreJob
            // 
            this.textNombreJob.Enabled = false;
            this.textNombreJob.Location = new System.Drawing.Point(22, 47);
            this.textNombreJob.Name = "textNombreJob";
            this.textNombreJob.Size = new System.Drawing.Size(100, 20);
            this.textNombreJob.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo Posicion";
            // 
            // btnChangeData
            // 
            this.btnChangeData.Location = new System.Drawing.Point(14, 299);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(121, 25);
            this.btnChangeData.TabIndex = 7;
            this.btnChangeData.Text = "Cambiar Datos";
            this.btnChangeData.UseVisualStyleBackColor = true;
            this.btnChangeData.Visible = false;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // deletePosicion
            // 
            this.deletePosicion.Location = new System.Drawing.Point(402, 300);
            this.deletePosicion.Name = "deletePosicion";
            this.deletePosicion.Size = new System.Drawing.Size(109, 24);
            this.deletePosicion.TabIndex = 8;
            this.deletePosicion.Text = "Eliminar Posicion";
            this.deletePosicion.UseVisualStyleBackColor = true;
            this.deletePosicion.Visible = false;
            this.deletePosicion.Click += new System.EventHandler(this.deletePosicion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 345);
            this.Controls.Add(this.deletePosicion);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.buttonSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonInsertJob;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSalarioMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSalarioMIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombreJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Button deletePosicion;
    }
}

