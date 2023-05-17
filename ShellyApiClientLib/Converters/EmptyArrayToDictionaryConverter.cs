using System.Text.Json;
using System.Text.Json.Serialization;
using ShellyApiClientLib.Models.AllListsModel.DashboardModels;

namespace ShellyApiClientLib.Converters;

/// <summary>
/// Converts empty JSON array ("[]") to an empty dictionary.
/// </summary>
/// <remarks>
/// Some of the requests return empty array when there is nothing inside while an object that can be parsed
/// using Dictionary when it is not empty. This converter was created to handle those cases.
/// </remarks>
internal class EmptyArrayToDictionaryConverter : JsonConverter<Dictionary<string, PositionModel>>
{
    private readonly JsonConverter<Dictionary<string, PositionModel>> _defaultConverter = 
        (JsonConverter<Dictionary<string, PositionModel>>)JsonSerializerOptions.Default
            .GetConverter(typeof(Dictionary<string, PositionModel>));
    
    public override Dictionary<string, PositionModel>? Read(ref Utf8JsonReader reader, Type typeToConvert, 
        JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.StartArray)
        {
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    return new Dictionary<string, PositionModel>();
            }
        }

        return _defaultConverter.Read(ref reader, typeToConvert, options);
    }

    public override void Write(Utf8JsonWriter writer, Dictionary<string, PositionModel> value,
        JsonSerializerOptions options) =>
        _defaultConverter.Write(writer, value, options);
}