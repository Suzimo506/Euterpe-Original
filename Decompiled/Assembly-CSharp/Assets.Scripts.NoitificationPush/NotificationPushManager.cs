using System.Collections.Generic;
using Cpp2ILInjected;
using TPNS.Config;
using UnityEngine;

namespace Assets.Scripts.NoitificationPush;

[Token(Token = "0x20006AA")]
public class NotificationPushManager : MonoBehaviour
{
	[Token(Token = "0x4002402")]
	[FieldOffset(Offset = "0x18")]
	public AndroidTpnsConfig m_AndroidTpnsConfig_CN;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002403")]
	public AndroidTpnsConfig m_AndroidTpnsConfig_Oversea;

	[Token(Token = "0x4002404")]
	[FieldOffset(Offset = "0x28")]
	public IosTpnsConfig m_IOSTpnsConfig_Oversea;

	[Token(Token = "0x4002405")]
	[FieldOffset(Offset = "0x30")]
	public IosTpnsConfig m_IOSroidTpnsConfig_Oversea;

	[Token(Token = "0x4002406")]
	private const string POST_NOTIFICATIONS = "android.permission.POST_NOTIFICATIONS";

	[Token(Token = "0x4002407")]
	private static List<string> languageTags;

	[Token(Token = "0x4002408")]
	private static List<string> languageTagNeedToUpload;

	[Token(Token = "0x6003EA3")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public NotificationPushManager()
	{
	}
}
