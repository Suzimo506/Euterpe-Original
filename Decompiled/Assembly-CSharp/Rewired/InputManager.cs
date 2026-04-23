using Cpp2ILInjected;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired;

[Token(Token = "0x20001ED")]
[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x65D30", Offset = "0x65130")]
[Attribute(Name = "AddComponentMenu", RVA = "0x65D30", Offset = "0x65130")]
public sealed class InputManager : InputManager_Base
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D71")]
	private bool ignoreRecompile;

	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0xF99630", Offset = "0xF97E30", Length = "0x8C")]
	protected override void OnInitialized()
	{
	}

	[Address(RVA = "0xF99620", Offset = "0xF97E20", Length = "0x7")]
	[Token(Token = "0x6000FC1")]
	protected override void OnDeinitialized()
	{
	}

	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0xF99570", Offset = "0xF97D70", Length = "0x5D")]
	protected override void DetectPlatform()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000FC3")]
	protected override void CheckRecompile()
	{
	}

	[Address(RVA = "0xF995D0", Offset = "0xF97DD0", Length = "0x43")]
	[Token(Token = "0x6000FC4")]
	protected override IExternalTools GetExternalTools()
	{
		return null;
	}

	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0xF994B0", Offset = "0xF97CB0", Length = "0xB8")]
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0xF99630", Offset = "0xF97E30", Length = "0x8C")]
	private void SubscribeEvents()
	{
	}

	[Address(RVA = "0xF996D0", Offset = "0xF97ED0", Length = "0x82")]
	[Token(Token = "0x6000FC7")]
	private void UnsubscribeEvents()
	{
	}

	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0xF996C0", Offset = "0xF97EC0", Length = "0x7")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Address(RVA = "0xF99760", Offset = "0xF97F60", Length = "0x7")]
	[Token(Token = "0x6000FC9")]
	public InputManager()
	{
	}
}
