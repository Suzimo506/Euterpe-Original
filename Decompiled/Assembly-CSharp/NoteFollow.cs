using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

[Token(Token = "0x2000058")]
public class NoteFollow : MonoBehaviour, IFastPoolItem, IPause
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000213")]
	private ParticleSystem[] particles;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000214")]
	public float duration;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x24")]
	public float m_Progress;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve animCurve;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x30")]
	private Action m_Callback;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x38")]
	public float speed;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000219")]
	private SkeletonAnimation m_Skeleton;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 m_TargetPosition;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x54")]
	private float m_Tick;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_Distance;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400021D")]
	private Transform m_TargetTransform;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400021E")]
	private SkeletonRendererCustomMaterials m_CustomMaterials;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x78")]
	public double InvokeDistance;

	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x80")]
	private bool isPause;

	[Token(Token = "0x1700004C")]
	public Vector3 targetPosition
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x86DB40", Offset = "0x86C340", Length = "0x13")]
		get
		{
			return default(Vector3);
		}
		[Address(RVA = "0x86DB70", Offset = "0x86C370", Length = "0x10")]
		[Token(Token = "0x600029F")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public bool IsGlobal
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x5B7330", Offset = "0x5B5B30", Length = "0x8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002AB")]
		[CompilerGenerated]
		[Address(RVA = "0x86DB60", Offset = "0x86C360", Length = "0x7")]
		private set
		{
		}
	}

	[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
	[Token(Token = "0x600029D")]
	public void SetCallback(Action callback)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x86DA00", Offset = "0x86C200", Length = "0xE4")]
	private void UpdateDistance()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x86D180", Offset = "0x86B980", Length = "0x123")]
	public void Awake()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x86D3E0", Offset = "0x86BBE0", Length = "0xB4")]
	public void OnEnable()
	{
	}

	[Address(RVA = "0x86D320", Offset = "0x86BB20", Length = "0xB4")]
	[Token(Token = "0x60002A3")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x86DAF0", Offset = "0x86C2F0", Length = "0x11")]
	private void Update()
	{
	}

	[Address(RVA = "0x86D4A0", Offset = "0x86BCA0", Length = "0x9E")]
	[Token(Token = "0x60002A5")]
	private void ResetField()
	{
	}

	[Address(RVA = "0x86D2B0", Offset = "0x86BAB0", Length = "0x68")]
	[Token(Token = "0x60002A6")]
	public void Init(Vector3 startPosition, Transform targeTransform)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x86D540", Offset = "0x86BD40", Length = "0x394")]
	private void OnUpdate()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnFastInstantiate()
	{
	}

	[Address(RVA = "0x86D4A0", Offset = "0x86BCA0", Length = "0x9E")]
	[Token(Token = "0x60002A9")]
	public void OnFastDestroy()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x86D8E0", Offset = "0x86C0E0", Length = "0x85")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x86D970", Offset = "0x86C170", Length = "0x85")]
	[Token(Token = "0x60002AD")]
	public void Resume()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x86DB10", Offset = "0x86C310", Length = "0x23")]
	public NoteFollow()
	{
	}
}
