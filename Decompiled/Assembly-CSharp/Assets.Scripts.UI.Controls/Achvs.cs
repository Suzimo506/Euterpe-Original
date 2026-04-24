using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008A3")]
public class Achvs : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002CF7")]
	public GameObject achvBox;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002CF8")]
	private List<string> m_Achievements;

	[Token(Token = "0x4002CF9")]
	[FieldOffset(Offset = "0x28")]
	private List<int> m_DoneIndex;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002CFA")]
	private List<GameObject> m_GameObjects;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002CFB")]
	private Dictionary<string, int> m_IndexCount;

	[Token(Token = "0x4002CFC")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurrentActivateAchv;

	[Token(Token = "0x4002CFD")]
	[FieldOffset(Offset = "0x48")]
	public AchvSelect achvSelect;

	[Token(Token = "0x4002CFE")]
	[FieldOffset(Offset = "0x50")]
	private int m_SeealbeAchvCount;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002CFF")]
	private string m_CurrentLanguage;

	[Token(Token = "0x6004E36")]
	[Address(RVA = "0x5A4DB0", Offset = "0x5A35B0", Length = "0x143")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004E37")]
	[Address(RVA = "0x5A5000", Offset = "0x5A3800", Length = "0x892")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004E38")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F270", Offset = "0x3E670")]
	[Address(RVA = "0x5A5D50", Offset = "0x5A4550", Length = "0x65")]
	private IEnumerator UpdateActivateAchv()
	{
		return null;
	}

	[Address(RVA = "0x5A58A0", Offset = "0x5A40A0", Length = "0x4A3")]
	[Token(Token = "0x6004E39")]
	private void SetAchv(int AchvIndex)
	{
	}

	[Address(RVA = "0x5A4F00", Offset = "0x5A3700", Length = "0xF1")]
	[Token(Token = "0x6004E3A")]
	private bool IsHideAchv(int AchvIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x5A5DC0", Offset = "0x5A45C0", Length = "0x17A")]
	[Token(Token = "0x6004E3B")]
	private void UpdateRectTransformHeight()
	{
	}

	[Token(Token = "0x6004E3C")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public Achvs()
	{
	}
}
