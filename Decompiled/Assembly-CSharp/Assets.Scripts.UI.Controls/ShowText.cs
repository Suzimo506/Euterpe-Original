using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B0")]
public class ShowText : MonoBehaviour, IInitialization
{
	[Token(Token = "0x4002D64")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text m_Text;

	[Token(Token = "0x4002D65")]
	private static ShowText s_ShowText;

	[SerializeField]
	[Token(Token = "0x4002D66")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x431B0", Offset = "0x425B0")]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	[Token(Token = "0x4002D67")]
	[FieldOffset(Offset = "0x28")]
	private AnimationCurve m_Curve;

	[Token(Token = "0x4002D68")]
	[FieldOffset(Offset = "0x30")]
	private Tween m_Tween;

	[Token(Token = "0x6004E9D")]
	[Address(RVA = "0x5B7840", Offset = "0x5B6040", Length = "0x74")]
	public void Show(string info)
	{
	}

	[Token(Token = "0x6004E9E")]
	[Address(RVA = "0x5B7480", Offset = "0x5B5C80", Length = "0x42")]
	public void Close()
	{
	}

	[Token(Token = "0x6004E9F")]
	[Address(RVA = "0x5B7710", Offset = "0x5B5F10", Length = "0x12C")]
	public static void ShowInfo(string info)
	{
	}

	[Address(RVA = "0x44DE50", Offset = "0x44C650", Length = "0x26")]
	[Token(Token = "0x6004EA0")]
	private void OnComplete()
	{
	}

	[Token(Token = "0x6004EA1")]
	[Address(RVA = "0x5B76C0", Offset = "0x5B5EC0", Length = "0x42")]
	private void OnKill()
	{
	}

	[Token(Token = "0x6004EA2")]
	[Address(RVA = "0x5B7530", Offset = "0x5B5D30", Length = "0x13E")]
	private void DoTweenInit()
	{
	}

	[Token(Token = "0x6004EA3")]
	[Address(RVA = "0x5B7670", Offset = "0x5B5E70", Length = "0x4C")]
	public void OnAwake()
	{
	}

	[Token(Token = "0x6004EA4")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnStart()
	{
	}

	[Token(Token = "0x6004EA5")]
	[Address(RVA = "0x5B74D0", Offset = "0x5B5CD0", Length = "0x53")]
	public void Destroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004EA6")]
	public ShowText()
	{
	}
}
