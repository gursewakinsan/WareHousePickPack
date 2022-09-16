﻿using UIKit;
using Xamarin.Forms;
using WareHousePickPack.Controls;
using WareHousePickPack.iOS.Renderers;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace WareHousePickPack.iOS.Renderers
{
	public class CustomPickerRenderer : PickerRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
				this.Control.BorderStyle = UITextBorderStyle.None;
		}
	}
}