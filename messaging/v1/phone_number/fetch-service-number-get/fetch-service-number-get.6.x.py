# Download the helper library from https://www.twilio.com/docs/python/install
from twilio.rest import Client


# Your Account Sid and Auth Token from twilio.com/console
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'
client = Client(account_sid, auth_token)

phone_number = client.messaging \
                     .services('MG2172dd2db502e20dd981ef0d67850e1a') \
                     .phone_numbers('PN557ce644e5ab84fa21cc21112e22c485') \
                     .fetch()

print(phone_number.sid)
