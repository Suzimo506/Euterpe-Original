using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200068E")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x40023DA")]
	private static T m_Instance;

	[Token(Token = "0x170005C9")]
	public static T instance
	{
		[Address(RVA = "0x13620F0", Offset = "0x13608F0", Length = "0x266")]
		[Token(Token = "0x6003DB8")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x1362000", Offset = "0x1360800", Length = "0xE7")]
	[Token(Token = "0x6003DB9")]
	public void DestroyInstance()
	{
	}

	[Address(RVA = "0x1361EA0", Offset = "0x13606A0", Length = "0x152")]
	[Token(Token = "0x6003DBA")]
	private void Awake()
	{
	}

	[Address(RVA = "0x1361E30", Offset = "0x1360630", Length = "0x19")]
	[Token(Token = "0x6003DBB")]
	public SingletonMonoBehaviour()
	{
	}
}
