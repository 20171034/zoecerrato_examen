
namespace ZoeCerrato_Examen
{
    partial class Multiplos
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
            this.label = new System.Windows.Forms.Label();
            this.digitetextBox = new System.Windows.Forms.TextBox();
            this.calcularbutton = new System.Windows.Forms.Button();
            this.MultiploslistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite el Numero";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(113, 113);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Multiplo";
            // 
            // digitetextBox
            // 
            this.digitetextBox.Location = new System.Drawing.Point(216, 70);
            this.digitetextBox.Name = "digitetextBox";
            this.digitetextBox.Size = new System.Drawing.Size(172, 20);
            this.digitetextBox.TabIndex = 3;
            this.digitetextBox.TextChanged += new System.EventHandler(this.digitetextBox_TextChanged);
            // 
            // calcularbutton
            // 
            this.calcularbutton.Location = new System.Drawing.Point(174, 185);
            this.calcularbutton.Name = "calcularbutton";
            this.calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.calcularbutton.TabIndex = 6;
            this.calcularbutton.Text = "Calcular";
            this.calcularbutton.UseVisualStyleBackColor = true;
            this.calcularbutton.Click += new System.EventHandler(this.calcularbutton_Click);
            // 
            // MultiploslistBox
            // 
            this.MultiploslistBox.FormattingEnabled = true;
            this.MultiploslistBox.Location = new System.Drawing.Point(224, 117);
            this.MultiploslistBox.Name = "MultiploslistBox";
            this.MultiploslistBox.Size = new System.Drawing.Size(163, 30);
            this.MultiploslistBox.TabIndex = 8;
            // 
            // Multiplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 349);
            this.Controls.Add(this.MultiploslistBox);
            this.Controls.Add(this.calcularbutton);
            this.Controls.Add(this.digitetextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "Multiplos";
            this.Text = "Multiplos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox digitetextBox;
        private System.Windows.Forms.Button calcularbutton;
        private System.Windows.Forms.ListBox MultiploslistBox;
    }
}