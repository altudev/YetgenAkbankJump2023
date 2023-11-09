namespace YetgenAkbankJump.Domain.Dtos
{
    public class CityExcelDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
