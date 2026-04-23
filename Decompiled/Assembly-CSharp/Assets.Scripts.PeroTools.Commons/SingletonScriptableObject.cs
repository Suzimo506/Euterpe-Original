using Cpp2ILInjected;
using Sirenix.OdinInspector;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200068D")]
public class SingletonScriptableObject<T> : SerializedScriptableObject where T : SerializedScriptableObject
{
	[Token(Token = "0x40023D9")]
	protected static T m_Instance;

	[Token(Token = "0x170005C8")]
	public static T instance
	{
		[Address(RVA = "0x1362540", Offset = "0x1360D40", Length = "0x620")]
		[Token(Token = "0x6003DB5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x1362420", Offset = "0x1360C20", Length = "0xFA")]
	[Token(Token = "0x6003DB4")]
	public static string GetSingleScriptableObjectDirectory()
	{
		return null;
	}

	[Token(Token = "0x6003DB6")]
	[Address(RVA = "0x1362360", Offset = "0x1360B60", Length = "0xB1")]
	public void DestroyInstance()
	{
	}

	[Address(RVA = "0x1362520", Offset = "0x1360D20", Length = "0x19")]
	[Token(Token = "0x6003DB7")]
	public SingletonScriptableObject()
	{
	}
}
