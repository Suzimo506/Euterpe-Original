using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using GameLogic;
using Sirenix.OdinInspector;

namespace Assets.Scripts.GameCore;

[Token(Token = "0x20006FA")]
public class StageInfo : SerializedScriptableObject
{
	[Token(Token = "0x400257E")]
	[FieldOffset(Offset = "0x58")]
	public List<MusicData> musicDatas;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400257F")]
	public decimal delay;

	[Token(Token = "0x4002580")]
	[FieldOffset(Offset = "0x70")]
	public string mapName;

	[Token(Token = "0x4002581")]
	[FieldOffset(Offset = "0x78")]
	public string music;

	[Token(Token = "0x4002582")]
	[FieldOffset(Offset = "0x80")]
	public string scene;

	[Token(Token = "0x4002583")]
	[FieldOffset(Offset = "0x88")]
	public int difficulty;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002584")]
	public string md5;

	[Token(Token = "0x4002585")]
	[FieldOffset(Offset = "0x98")]
	public float bpm;

	[Token(Token = "0x4002586")]
	[FieldOffset(Offset = "0xA0")]
	public List<SceneEvent> sceneEvents;

	[Token(Token = "0x4002587")]
	[FieldOffset(Offset = "0xA8")]
	public Dictionary<string, List<GameDialogArgs>> dialogEvents;

	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	[Token(Token = "0x60041B8")]
	public StageInfo()
	{
	}
}
