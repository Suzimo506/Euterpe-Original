using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Variables;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000A1")]
public class AlbumDifficultyCell : MonoBehaviour
{
	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x20")]
	private VariableBehaviour m_VariableBehaviour;

	[Token(Token = "0x17000077")]
	public Button btn
	{
		[CompilerGenerated]
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004F9")]
		[CompilerGenerated]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000078")]
	public string uid
	{
		[CompilerGenerated]
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		[CompilerGenerated]
		[Token(Token = "0x60004FB")]
		private set
		{
		}
	}

	[Address(RVA = "0x5946F0", Offset = "0x592EF0", Length = "0x6B")]
	[Token(Token = "0x60004FC")]
	public int GetDataIndex()
	{
		return default(int);
	}

	[Address(RVA = "0x5945A0", Offset = "0x592DA0", Length = "0x142")]
	[Token(Token = "0x60004FD")]
	private void Awake()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60004FE")]
	public AlbumDifficultyCell()
	{
	}
}
