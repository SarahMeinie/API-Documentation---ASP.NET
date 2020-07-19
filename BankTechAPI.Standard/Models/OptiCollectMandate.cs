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
    public class OptiCollectMandate : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Contract contract;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("contract")]
        public Models.Contract Contract 
        { 
            get 
            {
                return this.contract; 
            } 
            set 
            {
                this.contract = value;
                onPropertyChanged("Contract");
            }
        }
    }
} 