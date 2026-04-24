namespace Assets.Scripts.GameCore.Managers;

public static class GlobalManagers
{
	private static AbstractFeverManager s_FeverManager; //Field offset: 0x0
	private static AbstractGirlManager s_GirlManager; //Field offset: 0x8

	public static AbstractFeverManager feverManager
	{
		 get { } //Length: 86
	}

	public static AbstractGirlManager girlManager
	{
		 get { } //Length: 87
	}

	private static GlobalManagers() { }

	public static void AwakeInit() { }

	public static AbstractFeverManager get_feverManager() { }

	public static AbstractGirlManager get_girlManager() { }

	public static void Release() { }

	public static void StartInit() { }

}

