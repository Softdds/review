using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Web;

namespace DDS.Utils.Extensions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Builds enumerable key value pair from object by their properties
        /// </summary>
        /// <param name="objectParams"></param>
        /// <param name="extraParams"></param>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, string>> ToKeyValuePairEnumerable(
            this object objectParams,
            params KeyValuePair<string, string>[] extraParams)
        {
            AssertObjectType(objectParams, nameof(objectParams));

            return objectParams.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance)
                .Select(x => new KeyValuePair<string, string>(
                    JsonNamingPolicy.CamelCase.ConvertName(x.Name),
                    x.GetGetMethod()?.Invoke(objectParams, null)?.ToString()
                ))
                //// do not send null values
                .Where(x => x.Value != null)
                .Concat(extraParams.Select(x =>
                    new KeyValuePair<string, string>(
                        x.Key,
                        HttpUtility.UrlEncode(x.Value))));
        }

        /// <summary>
        /// Check type of parameters object
        /// </summary>
        /// <param name="obj">Parameters object</param>
        /// <param name="paramName">Using in error message parameter name</param>
        /// <exception cref="InvalidDataContractException"></exception>
        private static void AssertObjectType(object obj, string paramName)
        {
            if (obj is IEnumerable<KeyValuePair<string, string>>)
                throw new InvalidDataContractException(
                    $"Parameter \"{paramName}\" must be a single data object");
        }
    }
}
