using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200068F")]
public abstract class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x40023DB")]
	private static T m_Instance;

	[Token(Token = "0x170005CA")]
	public static T instance
	{
		[Address(RVA = "0x1361E50", Offset = "0x1360650", Length = "0x46")]
		[Token(Token = "0x6003DBC")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x1361D30", Offset = "0x1360530", Length = "0xFF")]
	[Token(Token = "0x6003DBD")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003DBE")]
	[Address(RVA = "0x0", Length = "0x0")]
	protected abstract void Init();

	[Token(Token = "0x6003DBF")]
	[Address(RVA = "0x1361E30", Offset = "0x1360630", Length = "0x19")]
	protected SingletonBehaviour()
	{
	}
}
