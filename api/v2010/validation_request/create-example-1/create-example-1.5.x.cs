// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var validationRequest = ValidationRequestResource.Create(
            friendlyName: "My Home Phone Number",
            phoneNumber: new Twilio.Types.PhoneNumber("+14158675310")
        );

        Console.WriteLine(validationRequest.FriendlyName);
    }
}
