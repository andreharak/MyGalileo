using System;

namespace MyGalileoLibrary
{
    public class ApiModelAzureMaps
    {
        public string Name { get; set; }
        public double Distance { get; set; } // in metres

        public ApiModelAzureMaps() { }

        public ApiModelAzureMaps(string name, double distance)
        {
            Name = name;
            Distance = distance;
        }
    }
}
