namespace Rewired.Utils.Classes;

[CustomClassObfuscation]
public abstract class SerializedMethod : ScriptableObject
{
	private const int VdjcwgteIomRylEswSZZtFlKAaFw = 3; //Field offset: 0x0
	private bool yYpbtSAHsUMPWPRSxoILJpupHuBQ; //Field offset: 0x18
	internal List<TypeWrapper> _data; //Field offset: 0x20
	internal TypeWrapper _result; //Field offset: 0x28
	internal bool _resultIsValid; //Field offset: 0x48

	internal int DataCount
	{
		internal get { } //Length: 60
	}

	internal TypeWrapper Result
	{
		internal get { } //Length: 19
	}

	internal bool ResultIsValid
	{
		internal get { } //Length: 5
	}

	internal abstract DataType ResultType
	{
		internal get { } //Length: 0
	}

	protected SerializedMethod() { }

	internal void AddData(TypeWrapper item) { }

	internal void AddData(object item) { }

	internal void AddData(string item) { }

	internal void AddData(bool item) { }

	internal void AddData(double item) { }

	internal void AddData(float item) { }

	internal void AddData(long item) { }

	internal void AddData(uint item) { }

	internal void AddData(ulong item) { }

	internal void AddData(char item) { }

	internal void AddData(sbyte item) { }

	internal void AddData(byte item) { }

	internal void AddData(int item) { }

	internal void ClearData() { }

	internal void ClearResult() { }

	internal int get_DataCount() { }

	internal TypeWrapper get_Result() { }

	internal bool get_ResultIsValid() { }

	internal abstract DataType get_ResultType() { }

	internal TypeWrapper GetData(int index) { }

	internal abstract bool Process() { }

	private void zeREuYgnfqBbABLRyPbkaMWgetqN() { }

}

