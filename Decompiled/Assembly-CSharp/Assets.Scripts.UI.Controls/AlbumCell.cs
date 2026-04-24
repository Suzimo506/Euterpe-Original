using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Variables;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008A4")]
public class AlbumCell : MonoBehaviour
{
	[Token(Token = "0x4002D00")]
	[FieldOffset(Offset = "0x18")]
	public Button btn;

	[Token(Token = "0x4002D01")]
	[FieldOffset(Offset = "0x20")]
	public GameObject imgLock;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002D02")]
	public GameObject imgMy;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002D03")]
	public GameObject imgHeart;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002D04")]
	public GameObject locker;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002D05")]
	private VariableBehaviour m_VariableBehaviour;

	[Token(Token = "0x4002D06")]
	[FieldOffset(Offset = "0x48")]
	public GameObject imgFavoriteMusic;

	[Token(Token = "0x4002D07")]
	[FieldOffset(Offset = "0x50")]
	public GameObject weekFreeIcon;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002D08")]
	private bool m_Lock;

	[Token(Token = "0x1700087F")]
	public string uid
	{
		[CompilerGenerated]
		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x5A6760", Offset = "0x5A4F60", Length = "0xC")]
		private set
		{
		}
	}

	[Address(RVA = "0x5A6250", Offset = "0x5A4A50", Length = "0x6B")]
	[Token(Token = "0x6004E3F")]
	public int GetDataIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6004E40")]
	[Address(RVA = "0x5A6580", Offset = "0x5A4D80", Length = "0xAD")]
	public void SetUid(string uid)
	{
	}

	[Token(Token = "0x6004E41")]
	[Address(RVA = "0x5A62C0", Offset = "0x5A4AC0", Length = "0x2B1")]
	public void SetLock(bool isLock)
	{
	}

	[Address(RVA = "0x5A6630", Offset = "0x5A4E30", Length = "0x12F")]
	[Token(Token = "0x6004E42")]
	public void SetWeekFree(bool isWeekFree)
	{
	}

	[Token(Token = "0x6004E43")]
	[Address(RVA = "0x5A6200", Offset = "0x5A4A00", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004E44")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AlbumCell()
	{
	}
}
