/*
 * BankTechAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BankTechAPI.Standard;
using BankTechAPI.Standard.Utilities;


namespace BankTechAPI.Standard.Models
{
    public class CancelRegisteredMandateSRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string objectId;
        private string mandateIdentification;
        private string cancellationReasonCode;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("objectId")]
        public string ObjectId 
        { 
            get 
            {
                return this.objectId; 
            } 
            set 
            {
                this.objectId = value;
                onPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mandateIdentification")]
        public string MandateIdentification 
        { 
            get 
            {
                return this.mandateIdentification; 
            } 
            set 
            {
                this.mandateIdentification = value;
                onPropertyChanged("MandateIdentification");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cancellationReasonCode")]
        public string CancellationReasonCode 
        { 
            get 
            {
                return this.cancellationReasonCode; 
            } 
            set 
            {
                this.cancellationReasonCode = value;
                onPropertyChanged("CancellationReasonCode");
            }
        }
    }
} 