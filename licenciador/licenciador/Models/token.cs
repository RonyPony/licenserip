namespace licenciador.Models
{
    public class Token
    {
        public int Id { get; set; }
        public bool IsValidToken { get; set; }
        public string Name { get; set; }
        public string hash { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
