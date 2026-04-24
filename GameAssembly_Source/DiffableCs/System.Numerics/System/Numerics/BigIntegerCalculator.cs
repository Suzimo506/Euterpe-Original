namespace System.Numerics;

internal static class BigIntegerCalculator
{
	private static int ReducerThreshold; //Field offset: 0x0
	private static int SquareThreshold; //Field offset: 0x4
	private static int AllocationThreshold; //Field offset: 0x8
	private static int MultiplyThreshold; //Field offset: 0xC

	private static BigIntegerCalculator() { }

	public static UInt32[] Add(UInt32[] left, uint right) { }

	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	private static void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	public static int Compare(UInt32[] left, UInt32[] right) { }

	public static UInt32[] Multiply(UInt32[] left, uint right) { }

	public static UInt32[] Multiply(UInt32[] left, UInt32[] right) { }

	private static void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	public static UInt32[] Square(UInt32[] value) { }

	private static void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	public static UInt32[] Subtract(UInt32[] left, uint right) { }

	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	private static void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

}

