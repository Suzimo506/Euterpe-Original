using System.Collections.Generic;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using Spine;
using UnityEngine;

[Token(Token = "0x20000BC")]
public class DialogMasterControl : MonoBehaviour, IPause, IRelease
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004D7")]
	private string m_Language;

	[SerializeField]
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x20")]
	private DialogControls[] m_Controls;

	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 m_RoleDialogOffset;

	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector3 m_RinLenRoleDialogOffset;

	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 m_CatDialogOffset;

	[Token(Token = "0x40004DC")]
	[SerializeField]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_LRUpTextOffset;

	[SerializeField]
	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_LRDownTextOffset;

	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Vector3[] m_BossDialogOffset;

	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private string m_SortingName;

	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40004E0")]
	private int m_SortingOrder;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40004E1")]
	[SerializeField]
	private Canvas m_DialogCanvas;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40004E2")]
	[SerializeField]
	private TalkBaseImg[] m_TalkBaseImgs;

	[Token(Token = "0x1700007C")]
	public string language
	{
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007D")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x600057E")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x99E070", Offset = "0x99C870", Length = "0x57")]
	[Token(Token = "0x6000576")]
	public Vector3 GetLRDialogOffset(DialogSubControl.DialogDir dir)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x99E060", Offset = "0x99C860", Length = "0x7")]
	public Font GetFont(int index = -1)
	{
		return null;
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x99E0D0", Offset = "0x99C8D0", Length = "0xF0")]
	public TalkBaseImg GetTalkBaseImg(int index)
	{
		return default(TalkBaseImg);
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x99EC00", Offset = "0x99D400", Length = "0x383")]
	public void SetBone(int index, int bossIndex, Dictionary<string, Bone> bones, Transform spineTf)
	{
	}

	[Address(RVA = "0x99E9C0", Offset = "0x99D1C0", Length = "0x6F")]
	[Token(Token = "0x600057B")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x99EBA0", Offset = "0x99D3A0", Length = "0x5C")]
	public void Resume()
	{
	}

	[Address(RVA = "0x99E610", Offset = "0x99CE10", Length = "0x148")]
	[Token(Token = "0x600057D")]
	private void OnInvokeDialog(GameDialogArgs args)
	{
	}

	[Address(RVA = "0x99E1D0", Offset = "0x99C9D0", Length = "0x375")]
	[Token(Token = "0x600057F")]
	public void Init()
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x99E760", Offset = "0x99CF60", Length = "0x25E")]
	private void OnSceneChanged(int index)
	{
	}

	[Address(RVA = "0x99E5D0", Offset = "0x99CDD0", Length = "0x3D")]
	[Token(Token = "0x6000581")]
	private void OnBossSetHide(bool hide)
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x99EA30", Offset = "0x99D230", Length = "0x164")]
	public void Release(bool isEditor)
	{
	}

	[Address(RVA = "0x99E550", Offset = "0x99CD50", Length = "0x77")]
	[Token(Token = "0x6000583")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x99EF90", Offset = "0x99D790", Length = "0x12D")]
	public DialogMasterControl()
	{
	}
}
