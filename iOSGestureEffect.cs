using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("<namespace>")]
[assembly: ExportEffect(typeof(iOSGestureEffect), "GesturesEffect")]
namespace <ios-namespace> {

    public class iOSGestureEffect : PlatformEffect
    {
        private bool _attached;
        private readonly UILongPressGestureRecognizer _longPressRecognizer;
        private readonly UITapGestureRecognizer _singleTapRecognizer;
     
        [Preserve]
        public iOSGestureEffect()
        {
            _longPressRecognizer = new UILongPressGestureRecognizer(HandleLongClick);
            _singleTapRecognizer = new UITapGestureRecognizer(HandleSingleClick);
        }

    
        protected override void OnAttached()
        {
            if (!_attached)
            {
                Container.AddGestureRecognizer(_longPressRecognizer);
                Container.AddGestureRecognizer(_singleTapRecognizer);
                _attached = true;
            }
        }

        private void HandleLongClick()
        {
            var command = GesturesEffect.GetLongCommand(Element);
            command?.Execute(GesturesEffect.GetLongCommandParameter(Element));
        }

        private void HandleSingleClick()
        {
            var command = GesturesEffect.GetTapCommand(Element);
            command?.Execute(GesturesEffect.GetTapCommandParameter(Element));
        }

        protected override void OnDetached()
        {
            if (_attached)
            {
                Container.RemoveGestureRecognizer(_longPressRecognizer);
                Container.RemoveGestureRecognizer(_singleTapRecognizer);
                _attached = false;
            }
        }

    }
}