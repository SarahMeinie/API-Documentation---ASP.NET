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
    public class SouthAfricanIDNumberVerificationRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string idNumber;
        private string yourReference;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("idNumber")]
        public string IdNumber 
        { 
            get 
            {
                return this.idNumber; 
            } 
            set 
            {
                this.idNumber = value;
                onPropertyChanged("IdNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("yourReference")]
        public string YourReference 
        { 
            get 
            {
                return this.yourReference; 
            } 
            set 
            {
                this.yourReference = value;
                onPropertyChanged("YourReference");
            }
        }
    }
} 