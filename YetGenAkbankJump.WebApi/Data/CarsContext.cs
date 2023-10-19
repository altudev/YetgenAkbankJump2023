using YetgenAkbankJump.Domain.Entities;

namespace YetGenAkbankJump.WebApi.Data
{
    public static class CarsContext
    {
        public static List<Car> LuxuryCars = new List<Car>
        {
            new Car
            {
                Id = new Guid("460eb0f4-fc8b-4a49-a636-1fb7f9a7d32a"), Make = "Rolls-Royce", Model = "Phantom",
                Price = 455000m, ImageUrl = "https://www.rolls-roycemotorcars.com/content/dam/rrmc/marketUK/rollsroycemotorcars_com/phantom-series-ii-in-detail/page-properties/01_RR_PHANTOM-single-twin-card-min.jpg"
            },
            new Car
            {
                Id = new Guid("0d37d14f-1289-4b8e-8f1b-83bc8bb01c90"), Make = "Bentley", Model = "Mulsanne",
                Price = 304200m, ImageUrl = "https://assets.whichcar.com.au/image/upload/s--lsQxH7QE--/c_fill,f_auto,q_auto:good/t_p_16x9/v1/archive/whichcar/2020/01/15/-1/Bentley-Mulsanne-6.75-Edition-revealed.jpg"
            },
            new Car
            {
                Id = new Guid("74e63c67-468b-404e-b0f6-8e1a2ad6c6a7"), Make = "Lamborghini", Model = "Aventador",
                Price = 417826m, ImageUrl = "https://imgd.aeplcdn.com/1920x1080/ec/79/85/9802/img/ol/Lamborghini-Aventador-Front-view-52649.jpg?v=201711021421&q=80&q=80"
            },
            new Car
            {
                Id = new Guid("5a62d1de-80a9-4f98-b03e-9f2d4e0682e4"), Make = "Ferrari", Model = "488 Pista",
                Price = 350000m, ImageUrl = "https://ca-times.brightspotcdn.com/dims4/default/9a10307/2147483647/strip/true/crop/5000x2625+0+357/resize/1200x630!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F6c%2Fce%2Feb7ce0174a99bcf7e4fd4cd91a06%2Ffi-hy-ferrari-488-pista-10.jpg"
            },
            new Car
            {
                Id = new Guid("d8c76412-f89e-43a9-9d8b-3d6880c3b8f8"), Make = "Aston Martin",
                Model = "DBS Superleggera", Price = 316300m, ImageUrl = "https://www.topgear.com/sites/default/files/cars-car/image/2018/08/am_dbs_superleggera_hyper_red_015_28083.jpg"
            },
            new Car
            {
                Id = new Guid("2d33bc6a-1fa4-4513-aa73-dfb7b3e40854"), Make = "Porsche", Model = "911 GT2 RS",
                Price = 293200m, ImageUrl = "https://hips.hearstapps.com/hmg-prod/amv-prod-cad-assets/wp-content/uploads/2017/06/2018-Porsche-911-GT2-RS-102.jpg"
            },
            new Car
            {
                Id = new Guid("76e5a2b3-37c0-48c7-8e7a-2a77e203d8e7"), Make = "McLaren", Model = "720S",
                Price = 299000m, ImageUrl = "https://image-cdn.hypb.st/https%3A%2F%2Fhypebeast.com%2Fimage%2F2022%2F02%2Fmclaren-720s-spider-open-road-review-test-drive-main.jpg?w=960&cbr=1&q=90&fit=max"
            },
            new Car
            {
                Id = new Guid("8b30cc7a-eeb4-4b0e-8f57-400d2c9c794e"), Make = "Bugatti", Model = "Chiron",
                Price = 2995000m, ImageUrl = "https://www.motortrend.com/uploads/sites/5/2018/03/Bugatti-Chiron-Sport-front-three-quarter.jpg"
            },
            new Car
            {
                Id = new Guid("5f5163c2-ec42-4e7d-9c3e-af49b56e21c8"), Make = "Maserati", Model = "GranTurismo",
                Price = 150380m, ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/2023-maserati-granturismo-modena-7-1676302719.jpg?crop=0.497xw:0.442xh;0.290xw,0.507xh&resize=1200:*"
            },
            new Car
            {
                Id = new Guid("1c7c21b7-cba5-4f2b-8a70-146ef1a7e3c0"), Make = "Jaguar", Model = "F-Type",
                Price = 61300m, ImageUrl = "https://car-images.bauersecure.com/wp-images/12899/jaguar_ftype_100.jpg"
            },
            new Car
            {
                Id = new Guid("8a5c5a94-5e2b-4c69-9c9f-c428f36a6a72"), Make = "Mercedes-Benz", Model = "S-Class",
                Price = 94100m, ImageUrl = "https://cdn.carbuzz.com/gallery-images/1600/1173000/300/1173321.jpg"
            },
            new Car
            {
                Id = new Guid("29d9a545-6b7d-454a-a06e-151e9e9fd912"), Make = "BMW", Model = "7 Series", Price = 86700m,
                ImageUrl = "https://media.autoexpress.co.uk/image/private/s--X-WVjvBW--/f_auto,t_content-image-full-desktop@1/v1650449845/autoexpress/2022/04/BMW%207%20Series%202022-20.jpg"
            },
            new Car
            {
                Id = new Guid("1aa25cb6-80a1-4da7-8ed8-7cee67a1a2d2"), Make = "Audi", Model = "A8", Price = 86100m,
                ImageUrl = "https://cdn.motor1.com/images/mgl/WBxv3/s3/2022-audi-a8-l-horch.jpg"
            },
            new Car
            {
                Id = new Guid("3cdd0f41-aa7a-4ca4-81e7-1e446947f89d"), Make = "Lexus", Model = "LS", Price = 76230m,
                ImageUrl = "https://i.wpimg.pl/O/640x453/i.wp.pl/a/f/jpeg/29603/lexus_ls_2013_8.jpeg"
            },
        };
    }
}
