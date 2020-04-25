using test.Models;

namespace test.Core
{
  public class MessageEndPoint
  {
    private const string apikey = "2f5ae96c-b558-4c7b-a590-a501ae1c3f6c";

    public static string GetApiKey() { return apikey; }

    public static string LoadMessage(MessageRequest element)
    {
      var result = "Empty Field";
      if (element.to != null)
        result = $"Hello {element.to} your message will be send";
      return result;
    }
  }
}