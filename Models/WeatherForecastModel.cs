namespace HttpClientAPIDemo.Models
{

    public class WeatherForecastModel
    {
        public Weather[] Coord { get; set; }
        public Weather[] Weather { get; set; }
        public string Base { get; set; }
        public int Visibility { get; set; }
        public int Dt { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Cod { get; set; }
    }


}
