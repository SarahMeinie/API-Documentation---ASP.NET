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
    public class MandateReturned : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Mandate mandate;
        private int status;
        private string title;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mandate")]
        public Models.Mandate Mandate 
        { 
            get 
            {
                return this.mandate; 
            } 
            set 
            {
                this.mandate = value;
                onPropertyChanged("Mandate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public int Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("title")]
        public string Title 
        { 
            get 
            {
                return this.title; 
            } 
            set 
            {
                this.title = value;
                onPropertyChanged("Title");
            }
        }
    }
} 