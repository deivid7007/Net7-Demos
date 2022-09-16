using System.Text.Json;
using SystemTextJsonPolyDemo.Models;

#pragma warning disable

BaseMessage baseMessage = new BaseMessage { Id = 1, Text = "Hello" };
var serializedBaseMessage = JsonSerializer.Serialize(baseMessage);
BaseMessage baseMessageDeserialized = JsonSerializer.Deserialize<BaseMessage>(serializedBaseMessage);

BaseMessage messageWithParams = new MessageWithParams
{
    Id = 2,
    Text = "Hello",
    Params = new List<string>
        {
            "send_with_delay",
            "annonymous_message"
        }
};
var serializedMessageWithParams = JsonSerializer.Serialize(messageWithParams);
MessageWithParams messageWithParamsDeserialized = JsonSerializer.Deserialize<MessageWithParams>(serializedMessageWithParams);

Console.ReadKey();