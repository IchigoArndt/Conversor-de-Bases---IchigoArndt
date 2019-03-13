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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmb_conversao = new System.Windows.Forms.ComboBox();
            this.lbl_Conversao = new System.Windows.Forms.Label();
            this.txt_BaseN = new System.Windows.Forms.TextBox();
            this.ultTxtButton = new Infragistics.Win.Misc.UltraButton();
            this.progressoConversao = new Infragistics.Win.UltraWinProgressBar.UltraProgressBar();
            this.txtBase_O = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.SuspendLayout();
            // 
            // cmb_conversao
            // 
            this.cmb_conversao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_conversao.FormattingEnabled = true;
            this.cmb_conversao.Location = new System.Drawing.Point(20, 46);
            this.cmb_conversao.Margin = new System.Windows.Forms.Padding(4);
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
            // txt_BaseN
            // 
            this.txt_BaseN.Location = new System.Drawing.Point(20, 357);
            this.txt_BaseN.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BaseN.Multiline = true;
            this.txt_BaseN.Name = "txt_BaseN";
            this.txt_BaseN.ReadOnly = true;
            this.txt_BaseN.Size = new System.Drawing.Size(390, 162);
            this.txt_BaseN.TabIndex = 3;
            // 
            // ultTxtButton
            // 
            appearance1.BorderAlpha = Infragistics.Win.Alpha.UseAlphaLevel;
            appearance1.BorderColor = System.Drawing.Color.Red;
            this.ultTxtButton.HotTrackAppearance = appearance1;
            this.ultTxtButton.Location = new System.Drawing.Point(160, 270);
            this.ultTxtButton.Name = "ultTxtButton";
            appearance2.BorderAlpha = Infragistics.Win.Alpha.UseAlphaLevel;
            appearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ultTxtButton.PressedAppearance = appearance2;
            this.ultTxtButton.Size = new System.Drawing.Size(100, 28);
            this.ultTxtButton.TabIndex = 6;
            this.ultTxtButton.Text = "Converter";
            this.ultTxtButton.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // progressoConversao
            // 
            appearance3.BackColor = System.Drawing.Color.Red;
            appearance3.BorderColor = System.Drawing.Color.Black;
            appearance3.ForeColor = System.Drawing.Color.White;
            this.progressoConversao.FillAppearance = appearance3;
            this.progressoConversao.Location = new System.Drawing.Point(40, 318);
            this.progressoConversao.Name = "progressoConversao";
            this.progressoConversao.Size = new System.Drawing.Size(350, 23);
            this.progressoConversao.TabIndex = 7;
            this.progressoConversao.Text = "[Formatted]";
            this.progressoConversao.ValueChanged += new System.EventHandler(this.progressoConversao_ValueChanged);
            // 
            // txtBase_O
            // 
            this.txtBase_O.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.txtBase_O.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013;
            appearance4.BorderAlpha = Infragistics.Win.Alpha.UseAlphaLevel;
            appearance4.BorderColor = System.Drawing.Color.Blue;
            appearance4.BorderColor2 = System.Drawing.Color.Cyan;
            appearance4.BorderColor3DBase = System.Drawing.Color.Red;
            appearance4.TextHAlignAsString = "Left";
            this.txtBase_O.HotTrackLinkAppearance = appearance4;
            this.txtBase_O.Location = new System.Drawing.Point(20, 94);
            this.txtBase_O.Name = "txtBase_O";
            this.txtBase_O.Size = new System.Drawing.Size(390, 162);
            this.txtBase_O.TabIndex = 8;
            this.txtBase_O.Value = "";
            this.txtBase_O.Leave += new System.EventHandler(this.ultraButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 554);
            this.Controls.Add(this.txtBase_O);
            this.Controls.Add(this.progressoConversao);
            this.Controls.Add(this.ultTxtButton);
            this.Controls.Add(this.txt_BaseN);
            this.Controls.Add(this.lbl_Conversao);
            this.Controls.Add(this.cmb_conversao);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Conversão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_conversao;
        private System.Windows.Forms.Label lbl_Conversao;
        private System.Windows.Forms.TextBox txt_BaseN;
        private Infragistics.Win.Misc.UltraButton ultTxtButton;
        private Infragistics.Win.UltraWinProgressBar.UltraProgressBar progressoConversao;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor txtBase_O;
    }
}

