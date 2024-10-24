using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace minimal_api.Infraestrutura.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
        Administrador? BuscaPorId(int id);
        Administrador Incluir(Administrador administrador);
        List<Administrador> Todos(int? pagina);
    }
}