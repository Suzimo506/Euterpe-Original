namespace Google.Protobuf.Reflection;

internal static class DescriptorUtil
{
	public sealed class IndexedConverter : MulticastDelegate
	{

		public IndexedConverter`2(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TInput element, int index, AsyncCallback callback, object object) { }

		public override TOutput EndInvoke(IAsyncResult result) { }

		public override TOutput Invoke(TInput element, int index) { }

	}


	internal static IList<TOutput> ConvertAndMakeReadOnly(IList<TInput> input, IndexedConverter<TInput, TOutput> converter) { }

}

