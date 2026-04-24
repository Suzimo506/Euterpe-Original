using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Others;

[Token(Token = "0x20005C0")]
public class LoadingScene : MonoBehaviour
{
	[Token(Token = "0x4002178")]
	[FieldOffset(Offset = "0x18")]
	private float m_LoadingTime;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400217A")]
	public Text loadingTip;

	[Token(Token = "0x17000540")]
	public static bool isOnLoaded
	{
		[Address(RVA = "0x97EF30", Offset = "0x97D730", Length = "0x35")]
		[Token(Token = "0x6003983")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x97EF70", Offset = "0x97D770", Length = "0x3A")]
		[Token(Token = "0x6003984")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Address(RVA = "0x97ED00", Offset = "0x97D500", Length = "0xD2")]
	[Token(Token = "0x6003985")]
	private void OnEnable()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x97F00", Offset = "0x97300")]
	[Address(RVA = "0x97EDE0", Offset = "0x97D5E0", Length = "0x65")]
	[Token(Token = "0x6003986")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6003987")]
	[Address(RVA = "0x97E750", Offset = "0x97CF50", Length = "0x500")]
	private void Complete()
	{
	}

	[Token(Token = "0x6003988")]
	[Address(RVA = "0x97EC60", Offset = "0x97D460", Length = "0x95")]
	private void DelayDestroy()
	{
	}

	[Token(Token = "0x6003989")]
	[Address(RVA = "0x97EF00", Offset = "0x97D700", Length = "0x2E")]
	private void Update()
	{
	}

	[Token(Token = "0x600398A")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public LoadingScene()
	{
	}
}
