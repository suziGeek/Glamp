using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public class CampsiteDetail
    {
        public CampsiteDetail()
        {

        }

        public CampsiteDetail(string facilityName, string facilityID, string contractID, double longitude, double latitude)
        {
            this.facilityName = facilityName;
            this.facilityID = facilityID;
            this.longitude = longitude;
            this.latitude = latitude;
            this.contractID = contractID;
        }

        public double latitude { get; set; }
        public double longitude { get; set; }
        public string contractID { get; set; }
        public string campId { get; set; }
        public string alert { get; set; }
        public string description { get; set; }
        public string drivingDirections { get; set; }
        public string facility { get; set; }
        public string importantInformation { get; set; }
        public string note { get; set; }
        public List<CampsiteDetail> allCampDetails { get; set; }
        public string fullReservationUrl { get; set; }
        public string address { get; set; }
        public string user { get; set; }
        public string facilityID { get; set; }
        public string facilityName { get; set; }



        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Root
        {
            

            public string alertField;

            public string contractIDField;

            public string descriptionField;

            public string drivingDirectionField;

            public object facilitiesDescriptionField;

            public string facilityField;

            public string facilityIDField;

            public string favoriteField;

            public string fullReservationUrlField;

            public string importantInformationField;

            public decimal latitudeField;

            public string listingOnlyField;

            public decimal longitudeField;

            public object nearbyAttrctionDescriptionField;

            public string noteField;

            public object orientationDescriptionField;

            public object recreationDescriptionField;

            public string regionNameField;

            public string reservationUrlField;

            public object webURLField;

            /// <remarks/>
            public string alert
            {
                get
                {
                    return this.alertField;
                }
                set
                {
                    this.alertField = value;
                }
            }

            /// <remarks/>
            public string contractID
            {
                get
                {
                    return this.contractIDField;
                }
                set
                {
                    this.contractIDField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string drivingDirection
            {
                get
                {
                    return this.drivingDirectionField;
                }
                set
                {
                    this.drivingDirectionField = value;
                }
            }

            /// <remarks/>
            public object facilitiesDescription
            {
                get
                {
                    return this.facilitiesDescriptionField;
                }
                set
                {
                    this.facilitiesDescriptionField = value;
                }
            }

            /// <remarks/>
            public string facility
            {
                get
                {
                    return this.facilityField;
                }
                set
                {
                    this.facilityField = value;
                }
            }

            /// <remarks/>
            public string facilityID
            {
                get
                {
                    return this.facilityIDField;
                }
                set
                {
                    this.facilityIDField = value;
                }
            }

            /// <remarks/>
            public string favorite
            {
                get
                {
                    return this.favoriteField;
                }
                set
                {
                    this.favoriteField = value;
                }
            }

            /// <remarks/>
            public string fullReservationUrl
            {
                get
                {
                    return this.fullReservationUrlField;
                }
                set
                {
                    this.fullReservationUrlField = value;
                }
            }

            /// <remarks/>
            public string importantInformation
            {
                get
                {
                    return this.importantInformationField;
                }
                set
                {
                    this.importantInformationField = value;
                }
            }

            /// <remarks/>
            public decimal latitude
            {
                get
                {
                    return this.latitudeField;
                }
                set
                {
                    this.latitudeField = value;
                }
            }

            /// <remarks/>
            public string listingOnly
            {
                get
                {
                    return this.listingOnlyField;
                }
                set
                {
                    this.listingOnlyField = value;
                }
            }

            /// <remarks/>
            public decimal longitude
            {
                get
                {
                    return this.longitudeField;
                }
                set
                {
                    this.longitudeField = value;
                }
            }

            /// <remarks/>
            public object nearbyAttrctionDescription
            {
                get
                {
                    return this.nearbyAttrctionDescriptionField;
                }
                set
                {
                    this.nearbyAttrctionDescriptionField = value;
                }
            }

            /// <remarks/>
            public string note
            {
                get
                {
                    return this.noteField;
                }
                set
                {
                    this.noteField = value;
                }
            }

            /// <remarks/>
            public object orientationDescription
            {
                get
                {
                    return this.orientationDescriptionField;
                }
                set
                {
                    this.orientationDescriptionField = value;
                }
            }

            /// <remarks/>
            public object recreationDescription
            {
                get
                {
                    return this.recreationDescriptionField;
                }
                set
                {
                    this.recreationDescriptionField = value;
                }
            }

            /// <remarks/>
            public string regionName
            {
                get
                {
                    return this.regionNameField;
                }
                set
                {
                    this.regionNameField = value;
                }
            }

            /// <remarks/>
            public string reservationUrl
            {
                get
                {
                    return this.reservationUrlField;
                }
                set
                {
                    this.reservationUrlField = value;
                }
            }

            /// <remarks/>
            public object webURL
            {
                get
                {
                    return this.webURLField;
                }
                set
                {
                    this.webURLField = value;
                }
            }
        }

    }
}
