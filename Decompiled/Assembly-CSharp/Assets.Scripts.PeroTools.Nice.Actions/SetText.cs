using System.Collections.Generic;
using System.Text;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000635")]
public class SetText : Action
{
	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x21EC0", Offset = "0x212C0")]
	[Token(Token = "0x4002305")]
	[FieldOffset(Offset = "0x10")]
	private IVariable m_Object;

	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002306")]
	[Attribute(Name = "VariableAttribute", RVA = "0x222F0", Offset = "0x216F0")]
	private IVariable m_Curve;

	[Attribute(Name = "VariableAttribute", RVA = "0x22430", Offset = "0x21830")]
	[Token(Token = "0x4002307")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private IVariable m_Duration;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002308")]
	public string value;

	[Token(Token = "0x4002309")]
	[Attribute(Name = "VariableAttribute", RVA = "0x22710", Offset = "0x21B10")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<IVariable> m_Datas;

	[Token(Token = "0x400230A")]
	private const string tmpStr = "%s";

	[Token(Token = "0x400230B")]
	private static readonly string[] tmpStrArray;

	[Token(Token = "0x400230C")]
	[FieldOffset(Offset = "0x38")]
	private string[] m_SplitStrs;

	[Token(Token = "0x400230D")]
	[FieldOffset(Offset = "0x40")]
	private Text m_Text;

	[Token(Token = "0x400230E")]
	[FieldOffset(Offset = "0x48")]
	private YlyRichText m_YlyRichText;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400230F")]
	private TextMeshProUGUI m_TextMeshProUGUI;

	[Token(Token = "0x4002310")]
	[FieldOffset(Offset = "0x58")]
	private TextMeshPro m_TextMeshPro;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002311")]
	private InputField m_InputField;

	[Token(Token = "0x4002312")]
	[FieldOffset(Offset = "0x68")]
	private AnimationCurve m_AnimationCurve;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002313")]
	private UnityGameManager.Looper m_Looper;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002314")]
	private string m_OriginText;

	[Token(Token = "0x4002315")]
	private static List<string> m_Strs;

	[Token(Token = "0x4002316")]
	private static StringBuilder m_OutVal;

	[Token(Token = "0x17000593")]
	public Text Object
	{
		[Token(Token = "0x6003BDE")]
		[Address(RVA = "0x74E4C0", Offset = "0x74CCC0", Length = "0x39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000594")]
	public override float duration
	{
		[Token(Token = "0x6003BDF")]
		[Address(RVA = "0x74E500", Offset = "0x74CD00", Length = "0x5E")]
		get
		{
			return default(float);
		}
	}

	[Address(RVA = "0x74DCE0", Offset = "0x74C4E0", Length = "0xC3")]
	[Token(Token = "0x6003BE0")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003BE1")]
	[Address(RVA = "0x74DDB0", Offset = "0x74C5B0", Length = "0x453")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003BE2")]
	[Address(RVA = "0x74E210", Offset = "0x74CA10", Length = "0x64")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6003BE3")]
	[Address(RVA = "0x74E280", Offset = "0x74CA80", Length = "0x1B")]
	public override void Pause()
	{
	}

	[Address(RVA = "0x74E2A0", Offset = "0x74CAA0", Length = "0x1B")]
	[Token(Token = "0x6003BE4")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6003BE5")]
	[Address(RVA = "0x74CA10", Offset = "0x74B210", Length = "0x12C8")]
	private void DoText(string str)
	{
	}

	[Address(RVA = "0x74E400", Offset = "0x74CC00", Length = "0xBB")]
	[Token(Token = "0x6003BE6")]
	public SetText()
	{
	}
}
