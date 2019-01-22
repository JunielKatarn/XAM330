using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlExplorer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Effect fontEffect;
        int count;

        public MainPage()
        {
            InitializeComponent();

            fontEffect = Effect.Resolve("Xamarin.CustomFontEffect");
            labelWelcome.Effects.Add(fontEffect);
        }

        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            buttonClick.Text = string.Format("Click Count = {0}", ++count);
        }

        private void OnSwitchToggled(object sender, ToggledEventArgs e)
        {

        }

        private void OnSliderColorValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}