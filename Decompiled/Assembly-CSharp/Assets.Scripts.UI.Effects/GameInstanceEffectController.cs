using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using Spine;
using UnityEngine;

namespace Assets.Scripts.UI.Effects;

[Token(Token = "0x20008A2")]
public class GameInstanceEffectController : MonoBehaviour, IPause
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002CF1")]
	private GameObject m_EffectPrefab;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002CF2")]
	[SerializeField]
	private Vector3 m_Offset;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002CF3")]
	private GameObject m_EffectInstance;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002CF4")]
	private Bone m_EffectFollowBone;

	[Token(Token = "0x4002CF5")]
	[FieldOffset(Offset = "0x40")]
	private List<ParticleSystem> m_FxComps;

	[Token(Token = "0x1700087E")]
	public bool IsGlobal
	{
		[CompilerGenerated]
		[Address(RVA = "0x5B0970", Offset = "0x5AF170", Length = "0x5")]
		[Token(Token = "0x6004E34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004E2D")]
	[Address(RVA = "0x5B00C0", Offset = "0x5AE8C0", Length = "0x31D")]
	public void CreateEffect(Transform parent)
	{
	}

	[Token(Token = "0x6004E2E")]
	[Address(RVA = "0x5B0780", Offset = "0x5AEF80", Length = "0x8D")]
	public void ShowEffect(bool isVisible)
	{
	}

	[Token(Token = "0x6004E2F")]
	[Address(RVA = "0x45EEF0", Offset = "0x45D6F0", Length = "0xC")]
	public void SpineInstanceSetBone(Bone bone)
	{
	}

	[Token(Token = "0x6004E30")]
	[Address(RVA = "0x5B0810", Offset = "0x5AF010", Length = "0x15A")]
	private void UpdateEffect(float timeStep)
	{
	}

	[Token(Token = "0x6004E31")]
	[Address(RVA = "0x5B03E0", Offset = "0x5AEBE0", Length = "0x11F")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004E32")]
	[Address(RVA = "0x5B0500", Offset = "0x5AED00", Length = "0x135")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x5B0640", Offset = "0x5AEE40", Length = "0x135")]
	[Token(Token = "0x6004E33")]
	public void Resume()
	{
	}

	[Token(Token = "0x6004E35")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public GameInstanceEffectController()
	{
	}
}
