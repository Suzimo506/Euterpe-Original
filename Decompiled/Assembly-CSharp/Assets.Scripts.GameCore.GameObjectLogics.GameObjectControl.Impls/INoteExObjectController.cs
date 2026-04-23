using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl.Impls;

[Token(Token = "0x2000767")]
public interface INoteExObjectController
{
	[Token(Token = "0x600457B")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Init();

	[Token(Token = "0x600457C")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnAppear();

	[Token(Token = "0x600457D")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnDisappear();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600457E")]
	void OnNoteBeAttacked(int noteHitResult);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600457F")]
	void OnNoteMissed();

	[Token(Token = "0x6004580")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnPause();

	[Token(Token = "0x6004581")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnResume();

	[Token(Token = "0x6004582")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Release();
}
