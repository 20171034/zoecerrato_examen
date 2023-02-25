
namespace ZoeCerrato_Examen
{
    partial class Factura
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
            this.label3 = new System.Windows.Forms.Label();
            this.productostextbox = new System.Windows.Forms.TextBox();
            this.cantidadtextBox = new System.Windows.Forms.TextBox();
            this.descuentotextBox = new System.Windows.Forms.TextBox();
            this.preciotextBox = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "descuento";
            // 
            // productostextbox
            // 
            this.productostextbox.Location = new System.Drawing.Point(195, 27);
            this.productostextbox.Name = "productostextbox";
            this.productostextbox.Size = new System.Drawing.Size(176, 20);
            this.productostextbox.TabIndex = 3;
            // 
            // cantidadtextBox
            // 
            this.cantidadtextBox.Location = new System.Drawing.Point(195, 61);
            this.cantidadtextBox.Name = "cantidadtextBox";
            this.cantidadtextBox.Size = new System.Drawing.Size(176, 20);
            this.cantidadtextBox.TabIndex = 4;
            // 
            // descuentotextBox
            // 
            this.descuentotextBox.Location = new System.Drawing.Point(195, 112);
            this.descuentotextBox.Name = "descuentotextBox";
            this.descuentotextBox.Size = new System.Drawing.Size(176, 20);
            this.descuentotextBox.TabIndex = 5;
            // 
            // preciotextBox
            // 
            this.preciotextBox.Location = new System.Drawing.Point(195, 87);
            this.preciotextBox.Name = "preciotextBox";
            this.preciotextBox.Size = new System.Drawing.Size(176, 20);
            this.preciotextBox.TabIndex = 6;
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(103, 87);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(57, 13);
            this.precio.TabIndex = 7;
            this.precio.Text = "descuento";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(157, 186);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 8;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 323);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.preciotextBox);
            this.Controls.Add(this.descuentotextBox);
            this.Controls.Add(this.cantidadtextBox);
            this.Controls.Add(this.productostextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productostextbox;
        private System.Windows.Forms.TextBox cantidadtextBox;
        private System.Windows.Forms.TextBox descuentotextBox;
        private System.Windows.Forms.TextBox preciotextBox;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Button calcular;
    }
}