
namespace Cambios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOrigem = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.bt_Converter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bt_Troca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor: ";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(139, 41);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(155, 23);
            this.txt_Valor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de destino:";
            // 
            // comboBoxOrigem
            // 
            this.comboBoxOrigem.FormattingEnabled = true;
            this.comboBoxOrigem.Location = new System.Drawing.Point(139, 92);
            this.comboBoxOrigem.Name = "comboBoxOrigem";
            this.comboBoxOrigem.Size = new System.Drawing.Size(155, 23);
            this.comboBoxOrigem.TabIndex = 4;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(140, 133);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(155, 23);
            this.comboBoxDestino.TabIndex = 5;
            // 
            // bt_Converter
            // 
            this.bt_Converter.Enabled = false;
            this.bt_Converter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Converter.Location = new System.Drawing.Point(349, 41);
            this.bt_Converter.Name = "bt_Converter";
            this.bt_Converter.Size = new System.Drawing.Size(81, 45);
            this.bt_Converter.TabIndex = 6;
            this.bt_Converter.Text = "Converter";
            this.bt_Converter.UseVisualStyleBackColor = true;
            this.bt_Converter.Click += new System.EventHandler(this.bt_Converter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(88, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = " ";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resultado.Location = new System.Drawing.Point(106, 201);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(278, 17);
            this.lbl_Resultado.TabIndex = 8;
            this.lbl_Resultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.Location = new System.Drawing.Point(12, 264);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(39, 13);
            this.lbl_Status.TabIndex = 9;
            this.lbl_Status.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(366, 268);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 13);
            this.progressBar1.TabIndex = 10;
            // 
            // bt_Troca
            // 
            this.bt_Troca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Troca.BackgroundImage")));
            this.bt_Troca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Troca.Enabled = false;
            this.bt_Troca.Location = new System.Drawing.Point(349, 107);
            this.bt_Troca.Name = "bt_Troca";
            this.bt_Troca.Size = new System.Drawing.Size(81, 76);
            this.bt_Troca.TabIndex = 11;
            this.bt_Troca.UseVisualStyleBackColor = true;
            this.bt_Troca.Click += new System.EventHandler(this.bt_Troca_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 290);
            this.Controls.Add(this.bt_Troca);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Converter);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Câmbios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOrigem;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Button bt_Converter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bt_Troca;
    }
}

