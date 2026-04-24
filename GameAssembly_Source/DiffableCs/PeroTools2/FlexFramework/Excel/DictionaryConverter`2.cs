namespace FlexFramework.Excel;

public sealed class DictionaryConverter : CustomConverter<Dictionary`2<TKey, TValue>>
{

	public DictionaryConverter`2() { }

	public virtual Dictionary<TKey, TValue> Convert(string input) { }

}

