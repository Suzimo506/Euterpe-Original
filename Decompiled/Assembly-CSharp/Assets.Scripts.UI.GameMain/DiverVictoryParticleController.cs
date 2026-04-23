using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x2000895")]
public class DiverVictoryParticleController : MonoBehaviour
{
	[Attribute(Name = "HeaderAttribute", RVA = "0x3C610", Offset = "0x3BA10")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x3C610", Offset = "0x3BA10")]
	[Token(Token = "0x4002CA7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject particleObject;

	[Attribute(Name = "HeaderAttribute", RVA = "0x3C780", Offset = "0x3BB80")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x3C780", Offset = "0x3BB80")]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002CA8")]
	public float inAnimTriggerTime;

	[Attribute(Name = "TooltipAttribute", RVA = "0x3C8F0", Offset = "0x3BCF0")]
	[Token(Token = "0x4002CA9")]
	[FieldOffset(Offset = "0x28")]
	public List<float> standbyAnimTriggerTimes;

	[Token(Token = "0x4002CAA")]
	private const string ANIM_IN = "in";

	[Token(Token = "0x4002CAB")]
	private const string ANIM_STANDBY = "standby";

	[Token(Token = "0x4002CAC")]
	[FieldOffset(Offset = "0x30")]
	private HashSet<float> _triggeredTimes;

	[Token(Token = "0x4002CAD")]
	[FieldOffset(Offset = "0x38")]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002CAE")]
	private string m_CurrentAnimName;

	[Token(Token = "0x6004DD7")]
	[Address(RVA = "0x5AD150", Offset = "0x5AB950", Length = "0x9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004DD8")]
	[Address(RVA = "0x5AD440", Offset = "0x5ABC40", Length = "0x1CD")]
	private void Update()
	{
	}

	[Token(Token = "0x6004DD9")]
	[Address(RVA = "0x5AD1F0", Offset = "0x5AB9F0", Length = "0x1EB")]
	private void CheckAndTriggerParticle(float normalizedTime, float animLength)
	{
	}

	[Token(Token = "0x6004DDA")]
	[Address(RVA = "0x5AD3E0", Offset = "0x5ABBE0", Length = "0x5C")]
	private void TriggerParticleAtTime(float currentTime, float triggerTime)
	{
	}

	[Token(Token = "0x6004DDB")]
	[Address(RVA = "0x5AD610", Offset = "0x5ABE10", Length = "0xEC")]
	public DiverVictoryParticleController()
	{
	}
}
