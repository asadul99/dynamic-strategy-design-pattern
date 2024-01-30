using DynamicStrategyPattern.IServices;
using DynamicStrategyPattern.Models;
using DynamicStrategyPattern.ServiceAttributes;
using DynamicStrategyPattern.Strategies;

namespace DynamicStrategyPattern.ConcreteStrategies
{
    /// <summary>
    /// News save business
    /// </summary>
    /// 
    [ScopedService]
    public class SMSSendStrategy : INotificationStrategy
    {
        /// <summary>
        /// Action of news get
        /// </summary>
        public EnumNotificationType NotificationType => EnumNotificationType.SMS;

        private readonly ISMSSenderService _smsSenderService;

        private readonly IHttpClientFactory _httpClientFactory;
        /// <summary>
        /// Init EmailSenderService
        /// </summary>
        /// <param name="smsSenderService"></param>
        public SMSSendStrategy(ISMSSenderService smsSenderService, IHttpClientFactory httpClientFactory)
        {
            _smsSenderService = smsSenderService;
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Email send business implementation
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> SendNotificationAsync(string recipient, string message)
        {
            // Replace the URL with the actual API endpoint you want to call
            string apiUrl = "https://official-joke-api.appspot.com/random_joke";

            // Create an instance of HttpClient
            HttpClient client = _httpClientFactory.CreateClient();
            try
            {
                // Make a GET request to the API
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful (status code 200-299)
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Process the response data as needed
                    Console.WriteLine("Response: " + responseBody);
                }
                else
                {
                    // Handle the error if the request was not successful
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, if any
                Console.WriteLine($"Exception: {ex.Message}");
            }

            //implement your get news related business here
            return await _smsSenderService.SendSMSAsync(recipient, message);
        }
    }
}
