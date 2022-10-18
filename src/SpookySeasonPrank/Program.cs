using Microsoft.Extensions.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

IConfiguration config = new ConfigurationBuilder()
    .AddUserSecrets<Program>(optional: true, reloadOnChange: false)
    .Build();

var twilioAccountSid = config["Twilio:AccountSid"];
var twilioAuthToken = config["Twilio:AuthToken"];

TwilioClient.Init(twilioAccountSid, twilioAuthToken);

CallResource.Create(
    url: new Uri("https://{Your bucket name}.s3.amazonaws.com/output.mp3"),
    method: Twilio.Http.HttpMethod.Get, 
    
    to: new Twilio.Types.PhoneNumber("{Your victim’s phone number}"),
    from: new Twilio.Types.PhoneNumber("{Your Twilio phone number}")
);