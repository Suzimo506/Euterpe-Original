namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRSettings
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetBool : MulticastDelegate
	{

		public _GetBool(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override bool Invoke(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetFloat : MulticastDelegate
	{

		public _GetFloat(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override float EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override float Invoke(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetInt32 : MulticastDelegate
	{

		public _GetInt32(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override int EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override int Invoke(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSettingsErrorNameFromEnum : MulticastDelegate
	{

		public _GetSettingsErrorNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVRSettingsError eError, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVRSettingsError eError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetString : MulticastDelegate
	{

		public _GetString(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override void Invoke(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _RemoveKeyInSection : MulticastDelegate
	{

		public _RemoveKeyInSection(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override void Invoke(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _RemoveSection : MulticastDelegate
	{

		public _RemoveSection(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override void Invoke(string pchSection, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetBool : MulticastDelegate
	{

		public _SetBool(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override void Invoke(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetFloat : MulticastDelegate
	{

		public _SetFloat(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override void Invoke(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetInt32 : MulticastDelegate
	{

		public _SetInt32(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override void Invoke(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetString : MulticastDelegate
	{

		public _SetString(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override void Invoke(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _Sync : MulticastDelegate
	{

		public _Sync(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool bForce, ref EVRSettingsError peError, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref EVRSettingsError peError, IAsyncResult result) { }

		public override bool Invoke(bool bForce, ref EVRSettingsError peError) { }

	}

	internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum; //Field offset: 0x0
	internal _Sync Sync; //Field offset: 0x8
	internal _SetBool SetBool; //Field offset: 0x10
	internal _SetInt32 SetInt32; //Field offset: 0x18
	internal _SetFloat SetFloat; //Field offset: 0x20
	internal _SetString SetString; //Field offset: 0x28
	internal _GetBool GetBool; //Field offset: 0x30
	internal _GetInt32 GetInt32; //Field offset: 0x38
	internal _GetFloat GetFloat; //Field offset: 0x40
	internal _GetString GetString; //Field offset: 0x48
	internal _RemoveSection RemoveSection; //Field offset: 0x50
	internal _RemoveKeyInSection RemoveKeyInSection; //Field offset: 0x58

}

