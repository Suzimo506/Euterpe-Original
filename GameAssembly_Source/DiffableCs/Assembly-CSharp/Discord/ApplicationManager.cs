namespace Discord;

public class ApplicationManager
{
	public struct FFIEvents
	{

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetCurrentBranchMethod : MulticastDelegate
		{

			public GetCurrentBranchMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder branch, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, StringBuilder branch) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetCurrentLocaleMethod : MulticastDelegate
		{

			public GetCurrentLocaleMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder locale, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, StringBuilder locale) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetOAuth2TokenCallback : MulticastDelegate
		{

			public GetOAuth2TokenCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref OAuth2Token oauth2Token, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref OAuth2Token oauth2Token, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, ref OAuth2Token oauth2Token) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetOAuth2TokenMethod : MulticastDelegate
		{

			public GetOAuth2TokenMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, GetOAuth2TokenCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, GetOAuth2TokenCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetTicketCallback : MulticastDelegate
		{

			public GetTicketCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref string data, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref string data, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, ref string data) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetTicketMethod : MulticastDelegate
		{

			public GetTicketMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, GetTicketCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, GetTicketCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ValidateOrExitCallback : MulticastDelegate
		{

			public ValidateOrExitCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ValidateOrExitMethod : MulticastDelegate
		{

			public ValidateOrExitMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ValidateOrExitCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, ValidateOrExitCallback callback) { }

		}

		internal ValidateOrExitMethod ValidateOrExit; //Field offset: 0x0
		internal GetCurrentLocaleMethod GetCurrentLocale; //Field offset: 0x8
		internal GetCurrentBranchMethod GetCurrentBranch; //Field offset: 0x10
		internal GetOAuth2TokenMethod GetOAuth2Token; //Field offset: 0x18
		internal GetTicketMethod GetTicket; //Field offset: 0x20

	}

	internal sealed class GetOAuth2TokenHandler : MulticastDelegate
	{

		public GetOAuth2TokenHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, ref OAuth2Token oauth2Token, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref OAuth2Token oauth2Token, IAsyncResult result) { }

		public override void Invoke(Result result, ref OAuth2Token oauth2Token) { }

	}

	internal sealed class GetTicketHandler : MulticastDelegate
	{

		public GetTicketHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, ref string data, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref string data, IAsyncResult result) { }

		public override void Invoke(Result result, ref string data) { }

	}

	internal sealed class ValidateOrExitHandler : MulticastDelegate
	{

		public ValidateOrExitHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18

	private FFIMethods Methods
	{
		private get { } //Length: 272
	}

	internal ApplicationManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	private FFIMethods get_Methods() { }

	public string GetCurrentBranch() { }

	public string GetCurrentLocale() { }

	public void GetOAuth2Token(GetOAuth2TokenHandler callback) { }

	[MonoPInvokeCallback]
	private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token) { }

	public void GetTicket(GetTicketHandler callback) { }

	[MonoPInvokeCallback]
	private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data) { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	public void ValidateOrExit(ValidateOrExitHandler callback) { }

	[MonoPInvokeCallback]
	private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result) { }

}

