using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000651")]
public class SceneManager : Singleton<SceneManager>
{
	[Token(Token = "0x4002387")]
	[FieldOffset(Offset = "0x10")]
	public string loadingSceneName;

	[Token(Token = "0x4002388")]
	public const string welcomeSceneName = "Welcome";

	[Token(Token = "0x4002389")]
	[FieldOffset(Offset = "0x18")]
	public float leastLoadingTime;

	[Token(Token = "0x400238C")]
	[FieldOffset(Offset = "0x30")]
	public string loadSceneNameViaLoadingScene;

	[Token(Token = "0x400238D")]
	[FieldOffset(Offset = "0x38")]
	public UnityAction completeCallBack;

	[Token(Token = "0x400238E")]
	[FieldOffset(Offset = "0x40")]
	public UnityAction preloadCallback;

	[Token(Token = "0x170005AC")]
	public string preSceneName
	{
		[CompilerGenerated]
		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x170005AD")]
	public Scene curScene
	{
		[Address(RVA = "0x761FB0", Offset = "0x7607B0", Length = "0x48")]
		[Token(Token = "0x6003CD0")]
		get
		{
			return default(Scene);
		}
	}

	[Token(Token = "0x170005AE")]
	public string sceneName
	{
		[Address(RVA = "0x762000", Offset = "0x760800", Length = "0x59")]
		[Token(Token = "0x6003CD2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AF")]
	public Scene scene
	{
		[Address(RVA = "0x762060", Offset = "0x760860", Length = "0x48")]
		[Token(Token = "0x6003CD3")]
		get
		{
			return default(Scene);
		}
	}

	[Token(Token = "0x1400005D")]
	public event UnityAction onBeforeLoadNewScene
	{
		[Token(Token = "0x6003CD4")]
		[Address(RVA = "0x761E50", Offset = "0x760650", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x7620B0", Offset = "0x7608B0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005E")]
	public event UnityAction<Scene, LoadSceneMode> onSceneLoad
	{
		[Token(Token = "0x6003CD6")]
		[Address(RVA = "0x761F50", Offset = "0x760750", Length = "0x51")]
		add
		{
		}
		[Address(RVA = "0x7621B0", Offset = "0x7609B0", Length = "0x51")]
		[Token(Token = "0x6003CD7")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005F")]
	public event UnityAction<Scene, Scene> onSceneChanged
	{
		[Address(RVA = "0x761EF0", Offset = "0x7606F0", Length = "0x51")]
		[Token(Token = "0x6003CD8")]
		add
		{
		}
		[Address(RVA = "0x762150", Offset = "0x760950", Length = "0x51")]
		[Token(Token = "0x6003CD9")]
		remove
		{
		}
	}

	[Token(Token = "0x6003CD1")]
	[Address(RVA = "0x761AE0", Offset = "0x7602E0", Length = "0x119")]
	private void Init()
	{
	}

	[Address(RVA = "0x761C00", Offset = "0x760400", Length = "0x11")]
	[Token(Token = "0x6003CDA")]
	public void InvokeOnBeforeLoadNewScene()
	{
	}

	[Token(Token = "0x6003CDB")]
	[Address(RVA = "0x761C20", Offset = "0x760420", Length = "0xCC")]
	public void LoadSceneSync(string sName)
	{
	}

	[Token(Token = "0x6003CDC")]
	[Address(RVA = "0x761CF0", Offset = "0x7604F0", Length = "0xF5")]
	public void LoadSceneViaLoadingScene(string sceneName, UnityAction completeCallBack = null)
	{
	}

	[Address(RVA = "0x761DF0", Offset = "0x7605F0", Length = "0x52")]
	[Token(Token = "0x6003CDD")]
	public SceneManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
