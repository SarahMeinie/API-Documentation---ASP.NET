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
    public class RequestDebiCheckCancellationOnAMandateRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string bank;
        private string cancellationReasonCode;
        private string debiCheckAuthKey;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bank")]
        public string Bank 
        { 
            get 
            {
                return this.bank; 
            } 
            set 
            {
                this.bank = value;
                onPropertyChanged("Bank");
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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("debiCheckAuthKey")]
        public string DebiCheckAuthKey 
        { 
            get 
            {
                return this.debiCheckAuthKey; 
            } 
            set 
            {
                this.debiCheckAuthKey = value;
                onPropertyChanged("DebiCheckAuthKey");
            }
        }
    }
} 