namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal abstract class SafeDelegate : ICloneable
{
	private static Action<Exception> cGFGfxDieAvMmFeUvQXQHDOWFCUCA; //Field offset: 0x2C927B4

	internal abstract int Count
	{
		internal get { } //Length: 0
	}

	internal abstract Action<Exception> ExceptionHandler
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal static Action<Exception> S_ExceptionHandler
	{
		internal get { } //Length: 53
		internal set { } //Length: 66
	}

	protected SafeDelegate() { }

	internal abstract void Clear() { }

	public abstract object Clone() { }

	internal abstract int get_Count() { }

	internal abstract Action<Exception> get_ExceptionHandler() { }

	internal static Action<Exception> get_S_ExceptionHandler() { }

	internal abstract void RemoveDelegateOrAllDelegatesFromAnObject(object obj) { }

	internal abstract void set_ExceptionHandler(Action<Exception> value) { }

	internal static void set_S_ExceptionHandler(Action<Exception> value) { }

}

