namespace System.Diagnostics.Tracing;

internal static class EnumHelper
{
	private static class Caster
	{
		public static readonly Transformer<UnderlyingType, ValueType> Instance; //Field offset: 0x0

		private static Caster`1() { }

	}

	private sealed class Transformer : MulticastDelegate
	{

		public Transformer`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ValueType value, AsyncCallback callback, object object) { }

		public override UnderlyingType EndInvoke(IAsyncResult result) { }

		public override UnderlyingType Invoke(ValueType value) { }

	}

	private static readonly MethodInfo IdentityInfo; //Field offset: 0x0

	private static EnumHelper`1() { }

	public static UnderlyingType Cast(ValueType value) { }

}

