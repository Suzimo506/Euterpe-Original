using System.Collections.Generic;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

[Token(Token = "0x2000014")]
public static class LongActionController
{
	[Token(Token = "0x4000048")]
	private static Dictionary<Transform, GameObject> s_Stars;

	[Token(Token = "0x4000049")]
	private static List<Tweener> s_StarTweeners;

	[Token(Token = "0x400004A")]
	private static Dictionary<GameObject, string> s_LongDestroyClipName;

	[Token(Token = "0x400004B")]
	private static ParticleSystem[] s_GroundClipParticles;

	[Token(Token = "0x400004C")]
	private static ParticleSystem[] s_AirClipParticles;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8BCA00", Offset = "0x8BB200", Length = "0xA7")]
	public static void AddStarTween(Tweener startStar, Tweener endStar)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x8BC970", Offset = "0x8BB170", Length = "0x83")]
	public static void AddLongStar(Transform parent, GameObject star)
	{
	}

	[Address(RVA = "0x8BD200", Offset = "0x8BBA00", Length = "0xAF")]
	[Token(Token = "0x6000048")]
	public static GameObject PlayDestroyEffect(GameObject destroyEffect)
	{
		return null;
	}

	[Address(RVA = "0x8BCFB0", Offset = "0x8BB7B0", Length = "0x133")]
	[Token(Token = "0x6000049")]
	public static Effect InitLongDestroyFx(GameObject fx, string name, Transform parent)
	{
		return null;
	}

	[Address(RVA = "0x8BD2B0", Offset = "0x8BBAB0", Length = "0x100")]
	[Token(Token = "0x600004A")]
	public static void PlayLongPressEffect(bool enable, bool isAir)
	{
	}

	[Address(RVA = "0x8BD5D0", Offset = "0x8BBDD0", Length = "0x198")]
	[Token(Token = "0x600004B")]
	public static void StopStars()
	{
	}

	[Address(RVA = "0x8BCAB0", Offset = "0x8BB2B0", Length = "0x4F5")]
	[Token(Token = "0x600004C")]
	public static void InitClipParticle(GameObject clipEffect, bool isAir)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x8BD3C0", Offset = "0x8BBBC0", Length = "0xF5")]
	public static void ReleaseReferences()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x8BD0F0", Offset = "0x8BB8F0", Length = "0x105")]
	public static void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x8BD4C0", Offset = "0x8BBCC0", Length = "0x105")]
	[Token(Token = "0x600004F")]
	public static void Resume()
	{
	}
}
