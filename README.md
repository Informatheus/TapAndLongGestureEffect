# TapAndLongGestureEffect
Implements Tap and LongPress/LongClick gestures for Xamarin.Forms (Android & iOS) using Command and CommandParameter.

## Install
Paste the three files in respective projects (Shared, Android and iOS), replacing the < namespaces > in each one.

## Setup
Set the atributte on layout root
```
xmlns:effect="clr-namespace:<namespace>"
```
replacing the < namespace >.
## Using
```
<View effect:GesturesEffect.Command="{Binding YourCommand}"
      effect:GesturesEffect.TapCommand="{Binding YourCommand}"
      effect:GesturesEffect.TapCommandParameter="{Binding .}"
      effect:GesturesEffect.LongCommand="{Binding YourCommand}"
      effect:GesturesEffect.LongCommand=Parameter"{Binding .}"
      >
      
      <View.Effects>
        <effect:GesturesEffect/>
      </View.Effects>      
```   
***Does not work on Cell objects.***
