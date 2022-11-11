namespace forecast.entities
{
    class Weather : BaseEntity
    {
        public Guid idWeatherType { get; set; }
        public int temperature { get; set; }
    }
}