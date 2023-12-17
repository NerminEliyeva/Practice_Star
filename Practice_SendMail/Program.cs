using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

//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

//full acccess key
//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


//Forbidden xetasi aliram ???
await Execute();
static async Task Execute()
{
    var apiKey = "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";
    var client = new SendGridClient(apiKey);
    var from = new EmailAddress("narminshal@code.edu.az", "Narmin");
    var to = new EmailAddress("narminshal@code.edu.az", "Narmin");
    var subject = "Sending Email With SendGrid";
    var plainTextContent = "bu neki anlamadim";
    var htmlContent = "<h1>Hello <strong>Nermin</strong></h1>";
    var msg = MailHelper.CreateSingleEmail(
        from,
        to,
        subject,
        plainTextContent,
        htmlContent
        );
    var response = await client.SendEmailAsync(msg);
    Console.WriteLine( response.StatusCode);
    Console.WriteLine(response.Headers);
}