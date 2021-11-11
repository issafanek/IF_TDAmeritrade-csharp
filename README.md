# IF_TDAmeritrade-csharp
C# Library for interacting with the TD Ameritrade API

# Supported Services
* Instruments
* Market Hours
* Option Chains
* Orders
* Price History
* Real-Time Quotes
* Transaction History

# TO DOs
* Implement streaming socket API
* Implement 

<h1>How to Install</h1>

`PM> Install-Package IF.TDAmeritrade-csharp`

<h1>How to Use</h1>

<i>Generate your key at https://developer.tdameritrade.com</i>

```csharp
//create an authenticator with your apiKey
var auth = new Authenticator("<ApiKey>");
//When executing the line above, the terminal will provide a URL.
//Paste the URL into a web browser, and go through two factor authentication to log on to TDAmeritrade
//Copy and paste the result URL back into the terminal and press enter.
//You should be successfully authenticated after that.

//create the TDAmeritrade client
var tdAmertiradeClient = new TDAmeritradeClient(auth);

//use one of the services 
var appleLastPrice = await tdAmertiradeClient.QuotesService.GetEquityQuoteAsync("AAPL")).LastPrice;
```

