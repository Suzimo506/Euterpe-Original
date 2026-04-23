using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000137")]
public class SkinSwitchController : MonoBehaviour
{
	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x18")]
	private SkeletonGraphic m_SkeletonGraphic;

	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsSwitchSkin;

	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x24")]
	private int m_CurSwitchIndex;

	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x28")]
	public SkeletonDataAsset curSkeletonDataAsset;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007A5")]
	public List<SkeletonDataAsset> switchSkeletonDataAssets;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007A6")]
	public float switchTime;

	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x40")]
	public GameObject skinNameShow;

	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x48")]
	public Text txtSkinName;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007A9")]
	public GameObject switchEffect;

	[Address(RVA = "0x62EDE0", Offset = "0x62D5E0", Length = "0x107")]
	[Token(Token = "0x60008CE")]
	private void Awake()
	{
	}

	[Address(RVA = "0x62EEF0", Offset = "0x62D6F0", Length = "0xAD")]
	[Token(Token = "0x60008CF")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x62F270", Offset = "0x62DA70", Length = "0x65")]
	[Token(Token = "0x60008D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x211C0", Offset = "0x205C0")]
	private IEnumerator SwitchSkinHandle()
	{
		return null;
	}

	[Address(RVA = "0x62F1C0", Offset = "0x62D9C0", Length = "0xAD")]
	[Token(Token = "0x60008D1")]
	private void StartSwitchSkinHandle()
	{
	}

	[Address(RVA = "0x62EEF0", Offset = "0x62D6F0", Length = "0xAD")]
	[Token(Token = "0x60008D2")]
	private void StopSwitchSkinHandle()
	{
	}

	[Address(RVA = "0x62EFB0", Offset = "0x62D7B0", Length = "0x141")]
	[Token(Token = "0x60008D3")]
	private void OnShowName(int index, int roleOrElfinIndex, int roleOrElfinType)
	{
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x62EFA0", Offset = "0x62D7A0", Length = "0xA")]
	private void OnHideName()
	{
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x62F100", Offset = "0x62D900", Length = "0xB1")]
	private void SetSkinNameActive(bool isShow = true)
	{
	}

	[Address(RVA = "0x62F2E0", Offset = "0x62DAE0", Length = "0xE")]
	[Token(Token = "0x60008D6")]
	public SkinSwitchController()
	{
	}
}
