using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("<namespace>")]
[assembly: ExportEffect(typeof(AndroidGestureEffect), "GesturesEffect")]
namespace <android-namespace> {

    public class AndroidGestureEffect : PlatformEffect
    {
        private bool _attached;

     
        public static void Initialize() { }

    
        public AndroidGestureEffect()
        {
        }


        protected override void OnAttached()
        {
           
            if (!_attached)
            {
                if (Control != null)
                {
                    Control.LongClickable = true;
                    Control.LongClick += Control_LongClick;
                    Control.Clickable = true;
                    Control.Click += Control_SingleClick;
                }
                else
                {
                    Container.LongClickable = true;
                    Container.LongClick += Control_LongClick;
                    Container.Clickable = true;
                    Container.Click += Control_SingleClick;
                }
                _attached = true;
            }
        }


        private void Control_LongClick(object sender, Android.Views.View.LongClickEventArgs e)
        {
            Console.WriteLine("Invoking long click command");
            var command = GesturesEffect.GetLongCommand(Element);
            command?.Execute(GesturesEffect.GetLongCommandParameter(Element));
        }

        private void Control_SingleClick(object sender, EventArgs e)
        {
            Console.WriteLine("Invoke single click command");
            var command = GesturesEffect.GetTapCommand(Element);
            command?.Execute(GesturesEffect.GetTapCommandParameter(Element));
        }

        protected override void OnDetached()
        {
            if (_attached)
            {
                if (Control != null)
                {
                    Control.LongClickable = true;
                    Control.LongClick -= Control_LongClick;
                }
                else
                {
                    Container.LongClickable = true;
                    Container.LongClick -= Control_LongClick;
                }
                _attached = false;
            }
        }
    }
}
   