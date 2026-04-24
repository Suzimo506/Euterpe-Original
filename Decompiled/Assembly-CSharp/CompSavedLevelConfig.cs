using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200014D")]
public class CompSavedLevelConfig : MonoBehaviour
{
	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x18")]
	private ScrollViewSavedLevelConfig m_SvSavedLevelConfig;

	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x20")]
	private SavedRoleElfinConfigModel m_DataModel;

	[Token(Token = "0x170000BD")]
	public SavedLevelConfigData CurSelectData
	{
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x469630", Offset = "0x467E30", Length = "0x45")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BE")]
	public ScrollViewSavedLevelConfig SvSavedLevelConfig
	{
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0x469210", Offset = "0x467A10", Length = "0xCF")]
	public void Init()
	{
	}

	[Address(RVA = "0x469310", Offset = "0x467B10", Length = "0x27")]
	[Token(Token = "0x600095B")]
	public void RefreshData(List<SavedLevelConfigData> itemDataList)
	{
	}

	[Address(RVA = "0x469340", Offset = "0x467B40", Length = "0x18D")]
	[Token(Token = "0x600095C")]
	public void Release()
	{
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0x4694D0", Offset = "0x467CD0", Length = "0x155")]
	private void SaveConfig()
	{
	}

	[Address(RVA = "0x4692E0", Offset = "0x467AE0", Length = "0x27")]
	[Token(Token = "0x600095E")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600095F")]
	public CompSavedLevelConfig()
	{
	}
}
