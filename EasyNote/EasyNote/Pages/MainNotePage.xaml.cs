using EasyNote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyNote.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainNotePage : ContentPage
    {
        public MainNotePage()
        {
            InitializeComponent();
            BindingContext = new MainNoteViewModel();
        }
    }
}