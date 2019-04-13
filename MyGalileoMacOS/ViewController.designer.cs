// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MyGalileoMac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ClosestAirport { get; set; }

		[Outlet]
		AppKit.NSTextField ClosestHospital { get; set; }

		[Outlet]
		AppKit.NSTextField ClosestMuseum { get; set; }

		[Outlet]
		AppKit.NSTextField ClosestUniversity { get; set; }

		[Outlet]
		AppKit.NSTextField CurrentLatitude { get; set; }

		[Outlet]
		AppKit.NSTextField CurrentLongitude { get; set; }

		[Outlet]
		AppKit.NSTextField DistanceFromAirport { get; set; }

		[Outlet]
		AppKit.NSTextField DistanceFromHospital { get; set; }

		[Outlet]
		AppKit.NSTextField DistanceFromMuseum { get; set; }

		[Outlet]
		AppKit.NSTextField DistanceFromUniversity { get; set; }

		[Outlet]
		AppKit.NSImageView LoadingGif { get; set; }

		[Outlet]
		AppKit.NSButton RunButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ClosestAirport != null) {
				ClosestAirport.Dispose ();
				ClosestAirport = null;
			}

			if (ClosestHospital != null) {
				ClosestHospital.Dispose ();
				ClosestHospital = null;
			}

			if (ClosestMuseum != null) {
				ClosestMuseum.Dispose ();
				ClosestMuseum = null;
			}

			if (ClosestUniversity != null) {
				ClosestUniversity.Dispose ();
				ClosestUniversity = null;
			}

			if (CurrentLatitude != null) {
				CurrentLatitude.Dispose ();
				CurrentLatitude = null;
			}

			if (CurrentLongitude != null) {
				CurrentLongitude.Dispose ();
				CurrentLongitude = null;
			}

			if (DistanceFromAirport != null) {
				DistanceFromAirport.Dispose ();
				DistanceFromAirport = null;
			}

			if (DistanceFromHospital != null) {
				DistanceFromHospital.Dispose ();
				DistanceFromHospital = null;
			}

			if (DistanceFromMuseum != null) {
				DistanceFromMuseum.Dispose ();
				DistanceFromMuseum = null;
			}

			if (DistanceFromUniversity != null) {
				DistanceFromUniversity.Dispose ();
				DistanceFromUniversity = null;
			}

			if (RunButton != null) {
				RunButton.Dispose ();
				RunButton = null;
			}

			if (LoadingGif != null) {
				LoadingGif.Dispose ();
				LoadingGif = null;
			}
		}
	}
}
