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
    public class Collection : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mandateIdentification;
        private string collectionIdentifications;
        private string contractReference;
        private string collectionReference;
        private string collectionCurrency;
        private double collectionAmount;
        private string forDate;
        private string requestedActionDate;
        private string clientSegment;
        private bool recall;
        private string collectionInstrument;
        private string trackingPeriod;
        private string submissionDate;
        private string actionDate;
        private string resultCode;
        private string resultDate;
        private bool disputed;
        private string disputeCode;
        private string disputeDate;

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
        [JsonProperty("collectionIdentifications")]
        public string CollectionIdentifications 
        { 
            get 
            {
                return this.collectionIdentifications; 
            } 
            set 
            {
                this.collectionIdentifications = value;
                onPropertyChanged("CollectionIdentifications");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("contractReference")]
        public string ContractReference 
        { 
            get 
            {
                return this.contractReference; 
            } 
            set 
            {
                this.contractReference = value;
                onPropertyChanged("ContractReference");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("collectionReference")]
        public string CollectionReference 
        { 
            get 
            {
                return this.collectionReference; 
            } 
            set 
            {
                this.collectionReference = value;
                onPropertyChanged("CollectionReference");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("collectionCurrency")]
        public string CollectionCurrency 
        { 
            get 
            {
                return this.collectionCurrency; 
            } 
            set 
            {
                this.collectionCurrency = value;
                onPropertyChanged("CollectionCurrency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("collectionAmount")]
        public double CollectionAmount 
        { 
            get 
            {
                return this.collectionAmount; 
            } 
            set 
            {
                this.collectionAmount = value;
                onPropertyChanged("CollectionAmount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("forDate")]
        public string ForDate 
        { 
            get 
            {
                return this.forDate; 
            } 
            set 
            {
                this.forDate = value;
                onPropertyChanged("ForDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("requestedActionDate")]
        public string RequestedActionDate 
        { 
            get 
            {
                return this.requestedActionDate; 
            } 
            set 
            {
                this.requestedActionDate = value;
                onPropertyChanged("RequestedActionDate");
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
        [JsonProperty("recall")]
        public bool Recall 
        { 
            get 
            {
                return this.recall; 
            } 
            set 
            {
                this.recall = value;
                onPropertyChanged("Recall");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("collectionInstrument")]
        public string CollectionInstrument 
        { 
            get 
            {
                return this.collectionInstrument; 
            } 
            set 
            {
                this.collectionInstrument = value;
                onPropertyChanged("CollectionInstrument");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("trackingPeriod")]
        public string TrackingPeriod 
        { 
            get 
            {
                return this.trackingPeriod; 
            } 
            set 
            {
                this.trackingPeriod = value;
                onPropertyChanged("TrackingPeriod");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("submissionDate")]
        public string SubmissionDate 
        { 
            get 
            {
                return this.submissionDate; 
            } 
            set 
            {
                this.submissionDate = value;
                onPropertyChanged("SubmissionDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("actionDate")]
        public string ActionDate 
        { 
            get 
            {
                return this.actionDate; 
            } 
            set 
            {
                this.actionDate = value;
                onPropertyChanged("ActionDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("resultCode")]
        public string ResultCode 
        { 
            get 
            {
                return this.resultCode; 
            } 
            set 
            {
                this.resultCode = value;
                onPropertyChanged("ResultCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("resultDate")]
        public string ResultDate 
        { 
            get 
            {
                return this.resultDate; 
            } 
            set 
            {
                this.resultDate = value;
                onPropertyChanged("ResultDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("disputed")]
        public bool Disputed 
        { 
            get 
            {
                return this.disputed; 
            } 
            set 
            {
                this.disputed = value;
                onPropertyChanged("Disputed");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("disputeCode")]
        public string DisputeCode 
        { 
            get 
            {
                return this.disputeCode; 
            } 
            set 
            {
                this.disputeCode = value;
                onPropertyChanged("DisputeCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("disputeDate")]
        public string DisputeDate 
        { 
            get 
            {
                return this.disputeDate; 
            } 
            set 
            {
                this.disputeDate = value;
                onPropertyChanged("DisputeDate");
            }
        }
    }
} 