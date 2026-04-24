namespace Sirenix.Serialization;

public static class SerializationPolicies
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MemberInfo, Boolean> <>9__6_0; //Field offset: 0x8
		public static Func<MemberInfo, Boolean> <>9__10_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <get_Everything>b__6_0(MemberInfo member) { }

		internal bool <get_Strict>b__10_0(MemberInfo member) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Type tupleInterface; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <get_Unity>b__0(MemberInfo member) { }

	}

	private static readonly object LOCK; //Field offset: 0x0
	private static ISerializationPolicy everythingPolicy; //Field offset: 0x8
	private static ISerializationPolicy unityPolicy; //Field offset: 0x10
	private static ISerializationPolicy strictPolicy; //Field offset: 0x18

	public static ISerializationPolicy Everything
	{
		 get { } //Length: 658
	}

	public static ISerializationPolicy Strict
	{
		 get { } //Length: 658
	}

	public static ISerializationPolicy Unity
	{
		 get { } //Length: 835
	}

	private static SerializationPolicies() { }

	public static ISerializationPolicy get_Everything() { }

	public static ISerializationPolicy get_Strict() { }

	public static ISerializationPolicy get_Unity() { }

	public static bool TryGetByID(string name, out ISerializationPolicy policy) { }

}

