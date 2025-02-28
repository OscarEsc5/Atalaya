namespace Atalaya.Model
{
    public class OVConfirmation
    {
        public string WHSEID { get; set; }
        public string ObjetType { get; set; }
        public string OrderKey { get; set; }
        public string DocNum { get; set; }
        public string CardCode { get; set; }
        public string SUSR3 { get; set; }
        public string SUSR4 { get; set; }
        public DateTime DocDueDate { get; set; }
        public List<OVConfirmationL> OVConfirmationL { get; set; }
    }
}
