using Newtonsoft.Json.Linq;
{
    var client = new HttpClient();

    var openWeatherMapApi = "https://api.openweathermap.org/data/2.5/weather?zip=32810&appid=d165a6bfbc939e22cadc6fbfeb89aaaf&units=imperial";

    var orlandoTemps = client.GetStringAsync(openWeatherMapApi).Result;
    var myTemp = JObject.Parse(orlandoTemps)["main"]["temp"].ToString();
    var feelsLike = JObject.Parse(orlandoTemps)["main"]["feels_like"].ToString();
    var tempMin = JObject.Parse(orlandoTemps)["main"]["temp_min"].ToString();
    var tempMax = JObject.Parse(orlandoTemps)["main"]["temp_max"].ToString();
    var myPressure = JObject.Parse(orlandoTemps)["main"]["pressure"].ToString();
    var myHumidity = JObject.Parse(orlandoTemps)["main"]["humidity"].ToString();

    Console.WriteLine($"In the city of Orlano, the current weather details are:\nTemperater : {myTemp} degrees F" +
        $"\nFeels like : {feelsLike} degrees F" +
        $"\nMax Temperature : {tempMax} degrees F" +
        $"\nMin Temperature : {tempMin} degrees F" +
        $"\nPressure : {myPressure}" +
        $"\nHumidity : {myHumidity}");

}