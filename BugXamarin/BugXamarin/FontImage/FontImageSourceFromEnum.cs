using System;
using Xamarin.Forms;

namespace BugXamarin.FontImage
{
    public abstract class FontImageSourceFromEnum<T>
    {
        public readonly static BindableProperty IconProperty = BindableProperty.CreateAttached(
            "Icon",
            typeof(T),
            typeof(FontImageSourceFromEnum<T>),
            default(T),
            BindingMode.TwoWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is Label lblObject)
                {
                    // --> here goes the name of some fontimage
                    //lblObject.FontFamily = "SomeNameOfFontImage";
                    lblObject.Text = EnumToStringConvert((T)newValue);
                }
                else if (bindable is Button btnObject)
                {
                    // --> here goes the name of some fontimage
                    //btnObject.FontFamily = "SomeNameOfFontImage";
                    btnObject.Text = EnumToStringConvert((T)newValue);
                }
            });

        public static T GetIcon(BindableObject view)
        {
            return (T)view.GetValue(IconProperty);
        }

        public static void SetIcon(BindableObject view, T value)
        {
            view.SetValue(IconProperty, value);
        }
        private static string EnumToStringConvert(T value)
        {
            var _enum = Enum.Parse(typeof(T), value.ToString());
            var _ret = (char)(int)_enum;
            return _ret.ToString();
        }
    }
    public class ConcreteClassFontImageA : FontImageSourceFromEnum<SomeKindOfFontImageEnumA> { }
    public class ConcreteClassFontImageB : FontImageSourceFromEnum<SomeKindOfFontImageEnumB> { }
    public class ConcreteClassFontImageC : FontImageSourceFromEnum<SomeKindOfFontImageEnumC> { }
    public class ConcreteClassFontImageFontAwesomeBrands : FontImageSourceFromEnum<SomeKindOfFontImageEnumFontAwesomeBrands> { }

}
