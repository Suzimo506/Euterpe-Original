using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D6")]
public class PnlItemAward : MonoBehaviour
{
	[Token(Token = "0x4002E2F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject chipGrid;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002E30")]
	public Animator itemAwardAnimator;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002E31")]
	public Button btnCancel;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002E32")]
	public AudioClip clickSfx;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002E33")]
	public Chip[] chips;

	[Token(Token = "0x14000094")]
	public event Action onDisable
	{
		[Token(Token = "0x6004FAD")]
		[CompilerGenerated]
		[Address(RVA = "0x830190", Offset = "0x82E990", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004FAE")]
		[Address(RVA = "0x830230", Offset = "0x82EA30", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x82F660", Offset = "0x82DE60", Length = "0x89")]
	[Token(Token = "0x6004FAF")]
	private void Awake()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6004FB0")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x82F6F0", Offset = "0x82DEF0", Length = "0x120")]
	[Token(Token = "0x6004FB1")]
	private void OnCancelClicked()
	{
	}

	[Token(Token = "0x6004FB2")]
	[Address(RVA = "0x830060", Offset = "0x82E860", Length = "0x65")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F8A0", Offset = "0x4ECA0")]
	private IEnumerator PlayAnimator()
	{
		return null;
	}

	[Address(RVA = "0x82FA90", Offset = "0x82E290", Length = "0x5CA")]
	[Token(Token = "0x6004FB3")]
	public void OnEnable()
	{
	}

	[Address(RVA = "0x8300D0", Offset = "0x82E8D0", Length = "0xBB")]
	[Token(Token = "0x6004FB4")]
	private void SetChips(List<IData> rewardItems)
	{
	}

	[Token(Token = "0x6004FB5")]
	[Address(RVA = "0x82F820", Offset = "0x82E020", Length = "0x266")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004FB6")]
	public PnlItemAward()
	{
	}
}
