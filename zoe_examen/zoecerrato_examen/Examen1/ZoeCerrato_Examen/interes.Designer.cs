
namespace ZoeCerrato_Examen
{
    partial class interes
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
            this.label1 = new System.Windows.Forms.Label();
            this.depositotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listamesesBox = new System.Windows.Forms.ListBox();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a Depositar: ";
            // 
            // depositotextBox
            // 
            this.depositotextBox.Location = new System.Drawing.Point(339, 51);
            this.depositotextBox.Name = "depositotextBox";
            this.depositotextBox.Size = new System.Drawing.Size(200, 20);
            this.depositotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el mes:  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listamesesBox
            // 
            this.listamesesBox.FormattingEnabled = true;
            this.listamesesBox.Location = new System.Drawing.Point(339, 110);
            this.listamesesBox.Name = "listamesesBox";
            this.listamesesBox.Size = new System.Drawing.Size(200, 95);
            this.listamesesBox.TabIndex = 4;
            this.listamesesBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(415, 327);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(108, 23);
            this.Limpiarbutton.TabIndex = 8;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(262, 327);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(94, 23);
            this.Calcularbutton.TabIndex = 7;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // interes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.listamesesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depositotextBox);
            this.Controls.Add(this.label1);
            this.Name = "interes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depositotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listamesesBox;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.Button Calcularbutton;
    }
}

