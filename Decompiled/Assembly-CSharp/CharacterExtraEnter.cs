using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

[Token(Token = "0x20000AA")]
public class CharacterExtraEnter : MonoBehaviour, IPreWarm
{
	[SerializeField]
	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0x18")]
	public List<CharacterEnterConfig> data;

	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x20")]
	private CharacterEnterConfig currentSelectedEnterConfig;

	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x70")]
	private GameObject animationAsset;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000484")]
	private GameObject animationObject;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000485")]
	private SkeletonAnimation animation;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000486")]
	private AudioClip audioClipAsset;

	[Address(RVA = "0x465F60", Offset = "0x464760", Length = "0xDC")]
	[Token(Token = "0x6000517")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x465490", Offset = "0x463C90", Length = "0x137")]
	private bool GetCharacterEnterConfig(int characterIndex, out CharacterEnterConfig result)
	{
		System.Runtime.CompilerServices.Unsafe.As<CharacterEnterConfig, @null>(ref result) = null;
		return default(bool);
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x4656E0", Offset = "0x463EE0", Length = "0x877")]
	private void OnStageStart(object _, object __, params object[] ___)
	{
	}

	[Address(RVA = "0x4655D0", Offset = "0x463DD0", Length = "0x103")]
	[Token(Token = "0x600051A")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x466040", Offset = "0x464840", Length = "0x6E")]
	public CharacterExtraEnter()
	{
	}
}
