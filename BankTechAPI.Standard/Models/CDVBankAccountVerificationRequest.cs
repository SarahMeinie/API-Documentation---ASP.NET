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
    public class CDVBankAccountVerificationRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountNumber;
        private string accountType;
        private string branchCode;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber 
        { 
            get 
            {
                return this.accountNumber; 
            } 
            set 
            {
                this.accountNumber = value;
                onPropertyChanged("AccountNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountType")]
        public string AccountType 
        { 
            get 
            {
                return this.accountType; 
            } 
            set 
            {
                this.accountType = value;
                onPropertyChanged("AccountType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("branchCode")]
        public string BranchCode 
        { 
            get 
            {
                return this.branchCode; 
            } 
            set 
            {
                this.branchCode = value;
                onPropertyChanged("BranchCode");
            }
        }
    }
} 