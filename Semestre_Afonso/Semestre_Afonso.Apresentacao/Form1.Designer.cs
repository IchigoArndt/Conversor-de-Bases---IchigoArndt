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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.cmb_conversao.Location = new System.Drawing.Point(20, 46);
            this.cmb_conversao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_conversao.Name = "cmb_conversao";
            this.cmb_conversao.Size = new System.Drawing.Size(390, 24);
            this.cmb_conversao.TabIndex = 0;
            this.cmb_conversao.SelectedIndexChanged += new System.EventHandler(this.cmb_conversao_SelectedIndexChanged);
            // 
            // lbl_Conversao
            // 
            this.lbl_Conversao.AutoSize = true;
            this.lbl_Conversao.Location = new System.Drawing.Point(16, 11);
            this.lbl_Conversao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Conversao.Name = "lbl_Conversao";
            this.lbl_Conversao.Size = new System.Drawing.Size(135, 16);
            this.lbl_Conversao.TabIndex = 1;
            this.lbl_Conversao.Text = "Escolha a conversão";
            this.lbl_Conversao.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_BaseO
            // 
            this.txt_BaseO.Location = new System.Drawing.Point(20, 101);
            this.txt_BaseO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BaseO.Multiline = true;
            this.txt_BaseO.Name = "txt_BaseO";
            this.txt_BaseO.Size = new System.Drawing.Size(390, 162);
            this.txt_BaseO.TabIndex = 2;
            this.txt_BaseO.Leave += new System.EventHandler(this.txt_BaseO_Leave);
            // 
            // btn_conversao
            // 
            this.btn_conversao.Location = new System.Drawing.Point(156, 272);
            this.btn_conversao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_conversao.Name = "btn_conversao";
            this.btn_conversao.Size = new System.Drawing.Size(100, 28);
            this.btn_conversao.TabIndex = 4;
            this.btn_conversao.Text = "Converter";
            this.btn_conversao.UseVisualStyleBackColor = true;
            this.btn_conversao.Click += new System.EventHandler(this.btn_conversao_Click);
            // 
            // txt_BaseN
            // 
            this.txt_BaseN.Location = new System.Drawing.Point(20, 357);
            this.txt_BaseN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BaseN.Multiline = true;
            this.txt_BaseN.Name = "txt_BaseN";
            this.txt_BaseN.ReadOnly = true;
            this.txt_BaseN.Size = new System.Drawing.Size(390, 162);
            this.txt_BaseN.TabIndex = 3;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(42, 314);
            this.pb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(350, 28);
            this.pb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 554);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btn_conversao);
            this.Controls.Add(this.txt_BaseN);
            this.Controls.Add(this.txt_BaseO);
            this.Controls.Add(this.lbl_Conversao);
            this.Controls.Add(this.cmb_conversao);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Conversão";
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

