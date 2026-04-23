using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Variables;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Obsolete]
[Token(Token = "0x200087B")]
public class TroveItemIndexs : MonoBehaviour, IPreWarm
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002C43")]
	private List<VariableBehaviour> m_Variables;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002C44")]
	public GameObject itemPrefab;

	[Token(Token = "0x4002C45")]
	[FieldOffset(Offset = "0x28")]
	public Transform parent;

	[Token(Token = "0x6004D4C")]
	[Address(RVA = "0x61CF70", Offset = "0x61B770", Length = "0x2A6")]
	private int CheckMissCount()
	{
		return default(int);
	}

	[Token(Token = "0x6004D4D")]
	[Address(RVA = "0x61D230", Offset = "0x61BA30", Length = "0x343")]
	private void RefreshIndexs()
	{
	}

	[Token(Token = "0x6004D4E")]
	[Address(RVA = "0x61D220", Offset = "0x61BA20", Length = "0xD")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x61D580", Offset = "0x61BD80", Length = "0x69")]
	[Token(Token = "0x6004D4F")]
	public TroveItemIndexs()
	{
	}
}
