using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BugXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

    public enum SomeKindOfFontImageEnumA
    {
        LetterA = 'A',
    }
    public enum SomeKindOfFontImageEnumB
    {
        LetterB = 'B',
    }
    public enum SomeKindOfFontImageEnumC
    {
        LetterC = 'C',
    }
    public enum SomeKindOfFontImageEnumFontAwesomeBrands
    {
        Chrome = '\uf268',
    }
}
