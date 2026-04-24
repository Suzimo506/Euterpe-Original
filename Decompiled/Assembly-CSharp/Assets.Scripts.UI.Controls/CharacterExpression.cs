using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using MEC;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008A8")]
public class CharacterExpression : SerializedMonoBehaviour
{
	[Token(Token = "0x4002D20")]
	public const string talk_bubble_start = "TalkBubbleStart";

	[Token(Token = "0x4002D21")]
	public const string talk_bubble_end = "TalkBubbleEnd";

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002D22")]
	private ExpressionContainer m_Expressions;

	[Token(Token = "0x4002D23")]
	[FieldOffset(Offset = "0x60")]
	private int m_CharacterIdx;

	[Token(Token = "0x4002D24")]
	[FieldOffset(Offset = "0x68")]
	private string m_Language;

	[Token(Token = "0x4002D25")]
	[FieldOffset(Offset = "0x70")]
	private BaseTalkBubble m_TalkBubble;

	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4002D26")]
	private List<BaseTalkBubble> m_TalkBubbleList;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002D27")]
	[SerializeField]
	private Dictionary<int, string> m_SpecialTalkBubbleNameMapping;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002D28")]
	private Dictionary<int, BaseTalkBubble> m_SpecialTalkBubbleMapping;

	[SerializeField]
	[Token(Token = "0x4002D29")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, List<Vector3>> m_BubbleLocationDic;

	[SerializeField]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002D2A")]
	private Dictionary<int, List<Vector3>> m_IpadBubbleLocationDic;

	[Token(Token = "0x4002D2B")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<int, List<Vector3>> m_CurLocationDic;

	[Token(Token = "0x4002D2C")]
	[FieldOffset(Offset = "0xA8")]
	private int m_TalkIndex;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4002D2D")]
	private string[] m_Talks;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002D2E")]
	[SerializeField]
	private string m_SplitSign;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4002D2F")]
	private Coroutine m_Coroutine;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002D30")]
	private Coroutine m_EndCoroutine;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4002D31")]
	private CoroutineManager m_CoroutineManager;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4002D32")]
	private AudioSource m_AudioSource;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4002D33")]
	public Button m_Btn;

	[Token(Token = "0x4002D34")]
	[FieldOffset(Offset = "0xE8")]
	private MuseShow m_MuseShow;

	[Token(Token = "0x4002D35")]
	[FieldOffset(Offset = "0xF0")]
	private CharacterApply m_CharacterApply;

	[Token(Token = "0x4002D36")]
	[FieldOffset(Offset = "0xF8")]
	private Coroutine m_ShowTalkCoroutine;

	[Token(Token = "0x4002D37")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private RectTransform m_MuseShowTransform;

	[SerializeField]
	[Token(Token = "0x4002D38")]
	[FieldOffset(Offset = "0x108")]
	private Dictionary<int, Vector3> m_IpadRoleLocationAdjustDic;

	[Token(Token = "0x4002D39")]
	[FieldOffset(Offset = "0x110")]
	private bool m_IsFinishAnim;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002D3A")]
	public string tipExpressionAnimName;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4002D3B")]
	public float tipExpressionTime;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4002D3C")]
	public GameObject tipExpressionContent;

	[Token(Token = "0x4002D3D")]
	[FieldOffset(Offset = "0x130")]
	private bool m_IsTriggerNekoMainHidden;

	[Token(Token = "0x4002D3E")]
	[FieldOffset(Offset = "0x134")]
	private int m_NekoMainHiddenNum;

	[Token(Token = "0x4002D3F")]
	[FieldOffset(Offset = "0x138")]
	private float m_BubbleOutTime;

	[Token(Token = "0x4002D40")]
	[FieldOffset(Offset = "0x13C")]
	private bool m_IsAutoExpressInvoked;

	[Token(Token = "0x4002D41")]
	[FieldOffset(Offset = "0x140")]
	private CoroutineHandle m_AutoExpressCoroutine;

	[Token(Token = "0x4002D42")]
	private const float auto_express_show_duration = 10f;

	[Token(Token = "0x4002D43")]
	[FieldOffset(Offset = "0x144")]
	private int m_ClickCount;

	[Token(Token = "0x17000882")]
	public ExpressionContainer expressionContainer
	{
		[Token(Token = "0x6004E60")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004E61")]
	[Address(RVA = "0x5AA8B0", Offset = "0x5A90B0", Length = "0x24D")]
	public void SetMuseShow(MuseShow museShow)
	{
	}

	[Token(Token = "0x6004E62")]
	[Address(RVA = "0x5A8FE0", Offset = "0x5A77E0", Length = "0x255")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5AAC60", Offset = "0x5A9460", Length = "0x25C")]
	[Token(Token = "0x6004E63")]
	private void Start()
	{
	}

	[Address(RVA = "0x5A9CD0", Offset = "0x5A84D0", Length = "0x17B")]
	[Token(Token = "0x6004E64")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004E65")]
	[Address(RVA = "0x5A9C60", Offset = "0x5A8460", Length = "0x66")]
	private void InvokeSteamAchievement()
	{
	}

	[Token(Token = "0x6004E66")]
	[Address(RVA = "0x5AA090", Offset = "0x5A8890", Length = "0x1EB")]
	private void OnMuseShowClicked()
	{
	}

	[Token(Token = "0x6004E67")]
	[Address(RVA = "0x5AAB90", Offset = "0x5A9390", Length = "0xC8")]
	public void StartAutoExpressProcess()
	{
	}

	[Token(Token = "0x6004E68")]
	[Address(RVA = "0x5AA280", Offset = "0x5A8A80", Length = "0x8")]
	private void OnRoleChanged()
	{
	}

	[Address(RVA = "0x5AA8A0", Offset = "0x5A90A0", Length = "0x7")]
	[Token(Token = "0x6004E69")]
	private void ResetAutoExpressState(bool state)
	{
	}

	[Token(Token = "0x6004E6A")]
	[Address(RVA = "0x5AA360", Offset = "0x5A8B60", Length = "0xC2")]
	private void RandomExpress()
	{
	}

	[Address(RVA = "0x5A9260", Offset = "0x5A7A60", Length = "0xCB")]
	[Token(Token = "0x6004E6B")]
	public void Express(int index, int soundIndex)
	{
	}

	[Address(RVA = "0x5A8EB0", Offset = "0x5A76B0", Length = "0x121")]
	[Token(Token = "0x6004E6C")]
	public void AutoExpress()
	{
	}

	[Address(RVA = "0x5A9330", Offset = "0x5A7B30", Length = "0x82C")]
	[Token(Token = "0x6004E6D")]
	public void Express(Expression expression, int soundIndex = -1)
	{
	}

	[Address(RVA = "0x5AA290", Offset = "0x5A8A90", Length = "0xC0")]
	[Token(Token = "0x6004E6E")]
	private void PlayEndCallback()
	{
	}

	[Address(RVA = "0x5A9B60", Offset = "0x5A8360", Length = "0xF0")]
	[Token(Token = "0x6004E6F")]
	private float GetFullTalkTime(List<TalkInfo> talkInfos)
	{
		return default(float);
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x418B0", Offset = "0x40CB0")]
	[Token(Token = "0x6004E70")]
	[Address(RVA = "0x5AAB00", Offset = "0x5A9300", Length = "0x81")]
	private IEnumerator ShowTalk(List<TalkInfo> talkInfos)
	{
		return null;
	}

	[Token(Token = "0x6004E71")]
	[Address(RVA = "0x5AAEC0", Offset = "0x5A96C0", Length = "0x8D")]
	private void SwitchBubbleAnimatorAndTextByType(TalkType talkType)
	{
	}

	[Token(Token = "0x6004E72")]
	[Address(RVA = "0x5AA030", Offset = "0x5A8830", Length = "0x50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004E73")]
	[Address(RVA = "0x5A9E50", Offset = "0x5A8650", Length = "0x1D2")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004E74")]
	[Address(RVA = "0x5AA430", Offset = "0x5A8C30", Length = "0x2AA")]
	private void RefreshExpressions()
	{
	}

	[Address(RVA = "0x5A9240", Offset = "0x5A7A40", Length = "0x1E")]
	[Token(Token = "0x6004E75")]
	private void ChangeExpressions(Assets.Scripts.Database.CharacterInfo characterInfo, CharacterFestivalVoiceInfo festivalInfo)
	{
	}

	[Token(Token = "0x6004E76")]
	[Address(RVA = "0x5AA6E0", Offset = "0x5A8EE0", Length = "0x1B1")]
	private void RefreshTwnTalkBubbleLocation()
	{
	}

	[Token(Token = "0x6004E77")]
	[Address(RVA = "0x5AAF50", Offset = "0x5A9750", Length = "0x335")]
	public void TipExpression(bool test = false)
	{
	}

	[Token(Token = "0x6004E78")]
	[Address(RVA = "0x5AB390", Offset = "0x5A9B90", Length = "0x154")]
	public CharacterExpression()
	{
	}
}
