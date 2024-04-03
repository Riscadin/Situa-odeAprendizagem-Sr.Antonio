namespace SituaçãodeAprendizagem_Sr.Antonio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.totaldacompra = new System.Windows.Forms.Label();
            this.btnExecutarCompra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkRefrigerante = new System.Windows.Forms.CheckBox();
            this.chkAzeite = new System.Windows.Forms.CheckBox();
            this.chkBiscoitoDeChocolate = new System.Windows.Forms.CheckBox();
            this.chkLeite = new System.Windows.Forms.CheckBox();
            this.chkMacarrao = new System.Windows.Forms.CheckBox();
            this.chkSucoDeLaranja = new System.Windows.Forms.CheckBox();
            this.chkChocolateAoLeite = new System.Windows.Forms.CheckBox();
            this.chkPaoDeForma = new System.Windows.Forms.CheckBox();
            this.chkArroz = new System.Windows.Forms.CheckBox();
            this.chkFeijao = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCartaodecredito = new System.Windows.Forms.RadioButton();
            this.rbtPix = new System.Windows.Forms.RadioButton();
            this.rbtDinheiro = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTippp1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnRealizado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btnRealizado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.totaldacompra);
            this.panel1.Controls.Add(this.btnExecutarCompra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 450);
            this.panel1.TabIndex = 0;
            // 
            // totaldacompra
            // 
            this.totaldacompra.AutoSize = true;
            this.totaldacompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldacompra.Location = new System.Drawing.Point(12, 193);
            this.totaldacompra.Name = "totaldacompra";
            this.totaldacompra.Size = new System.Drawing.Size(38, 31);
            this.totaldacompra.TabIndex = 13;
            this.totaldacompra.Text = "...";
            this.toolTippp1.SetToolTip(this.totaldacompra, "Valor que o cliente ira pagar.");
            // 
            // btnExecutarCompra
            // 
            this.btnExecutarCompra.BackColor = System.Drawing.Color.IndianRed;
            this.btnExecutarCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExecutarCompra.FlatAppearance.BorderSize = 0;
            this.btnExecutarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnExecutarCompra.Image")));
            this.btnExecutarCompra.Location = new System.Drawing.Point(0, 100);
            this.btnExecutarCompra.Name = "btnExecutarCompra";
            this.btnExecutarCompra.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnExecutarCompra.Size = new System.Drawing.Size(194, 55);
            this.btnExecutarCompra.TabIndex = 14;
            this.btnExecutarCompra.Text = "Executar Compra";
            this.btnExecutarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTippp1.SetToolTip(this.btnExecutarCompra, "Botão de finalizar a compra.");
            this.btnExecutarCompra.UseVisualStyleBackColor = false;
            this.btnExecutarCompra.Click += new System.EventHandler(this.btnExecutarCompra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "TOTAL A PAGAR:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 100);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chkRefrigerante
            // 
            this.chkRefrigerante.AutoSize = true;
            this.chkRefrigerante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRefrigerante.ForeColor = System.Drawing.Color.White;
            this.chkRefrigerante.Location = new System.Drawing.Point(8, 46);
            this.chkRefrigerante.Name = "chkRefrigerante";
            this.chkRefrigerante.Size = new System.Drawing.Size(150, 20);
            this.chkRefrigerante.TabIndex = 1;
            this.chkRefrigerante.Text = "Refrigerante   R$8,90";
            this.chkRefrigerante.UseVisualStyleBackColor = true;
            this.chkRefrigerante.CheckedChanged += new System.EventHandler(this.chkRefrigerante_CheckedChanged);
            // 
            // chkAzeite
            // 
            this.chkAzeite.AutoSize = true;
            this.chkAzeite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAzeite.ForeColor = System.Drawing.Color.White;
            this.chkAzeite.Location = new System.Drawing.Point(8, 69);
            this.chkAzeite.Name = "chkAzeite";
            this.chkAzeite.Size = new System.Drawing.Size(120, 20);
            this.chkAzeite.TabIndex = 2;
            this.chkAzeite.Text = "Azeite   R$38,50";
            this.chkAzeite.UseVisualStyleBackColor = true;
            this.chkAzeite.CheckedChanged += new System.EventHandler(this.chkAzeite_CheckedChanged);
            // 
            // chkBiscoitoDeChocolate
            // 
            this.chkBiscoitoDeChocolate.AutoSize = true;
            this.chkBiscoitoDeChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBiscoitoDeChocolate.ForeColor = System.Drawing.Color.White;
            this.chkBiscoitoDeChocolate.Location = new System.Drawing.Point(8, 92);
            this.chkBiscoitoDeChocolate.Name = "chkBiscoitoDeChocolate";
            this.chkBiscoitoDeChocolate.Size = new System.Drawing.Size(205, 20);
            this.chkBiscoitoDeChocolate.TabIndex = 3;
            this.chkBiscoitoDeChocolate.Text = "Biscoito de chocolate   R$3,50";
            this.chkBiscoitoDeChocolate.UseVisualStyleBackColor = true;
            this.chkBiscoitoDeChocolate.CheckedChanged += new System.EventHandler(this.chkBiscoitoDeChocolate_CheckedChanged);
            // 
            // chkLeite
            // 
            this.chkLeite.AutoSize = true;
            this.chkLeite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLeite.ForeColor = System.Drawing.Color.White;
            this.chkLeite.Location = new System.Drawing.Point(8, 115);
            this.chkLeite.Name = "chkLeite";
            this.chkLeite.Size = new System.Drawing.Size(108, 20);
            this.chkLeite.TabIndex = 4;
            this.chkLeite.Text = "Leite   R$4,99 ";
            this.chkLeite.UseVisualStyleBackColor = true;
            this.chkLeite.CheckedChanged += new System.EventHandler(this.chkLeite_CheckedChanged);
            // 
            // chkMacarrao
            // 
            this.chkMacarrao.AutoSize = true;
            this.chkMacarrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMacarrao.ForeColor = System.Drawing.Color.White;
            this.chkMacarrao.Location = new System.Drawing.Point(8, 138);
            this.chkMacarrao.Name = "chkMacarrao";
            this.chkMacarrao.Size = new System.Drawing.Size(137, 20);
            this.chkMacarrao.TabIndex = 5;
            this.chkMacarrao.Text = "Macarrão   R$ 2,30";
            this.chkMacarrao.UseVisualStyleBackColor = true;
            this.chkMacarrao.CheckedChanged += new System.EventHandler(this.chkMacarrao_CheckedChanged);
            // 
            // chkSucoDeLaranja
            // 
            this.chkSucoDeLaranja.AutoSize = true;
            this.chkSucoDeLaranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSucoDeLaranja.ForeColor = System.Drawing.Color.White;
            this.chkSucoDeLaranja.Location = new System.Drawing.Point(8, 161);
            this.chkSucoDeLaranja.Name = "chkSucoDeLaranja";
            this.chkSucoDeLaranja.Size = new System.Drawing.Size(183, 20);
            this.chkSucoDeLaranja.TabIndex = 6;
            this.chkSucoDeLaranja.Text = "Suco de Laranja   R$ 5,75  ";
            this.chkSucoDeLaranja.UseVisualStyleBackColor = true;
            this.chkSucoDeLaranja.CheckedChanged += new System.EventHandler(this.chkSucoDeLaranja_CheckedChanged);
            // 
            // chkChocolateAoLeite
            // 
            this.chkChocolateAoLeite.AutoSize = true;
            this.chkChocolateAoLeite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChocolateAoLeite.ForeColor = System.Drawing.Color.White;
            this.chkChocolateAoLeite.Location = new System.Drawing.Point(8, 181);
            this.chkChocolateAoLeite.Name = "chkChocolateAoLeite";
            this.chkChocolateAoLeite.Size = new System.Drawing.Size(191, 20);
            this.chkChocolateAoLeite.TabIndex = 7;
            this.chkChocolateAoLeite.Text = "Chocolate ao Leite   R$ 6,50";
            this.chkChocolateAoLeite.UseVisualStyleBackColor = true;
            this.chkChocolateAoLeite.CheckedChanged += new System.EventHandler(this.chkChocolateAoLeite_CheckedChanged);
            // 
            // chkPaoDeForma
            // 
            this.chkPaoDeForma.AutoSize = true;
            this.chkPaoDeForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaoDeForma.ForeColor = System.Drawing.Color.White;
            this.chkPaoDeForma.Location = new System.Drawing.Point(8, 204);
            this.chkPaoDeForma.Name = "chkPaoDeForma";
            this.chkPaoDeForma.Size = new System.Drawing.Size(168, 20);
            this.chkPaoDeForma.TabIndex = 8;
            this.chkPaoDeForma.Text = "Pão de Forma   R$ 3,20 ";
            this.chkPaoDeForma.UseVisualStyleBackColor = true;
            this.chkPaoDeForma.CheckedChanged += new System.EventHandler(this.chkPaoDeForma_CheckedChanged);
            // 
            // chkArroz
            // 
            this.chkArroz.AutoSize = true;
            this.chkArroz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArroz.ForeColor = System.Drawing.Color.White;
            this.chkArroz.Location = new System.Drawing.Point(8, 227);
            this.chkArroz.Name = "chkArroz";
            this.chkArroz.Size = new System.Drawing.Size(123, 20);
            this.chkArroz.TabIndex = 9;
            this.chkArroz.Text = "Arroz   R$ 10,75  ";
            this.chkArroz.UseVisualStyleBackColor = true;
            this.chkArroz.CheckedChanged += new System.EventHandler(this.chkArroz_CheckedChanged);
            // 
            // chkFeijao
            // 
            this.chkFeijao.AutoSize = true;
            this.chkFeijao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFeijao.ForeColor = System.Drawing.Color.White;
            this.chkFeijao.Location = new System.Drawing.Point(8, 250);
            this.chkFeijao.Name = "chkFeijao";
            this.chkFeijao.Size = new System.Drawing.Size(123, 20);
            this.chkFeijao.TabIndex = 10;
            this.chkFeijao.Text = "Feijão   R$ 9,90  ";
            this.chkFeijao.UseVisualStyleBackColor = true;
            this.chkFeijao.CheckedChanged += new System.EventHandler(this.chkFeijao_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chkSucoDeLaranja);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.chkMacarrao);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.chkRefrigerante);
            this.panel3.Controls.Add(this.chkBiscoitoDeChocolate);
            this.panel3.Controls.Add(this.chkChocolateAoLeite);
            this.panel3.Controls.Add(this.chkArroz);
            this.panel3.Controls.Add(this.chkFeijao);
            this.panel3.Controls.Add(this.chkPaoDeForma);
            this.panel3.Controls.Add(this.chkLeite);
            this.panel3.Controls.Add(this.chkAzeite);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 450);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "PAGEMENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "FORMA DE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbtCartaodecredito);
            this.groupBox1.Controls.Add(this.rbtPix);
            this.groupBox1.Controls.Add(this.rbtDinheiro);
            this.groupBox1.Location = new System.Drawing.Point(50, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.toolTippp1.SetToolTip(this.groupBox1, "Formas de pagamento.");
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtCartaodecredito
            // 
            this.rbtCartaodecredito.AutoSize = true;
            this.rbtCartaodecredito.Location = new System.Drawing.Point(6, 28);
            this.rbtCartaodecredito.Name = "rbtCartaodecredito";
            this.rbtCartaodecredito.Size = new System.Drawing.Size(107, 17);
            this.rbtCartaodecredito.TabIndex = 12;
            this.rbtCartaodecredito.TabStop = true;
            this.rbtCartaodecredito.Text = "Cartão de Credito";
            this.toolTippp1.SetToolTip(this.rbtCartaodecredito, "Pagar com cartão de credito.");
            this.rbtCartaodecredito.UseVisualStyleBackColor = true;
            // 
            // rbtPix
            // 
            this.rbtPix.AutoSize = true;
            this.rbtPix.Location = new System.Drawing.Point(6, 74);
            this.rbtPix.Name = "rbtPix";
            this.rbtPix.Size = new System.Drawing.Size(39, 17);
            this.rbtPix.TabIndex = 14;
            this.rbtPix.TabStop = true;
            this.rbtPix.Text = "Pix";
            this.toolTippp1.SetToolTip(this.rbtPix, "Pagar com Pix.");
            this.rbtPix.UseVisualStyleBackColor = true;
            // 
            // rbtDinheiro
            // 
            this.rbtDinheiro.AutoSize = true;
            this.rbtDinheiro.Location = new System.Drawing.Point(6, 51);
            this.rbtDinheiro.Name = "rbtDinheiro";
            this.rbtDinheiro.Size = new System.Drawing.Size(64, 17);
            this.rbtDinheiro.TabIndex = 13;
            this.rbtDinheiro.TabStop = true;
            this.rbtDinheiro.Text = "Dinheiro";
            this.toolTippp1.SetToolTip(this.rbtDinheiro, "Pagar em dinheiro");
            this.rbtDinheiro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seu Antônio agradece pela preferência ";
            // 
            // toolTippp1
            // 
            this.toolTippp1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolTippp1.ForeColor = System.Drawing.Color.White;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Lavender;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(198, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 23);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "X";
            this.toolTippp1.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnRealizado
            // 
            this.btnRealizado.BackColor = System.Drawing.Color.IndianRed;
            this.btnRealizado.FlatAppearance.BorderSize = 0;
            this.btnRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizado.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizado.Image")));
            this.btnRealizado.Location = new System.Drawing.Point(0, 250);
            this.btnRealizado.Name = "btnRealizado";
            this.btnRealizado.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnRealizado.Size = new System.Drawing.Size(194, 55);
            this.btnRealizado.TabIndex = 19;
            this.btnRealizado.Text = "Pagamento Realizado";
            this.btnRealizado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTippp1.SetToolTip(this.btnRealizado, "Botão de pagamento realizado");
            this.btnRealizado.UseVisualStyleBackColor = false;
            this.btnRealizado.Click += new System.EventHandler(this.btnRealizado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercearia do Seu Antônio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkRefrigerante;
        private System.Windows.Forms.CheckBox chkAzeite;
        private System.Windows.Forms.CheckBox chkBiscoitoDeChocolate;
        private System.Windows.Forms.CheckBox chkLeite;
        private System.Windows.Forms.CheckBox chkMacarrao;
        private System.Windows.Forms.CheckBox chkSucoDeLaranja;
        private System.Windows.Forms.CheckBox chkChocolateAoLeite;
        private System.Windows.Forms.CheckBox chkPaoDeForma;
        private System.Windows.Forms.CheckBox chkArroz;
        private System.Windows.Forms.CheckBox chkFeijao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCartaodecredito;
        private System.Windows.Forms.RadioButton rbtPix;
        private System.Windows.Forms.RadioButton rbtDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totaldacompra;
        private System.Windows.Forms.Button btnExecutarCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTippp1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRealizado;
    }
}

