using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.Bulletin;

[Token(Token = "0x200094F")]
public class PnlStageBulletinController : BaseMessageBox
{
	[SerializeField]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40032BB")]
	private PnlStageBulletinView m_BulletinView;

	[Token(Token = "0x40032BD")]
	private static bool s_HasBeenOpened;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40032BE")]
	private List<string> bulletinList;

	[Token(Token = "0x40032BF")]
	[FieldOffset(Offset = "0x108")]
	public RectTransform m_Content;

	[Token(Token = "0x40032C0")]
	[SerializeField]
	[FieldOffset(Offset = "0x110")]
	private bool m_isNewMessage;

	[Token(Token = "0x170008E0")]
	private Dictionary<string, List<PnlStageBulletinDataModel>> m_BulletinDataModels
	{
		[CompilerGenerated]
		[Address(RVA = "0x4E8C50", Offset = "0x4E7450", Length = "0x8")]
		[Token(Token = "0x600548C")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6CE320", Offset = "0x6CCB20", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x600548B")]
		set
		{
		}
	}

	[Address(RVA = "0x6CF710", Offset = "0x6CDF10", Length = "0x4D")]
	[Token(Token = "0x600548D")]
	public void OnEnable()
	{
	}

	[Address(RVA = "0x6CEC00", Offset = "0x6CD400", Length = "0x2E5")]
	[Token(Token = "0x600548E")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x600548F")]
	[Address(RVA = "0x6CFAD0", Offset = "0x6CE2D0", Length = "0x1E")]
	public void SetDirty(int index)
	{
	}

	[Address(RVA = "0x6CF530", Offset = "0x6CDD30", Length = "0xB7")]
	[Token(Token = "0x6005490")]
	private void InitbulletinListData()
	{
	}

	[Token(Token = "0x6005491")]
	[Address(RVA = "0x6CF840", Offset = "0x6CE040", Length = "0xCE")]
	public void Popup()
	{
	}

	[Token(Token = "0x6005492")]
	[Address(RVA = "0x6CF760", Offset = "0x6CDF60", Length = "0xD2")]
	public void OnShowPnlStageBulletin()
	{
	}

	[Token(Token = "0x6005493")]
	[Address(RVA = "0x6CF9A0", Offset = "0x6CE1A0", Length = "0x2B")]
	private void RefreshUI()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FA70", Offset = "0x9EE70")]
	[Token(Token = "0x6005494")]
	[Address(RVA = "0x6CF910", Offset = "0x6CE110", Length = "0x81")]
	private IEnumerator RefreshBulletinInfo(Action<Dictionary<string, List<PnlStageBulletinDataModel>>> callback = null)
	{
		return null;
	}

	[Address(RVA = "0x6CF9D0", Offset = "0x6CE1D0", Length = "0xA1")]
	[Token(Token = "0x6005495")]
	private void SaveBulletinsUid(List<string> tempUid)
	{
	}

	[Address(RVA = "0x6CEEF0", Offset = "0x6CD6F0", Length = "0x29D")]
	[Token(Token = "0x6005496")]
	private bool CurrentBulletinIsEqual()
	{
		return default(bool);
	}

	[Token(Token = "0x6005497")]
	[Address(RVA = "0x6CF1C0", Offset = "0x6CD9C0", Length = "0x36A")]
	private void HandleBulletinInfos(JToken announce, Dictionary<string, List<PnlStageBulletinDataModel>> models, List<string> tempUid)
	{
	}

	[Token(Token = "0x6005498")]
	[Address(RVA = "0x6CF190", Offset = "0x6CD990", Length = "0x2B")]
	private string CurrentPlatform()
	{
		return null;
	}

	[Token(Token = "0x6005499")]
	[Address(RVA = "0x6CFA80", Offset = "0x6CE280", Length = "0x41")]
	private void SaveDataInLocal(bool islocal)
	{
	}

	[Address(RVA = "0x6CF5F0", Offset = "0x6CDDF0", Length = "0x112")]
	[Token(Token = "0x600549A")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x600549B")]
	public PnlStageBulletinController()
	{
	}
}
