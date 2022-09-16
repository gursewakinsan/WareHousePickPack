using Xamarin.Forms;
using Android.Content;
using WareHousePickPack.Controls;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(WareHousePickPack.Droid.Renderers.CustomPickerRenderer))]
namespace WareHousePickPack.Droid.Renderers
{
	public class CustomPickerRenderer : PickerRenderer
	{
		GradientDrawable gd;
		public CustomPickerRenderer(Context context) : base(context)
		{
		}
		protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.Focusable = false;
				if (gd == null)
					gd = new GradientDrawable();
				gd.SetStroke(0, Android.Graphics.Color.Transparent);
				Control.SetBackgroundDrawable(gd);
			}
		}
	}
}