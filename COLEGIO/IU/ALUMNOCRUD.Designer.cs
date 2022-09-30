namespace COLEGIO.IU
{
    partial class ALUMNOCRUD
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
            this.DATA_VIEW = new System.Windows.Forms.GroupBox();
            this.DATAGRID = new System.Windows.Forms.DataGridView();
            this.CRUD_BOX = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CRUD_LABEL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DNI_TEXT = new System.Windows.Forms.TextBox();
            this.NAME_TEXT = new System.Windows.Forms.TextBox();
            this.P_APELLIDO_TEXT = new System.Windows.Forms.TextBox();
            this.M_APELLIDO_TEXT = new System.Windows.Forms.TextBox();
            this.TELEFONO_TEXT = new System.Windows.Forms.TextBox();
            this.CELULAR_TEXT = new System.Windows.Forms.TextBox();
            this.DIRECCION_TEXT = new System.Windows.Forms.TextBox();
            this.CORREO_TEXT = new System.Windows.Forms.TextBox();
            this.FECHA = new System.Windows.Forms.DateTimePicker();
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.UPDATE_BTN = new System.Windows.Forms.Button();
            this.DELETE_BTN = new System.Windows.Forms.Button();
            this.SEARCH_TXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SEARCH_BTN = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.NUMERIC = new System.Windows.Forms.NumericUpDown();
            this.REFRESH_BTN = new System.Windows.Forms.Button();
            this.SEARCH_1_BTN = new System.Windows.Forms.Button();
            this.DATA_VIEW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRID)).BeginInit();
            this.CRUD_BOX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMERIC)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA_VIEW
            // 
            this.DATA_VIEW.Controls.Add(this.REFRESH_BTN);
            this.DATA_VIEW.Controls.Add(this.SEARCH_BTN);
            this.DATA_VIEW.Controls.Add(this.label10);
            this.DATA_VIEW.Controls.Add(this.SEARCH_TXT);
            this.DATA_VIEW.Controls.Add(this.DATAGRID);
            this.DATA_VIEW.Location = new System.Drawing.Point(616, 80);
            this.DATA_VIEW.Name = "DATA_VIEW";
            this.DATA_VIEW.Size = new System.Drawing.Size(614, 472);
            this.DATA_VIEW.TabIndex = 0;
            this.DATA_VIEW.TabStop = false;
            this.DATA_VIEW.Text = "DATOS";
            // 
            // DATAGRID
            // 
            this.DATAGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRID.Location = new System.Drawing.Point(22, 80);
            this.DATAGRID.Name = "DATAGRID";
            this.DATAGRID.Size = new System.Drawing.Size(568, 364);
            this.DATAGRID.TabIndex = 0;
            this.DATAGRID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGRID_CellContentClick);
            // 
            // CRUD_BOX
            // 
            this.CRUD_BOX.Controls.Add(this.SEARCH_1_BTN);
            this.CRUD_BOX.Controls.Add(this.NUMERIC);
            this.CRUD_BOX.Controls.Add(this.label11);
            this.CRUD_BOX.Controls.Add(this.DELETE_BTN);
            this.CRUD_BOX.Controls.Add(this.UPDATE_BTN);
            this.CRUD_BOX.Controls.Add(this.ADD_BTN);
            this.CRUD_BOX.Controls.Add(this.FECHA);
            this.CRUD_BOX.Controls.Add(this.CORREO_TEXT);
            this.CRUD_BOX.Controls.Add(this.DIRECCION_TEXT);
            this.CRUD_BOX.Controls.Add(this.CELULAR_TEXT);
            this.CRUD_BOX.Controls.Add(this.TELEFONO_TEXT);
            this.CRUD_BOX.Controls.Add(this.M_APELLIDO_TEXT);
            this.CRUD_BOX.Controls.Add(this.P_APELLIDO_TEXT);
            this.CRUD_BOX.Controls.Add(this.NAME_TEXT);
            this.CRUD_BOX.Controls.Add(this.DNI_TEXT);
            this.CRUD_BOX.Controls.Add(this.label9);
            this.CRUD_BOX.Controls.Add(this.label8);
            this.CRUD_BOX.Controls.Add(this.label7);
            this.CRUD_BOX.Controls.Add(this.label6);
            this.CRUD_BOX.Controls.Add(this.label5);
            this.CRUD_BOX.Controls.Add(this.label4);
            this.CRUD_BOX.Controls.Add(this.label3);
            this.CRUD_BOX.Controls.Add(this.label2);
            this.CRUD_BOX.Controls.Add(this.label1);
            this.CRUD_BOX.Location = new System.Drawing.Point(15, 80);
            this.CRUD_BOX.Name = "CRUD_BOX";
            this.CRUD_BOX.Size = new System.Drawing.Size(581, 472);
            this.CRUD_BOX.TabIndex = 1;
            this.CRUD_BOX.TabStop = false;
            this.CRUD_BOX.Text = "DATOS ALUMNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRES:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // CRUD_LABEL
            // 
            this.CRUD_LABEL.AutoSize = true;
            this.CRUD_LABEL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD_LABEL.Location = new System.Drawing.Point(446, 34);
            this.CRUD_LABEL.Name = "CRUD_LABEL";
            this.CRUD_LABEL.Size = new System.Drawing.Size(327, 43);
            this.CRUD_LABEL.TabIndex = 2;
            this.CRUD_LABEL.Text = "CRUD ALUMNOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO PATERNO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO MATERNO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFONO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "CELULAR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "DIRECCIÓN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "CORREO ELECTRÓNICO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "FECHA DE NACIMIENTO:";
            // 
            // DNI_TEXT
            // 
            this.DNI_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI_TEXT.Location = new System.Drawing.Point(266, 21);
            this.DNI_TEXT.Name = "DNI_TEXT";
            this.DNI_TEXT.Size = new System.Drawing.Size(149, 24);
            this.DNI_TEXT.TabIndex = 9;
            // 
            // NAME_TEXT
            // 
            this.NAME_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME_TEXT.Location = new System.Drawing.Point(188, 77);
            this.NAME_TEXT.Name = "NAME_TEXT";
            this.NAME_TEXT.Size = new System.Drawing.Size(371, 24);
            this.NAME_TEXT.TabIndex = 10;
            // 
            // P_APELLIDO_TEXT
            // 
            this.P_APELLIDO_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_APELLIDO_TEXT.Location = new System.Drawing.Point(188, 117);
            this.P_APELLIDO_TEXT.Name = "P_APELLIDO_TEXT";
            this.P_APELLIDO_TEXT.Size = new System.Drawing.Size(371, 24);
            this.P_APELLIDO_TEXT.TabIndex = 11;
            // 
            // M_APELLIDO_TEXT
            // 
            this.M_APELLIDO_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_APELLIDO_TEXT.Location = new System.Drawing.Point(188, 155);
            this.M_APELLIDO_TEXT.Name = "M_APELLIDO_TEXT";
            this.M_APELLIDO_TEXT.Size = new System.Drawing.Size(371, 24);
            this.M_APELLIDO_TEXT.TabIndex = 12;
            // 
            // TELEFONO_TEXT
            // 
            this.TELEFONO_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TELEFONO_TEXT.Location = new System.Drawing.Point(114, 205);
            this.TELEFONO_TEXT.Name = "TELEFONO_TEXT";
            this.TELEFONO_TEXT.Size = new System.Drawing.Size(152, 24);
            this.TELEFONO_TEXT.TabIndex = 13;
            // 
            // CELULAR_TEXT
            // 
            this.CELULAR_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CELULAR_TEXT.Location = new System.Drawing.Point(359, 205);
            this.CELULAR_TEXT.Name = "CELULAR_TEXT";
            this.CELULAR_TEXT.Size = new System.Drawing.Size(200, 24);
            this.CELULAR_TEXT.TabIndex = 14;
            // 
            // DIRECCION_TEXT
            // 
            this.DIRECCION_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIRECCION_TEXT.Location = new System.Drawing.Point(114, 251);
            this.DIRECCION_TEXT.Name = "DIRECCION_TEXT";
            this.DIRECCION_TEXT.Size = new System.Drawing.Size(445, 24);
            this.DIRECCION_TEXT.TabIndex = 15;
            // 
            // CORREO_TEXT
            // 
            this.CORREO_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CORREO_TEXT.Location = new System.Drawing.Point(222, 291);
            this.CORREO_TEXT.Name = "CORREO_TEXT";
            this.CORREO_TEXT.Size = new System.Drawing.Size(337, 24);
            this.CORREO_TEXT.TabIndex = 16;
            // 
            // FECHA
            // 
            this.FECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHA.Location = new System.Drawing.Point(222, 328);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(337, 24);
            this.FECHA.TabIndex = 18;
            this.FECHA.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_BTN.Location = new System.Drawing.Point(159, 385);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(107, 59);
            this.ADD_BTN.TabIndex = 19;
            this.ADD_BTN.Text = "AÑADIR";
            this.ADD_BTN.UseVisualStyleBackColor = true;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // UPDATE_BTN
            // 
            this.UPDATE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE_BTN.Location = new System.Drawing.Point(295, 385);
            this.UPDATE_BTN.Name = "UPDATE_BTN";
            this.UPDATE_BTN.Size = new System.Drawing.Size(120, 59);
            this.UPDATE_BTN.TabIndex = 20;
            this.UPDATE_BTN.Text = "ACTUALIZAR";
            this.UPDATE_BTN.UseVisualStyleBackColor = true;
            this.UPDATE_BTN.Click += new System.EventHandler(this.UPDATE_BTN_Click);
            // 
            // DELETE_BTN
            // 
            this.DELETE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE_BTN.Location = new System.Drawing.Point(439, 385);
            this.DELETE_BTN.Name = "DELETE_BTN";
            this.DELETE_BTN.Size = new System.Drawing.Size(120, 59);
            this.DELETE_BTN.TabIndex = 21;
            this.DELETE_BTN.Text = "ELIMINAR";
            this.DELETE_BTN.UseVisualStyleBackColor = true;
            this.DELETE_BTN.Click += new System.EventHandler(this.DELETE_BTN_Click);
            // 
            // SEARCH_TXT
            // 
            this.SEARCH_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_TXT.Location = new System.Drawing.Point(106, 33);
            this.SEARCH_TXT.Name = "SEARCH_TXT";
            this.SEARCH_TXT.Size = new System.Drawing.Size(231, 24);
            this.SEARCH_TXT.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "BUSCAR:";
            // 
            // SEARCH_BTN
            // 
            this.SEARCH_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_BTN.Location = new System.Drawing.Point(357, 24);
            this.SEARCH_BTN.Name = "SEARCH_BTN";
            this.SEARCH_BTN.Size = new System.Drawing.Size(107, 42);
            this.SEARCH_BTN.TabIndex = 22;
            this.SEARCH_BTN.Text = "BUSCAR";
            this.SEARCH_BTN.UseVisualStyleBackColor = true;
            this.SEARCH_BTN.Click += new System.EventHandler(this.SEARCH_BTN_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "ID:";
            // 
            // NUMERIC
            // 
            this.NUMERIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NUMERIC.Location = new System.Drawing.Point(41, 22);
            this.NUMERIC.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NUMERIC.Name = "NUMERIC";
            this.NUMERIC.Size = new System.Drawing.Size(168, 24);
            this.NUMERIC.TabIndex = 24;
            // 
            // REFRESH_BTN
            // 
            this.REFRESH_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REFRESH_BTN.Location = new System.Drawing.Point(470, 24);
            this.REFRESH_BTN.Name = "REFRESH_BTN";
            this.REFRESH_BTN.Size = new System.Drawing.Size(120, 42);
            this.REFRESH_BTN.TabIndex = 23;
            this.REFRESH_BTN.Text = "ACTUALIZAR";
            this.REFRESH_BTN.UseVisualStyleBackColor = true;
            this.REFRESH_BTN.Click += new System.EventHandler(this.REFRESH_BTN_Click);
            // 
            // SEARCH_1_BTN
            // 
            this.SEARCH_1_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_1_BTN.Location = new System.Drawing.Point(452, 12);
            this.SEARCH_1_BTN.Name = "SEARCH_1_BTN";
            this.SEARCH_1_BTN.Size = new System.Drawing.Size(107, 42);
            this.SEARCH_1_BTN.TabIndex = 24;
            this.SEARCH_1_BTN.Text = "BUSCAR";
            this.SEARCH_1_BTN.UseVisualStyleBackColor = true;
            this.SEARCH_1_BTN.Click += new System.EventHandler(this.SEARCH_1_BTN_Click);
            // 
            // ALUMNOCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 596);
            this.Controls.Add(this.CRUD_LABEL);
            this.Controls.Add(this.CRUD_BOX);
            this.Controls.Add(this.DATA_VIEW);
            this.Name = "ALUMNOCRUD";
            this.Text = "ALUMNOCRUD";
            this.Load += new System.EventHandler(this.ALUMNOCRUD_Load);
            this.DATA_VIEW.ResumeLayout(false);
            this.DATA_VIEW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRID)).EndInit();
            this.CRUD_BOX.ResumeLayout(false);
            this.CRUD_BOX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMERIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DATA_VIEW;
        private System.Windows.Forms.DataGridView DATAGRID;
        private System.Windows.Forms.GroupBox CRUD_BOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CRUD_LABEL;
        private System.Windows.Forms.DateTimePicker FECHA;
        private System.Windows.Forms.TextBox CORREO_TEXT;
        private System.Windows.Forms.TextBox DIRECCION_TEXT;
        private System.Windows.Forms.TextBox CELULAR_TEXT;
        private System.Windows.Forms.TextBox TELEFONO_TEXT;
        private System.Windows.Forms.TextBox M_APELLIDO_TEXT;
        private System.Windows.Forms.TextBox P_APELLIDO_TEXT;
        private System.Windows.Forms.TextBox NAME_TEXT;
        private System.Windows.Forms.TextBox DNI_TEXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SEARCH_BTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SEARCH_TXT;
        private System.Windows.Forms.Button DELETE_BTN;
        private System.Windows.Forms.Button UPDATE_BTN;
        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NUMERIC;
        private System.Windows.Forms.Button REFRESH_BTN;
        private System.Windows.Forms.Button SEARCH_1_BTN;
    }
}