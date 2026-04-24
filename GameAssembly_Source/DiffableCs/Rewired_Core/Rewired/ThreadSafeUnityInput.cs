namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class ThreadSafeUnityInput
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class Keyboard
	{
		private const int LZKnjDKtSFnXsKqktyFLODSDANGM = 132; //Field offset: 0x0
		public static readonly int keyValueIndex_Escape; //Field offset: 0x0
		public static readonly int keyValueIndex_Menu; //Field offset: 0x4
		public static readonly int keyValueIndex_F2; //Field offset: 0x8
		public static readonly int keyValueIndex_UpArrow; //Field offset: 0xC
		public static readonly int keyValueIndex_RightArrow; //Field offset: 0x10
		public static readonly int keyValueIndex_DownArrow; //Field offset: 0x14
		public static readonly int keyValueIndex_LeftArrow; //Field offset: 0x18
		private static readonly Int32[] mNJcSjXShSDBkoNNsabnYPmjPkhg; //Field offset: 0x20
		private readonly int tWDByJEDCTKcdmJJqzTLkYYluHKPA; //Field offset: 0x10
		private readonly Int32[] pmagQUKmHQlUFGIMBPZdGfYTmcsoc; //Field offset: 0x18
		private readonly Boolean[] vYPwiiZVADfavNIFLmGgnFzKqRXv; //Field offset: 0x20
		private bool dDPTnfkiUGCQQHgOhJldFBaHbwjJc; //Field offset: 0x28
		private int ppcSwfTRgVcgmEzcGzyUATpGKNle; //Field offset: 0x2C
		private readonly bool bfVSKnwTvlPQOccariDhVtmaRRJP; //Field offset: 0x30
		private bool vEYJbnhmhpPrxMMNXBuLbjLjCVJgA; //Field offset: 0x31

		public bool enabled
		{
			 get { } //Length: 5
			 set { } //Length: 226
		}

		public int keyCount
		{
			 get { } //Length: 6
		}

		public bool monitoring
		{
			 get { } //Length: 8
		}

		private static Keyboard() { }

		public Keyboard() { }

		private void bvMtRATPywcooigvmEvosofRPvOI() { }

		public void Clear() { }

		public bool get_enabled() { }

		public int get_keyCount() { }

		public bool get_monitoring() { }

		public bool GetKey(KeyCode keyCode) { }

		public void GetKeyValues(Boolean[] values) { }

		public void Initialize() { }

		private void mKzJspFVUcAUbPNhhtdnAcCmMbaQ() { }

		public void Monitor(bool state) { }

		private void muRIHwqwkoKkvtsjmfKxfZFZlpaG() { }

		private void PKjWQxiRYgfcZEqfRxwlqedcqxKO() { }

		public void PostInitialize() { }

		public void set_enabled(bool value) { }

		public void Update() { }

		private void VqrlrYdRHTjakuOHbwmEIxWQEoxR() { }

		private void YnbtUaqXYCICrHlLfTAoLwxnmlRN() { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class Mouse
	{
		private const int SEIAKoQxKrDrpYGDkSFenQFvkamc = 7; //Field offset: 0x0
		private const int IHRHdJLWSOiUNKpSzEjmmDuidoyS = 4; //Field offset: 0x0
		private readonly Boolean[] PpoIcwcfCemRCmKZmtstWxZCnkFM; //Field offset: 0x10
		private readonly Single[] udOAOIdqpZzeiqxOALsgUcXIZDYE; //Field offset: 0x18
		private int ppcSwfTRgVcgmEzcGzyUATpGKNle; //Field offset: 0x20
		private Vector3 tbiegNjtVWlfSeXpJPtWcpKdsIRcA; //Field offset: 0x24
		private bool whUGNXKuzcEggIjMyoLtbOgSFpRS; //Field offset: 0x30
		private bool spmyEEKUkdQLZEOHSikPJZNosScmA; //Field offset: 0x31

		public bool monitoring
		{
			 get { } //Length: 8
		}

		public Vector3 mousePosition
		{
			 get { } //Length: 19
		}

		public bool mousePresent
		{
			 get { } //Length: 5
		}

		public Mouse() { }

		private void bvMtRATPywcooigvmEvosofRPvOI() { }

		private void eFbgvUqcbrilLAKLgFnUWLmThZDk() { }

		public bool get_monitoring() { }

		public Vector3 get_mousePosition() { }

		public bool get_mousePresent() { }

		public float GetAxisRaw(int index) { }

		public void GetAxisRawValues(Single[] axes) { }

		public bool GetButton(int index) { }

		public void GetButtonValues(Boolean[] buttons) { }

		private void mKzJspFVUcAUbPNhhtdnAcCmMbaQ() { }

		public void Monitor(bool state) { }

		private void PKjWQxiRYgfcZEqfRxwlqedcqxKO() { }

		public void PostInitialize() { }

		public void Update() { }

		private void VqrlrYdRHTjakuOHbwmEIxWQEoxR() { }

		private void YnbtUaqXYCICrHlLfTAoLwxnmlRN() { }

	}

	private static Mouse cfklkOpolPSVNzJXCnPlFucXkdnH; //Field offset: 0x0
	private static Keyboard XNsKhIDoOUFsrXDwlPojpsnfVIqr; //Field offset: 0x8

	public static Keyboard keyboard
	{
		 get { } //Length: 126
	}

	public static Mouse mouse
	{
		 get { } //Length: 311
	}

	public static void Deinitialize() { }

	public static Keyboard get_keyboard() { }

	public static Mouse get_mouse() { }

	public static void Initialize() { }

	public static void PostInitialize() { }

	public static void PostInitialize2() { }

	public static void Update() { }

}

