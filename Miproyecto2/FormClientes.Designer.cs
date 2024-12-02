namespace Miproyecto2
{
    partial class FormClientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.salbtn = new System.Windows.Forms.Button();
            this.agbtn = new System.Windows.Forms.Button();
            this.dtgclientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbclave = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgclientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.editbtn);
            this.panel2.Controls.Add(this.salbtn);
            this.panel2.Controls.Add(this.agbtn);
            this.panel2.Location = new System.Drawing.Point(5, 168);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 80);
            this.panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(309, 33);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 22);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(218, 33);
            this.editbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(56, 22);
            this.editbtn.TabIndex = 2;
            this.editbtn.Text = "Editar";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // salbtn
            // 
            this.salbtn.Location = new System.Drawing.Point(130, 33);
            this.salbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salbtn.Name = "salbtn";
            this.salbtn.Size = new System.Drawing.Size(56, 22);
            this.salbtn.TabIndex = 1;
            this.salbtn.Text = "Salir";
            this.salbtn.UseVisualStyleBackColor = true;
            this.salbtn.Click += new System.EventHandler(this.salbtn_Click);
            // 
            // agbtn
            // 
            this.agbtn.Location = new System.Drawing.Point(28, 29);
            this.agbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.agbtn.Name = "agbtn";
            this.agbtn.Size = new System.Drawing.Size(56, 26);
            this.agbtn.TabIndex = 0;
            this.agbtn.Text = "Agregar";
            this.agbtn.UseVisualStyleBackColor = true;
            this.agbtn.Click += new System.EventHandler(this.agbtn_Click);
            // 
            // dtgclientes
            // 
            this.dtgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgclientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgclientes.Location = new System.Drawing.Point(0, 252);
            this.dtgclientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgclientes.Name = "dtgclientes";
            this.dtgclientes.RowHeadersWidth = 51;
            this.dtgclientes.RowTemplate.Height = 24;
            this.dtgclientes.Size = new System.Drawing.Size(996, 230);
            this.dtgclientes.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbclave);
            this.panel1.Controls.Add(this.tbtel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbdireccion);
            this.panel1.Controls.Add(this.tbnombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 162);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Clave Cliente";
            // 
            // tbclave
            // 
            this.tbclave.Location = new System.Drawing.Point(152, 13);
            this.tbclave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbclave.Name = "tbclave";
            this.tbclave.Size = new System.Drawing.Size(158, 20);
            this.tbclave.TabIndex = 14;
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(152, 124);
            this.tbtel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(158, 20);
            this.tbtel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número Telefonico";
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(152, 85);
            this.tbdireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(158, 20);
            this.tbdireccion.TabIndex = 10;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(152, 50);
            this.tbnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(158, 20);
            this.tbnombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgclientes);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgclientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button salbtn;
        private System.Windows.Forms.Button agbtn;
        private System.Windows.Forms.DataGridView dtgclientes;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbclave;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}