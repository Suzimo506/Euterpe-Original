using Cpp2ILInjected;
using DG.Tweening;
using PeroTools2.PeroString;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000175")]
public class ChangeHealthValue : MonoBehaviour
{
	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image m_BackImage;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400093C")]
	private AnimationCurve m_Curve;

	[SerializeField]
	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x30")]
	private float m_Duration;

	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x38")]
	private Slider m_Slider;

	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsEvil;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000940")]
	private Sequence m_Sequence;

	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x50")]
	private Tweener m_HpTweener;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000942")]
	private PeroString m_PeroString;

	[Address(RVA = "0x463EA0", Offset = "0x4626A0", Length = "0x25B")]
	[Token(Token = "0x6000AB6")]
	private void Awake()
	{
	}

	[Address(RVA = "0x464480", Offset = "0x462C80", Length = "0x13D")]
	[Token(Token = "0x6000AB7")]
	private void OnGameStart(object sender, object rev, params object[] args)
	{
	}

	[Address(RVA = "0x464100", Offset = "0x462900", Length = "0x239")]
	[Token(Token = "0x6000AB8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x464840", Offset = "0x463040", Length = "0x2CA")]
	private void OnHpRateChange(object sender, object reciever, object[] args)
	{
	}

	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x464750", Offset = "0x462F50", Length = "0xE1")]
	private void OnHpDeduct(object sender, object reciever, object[] args)
	{
	}

	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x4645C0", Offset = "0x462DC0", Length = "0x184")]
	private void OnHpAdd(object sender, object reciever, object[] args)
	{
	}

	[Address(RVA = "0x464340", Offset = "0x462B40", Length = "0x13E")]
	[Token(Token = "0x6000ABC")]
	private void OnFail()
	{
	}

	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x464BB0", Offset = "0x4633B0", Length = "0x70")]
	public ChangeHealthValue()
	{
	}
}
