using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

[Token(Token = "0x20000A8")]
public class AnimationControllerByLanguage : SerializedMonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x58")]
	private Animator m_Animator;

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000475")]
	public Dictionary<string, string> m_LanguageToAnimationMapping;

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x596D90", Offset = "0x595590", Length = "0x92")]
	private void Start()
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x6000516")]
	public AnimationControllerByLanguage()
	{
	}
}
