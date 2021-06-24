using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace teclaenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnome1.Text.Length == 0)
            {
                MessageBox.Show("Você precisa digitar um nome !!");
            }
            else
            {
                string nome = txtnome1.Text;
                txtseparar.Text = nome.Substring(3, 2);//primeira posição é a posição que comeca a contar e segunda posição é quantas vezes conta
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string texto = "Deseja realmente sair";
            string titulo = "finalizar aplicação";
            if(MessageBox.Show(texto,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        

        private void txtnome1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtseparar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
