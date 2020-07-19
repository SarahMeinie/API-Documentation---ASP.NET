using System.Collections.Generic;
using System.Text;
using BankTechAPI.Standard.Utilities;
using BankTechAPI.Standard.Models;
namespace BankTechAPI.Standard
{
    public partial class Configuration
    {


        public enum Environments
        {
            PRODUCTION,
        }
        public enum Servers
        {
            SERVER_1,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //The requested API version
        //TODO: Replace the XApiVersion with an appropriate value
        public static string XApiVersion = "1.0";

        //All requests must include the X-API-KEY header containing your api key.
        //TODO: Replace the XApiKey with an appropriate value
        public static string XApiKey = "";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.SERVER_1,"https://fintecapisandbox.azurewebsites.net/api" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:SERVER 1</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.SERVER_1)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}