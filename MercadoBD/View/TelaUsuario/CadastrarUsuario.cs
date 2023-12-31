﻿using MercadoBD.Controller;
using MercadoBD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoBD.View.TelaUsuario
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btn_CadUser_Click(object sender, EventArgs e)
        {
            Usuario.Tipo = cbx_TipoCadUser.Text;
            Usuario.Id_FuncionariosFK= Convert.ToInt32(tbx_MatriFunUser.Text);
            
            Usuario.SenhaUsuarios = tbx_SenhaCadUser.Text;

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.AddUsuario();
        }

        
    }
}
