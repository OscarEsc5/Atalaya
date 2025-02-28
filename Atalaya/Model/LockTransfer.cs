namespace Atalaya.Model
{
    public class LockTransfer
    {
        public string WHSEID { get; set; }
        public string ITRNKEY { get; set; }
        public string STORER { get; set; }
        public string Comments { get; set; }
        public DateTime DocDate { get; set; }
        public string Status { get; set; }
        public int WHSCode { get; set; }
        public int FROMLOC { get; set; }
        public int LOC { get; set; }
        public List<LockTransferL> LockTransferL { get; set; }
    }
}
