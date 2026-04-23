using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x200083D")]
public class PnlEditorFishDebug : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4002B0B")]
	private Dropdown m_FishSelections;

	[Token(Token = "0x4002B0C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InputField m_FishAddCount;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002B0D")]
	[SerializeField]
	private Button m_BtnAdd;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002B0E")]
	[SerializeField]
	private Button m_BtnClearCache;

	[SerializeField]
	[Token(Token = "0x4002B0F")]
	[FieldOffset(Offset = "0x38")]
	private Button m_BtnAllUnlock;

	[SerializeField]
	[Token(Token = "0x4002B10")]
	[FieldOffset(Offset = "0x40")]
	private Button m_BtnShow;

	[SerializeField]
	[Token(Token = "0x4002B11")]
	[FieldOffset(Offset = "0x48")]
	private Button m_BtnClose;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002B12")]
	[SerializeField]
	private GameObject m_MainPnl;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002B13")]
	private DaveFishDataModel m_DataModel;

	[Token(Token = "0x4002B14")]
	[FieldOffset(Offset = "0x60")]
	private List<DaveFishLocalizationData> m_FishLocalizationDataList;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002B15")]
	private DaveFishLocalizationData m_CurrentSelectionFish;

	[Address(RVA = "0x613D30", Offset = "0x612530", Length = "0x250")]
	[Token(Token = "0x6004BD9")]
	private void Awake()
	{
	}

	[Address(RVA = "0x6141D0", Offset = "0x6129D0", Length = "0x23C")]
	[Token(Token = "0x6004BDA")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6004BDB")]
	[Address(RVA = "0x614160", Offset = "0x612960", Length = "0x6E")]
	private void OnFishSelectionChanged(int fishDataIdx)
	{
	}

	[Token(Token = "0x6004BDC")]
	[Address(RVA = "0x613F90", Offset = "0x612790", Length = "0xCA")]
	private void OnClickToAdd()
	{
	}

	[Token(Token = "0x6004BDD")]
	[Address(RVA = "0x614060", Offset = "0x612860", Length = "0xF6")]
	private void OnClickToUnlockAll()
	{
	}

	[Token(Token = "0x6004BDE")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlEditorFishDebug()
	{
	}
}
