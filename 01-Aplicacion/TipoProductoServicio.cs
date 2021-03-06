﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class TipoProductoServicio
    {
        private _02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.TipoProducto> _repositorio;
        public TipoProductoServicio(_02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.TipoProducto> repositorio)
        {
            _repositorio = repositorio;
        }

        public List<_02_Dominio.Entidades.TipoProducto> Listar()
        {
            return _repositorio.Leer();
        }
    }
}
