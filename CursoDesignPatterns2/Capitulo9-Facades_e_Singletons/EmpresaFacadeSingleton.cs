using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    /// <summary>
    /// Possibilita que durante a execução do programa terá uma única instância de EmpresaFacade
    /// </summary>
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get {
                return facade;   
            }
        }
    }
}
