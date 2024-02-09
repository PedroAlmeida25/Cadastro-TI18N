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
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            
        }//fim do construtor


        private void Menu_Load(object sender, EventArgs e)
        {

        }//faz o carregamento de conteúdos da minha tela

        private void button5_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar   
        }//fim do método cadastrar

        private void button6_Click(object sender, EventArgs e)
        {

        }//fim do método consultar

        private void button7_Click(object sender, EventArgs e)
        {

        }//fim do método atualizar

        private void button8_Click(object sender, EventArgs e)
        {

        }//fim do método excluir
    }//fim da classe
}//fim do projeto
