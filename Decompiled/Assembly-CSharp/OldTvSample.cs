using Cpp2ILInjected;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x20001AB")]
public class OldTvSample : MonoBehaviour
{
	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer renderer;

	[Attribute(Name = "RangeAttribute", RVA = "0x2AB10", Offset = "0x29F10")]
	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x20")]
	public int downSample;

	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x24")]
	public FilterMode filterMode;

	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x28")]
	private SkeletonAnimation skeletonAnimation;

	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x30")]
	private Camera m_Camera;

	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x38")]
	private CommandBuffer m_Buffer;

	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x40")]
	private Material m_DownSampleMat;

	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0x48")]
	private string startEventName;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A70")]
	private string endEventName;

	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x58")]
	private int m_ScreenId;

	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x5C")]
	private int m_ScreenId2;

	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x60")]
	private int m_TexId;

	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x64")]
	private int m_ObjectInfoId;

	[Address(RVA = "0x86E2C0", Offset = "0x86CAC0", Length = "0x47")]
	[Token(Token = "0x6000C05")]
	private void Awake()
	{
	}

	[Address(RVA = "0x86E510", Offset = "0x86CD10", Length = "0x655")]
	[Token(Token = "0x6000C06")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x86EB70", Offset = "0x86D370", Length = "0x229")]
	public void OnUpdateRenderInfo()
	{
	}

	[Address(RVA = "0x86E3B0", Offset = "0x86CBB0", Length = "0x159")]
	[Token(Token = "0x6000C08")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x86EDA0", Offset = "0x86D5A0", Length = "0x162")]
	[Token(Token = "0x6000C09")]
	public void Refresh()
	{
	}

	[Address(RVA = "0x86E310", Offset = "0x86CB10", Length = "0x99")]
	[Token(Token = "0x6000C0A")]
	private void HandleSpineEvent(TrackEntry trackEntry, Spine.Event e)
	{
	}

	[Address(RVA = "0x86EF10", Offset = "0x86D710", Length = "0xAB")]
	[Token(Token = "0x6000C0B")]
	public OldTvSample()
	{
	}
}
