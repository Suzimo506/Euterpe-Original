namespace PeroTools2.Account.Web;

public class Schema
{
	internal class AppPayReq
	{
		public string uid; //Field offset: 0x10
		public long time_stamp; //Field offset: 0x18
		public int price; //Field offset: 0x20
		public int real_name_type; //Field offset: 0x24
		public int adult_type; //Field offset: 0x28
		public string product_id; //Field offset: 0x30
		public string game_id; //Field offset: 0x38

		private AppPayReq() { }

		public AppPayReq(string _uid, long timeStamp, int _price, int _realnameType, int _adultType, string productId, string gameId) { }

		public Dictionary<String, Object> GetDict() { }

	}

	internal struct RestfulResp
	{
		public int code; //Field offset: 0x0
		public string msg; //Field offset: 0x8
		public JObject data; //Field offset: 0x10

	}


	public Schema() { }

}

