using System.Text.Json.Serialization;

namespace Radical.Presenting.Components;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RecognizerStatus
{
    Start,

    Finished,

    Close,

    Error
}
