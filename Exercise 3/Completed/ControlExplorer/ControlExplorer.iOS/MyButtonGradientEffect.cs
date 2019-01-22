using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace ControlExplorer.iOS
{
    public class MyButtonGradientEffect : PlatformEffect
    {
        private CoreAnimation.CAGradientLayer gradLayer;

        public MyButtonGradientEffect()
        {
        }

        protected override void OnAttached()
        {
            if (Element is Button == false)
                return;

            SetGradient();
        }

        protected override void OnDetached()
        {
            gradLayer?.RemoveFromSuperLayer();
        }

        public void SetGradient()
        {
            gradLayer?.RemoveFromSuperLayer();

            var xfButton = Element as Button;
            var colorTop = xfButton.BackgroundColor;
            var colorBottom = Color.Black;

            gradLayer = Gradient.GetGradientLayer(colorTop.ToCGColor(), colorBottom.ToCGColor(), (float)xfButton.Width, (float)xfButton.Height);

            Control.Layer.InsertSublayer(gradLayer, 0);
        }
    }
}
