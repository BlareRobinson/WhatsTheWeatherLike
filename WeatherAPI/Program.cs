using System;

namespace WeatherAPI
{
    class Program
    {
        public static object GetForecast { get; private set; }

        static void Main(string[] args)
        {
            var weatherUpdate = new DailyWeatherUpdate();

            var updating = true;
            while (updating)
            {
                showForecast();
                var forecast = GetForecast;
                switch (forecast)
                {
                    case 1:
                        var oneDay = searchForecast.GetDailyForecast();
                        DisplayTodaysForecast(oneDay);
                        break;
                    case 2:
                        var oneWeek = searchForecast.GetWeeklyForecast();
                        break;
                }
            }

        }

        private static void DisplayTodaysForecast(object oneDay)
        {
            throw new NotImplementedException();
        }

        private static void showForecast()
        {
            throw new NotImplementedException();
        }
    }
}
