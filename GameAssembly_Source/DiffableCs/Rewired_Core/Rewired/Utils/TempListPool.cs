namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class TempListPool
{
	private static class eljarZdYiJzfqtBAIIKLDJGnBFewA
	{
		private static ADictionary<Type, List`1<Object>> kpXyBibRrWVBTKQuWGLkZJsNBjMDA; //Field offset: 0x2C927B4

		private static ADictionary<Type, List`1<Object>> snPPPIgMkCJaamiaEBVTyzspqTrN
		{
			private get { } //Length: 126
		}

		private static ADictionary<Type, List`1<Object>> cuZXIGfBnaoffIRGBYkexjCQkQwt() { }

		public static TList<> hHMGnmEXADARjhsTFcQEjIUHWvkBA(List<> unnamed_param_0) { }

		public static void SigadiKBhyYFokJChAYFHHOAncjV(TList<> unnamed_param_0) { }

		public static void TIWlPgfaGufdFBhysiChIRXnJxnP() { }

		public static void TIWlPgfaGufdFBhysiChIRXnJxnP(Type unnamed_param_0) { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	public interface ITListSetter
	{

		public void SetList(List<T> list) { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	public sealed class TList : IDisposable, ITListSetter<T>
	{
		private List<T> mECxxWkCqbkiOJrUgGqXCWtkklh; //Field offset: 0x0
		private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x0

		public List<T> list
		{
			 get { } //Length: 55
		}

		private TList`1() { }

		public static TList<T> Create() { }

		public override void Dispose() { }

		public List<T> get_list() { }

		public static List<T> op_Implicit(TList<T> obj) { }

		private override void Rewired.Utils.TempListPool.ITListSetter<T>.SetList(List<T> unnamed_param_0) { }

		private void SigadiKBhyYFokJChAYFHHOAncjV() { }

		private static void ZZSJyKYpBbcKQGDsPTqNedwZVKtX() { }

	}

	private const int ghsNrKkDHDqVrxzRtWdgHXCWKIFI = 10; //Field offset: 0x69F00
	private static ADictionary<Type, List`1<IList>> qUtYIEkITxFRHgINRtTTbFfYBPDzA; //Field offset: 0x69F33
	private const int ovBDwopsQVbAdjOOZrRpWRlvAjMAA = 3; //Field offset: 0x2C927B4

	private static ADictionary<Type, List`1<IList>> lists
	{
		private get { } //Length: 126
	}

	private static ADictionary<Type, List`1<IList>> baJsplCnVQRBxGpShVhMNBrtyZrr() { }

	public static void Clear() { }

	public static void Clear(Type listType) { }

	public static List<T> Get() { }

	public static List<T> Get(int capacity) { }

	public static TList<T> GetTList() { }

	public static TList<T> GetTList(int capacity) { }

	public static void Return(List<T> list) { }

	public static void Return(List<T> list1, List<T> list2) { }

	public static void Return(List<T> list1, List<T> list2, List<T> list3) { }

	public static void ReturnTList(TList<T> tList) { }

}

