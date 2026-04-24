using System.Collections;
using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000476")]
public class PirateGirlManager : GeneralGirlManager
{
	[Token(Token = "0x400181A")]
	private const string pirate_long_press_vfx = "char_1_pirate_vfx_pressing";

	[Token(Token = "0x400181B")]
	private const string pirate_long_press_sk_anima_start_state = "press_star";

	[Token(Token = "0x400181C")]
	private const string pirate_long_press_sk_anima_pressing_state = "press_standby";

	[Token(Token = "0x400181D")]
	private const string pirate_long_press_sk_anima_end_state = "press_end";

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400181E")]
	private bool m_IsSkillInvalidate;

	[Token(Token = "0x400181F")]
	[FieldOffset(Offset = "0xA0")]
	private LongPressEffectData[] m_LongPressingVfxes;

	[Token(Token = "0x600334B")]
	[Address(RVA = "0x90A7F0", Offset = "0x908FF0", Length = "0xC6")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x90AC60", Offset = "0x909460", Length = "0x2E")]
	[Token(Token = "0x600334C")]
	public override void InstanceGirl()
	{
	}

	[Address(RVA = "0x90AC90", Offset = "0x909490", Length = "0x358")]
	[Token(Token = "0x600334D")]
	public void ShowPirateLongPressEffect(bool isPressHeadOrEnd, bool isAir)
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E400", Offset = "0x3D800")]
	[Address(RVA = "0x90A780", Offset = "0x908F80", Length = "0x65")]
	[Token(Token = "0x600334E")]
	protected override IEnumerator AfterComeOut()
	{
		return null;
	}

	[Address(RVA = "0x90ABC0", Offset = "0x9093C0", Length = "0x94")]
	[Token(Token = "0x600334F")]
	public override void Dead()
	{
	}

	[Address(RVA = "0x90A8C0", Offset = "0x9090C0", Length = "0x2FD")]
	[Token(Token = "0x6003350")]
	private void CreateSpecialLongPressFireVfx()
	{
	}

	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	[Token(Token = "0x6003351")]
	public PirateGirlManager()
	{
	}
}
