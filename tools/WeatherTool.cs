
using System.ComponentModel;
using ModelContextProtocol.Server;

[McpServerToolType]
public class WeatherTool
{
    [McpServerTool, Description("Get the weather in a city")]
    public string GetWeather(string city)
    {
        return $"The weather in {city} is sunny.";
    }


}
