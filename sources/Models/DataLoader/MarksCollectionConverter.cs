using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VSU.Models.DataLoader
{
    public class MarksCollectionConverter : JsonConverter<MarkCollection>
    {
        public override MarkCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Mark[] marks = JsonSerializer.Deserialize<short[]>(ref reader, options).Select(x => new Mark((byte)x)).ToArray();
            return new MarkCollection(marks);
        }

        public override void Write(Utf8JsonWriter writer, MarkCollection value, JsonSerializerOptions options)
        {
            short[] marks = value.Select(x => (short)x).ToArray();
            JsonSerializer.Serialize(writer, marks, options);
        }
    }
}
