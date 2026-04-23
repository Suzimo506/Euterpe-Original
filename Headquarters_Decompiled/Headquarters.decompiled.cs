using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text.Json;
using System.Text.Json.Nodes;
using CustomAlbums.Data;
using CustomAlbums.Managers;
using HarmonyLib;
using Headquarters;
using Headquarters.Data;
using Headquarters.Data.Responses;
using Headquarters.Managers;
using Headquarters.UI;
using Headquarters.Utilities;
using Il2Cpp;
using Il2CppAccount;
using Il2CppAssets.Scripts.Common;
using Il2CppAssets.Scripts.Database;
using Il2CppAssets.Scripts.PeroTools.Commons;
using Il2CppAssets.Scripts.PeroTools.GeneralLocalization;
using Il2CppAssets.Scripts.PeroTools.Managers;
using Il2CppAssets.Scripts.UI.Panels;
using Il2CppAssets.Scripts.UI.Tips;
using Il2CppNewtonsoft.Json.Linq;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using MelonLoader.Preferences;
using MelonLoader.Utils;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: MelonInfo(typeof(Main), "Headquarters", "4.1.0", "AshtonMemer", null)]
[assembly: MelonGame("PeroPeroGames", "MuseDash")]
[assembly: MelonColor(255, 231, 0, 198)]
[assembly: AssemblyTitle("Headquarters")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Muse Dash Modding Community")]
[assembly: AssemblyProduct("Headquarters")]
[assembly: AssemblyCopyright("Copyright © AshtonMemer 2025")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyFileVersion("4.1.0.0")]
[assembly: TargetFramework(".NETCoreApp,Version=v6.0", FrameworkDisplayName = ".NET 6.0")]
[assembly: AssemblyVersion("4.1.0.0")]
namespace Headquarters
{
	public class Main : MelonMod
	{
		public const string MelonName = "Headquarters";

		public const string MelonVersion = "4.1.0";

		public const string MelonAuthor = "AshtonMemer";

		public static readonly string ApiPrefix = "https://api.mdmc.moe/v3";

		public static readonly string LinkUrl = "https://mdmc.moe/settings/link";

		private readonly Logger _logger = new Logger("Headquarters");

		public override void OnLateInitializeMelon()
		{
			((MelonBase)this).OnLateInitializeMelon();
			MelonSettings.Initialize();
			PopupManager.Initialize();
			LocalizationManager.Initialize();
			if (MelonSettings.EnableAccountSystem)
			{
				FavoritesManager.Initialize();
				AuthManager.LoadToken();
			}
			else
			{
				_logger.Msg("Account system is disabled. Skipping authentication initialization.");
			}
		}
	}
	internal static class MelonSettings
	{
		private static MelonPreferences_Category _category;

		private static MelonPreferences_Entry<bool> _enableVerboseLogging;

		private static MelonPreferences_Entry<bool> _enablePopups;

		private static MelonPreferences_Entry<bool> _enableAccountSystem;

		private static MelonPreferences_Entry<bool> _enableFavoritesSyncing;

		public static bool EnableVerboseLogging => _enableVerboseLogging.Value;

		public static bool EnablePopups => _enablePopups.Value;

		public static bool EnableAccountSystem => _enableAccountSystem.Value;

		public static bool EnableFavoritesSyncing => _enableFavoritesSyncing.Value;

		public static void Initialize()
		{
			_category = MelonPreferences.CreateCategory("Headquarters");
			_category.SetFilePath(Path.Combine(MelonEnvironment.UserDataDirectory, "Headquarters.cfg"));
			_enableVerboseLogging = _category.CreateEntry<bool>("VerboseLogging", false, "Verbose Logging", "Enables the printing of debug messages to your console. Useless unless you're having issues.", false, false, (ValueValidator)null, (string)null);
			_enablePopups = _category.CreateEntry<bool>("Popups", true, "Popups", "Enables the popups that appear when you successfully submit a score to the leaderboard.", false, false, (ValueValidator)null, (string)null);
			_enableAccountSystem = _category.CreateEntry<bool>("AccountSystem", true, "Account System", "Enables the account system. If disabled, you will not be prompted to sign in or save scores, but you can still view the leaderboard.", false, false, (ValueValidator)null, (string)null);
			_enableFavoritesSyncing = _category.CreateEntry<bool>("FavoritesSyncing", true, "Favorites Syncing", "Enables the syncing of your favorites with the server. If disabled, favorite charts will not be liked on the website.", false, false, (ValueValidator)null, (string)null);
			_category.SaveToFile(true);
		}
	}
}
namespace Headquarters.Utilities
{
	internal class Logger
	{
		private readonly Instance _logger;

		public Logger(string className)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			_logger = new Instance(className);
		}

		public void Msg(string message, bool isImportant = false)
		{
			if (MelonSettings.EnableVerboseLogging || isImportant)
			{
				_logger.Msg(message);
			}
		}

		public void Success(string message, bool isImportant = false)
		{
			if (MelonSettings.EnableVerboseLogging || isImportant)
			{
				_logger.Msg(ConsoleColor.Green, "Success: " + message);
			}
		}

		public void Warning(string message)
		{
			_logger.Msg(ConsoleColor.Yellow, "Warning: " + message);
		}

		public void Error(string message)
		{
			_logger.Msg(ConsoleColor.Red, "ERROR: " + message);
		}
	}
	internal static class Web
	{
		private static readonly Logger _logger = new Logger("Web");

		public static void Get(string url, Action<JsonDocument, bool> callback)
		{
			MelonCoroutines.Start(GetRoutine(url, callback));
		}

		private static IEnumerator GetRoutine(string url, Action<JsonDocument, bool> callback)
		{
			UnityWebRequest request = UnityWebRequest.Get(url);
			SetAuth(request);
			yield return request.SendWebRequest();
			HandleResponse(request, callback);
		}

		public static void Post(string url, Action<JsonDocument, bool> callback)
		{
			MelonCoroutines.Start(PostRoutine(url, null, callback));
		}

		public static void Post(string url, Dictionary<string, string> data, Action<JsonDocument, bool> callback)
		{
			MelonCoroutines.Start(PostRoutine(url, data, callback));
		}

		private static IEnumerator PostRoutine(string url, Dictionary<string, string> data, Action<JsonDocument, bool> callback)
		{
			WWWForm val = new WWWForm();
			if (data != null)
			{
				foreach (KeyValuePair<string, string> datum in data)
				{
					val.AddField(datum.Key, datum.Value);
				}
			}
			UnityWebRequest request = UnityWebRequest.Post(url, val);
			SetAuth(request);
			yield return request.SendWebRequest();
			HandleResponse(request, callback);
		}

		private static void HandleResponse(UnityWebRequest request, Action<JsonDocument, bool> callback)
		{
			bool flag = !request.isNetworkError && !request.isHttpError;
			string text = request.downloadHandler.text;
			try
			{
				JsonDocument arg = JsonDocument.Parse(text);
				if (!flag)
				{
					_logger.Error("Network/HTTP Error: " + request.error + " | Content: " + text);
					callback?.Invoke(null, arg2: false);
				}
				else
				{
					callback?.Invoke(arg, arg2: true);
				}
			}
			catch (JsonException ex)
			{
				_logger.Error($"JSON parsing error: {ex.Message}\nResponse content: '{text}'");
				callback?.Invoke(null, arg2: false);
			}
		}

		private static void SetAuth(UnityWebRequest request)
		{
			if (AuthManager.IsAuthenticated)
			{
				request.SetRequestHeader("Authorization", "Bearer " + AuthManager.AccessToken);
			}
		}
	}
}
namespace Headquarters.UI
{
	public class ChoicePopup : Popup
	{
		public string ConfirmText { get; private set; }

		public string CancelText { get; private set; }

		public Action OnConfirm { get; private set; }

		public Action OnCancel { get; private set; }

		public ChoicePopup(string message, string confirmText, string cancelText, Action onConfirm, Action onCancel)
			: base(message)
		{
			ConfirmText = confirmText;
			CancelText = cancelText;
			OnConfirm = onConfirm;
			OnCancel = onCancel;
		}

		public override void Update()
		{
			if (Time.time - base.StartTime < 0.4f)
			{
				base.Alpha = CalculateFadeAlpha(Time.time, float.MaxValue);
			}
			else if (base.IsClosing)
			{
				float num = Time.time - base.CloseStartTime;
				base.Alpha = Mathf.Lerp(1f, 0f, num / 0.4f);
			}
			else
			{
				base.Alpha = 1f;
			}
		}

		public override void Draw(GUIStyle textStyle, GUIStyle choiceStyle, GUIStyle buttonStyle)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Expected O, but got Unknown
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Expected O, but got Unknown
			Color color = GUI.color;
			GUI.color = PopupManager.POPUP_BACKGROUND_COLOR;
			GUI.DrawTexture(base.Position, (Texture)(object)Texture2D.whiteTexture);
			GUI.color = PopupManager.POPUP_BORDER_COLOR;
			PopupManager.DrawBorder(base.Position, 2f);
			Rect position = base.Position;
			float num = ((Rect)(ref position)).height - 30f - 24f;
			position = base.Position;
			float num2 = ((Rect)(ref position)).x + 12f;
			position = base.Position;
			float num3 = ((Rect)(ref position)).y + 10f;
			position = base.Position;
			Rect val = new Rect(num2, num3, ((Rect)(ref position)).width - 24f, num);
			GUI.color = PopupManager.TEXT_COLOR;
			string message = base.Message;
			GUIStyle val2 = new GUIStyle(GUI.skin.label)
			{
				fontSize = 16,
				alignment = (TextAnchor)1,
				wordWrap = true
			};
			val2.normal.textColor = PopupManager.TEXT_COLOR;
			GUI.Label(val, message, val2);
			position = base.Position;
			float num4 = (((Rect)(ref position)).width - 36f) / 2f;
			position = base.Position;
			float num5 = ((Rect)(ref position)).x + 12f;
			position = base.Position;
			Rect val3 = default(Rect);
			((Rect)(ref val3))..ctor(num5, ((Rect)(ref position)).y + num + 12f, num4, 30f);
			position = base.Position;
			float num6 = ((Rect)(ref position)).x + 12f + num4 + 12f;
			position = base.Position;
			Rect val4 = default(Rect);
			((Rect)(ref val4))..ctor(num6, ((Rect)(ref position)).y + num + 12f, num4, 30f);
			Vector2 mousePosition = Event.current.mousePosition;
			bool flag = ((Rect)(ref val3)).Contains(mousePosition);
			bool flag2 = ((Rect)(ref val4)).Contains(mousePosition);
			PopupManager.DrawButtonWithBorder(val3, flag ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR, 1f);
			PopupManager.DrawButtonWithBorder(val4, flag2 ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR, 1f);
			GUI.color = Color.clear;
			bool num7 = GUI.Button(val3, "", GUIStyle.none);
			bool flag3 = GUI.Button(val4, "", GUIStyle.none);
			GUI.color = (flag ? Color.black : PopupManager.TEXT_COLOR);
			Rect val5 = val3;
			string confirmText = ConfirmText;
			GUIStyle val6 = new GUIStyle(GUI.skin.label)
			{
				fontSize = 15,
				fontStyle = (FontStyle)1,
				alignment = (TextAnchor)4
			};
			val6.normal.textColor = (flag ? Color.black : PopupManager.TEXT_COLOR);
			GUI.Label(val5, confirmText, val6);
			GUI.color = (flag2 ? Color.black : PopupManager.TEXT_COLOR);
			Rect val7 = val4;
			string cancelText = CancelText;
			GUIStyle val8 = new GUIStyle(GUI.skin.label)
			{
				fontSize = 15,
				fontStyle = (FontStyle)1,
				alignment = (TextAnchor)4
			};
			val8.normal.textColor = (flag2 ? Color.black : PopupManager.TEXT_COLOR);
			GUI.Label(val7, cancelText, val8);
			if (num7)
			{
				OnConfirm?.Invoke();
				StartClosing();
			}
			if (flag3)
			{
				OnCancel?.Invoke();
				StartClosing();
			}
			GUI.color = color;
		}

		protected override float CalculateHeight()
		{
			float num = Mathf.Ceil((float)base.Message.Length / 26f);
			return Mathf.Max(45f, num * 20f + 6f) + 30f + 24f;
		}
	}
	public class LargePopup
	{
		public string Title { get; private set; }

		public string Message { get; private set; }

		public string Code { get; private set; }

		public string ExtraButtonText { get; private set; }

		public Action OnExtraButton { get; private set; }

		public Action OnClose { get; private set; }

		public float StartTime { get; set; }

		public Rect Position { get; private set; }

		public bool ShouldRemove { get; private set; }

		public bool IsClosing { get; private set; }

		public float CloseStartTime { get; private set; }

		public float Alpha { get; private set; } = 1f;

		public LargePopup(string title, string message, string code, string extraButtonText, Action onExtraButton, Action onClose)
		{
			Title = title;
			Message = message;
			Code = code;
			ExtraButtonText = extraButtonText;
			OnExtraButton = onExtraButton;
			OnClose = onClose;
			CalculatePosition();
		}

		public void Update()
		{
			float num = Time.time - StartTime;
			if (num < 0.4f)
			{
				Alpha = PopupManager.Easing.OutCubic(num / 0.4f);
			}
			else if (IsClosing)
			{
				float num2 = Time.time - CloseStartTime;
				if (num2 < 0.4f)
				{
					Alpha = PopupManager.Easing.InOutCubic(1f - num2 / 0.4f);
				}
				else
				{
					ShouldRemove = true;
				}
			}
			else
			{
				Alpha = 1f;
			}
		}

		public void Draw(GUIStyle largeStyle, GUIStyle titleStyle, GUIStyle codeStyle, GUIStyle buttonStyle)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Expected O, but got Unknown
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Expected O, but got Unknown
			//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_041f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Expected O, but got Unknown
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_094d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0952: Unknown result type (might be due to invalid IL or missing references)
			//IL_095c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0961: Unknown result type (might be due to invalid IL or missing references)
			//IL_0978: Unknown result type (might be due to invalid IL or missing references)
			//IL_097d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0987: Unknown result type (might be due to invalid IL or missing references)
			//IL_098c: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0550: Unknown result type (might be due to invalid IL or missing references)
			//IL_0580: Unknown result type (might be due to invalid IL or missing references)
			//IL_058a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0596: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0600: Unknown result type (might be due to invalid IL or missing references)
			//IL_0607: Unknown result type (might be due to invalid IL or missing references)
			//IL_060e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0638: Unknown result type (might be due to invalid IL or missing references)
			//IL_0647: Expected O, but got Unknown
			//IL_0674: Unknown result type (might be due to invalid IL or missing references)
			//IL_06af: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_071f: Unknown result type (might be due to invalid IL or missing references)
			//IL_072e: Expected O, but got Unknown
			//IL_09db: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_077a: Unknown result type (might be due to invalid IL or missing references)
			//IL_078d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0786: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_079b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0801: Unknown result type (might be due to invalid IL or missing references)
			//IL_080b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_0821: Unknown result type (might be due to invalid IL or missing references)
			//IL_0842: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
			//IL_085c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0876: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0886: Unknown result type (might be due to invalid IL or missing references)
			//IL_0890: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5f: Expected O, but got Unknown
			//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0906: Unknown result type (might be due to invalid IL or missing references)
			//IL_0916: Unknown result type (might be due to invalid IL or missing references)
			//IL_0925: Expected O, but got Unknown
			Color color = GUI.color;
			GUI.color = new Color(PopupManager.OVERLAY_COLOR.r, PopupManager.OVERLAY_COLOR.g, PopupManager.OVERLAY_COLOR.b, PopupManager.OVERLAY_COLOR.a * Alpha);
			GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), (Texture)(object)Texture2D.whiteTexture);
			GUI.color = new Color(1f, 1f, 1f, Alpha);
			GUI.color = new Color(PopupManager.POPUP_BACKGROUND_COLOR.r, PopupManager.POPUP_BACKGROUND_COLOR.g, PopupManager.POPUP_BACKGROUND_COLOR.b, PopupManager.POPUP_BACKGROUND_COLOR.a * Alpha);
			GUI.DrawTexture(Position, (Texture)(object)Texture2D.whiteTexture);
			GUI.color = new Color(PopupManager.POPUP_BORDER_COLOR.r, PopupManager.POPUP_BORDER_COLOR.g, PopupManager.POPUP_BORDER_COLOR.b, Alpha);
			PopupManager.DrawBorder(Position, 2f);
			Rect position = Position;
			float num = ((Rect)(ref position)).y + 30f;
			position = Position;
			float x = ((Rect)(ref position)).x;
			position = Position;
			float num2 = x + ((Rect)(ref position)).width - 30f - 10f;
			position = Position;
			Rect val = default(Rect);
			((Rect)(ref val))..ctor(num2, ((Rect)(ref position)).y + 10f, 30f, 30f);
			Vector2 mousePosition = Event.current.mousePosition;
			bool flag = ((Rect)(ref val)).Contains(mousePosition);
			GUI.color = new Color((flag ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).r, (flag ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).g, (flag ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).b, Alpha);
			GUI.DrawTexture(val, (Texture)(object)Texture2D.whiteTexture);
			GUI.color = new Color(PopupManager.POPUP_BORDER_COLOR.r, PopupManager.POPUP_BORDER_COLOR.g, PopupManager.POPUP_BORDER_COLOR.b, Alpha);
			PopupManager.DrawBorder(val, 1f);
			GUI.color = new Color(flag ? Color.black.r : PopupManager.TEXT_COLOR.r, flag ? Color.black.g : PopupManager.TEXT_COLOR.g, flag ? Color.black.b : PopupManager.TEXT_COLOR.b, Alpha);
			Rect val2 = val;
			GUIStyle val3 = new GUIStyle(GUI.skin.label)
			{
				fontSize = 20,
				fontStyle = (FontStyle)1,
				alignment = (TextAnchor)4
			};
			val3.normal.textColor = new Color(flag ? Color.black.r : PopupManager.TEXT_COLOR.r, flag ? Color.black.g : PopupManager.TEXT_COLOR.g, flag ? Color.black.b : PopupManager.TEXT_COLOR.b, Alpha);
			GUI.Label(val2, "×", val3);
			GUI.color = Color.clear;
			if (!IsClosing && GUI.Button(val, "", GUIStyle.none))
			{
				OnClose?.Invoke();
				StartClosing();
			}
			position = Position;
			float num3 = ((Rect)(ref position)).x + 30f;
			float num4 = num;
			position = Position;
			Rect val4 = new Rect(num3, num4, ((Rect)(ref position)).width - 60f, 40f);
			GUI.color = new Color(PopupManager.TEXT_COLOR.r, PopupManager.TEXT_COLOR.g, PopupManager.TEXT_COLOR.b, Alpha);
			string title = Title;
			GUIStyle val5 = new GUIStyle(titleStyle);
			val5.normal.textColor = new Color(PopupManager.TEXT_COLOR.r, PopupManager.TEXT_COLOR.g, PopupManager.TEXT_COLOR.b, Alpha);
			GUI.Label(val4, title, val5);
			num += 50f;
			float num5 = 80f;
			position = Position;
			float num6 = ((Rect)(ref position)).x + 30f;
			float num7 = num;
			position = Position;
			Rect val6 = new Rect(num6, num7, ((Rect)(ref position)).width - 60f, num5);
			string message = Message;
			GUIStyle val7 = new GUIStyle(GUI.skin.label)
			{
				fontSize = 18,
				alignment = (TextAnchor)1,
				wordWrap = true
			};
			val7.normal.textColor = new Color(PopupManager.TEXT_COLOR.r, PopupManager.TEXT_COLOR.g, PopupManager.TEXT_COLOR.b, Alpha);
			GUI.Label(val6, message, val7);
			num += num5 + 20f;
			if (!string.IsNullOrEmpty(Code))
			{
				position = Position;
				float num8 = ((Rect)(ref position)).x + 30f;
				float num9 = num;
				position = Position;
				Rect val8 = default(Rect);
				((Rect)(ref val8))..ctor(num8, num9, ((Rect)(ref position)).width - 60f, 60f);
				bool num10 = ((Rect)(ref val8)).Contains(mousePosition);
				GUI.color = (num10 ? new Color(PopupManager.CODE_BACKGROUND_COLOR.r * 1.2f, PopupManager.CODE_BACKGROUND_COLOR.g * 1.2f, PopupManager.CODE_BACKGROUND_COLOR.b * 1.2f, Alpha) : new Color(PopupManager.CODE_BACKGROUND_COLOR.r, PopupManager.CODE_BACKGROUND_COLOR.g, PopupManager.CODE_BACKGROUND_COLOR.b, Alpha));
				GUI.DrawTexture(val8, (Texture)(object)Texture2D.whiteTexture);
				GUI.color = new Color(PopupManager.POPUP_BORDER_COLOR.r, PopupManager.POPUP_BORDER_COLOR.g, PopupManager.POPUP_BORDER_COLOR.b, Alpha);
				PopupManager.DrawBorder(val8, 2f);
				GUI.color = Color.clear;
				bool flag2 = GUI.Button(val8, "", GUIStyle.none);
				GUI.color = new Color(PopupManager.TEXT_COLOR.r, PopupManager.TEXT_COLOR.g, PopupManager.TEXT_COLOR.b, Alpha);
				Rect val9 = val8;
				string code = Code;
				GUIStyle val10 = new GUIStyle(GUI.skin.label)
				{
					fontSize = 32,
					fontStyle = (FontStyle)1,
					alignment = (TextAnchor)4
				};
				val10.normal.textColor = new Color(PopupManager.TEXT_COLOR.r, PopupManager.TEXT_COLOR.g, PopupManager.TEXT_COLOR.b, Alpha);
				GUI.Label(val9, code, val10);
				if (num10)
				{
					Rect val11 = new Rect(((Rect)(ref val8)).x, ((Rect)(ref val8)).y + ((Rect)(ref val8)).height - 18f, ((Rect)(ref val8)).width, 15f);
					GUI.color = new Color(PopupManager.TEXT_COLOR.r * 0.8f, PopupManager.TEXT_COLOR.g * 0.8f, PopupManager.TEXT_COLOR.b * 0.8f, Alpha);
					GUIStyle val12 = new GUIStyle(GUI.skin.label)
					{
						fontSize = 11,
						fontStyle = (FontStyle)2,
						alignment = (TextAnchor)4
					};
					val12.normal.textColor = new Color(PopupManager.TEXT_COLOR.r * 0.8f, PopupManager.TEXT_COLOR.g * 0.8f, PopupManager.TEXT_COLOR.b * 0.8f, Alpha);
					GUI.Label(val11, "Click to copy", val12);
				}
				if (flag2)
				{
					PopupManager.CopyToClipboard(Code);
				}
				Rect val13 = default(Rect);
				((Rect)(ref val13))..ctor(((Rect)(ref val8)).x + ((Rect)(ref val8)).width - 60f, ((Rect)(ref val8)).y + ((Rect)(ref val8)).height + 5f, 60f, 25f);
				bool flag3 = ((Rect)(ref val13)).Contains(mousePosition);
				GUI.color = new Color((flag3 ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).r, (flag3 ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).g, (flag3 ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).b, Alpha);
				GUI.DrawTexture(val13, (Texture)(object)Texture2D.whiteTexture);
				GUI.color = new Color(PopupManager.POPUP_BORDER_COLOR.r, PopupManager.POPUP_BORDER_COLOR.g, PopupManager.POPUP_BORDER_COLOR.b, Alpha);
				PopupManager.DrawBorder(val13, 1f);
				GUI.color = Color.clear;
				bool num11 = GUI.Button(val13, "", GUIStyle.none);
				GUI.color = new Color(flag3 ? Color.black.r : PopupManager.TEXT_COLOR.r, flag3 ? Color.black.g : PopupManager.TEXT_COLOR.g, flag3 ? Color.black.b : PopupManager.TEXT_COLOR.b, Alpha);
				Rect val14 = val13;
				GUIStyle val15 = new GUIStyle(GUI.skin.label)
				{
					fontSize = 12,
					fontStyle = (FontStyle)1,
					alignment = (TextAnchor)4
				};
				val15.normal.textColor = new Color(flag3 ? Color.black.r : PopupManager.TEXT_COLOR.r, flag3 ? Color.black.g : PopupManager.TEXT_COLOR.g, flag3 ? Color.black.b : PopupManager.TEXT_COLOR.b, Alpha);
				GUI.Label(val14, "Copy", val15);
				if (num11)
				{
					PopupManager.CopyToClipboard(Code);
				}
				num += 90f;
			}
			if (!string.IsNullOrEmpty(ExtraButtonText))
			{
				position = Position;
				float x2 = ((Rect)(ref position)).x;
				position = Position;
				float num12 = x2 + (((Rect)(ref position)).width - 200f) / 2f;
				position = Position;
				float y = ((Rect)(ref position)).y;
				position = Position;
				Rect val16 = default(Rect);
				((Rect)(ref val16))..ctor(num12, y + ((Rect)(ref position)).height - 30f - 40f, 200f, 40f);
				bool flag4 = ((Rect)(ref val16)).Contains(mousePosition);
				GUI.color = new Color((flag4 ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).r, (flag4 ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).g, (flag4 ? PopupManager.BUTTON_HOVER_COLOR : PopupManager.BUTTON_NORMAL_COLOR).b, Alpha);
				GUI.DrawTexture(val16, (Texture)(object)Texture2D.whiteTexture);
				GUI.color = new Color(PopupManager.POPUP_BORDER_COLOR.r, PopupManager.POPUP_BORDER_COLOR.g, PopupManager.POPUP_BORDER_COLOR.b, Alpha);
				PopupManager.DrawBorder(val16, 1f);
				GUI.color = Color.clear;
				bool num13 = GUI.Button(val16, "", GUIStyle.none);
				GUI.color = new Color(flag4 ? Color.black.r : PopupManager.TEXT_COLOR.r, flag4 ? Color.black.g : PopupManager.TEXT_COLOR.g, flag4 ? Color.black.b : PopupManager.TEXT_COLOR.b, Alpha);
				Rect val17 = val16;
				string extraButtonText = ExtraButtonText;
				GUIStyle val18 = new GUIStyle(GUI.skin.label)
				{
					fontSize = 16,
					fontStyle = (FontStyle)1,
					alignment = (TextAnchor)4
				};
				val18.normal.textColor = new Color(flag4 ? Color.black.r : PopupManager.TEXT_COLOR.r, flag4 ? Color.black.g : PopupManager.TEXT_COLOR.g, flag4 ? Color.black.b : PopupManager.TEXT_COLOR.b, Alpha);
				GUI.Label(val17, extraButtonText, val18);
				if (num13)
				{
					OnExtraButton?.Invoke();
				}
			}
			GUI.color = color;
		}

		public void StartClosing()
		{
			if (!IsClosing)
			{
				IsClosing = true;
				CloseStartTime = Time.time;
			}
		}

		private void CalculatePosition()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			float num = ((float)Screen.width - 600f) / 2f;
			float num2 = ((float)Screen.height - 400f) / 2f;
			Position = new Rect(num, num2, 600f, 400f);
		}
	}
	public abstract class Popup
	{
		public string Message { get; protected set; }

		public float StartTime { get; set; }

		public Rect Position { get; protected set; }

		public bool ShouldRemove { get; protected set; }

		public bool IsClosing { get; protected set; }

		public float CloseStartTime { get; private set; }

		public float Alpha { get; protected set; } = 1f;

		protected Popup(string message)
		{
			Message = message;
		}

		public abstract void Update();

		public abstract void Draw(GUIStyle textStyle, GUIStyle choiceStyle, GUIStyle buttonStyle);

		protected void StartClosing()
		{
			if (!IsClosing)
			{
				IsClosing = true;
				CloseStartTime = Time.time;
			}
		}

		public void CalculatePosition(int index)
		{
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			float num = CalculateHeight();
			float num2 = (float)Screen.width - 320f - 20f;
			float num3 = (float)Screen.height - 20f - num;
			PopupManager instance = PopupManager.Instance;
			if ((Object)(object)instance != (Object)null && index > 0)
			{
				for (int i = 0; i < Math.Min(index, instance.ActivePopups.Count); i++)
				{
					float num4 = instance.ActivePopups[i].CalculateHeight();
					num3 -= num4 + 20f;
				}
			}
			float num5 = Time.time - StartTime;
			if (IsClosing)
			{
				float num6 = Time.time - CloseStartTime;
				if (num6 < 0.4f)
				{
					float t = num6 / 0.4f;
					float num7 = Mathf.Lerp(0f, 340f, PopupManager.Easing.InOutCubic(t));
					num2 += num7;
				}
				else
				{
					ShouldRemove = true;
				}
			}
			else if (num5 < 0.4f)
			{
				float t2 = num5 / 0.4f;
				float num8 = Mathf.Lerp(340f, 0f, PopupManager.Easing.OutCubic(t2));
				num2 += num8;
			}
			Position = new Rect(num2, num3, 320f, num);
		}

		protected abstract float CalculateHeight();

		protected float CalculateFadeAlpha(float currentTime, float duration, bool fadeOut = false)
		{
			float num = currentTime - StartTime;
			if (!fadeOut)
			{
				if (num < 0.4f)
				{
					return PopupManager.Easing.OutCubic(num / 0.4f);
				}
				return 1f;
			}
			float num2 = duration - 0.4f;
			if (num >= num2)
			{
				float num3 = (num - num2) / 0.4f;
				return PopupManager.Easing.InOutCubic(1f - num3);
			}
			return 1f;
		}
	}
	public class TextPopup : Popup
	{
		public TextPopup(string message)
			: base(message)
		{
		}

		public override void Update()
		{
			float num = Time.time - base.StartTime;
			if (!base.IsClosing && num >= 3.1f)
			{
				StartClosing();
			}
			if (num < 0.4f)
			{
				base.Alpha = CalculateFadeAlpha(Time.time, 3.5f);
			}
			else if (base.IsClosing)
			{
				float num2 = Time.time - base.CloseStartTime;
				base.Alpha = Mathf.Lerp(1f, 0f, num2 / 0.4f);
			}
			else
			{
				base.Alpha = 1f;
			}
		}

		public override void Draw(GUIStyle textStyle, GUIStyle choiceStyle, GUIStyle buttonStyle)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			Color color = GUI.color;
			GUI.color = PopupManager.POPUP_BACKGROUND_COLOR;
			GUI.DrawTexture(base.Position, (Texture)(object)Texture2D.whiteTexture);
			GUI.color = PopupManager.POPUP_BORDER_COLOR;
			PopupManager.DrawBorder(base.Position, 2f);
			GUI.color = PopupManager.TEXT_COLOR;
			Rect position = base.Position;
			float num = ((Rect)(ref position)).x + 12f;
			position = base.Position;
			float num2 = ((Rect)(ref position)).y + 10f;
			position = base.Position;
			float num3 = ((Rect)(ref position)).width - 24f;
			position = base.Position;
			Rect val = new Rect(num, num2, num3, ((Rect)(ref position)).height - 20f);
			string message = base.Message;
			GUIStyle val2 = new GUIStyle(GUI.skin.label)
			{
				fontSize = 16,
				alignment = (TextAnchor)4,
				wordWrap = true
			};
			val2.normal.textColor = PopupManager.TEXT_COLOR;
			GUI.Label(val, message, val2);
			GUI.color = color;
		}

		protected override float CalculateHeight()
		{
			float num = Mathf.Ceil((float)base.Message.Length / 30f);
			float num2 = Mathf.Max(45f, num * 20f + 6f) + 24f;
			return Mathf.Max(60f, num2);
		}
	}
}
namespace Headquarters.Patches
{
	[HarmonyPatch]
	internal static class AchievementPanelPatch
	{
		private const string CUSTOM_MUSIC_PREFIX = "999";

		private const string PANEL_NAME = "PnlAchv";

		private const string LAYER_NAME = "LayAchv";

		private const string TITLE_BASE_NAME = "ImgTittleBaseP";

		private const string STAGE_ACHIEVEMENT_NAME = "ImgStageAchievement";

		private const float MODIFIED_TEXT_X_POSITION = 25f;

		private const float RESET_TEXT_X_POSITION = 110f;

		private static readonly Dictionary<string, string> _panelCache = new Dictionary<string, string>();

		private static bool _isModified;

		private static IEnumerable<MethodBase> TargetMethods()
		{
			return new MethodInfo[2]
			{
				typeof(PnlPreparation).GetMethod("OnEnable"),
				typeof(PnlPreparation).GetMethod("OnDiffTglChanged")
			};
		}

		private static void Postfix()
		{
			MusicInfo val = GlobalDataBase.s_DbMusicTag.CurMusicInfo();
			if (!IsCustomMusic(val.uid))
			{
				ResetPanelIfModified();
				return;
			}
			string cacheKey = GetCacheKey(val.uid);
			if (_panelCache.TryGetValue(cacheKey, out var value))
			{
				SetPanelText(value);
			}
		}

		internal static void SetPanelText(string text, string uid = null)
		{
			if (TryGetPanelComponents(out var imgBase, out var textComponent))
			{
				ConfigurePanelForCustomContent(imgBase, textComponent, text);
				if (!string.IsNullOrEmpty(uid))
				{
					_panelCache[uid] = text;
				}
				_isModified = true;
			}
		}

		internal static int GetDifficulty(string uid)
		{
			int selectedDiffTglIndex = GlobalDataBase.s_DbMusicTag.selectedDiffTglIndex;
			Dictionary<string, HideBmsInfo> hideBmsInfos = Singleton<SpecialSongManager>.instance.m_HideBmsInfos;
			if (!hideBmsInfos.ContainsKey(uid))
			{
				return selectedDiffTglIndex;
			}
			HideBmsInfo val = hideBmsInfos[uid];
			Dictionary<string, bool> isInvokeHideDic = Singleton<SpecialSongManager>.instance.m_IsInvokeHideDic;
			if (!isInvokeHideDic.ContainsKey(uid) || !isInvokeHideDic[uid] || selectedDiffTglIndex != val.triggerDiff)
			{
				return selectedDiffTglIndex;
			}
			return val.m_HideDiff;
		}

		internal static void ResetPanel()
		{
			if (!TryGetPanelComponents(out var imgBase, out var textComponent))
			{
				return;
			}
			ConfigurePanelForOriginalContent(imgBase, textComponent);
			GameObject val = GameObject.Find("PnlAchv");
			if ((Object)(object)val != (Object)null)
			{
				Transform obj = val.transform.Find("ImgTittleBaseP");
				object obj2;
				if (obj == null)
				{
					obj2 = null;
				}
				else
				{
					Transform child = obj.GetChild(0);
					obj2 = ((child != null) ? ((Component)child).GetComponent<Text>() : null);
				}
				Text val2 = (Text)obj2;
				if ((Object)(object)val2 != (Object)null)
				{
					val2.text = LocalizationManager.Get("stage_achievements");
				}
			}
			GameObject obj3 = GameObject.Find("ImgStageAchievement");
			if (obj3 != null)
			{
				obj3.SetActive(true);
			}
		}

		private static bool IsCustomMusic(string uid)
		{
			return uid.StartsWith("999");
		}

		private static string GetCacheKey(string uid)
		{
			return $"{uid}-{GetDifficulty(uid)}";
		}

		private static void ResetPanelIfModified()
		{
			if (_isModified)
			{
				ResetPanel();
				_isModified = false;
			}
		}

		private static bool TryGetPanelComponents(out Transform imgBase, out Text textComponent)
		{
			imgBase = null;
			textComponent = null;
			try
			{
				GameObject val = GameObject.Find("PnlAchv");
				if ((Object)(object)val == (Object)null)
				{
					return false;
				}
				Transform obj = val.transform.Find("LayAchv");
				imgBase = ((obj != null) ? obj.GetChild(0) : null);
				if ((Object)(object)imgBase == (Object)null)
				{
					return false;
				}
				Transform child = imgBase.GetChild(1);
				if ((Object)(object)child == (Object)null)
				{
					return false;
				}
				textComponent = ((Component)child).GetComponent<Text>();
				return (Object)(object)textComponent != (Object)null;
			}
			catch
			{
				return false;
			}
		}

		private static void ConfigurePanelForCustomContent(Transform imgBase, Text textComponent, string text)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			((Component)imgBase.GetChild(0)).gameObject.SetActive(false);
			Transform transform = ((Component)textComponent).transform;
			transform.localPosition = new Vector3(25f, transform.localPosition.y, transform.localPosition.z);
			textComponent.text = text;
			((Component)imgBase).gameObject.SetActive(true);
		}

		private static void ConfigurePanelForOriginalContent(Transform imgBase, Text textComponent)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			((Component)imgBase.GetChild(0)).gameObject.SetActive(true);
			Transform transform = ((Component)textComponent).transform;
			transform.localPosition = new Vector3(110f, transform.localPosition.y, transform.localPosition.z);
		}
	}
	[HarmonyPatch(typeof(GameAccountSystem), "GetRanks")]
	internal static class GetPanelInfo
	{
		private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true,
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			WriteIndented = true
		};

		private static void Postfix()
		{
			MusicInfo val = GlobalDataBase.s_DbMusicTag.CurMusicInfo();
			if (val.uid.StartsWith("999"))
			{
				InitializeCustomPanel(val);
			}
		}

		private static void InitializeCustomPanel(MusicInfo musicInfo)
		{
			if (SetupPanelUI())
			{
				AchievementPanelPatch.SetPanelText(GetAuthStatusText(LocalizationManager.Get("contacting")));
				int difficulty = AchievementPanelPatch.GetDifficulty(musicInfo.uid);
				if (!AlbumManager.GetByUid(musicInfo.uid).Sheets.TryGetValue(difficulty, out var value))
				{
					AchievementPanelPatch.SetPanelText(GetAuthStatusText(LocalizationManager.Get("retrieve_error")));
				}
				else
				{
					FetchAndDisplaySheetInfo(musicInfo.uid, value, difficulty);
				}
			}
		}

		private static bool SetupPanelUI()
		{
			try
			{
				GameObject val = GameObject.Find("PnlAchv");
				if ((Object)(object)val == (Object)null)
				{
					return false;
				}
				Transform val2 = val.transform.Find("LayAchv");
				if ((Object)(object)val2 == (Object)null)
				{
					return false;
				}
				Transform obj = val.transform.Find("ImgTittleBaseP");
				object obj2;
				if (obj == null)
				{
					obj2 = null;
				}
				else
				{
					Transform child = obj.GetChild(0);
					obj2 = ((child != null) ? ((Component)child).GetComponent<Text>() : null);
				}
				Text val3 = (Text)obj2;
				if ((Object)(object)val3 != (Object)null)
				{
					val3.text = LocalizationManager.Get("headquarters");
				}
				GameObject obj3 = GameObject.Find("ImgStageAchievement");
				if (obj3 != null)
				{
					obj3.SetActive(false);
				}
				for (int i = 0; i < val2.childCount; i++)
				{
					((Component)val2.GetChild(i)).gameObject.SetActive(false);
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		private static void FetchAndDisplaySheetInfo(string musicUid, object sheet, int difficulty)
		{
			try
			{
				string text = sheet.GetType().GetProperty("Md5")?.GetValue(sheet)?.ToString();
				if (string.IsNullOrEmpty(text))
				{
					AchievementPanelPatch.SetPanelText(GetAuthStatusText(LocalizationManager.Get("retrieve_error")));
					return;
				}
				Web.Get(Main.ApiPrefix + "/sheets/" + text, delegate(JsonDocument json, bool success)
				{
					if (!success || json == null)
					{
						HandleApiError(json, musicUid, difficulty);
					}
					else
					{
						string text2 = BuildDisplayText(json.Deserialize<Sheet>(jsonOptions));
						string uid = $"{musicUid}-{difficulty}";
						AchievementPanelPatch.SetPanelText(text2, uid);
					}
				});
			}
			catch
			{
				AchievementPanelPatch.SetPanelText(GetAuthStatusText(LocalizationManager.Get("retrieve_error")));
			}
		}

		private static void HandleApiError(JsonDocument json, string musicUid, int difficulty)
		{
			if (json == null)
			{
				AchievementPanelPatch.SetPanelText(GetAuthStatusText(LocalizationManager.Get("retrieve_error")));
				return;
			}
			try
			{
				ErrorResponse? errorResponse = json.Deserialize<ErrorResponse>(jsonOptions);
				string uid = $"{musicUid}-{difficulty}";
				if (errorResponse.Error == "Not Found")
				{
					AchievementPanelPatch.SetPanelText(GetAuthStatusText(LocalizationManager.Get("not_uploaded")), uid);
				}
				else
				{
					AchievementPanelPatch.SetPanelText(GetAuthStatusText(LocalizationManager.Get("retrieve_error")));
				}
			}
			catch
			{
				AchievementPanelPatch.SetPanelText(GetAuthStatusText(LocalizationManager.Get("retrieve_error")));
			}
		}

		private static string GetAuthStatusText(string additionalText = null)
		{
			string text = (AuthManager.IsAuthenticated ? (LocalizationManager.Get("logged_in_as") + AuthManager.User.Username) : LocalizationManager.Get("not_logged_in"));
			if (!string.IsNullOrEmpty(additionalText))
			{
				return text + "\n\n" + additionalText;
			}
			return text;
		}

		private static string BuildDisplayText(Sheet sheetResponse)
		{
			Chart chart = sheetResponse.Chart;
			int num;
			int num2;
			if (chart == null)
			{
				num = 0;
			}
			else
			{
				num = (chart.Ranked ? 1 : 0);
				if (num != 0)
				{
					num2 = ((sheetResponse.RankedDifficulty != 0) ? 1 : 0);
					goto IL_0021;
				}
			}
			num2 = 0;
			goto IL_0021;
			IL_0021:
			bool flag = (byte)num2 != 0;
			string value = (AuthManager.IsAuthenticated ? (LocalizationManager.Get("logged_in_as") + AuthManager.User.Username) : LocalizationManager.Get("not_logged_in"));
			string value2 = ((num != 0) ? LocalizationManager.Get("ranked") : LocalizationManager.Get("unranked"));
			string value3 = (flag ? LocalizationManager.Get("mp_earnable") : LocalizationManager.Get("mp_unearnable"));
			return $"{value}\n\n{value2}\n{value3}";
		}
	}
	internal static class Names
	{
		internal static string CharacterName => GetCharacterName(DataHelper.selectedRoleIndex);

		internal static string ElfinName => GetElfinName(DataHelper.selectedElfinIndex);

		internal static string GetCharacterName(int index)
		{
			return Singleton<ConfigManager>.instance.GetConfigStringValue("character", index, "cosName");
		}

		internal static string GetElfinName(int index)
		{
			return Singleton<ConfigManager>.instance.GetConfigStringValue("elfin", index, "name");
		}
	}
	[HarmonyPatch(typeof(GameAccountSystem), "SendFavoriteMusic")]
	internal class FavoritesPatch
	{
		private static bool Prefix(string addMusicUid, string removeMusicUid)
		{
			if (!string.IsNullOrEmpty(addMusicUid))
			{
				if (!addMusicUid.StartsWith($"{999}-"))
				{
					return true;
				}
				FavoritesManager.ToggleFavorite(addMusicUid, isFavorite: true);
			}
			else if (!string.IsNullOrEmpty(removeMusicUid))
			{
				if (!removeMusicUid.StartsWith($"{999}-"))
				{
					return true;
				}
				FavoritesManager.ToggleFavorite(removeMusicUid, isFavorite: false);
			}
			return false;
		}
	}
	[HarmonyPatch(typeof(PnlPreparation), "GameStart")]
	internal class GameBattleStartPatch
	{
		private static bool _hasShown;

		private static bool _hasShownBanned;

		private static bool Prefix()
		{
			if (!DataHelper.selectedMusicUid.StartsWith("999") || (GlobalDataBase.s_DbMusicTag.m_SelectedDiffTglIndex == 3 && !DataHelper.isSelectedUnlockMaster))
			{
				return true;
			}
			if (!MelonSettings.EnableAccountSystem)
			{
				return true;
			}
			AbstractMessageBox messageBox = PnlTipsManager.instance.GetMessageBox("PnlSpecialsBmsAsk");
			if (!AuthManager.IsAuthenticated)
			{
				if (!_hasShown)
				{
					messageBox.Show("TIPS", "You are not logged into Headquarters. If you do not connect your account, you will not be able to submit scores.");
					_hasShown = true;
					return false;
				}
			}
			else if (AuthManager.User.Banned && !_hasShownBanned)
			{
				messageBox.Show("TIPS", "Your Headquarters account has been banned, so you are not allowed to submit scores. Contact an administrator if you believe this is an error.");
				_hasShownBanned = true;
				return false;
			}
			return true;
		}
	}
	[HarmonyPatch(typeof(GameAccountSystem), "GetRanks")]
	internal static class GetRanksPatch
	{
		private static bool Prefix(string musicUid, int difficulty, Action<JToken, JToken, int> callback, Action<long, string> failCallback)
		{
			if (!musicUid.StartsWith("999"))
			{
				return true;
			}
			Album byUid = AlbumManager.GetByUid(musicUid);
			if (byUid == null)
			{
				failCallback.Invoke(404L, "");
				return false;
			}
			string md = byUid.Sheets[difficulty].Md5;
			try
			{
				Web.Get(Main.ApiPrefix + "/sheets/" + md + "/scores?format=md&limit=99", delegate(JsonDocument json, bool success)
				{
					if (!success)
					{
						failCallback.Invoke(404L, "");
					}
					else
					{
						int @int = json.RootElement.GetProperty("code").GetInt32();
						string rawText = json.RootElement.GetProperty("result").GetRawText();
						string rawText2 = json.RootElement.GetProperty("rank").GetRawText();
						JArray val = JArray.Parse(rawText);
						JObject val2 = JObject.Parse(rawText2);
						callback.Invoke((JToken)(object)val, (JToken)(object)val2, @int);
					}
				});
			}
			catch (Exception ex)
			{
				MelonLogger.Error("Error fetching ranks: " + ex.Message);
				failCallback.Invoke(404L, "");
			}
			return false;
		}
	}
	[HarmonyPatch(typeof(GameAccountSystem), "IsLoggedIn")]
	internal class IsLoggedInPatch
	{
		private static void Postfix(ref bool __result)
		{
			if (DataHelper.selectedMusicUid != null && DataHelper.selectedMusicUid.StartsWith("999"))
			{
				__result = true;
			}
		}
	}
	[HarmonyPatch(typeof(PnlRank), "UIRefresh")]
	internal class UiRefreshPatch
	{
		private static void Postfix(PnlRank __instance, string uid)
		{
			if (uid.StartsWith("999") && __instance.server.activeSelf && AuthManager.IsAuthenticated)
			{
				__instance.txtServerName.text = AuthManager.User.Username;
			}
		}
	}
	[PatchShield]
	[HarmonyPatch(typeof(GameAccountSystem), "UploadScore")]
	internal class UploadScorePatch
	{
		private static readonly Logger _logger = new Logger("UploadScorePatch");

		private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true,
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			WriteIndented = true
		};

		private static bool Prefix(SceneUploadResultData resData, List<Beat> beats)
		{
			if (!resData.musicUid.StartsWith("999"))
			{
				return true;
			}
			if (!MelonSettings.EnableAccountSystem)
			{
				return false;
			}
			if (!AuthManager.IsAuthenticated)
			{
				return false;
			}
			Album chart = AlbumManager.GetByUid(resData.musicUid);
			Sheet val = chart.Sheets[resData.musicDifficulty];
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				["score"] = resData.score.ToString(CultureInfo.InvariantCulture),
				["acc"] = resData.accuracy.ToString(CultureInfo.InvariantCulture),
				["combo"] = resData.combo.ToString(CultureInfo.InvariantCulture),
				["characterId"] = resData.roleUid,
				["elfinId"] = resData.elfinUid ?? "-1",
				["hp"] = resData.hp.ToString(CultureInfo.InvariantCulture),
				["mod_version"] = MelonBase.FindMelon("Headquarters", "AshtonMemer").Info.Version
			};
			Web.Post(Main.ApiPrefix + "/sheets/" + val.Md5 + "/scores", data, delegate(JsonDocument json, bool success)
			{
				if (!success || json == null)
				{
					ErrorResponse errorResponse = json.Deserialize<ErrorResponse>(jsonOptions);
					_logger.Error("Failed to upload score: " + errorResponse.Message + "\n" + json.RootElement.GetRawText());
				}
				else if (MelonSettings.EnablePopups)
				{
					PopupManager.ShowTextPopup(LocalizationManager.Get("score_submitted").Replace("{0}", chart.Info.Name));
				}
			});
			return false;
		}
	}
}
namespace Headquarters.Managers
{
	public static class AuthManager
	{
		private const int PollingInterval = 5;

		private const int TokenRefreshInterval = 840;

		private const int TokenExpirationMs = 900000;

		private const string TokenFileName = "mdmc.dat";

		private static readonly Logger logger = new Logger("AuthManager");

		private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true,
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			WriteIndented = true
		};

		private static object _activePollingRoutine = null;

		private static object _activeRefreshRoutine = null;

		private static DateTime _lastTokenRefreshTime = DateTime.MinValue;

		internal static string AccessToken { get; private set; } = string.Empty;

		internal static string RefreshToken { get; private set; } = string.Empty;

		internal static string PairingCode { get; private set; } = string.Empty;

		public static User User { get; private set; }

		public static bool IsAuthenticated
		{
			get
			{
				if (!string.IsNullOrEmpty(AccessToken))
				{
					return !string.IsNullOrEmpty(RefreshToken);
				}
				return false;
			}
		}

		internal static TimeSpan TimeUntilNextRefresh
		{
			get
			{
				if (_lastTokenRefreshTime == DateTime.MinValue || !IsAuthenticated)
				{
					return TimeSpan.Zero;
				}
				TimeSpan timeSpan = DateTime.UtcNow - _lastTokenRefreshTime;
				TimeSpan timeSpan2 = TimeSpan.FromSeconds(840.0) - timeSpan;
				if (!(timeSpan2 > TimeSpan.Zero))
				{
					return TimeSpan.Zero;
				}
				return timeSpan2;
			}
		}

		internal static TimeSpan TimeUntilTokenExpires
		{
			get
			{
				if (_lastTokenRefreshTime == DateTime.MinValue || !IsAuthenticated)
				{
					return TimeSpan.Zero;
				}
				TimeSpan timeSpan = DateTime.UtcNow - _lastTokenRefreshTime;
				TimeSpan timeSpan2 = TimeSpan.FromMilliseconds(900000.0) - timeSpan;
				if (!(timeSpan2 > TimeSpan.Zero))
				{
					return TimeSpan.Zero;
				}
				return timeSpan2;
			}
		}

		internal static bool IsTokenNearExpiration
		{
			get
			{
				if (IsAuthenticated)
				{
					return TimeUntilTokenExpires <= TimeSpan.FromMinutes(2.0);
				}
				return false;
			}
		}

		internal static void SetTokens(string accessToken, string refreshToken)
		{
			if (string.IsNullOrWhiteSpace(accessToken))
			{
				throw new ArgumentException("Access token cannot be null or empty", "accessToken");
			}
			if (string.IsNullOrWhiteSpace(refreshToken))
			{
				throw new ArgumentException("Refresh token cannot be null or empty", "refreshToken");
			}
			AccessToken = accessToken;
			RefreshToken = refreshToken;
			_lastTokenRefreshTime = DateTime.UtcNow;
			StartAutomaticTokenRefresh();
			logger.Success("Authentication tokens updated successfully");
			logger.Msg($"Next token refresh in: {TimeUntilNextRefresh:mm\\:ss}");
		}

		internal static void ClearTokens()
		{
			AccessToken = string.Empty;
			RefreshToken = string.Empty;
			User = null;
			_lastTokenRefreshTime = DateTime.MinValue;
			StopPolling();
			StopAutomaticTokenRefresh();
			logger.Msg("Authentication tokens cleared");
		}

		internal static void CreatePairingCode(Action<string> onSuccess)
		{
			try
			{
				Web.Post(Main.ApiPrefix + "/auth/session/code", delegate(JsonDocument json, bool success)
				{
					if (!success || json == null)
					{
						HandleApiError(json, "Failed to create pairing code");
					}
					else
					{
						PairingCodeResponse pairingCodeResponse = json.Deserialize<PairingCodeResponse>(jsonOptions);
						if (pairingCodeResponse == null || string.IsNullOrEmpty(pairingCodeResponse.Code))
						{
							logger.Error("Failed to create pairing code: Invalid response");
						}
						else
						{
							PairingCode = pairingCodeResponse.Code;
							logger.Success("Pairing code created: " + PairingCode);
							onSuccess?.Invoke(PairingCode);
							StartPolling();
						}
					}
				});
			}
			catch (Exception ex)
			{
				logger.Error("Exception while creating pairing code: " + ex.Message);
			}
		}

		internal static void LoadToken()
		{
			try
			{
				if (!File.Exists("mdmc.dat"))
				{
					logger.Msg("No saved token file found");
					PopupManager.ShowLoginPrompt(Main.LinkUrl);
					return;
				}
				string text = File.ReadAllText("mdmc.dat");
				if (string.IsNullOrWhiteSpace(text))
				{
					logger.Warning("Loaded token is empty");
					DeleteTokenFile();
					PopupManager.ShowLoginPrompt(Main.LinkUrl);
					return;
				}
				RefreshToken = text.Trim();
				logger.Msg("Token loaded from file");
				RefreshAccessToken(delegate(bool success)
				{
					if (success)
					{
						PopupManager.ShowTextPopup("Welcome back to Headquarters, " + User.Username + "!");
						FavoritesManager.SyncFavorites();
					}
					else
					{
						logger.Warning("Loaded token is invalid or expired");
						PopupManager.ShowLoginPrompt(Main.LinkUrl);
					}
				});
			}
			catch (Exception ex)
			{
				logger.Error("Failed to load token: " + ex.Message);
				DeleteTokenFile();
			}
		}

		internal static void RefreshAccessToken(Action<bool> onResult = null)
		{
			MelonCoroutines.Start(RefreshAccessTokenRoutine(onResult));
		}

		internal static IEnumerator RefreshAccessTokenRoutine(Action<bool> onComplete = null)
		{
			if (string.IsNullOrEmpty(RefreshToken))
			{
				logger.Warning("Cannot refresh token: Refresh token is empty");
				onComplete?.Invoke(obj: false);
				yield break;
			}
			logger.Msg("Refreshing access token...");
			Dictionary<string, string> data = new Dictionary<string, string> { { "token", RefreshToken } };
			bool isRequestDone = false;
			JsonDocument resultJson = null;
			bool resultSuccess = false;
			Web.Post(Main.ApiPrefix + "/auth/refresh", data, delegate(JsonDocument json, bool success)
			{
				resultJson = json;
				resultSuccess = success;
				isRequestDone = true;
			});
			while (!isRequestDone)
			{
				yield return null;
			}
			try
			{
				if (!resultSuccess || resultJson == null)
				{
					HandleApiError(resultJson, "Failed to refresh token");
					HandleInvalidToken();
					onComplete?.Invoke(obj: false);
					yield break;
				}
				RefreshTokenResponse refreshTokenResponse = resultJson.Deserialize<RefreshTokenResponse>(jsonOptions);
				if (refreshTokenResponse == null || string.IsNullOrEmpty(refreshTokenResponse.AccessToken) || string.IsNullOrEmpty(refreshTokenResponse.RefreshToken))
				{
					logger.Error("Failed to refresh token: Invalid response");
					HandleInvalidToken();
					onComplete?.Invoke(obj: false);
				}
				else
				{
					SetTokens(refreshTokenResponse.AccessToken, refreshTokenResponse.RefreshToken);
					User = refreshTokenResponse.User;
					SaveToken();
					logger.Success("Token refreshed successfully");
					onComplete?.Invoke(obj: true);
				}
			}
			catch (Exception ex)
			{
				logger.Error("Exception while refreshing token: " + ex.Message);
				HandleInvalidToken();
			}
		}

		internal static void StopPolling()
		{
			if (_activePollingRoutine != null)
			{
				MelonCoroutines.Stop(_activePollingRoutine);
				_activePollingRoutine = null;
				logger.Msg("Pairing code polling stopped");
			}
		}

		internal static void StartAutomaticTokenRefresh()
		{
			if (IsAuthenticated)
			{
				StopAutomaticTokenRefresh();
				_activeRefreshRoutine = MelonCoroutines.Start(AutoRefreshLoop());
			}
		}

		private static IEnumerator AutoRefreshLoop()
		{
			logger.Msg("Automatic token refresh started");
			while (IsAuthenticated)
			{
				yield return (object)new WaitForSecondsRealtime(840f);
				bool flag = false;
				try
				{
					if (IsAuthenticated)
					{
						logger.Msg("Automatic token refresh triggered");
						flag = true;
					}
				}
				catch (Exception ex)
				{
					logger.Error("Error during pre-refresh check: " + ex.Message);
				}
				if (!flag)
				{
					continue;
				}
				yield return MelonCoroutines.Start(RefreshAccessTokenRoutine());
				bool flag2 = false;
				try
				{
					if (!IsAuthenticated)
					{
						logger.Warning("Token refresh failed, stopping automatic refresh");
						break;
					}
				}
				catch (Exception ex2)
				{
					logger.Error("Error during post-refresh check: " + ex2.Message);
					flag2 = true;
				}
				if (flag2)
				{
					yield return (object)new WaitForSecondsRealtime(60f);
				}
			}
			_activeRefreshRoutine = null;
			logger.Msg("Automatic token refresh stopped");
		}

		internal static void StopAutomaticTokenRefresh()
		{
			if (_activeRefreshRoutine != null)
			{
				MelonCoroutines.Stop(_activeRefreshRoutine);
				_activeRefreshRoutine = null;
				logger.Msg("Automatic token refresh stopped");
			}
		}

		private static void StartPolling()
		{
			if (string.IsNullOrEmpty(PairingCode))
			{
				logger.Error("Cannot start polling: Pairing code is empty");
				return;
			}
			StopPolling();
			logger.Msg("Starting pairing code polling...");
			_activePollingRoutine = MelonCoroutines.Start(PollingRoutine());
		}

		private static IEnumerator PollingRoutine()
		{
			while (true)
			{
				yield return (object)new WaitForSecondsRealtime(5f);
				bool isRequestDone = false;
				JsonDocument resultJson = null;
				bool resultSuccess = false;
				Web.Get(Main.ApiPrefix + "/auth/session/status?code=" + PairingCode, delegate(JsonDocument json, bool success)
				{
					resultJson = json;
					resultSuccess = success;
					isRequestDone = true;
				});
				while (!isRequestDone)
				{
					yield return null;
				}
				if (!resultSuccess || resultJson == null)
				{
					HandleApiError(resultJson, "Failed to check pairing code status");
					continue;
				}
				SessionStatusResponse sessionStatusResponse;
				try
				{
					sessionStatusResponse = resultJson.Deserialize<SessionStatusResponse>(jsonOptions);
				}
				catch (Exception ex)
				{
					logger.Error("Error deserializing pairing status response: " + ex.Message);
					break;
				}
				if (sessionStatusResponse == null)
				{
					logger.Error("Invalid response while checking pairing status");
					break;
				}
				logger.Msg("Pairing status: " + sessionStatusResponse.Status);
				if (sessionStatusResponse.Status == "completed")
				{
					yield return MelonCoroutines.Start(HandleSuccessfulPairing(sessionStatusResponse));
					break;
				}
				if (!(sessionStatusResponse.Status == "expired") && !(sessionStatusResponse.Status == "cancelled"))
				{
					continue;
				}
				logger.Warning("Pairing code " + sessionStatusResponse.Status);
				break;
			}
			_activePollingRoutine = null;
		}

		private static IEnumerator HandleSuccessfulPairing(SessionStatusResponse response)
		{
			if (string.IsNullOrEmpty(response.AccessToken) || string.IsNullOrEmpty(response.RefreshToken))
			{
				logger.Error("Pairing completed but tokens are missing");
				yield break;
			}
			try
			{
				SetTokens(response.AccessToken, response.RefreshToken);
				User = response.User;
				SaveToken();
				string text = User?.Username ?? "Unknown User";
				logger.Success("Welcome, " + text + "! You are now authenticated.", isImportant: true);
				PopupManager.ShowTextPopup("Connected to Headquarters as " + text + "!");
				PopupManager.CloseLargePopup();
			}
			catch (Exception ex)
			{
				logger.Error("Error handling successful pairing: " + ex.Message);
			}
		}

		private static void SaveToken()
		{
			if (string.IsNullOrEmpty(RefreshToken))
			{
				logger.Warning("Cannot save token: Refresh token is empty");
				return;
			}
			try
			{
				File.WriteAllText("mdmc.dat", RefreshToken);
				logger.Msg("Token saved successfully");
			}
			catch (Exception ex)
			{
				logger.Error("Failed to save token: " + ex.Message);
			}
		}

		private static void HandleInvalidToken()
		{
			ClearTokens();
			DeleteTokenFile();
		}

		private static void DeleteTokenFile()
		{
			try
			{
				if (File.Exists("mdmc.dat"))
				{
					File.Delete("mdmc.dat");
					logger.Msg("Token file deleted");
				}
			}
			catch (Exception ex)
			{
				logger.Error("Failed to delete token file: " + ex.Message);
			}
		}

		private static void HandleApiError(JsonDocument json, string defaultMessage)
		{
			try
			{
				if (json != null)
				{
					ErrorResponse errorResponse = json.Deserialize<ErrorResponse>(jsonOptions);
					string text = errorResponse?.Message ?? errorResponse?.Error ?? defaultMessage;
					logger.Error(defaultMessage + ": " + text);
				}
				else
				{
					logger.Error(defaultMessage + ": No response data");
				}
			}
			catch (Exception ex)
			{
				logger.Error(defaultMessage + ": " + ex.Message);
			}
		}
	}
	internal static class FavoritesManager
	{
		private static readonly List<Album> Favorites = new List<Album>();

		private static readonly Logger logger = new Logger("FavoritesManager");

		private static bool _isInitialized;

		public static void Initialize()
		{
			if (!MelonSettings.EnableAccountSystem || !MelonSettings.EnableFavoritesSyncing)
			{
				return;
			}
			Favorites.Clear();
			string path = Path.Combine(MelonEnvironment.UserDataDirectory, "CustomAlbums.json");
			if (!File.Exists(path))
			{
				logger.Warning("CustomAlbums.json not found. Skipping favorites initialization.");
				return;
			}
			if (!(JsonNode.Parse(File.ReadAllText(path)) is JsonObject jsonObject))
			{
				logger.Error("CustomAlbums.json is not a valid JSON object.");
				return;
			}
			if (!jsonObject.ContainsKey("Collections"))
			{
				logger.Error("CustomAlbums.json does not contain a 'Collections' key.");
			}
			if (!(jsonObject["Collections"] is JsonArray source))
			{
				logger.Error("CustomAlbums.json 'Collections' key is not an array.");
				return;
			}
			foreach (string item in source.Select((JsonNode x) => x.ToString()).ToList())
			{
				if (!AlbumManager.LoadedAlbums.TryGetValue(item, out var value))
				{
					logger.Msg("Album " + item + " not found in loaded albums. Skipping...");
				}
				else if (!value.Sheets.ContainsKey(2))
				{
					logger.Warning("Album " + item + " does not contain a sheet for map 2? How did this shit even load?");
				}
				else
				{
					Favorites.Add(value);
				}
			}
			_isInitialized = true;
		}

		public static async void SyncFavorites()
		{
			if (!AuthManager.IsAuthenticated || !_isInitialized)
			{
				return;
			}
			List<string> list = Favorites.Select((Album x) => x.Sheets[2].Md5).ToList();
			if (list.Count == 0)
			{
				return;
			}
			JsonArray jsonArray = new JsonArray();
			foreach (string item in list)
			{
				jsonArray.Add((object?)item);
			}
			Dictionary<string, string> data = new Dictionary<string, string> { ["hashes"] = jsonArray.ToJsonString() };
			Web.Post(Main.ApiPrefix + "/users/" + AuthManager.User.Id + "/likes", data, delegate(JsonDocument json, bool success)
			{
				if (!success)
				{
					if (json == null)
					{
						logger.Error("Failed to sync favorites: JSON is not valid.");
					}
					else
					{
						logger.Error("Failed to sync favorites:\n" + json.RootElement.GetRawText());
					}
				}
			});
		}

		public static async void ToggleFavorite(string uid, bool isFavorite)
		{
			if (!AuthManager.IsAuthenticated || !_isInitialized)
			{
				return;
			}
			Album byUid = AlbumManager.GetByUid(uid);
			if (byUid == null)
			{
				logger.Warning("Album " + uid + " not found. What?");
				return;
			}
			if (!byUid.Sheets.TryGetValue(2, out var value))
			{
				logger.Warning("Album " + uid + " does not contain a sheet for map 2? How did this shit even load?");
				return;
			}
			Dictionary<string, string> data = new Dictionary<string, string> { ["strictly"] = isFavorite.ToString().ToLower() };
			Web.Post(Main.ApiPrefix + "/charts/" + value.Md5 + "/like", data, delegate(JsonDocument json, bool success)
			{
				if (!success)
				{
					if (json == null)
					{
						logger.Error("Failed to sync favorites: JSON is not valid.");
					}
					else
					{
						logger.Error("Failed to sync favorite:\n" + json.RootElement.GetRawText());
					}
				}
			});
		}
	}
	internal static class LocalizationManager
	{
		private static readonly string[] Languages = new string[5] { "ChineseS", "ChineseT", "English", "Japanese", "Korean" };

		private static readonly Dictionary<string, JsonObject> LocalizationData = new Dictionary<string, JsonObject>();

		internal static string CurrentLanguage => SingletonScriptableObject<LocalizationSettings>.instance.GetActiveOption("Language");

		internal static string Get(string key)
		{
			if (LocalizationData.TryGetValue(CurrentLanguage, out var value))
			{
				if (!value.ContainsKey(key))
				{
					return key;
				}
				return value[key].ToString();
			}
			return key;
		}

		internal static void Initialize()
		{
			string[] languages = Languages;
			foreach (string text in languages)
			{
				string text2 = text + ".json";
				string name = "Headquarters.Localization." + text2;
				using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
				if (stream == null)
				{
					MelonLogger.Warning("Resource " + text2 + " not found.");
					continue;
				}
				using StreamReader streamReader = new StreamReader(stream);
				if (!(JsonNode.Parse(streamReader.ReadToEnd()) is JsonObject value))
				{
					MelonLogger.Warning(text2 + " is not a valid JSON object.");
				}
				else
				{
					LocalizationData[text] = value;
				}
			}
		}
	}
	[RegisterTypeInIl2Cpp]
	internal class PopupManager : MonoBehaviour
	{
		public static class Easing
		{
			public static float OutCubic(float t)
			{
				return 1f - Mathf.Pow(1f - t, 3f);
			}

			public static float InOutCubic(float t)
			{
				if (!(t < 0.5f))
				{
					return 1f - Mathf.Pow(-2f * t + 2f, 3f) / 2f;
				}
				return 4f * t * t * t;
			}
		}

		private static readonly Logger _logger = new Logger("PopupManager");

		private readonly Queue<Popup> _popupQueue = new Queue<Popup>();

		private readonly List<Popup> _activePopups = new List<Popup>();

		private LargePopup _currentLargePopup;

		private GUIStyle _textPopupStyle;

		private GUIStyle _choicePopupStyle;

		private GUIStyle _buttonStyle;

		private GUIStyle _largePopupStyle;

		private GUIStyle _codeStyle;

		private GUIStyle _titleStyle;

		private bool _stylesInitialized;

		public const float POPUP_WIDTH = 320f;

		public const float POPUP_MARGIN = 20f;

		public const float BUTTON_HEIGHT = 30f;

		public const float POPUP_PADDING = 12f;

		public const float FADE_DURATION = 0.4f;

		public const float TEXT_POPUP_DURATION = 3.5f;

		public const float TEXT_HEIGHT_PADDING = 6f;

		public const float LARGE_POPUP_WIDTH = 600f;

		public const float LARGE_POPUP_HEIGHT = 400f;

		public const float LARGE_POPUP_PADDING = 30f;

		public const float LARGE_BUTTON_HEIGHT = 40f;

		public const float CODE_BOX_HEIGHT = 60f;

		public const float CLOSE_BUTTON_SIZE = 30f;

		public const int MESSAGE_FONT_SIZE = 16;

		public const int BUTTON_FONT_SIZE = 15;

		public const int LARGE_TITLE_FONT_SIZE = 24;

		public const int LARGE_MESSAGE_FONT_SIZE = 18;

		public const int CODE_FONT_SIZE = 32;

		public const int LARGE_BUTTON_FONT_SIZE = 16;

		public const float BORDER_WIDTH = 2f;

		public const float BUTTON_BORDER_WIDTH = 1f;

		public static readonly Color POPUP_BACKGROUND_COLOR = new Color(0.23529412f, 8f / 51f, 37f / 85f, 1f);

		public static readonly Color POPUP_BORDER_COLOR = new Color(13f / 85f, 8f / 85f, 0.3019608f, 1f);

		public static readonly Color BUTTON_NORMAL_COLOR = new Color(0.88235295f, 0.003921569f, 0.9843137f, 1f);

		public static readonly Color BUTTON_HOVER_COLOR = new Color(42f / 85f, 0f, 255f, 1f);

		public static readonly Color BUTTON_ACTIVE_COLOR = new Color(0.3f, 0.3f, 0.3f, 1f);

		public static readonly Color TEXT_COLOR = new Color(1f, 1f, 1f, 1f);

		public static readonly Color CODE_BACKGROUND_COLOR = new Color(0.11764706f, 4f / 51f, 11f / 51f, 1f);

		public static readonly Color OVERLAY_COLOR = new Color(0f, 0f, 0f, 0.7f);

		public static PopupManager Instance { get; private set; }

		public IReadOnlyList<Popup> ActivePopups => _activePopups;

		public PopupManager(IntPtr intPtr)
			: base(intPtr)
		{
		}

		private void Update()
		{
			ProcessQueue();
			UpdateActivePopups();
			UpdateLargePopup();
		}

		private void OnGUI()
		{
			if (!_stylesInitialized)
			{
				InitializeStyles();
			}
			DrawLargePopup();
			DrawPopups();
		}

		public static void ShowTextPopup(string message)
		{
			if ((Object)(object)Instance == (Object)null)
			{
				_logger.Warning("PopupManager not initialized");
				return;
			}
			TextPopup item = new TextPopup(message);
			Instance._popupQueue.Enqueue(item);
		}

		public static void ShowChoicePopup(string message, string confirmText = "OK", string cancelText = "Cancel", Action onConfirm = null, Action onCancel = null)
		{
			if ((Object)(object)Instance == (Object)null)
			{
				_logger.Warning("PopupManager not initialized");
				return;
			}
			ChoicePopup item = new ChoicePopup(message, confirmText, cancelText, onConfirm, onCancel);
			Instance._popupQueue.Enqueue(item);
		}

		public static void ShowLargePopup(string title, string message, string code = null, string extraButtonText = null, Action onExtraButton = null, Action onClose = null)
		{
			if ((Object)(object)Instance == (Object)null)
			{
				_logger.Warning("PopupManager not initialized");
				return;
			}
			Instance._currentLargePopup?.StartClosing();
			Instance._currentLargePopup = new LargePopup(title, message, code, extraButtonText, onExtraButton, onClose)
			{
				StartTime = Time.time
			};
		}

		public static void ShowLoginPrompt(string linkingUrl)
		{
			ShowChoicePopup("You are not logged into Headquarters.\n\nWould you like to link your account in order to submit scores?", "Yes, Link Account", "Not Now", async delegate
			{
				AuthManager.CreatePairingCode(delegate(string code)
				{
					ShowLargePopup("Link Your Account", "Enter this code on the website to link your account:\n\nThis code is valid for 5 minutes.", code, "Open Linking Page", delegate
					{
						OpenUrl(linkingUrl);
					}, delegate
					{
						AuthManager.StopPolling();
						if (!AuthManager.IsAuthenticated)
						{
							ShowLoginPrompt(linkingUrl);
						}
					});
				});
			});
		}

		public static void CloseLargePopup()
		{
			if (Instance?._currentLargePopup != null)
			{
				Instance._currentLargePopup.StartClosing();
			}
		}

		public static void Initialize()
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if ((Object)(object)Instance == (Object)null)
			{
				GameObject val = new GameObject("PopupManager");
				Instance = val.AddComponent<PopupManager>();
				Object.DontDestroyOnLoad((Object)val);
				_logger.Success("PopupManager initialized.");
			}
			else
			{
				_logger.Warning("PopupManager is already initialized.");
			}
		}

		public static void ClearAllPopups()
		{
			if (!((Object)(object)Instance == (Object)null))
			{
				Instance._popupQueue.Clear();
				Instance._activePopups.Clear();
				Instance._currentLargePopup = null;
			}
		}

		public static void OpenUrl(string url)
		{
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true
				});
				_logger.Success("Opened URL: " + url);
			}
			catch (Exception ex)
			{
				_logger.Error("Failed to open URL: " + ex.Message);
			}
		}

		public static void CopyToClipboard(string text)
		{
			try
			{
				GUIUtility.systemCopyBuffer = text;
				_logger.Success("Copied to clipboard: " + text);
				ShowTextPopup("Copied '" + text + "' to clipboard!");
			}
			catch (Exception ex)
			{
				_logger.Error("Failed to copy to clipboard: " + ex.Message);
				ShowTextPopup("Failed to copy to clipboard");
			}
		}

		private void ProcessQueue()
		{
			if (_popupQueue.Count > 0 && CanShowNewPopup())
			{
				Popup popup = _popupQueue.Dequeue();
				popup.StartTime = Time.time;
				popup.CalculatePosition(_activePopups.Count);
				_activePopups.Add(popup);
			}
		}

		private bool CanShowNewPopup()
		{
			if (_activePopups.Count != 0)
			{
				if (_activePopups.Count < 5)
				{
					return Time.time - _activePopups.Last().StartTime > 0.5f;
				}
				return false;
			}
			return true;
		}

		private void UpdateActivePopups()
		{
			for (int num = _activePopups.Count - 1; num >= 0; num--)
			{
				Popup popup = _activePopups[num];
				popup.Update();
				if (popup.ShouldRemove)
				{
					_activePopups.RemoveAt(num);
					RecalculatePositions();
				}
				else
				{
					popup.CalculatePosition(num);
				}
			}
		}

		private void UpdateLargePopup()
		{
			if (_currentLargePopup != null)
			{
				_currentLargePopup.Update();
				if (_currentLargePopup.ShouldRemove)
				{
					_currentLargePopup = null;
				}
			}
		}

		private void RecalculatePositions()
		{
			for (int i = 0; i < _activePopups.Count; i++)
			{
				_activePopups[i].CalculatePosition(i);
			}
		}

		private void DrawPopups()
		{
			foreach (Popup activePopup in _activePopups)
			{
				activePopup.Draw(_textPopupStyle, _choicePopupStyle, _buttonStyle);
			}
		}

		private void DrawLargePopup()
		{
			_currentLargePopup?.Draw(_largePopupStyle, _titleStyle, _codeStyle, _buttonStyle);
		}

		private void InitializeStyles()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00a1: Expected O, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			//IL_00cc: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_00ff: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected O, but got Unknown
			//IL_01ab: Expected O, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected O, but got Unknown
			//IL_024a: Expected O, but got Unknown
			Texture2D background = CreateSolidColorTexture(POPUP_BACKGROUND_COLOR);
			Texture2D background2 = CreateSolidColorTexture(BUTTON_NORMAL_COLOR);
			Texture2D background3 = CreateSolidColorTexture(BUTTON_HOVER_COLOR);
			Texture2D background4 = CreateSolidColorTexture(BUTTON_ACTIVE_COLOR);
			Texture2D background5 = CreateSolidColorTexture(CODE_BACKGROUND_COLOR);
			GUIStyle val = new GUIStyle(GUI.skin.box)
			{
				fontSize = 16,
				alignment = (TextAnchor)4,
				wordWrap = true
			};
			val.normal.background = background;
			val.normal.textColor = TEXT_COLOR;
			val.padding = new RectOffset(15, 15, 10, 10);
			val.border = new RectOffset(2, 2, 2, 2);
			_textPopupStyle = val;
			_choicePopupStyle = new GUIStyle(_textPopupStyle)
			{
				alignment = (TextAnchor)1,
				padding = new RectOffset(15, 15, 15, 10)
			};
			_largePopupStyle = new GUIStyle(_textPopupStyle)
			{
				fontSize = 18,
				alignment = (TextAnchor)1,
				padding = new RectOffset(20, 20, 20, 20)
			};
			GUIStyle val2 = new GUIStyle(GUI.skin.label)
			{
				fontSize = 24,
				fontStyle = (FontStyle)1,
				alignment = (TextAnchor)1
			};
			val2.normal.textColor = TEXT_COLOR;
			val2.wordWrap = true;
			_titleStyle = val2;
			GUIStyle val3 = new GUIStyle(GUI.skin.box)
			{
				fontSize = 32,
				fontStyle = (FontStyle)1,
				alignment = (TextAnchor)4
			};
			val3.normal.background = background5;
			val3.normal.textColor = TEXT_COLOR;
			val3.padding = new RectOffset(15, 15, 15, 15);
			val3.border = new RectOffset(2, 2, 2, 2);
			_codeStyle = val3;
			GUIStyle val4 = new GUIStyle(GUI.skin.button)
			{
				fontSize = 15,
				alignment = (TextAnchor)4,
				fontStyle = (FontStyle)1
			};
			val4.normal.background = background2;
			val4.normal.textColor = TEXT_COLOR;
			val4.hover.background = background3;
			val4.hover.textColor = TEXT_COLOR;
			val4.active.background = background4;
			val4.active.textColor = TEXT_COLOR;
			val4.padding = new RectOffset(10, 10, 8, 8);
			val4.border = new RectOffset(2, 2, 2, 2);
			_buttonStyle = val4;
			_stylesInitialized = true;
		}

		private static Texture2D CreateSolidColorTexture(Color color)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			Texture2D val = new Texture2D(4, 4);
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					val.SetPixel(i, j, color);
				}
			}
			val.Apply();
			return val;
		}

		public static void DrawBorder(Rect rect, float borderWidth)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			GUI.DrawTexture(new Rect(((Rect)(ref rect)).x, ((Rect)(ref rect)).y, ((Rect)(ref rect)).width, borderWidth), (Texture)(object)Texture2D.whiteTexture);
			GUI.DrawTexture(new Rect(((Rect)(ref rect)).x, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height - borderWidth, ((Rect)(ref rect)).width, borderWidth), (Texture)(object)Texture2D.whiteTexture);
			GUI.DrawTexture(new Rect(((Rect)(ref rect)).x, ((Rect)(ref rect)).y, borderWidth, ((Rect)(ref rect)).height), (Texture)(object)Texture2D.whiteTexture);
			GUI.DrawTexture(new Rect(((Rect)(ref rect)).x + ((Rect)(ref rect)).width - borderWidth, ((Rect)(ref rect)).y, borderWidth, ((Rect)(ref rect)).height), (Texture)(object)Texture2D.whiteTexture);
		}

		public static void DrawButtonWithBorder(Rect rect, Color backgroundColor, float borderWidth)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			GUI.color = backgroundColor;
			GUI.DrawTexture(rect, (Texture)(object)Texture2D.whiteTexture);
			GUI.color = POPUP_BORDER_COLOR;
			DrawBorder(rect, borderWidth);
		}
	}
}
namespace Headquarters.Data
{
	internal class Chart
	{
		public string Id { get; set; } = string.Empty;

		public string Title { get; set; } = string.Empty;

		public string TitleRomanized { get; set; }

		public string Artist { get; set; } = string.Empty;

		public string Charter { get; set; } = string.Empty;

		public string Bpm { get; set; } = string.Empty;

		public bool Ranked { get; set; }
	}
	internal class Sheet
	{
		public string Id { get; set; } = string.Empty;

		public Chart Chart { get; set; }

		public string Difficulty { get; set; } = string.Empty;

		public int RankedDifficulty { get; set; }

		public string Charter { get; set; } = string.Empty;

		public string Hash { get; set; } = string.Empty;

		public int Map { get; set; }
	}
	public class User
	{
		public string Id { get; set; } = string.Empty;

		public int Uid { get; set; }

		public string DiscordId { get; set; } = string.Empty;

		public string Username { get; set; } = string.Empty;

		public UserProfile Profile { get; set; } = new UserProfile();

		public bool Banned { get; set; }
	}
	public class UserProfile
	{
		public string Bio { get; set; } = string.Empty;

		public string[] Badges { get; set; } = Array.Empty<string>();

		public string PeroPeroId { get; set; }

		public string Avatar { get; set; }

		public string Banner { get; set; }
	}
}
namespace Headquarters.Data.Responses
{
	internal class ErrorResponse
	{
		public string Error { get; set; } = string.Empty;

		public string Message { get; set; } = string.Empty;
	}
	internal class PairingCodeResponse
	{
		public string Code { get; set; } = string.Empty;

		public int ExpiresIn { get; set; }
	}
	internal class RefreshTokenResponse
	{
		public string AccessToken { get; set; } = string.Empty;

		public string RefreshToken { get; set; } = string.Empty;

		public User User { get; set; }
	}
	internal class SessionStatusResponse
	{
		public string Status { get; set; } = string.Empty;

		public string AccessToken { get; set; } = string.Empty;

		public string RefreshToken { get; set; } = string.Empty;

		public User User { get; set; }
	}
}
