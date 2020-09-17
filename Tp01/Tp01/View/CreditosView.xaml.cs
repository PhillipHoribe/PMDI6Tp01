using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp01.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditosView : ContentPage
    {
        public CreditosView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.CreditosViewModel();
        }
    }
}