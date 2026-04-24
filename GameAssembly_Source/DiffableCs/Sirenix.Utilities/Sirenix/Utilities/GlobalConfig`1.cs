namespace Sirenix.Utilities;

public abstract class GlobalConfig : ScriptableObject
{
	private static GlobalConfigAttribute configAttribute; //Field offset: 0x0
	private static T instance; //Field offset: 0x0

	private static GlobalConfigAttribute ConfigAttribute
	{
		private get { } //Length: 652
	}

	public static bool HasInstanceLoaded
	{
		 get { } //Length: 143
	}

	public static T Instance
	{
		 get { } //Length: 548
	}

	protected GlobalConfig`1() { }

	private static GlobalConfigAttribute get_ConfigAttribute() { }

	public static bool get_HasInstanceLoaded() { }

	public static T get_Instance() { }

	public static void LoadInstanceIfAssetExists() { }

	protected override void OnConfigAutoCreated() { }

	public void OpenInEditor() { }

}

