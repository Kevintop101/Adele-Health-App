using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Adele_Health_App.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Adele_Health_App.Pages
{
    public class ChatModel : PageModel
    {
        private readonly HttpClient _httpClient;
        private const string OpenAIApiKey = "";
        private const string OpenAIEndpoint = "https://api.openai.com/v1/chat/completions";
        private const string OpenAIModel = "gpt-3.5-turbo";

        public ChatModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        
        public async Task<IActionResult> SendMessage([FromBody] ChatRequest request) 
        {
            var payload = new
            {
                model = OpenAIModel,
                messages = new[]
                {
                    new { role = "system", content = "You are a friendly and knowledgeable assistant who helps users track and manage their diabetes based on their own logged data. Offer supportive insights and general wellness tips. Avoid giving strict medical advice." },
                    new { role = "user", content = request.Message }
                },
               
                temperature = 0.7
            };
            var jsonPayload = JsonSerializer.Serialize(payload);
            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", OpenAIApiKey);

            var response = await _httpClient.PostAsync(OpenAIEndpoint, content);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                return StatusCode((int)response.StatusCode, responseString);

            var chatResponse = JsonSerializer.Deserialize<ChatCompletionResponse>(responseString);
            var assistantReply = chatResponse?.Choices[0].Message.Content.Trim();

            return new JsonResult(new { reply = assistantReply });
        }

        public class ChatRequest
        {
            public string Message { get; set; }
        }
        public class ChatCompletionResponse
        {
            public Choice[] Choices { get; set; }
        }
        public class Choice
        {
            public Message Message { get; set; }
        }
        public class Message
        {
            public string Role { get; set; }
            public string Content { get; set; }
        }
        

    }
}


