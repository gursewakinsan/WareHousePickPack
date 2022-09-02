using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using WareHousePickPack.Controls;
using WareHousePickPack.iOS.Renderers;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace WareHousePickPack.iOS.Renderers
{
	public class CustomEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
				Control.BorderStyle = UITextBorderStyle.None;
		}
	}
}