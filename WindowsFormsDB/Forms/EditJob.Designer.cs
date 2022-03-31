
namespace WindowsFormsDB
{
    partial class EditJob
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
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtSalMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAcceptModify = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puesto";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(189, 78);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(100, 20);
            this.txtPuesto.TabIndex = 2;
            // 
            // txtSalMin
            // 
            this.txtSalMin.Location = new System.Drawing.Point(189, 115);
            this.txtSalMin.Name = "txtSalMin";
            this.txtSalMin.Size = new System.Drawing.Size(100, 20);
            this.txtSalMin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suelo Minimo";
            // 
            // txtSalMax
            // 
            this.txtSalMax.Location = new System.Drawing.Point(189, 152);
            this.txtSalMax.Name = "txtSalMax";
            this.txtSalMax.Size = new System.Drawing.Size(100, 20);
            this.txtSalMax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sueldo Maixmo";
            // 
            // btnAcceptModify
            // 
            this.btnAcceptModify.Location = new System.Drawing.Point(274, 209);
            this.btnAcceptModify.Name = "btnAcceptModify";
            this.btnAcceptModify.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptModify.TabIndex = 7;
            this.btnAcceptModify.Text = "Modificar";
            this.btnAcceptModify.UseVisualStyleBackColor = true;
            this.btnAcceptModify.Click += new System.EventHandler(this.btnAcceptModify_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 235);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAcceptModify);
            this.Controls.Add(this.txtSalMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditJob";
            this.Text = "EditJob";
            this.Load += new System.EventHandler(this.EditJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtSalMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAcceptModify;
        private System.Windows.Forms.Button button2;
    }
}