using System.Text.Json.Serialization;

#pragma warning disable
namespace SystemTextJsonPolyDemo.Models
{
    // First solution
    //[JsonDerivedType(typeof(MessageWithParams))]

    // Second solution if the message is comming for outside
    //[JsonDerivedType(typeof(BaseMessage), "base")]
    //[JsonDerivedType(typeof(MessageWithParams), "withParams")]

    // Additional settings
    //[JsonPolymorphic(
    //    IgnoreUnrecognizedTypeDiscriminators = true,
    //    TypeDiscriminatorPropertyName = "test",
    //    UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization)]
    public class BaseMessage
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}
