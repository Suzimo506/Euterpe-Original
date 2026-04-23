using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000748")]
public class NoteDataMananger : SingletonScriptableObject<NoteDataMananger>
{
	[Token(Token = "0x4002688")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<NoteConfigData> m_NoteDatas;

	[Token(Token = "0x17000669")]
	public List<NoteConfigData> noteDatas
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[Token(Token = "0x6004435")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x6DC080", Offset = "0x6DA880", Length = "0x2B9")]
	[Token(Token = "0x6004436")]
	public NoteConfigData GetMirrorNoteByUidPathway(string uid, int pathway)
	{
		return default(NoteConfigData);
	}

	[Token(Token = "0x6004437")]
	[Address(RVA = "0x6DC340", Offset = "0x6DAB40", Length = "0x265")]
	public NoteConfigData GetNoteByUid(string uid)
	{
		return default(NoteConfigData);
	}

	[Token(Token = "0x6004438")]
	[Address(RVA = "0x6DC5B0", Offset = "0x6DADB0", Length = "0x99")]
	private void Init()
	{
	}

	[Token(Token = "0x6004439")]
	[Address(RVA = "0x6DC650", Offset = "0x6DAE50", Length = "0x6E")]
	public NoteDataMananger()
	{
		((SingletonScriptableObject<>)(object)this)._002Ector();
	}
}
