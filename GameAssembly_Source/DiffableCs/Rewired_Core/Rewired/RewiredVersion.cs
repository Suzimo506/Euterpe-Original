namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal struct RewiredVersion
{
	public int version1; //Field offset: 0x0
	public int version2; //Field offset: 0x4
	public int version3; //Field offset: 0x8
	public int version4; //Field offset: 0xC
	public string unityVersion; //Field offset: 0x10

	public RewiredVersion(int unnamed_param_0, int unnamed_param_1, int unnamed_param_2, int unnamed_param_3, string unnamed_param_4) { }

	public RewiredVersion(string unnamed_param_0) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RewiredVersion a, RewiredVersion b) { }

	public static bool op_GreaterThan(RewiredVersion a, RewiredVersion b) { }

	public static bool op_Inequality(RewiredVersion a, RewiredVersion b) { }

	public static bool op_LessThan(RewiredVersion a, RewiredVersion b) { }

	public virtual string ToString() { }

}

