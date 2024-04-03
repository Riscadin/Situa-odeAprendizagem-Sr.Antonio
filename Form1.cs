using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SituaçãodeAprendizagem_Sr.Antonio
{
    public partial class Form1 : Form
    {
        Dictionary<CheckBox, double> produtos = new Dictionary<CheckBox, double>();

        public Form1()
        {
            InitializeComponent();
        }

         double produtosselecionados1 = 0;
         double totalCompra = 0;
        

        public void produtosselecionados()
        {
            produtos.Clear();
            
            produtos.Add(chkRefrigerante, 8.90);
            produtos.Add(chkAzeite, 38.50);
            produtos.Add(chkBiscoitoDeChocolate, 3.50);
            produtos.Add(chkLeite, 4.99);
            produtos.Add(chkMacarrao, 2.30);
            produtos.Add(chkSucoDeLaranja, 5.75);
            produtos.Add(chkChocolateAoLeite, 6.50);
            produtos.Add(chkPaoDeForma, 3.20);
            produtos.Add(chkArroz, 10.75);
            produtos.Add(chkFeijao, 9.90);



            

            foreach (KeyValuePair<CheckBox,double> c in produtos)
            {
                

                if(c.Key.Checked)
                {
                    produtosselecionados1 += c.Value;
                }




            }

            
            
            


        }

        private void AtualizarTotal()
        {
           

            // Calcula o valor total da compra
            foreach (var produto in produtos)
            {
                if (produto.Key.Checked)
                {
                    totalCompra += produto.Value;
                }
            }

           
            

            // Aplica os descontos ou acréscimos de acordo com a forma de pagamento
            if (rbtCartaodecredito.Checked)
            {
                totalCompra *= 1.05; // Acréscimo de 5% para Cartão de Crédito
            }
            else if (rbtDinheiro.Checked)
            {
                totalCompra *= 0.92; // Desconto de 8% para Dinheiro
            }
            else if (rbtPix.Checked)
            {
                totalCompra *= 0.95; // Desconto de 5% para PIX
            }


        }

        

        private void exibir()
        {

            if(rbtCartaodecredito.Checked || rbtDinheiro.Checked || rbtPix.Checked)
            {

                if(totalCompra != 0.00)
                {
                    string msg = "ESSES SÃO OS ITENS QUE DESEJA COMPRAR? \n";
                    foreach (var produto in produtos)
                    {
                        if (produto.Key.Checked)
                        {
                            msg += $"{produto.Key.Text}\n";
                        }
                    }
                    string titulo = "REALIZAR COMPRA?";
                    var resultado = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show($"Total da compra: R${totalCompra:N2}", "TOTAL DA COMPRA!");
                        totaldacompra.Text = $"R${totalCompra.ToString("0.00")}";

                    }
                }
                else
                {
                    MessageBox.Show("NÃO HÁ NENHUM ITEM PARA COMPRAR","AVISO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                
            }
            else
            {
                MessageBox.Show("MÉTODO DE PAGAMENTO NÃO FOI ESCOLHIDO", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }




        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkRefrigerante_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void chkAzeite_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkBiscoitoDeChocolate_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkLeite_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkMacarrao_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkSucoDeLaranja_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkChocolateAoLeite_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkPaoDeForma_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkArroz_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkFeijao_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            foreach (CheckBox c in Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                   
                }
            }
        }

        private void btnExecutarCompra_Click(object sender, EventArgs e)
        {
            

            produtosselecionados();
            AtualizarTotal();
            exibir();
            totalCompra = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRealizado_Click(object sender, EventArgs e)
        {
            chkArroz.Checked = false;
            chkRefrigerante.Checked = false;
            chkAzeite.Checked = false;
            chkBiscoitoDeChocolate.Checked = false;
            chkLeite.Checked = false;
            chkMacarrao.Checked = false;
            chkSucoDeLaranja.Checked = false;
            chkChocolateAoLeite.Checked = false;
            chkPaoDeForma.Checked = false;
            chkFeijao.Checked = false;

            rbtCartaodecredito.Checked = false;
            rbtDinheiro.Checked = false;
            rbtPix.Checked = false;

            totaldacompra.Text = "...";
        }
    }
}
