using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tp01.ViewModel.Services
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
