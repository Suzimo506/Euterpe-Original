using System.Runtime.InteropServices;
using Cpp2ILInjected;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000030")]
public struct ACTION_KEYS
{
	[Token(Token = "0x40000F3")]
	public const string NULL = "0";

	[Token(Token = "0x40000F4")]
	public const string COMEIN = "in";

	[Token(Token = "0x40000F5")]
	public const string COMEOUT = "out";

	[Token(Token = "0x40000F6")]
	public const string BLOCK_DESTROY = "note_destroy";

	[Token(Token = "0x40000F7")]
	public const string NEAR_ATTACK_1 = "boss_close_atk_1";

	[Token(Token = "0x40000F8")]
	public const string NEAR_ATTACK_2 = "boss_close_atk_2";

	[Token(Token = "0x40000F9")]
	public const string FAR_ATTACK1_START = "boss_far_atk_1_start";

	[Token(Token = "0x40000FA")]
	public const string FAR_ATTACK1_LEFT = "boss_far_atk_1_L";

	[Token(Token = "0x40000FB")]
	public const string FAR_ATTACK1_RIGHT = "boss_far_atk_1_R";

	[Token(Token = "0x40000FC")]
	public const string FAR_ATTACK1_END = "boss_far_atk_1_end";

	[Token(Token = "0x40000FD")]
	public const string FAR_ATTACK2_START = "boss_far_atk_2_start";

	[Token(Token = "0x40000FE")]
	public const string FAR_ATTACK2 = "boss_far_atk_2";

	[Token(Token = "0x40000FF")]
	public const string FAR_ATTACK2_END = "boss_far_atk_2_end";

	[Token(Token = "0x4000100")]
	public const string BOSS_ATK_1_TO_2 = "atk_1_to_2";

	[Token(Token = "0x4000101")]
	public const string BOSS_ATK_2_TO_1 = "atk_2_to_1";

	[Token(Token = "0x4000102")]
	public const string BOSS_MULTI_HURT = "multi_atk_hurt";

	[Token(Token = "0x4000103")]
	public const string BOSS_MULTI_HURT_END1 = "hurt";

	[Token(Token = "0x4000104")]
	public const string BOSS_MULTI_HURT_END2 = "multi_atk_hurt_end";

	[Token(Token = "0x4000105")]
	public const string BOSS_MULTI_HURT_CANCELL1 = "multi_atk_out";

	[Token(Token = "0x4000106")]
	public const string BOSS_MULTI_HURT_CANCELL2 = "multi_atk_end";

	[Token(Token = "0x4000107")]
	public const string BOSS_MULTI_ATK = "multi_atk_48";

	[Token(Token = "0x4000108")]
	public const string BOSS_MULTI_HURT_STATE = "boss_multi_hurt";

	[Token(Token = "0x4000109")]
	public const string BOSS_MULTI_ATK_END = "multi_atk_48_end";

	[Token(Token = "0x400010A")]
	public const string COMEOUT1 = "note_out_g";

	[Token(Token = "0x400010B")]
	public const string COMEOUT2 = "note_out_g";

	[Token(Token = "0x400010C")]
	public const string COMEOUT3 = "note_out_p";

	[Token(Token = "0x400010D")]
	public const string MUL_HURT = "note_multihit_hurt";

	[Token(Token = "0x400010E")]
	public const string MUL_ALIVE = "note_multi_alive";

	[Token(Token = "0x400010F")]
	public const string STAND = "standby";

	[Token(Token = "0x4000110")]
	public const string STAND_AIR = "standby_air";

	[Token(Token = "0x4000111")]
	public const string PRESS = "char_press";

	[Token(Token = "0x4000112")]
	public const string HURT = "char_hurt";

	[Token(Token = "0x4000113")]
	public const string CHAR_INVINCIBLE = "char_invincible";

	[Token(Token = "0x4000114")]
	public const string CHAR_ZOMBIA_INVINCIBLE = "char_zombie_invincible";

	[Token(Token = "0x4000115")]
	public const string CHAR_ZOMBIA_INVINCIBLE_END = "char_zombie_invincible_end";

	[Token(Token = "0x4000116")]
	public const string CHAR_NEKO_INVINCIBLE = "char_neko_invincible";

	[Token(Token = "0x4000117")]
	public const string CHAR_BLOOD_HURT = "char_blood_hurt";

	[Token(Token = "0x4000118")]
	public const string CHAR_EMPTY = "empty";

	[Token(Token = "0x4000119")]
	public const string BOSS_HURT = "boss_hurt";

	[Token(Token = "0x400011A")]
	public const string RUN = "char_run";

	[Token(Token = "0x400011B")]
	public const string FLY = "char_fly";

	[Token(Token = "0x400011C")]
	public const string ATTACK_PERFECT = "char_atk_p";

	[Token(Token = "0x400011D")]
	public const string ATTACK_GREAT = "char_atk_g";

	[Token(Token = "0x400011E")]
	public const string ATTACK_COOL = "";

	[Token(Token = "0x400011F")]
	public const string ATTACK_MISS = "char_atk_miss";

	[Token(Token = "0x4000120")]
	public const string JUMP_HURT = "char_jump_hurt";

	[Token(Token = "0x4000121")]
	public const string JUMP = "char_jump";

	[Token(Token = "0x4000122")]
	public const string CHAR_DEAD = "char_die";

	[Token(Token = "0x4000123")]
	public const string PET_SKILL = "servant_skill";

	[Token(Token = "0x4000124")]
	public const string OUTSIDE = "outside";

	[Token(Token = "0x4000125")]
	public const string JUMP_ATTACK = "char_jumphit";

	[Token(Token = "0x4000126")]
	public const string JUMP_ATTACK_GREAT = "char_jumphit_great";

	[Token(Token = "0x4000127")]
	public const string JUMP_DOWN_ATTACK = "char_downhit";

	[Token(Token = "0x4000128")]
	public const string REIMU_UP_TO_DOWN = "char_uptodown";

	[Token(Token = "0x4000129")]
	public const string JUMP_DOWN_PRESS = "char_downpress";

	[Token(Token = "0x400012A")]
	public const string JUMP_ATTACK_UP = "char_uphit";

	[Token(Token = "0x400012B")]
	public const string AIR_PRESS_START = "char_uppress_start";

	[Token(Token = "0x400012C")]
	public const string AIR_PRESSING = "char_uppress";

	[Token(Token = "0x400012D")]
	public const string AIR_PRESS_END = "char_uppress_end";

	[Token(Token = "0x400012E")]
	public const string AIR_PRESS_HURT = "char_uppress_hurt";

	[Token(Token = "0x400012F")]
	public const string PRESS_BIG = "char_big_press";

	[Token(Token = "0x4000130")]
	public const string PRESS_GROUND_TO_BIG = "char_up_press_s2b";

	[Token(Token = "0x4000131")]
	public const string PRESS_AIR_TO_BIG = "char_down_press_s2b";

	[Token(Token = "0x4000132")]
	public const string PRESS_BIG_TO_GROUND = "char_down_press_b2s";

	[Token(Token = "0x4000133")]
	public const string PRESS_BIG_TO_AIR = "char_up_press_b2s";

	[Token(Token = "0x4000134")]
	public const string PRESS_HIT_TO_GROUND = "char_down_press_s";

	[Token(Token = "0x4000135")]
	public const string PRESS_HIT_TO_AIR = "char_up_press_s";

	[Token(Token = "0x4000136")]
	public const string ATTACK_DOUBLE = "char_bighit";

	[Token(Token = "0x4000137")]
	public const string MUL_HIT_START = "char_multihit_start";

	[Token(Token = "0x4000138")]
	public const string MUL_HITTING = "char_multihitting";

	[Token(Token = "0x4000139")]
	public const string MUL_HIT_END = "char_multihit_end";

	[Token(Token = "0x400013A")]
	public const string ENEMY_ATTACK_DOUBLE = "note_charge";
}
