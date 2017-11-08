
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BCCMobileAppLauncher.View
{
    public partial class FirstPage : ContentPage

    {

        private bool _canClose = true;

        public FirstPage()
        {
            InitializeComponent();
            
        }
        
       

        protected override bool OnBackButtonPressed()
        {
    
            if (_canClose)
            {
                
                
                DisplayAlert("Exit", "Do you want to exit the App?", "Yes", "No").ContinueWith(t =>
                {
                    t.Start();
                    
                    if (t.Result)
                    {
                        _canClose = false;
                    }
                    
                }, TaskScheduler.FromCurrentSynchronizationContext());

            }
            
            return _canClose;
        }

        
    }

    

    
}
