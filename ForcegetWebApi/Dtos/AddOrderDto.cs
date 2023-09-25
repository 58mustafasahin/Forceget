using ForcegetWebApi.Enums;

namespace ForcegetWebApi.Dtos
{
    public class AddOrderDto
    {
        public int CityId { get; set; }
        public Mode Mode { get; set; }
        public MovementType MovementType { get; set; }
        public Incoterm Incoterm { get; set; }
        public PackageType PackageType { get; set; }
        public Unit1 Unit1 { get; set; }
        public Unit2 Unit2 { get; set; }
        public Currency Currency { get; set; }
    }
}
