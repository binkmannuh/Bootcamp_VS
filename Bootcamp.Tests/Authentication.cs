namespace Bootcamp.Tests
{
    public class Authentication
    {
        // Eenvoudige methode om login te valideren
        public bool LoginSuccessful(string username, string password)
        {
            // Standaard gebruikersnaam en wachtwoord voor validatie
            string validUsername = "rtj.lans@gmail.com";
            string validPassword = "password123";

            return username == validUsername && password == validPassword;
        }
    }
}
