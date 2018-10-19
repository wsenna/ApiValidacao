namespace ApiValidacao
{
    public class Usuarios
    {
        public string Id { get; set; }
        public string NomeRazao { get; set; }
        public string AppKey { get; set; }        
    }

    public static class Roles
    {
        public const string ROLE = "ACESSO-API";
    }

    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}