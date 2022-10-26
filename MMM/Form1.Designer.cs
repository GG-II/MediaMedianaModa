namespace MMM
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cantfor = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.listaNumero = new System.Windows.Forms.ListBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.agregarv = new System.Windows.Forms.Button();
            this.mediaTxt = new System.Windows.Forms.TextBox();
            this.medianaTxt = new System.Windows.Forms.TextBox();
            this.modaTxt = new System.Windows.Forms.TextBox();
            this.mediaV = new System.Windows.Forms.TextBox();
            this.medianaV = new System.Windows.Forms.TextBox();
            this.modaV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconError = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de números que va a ingresar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cantfor
            // 
            this.cantfor.Location = new System.Drawing.Point(6, 49);
            this.cantfor.Name = "cantfor";
            this.cantfor.Size = new System.Drawing.Size(237, 20);
            this.cantfor.TabIndex = 1;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(168, 75);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // listaNumero
            // 
            this.listaNumero.FormattingEnabled = true;
            this.listaNumero.Location = new System.Drawing.Point(276, 19);
            this.listaNumero.Name = "listaNumero";
            this.listaNumero.Size = new System.Drawing.Size(70, 433);
            this.listaNumero.TabIndex = 3;
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(13, 427);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 23);
            this.nuevo.TabIndex = 4;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(180, 427);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 5;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(164, 108);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // agregarv
            // 
            this.agregarv.Location = new System.Drawing.Point(136, 96);
            this.agregarv.Name = "agregarv";
            this.agregarv.Size = new System.Drawing.Size(100, 23);
            this.agregarv.TabIndex = 7;
            this.agregarv.Text = "Calcular";
            this.agregarv.UseVisualStyleBackColor = true;
            this.agregarv.Click += new System.EventHandler(this.agregarv_Click);
            // 
            // mediaTxt
            // 
            this.mediaTxt.Location = new System.Drawing.Point(139, 22);
            this.mediaTxt.Name = "mediaTxt";
            this.mediaTxt.Size = new System.Drawing.Size(100, 20);
            this.mediaTxt.TabIndex = 8;
            // 
            // medianaTxt
            // 
            this.medianaTxt.Location = new System.Drawing.Point(139, 53);
            this.medianaTxt.Name = "medianaTxt";
            this.medianaTxt.Size = new System.Drawing.Size(100, 20);
            this.medianaTxt.TabIndex = 9;
            // 
            // modaTxt
            // 
            this.modaTxt.Location = new System.Drawing.Point(139, 82);
            this.modaTxt.Name = "modaTxt";
            this.modaTxt.Size = new System.Drawing.Size(100, 20);
            this.modaTxt.TabIndex = 10;
            // 
            // mediaV
            // 
            this.mediaV.Location = new System.Drawing.Point(136, 19);
            this.mediaV.Name = "mediaV";
            this.mediaV.Size = new System.Drawing.Size(100, 20);
            this.mediaV.TabIndex = 11;
            // 
            // medianaV
            // 
            this.medianaV.Location = new System.Drawing.Point(136, 45);
            this.medianaV.Name = "medianaV";
            this.medianaV.Size = new System.Drawing.Size(100, 20);
            this.medianaV.TabIndex = 12;
            // 
            // modaV
            // 
            this.modaV.Location = new System.Drawing.Point(136, 71);
            this.modaV.Name = "modaV";
            this.modaV.Size = new System.Drawing.Size(100, 20);
            this.modaV.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Media";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mediana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Moda";
            // 
            // iconError
            // 
            this.iconError.ContainerControl = this;
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // error3
            // 
            this.error3.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cantfor);
            this.groupBox1.Controls.Add(this.agregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 111);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mediaTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.medianaTxt);
            this.groupBox2.Controls.Add(this.modaTxt);
            this.groupBox2.Controls.Add(this.calcular);
            this.groupBox2.Location = new System.Drawing.Point(13, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 143);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.mediaV);
            this.groupBox3.Controls.Add(this.medianaV);
            this.groupBox3.Controls.Add(this.modaV);
            this.groupBox3.Controls.Add(this.agregarv);
            this.groupBox3.Location = new System.Drawing.Point(13, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 125);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Con Vector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Media";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mediana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Moda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.listaNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iconError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantfor;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.ListBox listaNumero;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button agregarv;
        private System.Windows.Forms.TextBox mediaTxt;
        private System.Windows.Forms.TextBox medianaTxt;
        private System.Windows.Forms.TextBox modaTxt;
        private System.Windows.Forms.TextBox mediaV;
        private System.Windows.Forms.TextBox medianaV;
        private System.Windows.Forms.TextBox modaV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider iconError;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.ErrorProvider error3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

