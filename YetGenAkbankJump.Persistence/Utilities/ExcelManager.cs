using ExcelMapper;
using Microsoft.EntityFrameworkCore;
using YetgenAkbankJump.Domain.Dtos;
using YetgenAkbankJump.Domain.Entities;
using YetGenAkbankJump.Persistence.Contexts;
using YetGenAkbankJump.Persistence.Utilities.ExcelConfigurations;

namespace YetGenAkbankJump.Persistence.Utilities
{
    public class ExcelManager
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ExcelManager(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task LoadCountriesAsync(ExcelLoadFileDto excelLoadFileDto, CancellationToken cancellationToken)
        {
            //using (var stream = new MemoryStream(Convert.FromBase64String(excelLoadFileDto.Base64File)))
            //using (var importer = new ExcelImporter(stream))
            //{
            //    // You can register class maps by type.
            //    importer.Configuration.RegisterClassMap<CountryExcelMap>();

            //    ExcelSheet sheet = importer.ReadSheet();
            //    CountryExcelDto[] countryDtos = sheet.ReadRows<CountryExcelDto>().ToArray();

            //    var countries = new List<Country>();

            //    foreach (var countryDto in countryDtos)
            //    {
            //        countries.Add(new Country()
            //        {
            //            Id = countryDto.Id,
            //            Name = countryDto.Name,
            //            Iso2 = countryDto.Iso2,
            //            Iso3 = countryDto.Iso3,
            //            NumericCode = countryDto.NumericCode,
            //            PhoneCode = countryDto.PhoneCode,
            //            Capital = countryDto.Capital,
            //            Currency = countryDto.Currency,
            //            TId = countryDto.TId,
            //            Region = countryDto.Region,
            //            SubRegion = countryDto.SubRegion,
            //            Latitude = countryDto.Latitude,
            //            Longitude = countryDto.Longitude,
            //            WikiDataId = countryDto.WikiDataId,
            //            IsDeleted = false,
            //            CreatedOn = DateTimeOffset.Now,
            //            CreatedByUserId = "hkl2q51XYee4"
            //        });
            //    }

            //    using (var transaction = _applicationDbContext.Database.BeginTransaction())
            //    {
            //        _applicationDbContext.Countries.AddRange(countries);

            //        _applicationDbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Countries ON");

            //        _applicationDbContext.SaveChanges();

            //        _applicationDbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Countries OFF");

            //        transaction.Commit();
            //    }


            //}

            return;
        }

        public async Task LoadCitiesAsync(ExcelLoadFileDto excelLoadFileDto, CancellationToken cancellationToken)
        {
            //using (var stream = new MemoryStream(Convert.FromBase64String(excelLoadFileDto.Base64File)))
            //using (var importer = new ExcelImporter(stream))
            //{
            //    // You can register class maps by type.
            //    importer.Configuration.RegisterClassMap<CityExcelMap>();

            //    ExcelSheet sheet = importer.ReadSheet();
            //    CityExcelDto[] cityDtos = sheet.ReadRows<CityExcelDto>().ToArray();

            //    var cities = new List<City>();

            //    foreach (var cityDto in cityDtos)
            //    {
            //        cities.Add(new City()
            //        {
            //            Id = cityDto.Id,
            //            Name = cityDto.Name,
            //            CountryId = cityDto.CountryId,
            //            Latitude = cityDto.Latitude,
            //            Longitude = cityDto.Longitude,
            //            CreatedOn = DateTimeOffset.Now,
            //            CreatedByUserId = "hkl2q51XYee4"
            //        });
            //    }

            //    using (var transaction = _applicationDbContext.Database.BeginTransaction())
            //    {
            //        _applicationDbContext.Cities.AddRange(cities);

            //        _applicationDbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Cities ON");

            //        _applicationDbContext.SaveChanges();

            //        _applicationDbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Cities OFF");

            //        transaction.Commit();
            //    }

            //}

            return;
        }
    }
}
