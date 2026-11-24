 // Store a Fahrenheit temperature
Console.WriteLine("Enter the temperature in fahrenheit: ");
decimal fahrenheitTemperature = Convert.ToDecimal(Console.ReadLine());


// Convert it to Celsius

decimal celsiusTemperature = (fahrenheitTemperature - 32) * 5 / 9;


// Display the result

Console.WriteLine($"{fahrenheitTemperature}ºF is equal to {celsiusTemperature:F1}ºC");
