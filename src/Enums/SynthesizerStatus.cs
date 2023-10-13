using System.Text.Json.Serialization;

namespace Radical.Presenting.Components;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SynthesizerStatus
{
    Synthesizer,

    Finished,

    Cancel,

    Error
}
