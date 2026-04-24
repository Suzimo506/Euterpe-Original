using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000012")]
public class SceneObjectController : SingletonMonoBehaviour<SceneObjectController>
{
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x18")]
	private int idx;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000039")]
	private int timeEventIndex;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x20")]
	private float runtime;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400003B")]
	private StageEvent eventData;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x40")]
	private Hashtable sceneObjectPool;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400003D")]
	private AudioSource sceneAudio;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> dymObjectList;

	[Token(Token = "0x17000007")]
	public Hashtable SceneObjectPool
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6000037")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x627980", Offset = "0x626180", Length = "0x5FF")]
	[Token(Token = "0x6000038")]
	public void TimerStepTrigger(object sender, uint triggerId, params object[] args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x627730", Offset = "0x625F30", Length = "0x159")]
	public void InitController(int idx, string audioLayerName = "BossLayer")
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x627960", Offset = "0x626160", Length = "0x18")]
	public void Run()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600003B")]
	public void PreLoad()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x627180", Offset = "0x625980", Length = "0x1D7")]
	public void DoObjectComeoutEvent(string nodeId)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x627360", Offset = "0x625B60", Length = "0x1DC")]
	public void DoObjectOnAttackedEvent(string nodeId)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x627540", Offset = "0x625D40", Length = "0x1E1")]
	public void DoObjectOnMissedEvent(string nodeId)
	{
	}

	[Address(RVA = "0x44A090", Offset = "0x448890", Length = "0x6")]
	[Token(Token = "0x600003F")]
	public float GetRunTime()
	{
		return default(float);
	}

	[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
	[Token(Token = "0x6000040")]
	public AudioSource GetAudioSource()
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
	public List<GameObject> GetAllSceneEventObjects()
	{
		return null;
	}

	[Address(RVA = "0x6270E0", Offset = "0x6258E0", Length = "0x9C")]
	[Token(Token = "0x6000042")]
	public void ActiveObject(int idx)
	{
	}

	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	[Token(Token = "0x6000043")]
	private GameObject CreateObj(GameObject sourceObject)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x627890", Offset = "0x626090", Length = "0xCC")]
	private void ResetParticle(GameObject sceneObject)
	{
	}

	[Address(RVA = "0x627F80", Offset = "0x626780", Length = "0x38")]
	[Token(Token = "0x6000045")]
	public SceneObjectController()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
