namespace Atalaya.Model
{
    public class WarehouseTransfer
    {
        public string WHSEID { get; set; }
        public string ITRNKEY { get; set; }
        public string STORER { get; set; }
        public DateTime DocDate { get; set; }
        public string FROMLOC { get; set; }
        public string Status { get; set; }
        public string Motivo { get; set; }
        public string LOC { get; set; }
        public string Comments { get; set; }
        public List<WarehouseTransferL> WarehouseTransferL { get; set; }
    }
}
