using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200074F")]
public class StageManager : Singleton<StageManager>
{
	[Token(Token = "0x40026A8")]
	[FieldOffset(Offset = "0x10")]
	private List<IData> m_UnlockStages;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40026A9")]
	private List<int> m_UnlockAlbums;

	[Address(RVA = "0x7D00A0", Offset = "0x7CE8A0", Length = "0x117")]
	[Token(Token = "0x60044B4")]
	private void Init()
	{
	}

	[Token(Token = "0x60044B5")]
	[Address(RVA = "0x7CFD40", Offset = "0x7CE540", Length = "0x359")]
	private void DataUpdate()
	{
	}

	[Token(Token = "0x60044B6")]
	[Address(RVA = "0x7D03B0", Offset = "0x7CEBB0", Length = "0x1F7")]
	public void UnlockStage(bool isNew = true)
	{
	}

	[Token(Token = "0x60044B7")]
	[Address(RVA = "0x7D0230", Offset = "0x7CEA30", Length = "0x174")]
	public void UnlockStage(string uid, bool isNew = true)
	{
	}

	[Token(Token = "0x60044B8")]
	[Address(RVA = "0x7D01C0", Offset = "0x7CE9C0", Length = "0x6C")]
	public void UnlockAlbum(int albumIndex)
	{
	}

	[Token(Token = "0x60044B9")]
	[Address(RVA = "0x7D05B0", Offset = "0x7CEDB0", Length = "0x38")]
	public StageManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
