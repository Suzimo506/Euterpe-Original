namespace LitJson;

public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
{

	public bool IsArray
	{
		 get { } //Length: 0
	}

	public bool IsBoolean
	{
		 get { } //Length: 0
	}

	public bool IsDouble
	{
		 get { } //Length: 0
	}

	public bool IsInt
	{
		 get { } //Length: 0
	}

	public bool IsLong
	{
		 get { } //Length: 0
	}

	public bool IsObject
	{
		 get { } //Length: 0
	}

	public bool IsString
	{
		 get { } //Length: 0
	}

	public bool get_IsArray() { }

	public bool get_IsBoolean() { }

	public bool get_IsDouble() { }

	public bool get_IsInt() { }

	public bool get_IsLong() { }

	public bool get_IsObject() { }

	public bool get_IsString() { }

	public bool GetBoolean() { }

	public double GetDouble() { }

	public int GetInt() { }

	public JsonType GetJsonType() { }

	public long GetLong() { }

	public string GetString() { }

	public void SetBoolean(bool val) { }

	public void SetDouble(double val) { }

	public void SetInt(int val) { }

	public void SetJsonType(JsonType type) { }

	public void SetLong(long val) { }

	public void SetString(string val) { }

	public string ToJson() { }

	public void ToJson(JsonWriter writer) { }

}

