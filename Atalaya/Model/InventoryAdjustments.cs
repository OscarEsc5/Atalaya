namespace Atalaya.Model
{
    public class InventoryAdjustments
    {
        public string WHSEID { get; set; }
        public string ADJUSTMENTKEY { get; set; }
        public string STORER { get; set; }
        public string Comments { get; set; }
        public string HoldCode { get; set; }
        public DateTime DocDate { get; set; }
        public int IdType { get; set; }
        public List<InventoryAdjustmentsL> InventoryAdjustmentsL { get; set; }
    }
}
