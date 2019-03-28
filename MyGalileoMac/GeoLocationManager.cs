using System;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using MyGalileoLibrary;

namespace MyGalileoMac
{
    public class GeoLocationManager
    {
        public double CurrentLatitude { get; set; }
        public double CurrentLongitude { get; set; }
        private Position CurrentPosition { get; set; }

        public ApiModelAzureMaps ClosestHospital { get; set; }
        public ApiModelAzureMaps ClosestUniversity { get; set; }
        public ApiModelAzureMaps ClosestMuseum { get; set; }
        public ApiModelAzureMaps ClosestAirport { get; set; }

        public bool IsLocationAvailable()
        {
            if (!CrossGeolocator.IsSupported)
                return false;

            return CrossGeolocator.Current.IsGeolocationAvailable;
        }

        public async Task<bool> GetCurrentLocation()
        {
            try
            {
                var locator = CrossGeolocator.Current;

                CurrentPosition = await locator.GetPositionAsync(TimeSpan.FromSeconds(15));

                if (CurrentPosition != null)
                {
                    CurrentLatitude = CurrentPosition.Latitude;
                    CurrentLongitude = CurrentPosition.Longitude;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool GetClosestHospital()
        {
            ClosestHospital = ApiProcessorAzureMaps.GetPoi("hospital", CurrentLatitude, CurrentLongitude);

            if (ClosestHospital == null)
            {
                ClosestHospital = new ApiModelAzureMaps("Unknown", double.Epsilon);
            }
            return true;
        }

        public bool GetClosestUniversity()
        {
            ClosestUniversity = ApiProcessorAzureMaps.GetPoi("university", CurrentLatitude, CurrentLongitude);

            if (ClosestUniversity == null)
            {
                ClosestUniversity = new ApiModelAzureMaps("Unknown", double.Epsilon);
            }
            return true;
        }

        public bool GetClosestMuseum()
        {
            ClosestMuseum = ApiProcessorAzureMaps.GetPoi("museum", CurrentLatitude, CurrentLongitude);

            if (ClosestMuseum == null)
            {
                ClosestMuseum = new ApiModelAzureMaps("Unknown", double.Epsilon);
            }
            return true;
        }

        public bool GetClosestAirport()
        {
            ClosestAirport = ApiProcessorAzureMaps.GetPoi("airport", CurrentLatitude, CurrentLongitude);

            if (ClosestAirport == null)
            {
                ClosestAirport = new ApiModelAzureMaps("Unknown", double.Epsilon);
            }
            return true;
        }
    }
}