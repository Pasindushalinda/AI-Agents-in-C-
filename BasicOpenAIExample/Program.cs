using dotenv.net;
using OpenAI.Chat;
using OpenAI.Responses;

DotEnv.Load();
var openAiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
if (openAiKey == null)
    throw new InvalidOperationException("Missing OPENAI_API_KEY");

ChatClient client = new(model: "gpt-4.1-nano", openAiKey);

List<ChatMessage> messages = [
    new AssistantChatMessage("Hello, what do you want to do today?")
];

Console.WriteLine(messages[0].Content[0].Text);

while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    var input = Console.ReadLine();
    if (input == null || input?.ToLower() == "exit")
        break;
    Console.ResetColor();

    messages.Add(new UserChatMessage(input));

    ChatCompletion completion = client.CompleteChat(messages);

    var response = completion.Content[0].Text;

    messages.Add(new AssistantChatMessage(response));
    Console.WriteLine(response);
}
