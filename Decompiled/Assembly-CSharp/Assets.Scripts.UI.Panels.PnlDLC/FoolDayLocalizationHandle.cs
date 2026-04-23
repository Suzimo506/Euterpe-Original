using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200092C")]
public class FoolDayLocalizationHandle : MonoBehaviour
{
	[Token(Token = "0x4003169")]
	[FieldOffset(Offset = "0x18")]
	public Localization originLocalization;

	[Token(Token = "0x400316A")]
	[FieldOffset(Offset = "0x20")]
	public Localization targetLocalization;

	[Token(Token = "0x6005321")]
	[Address(RVA = "0x42E7F0", Offset = "0x42CFF0", Length = "0xA9")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005322")]
	[Address(RVA = "0x42E8A0", Offset = "0x42D0A0", Length = "0x4C")]
	private void ChangeByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Token(Token = "0x6005323")]
	[Address(RVA = "0x42E8F0", Offset = "0x42D0F0", Length = "0xA9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005324")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public FoolDayLocalizationHandle()
	{
	}
}
