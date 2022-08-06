using CommunityToolkit.Mvvm.ComponentModel;

namespace CSSPCultureServices
{
    // All the code in this file is included in all platforms.
    public partial class Class1 : ObservableObject
    {
        [ObservableProperty]
        string rouge;

        public Class1()
        {
            Rouge = "first";
        }

        public void HelloWorld()
        {
            Rouge = "Hello World";
        }
    }
}