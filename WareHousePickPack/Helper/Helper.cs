using System.Collections.Generic;

namespace WareHousePickPack.Helper
{
	public static class Helper
	{
		public static T FromJson<T>(this string jsonData)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonData);
		}
		public static string ToJson(this object obj)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
		}

        public static List<Models.Order> PickOrPackOrderItems { get; set; }
		public static bool IsPicked { get; set; } = true;
    }
}
