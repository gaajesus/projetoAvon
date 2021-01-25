using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void valida(string price, string qtd)
        {
            if (string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(qtd))
            {
                MessageBox.Show("Valores incorretos! Corrija-os");
                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    txtPrice.Focus();
                }
                else txtQtd.Focus();
            }
        }
        private double calc(double total, double qtd,double price, double comi)
            {
                total = price * qtd;
                comi = total * 0.10;
            }
        private void rdbAvon_CheckedChanged(object sender, EventArgs e)
        {
           
                lblDescri.Text = "Hidratante de pele de frutas vermelhas\nPreço: R$12,50\nCódigo:012345\n" +
                    "Desodorante feminino\nPreço R$8,80\nCódigo:543210";
    
        }

        private void rdbAbelha_CheckedChanged(object sender, EventArgs e)
        {
            
                lblDescri.Text = "Hidratante de pele de mel\nPreço: R$20,90\nCódigo:454578\n" +
                    "Shampoo de coco \nPreço R$6,00\nCódigo:787845";
        }

        private void rdbNatura_CheckedChanged(object sender, EventArgs e)
        {
           
                lblDescri.Text = "Hidratante de pele de Algas\nPreço: R$17,00\nCódigo:696990\n" +
                    "Sabonete líquido\nPreço R$10,80\nCódigo:906969";
         
        }
    }
}
