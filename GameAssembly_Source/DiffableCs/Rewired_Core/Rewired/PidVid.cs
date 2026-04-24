namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal struct PidVid : IEquatable<PidVid>
{
	private const string AHmDwrBCTaQIJtfKKNGDEOQpgHGB = "[^a-fA-F0-9]"; //Field offset: 0x0
	public ushort productId; //Field offset: 0x0
	public ushort vendorId; //Field offset: 0x2

	public bool isZero
	{
		 get { } //Length: 18
	}

	public PidVid(ushort unnamed_param_0, ushort unnamed_param_1) { }

	public PidVid(string unnamed_param_0) { }

	public PidVid(Guid unnamed_param_0) { }

	public static bool ArrayContains(String[] pidVids, ref PidVid vidPid) { }

	public bool Equals(string pidVid) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(PidVid other) { }

	public bool get_isZero() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PidVid x, PidVid y) { }

	public static bool op_Inequality(PidVid x, PidVid y) { }

	private bool rtnsfGaxLOwOtCbDUbuOaSRQKABpA(string unnamed_param_0) { }

	public Guid ToProductGuid() { }

	public virtual string ToString() { }

	private static string WLNCJTnURscSigPgfhojsqtRsvfgA(string unnamed_param_0) { }

}

