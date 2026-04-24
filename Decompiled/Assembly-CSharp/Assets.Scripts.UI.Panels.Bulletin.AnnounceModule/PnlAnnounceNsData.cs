using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;

[Token(Token = "0x2000957")]
[CreateAssetMenu]
public class PnlAnnounceNsData : SerializedScriptableObject
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40032EE")]
	[SerializeField]
	private Dictionary<string, List<PnlStageBulletinDataModel>> m_Data;

	[Token(Token = "0x40032EF")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, List<string>> m_StateContents;

	[Token(Token = "0x170008E7")]
	public Dictionary<string, List<PnlStageBulletinDataModel>> data
	{
		[Token(Token = "0x60054D1")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008E8")]
	public Dictionary<string, List<string>> stateContents
	{
		[Token(Token = "0x60054D2")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x6C9160", Offset = "0x6C7960", Length = "0x143")]
	[Token(Token = "0x60054D3")]
	private void SortAnnounceData()
	{
	}

	[Address(RVA = "0x6C92B0", Offset = "0x6C7AB0", Length = "0x1E8")]
	[Token(Token = "0x60054D4")]
	private int SortRule(PnlStageBulletinDataModel data1, PnlStageBulletinDataModel data2)
	{
		return default(int);
	}

	[Token(Token = "0x60054D5")]
	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	public PnlAnnounceNsData()
	{
	}
}
