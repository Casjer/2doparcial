namespace PrimerParcial.UI.Registro
{
    partial class rmetas
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
            this.components = new System.ComponentModel.Container();
            this.MetaID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MetaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cuotanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MetaIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotanumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MetaID
            // 
            this.MetaID.AutoSize = true;
            this.MetaID.Location = new System.Drawing.Point(32, 67);
            this.MetaID.Name = "MetaID";
            this.MetaID.Size = new System.Drawing.Size(42, 13);
            this.MetaID.TabIndex = 0;
            this.MetaID.Text = "MetaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuota";
            // 
            // MetaIdnumericUpDown
            // 
            this.MetaIdnumericUpDown.Location = new System.Drawing.Point(101, 60);
            this.MetaIdnumericUpDown.Name = "MetaIdnumericUpDown";
            this.MetaIdnumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.MetaIdnumericUpDown.TabIndex = 3;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(101, 101);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cuotanumericUpDown
            // 
            this.cuotanumericUpDown.Location = new System.Drawing.Point(101, 133);
            this.cuotanumericUpDown.Name = "cuotanumericUpDown";
            this.cuotanumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.cuotanumericUpDown.TabIndex = 5;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(114, 191);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 43);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.Location = new System.Drawing.Point(190, 57);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.buscarbutton.TabIndex = 7;
            this.buscarbutton.Text = "button1";
            this.buscarbutton.UseVisualStyleBackColor = true;
            // 
            // rmetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 257);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.cuotanumericUpDown);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.MetaIdnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MetaID);
            this.Name = "rmetas";
            this.Text = "rmetas";
            ((System.ComponentModel.ISupportInitialize)(this.MetaIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotanumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MetaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MetaIdnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown cuotanumericUpDown;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button buscarbutton;
    }
}