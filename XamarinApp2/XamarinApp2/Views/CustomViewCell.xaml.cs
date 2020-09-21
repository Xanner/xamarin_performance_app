using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2.Models;

namespace XamarinApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomViewCell : ViewCell
    {
        public CustomViewCell()
        {
            InitializeComponent();

            InitCell();
        }

        public async void InitCell()
        {
            var wtoken = new CancellationToken(false);
            await RotateElement(ImageAvatar, wtoken);
        }

        protected override void OnBindingContextChanged()
        {
            SetupCell();
            base.OnBindingContextChanged();
        }

        public void SetupCell()
        {
            var item = BindingContext as Item;
            if (item == null) return;

            AnimationLabel.Text = item.Text;
        }

        private async Task RotateElement(VisualElement element, CancellationToken cancellation)
        {
            while (!cancellation.IsCancellationRequested)
            {
                await element.RotateTo(360, 2000, Easing.Linear);
                await element.RotateTo(0, 0);
            }
        }
    }
}
