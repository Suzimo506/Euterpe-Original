using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B3")]
public class GameSceneContainer : SingletonMonoBehaviour<GameSceneContainer>
{
	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x18")]
	public Camera mainCamera;

	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject girlLayer;

	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject bossLayer;

	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject elfinLayer;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004A7")]
	public DialogMasterControl dialogMaster;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004A8")]
	public SpriteRenderer sprLightness;

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x5BE350", Offset = "0x5BCB50", Length = "0x38")]
	public GameSceneContainer()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
