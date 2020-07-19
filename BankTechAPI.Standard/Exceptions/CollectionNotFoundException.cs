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
using BankTechAPI.Standard.Http.Client;

using BankTechAPI.Standard.Models;
using BankTechAPI.Standard;
using BankTechAPI.Standard.Utilities;


namespace BankTechAPI.Standard.Exceptions
{
    public class CollectionNotFoundException : APIException 
    {
        // These fields hold the values for the public properties.
        private List<string> errors;
        private int status;
        private string title;
        private string traceId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            private set 
            {
                this.errors = value;
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
            private set 
            {
                this.status = value;
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
            private set 
            {
                this.title = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("traceId")]
        public string TraceId 
        { 
            get 
            {
                return this.traceId; 
            } 
            private set 
            {
                this.traceId = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public CollectionNotFoundException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 