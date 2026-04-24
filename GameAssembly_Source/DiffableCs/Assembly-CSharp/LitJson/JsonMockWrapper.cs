namespace LitJson;

public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
{

	public override bool IsArray
	{
		 get { } //Length: 3
	}

	public override bool IsBoolean
	{
		 get { } //Length: 3
	}

	public override bool IsDouble
	{
		 get { } //Length: 3
	}

	public override bool IsInt
	{
		 get { } //Length: 3
	}

	public override bool IsLong
	{
		 get { } //Length: 3
	}

	public override bool IsObject
	{
		 get { } //Length: 3
	}

	public override bool IsString
	{
		 get { } //Length: 3
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 3
		private set { } //Length: 3
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 3
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 3
		private set { } //Length: 3
	}

	private override object System.Collections.Specialized.IOrderedDictionary.Item
	{
		private get { } //Length: 3
		private set { } //Length: 3
	}

	public JsonMockWrapper() { }

	public override bool get_IsArray() { }

	public override bool get_IsBoolean() { }

	public override bool get_IsDouble() { }

	public override bool get_IsInt() { }

	public override bool get_IsLong() { }

	public override bool get_IsObject() { }

	public override bool get_IsString() { }

	public override bool GetBoolean() { }

	public override double GetDouble() { }

	public override int GetInt() { }

	public override JsonType GetJsonType() { }

	public override long GetLong() { }

	public override string GetString() { }

	public override void SetBoolean(bool val) { }

	public override void SetDouble(double val) { }

	public override void SetInt(int val) { }

	public override void SetJsonType(JsonType type) { }

	public override void SetLong(long val) { }

	public override void SetString(string val) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object k, object v) { }

	private override void System.Collections.IDictionary.Clear() { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.Remove(object key) { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int i, object v) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	private override object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx) { }

	private override IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator() { }

	private override void System.Collections.Specialized.IOrderedDictionary.Insert(int i, object k, object v) { }

	private override void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int i) { }

	private override void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value) { }

	public override void ToJson(JsonWriter writer) { }

	public override string ToJson() { }

}

