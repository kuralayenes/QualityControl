using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace QualityControl.Views
{
    /// <summary>
    /// Page to add business details such as name, email address, and phone number.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformationEntry : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InformationEntry" /> class.
        /// </summary>
        public InformationEntry()
        {
            this.InitializeComponent();
        }
    }
}