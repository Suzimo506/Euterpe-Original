using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200068B")]
public class Singleton
{
	[Address(RVA = "0x932640", Offset = "0x930E40", Length = "0x171")]
	[Token(Token = "0x6003DAE")]
	public static void Init(object instance)
	{
	}

	[Address(RVA = "0x9324D0", Offset = "0x930CD0", Length = "0x165")]
	[Token(Token = "0x6003DAF")]
	public static void Destroy(object instance)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003DB0")]
	public Singleton()
	{
	}
}
[Token(Token = "0x200068C")]
public class Singleton<T> where T : new()
{
	[Token(Token = "0x40023D8")]
	private static T m_Instance;

	[Token(Token = "0x170005C7")]
	public static T instance
	{
		[Token(Token = "0x6003DB1")]
		[Address(RVA = "0x1362BF0", Offset = "0x13613F0", Length = "0x166")]
		get
		{
			return (T)null;
		}
	}

	[Address(RVA = "0x1362B70", Offset = "0x1361370", Length = "0x73")]
	[Token(Token = "0x6003DB2")]
	public void Reset()
	{
	}

	[Address(RVA = "0xC25360", Offset = "0xC23B60", Length = "0x19")]
	[Token(Token = "0x6003DB3")]
	public Singleton()
	{
	}
}
