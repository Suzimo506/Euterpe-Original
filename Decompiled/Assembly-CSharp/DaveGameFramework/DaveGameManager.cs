using System.Collections;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using DaveGameFramework.GameActivedObjects;
using DaveGameFramework.GameComponents;
using DaveGameFramework.GameInstanceData;
using DaveGameFramework.Interfaces;
using UnityEngine;

namespace DaveGameFramework;

[Token(Token = "0x20004B9")]
[Attribute(Name = "RequireComponent", RVA = "0x57080", Offset = "0x56480")]
public class DaveGameManager : MonoBehaviour
{
	[Token(Token = "0x40019C6")]
	private static DaveGameManager s_Instance;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019C7")]
	public DaveGameManager_ScenePresets scenePresets;

	[Token(Token = "0x40019C8")]
	[FieldOffset(Offset = "0x20")]
	private List<IUpdateController> m_UpdateCtrls;

	[Token(Token = "0x40019C9")]
	[FieldOffset(Offset = "0x28")]
	private DaveGameplayController m_GameplayController;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019CA")]
	private DaveGameStateController m_GameStateController;

	[Token(Token = "0x40019CB")]
	[FieldOffset(Offset = "0x38")]
	private DaveMusicConfigReader m_MusicConfigReader;

	[Token(Token = "0x40019CC")]
	[FieldOffset(Offset = "0x40")]
	private DaveGameAudioController m_AudioController;

	[Token(Token = "0x40019CD")]
	[FieldOffset(Offset = "0x48")]
	private BaseInputComponent m_InputComponent;

	[Token(Token = "0x40019CE")]
	[FieldOffset(Offset = "0x50")]
	private Queue<DaveGameJudgedNote> m_JudgeNoteQueue;

	[Token(Token = "0x40019CF")]
	[FieldOffset(Offset = "0x58")]
	private Queue<DaveGameBehaviourNote> m_BehaviourNoteQueue;

	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0x60")]
	private bool m_SceneIsLoading;

	[Token(Token = "0x40019D1")]
	[FieldOffset(Offset = "0x68")]
	private StringBuilder m_Sb;

	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0x70")]
	private GUIStyle m_Style;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40019D3")]
	private bool m_ShowDebugInfo;

	[Token(Token = "0x40019D4")]
	private static DaveGameSoConfig s_SoConfig;

	[Token(Token = "0x170004DE")]
	public static DaveGameManager Instance
	{
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x46EF40", Offset = "0x46D740", Length = "0x35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DF")]
	public BaseInputComponent InputComponent
	{
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E0")]
	public DaveGameplayController GameplayController
	{
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E1")]
	public DaveGameStateController GameStateController
	{
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[Token(Token = "0x6003551")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E2")]
	public DaveMusicConfigReader MusicConfigReader
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x6003552")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E3")]
	public Queue<DaveGameJudgedNote> JudgeNoteQueue
	{
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		[Token(Token = "0x6003553")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E4")]
	public Queue<DaveGameBehaviourNote> BehaviourNoteQueue
	{
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E5")]
	public DaveGameAudioController AudioController
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6003555")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E6")]
	public static DaveGameSoConfig SoConfig
	{
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x46EF90", Offset = "0x46D790", Length = "0x36")]
		get
		{
			return null;
		}
		[Address(RVA = "0x46EFD0", Offset = "0x46D7D0", Length = "0xC4")]
		[Token(Token = "0x6003558")]
		private set
		{
		}
	}

	[Token(Token = "0x6003556")]
	[Address(RVA = "0x46E760", Offset = "0x46CF60", Length = "0x150")]
	public static bool IsDaveMmg()
	{
		return default(bool);
	}

	[Address(RVA = "0x46EB30", Offset = "0x46D330", Length = "0x6F")]
	[Token(Token = "0x6003559")]
	public void RegisterUpdateCtrl(IUpdateController updateCtrl)
	{
	}

	[Address(RVA = "0x46EBA0", Offset = "0x46D3A0", Length = "0xEC")]
	[Token(Token = "0x600355A")]
	public void ResetGameData()
	{
	}

	[Address(RVA = "0x46E350", Offset = "0x46CB50", Length = "0x2AC")]
	[Token(Token = "0x600355B")]
	private void Awake()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x573F0", Offset = "0x567F0")]
	[Token(Token = "0x600355C")]
	[Address(RVA = "0x46EC90", Offset = "0x46D490", Length = "0x65")]
	private IEnumerator Start()
	{
		return null;
	}

	[Address(RVA = "0x46ED60", Offset = "0x46D560", Length = "0x14C")]
	[Token(Token = "0x600355D")]
	private void Update()
	{
	}

	[Address(RVA = "0x46E600", Offset = "0x46CE00", Length = "0x151")]
	[Token(Token = "0x600355E")]
	private void FixedUpdate()
	{
	}

	[Address(RVA = "0x46E8C0", Offset = "0x46D0C0", Length = "0x152")]
	[Token(Token = "0x600355F")]
	private void LateUpdate()
	{
	}

	[Address(RVA = "0x46EA20", Offset = "0x46D220", Length = "0x108")]
	[Token(Token = "0x6003560")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003561")]
	[Address(RVA = "0x46EEB0", Offset = "0x46D6B0", Length = "0x64")]
	public DaveGameManager()
	{
	}
}
