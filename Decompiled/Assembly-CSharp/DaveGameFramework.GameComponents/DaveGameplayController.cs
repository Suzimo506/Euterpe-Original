using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DaveGameFramework.GameActivedObjects;
using DaveGameFramework.GameComponents.AnimaControl;
using DaveGameFramework.Interfaces;
using MEC;
using UnityEngine;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C7")]
public class DaveGameplayController : MonoBehaviour, IUpdateController
{
	[Token(Token = "0x4001A06")]
	public static readonly string turnOnSound;

	[Token(Token = "0x4001A07")]
	public static readonly string hitSound;

	[Token(Token = "0x4001A08")]
	public static readonly string hitSoundHeavyReady;

	[Token(Token = "0x4001A09")]
	public static readonly string hitSoundHeavy;

	[Token(Token = "0x4001A0A")]
	public static readonly string emptyHitSound;

	[Token(Token = "0x4001A0B")]
	public static readonly string readySound;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A0C")]
	[SerializeField]
	private DaveGameAnimationController m_AnimationController;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A0D")]
	[SerializeField]
	private DaveGameHUDController m_HUDController;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A0E")]
	private Stopwatch m_Stopwatch;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A0F")]
	private DaveGameManager m_DaveGameManager;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A10")]
	private List<DaveGameNote> m_GameNotes;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A11")]
	private float m_BgmLength;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001A12")]
	private CoroutineHandle m_ResultHandle;

	[Token(Token = "0x170004F3")]
	public float CurGameTime
	{
		[Address(RVA = "0x99D290", Offset = "0x99BA90", Length = "0x33")]
		[Token(Token = "0x6003598")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170004F4")]
	public float GameProgress
	{
		[Token(Token = "0x6003599")]
		[Address(RVA = "0x99D2D0", Offset = "0x99BAD0", Length = "0x4D")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170004F5")]
	public DaveGameAnimationController AnimationController
	{
		[Token(Token = "0x600359A")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F6")]
	public DaveGameHUDController HUDController
	{
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600359C")]
	[Address(RVA = "0x99A870", Offset = "0x999070", Length = "0x9C")]
	public void AwakeInit()
	{
	}

	[Address(RVA = "0x99BC90", Offset = "0x99A490", Length = "0x308")]
	[Token(Token = "0x600359D")]
	public void PreloadSceneObjs()
	{
	}

	[Address(RVA = "0x99ABD0", Offset = "0x9993D0", Length = "0x16A")]
	[Token(Token = "0x600359E")]
	public void EnterGameScene()
	{
	}

	[Address(RVA = "0x99CB20", Offset = "0x99B320", Length = "0x1EB")]
	[Token(Token = "0x600359F")]
	public void StartGame()
	{
	}

	[Address(RVA = "0x99BFA0", Offset = "0x99A7A0", Length = "0x2ED")]
	[Token(Token = "0x60035A0")]
	public void ResetGame()
	{
	}

	[Token(Token = "0x60035A1")]
	[Address(RVA = "0x99BB00", Offset = "0x99A300", Length = "0x180")]
	public void PauseGame()
	{
	}

	[Address(RVA = "0x99C990", Offset = "0x99B190", Length = "0x18F")]
	[Token(Token = "0x60035A2")]
	public void ResumeGame()
	{
	}

	[Token(Token = "0x60035A3")]
	[Address(RVA = "0x99C290", Offset = "0x99AA90", Length = "0x1D3")]
	public void ResultGame(bool result)
	{
	}

	[Token(Token = "0x60035A4")]
	[Address(RVA = "0x99AD40", Offset = "0x999540", Length = "0xB7")]
	public void ExitGame()
	{
	}

	[Token(Token = "0x60035A5")]
	[Address(RVA = "0x99B7E0", Offset = "0x999FE0", Length = "0x31E")]
	public void OnUpdate()
	{
	}

	[Token(Token = "0x60035A6")]
	[Address(RVA = "0x99AEA0", Offset = "0x9996A0", Length = "0x93C")]
	public void OnFixedUpdate()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60035A7")]
	public void OnLateUpdate()
	{
	}

	[Address(RVA = "0x99C470", Offset = "0x99AC70", Length = "0x512")]
	[Token(Token = "0x60035A8")]
	private void ResultGame()
	{
	}

	[Address(RVA = "0x99A9B0", Offset = "0x9991B0", Length = "0x21F")]
	[Token(Token = "0x60035A9")]
	private void DoStageAchievement()
	{
	}

	[Token(Token = "0x60035AA")]
	[Address(RVA = "0x99AE00", Offset = "0x999600", Length = "0x99")]
	private void OnExitedComplete()
	{
	}

	[Address(RVA = "0x99A910", Offset = "0x999110", Length = "0x97")]
	[Token(Token = "0x60035AB")]
	private void CreateNoteInstances()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60035AC")]
	public DaveGameplayController()
	{
	}
}
