using System.Collections.Generic;
using Cpp2ILInjected;
using MEC;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground.DaveFishSwim;

[Token(Token = "0x2000848")]
public class DaveBgFishGroupManage : MonoBehaviour
{
	[Token(Token = "0x4002B39")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 boundOffsets;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002B3A")]
	public bool isAutoCreate;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4002B3B")]
	public Vector2 autoCreateDuration;

	[Token(Token = "0x4002B3C")]
	[FieldOffset(Offset = "0x2C")]
	public bool isForceCreate;

	[Token(Token = "0x4002B3D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] forceCreateObj;

	[Token(Token = "0x4002B3E")]
	[FieldOffset(Offset = "0x38")]
	private List<int> m_CacheFishUid;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002B3F")]
	private DaveFishDataModel m_DataModel;

	[Token(Token = "0x4002B40")]
	[FieldOffset(Offset = "0x48")]
	private Rect m_ScreenBounds;

	[Token(Token = "0x4002B41")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<int, Queue<DaveBgActiveObjs>> m_FishObjPool;

	[Token(Token = "0x4002B42")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<int, DaveFishCachedData> m_FishCache;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002B43")]
	private List<DaveBgActiveObjs> m_ActiveObjsList;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002B44")]
	private CoroutineHandle m_AutoCreateFishCoroutine;

	[Token(Token = "0x17000859")]
	public Rect FishActiveBounds
	{
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x60E270", Offset = "0x60CA70", Length = "0xB")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x6004C17")]
	[Address(RVA = "0x60D730", Offset = "0x60BF30", Length = "0x25C")]
	public void Init()
	{
	}

	[Token(Token = "0x6004C18")]
	[Address(RVA = "0x60DC80", Offset = "0x60C480", Length = "0xF2")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x60D990", Offset = "0x60C190", Length = "0x2C")]
	[Token(Token = "0x6004C19")]
	private void OnBackgroundSelectAndConfrim(int bgId)
	{
	}

	[Address(RVA = "0x60DE90", Offset = "0x60C690", Length = "0xCA")]
	[Token(Token = "0x6004C1A")]
	private void RefreshFishData()
	{
	}

	[Address(RVA = "0x60C850", Offset = "0x60B050", Length = "0xC1")]
	[Token(Token = "0x6004C1B")]
	public void AutoCreateFish()
	{
	}

	[Token(Token = "0x6004C1C")]
	[Address(RVA = "0x60E160", Offset = "0x60C960", Length = "0x53")]
	public void StopAutoCreateFish()
	{
	}

	[Token(Token = "0x6004C1D")]
	[Address(RVA = "0x60DF60", Offset = "0x60C760", Length = "0x1F4")]
	public void SpawnFish()
	{
	}

	[Token(Token = "0x6004C1E")]
	[Address(RVA = "0x60D460", Offset = "0x60BC60", Length = "0x2C5")]
	public void DeactiveFish()
	{
	}

	[Token(Token = "0x6004C1F")]
	[Address(RVA = "0x60CC00", Offset = "0x60B400", Length = "0x40E")]
	public void ClearFish()
	{
	}

	[Address(RVA = "0x60DD80", Offset = "0x60C580", Length = "0x101")]
	[Token(Token = "0x6004C20")]
	public void RecycleFish(DaveBgActiveObjs obj)
	{
	}

	[Address(RVA = "0x60D010", Offset = "0x60B810", Length = "0x1E1")]
	[Token(Token = "0x6004C21")]
	private DaveBgActiveObjs CreateFishInstanceTest()
	{
		return null;
	}

	[Address(RVA = "0x60D200", Offset = "0x60BA00", Length = "0x253")]
	[Token(Token = "0x6004C22")]
	private DaveBgActiveObjs CreateFishInstance(int fishUid)
	{
		return null;
	}

	[Token(Token = "0x6004C23")]
	[Address(RVA = "0x60DAE0", Offset = "0x60C2E0", Length = "0x53")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004C24")]
	[Address(RVA = "0x60D9C0", Offset = "0x60C1C0", Length = "0x116")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004C25")]
	[Address(RVA = "0x60C920", Offset = "0x60B120", Length = "0x2DE")]
	private void CalculateScreenBounds()
	{
	}

	[Token(Token = "0x6004C26")]
	[Address(RVA = "0x60DB40", Offset = "0x60C340", Length = "0x135")]
	private void OnDrawGizmos()
	{
	}

	[Address(RVA = "0x60E230", Offset = "0x60CA30", Length = "0x3E")]
	[Token(Token = "0x6004C27")]
	public DaveBgFishGroupManage()
	{
	}
}
