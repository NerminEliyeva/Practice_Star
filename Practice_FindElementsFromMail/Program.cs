
/*
    ----------------------------------------
    - Adı : Murat
    - Soyadı : Vuranok
    - Mail   : murat.vuranok@example.com
    - Domain : example
    - Extention : com
    ----------------------------------------

    ----------------------------------------
    - Adı : Murat
    - Soyadı : Vuranok
    - Mail   : murat.vuranok@example.com
    - Domain : example
    - Extention : com
    ----------------------------------------

*/

using System.Linq;
using System.Runtime.CompilerServices;

string[] mails = {
    "john.doe@example.com",
    "alice.smith@example.com",
    "bob.jones@example.com",
    "emily.white@example.com",
    "david.miller@example.com",
    "sarah.green@example.com",
    "chris.taylor@example.com",
    "laura.wilson@example.com",
    "mike.brown@example.com",
    "jenny.evans@example.com",
    "alex.hall@example.com",
    "olivia.clark@example.com",
    "samuel.lee@example.com",
    "mia.robinson@example.com",
    "ethan.carter@example.com",
    "ava.moore@example.com",
    "lucas.jackson@example.com",
    "grace.anderson@example.com",
    "logan.wright@example.com",
    "lily.harris@example.com",
    "noah.ward@example.com",
    "sophia.martin@example.com",
    "liam.cooper@example.com",
    "emma.king@example.com",
    "jacob.turner@example.com",
    "mia.stewart@example.com",
    "william.cook@example.com",
    "avery.hill@example.com",
    "benjamin.bailey@example.com",
    "mia.mitchell@example.com",
    "daniel.hall@example.com",
    "hannah.carter@example.com",
    "owen.ross@example.com",
    "ava.perry@example.com",
    "ethan.harrison@example.com",
    "audrey.fisher@example.com",
    "caleb.kelly@example.com",
    "madison.brown@example.com",
    "jackson.smith@example.com",
    "sophia.jones@example.com",
    "aiden.davis@example.com",
    "abigail.evans@example.com",
    "logan.lee@example.com",
    "olivia.green@example.com",
    "lucas.williams@example.com",
    "grace.miller@example.com",
    "max.martin@example.com",
    "ella.baker@example.com",
    "jacob.johnson@example.com",
    "mia.collins@example.com",
    "owen.hall@example.com",
    "isabella.clark@example.com",
    "noah.white@example.com",
    "ava.harris@example.com",
    "liam.mitchell@example.com",
    "emma.king@example.com",
    "ethan.stewart@example.com",
    "olivia.cook@example.com",
    "jackson.cooper@example.com",
    "sophia.ward@example.com",
    "aiden.wright@example.com",
    "abigail.turner@example.com",
    "caleb.martin@example.com",
    "audrey.brown@example.com",
    "william.robinson@example.com",
    "grace.evans@example.com",
    "mia.jackson@example.com",
    "logan.anderson@example.com",
    "hannah.smith@example.com",
    "benjamin.jones@example.com",
    "sophia.hall@example.com",
    "emma.brown@example.com",
    "owen.green@example.com",
    "noah.cooper@example.com",
    "lucas.martin@example.com",
    "ava.jones@example.com",
    "ethan.ross@example.com",
    "olivia.hill@example.com",
    "liam.bailey@example.com",
    "audrey.ward@example.com",
    "jackson.turner@example.com",
    "grace.davis@example.com",
    "mia.harrison@example.com",
    "caleb.williams@example.com",
    "avery.king@example.com",
    "abigail.johnson@example.com",
    "logan.white@example.com",
    "hannah.cook@example.com",
    "william.lee@example.com",
    "sophia.evans@example.com",
    "jacob.wright@example.com",
    "emily.cooper@example.com",
    "ava.baker@example.com",
    "olivia.miller@example.com",
    "ethan.hall@example.com",
    "liam.turner@example.com",
    "mia.jones@example.com",
    "audrey.mitchell@example.com",
    "jackson.smith@example.com",
    "grace.williams@example.com"
};

string tre = new String('-', 40);
char[] chararr = { '.', '@' };

for (int i = 0; i < mails.Length; i++)
{
    string result = $"""
    {tre}
    - Adı       : _firstName
    - Soyadı    : _lastName
    - Mail      : _mail
    - Domain    : _domain
    - Extention : _extention
    {tre} 
    """;
    string[] elements = mails[i].Split(chararr);
 
    result = result.Replace("_firstName", elements[0])
                   .Replace("_lastName", elements[1])
                   .Replace("_mail", mails[i])
                   .Replace("_domain", elements[2])
                   .Replace("_extention", elements[3]);

    Console.WriteLine(result);
}






