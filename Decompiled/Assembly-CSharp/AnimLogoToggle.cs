using System;
using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000097")]
public class AnimLogoToggle : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400043E")]
	public GameObject peroperoAnimLogoObj;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400043F")]
	public GameObject eroeroAnimLogoObj;

	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x28")]
	public GameObject rhythmdoctorAnimLogoObj;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000441")]
	private DateTime nowDateTime;

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x38")]
	private VoiceSetting.Voice m_PeroLogoVoices;

	[Address(RVA = "0x5967D0", Offset = "0x594FD0", Length = "0x68")]
	[Token(Token = "0x60004C6")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x596AE0", Offset = "0x5952E0", Length = "0x243")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x596990", Offset = "0x595190", Length = "0x148")]
	private void LogoSfxHandler()
	{
	}

	[Address(RVA = "0x596840", Offset = "0x595040", Length = "0x14C")]
	[Token(Token = "0x60004C9")]
	private bool FirstUseSfxHandler(string firstOpenEventName, bool isContainYear = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x596D30", Offset = "0x595530", Length = "0x5C")]
	public AnimLogoToggle()
	{
	}
}
