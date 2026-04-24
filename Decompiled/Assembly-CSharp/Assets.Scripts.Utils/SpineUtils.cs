using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Utils;

[Token(Token = "0x20005AA")]
public static class SpineUtils
{
	[Token(Token = "0x600390E")]
	[Address(RVA = "0x600500", Offset = "0x5FED00", Length = "0xCC")]
	public static string CurrentAnimationName(int idx)
	{
		return null;
	}

	[Token(Token = "0x600390F")]
	[Address(RVA = "0x600780", Offset = "0x5FEF80", Length = "0x1B7")]
	public static Vector3 GetBoneRealPosition(string boneName, GameObject obj)
	{
		return default(Vector3);
	}

	[Address(RVA = "0x6005D0", Offset = "0x5FEDD0", Length = "0x1AC")]
	[Token(Token = "0x6003910")]
	public static Vector3 GetBoneAbsPosition(string boneName, GameObject obj)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003911")]
	[Address(RVA = "0x600940", Offset = "0x5FF140", Length = "0x194")]
	public static void SetSynchroObjectsActive(GameObject obj, bool val)
	{
	}
}
