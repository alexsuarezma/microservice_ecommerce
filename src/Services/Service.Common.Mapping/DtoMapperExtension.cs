using System;
using System.Text.Json;
using Newtonsoft.Json;
namespace Service.Common.Mapping
{
    public static class DtoMapperExtension
    {
        public static T MapTo<T>(this object value)
        {
            //return JsonSerializer.Deserialize<T>(
            //    JsonSerializer.Serialize(value)
            //);
            return JsonConvert.DeserializeObject<T>(
                JsonConvert.SerializeObject(value, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })
            );
        }
    }
}
