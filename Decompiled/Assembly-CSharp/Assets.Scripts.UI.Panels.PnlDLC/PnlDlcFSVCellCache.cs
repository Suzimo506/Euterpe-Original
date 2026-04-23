using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200093D")]
public class PnlDlcFSVCellCache : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000DB4")]
	public struct CellPrefabSettingNew
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4004086")]
		public int jsonIndex;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4004087")]
		public string prefabAddressableKey;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4004088")]
		public int cacheCount;
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40031F2")]
	private Transform m_Transform;

	[Token(Token = "0x40031F3")]
	[FieldOffset(Offset = "0x20")]
	private PnlDlc m_Parent;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40031F4")]
	private Dictionary<string, GameObject> assetCached;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40031F5")]
	private bool isActive;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40031F6")]
	[SerializeField]
	private List<CellPrefabSettingNew> m_CellPrefabSettingNew;

	[Token(Token = "0x40031F7")]
	[FieldOffset(Offset = "0x40")]
	private List<Transform> m_Cache;

	[Token(Token = "0x60053E5")]
	[Address(RVA = "0x824D90", Offset = "0x823590", Length = "0x208")]
	internal Transform GetCellCache(int albumJsonIndex, Transform parent)
	{
		return null;
	}

	[Address(RVA = "0x8252D0", Offset = "0x823AD0", Length = "0xC5")]
	[Token(Token = "0x60053E6")]
	internal void ReturnCellCache(Transform usedCell)
	{
	}

	[Address(RVA = "0x824B00", Offset = "0x823300", Length = "0x1FC")]
	[Token(Token = "0x60053E7")]
	private Transform CreateCellNew(string addressableKey)
	{
		return null;
	}

	[Token(Token = "0x60053E8")]
	[Address(RVA = "0x824A30", Offset = "0x823230", Length = "0xCA")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x94220", Offset = "0x93620")]
	public void CacheInit()
	{
	}

	[Token(Token = "0x60053E9")]
	[Address(RVA = "0x782BE0", Offset = "0x7813E0", Length = "0x5")]
	public void CacheRelease()
	{
	}

	[Address(RVA = "0x825190", Offset = "0x823990", Length = "0xB6")]
	[Token(Token = "0x60053EA")]
	private Task<GameObject> LoadToAssetCacheAsync(string assetName)
	{
		return null;
	}

	[Address(RVA = "0x8253A0", Offset = "0x823BA0", Length = "0x12E")]
	[Token(Token = "0x60053EB")]
	public void UnloadAllAssetCache()
	{
	}

	[Token(Token = "0x60053EC")]
	[Address(RVA = "0x824D00", Offset = "0x823500", Length = "0x8A")]
	private GameObject CreateCellSettingPrefab(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x60053ED")]
	[Address(RVA = "0x825250", Offset = "0x823A50", Length = "0x73")]
	private static void RenameCloneObject(GameObject tempObject)
	{
	}

	[Token(Token = "0x60053EE")]
	[Address(RVA = "0x824FA0", Offset = "0x8237A0", Length = "0x1E6")]
	private CellPrefabSettingNew GetCellSettingByJsonIndex(int albumJsonIndex)
	{
		return default(CellPrefabSettingNew);
	}

	[Address(RVA = "0x8254D0", Offset = "0x823CD0", Length = "0xC8")]
	[Token(Token = "0x60053EF")]
	public PnlDlcFSVCellCache()
	{
	}
}
