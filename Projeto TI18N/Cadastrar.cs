using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TI18N
{
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }//fim do construtor

        private void label7_Click(object sender, EventArgs e)
        {

        }//fim do código

        private void label5_Click(object sender, EventArgs e)
        {

        }//fim do nome

        private void label4_Click(object sender, EventArgs e)
        {

        }//fim do telefone

        private void label2_Click(object sender, EventArgs e)
        {

        }//fim da cidade

        private void label3_Click(object sender, EventArgs e)
        {

        }//fim do estado

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(maskedTextBox1.Text);
            string name = textBox5.Text;
            string tel = maskedTextBox2.Text;
            string cid = textBox2.Text;
            string est = textBox3.Text;

            bd.Inserir(cod, name, tel, cid, est);//Inserindo no BD

            maskedTextBox1.Text = "";
            textBox5.Text = "";
            maskedTextBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }//fim do botão cadastrar

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//fim do projeto
