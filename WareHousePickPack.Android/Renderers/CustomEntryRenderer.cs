using Xamarin.Forms;
using Android.Content;
using WareHousePickPack.Controls;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using WareHousePickPack.Droid.Renderers;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace WareHousePickPack.Droid.Renderers
{
	public class CustomEntryRenderer : EntryRenderer
	{
		public CustomEntryRenderer(Context context) : base(context)
		{
		}
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
				Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
		}
	}
}