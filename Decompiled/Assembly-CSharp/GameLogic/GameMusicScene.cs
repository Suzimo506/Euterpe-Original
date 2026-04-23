using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.UI.GameMain;
using Cpp2ILInjected;
using DYUnityLib;
using GameCore.GameObjectLogics.GameObjectManager._2025FoolActivity;
using Spine.Unity;
using UnityEngine;

namespace GameLogic;

[Token(Token = "0x2000497")]
public class GameMusicScene : IPause
{
	[Token(Token = "0x2000B50")]
	private struct Node
	{
		[Token(Token = "0x40039ED")]
		[FieldOffset(Offset = "0x0")]
		public Transform current;

		[Token(Token = "0x40039EE")]
		[FieldOffset(Offset = "0x8")]
		public int currentId;

		[Token(Token = "0x40039EF")]
		[FieldOffset(Offset = "0xC")]
		public int countOfThisLine;
	}

	[Token(Token = "0x40018E2")]
	[FieldOffset(Offset = "0x10")]
	public FoolQaActManager qaActManager;

	[Token(Token = "0x40018E3")]
	[FieldOffset(Offset = "0x18")]
	public FixUpdateTimer stepTimer;

	[Token(Token = "0x40018E4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] preloads;

	[Token(Token = "0x40018E5")]
	[FieldOffset(Offset = "0x28")]
	public NodeInitController[] nodeInitCtrls;

	[Token(Token = "0x40018E6")]
	[FieldOffset(Offset = "0x30")]
	public SpineActionController[] spineActionCtrls;

	[Token(Token = "0x40018E7")]
	[FieldOffset(Offset = "0x38")]
	public BaseSpineObjectController[] objCtrls;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018E8")]
	public Animator[] animators;

	[Token(Token = "0x40018E9")]
	[FieldOffset(Offset = "0x48")]
	public SkeletonAnimation[] animations;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018EA")]
	public SpineMountController[] spineMountCtrls;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40018EB")]
	public List<GameObject>[] preloads1;

	[Token(Token = "0x40018EC")]
	[FieldOffset(Offset = "0x60")]
	public List<NodeInitController>[] nodeInitCtrls1;

	[Token(Token = "0x40018ED")]
	[FieldOffset(Offset = "0x68")]
	public List<SpineActionController>[] spineActionCtrls1;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40018EE")]
	public List<BaseSpineObjectController>[] objCtrls1;

	[Token(Token = "0x40018EF")]
	[FieldOffset(Offset = "0x78")]
	public List<Animator>[] animators1;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40018F0")]
	public List<SkeletonAnimation>[] animations1;

	[Token(Token = "0x40018F1")]
	[FieldOffset(Offset = "0x88")]
	public List<SpineMountController>[] spineMountCtrls1;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40018F2")]
	public List<bool>[] showEffects;

	[Token(Token = "0x40018F3")]
	[FieldOffset(Offset = "0x98")]
	public bool firstIn;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40018F5")]
	public List<GameObject> scenes;

	[Token(Token = "0x40018F6")]
	[FieldOffset(Offset = "0xB0")]
	public Dictionary<string, Animator[]> scenesAnimas;

	[Token(Token = "0x40018F7")]
	[FieldOffset(Offset = "0xB8")]
	public string curSceneName;

	[Token(Token = "0x40018F8")]
	private static GameObject sceneChangeObj;

	[Token(Token = "0x40018F9")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<int, SceneSubControl> m_SceneSubControls;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40018FD")]
	private Color m_GroundCatchCircleColor;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40018FE")]
	private Color m_GroundCatchCircle2Color;

	[Token(Token = "0x40018FF")]
	[FieldOffset(Offset = "0x100")]
	private Color m_AirCatchCircleColor;

	[Token(Token = "0x4001900")]
	[FieldOffset(Offset = "0x110")]
	private Color m_AirCatchCircle2Color;

	[Token(Token = "0x4001901")]
	[FieldOffset(Offset = "0x120")]
	public int passIdx;

	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x124")]
	public int prePassIdx;

	[Token(Token = "0x170004BD")]
	public static GameMusicScene instance
	{
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x900030", Offset = "0x8FE830", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004BE")]
	public GameObject scene
	{
		[Address(RVA = "0x48E690", Offset = "0x48CE90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6003482")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x49A960", Offset = "0x499160", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x170004BF")]
	public Dictionary<int, SceneSubControl> SceneSubCtrls
	{
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x49A8D0", Offset = "0x4990D0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004C0")]
	public Material catchMaterial
	{
		[CompilerGenerated]
		[Address(RVA = "0x460220", Offset = "0x45EA20", Length = "0x8")]
		[Token(Token = "0x6003485")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x49A9C0", Offset = "0x4991C0", Length = "0xF")]
		[Token(Token = "0x6003484")]
		private set
		{
		}
	}

	[Token(Token = "0x170004C1")]
	public Sprite catchGroundSprite
	{
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x49A8C0", Offset = "0x4990C0", Length = "0x8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003486")]
		[CompilerGenerated]
		[Address(RVA = "0x49A9A0", Offset = "0x4991A0", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x170004C2")]
	public Sprite catchAirSprite
	{
		[Token(Token = "0x6003489")]
		[CompilerGenerated]
		[Address(RVA = "0x49A8A0", Offset = "0x4990A0", Length = "0x8")]
		get
		{
			return null;
		}
		[Address(RVA = "0x49A980", Offset = "0x499180", Length = "0xF")]
		[Token(Token = "0x6003488")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170004C3")]
	public Color groundCatchCircleColor
	{
		[Address(RVA = "0x900020", Offset = "0x8FE820", Length = "0xE")]
		[Token(Token = "0x600348B")]
		get
		{
			return default(Color);
		}
		[Address(RVA = "0x9000C0", Offset = "0x8FE8C0", Length = "0xB")]
		[Token(Token = "0x600348A")]
		private set
		{
		}
	}

	[Token(Token = "0x170004C4")]
	public Color groundCatchCircle2Color
	{
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x900010", Offset = "0x8FE810", Length = "0xE")]
		get
		{
			return default(Color);
		}
		[Address(RVA = "0x9000B0", Offset = "0x8FE8B0", Length = "0xB")]
		[Token(Token = "0x600348C")]
		private set
		{
		}
	}

	[Token(Token = "0x170004C5")]
	public Color airCatchCircleColor
	{
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x900000", Offset = "0x8FE800", Length = "0xE")]
		get
		{
			return default(Color);
		}
		[Address(RVA = "0x9000A0", Offset = "0x8FE8A0", Length = "0xB")]
		[Token(Token = "0x600348E")]
		private set
		{
		}
	}

	[Token(Token = "0x170004C6")]
	public Color airCatchCircle2Color
	{
		[Address(RVA = "0x8FFFF0", Offset = "0x8FE7F0", Length = "0xE")]
		[Token(Token = "0x6003491")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x900090", Offset = "0x8FE890", Length = "0xB")]
		private set
		{
		}
	}

	[Token(Token = "0x170004C7")]
	public GameObject SecneObject
	{
		[Token(Token = "0x6003492")]
		[Address(RVA = "0x8FFFA0", Offset = "0x8FE7A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004C8")]
	public bool IsGlobal
	{
		[Token(Token = "0x60034B2")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x8FAD30", Offset = "0x8F9530", Length = "0x3C")]
	[Token(Token = "0x6003493")]
	public GameObject GetPreloads(int index)
	{
		return null;
	}

	[Address(RVA = "0x8FAC50", Offset = "0x8F9450", Length = "0x41")]
	[Token(Token = "0x6003494")]
	public Animator GetAnimator(int index)
	{
		return null;
	}

	[Token(Token = "0x6003495")]
	[Address(RVA = "0x8FED40", Offset = "0x8FD540", Length = "0xE5")]
	public void ReleaseReferences()
	{
	}

	[Address(RVA = "0x8FACA0", Offset = "0x8F94A0", Length = "0x46")]
	[Token(Token = "0x6003496")]
	public BaseSpineObjectController GetObjCtrl(int index)
	{
		return null;
	}

	[Address(RVA = "0x8FAD70", Offset = "0x8F9570", Length = "0x46")]
	[Token(Token = "0x6003497")]
	public SpineActionController GetSpineCtrl(int index)
	{
		return null;
	}

	[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
	[Token(Token = "0x6003498")]
	public void SetTimer(FixUpdateTimer timer)
	{
	}

	[Address(RVA = "0x8FF540", Offset = "0x8FDD40", Length = "0xCE")]
	[Token(Token = "0x6003499")]
	public void Run()
	{
	}

	[Token(Token = "0x600349A")]
	[Address(RVA = "0x8FFF20", Offset = "0x8FE720", Length = "0x6A")]
	public void Stop()
	{
	}

	[Address(RVA = "0x8FF380", Offset = "0x8FDB80", Length = "0x1BE")]
	[Token(Token = "0x600349B")]
	public void ResetTimer()
	{
	}

	[Address(RVA = "0x8FBAE0", Offset = "0x8FA2E0", Length = "0x30A")]
	[Token(Token = "0x600349C")]
	public void LoadScene(string sceneName)
	{
	}

	[Token(Token = "0x600349D")]
	[Address(RVA = "0x8FC550", Offset = "0x8FAD50", Length = "0x2FE")]
	private void PreLoadExtraObjs()
	{
	}

	[Address(RVA = "0x8FFC40", Offset = "0x8FE440", Length = "0x2D0")]
	[Token(Token = "0x600349E")]
	private void SetGameBrightnessColor()
	{
	}

	[Address(RVA = "0x8FEE30", Offset = "0x8FD630", Length = "0x54A")]
	[Token(Token = "0x600349F")]
	public void ReplaceEnemy(int idx, int curScene)
	{
	}

	[Token(Token = "0x60034A0")]
	[Address(RVA = "0x8FF850", Offset = "0x8FE050", Length = "0x1E7")]
	private string SceneFestival(string sceneFestivalName)
	{
		return null;
	}

	[Token(Token = "0x60034A1")]
	[Address(RVA = "0x8FF610", Offset = "0x8FDE10", Length = "0x23D")]
	public void SceneEventTrigger(decimal tick)
	{
	}

	[Token(Token = "0x60034A2")]
	[Address(RVA = "0x8FAA40", Offset = "0x8F9240", Length = "0x202")]
	private void DialogEventTrigger(decimal tick)
	{
	}

	[Address(RVA = "0x8FA760", Offset = "0x8F8F60", Length = "0x2D3")]
	[Token(Token = "0x60034A3")]
	public void AddObjTrigger(decimal genTick)
	{
	}

	[Address(RVA = "0x8FACF0", Offset = "0x8F94F0", Length = "0x3E")]
	[Token(Token = "0x60034A4")]
	public GameObject GetPreLoadGameObject(int idx)
	{
		return null;
	}

	[Address(RVA = "0x8FC850", Offset = "0x8FB050", Length = "0x9C7")]
	[Token(Token = "0x60034A5")]
	public GameObject PreLoad(int idx)
	{
		return null;
	}

	[Address(RVA = "0x8FB9B0", Offset = "0x8FA1B0", Length = "0x12B")]
	[Token(Token = "0x60034A6")]
	private bool IsIgnoreCurrentNoteChecking(int curScene, string notePrefabName)
	{
		return default(bool);
	}

	[Address(RVA = "0x8FE220", Offset = "0x8FCA20", Length = "0xB1F")]
	[Token(Token = "0x60034A7")]
	private GameObject PreloadTmpGameObject(GameObject go, MusicData md, int curScene)
	{
		return null;
	}

	[Address(RVA = "0x8FD220", Offset = "0x8FBA20", Length = "0xFFD")]
	[Token(Token = "0x60034A8")]
	private GameObject PreloadGameObject(GameObject preObj, MusicData md, int curScene, bool hasSceneChange)
	{
		return null;
	}

	[Address(RVA = "0x8FBDF0", Offset = "0x8FA5F0", Length = "0x753")]
	[Token(Token = "0x60034A9")]
	private void PreLoadEnemy()
	{
	}

	[Token(Token = "0x60034AA")]
	[Address(RVA = "0x8FB330", Offset = "0x8F9B30", Length = "0x358")]
	private void InitSceneObject(string name, bool isActive = false)
	{
	}

	[Token(Token = "0x60034AB")]
	[Address(RVA = "0x8FB690", Offset = "0x8F9E90", Length = "0x31E")]
	private void InitTimer(decimal total)
	{
	}

	[Token(Token = "0x60034AC")]
	[Address(RVA = "0x8FB0E0", Offset = "0x8F98E0", Length = "0x240")]
	private void InitSceneEvents()
	{
	}

	[Address(RVA = "0x8FADC0", Offset = "0x8F95C0", Length = "0x19F")]
	[Token(Token = "0x60034AD")]
	private void InitDialogEvent()
	{
	}

	[Token(Token = "0x60034AE")]
	[Address(RVA = "0x8FAF60", Offset = "0x8F9760", Length = "0x17A")]
	private void InitEventTrigger()
	{
	}

	[Address(RVA = "0x8FFA40", Offset = "0x8FE240", Length = "0x1FC")]
	[Token(Token = "0x60034AF")]
	public void SetBgFreeze(bool freeze)
	{
	}

	[Token(Token = "0x60034B0")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x60034B1")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void Resume()
	{
	}

	[Token(Token = "0x60034B3")]
	[Address(RVA = "0x8FFF90", Offset = "0x8FE790", Length = "0xE")]
	public GameMusicScene()
	{
	}
}
