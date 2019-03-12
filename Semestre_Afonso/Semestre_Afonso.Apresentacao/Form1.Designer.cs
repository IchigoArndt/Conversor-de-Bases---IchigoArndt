namespace Semestre_Afonso.Apresentacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_conversao = new System.Windows.Forms.ComboBox();
            this.lbl_Conversao = new System.Windows.Forms.Label();
            this.txt_BaseO = new System.Windows.Forms.TextBox();
            this.btn_conversao = new System.Windows.Forms.Button();
            this.txt_BaseN = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmb_conversao
            // 
            this.cmb_conversao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_conversao.FormattingEnabled = true;
            this.cmb_conversao.Location = new System.Drawing.Point(15, 37);
            this.cmb_conversao.Name = "cmb_conversao";
            this.cmb_conversao.Size = new System.Drawing.Size(294, 21);
            this.cmb_conversao.TabIndex = 0;
            this.cmb_conversao.SelectedIndexChanged += new System.EventHandler(this.cmb_conversao_SelectedIndexChanged);
            // 
            // lbl_Conversao
            // 
            this.lbl_Conversao.AutoSize = true;
            this.lbl_Conversao.Location = new System.Drawing.Point(12, 9);
            this.lbl_Conversao.Name = "lbl_Conversao";
            this.lbl_Conversao.Size = new System.Drawing.Size(107, 13);
            this.lbl_Conversao.TabIndex = 1;
            this.lbl_Conversao.Text = "Escolha a conversão";
            this.lbl_Conversao.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_BaseO
            // 
            this.txt_BaseO.Location = new System.Drawing.Point(15, 82);
            this.txt_BaseO.Multiline = true;
            this.txt_BaseO.Name = "txt_BaseO";
            this.txt_BaseO.Size = new System.Drawing.Size(294, 133);
            this.txt_BaseO.TabIndex = 2;
            this.txt_BaseO.TextChanged += new System.EventHandler(this.txt_BaseO_TextChanged);
            // 
            // btn_conversao
            // 
            this.btn_conversao.Location = new System.Drawing.Point(117, 221);
            this.btn_conversao.Name = "btn_conversao";
            this.btn_conversao.Size = new System.Drawing.Size(75, 23);
            this.btn_conversao.TabIndex = 4;
            this.btn_conversao.Text = "Converter";
            this.btn_conversao.UseVisualStyleBackColor = true;
            this.btn_conversao.Click += new System.EventHandler(this.btn_conversao_Click);
            // 
            // txt_BaseN
            // 
            this.txt_BaseN.Location = new System.Drawing.Point(15, 290);
            this.txt_BaseN.Multiline = true;
            this.txt_BaseN.Name = "txt_BaseN";
            this.txt_BaseN.Size = new System.Drawing.Size(294, 133);
            this.txt_BaseN.TabIndex = 3;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(32, 255);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(262, 23);
            this.pb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btn_conversao);
            this.Controls.Add(this.txt_BaseN);
            this.Controls.Add(this.txt_BaseO);
            this.Controls.Add(this.lbl_Conversao);
            this.Controls.Add(this.cmb_conversao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_conversao;
        private System.Windows.Forms.Label lbl_Conversao;
        private System.Windows.Forms.TextBox txt_BaseO;
        private System.Windows.Forms.Button btn_conversao;
        private System.Windows.Forms.TextBox txt_BaseN;
        private System.Windows.Forms.ProgressBar pb;
    }
}

