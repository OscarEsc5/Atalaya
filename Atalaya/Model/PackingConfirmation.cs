namespace Atalaya.Model
{
    public class PackingConfirmation
    {
        public string LOGNUMBER { get; set; }
        public string WHSEID { get; set; }
        public string WAVE { get; set; }
        public DateTime EDITDATE { get; set; }
        public string StorerKey { get; set; }
        public string Type { get; set; }
        public string ExternOrderKey { get; set; }
        public string ConsigneeKey { get; set; }
        public string STATUS { get; set; }
    }
}
