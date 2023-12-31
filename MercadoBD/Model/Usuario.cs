﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoBD.Model
{
    internal class Usuario
    {
        private static int id_Usuarios;
        private static string tipo;
        private static string dataAcesso;
        private static int id_FuncionariosFK;
        private static string senhaUsuarios;

        public static int Id_Usuarios { get => id_Usuarios; set => id_Usuarios = value; }
        public static string Tipo { get => tipo; set => tipo = value; }
        public static string DataAcesso { get => dataAcesso; set => dataAcesso = value; }
        public static int Id_FuncionariosFK { get => id_FuncionariosFK; set => id_FuncionariosFK = value; }
        public static string SenhaUsuarios { get => senhaUsuarios; set => senhaUsuarios = value; }
    }
}
    
