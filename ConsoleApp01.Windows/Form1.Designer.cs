namespace ConsoleApp01.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lsbFibonacci = new ListBox();
            label1 = new Label();
            txtCantidad = new TextBox();
            btnGenerar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            rbtDesc = new RadioButton();
            rbtAsc = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lsbFibonacci
            // 
            lsbFibonacci.FormattingEnabled = true;
            lsbFibonacci.ItemHeight = 15;
            lsbFibonacci.Location = new Point(60, 132);
            lsbFibonacci.Name = "lsbFibonacci";
            lsbFibonacci.Size = new Size(120, 214);
            lsbFibonacci.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 28);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la cantidad de términos:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(243, 25);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(62, 23);
            txtCantidad.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(68, 63);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 37);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(197, 63);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 37);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(360, 63);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 37);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtDesc);
            groupBox1.Controls.Add(rbtAsc);
            groupBox1.Location = new Point(226, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = " Orden ";
            // 
            // rbtDesc
            // 
            rbtDesc.AutoSize = true;
            rbtDesc.Location = new Point(17, 51);
            rbtDesc.Name = "rbtDesc";
            rbtDesc.Size = new Size(93, 19);
            rbtDesc.TabIndex = 0;
            rbtDesc.Text = "Descendente";
            rbtDesc.UseVisualStyleBackColor = true;
            rbtDesc.CheckedChanged += rbtDesc_CheckedChanged;
            // 
            // rbtAsc
            // 
            rbtAsc.AutoSize = true;
            rbtAsc.Checked = true;
            rbtAsc.Location = new Point(18, 26);
            rbtAsc.Name = "rbtAsc";
            rbtAsc.Size = new Size(87, 19);
            rbtAsc.TabIndex = 0;
            rbtAsc.TabStop = true;
            rbtAsc.Text = "Ascendente";
            rbtAsc.UseVisualStyleBackColor = true;
            rbtAsc.CheckedChanged += rbtAsc_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGenerar);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(lsbFibonacci);
            Name = "Form1";
            Text = "Fibonacci";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbFibonacci;
        private Label label1;
        private TextBox txtCantidad;
        private Button btnGenerar;
        private Button btnLimpiar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private RadioButton rbtDesc;
        private RadioButton rbtAsc;
    }
}
