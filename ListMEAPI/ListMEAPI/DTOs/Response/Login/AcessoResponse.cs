namespace ListMEAPI.DTOs.Response.Login
{
    public class AcessoResponse
    {
        public AcessoResponse(string email)
        {
            this.email = email;
        }
        public string email { get; set; }
    }
}
