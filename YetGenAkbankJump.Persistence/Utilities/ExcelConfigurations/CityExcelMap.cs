using ExcelMapper;
using YetgenAkbankJump.Domain.Dtos;

namespace YetGenAkbankJump.Persistence.Utilities.ExcelConfigurations
{
    public class CityExcelMap : ExcelClassMap<CityExcelDto>
    {
        public CityExcelMap()
        {

            Map(c => c.Id)
                .WithColumnIndex(0);

            Map(c => c.Name)
                .WithColumnIndex(1);

            Map(c => c.CountryId)
                .WithColumnIndex(2);
            Map(c => c.Latitude)
                .WithColumnIndex(3)
                .WithInvalidFallback(null);
            Map(c => c.Longitude)
                .WithColumnIndex(4)
                .WithInvalidFallback(null);

           


        }
    }
}
