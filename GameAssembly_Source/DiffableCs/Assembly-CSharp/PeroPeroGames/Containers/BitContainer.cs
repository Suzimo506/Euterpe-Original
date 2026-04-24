namespace PeroPeroGames.Containers;

public struct BitContainer
{
	private int m_Value; //Field offset: 0x0

	public BitContainer(int value) { }

	public bool Contains(int val) { }

	public TypeCode GetTypeCode() { }

	public static BitContainer op_Addition(BitContainer container, int value) { }

	public static int op_Implicit(BitContainer value) { }

	public static BitContainer op_Implicit(int value) { }

	public static BitContainer op_Subtraction(BitContainer container, int value) { }

	public bool ToBoolean() { }

	public byte ToByte() { }

	public char ToChar() { }

	public DateTime ToDateTime(IFormatProvider provider) { }

	public decimal ToDecimal() { }

	public double ToDouble() { }

	public T ToEnum() { }

	public short ToInt16() { }

	public int ToInt32() { }

	public long ToInt64() { }

	public sbyte ToSByte() { }

	public float ToSingle() { }

	public virtual string ToString() { }

	public ushort ToUInt16() { }

	public uint ToUInt32() { }

	public ulong ToUInt64() { }

}

