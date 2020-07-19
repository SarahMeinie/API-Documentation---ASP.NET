# Getting started

Plug-and-play fintech tools to scale your business.
Access our feature-rich console or build your own solution with our API-based architecture.

API Calls regarding **DebiCheck, Communication (WhatsApp and SMS), Transactions, Verification and Mandates.**

#### Mandates 
Consumers authenticate the payment series (or "mandate") either in real-time on their mobile or on one of their banks' channels (USSD, banking app, ATM, etc.).
A mandate is an authorization that a debtor gives to a creditor that enables the creditor to initiate a request for payment for a debt. The company that extends credit to a customer is the creditor. The customer is the debtor.

#### Transactions 
Make payments from any South African bank
Get paid by any combination of the following methods
- Once-off debit orders
- Recurring debit orders
- Late window: EFT debits
- Early window debit orders: DebiCheck
- Early window debit orders: NAEDO
![alt](https://imgur.com/HMBFsS8.png)

#### DebiCheck 
Leverage the most trusted way to authenticate and collect payments
Our DebiCheck portal enables you to initiate DebiCheck mandates directly in the BankTech console as part of your workflow.
DebiCheck collections process in the earliest window, before NAEDO and EFT, so they offer the highest collection success rate. To top it off, an authenticated mandate is not disputable, so payment persistency is improved significantly.
In short, our DebiCheck portal can help your business thrive with better cash flow.

#### Verification 
![alt text](https://imgur.com/VHhrEiH.png)

Avoid losing business through failed transactions at the point of sale with our real-time Account Verification Service (AVSR). Check bank account information fast and cost-effectively, before collecting payments.

Add the AVSR functionality to your app workflow or batch verify to streamline your process.
Verify your customers in real-time with
- Bank account verification
- DebiCheck authentication
- Deceased status check

#### Communication 
![alt text](https://imgur.com/AAGmJ3R.png)


Engage to create a superior user experience.
Create your own automated communication process with our APIs and reach your customers in more convenient ways. Engage via WhatsApp, SMS, Facebook Messenger or USSD push. Trigger personalised responses in-app and give your customers the benefits of self-service.

Make doing business with you as easy as sending a text message and join the chat economy today.

# FA(Integration)Q

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (BankTechAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=BankTech%20API-CSharp&workspaceName=BankTechAPI&projectName=BankTechAPI.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the BankTechAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=BankTech%20API-CSharp&workspaceName=BankTechAPI&projectName=BankTechAPI.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=BankTech%20API-CSharp&workspaceName=BankTechAPI&projectName=BankTechAPI.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=BankTech%20API-CSharp&workspaceName=BankTechAPI&projectName=BankTechAPI.Tests)

### 3. Add reference of the library project

In order to use the BankTechAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=BankTech%20API-CSharp&workspaceName=BankTechAPI&projectName=BankTechAPI.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` BankTechAPI.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```BankTechAPI.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=BankTech%20API-CSharp&workspaceName=BankTechAPI&projectName=BankTechAPI.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=BankTech%20API-CSharp&workspaceName=BankTechAPI&projectName=BankTechAPI.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| xApiVersion | The requested API version |
| xApiKey | All requests must include the X-API-KEY header containing your api key. |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string xApiVersion = "1.0"; // The requested API version
string xApiKey = "xApiKey"; // All requests must include the X-API-KEY header containing your api key.

BankTechAPIClient client = new BankTechAPIClient(xApiVersion, xApiKey);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [CommunicationController](#communication_controller)
* [MandateController](#mandate_controller)
* [ServiceController](#service_controller)
* [TransactController](#transact_controller)
* [VerifyController](#verify_controller)

## <a name="communication_controller"></a>![Class: ](https://apidocs.io/img/class.png "BankTechAPI.Tests.Controllers.CommunicationController") CommunicationController

### Get singleton instance

The singleton instance of the ``` CommunicationController ``` class can be accessed from the API Client.

```csharp
CommunicationController communication = client.Communication;
```

### <a name="create_send_a_whats_app_message"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateSendAWhatsAppMessage") CreateSendAWhatsAppMessage

> Send a WhatsApp message to a mobile number.


```csharp
Task<Standard.Models.WhatsappMessageSuccesfullySent> CreateSendAWhatsAppMessage(double xApiVersion, string contentType, Standard.Models.SendAWhatsAppMessageToAMobileNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"to\": \"<string>\",\r\n  \"body\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendAWhatsAppMessageToAMobileNumberRequest>(bodyValue);

Standard.Models.WhatsappMessageSuccesfullySent result = await communication.CreateSendAWhatsAppMessage(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_templated_whats_app_message"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateTemplatedWhatsAppMessage") CreateTemplatedWhatsAppMessage

> Send a templated WhatsApp message to a mobile number.


```csharp
Task<List<Standard.Models.TemplatedWhatsappMessageSuccesfullySent>> CreateTemplatedWhatsAppMessage(double xApiVersion, string contentType, Standard.Models.SendATemplatedWhatsAppMessageToAMobileNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"to\": \"<string>\",\r\n  \"messageFields\": [\r\n    {\r\n      \"name\": \"<string>\",\r\n      \"value\": \"<string>\"\r\n    },\r\n    {\r\n      \"name\": \"<string>\",\r\n      \"value\": \"<string>\"\r\n    }\r\n  ],\r\n  \"templateName\": \"<string>\",\r\n  \"templateId\": \"<integer>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendATemplatedWhatsAppMessageToAMobileNumberRequest>(bodyValue);

List<Standard.Models.TemplatedWhatsappMessageSuccesfullySent> result = await communication.CreateTemplatedWhatsAppMessage(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_send_an_image_via_whats_app"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateSendAnImageViaWhatsApp") CreateSendAnImageViaWhatsApp

> Send an image through WhatsApp to a mobile number.


```csharp
Task CreateSendAnImageViaWhatsApp(double xApiVersion, string contentType, Standard.Models.SendAnImageThroughWhatsAppToAMobileNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"to\": \"<string>\",\r\n  \"text\": \"<string>\",\r\n  \"imageUrl\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendAnImageThroughWhatsAppToAMobileNumberRequest>(bodyValue);

await communication.CreateSendAnImageViaWhatsApp(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_send_a_document_via_whats_app"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateSendADocumentViaWhatsApp") CreateSendADocumentViaWhatsApp

> Send a document through WhatsApp to a mobile number.


```csharp
Task CreateSendADocumentViaWhatsApp(double xApiVersion, string contentType, Standard.Models.SendADocumentThroughWhatsAppToAMobileNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\"to\":\"+27827265991\",\"text\":\"Hello World!\",\"fileUrl\":\"http://www.mydocument.com\"}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendADocumentThroughWhatsAppToAMobileNumberRequest>(bodyValue);

await communication.CreateSendADocumentViaWhatsApp(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_send_an_audio_file_via_whats_app"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateSendAnAudioFileViaWhatsApp") CreateSendAnAudioFileViaWhatsApp

> Send an audio file through WhatsApp to a mobile number.


```csharp
Task CreateSendAnAudioFileViaWhatsApp(double xApiVersion, string contentType, Standard.Models.SendAnAudioFileThroughWhatsAppToAMobileNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"to\": \"<string>\",\r\n  \"audioUrl\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendAnAudioFileThroughWhatsAppToAMobileNumberRequest>(bodyValue);

await communication.CreateSendAnAudioFileViaWhatsApp(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_send_an_video_file_via_whats_app"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateSendAnVideoFileViaWhatsApp") CreateSendAnVideoFileViaWhatsApp

> Send an video file through WhatsApp to a mobile number.


```csharp
Task CreateSendAnVideoFileViaWhatsApp(double xApiVersion, string contentType, Standard.Models.SendAnVideoFileThroughWhatsAppToAMobileNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"to\": \"<string>\",\r\n  \"text\": \"<string>\",\r\n  \"videoUrl\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendAnVideoFileThroughWhatsAppToAMobileNumberRequest>(bodyValue);

await communication.CreateSendAnVideoFileViaWhatsApp(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_send_an_sms"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateSendAnSMS") CreateSendAnSMS

> Send an SMS to a mobile number.
> 
> SMS banking solutions can be used in the following ways: 
> - Notify consumers instantly of account transactions
> - Allow customers to monitor their account activity
> - Use one time passwords to reduce fraud and theft
> etc.


```csharp
Task<Standard.Models.SMSSuccesfullySent> CreateSendAnSMS(double xApiVersion, string contentType, Standard.Models.SendAnSMSToAMobileNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"to\": \"<string>\",\r\n  \"body\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendAnSMSToAMobileNumberRequest>(bodyValue);

Standard.Models.SMSSuccesfullySent result = await communication.CreateSendAnSMS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_send_a_templated_sms"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateSendATemplatedSMS") CreateSendATemplatedSMS

> Send a templated SMS to a mobile number.
> 
> Examples of what templated SMS's can be used for:
> 
> - Notifying consumers instantly of account transactions
> - Send payment reminders
> - Effect debt collection


```csharp
Task<List<Standard.Models.TemplatedSMSSuccesfullySent>> CreateSendATemplatedSMS(double xApiVersion, string contentType, Standard.Models.SendATemplatedSMSToAMobileNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"to\": \"<string>\",\r\n  \"messageFields\": [\r\n    {\r\n      \"name\": \"<string>\",\r\n      \"value\": \"<string>\"\r\n    },\r\n    {\r\n      \"name\": \"<string>\",\r\n      \"value\": \"<string>\"\r\n    }\r\n  ],\r\n  \"templateName\": \"<string>\",\r\n  \"templateId\": \"<integer>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendATemplatedSMSToAMobileNumberRequest>(bodyValue);

List<Standard.Models.TemplatedSMSSuccesfullySent> result = await communication.CreateSendATemplatedSMS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_send_a_location_via_whats_app"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.CommunicationController.CreateSendALocationViaWhatsApp") CreateSendALocationViaWhatsApp

> Send a location through WhatsApp to a mobile number.


```csharp
Task CreateSendALocationViaWhatsApp(double xApiVersion, string contentType, Standard.Models.SendALocationThroughWhatsAppToAMobileNumber body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{   \"to\": \"+27827265991\",   \"body\": \"Hello World!\",   \"locationAttributes\": {     \"longitude\": \"15.946519\",     \"latitude\": \"45.793337\",     \"locationName\": \"Name of the location\",     \"address\": \"Address name\"   } }";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SendALocationThroughWhatsAppToAMobileNumber>(bodyValue);

await communication.CreateSendALocationViaWhatsApp(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


[Back to List of Controllers](#list_of_controllers)

## <a name="mandate_controller"></a>![Class: ](https://apidocs.io/img/class.png "BankTechAPI.Tests.Controllers.MandateController") MandateController

### Get singleton instance

The singleton instance of the ``` MandateController ``` class can be accessed from the API Client.

```csharp
MandateController mandate = client.Mandate;
```

### <a name="get_a_single_registered_mandate"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.GetASingleRegisteredMandate") GetASingleRegisteredMandate

> Get a single registered mandate matching the provided mandate ID.


```csharp
Task<Standard.Models.MandateReturned> GetASingleRegisteredMandate(string mandateIdentification, double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mandateIdentification |  ``` Required ```  | (Required) The Mandate Identification whose mandate you would like returned. |
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
string mandateIdentification = "<string>";
double xApiVersion = 1.0;

Standard.Models.MandateReturned result = await mandate.GetASingleRegisteredMandate(mandateIdentification, xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_verify_a_mandates_debtor_bank_account"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateVerifyAMandatesDebtorBankAccount") CreateVerifyAMandatesDebtorBankAccount

> ?? Confusing


```csharp
Task<Standard.Models.MandateBankAccountVerificationStatusSet> CreateVerifyAMandatesDebtorBankAccount(
        string mandateIdentification,
        double xApiVersion,
        string contentType,
        Standard.Models.VerifyAMandatesDebtorBankAccountRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mandateIdentification |  ``` Required ```  | (Required) |
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | Request Parameters |


#### Example Usage

```csharp
string mandateIdentification = "<string>";
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{   \"verificationType\": \"string\",   \"companyRegNo\": \"string\",   \"companyName\": \"string\",   \"idNumber\": 0,   \"initials\": \"string\",   \"surname\": \"string\",   \"bankName\": \"string\",   \"accNumber\": \"string\",   \"accType\": \"string\",   \"yourReference\": \"string\" }";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.VerifyAMandatesDebtorBankAccountRequest>(bodyValue);

Standard.Models.MandateBankAccountVerificationStatusSet result = await mandate.CreateVerifyAMandatesDebtorBankAccount(mandateIdentification, xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_verify_a_mandates_debtor_identification"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateVerifyAMandatesDebtorIdentification") CreateVerifyAMandatesDebtorIdentification

> For a specific mandate (with a specific mandate ID), verify the debtor.


```csharp
Task<Standard.Models.MandateVerificationStatusSet> CreateVerifyAMandatesDebtorIdentification(
        string mandateIdentification,
        double xApiVersion,
        string contentType,
        Standard.Models.VerifyAMandatesDebtorIdentificationRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mandateIdentification |  ``` Required ```  | (Required) |
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string mandateIdentification = "<string>";
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"idNumber\": \"<string>\",\r\n  \"yourReference\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.VerifyAMandatesDebtorIdentificationRequest>(bodyValue);

Standard.Models.MandateVerificationStatusSet result = await mandate.CreateVerifyAMandatesDebtorIdentification(mandateIdentification, xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_a_summary_list_of_registered_mandates_matching_the_provided_parameters"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.GetASummaryListOfRegisteredMandatesMatchingTheProvidedParameters") GetASummaryListOfRegisteredMandatesMatchingTheProvidedParameters

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateListReturned> GetASummaryListOfRegisteredMandatesMatchingTheProvidedParameters(
        string mandateStatus,
        string initiationDateStart,
        string initiationDateEnd,
        string releaseDateStart,
        string releaseDateEnd,
        string collectionFrequency,
        string collectionDay,
        string pageNumber,
        string pageSize,
        double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mandateStatus |  ``` Required ```  | TODO: Add a parameter description |
| initiationDateStart |  ``` Required ```  | TODO: Add a parameter description |
| initiationDateEnd |  ``` Required ```  | TODO: Add a parameter description |
| releaseDateStart |  ``` Required ```  | TODO: Add a parameter description |
| releaseDateEnd |  ``` Required ```  | TODO: Add a parameter description |
| collectionFrequency |  ``` Required ```  | TODO: Add a parameter description |
| collectionDay |  ``` Required ```  | TODO: Add a parameter description |
| pageNumber |  ``` Required ```  | TODO: Add a parameter description |
| pageSize |  ``` Required ```  | TODO: Add a parameter description |
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
string mandateStatus = "<string>";
string initiationDateStart = "<dateTime>";
string initiationDateEnd = "<dateTime>";
string releaseDateStart = "<dateTime>";
string releaseDateEnd = "<dateTime>";
string collectionFrequency = "<string>";
string collectionDay = "<string>";
string pageNumber = "<integer>";
string pageSize = "<integer>";
double xApiVersion = 1.0;

Standard.Models.MandateListReturned result = await mandate.GetASummaryListOfRegisteredMandatesMatchingTheProvidedParameters(mandateStatus, initiationDateStart, initiationDateEnd, releaseDateStart, releaseDateEnd, collectionFrequency, collectionDay, pageNumber, pageSize, xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_a_list_of_collection_dates_matching_the_provided_parameters"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.GetAListOfCollectionDatesMatchingTheProvidedParameters") GetAListOfCollectionDatesMatchingTheProvidedParameters

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionDateSReturned> GetAListOfCollectionDatesMatchingTheProvidedParameters(
        string startDate,
        string endDate,
        string day,
        string frequency,
        string collectionRule,
        double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| startDate |  ``` Required ```  | (Required) The first date you would like to see collection dates for. |
| endDate |  ``` Required ```  | (Required) The last date you would like to see collection dates for. |
| day |  ``` Required ```  | (Required) The numeric representation of the collection day.<b><small>Accepted values:</small></b><ul><li>(1 - 31) - When frequency is MNTH</li></ul><em><small>Represents the day of the month to collect.i.e. "1" for the 1st of the month or "31" for the 31st of the month.</small></em><br /><ul><li>(1 - 6) - When frequency is WEEK</li></ul><em><small>Represents the day of the week to collect.i.e. "1" for monday or "6" for saturday.</small></em><br /><ul><li>(1 - 6, 8 - 13) - When frequency is FRTN</li></ul><em><small>Represents the day of the week to collect.i.e. "1" for the 1st and 3rd monday or "8" for the 2nd and 4th monday.</small></em><br /><ul><li>(1 - 12, 14, 99) - When frequency is ADHO</li></ul><em><small>Represents the ad hoc day of the month to collect.i.e."1" for the last monday of the month"6" for the last saturday of the month"7" for the first monday of the month"12" for the first saturday of the month"14" for the second last day of the month"99" for the last day of the month.</small></em> |
| frequency |  ``` Required ```  | (Required) The regularity of the desired collections.<b><small>Accepted values:</small></b><ul><li>WEEK - Weekly</li><li>FRTN - Fortnightly</li><li>MNTH - Monthly</li><li>QURT - Quarterly</li><li>YEAR - Yearly</li><li>ADHO - Ad hoc</li></ul> |
| collectionRule |  ``` Required ```  | (Required) The collection rule to apply on non-processing days.
<b><small>Accepted values:</small></b><ul><li>FRWD - Fowards rule</li><li>BKWD - Backwards rule</li></ul> |
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
string startDate = "<date>";
string endDate = "<date>";
string day = "<integer>";
string frequency = "<string>";
string collectionRule = "<string>";
double xApiVersion = 1.0;

Standard.Models.CollectionDateSReturned result = await mandate.GetAListOfCollectionDatesMatchingTheProvidedParameters(startDate, endDate, day, frequency, collectionRule, xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_a_single_mandate_collection_matching_the_provided_parameters"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.GetASingleMandateCollectionMatchingTheProvidedParameters") GetASingleMandateCollectionMatchingTheProvidedParameters

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateCollectionReturned> GetASingleMandateCollectionMatchingTheProvidedParameters(string collectionIdentification, double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| collectionIdentification |  ``` Required ```  | (Required) The parameters. |
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
string collectionIdentification = "<string>";
double xApiVersion = 1.0;

Standard.Models.MandateCollectionReturned result = await mandate.GetASingleMandateCollectionMatchingTheProvidedParameters(collectionIdentification, xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_a_list_of_mandate_collections_matching_the_provided_parameters"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.GetAListOfMandateCollectionsMatchingTheProvidedParameters") GetAListOfMandateCollectionsMatchingTheProvidedParameters

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateCollectionListReturned> GetAListOfMandateCollectionsMatchingTheProvidedParameters(
        string mandateIdentification,
        string startDate,
        string endDate,
        string pageNumber,
        string pageSize,
        double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mandateIdentification |  ``` Required ```  | (Required) The unique mandate identifier assigned by the creditor. |
| startDate |  ``` Required ```  | The first date you would like to see collection dates for. |
| endDate |  ``` Required ```  | The last date you would like to see collection dates for. |
| pageNumber |  ``` Required ```  | TODO: Add a parameter description |
| pageSize |  ``` Required ```  | TODO: Add a parameter description |
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
string mandateIdentification = "<string>";
string startDate = "<date>";
string endDate = "<date>";
string pageNumber = "<integer>";
string pageSize = "<integer>";
double xApiVersion = 1.0;

Standard.Models.MandateCollectionListReturned result = await mandate.GetAListOfMandateCollectionsMatchingTheProvidedParameters(mandateIdentification, startDate, endDate, pageNumber, pageSize, xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_get_a_list_of_mandate_collections_matching_the_provided_parameters"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateGetAListOfMandateCollectionsMatchingTheProvidedParameters") CreateGetAListOfMandateCollectionsMatchingTheProvidedParameters

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateCollectionListReturned1> CreateGetAListOfMandateCollectionsMatchingTheProvidedParameters(
        string startDate,
        string endDate,
        string pageNumber,
        string pageSize,
        double xApiVersion,
        string contentType,
        List<Standard.Models.GetAListOfMandateCollectionsMatchingTheProvidedParametersRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| startDate |  ``` Required ```  | The first date you would like to see collection dates for. |
| endDate |  ``` Required ```  | The last date you would like to see collection dates for. |
| pageNumber |  ``` Required ```  | TODO: Add a parameter description |
| pageSize |  ``` Required ```  | TODO: Add a parameter description |
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string startDate = "<date>";
string endDate = "<date>";
string pageNumber = "<integer>";
string pageSize = "<integer>";
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.GetAListOfMandateCollectionsMatchingTheProvidedParametersRequest>>(bodyValue);

Standard.Models.MandateCollectionListReturned1 result = await mandate.CreateGetAListOfMandateCollectionsMatchingTheProvidedParameters(startDate, endDate, pageNumber, pageSize, xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_a_list_of_mandate_collection_results_matching_the_provided_parameters"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.GetAListOfMandateCollectionResultsMatchingTheProvidedParameters") GetAListOfMandateCollectionResultsMatchingTheProvidedParameters

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionResultSReturned> GetAListOfMandateCollectionResultsMatchingTheProvidedParameters(
        string forDateStart,
        string forDateEnd,
        string actionDateStart,
        string actionDateEnd,
        string resultDateStart,
        string resultDateEnd,
        string submissionDateStart,
        string submissionDateEnd,
        string resultLastUpdatedOnStart,
        string resultLastUpdatedOnEnd,
        string instrument,
        string clientSegment,
        string includePending,
        string pageNumber,
        string pageSize,
        double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| forDateStart |  ``` Required ```  | TODO: Add a parameter description |
| forDateEnd |  ``` Required ```  | TODO: Add a parameter description |
| actionDateStart |  ``` Required ```  | TODO: Add a parameter description |
| actionDateEnd |  ``` Required ```  | TODO: Add a parameter description |
| resultDateStart |  ``` Required ```  | TODO: Add a parameter description |
| resultDateEnd |  ``` Required ```  | TODO: Add a parameter description |
| submissionDateStart |  ``` Required ```  | TODO: Add a parameter description |
| submissionDateEnd |  ``` Required ```  | TODO: Add a parameter description |
| resultLastUpdatedOnStart |  ``` Required ```  | TODO: Add a parameter description |
| resultLastUpdatedOnEnd |  ``` Required ```  | TODO: Add a parameter description |
| instrument |  ``` Required ```  | TODO: Add a parameter description |
| clientSegment |  ``` Required ```  | TODO: Add a parameter description |
| includePending |  ``` Required ```  | TODO: Add a parameter description |
| pageNumber |  ``` Required ```  | TODO: Add a parameter description |
| pageSize |  ``` Required ```  | TODO: Add a parameter description |
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
string forDateStart = "<dateTime>";
string forDateEnd = "<dateTime>";
string actionDateStart = "<dateTime>";
string actionDateEnd = "<dateTime>";
string resultDateStart = "<dateTime>";
string resultDateEnd = "<dateTime>";
string submissionDateStart = "<dateTime>";
string submissionDateEnd = "<dateTime>";
string resultLastUpdatedOnStart = "<dateTime>";
string resultLastUpdatedOnEnd = "<dateTime>";
string instrument = "<string>";
string clientSegment = "<string>";
string includePending = "<boolean>";
string pageNumber = "<integer>";
string pageSize = "<integer>";
double xApiVersion = 1.0;

Standard.Models.CollectionResultSReturned result = await mandate.GetAListOfMandateCollectionResultsMatchingTheProvidedParameters(forDateStart, forDateEnd, actionDateStart, actionDateEnd, resultDateStart, resultDateEnd, submissionDateStart, submissionDateEnd, resultLastUpdatedOnStart, resultLastUpdatedOnEnd, instrument, clientSegment, includePending, pageNumber, pageSize, xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_register_new_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateRegisterNewMandateS") CreateRegisterNewMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateSRegistered> CreateRegisterNewMandateS(double xApiVersion, string contentType, List<Standard.Models.RegisterNewMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"collectionDay\": \"<string>\",\r\n    \"collectionType\": \"<string>\",\r\n    \"currency\": \"<string>\",\r\n    \"dateAdjustmentAllowed\": \"<boolean>\",\r\n    \"debitValueType\": \"<string>\",\r\n    \"entryClass\": \"<string>\",\r\n    \"initiationDate\": \"<date>\",\r\n    \"instalmentAmount\": \"<double>\",\r\n    \"instalmentOccurrence\": \"<string>\",\r\n    \"trackingAllowed\": \"<boolean>\",\r\n    \"useAmountAdjustment\": \"<boolean>\",\r\n    \"useRateAdjustment\": \"<boolean>\",\r\n    \"debtor\": {\r\n      \"name\": \"occa\",\r\n      \"accountNumber\": \"\",\r\n      \"accountType\": \"e\",\r\n      \"branchCode\": \"non\",\r\n      \"email\": \"c\",\r\n      \"phoneNumber\": \"de\",\r\n      \"identification\": \"dol\",\r\n      \"identificationType\": \"\"\r\n    },\r\n    \"creditor\": {\r\n      \"accountNumber\": \"eni\",\r\n      \"accountName\": \"lab\",\r\n      \"branchCode\": \"\",\r\n      \"email\": \"lab\",\r\n      \"phoneNumber\": \"con\",\r\n      \"schemeName\": \"cons\",\r\n      \"shortName\": \"m\",\r\n      \"ultimateName\": \"fugi\"\r\n    },\r\n    \"adjustmentAmount\": \"<double>\",\r\n    \"adjustmentCategory\": \"<string>\",\r\n    \"adjustmentRate\": \"<double>\",\r\n    \"authenticationCode\": \"<string>\",\r\n    \"authenticationDate\": \"<date>\",\r\n    \"authenticationInstrument\": \"<string>\",\r\n    \"authenticationType\": \"<string>\",\r\n    \"clientContractReference\": \"<string>\",\r\n    \"clientRequestReference\": \"<string>\",\r\n    \"collectionFrequency\": \"<string>\",\r\n    \"firstCollectionIdentifier\": \"<string>\",\r\n    \"firstCollectionDate\": \"<date>\",\r\n    \"firstCollectionAmount\": \"<double>\",\r\n    \"firstCollectionCurrency\": \"<string>\",\r\n    \"debiCheckAuthKey\": \"<string>\",\r\n    \"clientSegment\": \"<string>\",\r\n    \"trackingDays\": \"<integer>\",\r\n    \"releaseDate\": \"<date>\",\r\n    \"maxCollectionCurrency\": \"<string>\",\r\n    \"idVerificationStatus\": \"<string>\",\r\n    \"bankAccountVerificationStatus\": \"<string>\",\r\n    \"maxCollectionAmount\": \"<double>\",\r\n    \"optiCollectMandate\": {\r\n      \"contract\": {\r\n        \"contractNo\": \"eius\",\r\n        \"contractStatus\": \"e\",\r\n        \"statusDate\": \"enim nulla culpa ut ullamco\",\r\n        \"contractStartDate\": \"ullamco adipisicing\",\r\n        \"contractEndDate\": \"fugiat esse aliqua Ut\",\r\n        \"salesTeam\": \"Dui\",\r\n        \"salesPerson\": \"e\",\r\n        \"customer\": {\r\n          \"title\": \"\",\r\n          \"firstName\": \"e\",\r\n          \"surname\": \"\",\r\n          \"nationality\": \"null\",\r\n          \"identification\": \"si\",\r\n          \"gender\": \"ad\",\r\n          \"birthDate\": \"ad\",\r\n          \"language\": \"la\",\r\n          \"country\": \"i\",\r\n          \"city\": \"no\",\r\n          \"town\": \"d\",\r\n          \"suburb\": \"s\",\r\n          \"postalCode\": \"et \",\r\n          \"mobile\": \"dolo\",\r\n          \"workTel\": \"r\",\r\n          \"payday\": \"ani\",\r\n          \"incomeFrequency\": \"des\",\r\n          \"netSalary\": 31880210.751289979,\r\n          \"province\": \"\",\r\n          \"riskMapping\": \"ut \",\r\n          \"employerName\": \"ve\",\r\n          \"jobTitle\": \"u\",\r\n          \"employmentType\": \"sint\"\r\n        },\r\n        \"product\": {\r\n          \"productCode\": \"d\",\r\n          \"productDescription\": \"ad\",\r\n          \"businessLine\": \"sit\"\r\n        }\r\n      }\r\n    }\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"collectionDay\": \"<string>\",\r\n    \"collectionType\": \"<string>\",\r\n    \"currency\": \"<string>\",\r\n    \"dateAdjustmentAllowed\": \"<boolean>\",\r\n    \"debitValueType\": \"<string>\",\r\n    \"entryClass\": \"<string>\",\r\n    \"initiationDate\": \"<date>\",\r\n    \"instalmentAmount\": \"<double>\",\r\n    \"instalmentOccurrence\": \"<string>\",\r\n    \"trackingAllowed\": \"<boolean>\",\r\n    \"useAmountAdjustment\": \"<boolean>\",\r\n    \"useRateAdjustment\": \"<boolean>\",\r\n    \"debtor\": {\r\n      \"name\": \"dese\",\r\n      \"accountNumber\": \"a\",\r\n      \"accountType\": \"d\",\r\n      \"branchCode\": \"\",\r\n      \"email\": \"Ut e\",\r\n      \"phoneNumber\": \"ad\",\r\n      \"identification\": \"ad \",\r\n      \"identificationType\": \"a\"\r\n    },\r\n    \"creditor\": {\r\n      \"accountNumber\": \"ve\",\r\n      \"accountName\": \"\",\r\n      \"branchCode\": \"fug\",\r\n      \"email\": \"mi\",\r\n      \"phoneNumber\": \"in\",\r\n      \"schemeName\": \"labo\",\r\n      \"shortName\": \"elit\",\r\n      \"ultimateName\": \"iru\"\r\n    },\r\n    \"adjustmentAmount\": \"<double>\",\r\n    \"adjustmentCategory\": \"<string>\",\r\n    \"adjustmentRate\": \"<double>\",\r\n    \"authenticationCode\": \"<string>\",\r\n    \"authenticationDate\": \"<date>\",\r\n    \"authenticationInstrument\": \"<string>\",\r\n    \"authenticationType\": \"<string>\",\r\n    \"clientContractReference\": \"<string>\",\r\n    \"clientRequestReference\": \"<string>\",\r\n    \"collectionFrequency\": \"<string>\",\r\n    \"firstCollectionIdentifier\": \"<string>\",\r\n    \"firstCollectionDate\": \"<date>\",\r\n    \"firstCollectionAmount\": \"<double>\",\r\n    \"firstCollectionCurrency\": \"<string>\",\r\n    \"debiCheckAuthKey\": \"<string>\",\r\n    \"clientSegment\": \"<string>\",\r\n    \"trackingDays\": \"<integer>\",\r\n    \"releaseDate\": \"<date>\",\r\n    \"maxCollectionCurrency\": \"<string>\",\r\n    \"idVerificationStatus\": \"<string>\",\r\n    \"bankAccountVerificationStatus\": \"<string>\",\r\n    \"maxCollectionAmount\": \"<double>\",\r\n    \"optiCollectMandate\": {\r\n      \"contract\": {\r\n        \"contractNo\": \"l\",\r\n        \"contractStatus\": \"u\",\r\n        \"statusDate\": \"velit\",\r\n        \"contractStartDate\": \"sunt nostrud occaecat ipsum\",\r\n        \"contractEndDate\": \"consectetur commodo\",\r\n        \"salesTeam\": \"eni\",\r\n        \"salesPerson\": \"e\",\r\n        \"customer\": {\r\n          \"title\": \"v\",\r\n          \"firstName\": \"sin\",\r\n          \"surname\": \"mini\",\r\n          \"nationality\": \"oc\",\r\n          \"identification\": \"\",\r\n          \"gender\": \"co\",\r\n          \"birthDate\": \"et quis est\",\r\n          \"language\": \"\",\r\n          \"country\": \"vol\",\r\n          \"city\": \"cu\",\r\n          \"town\": \"r\",\r\n          \"suburb\": \"moll\",\r\n          \"postalCode\": \"dolo\",\r\n          \"mobile\": \"a\",\r\n          \"workTel\": \"eni\",\r\n          \"payday\": \"\",\r\n          \"incomeFrequency\": \"oc\",\r\n          \"netSalary\": -32621753.51843828,\r\n          \"province\": \"pa\",\r\n          \"riskMapping\": \"dolo\",\r\n          \"employerName\": \"\",\r\n          \"jobTitle\": \"Lo\",\r\n          \"employmentType\": \"la\"\r\n        },\r\n        \"product\": {\r\n          \"productCode\": \"\",\r\n          \"productDescription\": \"D\",\r\n          \"businessLine\": \"nu\"\r\n        }\r\n      }\r\n    }\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.RegisterNewMandateSRequest>>(bodyValue);

Standard.Models.MandateSRegistered result = await mandate.CreateRegisterNewMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="update_amend_registered_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.UpdateAmendRegisteredMandateS") UpdateAmendRegisteredMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateSAmended> UpdateAmendRegisteredMandateS(double xApiVersion, string contentType, List<Standard.Models.AmendRegisteredMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"amendmentReasonCode\": \"<string>\",\r\n    \"adjustmentAmount\": \"<double>\",\r\n    \"adjustmentCategory\": \"<string>\",\r\n    \"adjustmentRate\": \"<double>\",\r\n    \"authenticationCode\": \"<string>\",\r\n    \"authenticationDate\": \"<date>\",\r\n    \"authenticationInstrument\": \"<string>\",\r\n    \"authenticationType\": \"<string>\",\r\n    \"clientContractReference\": \"<string>\",\r\n    \"clientRequestReference\": \"<string>\",\r\n    \"collectionFrequency\": \"<string>\",\r\n    \"collectionDay\": \"<string>\",\r\n    \"collectionType\": \"<string>\",\r\n    \"currency\": \"<string>\",\r\n    \"dateAdjustmentAllowed\": \"<boolean>\",\r\n    \"debitValueType\": \"<string>\",\r\n    \"entryClass\": \"<string>\",\r\n    \"firstCollectionIdentifier\": \"<string>\",\r\n    \"firstCollectionDate\": \"<date>\",\r\n    \"firstCollectionAmount\": \"<double>\",\r\n    \"firstCollectionCurrency\": \"<string>\",\r\n    \"initiationDate\": \"<date>\",\r\n    \"instalmentAmount\": \"<double>\",\r\n    \"instalmentOccurrence\": \"<string>\",\r\n    \"debiCheckAuthKey\": \"<string>\",\r\n    \"clientSegment\": \"<string>\",\r\n    \"trackingAllowed\": \"<boolean>\",\r\n    \"trackingDays\": \"<integer>\",\r\n    \"useAmountAdjustment\": \"<boolean>\",\r\n    \"useRateAdjustment\": \"<boolean>\",\r\n    \"releaseDate\": \"<date>\",\r\n    \"maxCollectionCurrency\": \"<string>\",\r\n    \"idVerificationStatus\": \"<string>\",\r\n    \"bankAccountVerificationStatus\": \"<string>\",\r\n    \"maxCollectionAmount\": \"<double>\",\r\n    \"debtor\": {\r\n      \"name\": \"Lore\",\r\n      \"accountNumber\": \"ve\",\r\n      \"accountType\": \"d\",\r\n      \"branchCode\": \"co\",\r\n      \"email\": \"dolo\",\r\n      \"phoneNumber\": \"\",\r\n      \"identification\": \"min\",\r\n      \"identificationType\": \"r\"\r\n    },\r\n    \"creditor\": {\r\n      \"accountNumber\": \"\",\r\n      \"accountName\": \"no\",\r\n      \"branchCode\": \"sit\",\r\n      \"email\": \"ad\",\r\n      \"phoneNumber\": \"\",\r\n      \"schemeName\": \"m\",\r\n      \"shortName\": \"eu\",\r\n      \"ultimateName\": \"la\"\r\n    },\r\n    \"optiCollectMandate\": {\r\n      \"contract\": {\r\n        \"contractNo\": \"Exc\",\r\n        \"contractStatus\": \"of\",\r\n        \"statusDate\": \"commodo Excepteur\",\r\n        \"contractStartDate\": \"elit ut dolor sint\",\r\n        \"contractEndDate\": \"et velit\",\r\n        \"salesTeam\": \"de\",\r\n        \"salesPerson\": \"U\",\r\n        \"customer\": {\r\n          \"title\": \"do\",\r\n          \"firstName\": \"la\",\r\n          \"surname\": \"\",\r\n          \"nationality\": \"non\",\r\n          \"identification\": \"co\",\r\n          \"gender\": \"\",\r\n          \"birthDate\": \"in laborum\",\r\n          \"language\": \"sit\",\r\n          \"country\": \"an\",\r\n          \"city\": \"an\",\r\n          \"town\": \"aut\",\r\n          \"suburb\": \"anim\",\r\n          \"postalCode\": \"do c\",\r\n          \"mobile\": \"\",\r\n          \"workTel\": \"inc\",\r\n          \"payday\": \"dol\",\r\n          \"incomeFrequency\": \"ve\",\r\n          \"netSalary\": -34013197.13398996,\r\n          \"province\": \"aliq\",\r\n          \"riskMapping\": \"et\",\r\n          \"employerName\": \"eni\",\r\n          \"jobTitle\": \"ulla\",\r\n          \"employmentType\": \"m\"\r\n        },\r\n        \"product\": {\r\n          \"productCode\": \"la\",\r\n          \"productDescription\": \"m\",\r\n          \"businessLine\": \"id\"\r\n        }\r\n      }\r\n    }\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"amendmentReasonCode\": \"<string>\",\r\n    \"adjustmentAmount\": \"<double>\",\r\n    \"adjustmentCategory\": \"<string>\",\r\n    \"adjustmentRate\": \"<double>\",\r\n    \"authenticationCode\": \"<string>\",\r\n    \"authenticationDate\": \"<date>\",\r\n    \"authenticationInstrument\": \"<string>\",\r\n    \"authenticationType\": \"<string>\",\r\n    \"clientContractReference\": \"<string>\",\r\n    \"clientRequestReference\": \"<string>\",\r\n    \"collectionFrequency\": \"<string>\",\r\n    \"collectionDay\": \"<string>\",\r\n    \"collectionType\": \"<string>\",\r\n    \"currency\": \"<string>\",\r\n    \"dateAdjustmentAllowed\": \"<boolean>\",\r\n    \"debitValueType\": \"<string>\",\r\n    \"entryClass\": \"<string>\",\r\n    \"firstCollectionIdentifier\": \"<string>\",\r\n    \"firstCollectionDate\": \"<date>\",\r\n    \"firstCollectionAmount\": \"<double>\",\r\n    \"firstCollectionCurrency\": \"<string>\",\r\n    \"initiationDate\": \"<date>\",\r\n    \"instalmentAmount\": \"<double>\",\r\n    \"instalmentOccurrence\": \"<string>\",\r\n    \"debiCheckAuthKey\": \"<string>\",\r\n    \"clientSegment\": \"<string>\",\r\n    \"trackingAllowed\": \"<boolean>\",\r\n    \"trackingDays\": \"<integer>\",\r\n    \"useAmountAdjustment\": \"<boolean>\",\r\n    \"useRateAdjustment\": \"<boolean>\",\r\n    \"releaseDate\": \"<date>\",\r\n    \"maxCollectionCurrency\": \"<string>\",\r\n    \"idVerificationStatus\": \"<string>\",\r\n    \"bankAccountVerificationStatus\": \"<string>\",\r\n    \"maxCollectionAmount\": \"<double>\",\r\n    \"debtor\": {\r\n      \"name\": \"dolo\",\r\n      \"accountNumber\": \"\",\r\n      \"accountType\": \"t\",\r\n      \"branchCode\": \"co\",\r\n      \"email\": \"ip\",\r\n      \"phoneNumber\": \"e\",\r\n      \"identification\": \"al\",\r\n      \"identificationType\": \"ex\"\r\n    },\r\n    \"creditor\": {\r\n      \"accountNumber\": \"ei\",\r\n      \"accountName\": \"si\",\r\n      \"branchCode\": \"r\",\r\n      \"email\": \"c\",\r\n      \"phoneNumber\": \"vo\",\r\n      \"schemeName\": \"Dui\",\r\n      \"shortName\": \"sit \",\r\n      \"ultimateName\": \"mi\"\r\n    },\r\n    \"optiCollectMandate\": {\r\n      \"contract\": {\r\n        \"contractNo\": \"in\",\r\n        \"contractStatus\": \"do\",\r\n        \"statusDate\": \"reprehenderit pariatur\",\r\n        \"contractStartDate\": \"et esse occaec\",\r\n        \"contractEndDate\": \"dolor incididunt irure Excepteur\",\r\n        \"salesTeam\": \"\",\r\n        \"salesPerson\": \"e\",\r\n        \"customer\": {\r\n          \"title\": \"es\",\r\n          \"firstName\": \"\",\r\n          \"surname\": \"d\",\r\n          \"nationality\": \"eiu\",\r\n          \"identification\": \"m\",\r\n          \"gender\": \"lab\",\r\n          \"birthDate\": \"aliquip incididunt in cupidatat\",\r\n          \"language\": \"ipsu\",\r\n          \"country\": \"Ut d\",\r\n          \"city\": \"al\",\r\n          \"town\": \"l\",\r\n          \"suburb\": \"o\",\r\n          \"postalCode\": \"ip\",\r\n          \"mobile\": \"ull\",\r\n          \"workTel\": \"d\",\r\n          \"payday\": \"Lore\",\r\n          \"incomeFrequency\": \"a\",\r\n          \"netSalary\": 37918281.510315448,\r\n          \"province\": \"esse\",\r\n          \"riskMapping\": \"el\",\r\n          \"employerName\": \"al\",\r\n          \"jobTitle\": \"\",\r\n          \"employmentType\": \"Lor\"\r\n        },\r\n        \"product\": {\r\n          \"productCode\": \"Exce\",\r\n          \"productDescription\": \"pari\",\r\n          \"businessLine\": \"oc\"\r\n        }\r\n      }\r\n    }\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.AmendRegisteredMandateSRequest>>(bodyValue);

Standard.Models.MandateSAmended result = await mandate.UpdateAmendRegisteredMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_cancel_registered_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateCancelRegisteredMandateS") CreateCancelRegisteredMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateSCancelled> CreateCancelRegisteredMandateS(double xApiVersion, string contentType, List<Standard.Models.CancelRegisteredMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"cancellationReasonCode\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"cancellationReasonCode\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.CancelRegisteredMandateSRequest>>(bodyValue);

Standard.Models.MandateSCancelled result = await mandate.CreateCancelRegisteredMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="update_pause_registered_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.UpdatePauseRegisteredMandateS") UpdatePauseRegisteredMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateSuccessfullyPaused> UpdatePauseRegisteredMandateS(double xApiVersion, string contentType, List<Standard.Models.PauseRegisteredMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.PauseRegisteredMandateSRequest>>(bodyValue);

Standard.Models.MandateSuccessfullyPaused result = await mandate.UpdatePauseRegisteredMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="update_resume_registered_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.UpdateResumeRegisteredMandateS") UpdateResumeRegisteredMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateSuccessfullyResumed> UpdateResumeRegisteredMandateS(double xApiVersion, string contentType, List<Standard.Models.ResumeRegisteredMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.ResumeRegisteredMandateSRequest>>(bodyValue);

Standard.Models.MandateSuccessfullyResumed result = await mandate.UpdateResumeRegisteredMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="update_lapse_registered_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.UpdateLapseRegisteredMandateS") UpdateLapseRegisteredMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateSuccessfullyLapsed> UpdateLapseRegisteredMandateS(double xApiVersion, string contentType, List<Standard.Models.LapseRegisteredMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.LapseRegisteredMandateSRequest>>(bodyValue);

Standard.Models.MandateSuccessfullyLapsed result = await mandate.UpdateLapseRegisteredMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="update_suspend_registered_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.UpdateSuspendRegisteredMandateS") UpdateSuspendRegisteredMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.MandateSuccessfullySuspended> UpdateSuspendRegisteredMandateS(double xApiVersion, string contentType, List<Standard.Models.SuspendRegisteredMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.SuspendRegisteredMandateSRequest>>(bodyValue);

Standard.Models.MandateSuccessfullySuspended result = await mandate.UpdateSuspendRegisteredMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="add_additional_data_to_registered_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.AddAdditionalDataToRegisteredMandateS") AddAdditionalDataToRegisteredMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.AdditionalDataSuccessfullyAdded> AddAdditionalDataToRegisteredMandateS(double xApiVersion, string contentType, List<Standard.Models.AddAdditionalDataToRegisteredMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"additionalData\": [\r\n      {\r\n        \"fieldName\": \"anim Lorem\",\r\n        \"value\": \"aute\",\r\n        \"dataType\": \"Bool\"\r\n      },\r\n      {\r\n        \"fieldName\": \"sint dolore minim tempor\",\r\n        \"value\": \"officia veniam ea\",\r\n        \"dataType\": \"Number\"\r\n      }\r\n    ]\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"additionalData\": [\r\n      {\r\n        \"fieldName\": \"anim amet nulla\",\r\n        \"value\": \"Lorem irure\",\r\n        \"dataType\": \"Text\"\r\n      },\r\n      {\r\n        \"fieldName\": \"ullamco eiusmod\",\r\n        \"value\": \"cupidatat Excepteur\",\r\n        \"dataType\": \"Text\"\r\n      }\r\n    ]\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.AddAdditionalDataToRegisteredMandateSRequest>>(bodyValue);

Standard.Models.AdditionalDataSuccessfullyAdded result = await mandate.AddAdditionalDataToRegisteredMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="update_additional_data_of_registered_mandate_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.UpdateAdditionalDataOfRegisteredMandateS") UpdateAdditionalDataOfRegisteredMandateS

> TODO: Add a method description


```csharp
Task<Standard.Models.AdditionalDataSuccessfullyUpdated> UpdateAdditionalDataOfRegisteredMandateS(double xApiVersion, string contentType, List<Standard.Models.UpdateAdditionalDataOfRegisteredMandateSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"additionalData\": [\r\n      {\r\n        \"fieldName\": \"ut minim\",\r\n        \"value\": \"eiusmod est Lorem\",\r\n        \"dataType\": \"Text\"\r\n      },\r\n      {\r\n        \"fieldName\": \"voluptate dolore ullamco qui\",\r\n        \"value\": \"elit consequat nostrud\",\r\n        \"dataType\": \"Text\"\r\n      }\r\n    ]\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"additionalData\": [\r\n      {\r\n        \"fieldName\": \"fugiat sunt\",\r\n        \"value\": \"laborum occaecat labore voluptate in\",\r\n        \"dataType\": \"Text\"\r\n      },\r\n      {\r\n        \"fieldName\": \"commodo et amet voluptate\",\r\n        \"value\": \"esse consectetur qui enim\",\r\n        \"dataType\": \"Date\"\r\n      }\r\n    ]\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.UpdateAdditionalDataOfRegisteredMandateSRequest>>(bodyValue);

Standard.Models.AdditionalDataSuccessfullyUpdated result = await mandate.UpdateAdditionalDataOfRegisteredMandateS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_new_mandate_collection_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateNewMandateCollectionS") CreateNewMandateCollectionS

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionSCreated> CreateNewMandateCollectionS(double xApiVersion, string contentType, List<Standard.Models.CreateNewMandateCollectionSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"forDate\": \"<date>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"amount\": \"<double>\",\r\n    \"clientSegment\": \"<string>\",\r\n    \"currency\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"forDate\": \"<date>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"amount\": \"<double>\",\r\n    \"clientSegment\": \"<string>\",\r\n    \"currency\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.CreateNewMandateCollectionSRequest>>(bodyValue);

Standard.Models.CollectionSCreated result = await mandate.CreateNewMandateCollectionS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="update_amend_created_mandate_collection_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.UpdateAmendCreatedMandateCollectionS") UpdateAmendCreatedMandateCollectionS

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionSAmended> UpdateAmendCreatedMandateCollectionS(double xApiVersion, string contentType, List<Standard.Models.AmendCreatedMandateCollectionSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"collectionIdentification\": \"<string>\",\r\n    \"preferredCreditorAccount\": \"<string>\",\r\n    \"clientSegment\": \"<string>\",\r\n    \"currency\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"amount\": \"<double>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"collectionIdentification\": \"<string>\",\r\n    \"preferredCreditorAccount\": \"<string>\",\r\n    \"clientSegment\": \"<string>\",\r\n    \"currency\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"amount\": \"<double>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.AmendCreatedMandateCollectionSRequest>>(bodyValue);

Standard.Models.CollectionSAmended result = await mandate.UpdateAmendCreatedMandateCollectionS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_recall_created_mandate_collection_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateRecallCreatedMandateCollectionS") CreateRecallCreatedMandateCollectionS

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionSRecalled> CreateRecallCreatedMandateCollectionS(double xApiVersion, string contentType, List<Standard.Models.RecallCreatedMandateCollectionSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"collectionIdentification\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"collectionIdentification\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.RecallCreatedMandateCollectionSRequest>>(bodyValue);

Standard.Models.CollectionSRecalled result = await mandate.CreateRecallCreatedMandateCollectionS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_the_debi_check_authentication_status_of_a_mandate"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.GetTheDebiCheckAuthenticationStatusOfAMandate") GetTheDebiCheckAuthenticationStatusOfAMandate

> TODO: Add a method description


```csharp
Task<Standard.Models.DebicheckAuthenticationStatusReturned> GetTheDebiCheckAuthenticationStatusOfAMandate(string authReference, double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| authReference |  ``` Required ```  | (Required) The authentication reference. |
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
string authReference = "<string>";
double xApiVersion = 1.0;

Standard.Models.DebicheckAuthenticationStatusReturned result = await mandate.GetTheDebiCheckAuthenticationStatusOfAMandate(authReference, xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_request_debi_check_authentication_on_a_registered_mandate"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateRequestDebiCheckAuthenticationOnARegisteredMandate") CreateRequestDebiCheckAuthenticationOnARegisteredMandate

> TODO: Add a method description


```csharp
Task<Standard.Models.DebicheckAuthenticationRequestProcessing> CreateRequestDebiCheckAuthenticationOnARegisteredMandate(double xApiVersion, string contentType, Standard.Models.RequestDebiCheckAuthenticationOnARegisteredMandateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"mandateIdentification\": \"<string>\",\r\n  \"bank\": \"<string>\",\r\n  \"authenticationInstrument\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.RequestDebiCheckAuthenticationOnARegisteredMandateRequest>(bodyValue);

Standard.Models.DebicheckAuthenticationRequestProcessing result = await mandate.CreateRequestDebiCheckAuthenticationOnARegisteredMandate(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_request_debi_check_amendment_on_a_registered_mandate"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateRequestDebiCheckAmendmentOnARegisteredMandate") CreateRequestDebiCheckAmendmentOnARegisteredMandate

> TODO: Add a method description


```csharp
Task<Standard.Models.DebicheckAuthenticationAmendRequestProcessing> CreateRequestDebiCheckAmendmentOnARegisteredMandate(double xApiVersion, string contentType, Standard.Models.RequestDebiCheckAmendmentOnARegisteredMandateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"mandateIdentification\": \"<string>\",\r\n  \"bank\": \"<string>\",\r\n  \"authenticationInstrument\": \"<string>\",\r\n  \"amendmentReasonCode\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.RequestDebiCheckAmendmentOnARegisteredMandateRequest>(bodyValue);

Standard.Models.DebicheckAuthenticationAmendRequestProcessing result = await mandate.CreateRequestDebiCheckAmendmentOnARegisteredMandate(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_request_debi_check_cancellation_on_a_registered_mandate"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateRequestDebiCheckCancellationOnARegisteredMandate") CreateRequestDebiCheckCancellationOnARegisteredMandate

> TODO: Add a method description


```csharp
Task<Standard.Models.DebicheckAuthenticationCancelRequestProcessing> CreateRequestDebiCheckCancellationOnARegisteredMandate(double xApiVersion, string contentType, Standard.Models.RequestDebiCheckCancellationOnARegisteredMandateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"mandateIdentification\": \"<string>\",\r\n  \"bank\": \"<string>\",\r\n  \"cancellationReasonCode\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.RequestDebiCheckCancellationOnARegisteredMandateRequest>(bodyValue);

Standard.Models.DebicheckAuthenticationCancelRequestProcessing result = await mandate.CreateRequestDebiCheckCancellationOnARegisteredMandate(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_request_debi_check_authentication_on_a_mandate"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateRequestDebiCheckAuthenticationOnAMandate") CreateRequestDebiCheckAuthenticationOnAMandate

> TODO: Add a method description


```csharp
Task<Standard.Models.DebicheckAuthenticationRequestProcessing> CreateRequestDebiCheckAuthenticationOnAMandate(double xApiVersion, string contentType, Standard.Models.RequestDebiCheckAuthenticationOnAMandateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"bank\": \"<string>\",\r\n  \"maxCollectionCurrency\": \"<string>\",\r\n  \"maxCollectionAmount\": \"<double>\",\r\n  \"mandateIdentification\": \"<string>\",\r\n  \"adjustmentAmount\": \"<double>\",\r\n  \"adjustmentCategory\": \"<string>\",\r\n  \"adjustmentRate\": \"<double>\",\r\n  \"authenticationCode\": \"<string>\",\r\n  \"authenticationDate\": \"<date>\",\r\n  \"authenticationInstrument\": \"<string>\",\r\n  \"authenticationType\": \"<string>\",\r\n  \"clientContractReference\": \"<string>\",\r\n  \"clientRequestReference\": \"<string>\",\r\n  \"collectionFrequency\": \"<string>\",\r\n  \"collectionDay\": \"<string>\",\r\n  \"collectionType\": \"<string>\",\r\n  \"currency\": \"<string>\",\r\n  \"dateAdjustmentAllowed\": \"<boolean>\",\r\n  \"debitValueType\": \"<string>\",\r\n  \"entryClass\": \"<string>\",\r\n  \"firstCollectionIdentifier\": \"<string>\",\r\n  \"firstCollectionDate\": \"<date>\",\r\n  \"firstCollectionAmount\": \"<double>\",\r\n  \"firstCollectionCurrency\": \"<string>\",\r\n  \"initiationDate\": \"<date>\",\r\n  \"instalmentAmount\": \"<double>\",\r\n  \"instalmentOccurrence\": \"<string>\",\r\n  \"debiCheckAuthKey\": \"<string>\",\r\n  \"clientSegment\": \"<string>\",\r\n  \"trackingAllowed\": \"<boolean>\",\r\n  \"trackingDays\": \"<integer>\",\r\n  \"useAmountAdjustment\": \"<boolean>\",\r\n  \"useRateAdjustment\": \"<boolean>\",\r\n  \"releaseDate\": \"<date>\",\r\n  \"debtor\": {\r\n    \"name\": \"veni\",\r\n    \"accountNumber\": \"Lo\",\r\n    \"accountType\": \"e\",\r\n    \"branchCode\": \"ma\",\r\n    \"email\": \"\",\r\n    \"phoneNumber\": \"elit\",\r\n    \"identification\": \"cul\",\r\n    \"identificationType\": \"in \"\r\n  },\r\n  \"creditor\": {\r\n    \"accountNumber\": \"no\",\r\n    \"accountName\": \"\",\r\n    \"branchCode\": \"cu\",\r\n    \"email\": \"ex\",\r\n    \"phoneNumber\": \"pro\",\r\n    \"schemeName\": \"\",\r\n    \"shortName\": \"se\",\r\n    \"ultimateName\": \"ve\"\r\n  }\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.RequestDebiCheckAuthenticationOnAMandateRequest>(bodyValue);

Standard.Models.DebicheckAuthenticationRequestProcessing result = await mandate.CreateRequestDebiCheckAuthenticationOnAMandate(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_request_debi_check_amendment_on_a_mandate"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateRequestDebiCheckAmendmentOnAMandate") CreateRequestDebiCheckAmendmentOnAMandate

> TODO: Add a method description


```csharp
Task<Standard.Models.DebicheckAuthenticationAmendRequestProcessing> CreateRequestDebiCheckAmendmentOnAMandate(double xApiVersion, string contentType, Standard.Models.RequestDebiCheckAmendmentOnAMandateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"bank\": \"<string>\",\r\n  \"amendmentReasonCode\": \"<string>\",\r\n  \"debiCheckAuthKey\": \"<string>\",\r\n  \"maxCollectionCurrency\": \"<string>\",\r\n  \"maxCollectionAmount\": \"<double>\",\r\n  \"mandateIdentification\": \"<string>\",\r\n  \"adjustmentAmount\": \"<double>\",\r\n  \"adjustmentCategory\": \"<string>\",\r\n  \"adjustmentRate\": \"<double>\",\r\n  \"authenticationCode\": \"<string>\",\r\n  \"authenticationDate\": \"<date>\",\r\n  \"authenticationInstrument\": \"<string>\",\r\n  \"authenticationType\": \"<string>\",\r\n  \"clientContractReference\": \"<string>\",\r\n  \"clientRequestReference\": \"<string>\",\r\n  \"collectionFrequency\": \"<string>\",\r\n  \"collectionDay\": \"<string>\",\r\n  \"collectionType\": \"<string>\",\r\n  \"currency\": \"<string>\",\r\n  \"dateAdjustmentAllowed\": \"<boolean>\",\r\n  \"debitValueType\": \"<string>\",\r\n  \"entryClass\": \"<string>\",\r\n  \"firstCollectionIdentifier\": \"<string>\",\r\n  \"firstCollectionDate\": \"<date>\",\r\n  \"firstCollectionAmount\": \"<double>\",\r\n  \"firstCollectionCurrency\": \"<string>\",\r\n  \"initiationDate\": \"<date>\",\r\n  \"instalmentAmount\": \"<double>\",\r\n  \"instalmentOccurrence\": \"<string>\",\r\n  \"clientSegment\": \"<string>\",\r\n  \"trackingAllowed\": \"<boolean>\",\r\n  \"trackingDays\": \"<integer>\",\r\n  \"useAmountAdjustment\": \"<boolean>\",\r\n  \"useRateAdjustment\": \"<boolean>\",\r\n  \"releaseDate\": \"<date>\",\r\n  \"debtor\": {\r\n    \"name\": \"irur\",\r\n    \"accountNumber\": \"do\",\r\n    \"accountType\": \"par\",\r\n    \"branchCode\": \"\",\r\n    \"email\": \"e\",\r\n    \"phoneNumber\": \"te\",\r\n    \"identification\": \"si\",\r\n    \"identificationType\": \"\"\r\n  },\r\n  \"creditor\": {\r\n    \"accountNumber\": \"no\",\r\n    \"accountName\": \"sit\",\r\n    \"branchCode\": \"es\",\r\n    \"email\": \"la\",\r\n    \"phoneNumber\": \"te\",\r\n    \"schemeName\": \"do\",\r\n    \"shortName\": \"mi\",\r\n    \"ultimateName\": \"o\"\r\n  }\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.RequestDebiCheckAmendmentOnAMandateRequest>(bodyValue);

Standard.Models.DebicheckAuthenticationAmendRequestProcessing result = await mandate.CreateRequestDebiCheckAmendmentOnAMandate(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_request_debi_check_cancellation_on_a_mandate"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.MandateController.CreateRequestDebiCheckCancellationOnAMandate") CreateRequestDebiCheckCancellationOnAMandate

> TODO: Add a method description


```csharp
Task<Standard.Models.DebicheckAuthenticationCancelRequested> CreateRequestDebiCheckCancellationOnAMandate(double xApiVersion, string contentType, Standard.Models.RequestDebiCheckCancellationOnAMandateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"bank\": \"<string>\",\r\n  \"cancellationReasonCode\": \"<string>\",\r\n  \"debiCheckAuthKey\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.RequestDebiCheckCancellationOnAMandateRequest>(bodyValue);

Standard.Models.DebicheckAuthenticationCancelRequested result = await mandate.CreateRequestDebiCheckCancellationOnAMandate(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


[Back to List of Controllers](#list_of_controllers)

## <a name="service_controller"></a>![Class: ](https://apidocs.io/img/class.png "BankTechAPI.Tests.Controllers.ServiceController") ServiceController

### Get singleton instance

The singleton instance of the ``` ServiceController ``` class can be accessed from the API Client.

```csharp
ServiceController service = client.Service;
```

### <a name="get_clear_application_cache"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.ServiceController.GetClearApplicationCache") GetClearApplicationCache

> TODO: Add a method description


```csharp
Task<Standard.Models.CacheCleared> GetClearApplicationCache(double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
double xApiVersion = 1.0;

Standard.Models.CacheCleared result = await service.GetClearApplicationCache(xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_a_list_of_a_clients_instruments"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.ServiceController.GetAListOfAClientsInstruments") GetAListOfAClientsInstruments

> TODO: Add a method description


```csharp
Task GetAListOfAClientsInstruments(double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
double xApiVersion = 1.0;

await service.GetAListOfAClientsInstruments(xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_a_list_of_non_processing_days"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.ServiceController.GetAListOfNonProcessingDays") GetAListOfNonProcessingDays

> TODO: Add a method description


```csharp
Task GetAListOfNonProcessingDays(double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
double xApiVersion = 1.0;

await service.GetAListOfNonProcessingDays(xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


[Back to List of Controllers](#list_of_controllers)

## <a name="transact_controller"></a>![Class: ](https://apidocs.io/img/class.png "BankTechAPI.Tests.Controllers.TransactController") TransactController

### Get singleton instance

The singleton instance of the ``` TransactController ``` class can be accessed from the API Client.

```csharp
TransactController transact = client.Transact;
```

### <a name="get_a_collection_matching_the_provided_parameters"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.TransactController.GetACollectionMatchingTheProvidedParameters") GetACollectionMatchingTheProvidedParameters

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionReturned> GetACollectionMatchingTheProvidedParameters(string collectionIdentification, double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| collectionIdentification |  ``` Required ```  | (Required) The parameters. |
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
string collectionIdentification = "<string>";
double xApiVersion = 1.0;

Standard.Models.CollectionReturned result = await transact.GetACollectionMatchingTheProvidedParameters(collectionIdentification, xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_new_eft_collection_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.TransactController.CreateNewEFTCollectionS") CreateNewEFTCollectionS

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionSCreated1> CreateNewEFTCollectionS(double xApiVersion, string contentType, List<Standard.Models.CreateNewEFTCollectionSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"creditorShortName\": \"<string>\",\r\n    \"debtorName\": \"<string>\",\r\n    \"debtorAccountNumber\": \"<string>\",\r\n    \"debtorBranch\": \"<string>\",\r\n    \"debtorBank\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"amount\": \"<double>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"debtorIdentificationType\": \"<string>\",\r\n    \"debtorIdentification\": \"<string>\",\r\n    \"debtorPhoneNumber\": \"<string>\",\r\n    \"debtorEmail\": \"<string>\",\r\n    \"debtorAccountType\": \"<string>\",\r\n    \"forDate\": \"<date>\",\r\n    \"preferredServiceType\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"creditorShortName\": \"<string>\",\r\n    \"debtorName\": \"<string>\",\r\n    \"debtorAccountNumber\": \"<string>\",\r\n    \"debtorBranch\": \"<string>\",\r\n    \"debtorBank\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"amount\": \"<double>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"debtorIdentificationType\": \"<string>\",\r\n    \"debtorIdentification\": \"<string>\",\r\n    \"debtorPhoneNumber\": \"<string>\",\r\n    \"debtorEmail\": \"<string>\",\r\n    \"debtorAccountType\": \"<string>\",\r\n    \"forDate\": \"<date>\",\r\n    \"preferredServiceType\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.CreateNewEFTCollectionSRequest>>(bodyValue);

Standard.Models.CollectionSCreated1 result = await transact.CreateNewEFTCollectionS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_new_naedo_collection_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.TransactController.CreateNewNaedoCollectionS") CreateNewNaedoCollectionS

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionSCreated1> CreateNewNaedoCollectionS(double xApiVersion, string contentType, List<Standard.Models.CreateNewNaedoCollectionSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"creditorShortName\": \"<string>\",\r\n    \"debtorName\": \"<string>\",\r\n    \"debtorAccountNumber\": \"<string>\",\r\n    \"debtorBranch\": \"<string>\",\r\n    \"debtorBank\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"amount\": \"<double>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"trackingDays\": \"<integer>\",\r\n    \"debtorIdentificationType\": \"<string>\",\r\n    \"debtorIdentification\": \"<string>\",\r\n    \"debtorPhoneNumber\": \"<string>\",\r\n    \"debtorEmail\": \"<string>\",\r\n    \"debtorAccountType\": \"<string>\",\r\n    \"forDate\": \"<date>\",\r\n    \"preferredServiceType\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"creditorShortName\": \"<string>\",\r\n    \"debtorName\": \"<string>\",\r\n    \"debtorAccountNumber\": \"<string>\",\r\n    \"debtorBranch\": \"<string>\",\r\n    \"debtorBank\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"amount\": \"<double>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"trackingDays\": \"<integer>\",\r\n    \"debtorIdentificationType\": \"<string>\",\r\n    \"debtorIdentification\": \"<string>\",\r\n    \"debtorPhoneNumber\": \"<string>\",\r\n    \"debtorEmail\": \"<string>\",\r\n    \"debtorAccountType\": \"<string>\",\r\n    \"forDate\": \"<date>\",\r\n    \"preferredServiceType\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.CreateNewNaedoCollectionSRequest>>(bodyValue);

Standard.Models.CollectionSCreated1 result = await transact.CreateNewNaedoCollectionS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_new_debi_check_collection_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.TransactController.CreateNewDebiCheckCollectionS") CreateNewDebiCheckCollectionS

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionSCreated1> CreateNewDebiCheckCollectionS(double xApiVersion, string contentType, List<Standard.Models.CreateNewDebiCheckCollectionSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"trackingDays\": \"<integer>\",\r\n    \"creditorShortName\": \"<string>\",\r\n    \"debtorName\": \"<string>\",\r\n    \"debtorAccountNumber\": \"<string>\",\r\n    \"debtorBranch\": \"<string>\",\r\n    \"debtorBank\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"amount\": \"<double>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"debtorIdentificationType\": \"<string>\",\r\n    \"debtorIdentification\": \"<string>\",\r\n    \"debtorPhoneNumber\": \"<string>\",\r\n    \"debtorEmail\": \"<string>\",\r\n    \"debtorAccountType\": \"<string>\",\r\n    \"forDate\": \"<date>\",\r\n    \"preferredServiceType\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"mandateIdentification\": \"<string>\",\r\n    \"trackingDays\": \"<integer>\",\r\n    \"creditorShortName\": \"<string>\",\r\n    \"debtorName\": \"<string>\",\r\n    \"debtorAccountNumber\": \"<string>\",\r\n    \"debtorBranch\": \"<string>\",\r\n    \"debtorBank\": \"<string>\",\r\n    \"collectionReference\": \"<string>\",\r\n    \"amount\": \"<double>\",\r\n    \"requestedActionDate\": \"<date>\",\r\n    \"debtorIdentificationType\": \"<string>\",\r\n    \"debtorIdentification\": \"<string>\",\r\n    \"debtorPhoneNumber\": \"<string>\",\r\n    \"debtorEmail\": \"<string>\",\r\n    \"debtorAccountType\": \"<string>\",\r\n    \"forDate\": \"<date>\",\r\n    \"preferredServiceType\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.CreateNewDebiCheckCollectionSRequest>>(bodyValue);

Standard.Models.CollectionSCreated1 result = await transact.CreateNewDebiCheckCollectionS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_recall_created_collection_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.TransactController.CreateRecallCreatedCollectionS") CreateRecallCreatedCollectionS

> TODO: Add a method description


```csharp
Task<Standard.Models.CollectionSCreated1> CreateRecallCreatedCollectionS(double xApiVersion, string contentType, List<Standard.Models.RecallCreatedCollectionSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"collectionIdentification\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"collectionIdentification\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.RecallCreatedCollectionSRequest>>(bodyValue);

Standard.Models.CollectionSCreated1 result = await transact.CreateRecallCreatedCollectionS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_new_payment_s"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.TransactController.CreateNewPaymentS") CreateNewPaymentS

> TODO: Add a method description


```csharp
Task<Standard.Models.PaymentSCreated> CreateNewPaymentS(double xApiVersion, string contentType, List<Standard.Models.CreateNewPaymentSRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"bank\": \"<string>\",\r\n    \"shortName\": \"<string>\",\r\n    \"creditorName\": \"<string>\",\r\n    \"creditorAccountNumber\": \"<string>\",\r\n    \"creditorBranch\": \"<string>\",\r\n    \"paymentReference\": \"<string>\",\r\n    \"amount\": \"<double>\",\r\n    \"paymentDate\": \"<date>\",\r\n    \"instrument\": \"<string>\",\r\n    \"creditorAccountType\": \"<string>\"\r\n  },\r\n  {\r\n    \"objectId\": \"<integer>\",\r\n    \"bank\": \"<string>\",\r\n    \"shortName\": \"<string>\",\r\n    \"creditorName\": \"<string>\",\r\n    \"creditorAccountNumber\": \"<string>\",\r\n    \"creditorBranch\": \"<string>\",\r\n    \"paymentReference\": \"<string>\",\r\n    \"amount\": \"<double>\",\r\n    \"paymentDate\": \"<date>\",\r\n    \"instrument\": \"<string>\",\r\n    \"creditorAccountType\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.CreateNewPaymentSRequest>>(bodyValue);

Standard.Models.PaymentSCreated result = await transact.CreateNewPaymentS(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


[Back to List of Controllers](#list_of_controllers)

## <a name="verify_controller"></a>![Class: ](https://apidocs.io/img/class.png "BankTechAPI.Tests.Controllers.VerifyController") VerifyController

### Get singleton instance

The singleton instance of the ``` VerifyController ``` class can be accessed from the API Client.

```csharp
VerifyController verify = client.Verify;
```

### <a name="create_south_african_id_number_verification"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateSouthAfricanIDNumberVerification") CreateSouthAfricanIDNumberVerification

> TODO: Add a method description


```csharp
Task CreateSouthAfricanIDNumberVerification(double xApiVersion, string contentType, Standard.Models.SouthAfricanIDNumberVerificationRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"idNumber\": \"<string>\",\r\n  \"yourReference\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.SouthAfricanIDNumberVerificationRequest>(bodyValue);

await verify.CreateSouthAfricanIDNumberVerification(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_real_time_south_african_home_affairs_id_number_verification"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateRealTimeSouthAfricanHomeAffairsIDNumberVerification") CreateRealTimeSouthAfricanHomeAffairsIDNumberVerification

> TODO: Add a method description


```csharp
Task CreateRealTimeSouthAfricanHomeAffairsIDNumberVerification(double xApiVersion, string contentType, Standard.Models.RealTimeSouthAfricanHomeAffairsIDNumberVerificationRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"idNumber\": \"<string>\",\r\n  \"yourReference\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.RealTimeSouthAfricanHomeAffairsIDNumberVerificationRequest>(bodyValue);

await verify.CreateRealTimeSouthAfricanHomeAffairsIDNumberVerification(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_find_the_id_number_from_a_contact_number"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateFindTheIDNumberFromAContactNumber") CreateFindTheIDNumberFromAContactNumber

> TODO: Add a method description


```csharp
Task CreateFindTheIDNumberFromAContactNumber(double xApiVersion, string contentType, Standard.Models.FindTheIDNumberFromAContactNumberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"contactNumber\": \"<string>\",\r\n  \"yourReference\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.FindTheIDNumberFromAContactNumberRequest>(bodyValue);

await verify.CreateFindTheIDNumberFromAContactNumber(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_credit_bureau_data_without_id_verification"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateCreditBureauDataWithoutIDVerification") CreateCreditBureauDataWithoutIDVerification

> TODO: Add a method description


```csharp
Task CreateCreditBureauDataWithoutIDVerification(double xApiVersion, string contentType, Standard.Models.CreditBureauDataWithoutIDVerificationRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"idNumber\": \"<string>\",\r\n  \"yourReference\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.CreditBureauDataWithoutIDVerificationRequest>(bodyValue);

await verify.CreateCreditBureauDataWithoutIDVerification(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_fintec_apis_own_unique_algorithm_to_fica_your_clients"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateFintecAPISOwnUniqueAlgorithmToFICAYourClients") CreateFintecAPISOwnUniqueAlgorithmToFICAYourClients

> TODO: Add a method description


```csharp
Task CreateFintecAPISOwnUniqueAlgorithmToFICAYourClients(double xApiVersion, string contentType, Standard.Models.FintecAPISOwnUniqueAlgorithmToFICAYourClientsRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"idNumber\": \"<string>\",\r\n  \"firstname\": \"<string>\",\r\n  \"surname\": \"<string>\",\r\n  \"enquiryReason\": \"<string>\",\r\n  \"yourReference\": \"<string>\",\r\n  \"street\": \"<string>\",\r\n  \"suburb\": \"<string>\",\r\n  \"city\": \"<string>\",\r\n  \"province\": \"<string>\",\r\n  \"poCode\": \"<string>\",\r\n  \"dateRange\": \"<string>\",\r\n  \"minimumMatch\": \"<string>\",\r\n  \"secondname\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.FintecAPISOwnUniqueAlgorithmToFICAYourClientsRequest>(bodyValue);

await verify.CreateFintecAPISOwnUniqueAlgorithmToFICAYourClients(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_bank_account_verification_report"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateBankAccountVerificationReport") CreateBankAccountVerificationReport

> TODO: Add a method description


```csharp
Task CreateBankAccountVerificationReport(double xApiVersion, string contentType, Standard.Models.BankAccountVerificationReportRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"verificationType\": \"<string>\",\r\n  \"bankName\": \"<string>\",\r\n  \"accNumber\": \"<string>\",\r\n  \"accType\": \"<string>\",\r\n  \"yourReference\": \"<string>\",\r\n  \"companyRegNo\": \"<string>\",\r\n  \"companyName\": \"<string>\",\r\n  \"idNumber\": \"<double>\",\r\n  \"initials\": \"<string>\",\r\n  \"surname\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.BankAccountVerificationReportRequest>(bodyValue);

await verify.CreateBankAccountVerificationReport(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_absa_bank_account_verification_report"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateABSABankAccountVerificationReport") CreateABSABankAccountVerificationReport

> TODO: Add a method description


```csharp
Task CreateABSABankAccountVerificationReport(double xApiVersion, string contentType, Standard.Models.ABSABankAccountVerificationReportRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"bank\": \"<string>\",\r\n  \"branchCode\": \"<string>\",\r\n  \"accountNumber\": \"<string>\",\r\n  \"accountType\": \"<string>\",\r\n  \"idType\": \"<string>\",\r\n  \"idNumber\": \"<string>\",\r\n  \"surname\": \"<string>\",\r\n  \"initials\": \"<string>\",\r\n  \"emailAddress\": \"<string>\",\r\n  \"phoneNumber\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.ABSABankAccountVerificationReportRequest>(bodyValue);

await verify.CreateABSABankAccountVerificationReport(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_cdv_bank_account_verification"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateCDVBankAccountVerification") CreateCDVBankAccountVerification

> TODO: Add a method description


```csharp
Task<List<Standard.Models.CDVResult>> CreateCDVBankAccountVerification(double xApiVersion, string contentType, List<Standard.Models.CDVBankAccountVerificationRequest> body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "[\r\n  {\r\n    \"accountNumber\": \"<string>\",\r\n    \"accountType\": \"<string>\",\r\n    \"branchCode\": \"<string>\"\r\n  },\r\n  {\r\n    \"accountNumber\": \"<string>\",\r\n    \"accountType\": \"<string>\",\r\n    \"branchCode\": \"<string>\"\r\n  }\r\n]";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Standard.Models.CDVBankAccountVerificationRequest>>(bodyValue);

List<Standard.Models.CDVResult> result = await verify.CreateCDVBankAccountVerification(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_bank_account_verification_job_status"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateBankAccountVerificationJobStatus") CreateBankAccountVerificationJobStatus

> TODO: Add a method description


```csharp
Task CreateBankAccountVerificationJobStatus(double xApiVersion, string contentType, Standard.Models.BankAccountVerificationJobStatusRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"jobId\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.BankAccountVerificationJobStatusRequest>(bodyValue);

await verify.CreateBankAccountVerificationJobStatus(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="get_ping_method_to_test_the_status_of_the_service"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.GetPingMethodToTestTheStatusOfTheService") GetPingMethodToTestTheStatusOfTheService

> TODO: Add a method description


```csharp
Task GetPingMethodToTestTheStatusOfTheService(double xApiVersion)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |


#### Example Usage

```csharp
double xApiVersion = 1.0;

await verify.GetPingMethodToTestTheStatusOfTheService(xApiVersion);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


### <a name="create_get_the_company_cipc_search_results"></a>![Method: ](https://apidocs.io/img/method.png "BankTechAPI.Tests.Controllers.VerifyController.CreateGetTheCompanyCIPCSearchResults") CreateGetTheCompanyCIPCSearchResults

> CIPC - Uses the EnquiryID and EnquiryResultID from the company-match function to get the final file on the company.


```csharp
Task<Standard.Models.ResponseSuccessfulCIPCMatchResultIsPositive> CreateGetTheCompanyCIPCSearchResults(double xApiVersion, string contentType, Standard.Models.GetTheCompanyCIPCSearchResultsRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiVersion |  ``` Required ```  | The requested API version |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
double xApiVersion = 1.0;
string contentType = "application/json";
string bodyValue = "{\r\n  \"company_detailsyourReference\": \"<string>\",\r\n  \"company_detailsreg1\": \"<string>\",\r\n  \"company_detailsreg2\": \"<string>\",\r\n  \"company_detailsreg3\": \"<string>\",\r\n  \"company_detailsbusinessName\": \"<string>\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.GetTheCompanyCIPCSearchResultsRequest>(bodyValue);

Standard.Models.ResponseSuccessfulCIPCMatchResultIsPositive result = await verify.CreateGetTheCompanyCIPCSearchResults(xApiVersion, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 500 | Internal Server Error |
| 503 | Service Unavailable |


[Back to List of Controllers](#list_of_controllers)



