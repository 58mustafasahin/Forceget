using ForcegetWebApi.Enums;

namespace ForcegetWebApi.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public Mode Mode { get; set; }
        public MovementType MovementType { get; set; }
        public Incoterm Incoterm { get; set; }
        public PackageType PackageType { get; set; }
        public Unit1 Unit1 { get; set; }
        public Unit2 Unit2 { get; set; }
        public Currency Currency { get; set; }
    }
}
