namespace Grafos
{
    partial class FormDialogArbol
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnElementoArbol = new System.Windows.Forms.Button();
            this.TextNodo = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.BtnElementoArbol);
            this.panel1.Controls.Add(this.TextNodo);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 281);
            this.panel1.TabIndex = 0;
            // 
            // BtnElementoArbol
            // 
            this.BtnElementoArbol.BackColor = System.Drawing.Color.Indigo;
            this.BtnElementoArbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElementoArbol.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElementoArbol.ForeColor = System.Drawing.Color.White;
            this.BtnElementoArbol.Location = new System.Drawing.Point(124, 191);
            this.BtnElementoArbol.Name = "BtnElementoArbol";
            this.BtnElementoArbol.Size = new System.Drawing.Size(147, 34);
            this.BtnElementoArbol.TabIndex = 22;
            this.BtnElementoArbol.Text = "Agregar Nodo";
            this.BtnElementoArbol.UseVisualStyleBackColor = false;
            this.BtnElementoArbol.Click += new System.EventHandler(this.BtnElementoArbol_Click);
            // 
            // TextNodo
            // 
            this.TextNodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextNodo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNodo.Location = new System.Drawing.Point(93, 115);
            this.TextNodo.Multiline = true;
            this.TextNodo.Name = "TextNodo";
            this.TextNodo.Size = new System.Drawing.Size(205, 38);
            this.TextNodo.TabIndex = 21;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(343, 1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(48, 42);
            this.BtnCerrar.TabIndex = 19;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(124, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 3);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Agregar Elemento";
            // 
            // FormDialogArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 281);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDialogArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDialogArbol";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextNodo;
        private System.Windows.Forms.Button BtnElementoArbol;
    }
}