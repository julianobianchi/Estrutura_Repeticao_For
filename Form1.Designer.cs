namespace Estrutura_Repeticao
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
            label1 = new Label();
            txtNum = new TextBox();
            ltbTabuada = new ListBox();
            btnTabuada = new Button();
            bntLimpar = new Button();
            bntSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(151, 48);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            // 
            // ltbTabuada
            // 
            ltbTabuada.FormattingEnabled = true;
            ltbTabuada.ItemHeight = 15;
            ltbTabuada.Location = new Point(12, 84);
            ltbTabuada.Name = "ltbTabuada";
            ltbTabuada.Size = new Size(122, 289);
            ltbTabuada.TabIndex = 2;
            // 
            // btnTabuada
            // 
            btnTabuada.BackColor = SystemColors.Menu;
            btnTabuada.Location = new Point(151, 108);
            btnTabuada.Name = "btnTabuada";
            btnTabuada.Size = new Size(97, 43);
            btnTabuada.TabIndex = 3;
            btnTabuada.Text = "&TABUADA";
            btnTabuada.UseVisualStyleBackColor = false;
            btnTabuada.Click += btnTabuada_Click;
            // 
            // bntLimpar
            // 
            bntLimpar.BackColor = SystemColors.Menu;
            bntLimpar.Location = new Point(151, 181);
            bntLimpar.Name = "bntLimpar";
            bntLimpar.Size = new Size(97, 43);
            bntLimpar.TabIndex = 4;
            bntLimpar.Text = "&LIMPAR";
            bntLimpar.UseVisualStyleBackColor = false;
            bntLimpar.Click += bntLimpar_Click;
            // 
            // bntSair
            // 
            bntSair.BackColor = SystemColors.Menu;
            bntSair.Location = new Point(151, 253);
            bntSair.Name = "bntSair";
            bntSair.Size = new Size(97, 43);
            bntSair.TabIndex = 5;
            bntSair.Text = "&SAIR";
            bntSair.UseVisualStyleBackColor = false;
            bntSair.Click += bntSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(260, 391);
            Controls.Add(bntSair);
            Controls.Add(bntLimpar);
            Controls.Add(btnTabuada);
            Controls.Add(ltbTabuada);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "TABUADA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private ListBox ltbTabuada;
        private Button btnTabuada;
        private Button bntLimpar;
        private Button bntSair;
    }
}