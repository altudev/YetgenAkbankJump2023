using ExcelMapper;
using YetgenAkbankJump.Domain.Dtos;

namespace YetGenAkbankJump.Persistence.Utilities.ExcelConfigurations
{
    public class CountryExcelMap : ExcelClassMap<CountryExcelDto>
    {
        public CountryExcelMap()
        {

            Map(c => c.Id)
                .WithColumnIndex(0);


            Map(c => c.Name)
                .WithColumnIndex(1);

            Map(c => c.Iso2)
                .WithColumnIndex(2)
                .WithInvalidFallback(null);

            Map(c => c.Iso3)
                .WithColumnIndex(3)
                .WithInvalidFallback(null);

            Map(c => c.NumericCode)
                .WithColumnIndex(4)
                .WithInvalidFallback(null);

            Map(c => c.PhoneCode)
                .WithColumnIndex(5)
                .WithInvalidFallback(null);

            Map(c => c.Capital)
                .WithColumnIndex(6)
                .WithInvalidFallback(null);


            Map(c => c.Currency)
                .WithColumnIndex(7)
                .WithInvalidFallback(null);

            Map(c => c.TId)
                .WithColumnIndex(8)
                .WithInvalidFallback(null);

            Map(c => c.Region)
                .WithColumnIndex(9)
                .WithInvalidFallback(null);
            Map(c => c.SubRegion)
                .WithColumnIndex(10)
                .WithInvalidFallback(null);


            Map(c => c.Latitude)
                .WithColumnIndex(11)
                .WithInvalidFallback(null);

            Map(c => c.Longitude)
                .WithColumnIndex(12)
                .WithInvalidFallback(null);
            Map(c => c.WikiDataId)
                .WithColumnIndex(13)
                .WithInvalidFallback(null);

            Map(c => c.IsDeleted)
                .WithColumnIndex(14)
                .WithInvalidFallback(false);
        }

    }
}
