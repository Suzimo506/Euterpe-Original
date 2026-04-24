namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRSettings
{
	private IVRSettings FnTable; //Field offset: 0x10

	internal CVRSettings(IntPtr pInterface) { }

	public bool GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) { }

	public float GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) { }

	public int GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) { }

	public string GetSettingsErrorNameFromEnum(EVRSettingsError eError) { }

	public void GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError) { }

	public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) { }

	public void RemoveSection(string pchSection, ref EVRSettingsError peError) { }

	public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError) { }

	public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError) { }

	public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError) { }

	public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError) { }

	public bool Sync(bool bForce, ref EVRSettingsError peError) { }

}

