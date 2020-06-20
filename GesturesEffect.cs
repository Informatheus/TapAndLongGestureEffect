using System.Windows.Input;
using Xamarin.Forms;

namespace <namespace> {

    public class GesturesEffect : RoutingEffect
    {
        public GesturesEffect() : base("<namespace>.GesturesEffect")

        {
        }

        public static readonly BindableProperty LongCommandProperty = BindableProperty.CreateAttached("LongCommand", typeof(ICommand), typeof(GesturesEffect), (object)null);

        public static ICommand GetLongCommand(BindableObject view)
            => (ICommand)view.GetValue(LongCommandProperty);

        public static void SetLongCommand(BindableObject view, ICommand value)
            => view.SetValue(LongCommandProperty, value);

        public static readonly BindableProperty LongCommandParameterProperty = BindableProperty.CreateAttached("LongCommandParameter", typeof(object), typeof(GesturesEffect), (object)null);

        public static object GetLongCommandParameter(BindableObject view)
            => view.GetValue(LongCommandParameterProperty);

        public static void SetLongCommandParameter(BindableObject view, object value)
            => view.SetValue(LongCommandParameterProperty, value);

        public static readonly BindableProperty TapCommandProperty = BindableProperty.CreateAttached("TapCommand", typeof(ICommand), typeof(GesturesEffect), (object)null);

        public static ICommand GetTapCommand(BindableObject view)
            => (ICommand)view.GetValue(TapCommandProperty);

        public static void SetTapCommand(BindableObject view, ICommand value)
            => view.SetValue(TapCommandProperty, value);

        public static readonly BindableProperty TapCommandParameterProperty = BindableProperty.CreateAttached("TapCommandParameter", typeof(object), typeof(GesturesEffect), (object)null);

        public static object GetTapCommandParameter(BindableObject view)
            => view.GetValue(TapCommandParameterProperty);

        public static void SetCommandParameter(BindableObject view, object value)
            => view.SetValue(TapCommandParameterProperty, value);

    }
}

