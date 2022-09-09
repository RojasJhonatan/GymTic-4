using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;

namespace Gymtic.App.Persistencia
{
    public class repositorioDieta : IRepositorioDieta
    {
        private readonly _AppContext _appContextBD;
        public repositorioDieta(_AppContext appContext)
        {
            this._appContextBD = appContext;
        }
        

    }
}