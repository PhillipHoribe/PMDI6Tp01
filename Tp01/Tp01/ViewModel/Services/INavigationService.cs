using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tp01.ViewModel.Services
{
    interface INavigationService
    {
        // interface para navegar para a pagina
        Task NavigateToMain();
        Task NavigateToCreditos();
    }
}
