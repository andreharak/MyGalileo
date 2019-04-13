using System;
using System.Linq;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using MyGalileoLibrary;

namespace MyGalileoMac
{
    public partial class ViewController : NSViewController
    {
        private GeoLocationManager GeoManager { get; set; }
        private bool ConnectedToInternet { get; set; }

        public ViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ConnectedToInternet = false;
            CheckInternetConnection();
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        private void CheckInternetConnection()
        {
            ConnectedToInternet = InternetManager.CheckForInternetConnection();
        }

        [Action("RunButton_Clicked:")]
        private async void RunButton_Clicked(NSObject sender)
        {
            ResetForm();

            GeoManager = new GeoLocationManager();
            
            RunButton.Enabled = false;
            LoadingGif.Image = NSImage.ImageNamed("loading");
            LoadingGif.Enabled = true;

            if (ConnectedToInternet)
            {
                bool CanContinue = await GeoManager.GetCurrentLocation();

                if (CanContinue)
                {
                    FillFormPart1();

                    await GetAndFillHospital();

                    await GetAndFillUniversity();

                    await GetAndFillMuseum();

                    await GetAndFillAirport();

                    EnableButtonDisablePreloader();
                }
                else
                {
                    AlertMessage("Unable to locate your device!", "Error!");
                    ResetForm("N/A");
                    EnableButtonDisablePreloader();
                }
            }
            else
            {
                CheckInternetConnection();
                AlertMessage("Please check you internet connection!", "No Internet Connection!");
                ResetForm("N/A");
                EnableButtonDisablePreloader();
            }
        }

        private void EnableButtonDisablePreloader()
        {
            RunButton.Enabled = true;
            LoadingGif.Image = null;
            LoadingGif.Enabled = false;
        }

        private void ResetForm(string txt="")
        {
            CurrentLatitude.StringValue = txt;
            CurrentLongitude.StringValue = txt;
            ClosestHospital.StringValue = txt;
            ClosestUniversity.StringValue = txt;
            ClosestMuseum.StringValue = txt;
            ClosestAirport.StringValue = txt;

            DistanceFromHospital.StringValue = txt;
            DistanceFromUniversity.StringValue = txt;
            DistanceFromMuseum.StringValue = txt;
            DistanceFromAirport.StringValue = txt;
        }

        private async Task GetAndFillHospital()
        {
            await Task.Run(() => GeoManager.GetClosestHospital());

            FillFormPart2();
        }

        private async Task GetAndFillUniversity()
        {
            await Task.Run(() => GeoManager.GetClosestUniversity());

            FillFormPart3();
        }

        private async Task GetAndFillMuseum()
        {
            await Task.Run(() => GeoManager.GetClosestMuseum());

            FillFormPart4();
        }

        private async Task GetAndFillAirport()
        {
            await Task.Run(() => GeoManager.GetClosestAirport());

            FillFormPart5();
        }

        private void FillFormPart1()
        {
            if (GeoManager.CurrentLatitude > 0)
            {
                CurrentLatitude.StringValue = Math.Round(GeoManager.CurrentLatitude, 6).ToString();
            }

            if (GeoManager.CurrentLongitude > 0)
            {
                CurrentLongitude.StringValue = Math.Round(GeoManager.CurrentLongitude, 6).ToString();
            }
        }

        private void FillFormPart2()
        {
            if (GeoManager.ClosestHospital.Name.Any())
            {
                ClosestHospital.StringValue = GeoManager.ClosestHospital.Name;
            }

            if (GeoManager.ClosestHospital.Distance > double.Epsilon)
            {
                if (GeoManager.ClosestHospital.Distance >= 1000)
                {
                    DistanceFromHospital.StringValue = string.Format("{0} km", Math.Round(GeoManager.ClosestHospital.Distance / 1000, 2));
                }
                else
                {
                    DistanceFromHospital.StringValue = string.Format("{0} m", Math.Round(GeoManager.ClosestHospital.Distance, 2));
                }
            }
            else DistanceFromHospital.StringValue = "N/A";
        }

        private void FillFormPart3()
        {
            if (GeoManager.ClosestUniversity.Name.Any())
            {
                ClosestUniversity.StringValue = GeoManager.ClosestUniversity.Name;
            }

            if (GeoManager.ClosestUniversity.Distance > double.Epsilon)
            {
                if (GeoManager.ClosestUniversity.Distance >= 1000)
                {
                    DistanceFromUniversity.StringValue = string.Format("{0} km", Math.Round(GeoManager.ClosestUniversity.Distance / 1000, 2));
                }
                else
                {
                    DistanceFromUniversity.StringValue = string.Format("{0} m", Math.Round(GeoManager.ClosestUniversity.Distance, 2));
                }
            }
            else DistanceFromUniversity.StringValue = "N/A";
        }

        private void FillFormPart4()
        {
            if (GeoManager.ClosestMuseum.Name.Any())
            {
                ClosestMuseum.StringValue = GeoManager.ClosestMuseum.Name;
            }

            if (GeoManager.ClosestMuseum.Distance > double.Epsilon)
            {
                if (GeoManager.ClosestMuseum.Distance >= 1000)
                {
                    DistanceFromMuseum.StringValue = string.Format("{0} km", Math.Round(GeoManager.ClosestMuseum.Distance / 1000, 2));
                }
                else
                {
                    DistanceFromMuseum.StringValue = string.Format("{0} m", Math.Round(GeoManager.ClosestMuseum.Distance, 2));
                }
            }
            else DistanceFromMuseum.StringValue = "N/A";
        }

        private void FillFormPart5()
        {
            if (GeoManager.ClosestAirport.Name.Any())
            {
                ClosestAirport.StringValue = GeoManager.ClosestAirport.Name;
            }

            if (GeoManager.ClosestAirport.Distance > double.Epsilon)
            {
                if (GeoManager.ClosestAirport.Distance >= 1000)
                {
                    DistanceFromAirport.StringValue = string.Format("{0} km", Math.Round(GeoManager.ClosestAirport.Distance / 1000, 2));
                }
                else
                {
                    DistanceFromAirport.StringValue = string.Format("{0} m", Math.Round(GeoManager.ClosestAirport.Distance, 2));
                }
            }
            else DistanceFromAirport.StringValue = "N/A";
        }

        public void AlertMessage(string message, string title)
        {
            var alert = new NSAlert()
            {
                AlertStyle = NSAlertStyle.Informational,
                InformativeText = message,
                MessageText = title,
            };
            alert.AddButton("Ok");
            alert.BeginSheet(View.Window);
        }
    }
}