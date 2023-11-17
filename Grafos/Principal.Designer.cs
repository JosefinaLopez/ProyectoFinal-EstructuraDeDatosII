namespace Grafos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnOptiones = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGrafos = new System.Windows.Forms.Button();
            this.BtnArboles = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.BtnOptiones);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(190, 573);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grafos.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(34, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // BtnOptiones
            // 
            this.BtnOptiones.BackColor = System.Drawing.Color.Indigo;
            this.BtnOptiones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnOptiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnOptiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptiones.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOptiones.ForeColor = System.Drawing.Color.White;
            this.BtnOptiones.Location = new System.Drawing.Point(0, 242);
            this.BtnOptiones.Name = "BtnOptiones";
            this.BtnOptiones.Size = new System.Drawing.Size(190, 50);
            this.BtnOptiones.TabIndex = 19;
            this.BtnOptiones.Text = "Ejercicios";
            this.BtnOptiones.UseVisualStyleBackColor = false;
            this.BtnOptiones.Click += new System.EventHandler(this.BtnOptiones_Click);
            this.BtnOptiones.MouseEnter += new System.EventHandler(this.BtnOptiones_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnGrafos);
            this.panel1.Controls.Add(this.BtnArboles);
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 155);
            this.panel1.TabIndex = 0;
            // 
            // BtnGrafos
            // 
            this.BtnGrafos.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnGrafos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGrafos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.BtnGrafos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnGrafos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrafos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrafos.ForeColor = System.Drawing.Color.White;
            this.BtnGrafos.Location = new System.Drawing.Point(0, 50);
            this.BtnGrafos.Name = "BtnGrafos";
            this.BtnGrafos.Size = new System.Drawing.Size(190, 50);
            this.BtnGrafos.TabIndex = 1;
            this.BtnGrafos.Text = "Grafos";
            this.BtnGrafos.UseVisualStyleBackColor = false;
            this.BtnGrafos.Click += new System.EventHandler(this.BtnGrafos_Click);
            // 
            // BtnArboles
            // 
            this.BtnArboles.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnArboles.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnArboles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.BtnArboles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnArboles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArboles.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArboles.ForeColor = System.Drawing.Color.White;
            this.BtnArboles.Location = new System.Drawing.Point(0, 0);
            this.BtnArboles.Name = "BtnArboles";
            this.BtnArboles.Size = new System.Drawing.Size(190, 50);
            this.BtnArboles.TabIndex = 0;
            this.BtnArboles.Text = "Arboles";
            this.BtnArboles.UseVisualStyleBackColor = false;
            this.BtnArboles.Click += new System.EventHandler(this.BtnArboles_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.BtnCerrar);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.panel2);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(190, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(762, 573);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Click += new System.EventHandler(this.panelChildForm_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(714, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(48, 42);
            this.BtnCerrar.TabIndex = 19;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grafos.Properties.Resources.adasddadadsda;
            this.pictureBox1.Location = new System.Drawing.Point(280, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Josefina Lopez";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(226, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 2);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Trabajo Final de Estructuras de Datos II";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 573);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGrafos;
        private System.Windows.Forms.Button BtnArboles;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button BtnOptiones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}