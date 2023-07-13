using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos.Domain.Enum
{
    enum Situacao
    {
        Inativo,    //Usuarios que ainda não ativaram
        Ativo,      //Usuarios já ativos
        Suspenso,   //Usuarios suspensos temporiariamente
        Desativado  //Usuarios desativados
    };
}
