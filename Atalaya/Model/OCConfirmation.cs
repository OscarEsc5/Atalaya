namespace Atalaya.Model
{
    public class OCConfirmation
    {
        public string WHSEID { get; set; }
        public string ObjetType { get; set; }
        public string ASNInfor { get; set; }
        public string DocNum { get; set; }
        public DateTime DocDueDate { get; set; }
        public string INFOR_Documento { get; set; }
        public string DocEntry { get; set; }
        public string UserSign { get; set; }
        public string SUSR1 { get; set; }
        public string SUSR2 { get; set; }
        public List<OCConfirmationL> OCConfirmationL { get; set; }
    }
}
