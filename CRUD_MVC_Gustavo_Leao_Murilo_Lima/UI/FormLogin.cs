using CRUD_MVC_Gustavo_Leao_Murilo_Lima.BLL;
using CRUD_MVC_Gustavo_Leao_Murilo_Lima.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Gustavo_Leao_Murilo_Lima
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //capturar os dados digitados pelo usuário e encaminhas à camada controle
            LoginDTO loginDTO = new LoginDTO
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
            };

            LoginBLL login = new LoginBLL();
            bool retorno = login.GetLoginBLL(loginDTO);

            //se a variável de retorno for true retornar mensagem de ok
            if (retorno)
            {
                MessageBox.Show("Login OK.");
            }
            else
            {
                //caso não seja possivel realizar o login
                MessageBox.Show("Não foi possível realizar o login, tente novamente!");
            }
        }
    }
}
