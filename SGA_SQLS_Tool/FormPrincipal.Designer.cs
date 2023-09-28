namespace SGA_SQLS_Tool
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.b_borrarBD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_DataSource = new System.Windows.Forms.TextBox();
            this.b_comprobar = new System.Windows.Forms.Button();
            this.b_generarArchivoServerCFG = new System.Windows.Forms.Button();
            this.b_restaurarCS = new System.Windows.Forms.Button();
            this.b_realizarCS = new System.Windows.Forms.Button();
            this.b_nuevaBD = new System.Windows.Forms.Button();
            this.l_estadoDeLaConexion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_db_name = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_psw = new System.Windows.Forms.TextBox();
            this.t_comprobarConexion = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_borrarBD
            // 
            this.b_borrarBD.Enabled = false;
            this.b_borrarBD.Location = new System.Drawing.Point(17, 184);
            this.b_borrarBD.Name = "b_borrarBD";
            this.b_borrarBD.Size = new System.Drawing.Size(360, 25);
            this.b_borrarBD.TabIndex = 14;
            this.b_borrarBD.Text = "Eliminar la base de datos";
            this.b_borrarBD.UseVisualStyleBackColor = true;
            this.b_borrarBD.Click += new System.EventHandler(this.b_borrarBD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_DataSource);
            this.groupBox2.Controls.Add(this.b_comprobar);
            this.groupBox2.Location = new System.Drawing.Point(17, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 40);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSource";
            // 
            // tb_DataSource
            // 
            this.tb_DataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DataSource.Location = new System.Drawing.Point(3, 16);
            this.tb_DataSource.Name = "tb_DataSource";
            this.tb_DataSource.Size = new System.Drawing.Size(279, 20);
            this.tb_DataSource.TabIndex = 0;
            // 
            // b_comprobar
            // 
            this.b_comprobar.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_comprobar.Location = new System.Drawing.Point(282, 16);
            this.b_comprobar.Name = "b_comprobar";
            this.b_comprobar.Size = new System.Drawing.Size(75, 21);
            this.b_comprobar.TabIndex = 1;
            this.b_comprobar.Text = "Comprobar";
            this.b_comprobar.UseVisualStyleBackColor = true;
            this.b_comprobar.Click += new System.EventHandler(this.t_comprobarConexion_Tick);
            // 
            // b_generarArchivoServerCFG
            // 
            this.b_generarArchivoServerCFG.Enabled = false;
            this.b_generarArchivoServerCFG.Location = new System.Drawing.Point(17, 310);
            this.b_generarArchivoServerCFG.Name = "b_generarArchivoServerCFG";
            this.b_generarArchivoServerCFG.Size = new System.Drawing.Size(360, 25);
            this.b_generarArchivoServerCFG.TabIndex = 12;
            this.b_generarArchivoServerCFG.Text = "Crear un archivo server.cfg";
            this.b_generarArchivoServerCFG.UseVisualStyleBackColor = true;
            this.b_generarArchivoServerCFG.Click += new System.EventHandler(this.b_generarArchivoServerCFG_Click);
            // 
            // b_restaurarCS
            // 
            this.b_restaurarCS.Enabled = false;
            this.b_restaurarCS.Location = new System.Drawing.Point(17, 279);
            this.b_restaurarCS.Name = "b_restaurarCS";
            this.b_restaurarCS.Size = new System.Drawing.Size(360, 25);
            this.b_restaurarCS.TabIndex = 11;
            this.b_restaurarCS.Text = "Restaurar una copia de seguridad antigua";
            this.b_restaurarCS.UseVisualStyleBackColor = true;
            this.b_restaurarCS.Click += new System.EventHandler(this.b_restaurarCS_Click);
            // 
            // b_realizarCS
            // 
            this.b_realizarCS.Enabled = false;
            this.b_realizarCS.Location = new System.Drawing.Point(17, 248);
            this.b_realizarCS.Name = "b_realizarCS";
            this.b_realizarCS.Size = new System.Drawing.Size(360, 25);
            this.b_realizarCS.TabIndex = 10;
            this.b_realizarCS.Text = "Realizar copia de seguridad de la base de datos";
            this.b_realizarCS.UseVisualStyleBackColor = true;
            this.b_realizarCS.Click += new System.EventHandler(this.b_realizarCS_Click);
            // 
            // b_nuevaBD
            // 
            this.b_nuevaBD.Enabled = false;
            this.b_nuevaBD.Location = new System.Drawing.Point(17, 153);
            this.b_nuevaBD.Name = "b_nuevaBD";
            this.b_nuevaBD.Size = new System.Drawing.Size(360, 25);
            this.b_nuevaBD.TabIndex = 9;
            this.b_nuevaBD.Text = "Crear BD";
            this.b_nuevaBD.UseVisualStyleBackColor = true;
            this.b_nuevaBD.Click += new System.EventHandler(this.b_nuevaBD_Click);
            // 
            // l_estadoDeLaConexion
            // 
            this.l_estadoDeLaConexion.AutoSize = true;
            this.l_estadoDeLaConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_estadoDeLaConexion.Location = new System.Drawing.Point(121, 53);
            this.l_estadoDeLaConexion.Name = "l_estadoDeLaConexion";
            this.l_estadoDeLaConexion.Size = new System.Drawing.Size(152, 16);
            this.l_estadoDeLaConexion.TabIndex = 8;
            this.l_estadoDeLaConexion.Text = "Comprobando conexión";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_db_name);
            this.groupBox1.Location = new System.Drawing.Point(17, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 40);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre BD";
            // 
            // tb_db_name
            // 
            this.tb_db_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_db_name.Location = new System.Drawing.Point(3, 16);
            this.tb_db_name.Name = "tb_db_name";
            this.tb_db_name.Size = new System.Drawing.Size(122, 20);
            this.tb_db_name.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_user);
            this.groupBox3.Location = new System.Drawing.Point(148, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 40);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario";
            // 
            // tb_user
            // 
            this.tb_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_user.Location = new System.Drawing.Point(3, 16);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(92, 20);
            this.tb_user.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_psw);
            this.groupBox4.Location = new System.Drawing.Point(249, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 40);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PSW";
            // 
            // tb_psw
            // 
            this.tb_psw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_psw.Location = new System.Drawing.Point(3, 16);
            this.tb_psw.Name = "tb_psw";
            this.tb_psw.PasswordChar = '*';
            this.tb_psw.Size = new System.Drawing.Size(122, 20);
            this.tb_psw.TabIndex = 0;
            // 
            // t_comprobarConexion
            // 
            this.t_comprobarConexion.Tick += new System.EventHandler(this.t_comprobarConexion_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 347);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_borrarBD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_generarArchivoServerCFG);
            this.Controls.Add(this.b_restaurarCS);
            this.Controls.Add(this.b_realizarCS);
            this.Controls.Add(this.b_nuevaBD);
            this.Controls.Add(this.l_estadoDeLaConexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA SQL Server Tools";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_borrarBD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_DataSource;
        private System.Windows.Forms.Button b_comprobar;
        private System.Windows.Forms.Button b_generarArchivoServerCFG;
        private System.Windows.Forms.Button b_restaurarCS;
        private System.Windows.Forms.Button b_realizarCS;
        private System.Windows.Forms.Button b_nuevaBD;
        private System.Windows.Forms.Label l_estadoDeLaConexion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_db_name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_psw;
        private System.Windows.Forms.Timer t_comprobarConexion;
    }
}

