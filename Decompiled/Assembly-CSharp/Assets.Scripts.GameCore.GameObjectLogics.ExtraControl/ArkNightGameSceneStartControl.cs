using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

[Token(Token = "0x2000769")]
public class ArkNightGameSceneStartControl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002749")]
	public float gaussionDuration;

	[SerializeField]
	[Token(Token = "0x400274A")]
	[FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI m_LevelTMP;

	[SerializeField]
	[Token(Token = "0x400274B")]
	[FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI m_SongNameTMP;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400274C")]
	private RectTransform m_SongInfo;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400274D")]
	private Image m_StartBg;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400274E")]
	private Material m_BgMat;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400274F")]
	private Dictionary<string, string> m_SongUidDic;

	[Token(Token = "0x6004590")]
	[Address(RVA = "0x4960E0", Offset = "0x4948E0", Length = "0x3B")]
	private void Awake()
	{
	}

	[Address(RVA = "0x496120", Offset = "0x494920", Length = "0x2A3")]
	[Token(Token = "0x6004591")]
	private void Start()
	{
	}

	[Token(Token = "0x6004592")]
	[Address(RVA = "0x4963D0", Offset = "0x494BD0", Length = "0x4B")]
	private void Update()
	{
	}

	[Token(Token = "0x6004593")]
	[Address(RVA = "0x496420", Offset = "0x494C20", Length = "0x264")]
	public ArkNightGameSceneStartControl()
	{
	}
}
