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
    public class RequestDebiCheckAuthenticationOnAMandateRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string bank;
        private string maxCollectionCurrency;
        private string maxCollectionAmount;
        private string mandateIdentification;
        private string adjustmentAmount;
        private string adjustmentCategory;
        private string adjustmentRate;
        private string authenticationCode;
        private string authenticationDate;
        private string authenticationInstrument;
        private string authenticationType;
        private string clientContractReference;
        private string clientRequestReference;
        private string collectionFrequency;
        private string collectionDay;
        private string collectionType;
        private string currency;
        private string dateAdjustmentAllowed;
        private string debitValueType;
        private string entryClass;
        private string firstCollectionIdentifier;
        private string firstCollectionDate;
        private string firstCollectionAmount;
        private string firstCollectionCurrency;
        private string initiationDate;
        private string instalmentAmount;
        private string instalmentOccurrence;
        private string debiCheckAuthKey;
        private string clientSegment;
        private string trackingAllowed;
        private string trackingDays;
        private string useAmountAdjustment;
        private string useRateAdjustment;
        private string releaseDate;
        private Models.Debtor debtor;
        private Models.Creditor creditor;

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
        [JsonProperty("maxCollectionCurrency")]
        public string MaxCollectionCurrency 
        { 
            get 
            {
                return this.maxCollectionCurrency; 
            } 
            set 
            {
                this.maxCollectionCurrency = value;
                onPropertyChanged("MaxCollectionCurrency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("maxCollectionAmount")]
        public string MaxCollectionAmount 
        { 
            get 
            {
                return this.maxCollectionAmount; 
            } 
            set 
            {
                this.maxCollectionAmount = value;
                onPropertyChanged("MaxCollectionAmount");
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
        [JsonProperty("adjustmentAmount")]
        public string AdjustmentAmount 
        { 
            get 
            {
                return this.adjustmentAmount; 
            } 
            set 
            {
                this.adjustmentAmount = value;
                onPropertyChanged("AdjustmentAmount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("adjustmentCategory")]
        public string AdjustmentCategory 
        { 
            get 
            {
                return this.adjustmentCategory; 
            } 
            set 
            {
                this.adjustmentCategory = value;
                onPropertyChanged("AdjustmentCategory");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("adjustmentRate")]
        public string AdjustmentRate 
        { 
            get 
            {
                return this.adjustmentRate; 
            } 
            set 
            {
                this.adjustmentRate = value;
                onPropertyChanged("AdjustmentRate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("authenticationCode")]
        public string AuthenticationCode 
        { 
            get 
            {
                return this.authenticationCode; 
            } 
            set 
            {
                this.authenticationCode = value;
                onPropertyChanged("AuthenticationCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("authenticationDate")]
        public string AuthenticationDate 
        { 
            get 
            {
                return this.authenticationDate; 
            } 
            set 
            {
                this.authenticationDate = value;
                onPropertyChanged("AuthenticationDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("authenticationInstrument")]
        public string AuthenticationInstrument 
        { 
            get 
            {
                return this.authenticationInstrument; 
            } 
            set 
            {
                this.authenticationInstrument = value;
                onPropertyChanged("AuthenticationInstrument");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("authenticationType")]
        public string AuthenticationType 
        { 
            get 
            {
                return this.authenticationType; 
            } 
            set 
            {
                this.authenticationType = value;
                onPropertyChanged("AuthenticationType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientContractReference")]
        public string ClientContractReference 
        { 
            get 
            {
                return this.clientContractReference; 
            } 
            set 
            {
                this.clientContractReference = value;
                onPropertyChanged("ClientContractReference");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientRequestReference")]
        public string ClientRequestReference 
        { 
            get 
            {
                return this.clientRequestReference; 
            } 
            set 
            {
                this.clientRequestReference = value;
                onPropertyChanged("ClientRequestReference");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("collectionFrequency")]
        public string CollectionFrequency 
        { 
            get 
            {
                return this.collectionFrequency; 
            } 
            set 
            {
                this.collectionFrequency = value;
                onPropertyChanged("CollectionFrequency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("collectionDay")]
        public string CollectionDay 
        { 
            get 
            {
                return this.collectionDay; 
            } 
            set 
            {
                this.collectionDay = value;
                onPropertyChanged("CollectionDay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("collectionType")]
        public string CollectionType 
        { 
            get 
            {
                return this.collectionType; 
            } 
            set 
            {
                this.collectionType = value;
                onPropertyChanged("CollectionType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("dateAdjustmentAllowed")]
        public string DateAdjustmentAllowed 
        { 
            get 
            {
                return this.dateAdjustmentAllowed; 
            } 
            set 
            {
                this.dateAdjustmentAllowed = value;
                onPropertyChanged("DateAdjustmentAllowed");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("debitValueType")]
        public string DebitValueType 
        { 
            get 
            {
                return this.debitValueType; 
            } 
            set 
            {
                this.debitValueType = value;
                onPropertyChanged("DebitValueType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("entryClass")]
        public string EntryClass 
        { 
            get 
            {
                return this.entryClass; 
            } 
            set 
            {
                this.entryClass = value;
                onPropertyChanged("EntryClass");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstCollectionIdentifier")]
        public string FirstCollectionIdentifier 
        { 
            get 
            {
                return this.firstCollectionIdentifier; 
            } 
            set 
            {
                this.firstCollectionIdentifier = value;
                onPropertyChanged("FirstCollectionIdentifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstCollectionDate")]
        public string FirstCollectionDate 
        { 
            get 
            {
                return this.firstCollectionDate; 
            } 
            set 
            {
                this.firstCollectionDate = value;
                onPropertyChanged("FirstCollectionDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstCollectionAmount")]
        public string FirstCollectionAmount 
        { 
            get 
            {
                return this.firstCollectionAmount; 
            } 
            set 
            {
                this.firstCollectionAmount = value;
                onPropertyChanged("FirstCollectionAmount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstCollectionCurrency")]
        public string FirstCollectionCurrency 
        { 
            get 
            {
                return this.firstCollectionCurrency; 
            } 
            set 
            {
                this.firstCollectionCurrency = value;
                onPropertyChanged("FirstCollectionCurrency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("initiationDate")]
        public string InitiationDate 
        { 
            get 
            {
                return this.initiationDate; 
            } 
            set 
            {
                this.initiationDate = value;
                onPropertyChanged("InitiationDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("instalmentAmount")]
        public string InstalmentAmount 
        { 
            get 
            {
                return this.instalmentAmount; 
            } 
            set 
            {
                this.instalmentAmount = value;
                onPropertyChanged("InstalmentAmount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("instalmentOccurrence")]
        public string InstalmentOccurrence 
        { 
            get 
            {
                return this.instalmentOccurrence; 
            } 
            set 
            {
                this.instalmentOccurrence = value;
                onPropertyChanged("InstalmentOccurrence");
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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientSegment")]
        public string ClientSegment 
        { 
            get 
            {
                return this.clientSegment; 
            } 
            set 
            {
                this.clientSegment = value;
                onPropertyChanged("ClientSegment");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("trackingAllowed")]
        public string TrackingAllowed 
        { 
            get 
            {
                return this.trackingAllowed; 
            } 
            set 
            {
                this.trackingAllowed = value;
                onPropertyChanged("TrackingAllowed");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("trackingDays")]
        public string TrackingDays 
        { 
            get 
            {
                return this.trackingDays; 
            } 
            set 
            {
                this.trackingDays = value;
                onPropertyChanged("TrackingDays");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("useAmountAdjustment")]
        public string UseAmountAdjustment 
        { 
            get 
            {
                return this.useAmountAdjustment; 
            } 
            set 
            {
                this.useAmountAdjustment = value;
                onPropertyChanged("UseAmountAdjustment");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("useRateAdjustment")]
        public string UseRateAdjustment 
        { 
            get 
            {
                return this.useRateAdjustment; 
            } 
            set 
            {
                this.useRateAdjustment = value;
                onPropertyChanged("UseRateAdjustment");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("releaseDate")]
        public string ReleaseDate 
        { 
            get 
            {
                return this.releaseDate; 
            } 
            set 
            {
                this.releaseDate = value;
                onPropertyChanged("ReleaseDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("debtor")]
        public Models.Debtor Debtor 
        { 
            get 
            {
                return this.debtor; 
            } 
            set 
            {
                this.debtor = value;
                onPropertyChanged("Debtor");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("creditor")]
        public Models.Creditor Creditor 
        { 
            get 
            {
                return this.creditor; 
            } 
            set 
            {
                this.creditor = value;
                onPropertyChanged("Creditor");
            }
        }
    }
} 