namespace rail;

internal class RAIL_API_PINVOKE
{
	internal class SWIGExceptionHelper
	{
		internal sealed class ExceptionArgumentDelegate : MulticastDelegate
		{

			public ExceptionArgumentDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(string message, string paramName, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(string message, string paramName) { }

		}

		internal sealed class ExceptionDelegate : MulticastDelegate
		{

			public ExceptionDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(string message) { }

		}

		private static ExceptionDelegate applicationDelegate; //Field offset: 0x0
		private static ExceptionDelegate arithmeticDelegate; //Field offset: 0x8
		private static ExceptionDelegate divideByZeroDelegate; //Field offset: 0x10
		private static ExceptionDelegate indexOutOfRangeDelegate; //Field offset: 0x18
		private static ExceptionDelegate invalidCastDelegate; //Field offset: 0x20
		private static ExceptionDelegate invalidOperationDelegate; //Field offset: 0x28
		private static ExceptionDelegate ioDelegate; //Field offset: 0x30
		private static ExceptionDelegate nullReferenceDelegate; //Field offset: 0x38
		private static ExceptionDelegate outOfMemoryDelegate; //Field offset: 0x40
		private static ExceptionDelegate overflowDelegate; //Field offset: 0x48
		private static ExceptionDelegate systemDelegate; //Field offset: 0x50
		private static ExceptionArgumentDelegate argumentDelegate; //Field offset: 0x58
		private static ExceptionArgumentDelegate argumentNullDelegate; //Field offset: 0x60
		private static ExceptionArgumentDelegate argumentOutOfRangeDelegate; //Field offset: 0x68

		private static SWIGExceptionHelper() { }

		public SWIGExceptionHelper() { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingApplicationException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingArgumentException(string message, string paramName) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingArgumentNullException(string message, string paramName) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingArithmeticException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingDivideByZeroException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingIndexOutOfRangeException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingInvalidCastException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingInvalidOperationException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingIOException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingNullReferenceException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingOutOfMemoryException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingOverflowException(string message) { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static void SetPendingSystemException(string message) { }

		public static void SWIGRegisterExceptionCallbacks_rail_api(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

		public static void SWIGRegisterExceptionCallbacksArgument_rail_api(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	}

	internal class SWIGPendingException
	{
		[ThreadStatic]
		private static Exception pendingException; //Field offset: 0x80000000
		private static int numExceptionsPending; //Field offset: 0x0

		public static bool Pending
		{
			 get { } //Length: 152
		}

		private static SWIGPendingException() { }

		public SWIGPendingException() { }

		public static bool get_Pending() { }

		public static Exception Retrieve() { }

		public static void Set(Exception e) { }

	}

	internal class SWIGStringHelper
	{
		internal sealed class SWIGStringDelegate : MulticastDelegate
		{

			public SWIGStringDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

			public override string EndInvoke(IAsyncResult result) { }

			public override string Invoke(string message) { }

		}

		private static SWIGStringDelegate stringDelegate; //Field offset: 0x2C927B4

		private static SWIGStringHelper() { }

		public SWIGStringHelper() { }

		[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static string CreateString(string cString) { }

		public static void SWIGRegisterStringCallback_rail_api(SWIGStringDelegate stringDelegate) { }

	}

	public const string dll_path = "rail_api64"; //Field offset: 0x0
	protected static SWIGExceptionHelper swigExceptionHelper; //Field offset: 0x0
	protected static SWIGStringHelper swigStringHelper; //Field offset: 0x8

	private static RAIL_API_PINVOKE() { }

	public RAIL_API_PINVOKE() { }

	public static IntPtr AcquireSessionTicketResponse_session_ticket_get(IntPtr jarg1) { }

	public static void AcquireSessionTicketResponse_session_ticket_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AcquireSessionTicketResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncAcquireGameServerSessionTicketResponse_session_ticket_get(IntPtr jarg1) { }

	public static void AsyncAcquireGameServerSessionTicketResponse_session_ticket_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncAcquireGameServerSessionTicketResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncAddFavoriteGameServerResult_server_id_get(IntPtr jarg1) { }

	public static void AsyncAddFavoriteGameServerResult_server_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncAddFavoriteGameServerResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncDeleteStreamFileResult_filename_get(IntPtr jarg1) { }

	public static void AsyncDeleteStreamFileResult_filename_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr AsyncDeleteStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncGetFavoriteGameServersResult_server_id_array_get(IntPtr jarg1) { }

	public static void AsyncGetFavoriteGameServersResult_server_id_array_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncGetFavoriteGameServersResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncGetMyFavoritesWorksResult_spacework_descriptors_get(IntPtr jarg1) { }

	public static void AsyncGetMyFavoritesWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncGetMyFavoritesWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncGetMyFavoritesWorksResult_total_available_works_get(IntPtr jarg1) { }

	public static void AsyncGetMyFavoritesWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncGetMySubscribedWorksResult_spacework_descriptors_get(IntPtr jarg1) { }

	public static void AsyncGetMySubscribedWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncGetMySubscribedWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncGetMySubscribedWorksResult_total_available_works_get(IntPtr jarg1) { }

	public static void AsyncGetMySubscribedWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2) { }

	public static uint AsyncListFileResult_all_file_num_get(IntPtr jarg1) { }

	public static void AsyncListFileResult_all_file_num_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncListFileResult_file_list_get(IntPtr jarg1) { }

	public static void AsyncListFileResult_file_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint AsyncListFileResult_start_index_get(IntPtr jarg1) { }

	public static void AsyncListFileResult_start_index_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncListFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncListFileResult_try_list_file_num_get(IntPtr jarg1) { }

	public static void AsyncListFileResult_try_list_file_num_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncModifyFavoritesWorksResult_failure_ids_get(IntPtr jarg1) { }

	public static void AsyncModifyFavoritesWorksResult_failure_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int AsyncModifyFavoritesWorksResult_modify_flag_get(IntPtr jarg1) { }

	public static void AsyncModifyFavoritesWorksResult_modify_flag_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr AsyncModifyFavoritesWorksResult_success_ids_get(IntPtr jarg1) { }

	public static void AsyncModifyFavoritesWorksResult_success_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncModifyFavoritesWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static ulong AsyncQueryQuotaResult_available_quota_get(IntPtr jarg1) { }

	public static void AsyncQueryQuotaResult_available_quota_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr AsyncQueryQuotaResult_SWIGUpcast(IntPtr jarg1) { }

	public static ulong AsyncQueryQuotaResult_total_quota_get(IntPtr jarg1) { }

	public static void AsyncQueryQuotaResult_total_quota_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr AsyncQuerySpaceWorksResult_spacework_descriptors_get(IntPtr jarg1) { }

	public static void AsyncQuerySpaceWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncQuerySpaceWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncQuerySpaceWorksResult_total_available_works_get(IntPtr jarg1) { }

	public static void AsyncQuerySpaceWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncRateSpaceWorkResult_id_get(IntPtr jarg1) { }

	public static void AsyncRateSpaceWorkResult_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncRateSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncReadFileResult_data_get(IntPtr jarg1) { }

	public static void AsyncReadFileResult_data_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr AsyncReadFileResult_filename_get(IntPtr jarg1) { }

	public static void AsyncReadFileResult_filename_set(IntPtr jarg1, string jarg2) { }

	public static int AsyncReadFileResult_offset_get(IntPtr jarg1) { }

	public static void AsyncReadFileResult_offset_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr AsyncReadFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncReadFileResult_try_read_length_get(IntPtr jarg1) { }

	public static void AsyncReadFileResult_try_read_length_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncReadStreamFileResult_data_get(IntPtr jarg1) { }

	public static void AsyncReadStreamFileResult_data_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr AsyncReadStreamFileResult_filename_get(IntPtr jarg1) { }

	public static void AsyncReadStreamFileResult_filename_set(IntPtr jarg1, string jarg2) { }

	public static int AsyncReadStreamFileResult_offset_get(IntPtr jarg1) { }

	public static void AsyncReadStreamFileResult_offset_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr AsyncReadStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncReadStreamFileResult_try_read_length_get(IntPtr jarg1) { }

	public static void AsyncReadStreamFileResult_try_read_length_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncRemoveFavoriteGameServerResult_server_id_get(IntPtr jarg1) { }

	public static void AsyncRemoveFavoriteGameServerResult_server_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncRemoveFavoriteGameServerResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncRemoveSpaceWorkResult_id_get(IntPtr jarg1) { }

	public static void AsyncRemoveSpaceWorkResult_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncRemoveSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncRenameStreamFileResult_new_filename_get(IntPtr jarg1) { }

	public static void AsyncRenameStreamFileResult_new_filename_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr AsyncRenameStreamFileResult_old_filename_get(IntPtr jarg1) { }

	public static void AsyncRenameStreamFileResult_old_filename_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr AsyncRenameStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncSearchSpaceWorksResult_spacework_descriptors_get(IntPtr jarg1) { }

	public static void AsyncSearchSpaceWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncSearchSpaceWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncSearchSpaceWorksResult_total_available_works_get(IntPtr jarg1) { }

	public static void AsyncSearchSpaceWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncSubscribeSpaceWorksResult_failure_ids_get(IntPtr jarg1) { }

	public static void AsyncSubscribeSpaceWorksResult_failure_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool AsyncSubscribeSpaceWorksResult_subscribe_get(IntPtr jarg1) { }

	public static void AsyncSubscribeSpaceWorksResult_subscribe_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr AsyncSubscribeSpaceWorksResult_success_ids_get(IntPtr jarg1) { }

	public static void AsyncSubscribeSpaceWorksResult_success_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncSubscribeSpaceWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncUpdateMetadataResult_id_get(IntPtr jarg1) { }

	public static void AsyncUpdateMetadataResult_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncUpdateMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int AsyncUpdateMetadataResult_type_get(IntPtr jarg1) { }

	public static void AsyncUpdateMetadataResult_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr AsyncVoteSpaceWorkResult_id_get(IntPtr jarg1) { }

	public static void AsyncVoteSpaceWorkResult_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr AsyncVoteSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr AsyncWriteFileResult_filename_get(IntPtr jarg1) { }

	public static void AsyncWriteFileResult_filename_set(IntPtr jarg1, string jarg2) { }

	public static int AsyncWriteFileResult_offset_get(IntPtr jarg1) { }

	public static void AsyncWriteFileResult_offset_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr AsyncWriteFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncWriteFileResult_try_write_length_get(IntPtr jarg1) { }

	public static void AsyncWriteFileResult_try_write_length_set(IntPtr jarg1, uint jarg2) { }

	public static uint AsyncWriteFileResult_written_length_get(IntPtr jarg1) { }

	public static void AsyncWriteFileResult_written_length_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr AsyncWriteStreamFileResult_filename_get(IntPtr jarg1) { }

	public static void AsyncWriteStreamFileResult_filename_set(IntPtr jarg1, string jarg2) { }

	public static int AsyncWriteStreamFileResult_offset_get(IntPtr jarg1) { }

	public static void AsyncWriteStreamFileResult_offset_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr AsyncWriteStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint AsyncWriteStreamFileResult_try_write_length_get(IntPtr jarg1) { }

	public static void AsyncWriteStreamFileResult_try_write_length_set(IntPtr jarg1, uint jarg2) { }

	public static uint AsyncWriteStreamFileResult_written_length_get(IntPtr jarg1) { }

	public static void AsyncWriteStreamFileResult_written_length_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr BrowserDamageRectNeedsPaintRequest_bgra_data_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_bgra_data_set(IntPtr jarg1, string jarg2) { }

	public static uint BrowserDamageRectNeedsPaintRequest_bgra_height_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_bgra_height_set(IntPtr jarg1, uint jarg2) { }

	public static uint BrowserDamageRectNeedsPaintRequest_bgra_width_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_bgra_width_set(IntPtr jarg1, uint jarg2) { }

	public static int BrowserDamageRectNeedsPaintRequest_offset_x_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_offset_x_set(IntPtr jarg1, int jarg2) { }

	public static int BrowserDamageRectNeedsPaintRequest_offset_y_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_offset_y_set(IntPtr jarg1, int jarg2) { }

	public static float BrowserDamageRectNeedsPaintRequest_page_scale_factor_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_page_scale_factor_set(IntPtr jarg1, float jarg2) { }

	public static uint BrowserDamageRectNeedsPaintRequest_scroll_x_pos_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_scroll_x_pos_set(IntPtr jarg1, uint jarg2) { }

	public static uint BrowserDamageRectNeedsPaintRequest_scroll_y_pos_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_scroll_y_pos_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr BrowserDamageRectNeedsPaintRequest_SWIGUpcast(IntPtr jarg1) { }

	public static uint BrowserDamageRectNeedsPaintRequest_update_bgra_height_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_update_bgra_height_set(IntPtr jarg1, uint jarg2) { }

	public static uint BrowserDamageRectNeedsPaintRequest_update_bgra_width_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_update_bgra_width_set(IntPtr jarg1, uint jarg2) { }

	public static int BrowserDamageRectNeedsPaintRequest_update_offset_x_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_update_offset_x_set(IntPtr jarg1, int jarg2) { }

	public static int BrowserDamageRectNeedsPaintRequest_update_offset_y_get(IntPtr jarg1) { }

	public static void BrowserDamageRectNeedsPaintRequest_update_offset_y_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr BrowserNeedsPaintRequest_bgra_data_get(IntPtr jarg1) { }

	public static void BrowserNeedsPaintRequest_bgra_data_set(IntPtr jarg1, string jarg2) { }

	public static uint BrowserNeedsPaintRequest_bgra_height_get(IntPtr jarg1) { }

	public static void BrowserNeedsPaintRequest_bgra_height_set(IntPtr jarg1, uint jarg2) { }

	public static uint BrowserNeedsPaintRequest_bgra_width_get(IntPtr jarg1) { }

	public static void BrowserNeedsPaintRequest_bgra_width_set(IntPtr jarg1, uint jarg2) { }

	public static int BrowserNeedsPaintRequest_offset_x_get(IntPtr jarg1) { }

	public static void BrowserNeedsPaintRequest_offset_x_set(IntPtr jarg1, int jarg2) { }

	public static int BrowserNeedsPaintRequest_offset_y_get(IntPtr jarg1) { }

	public static void BrowserNeedsPaintRequest_offset_y_set(IntPtr jarg1, int jarg2) { }

	public static float BrowserNeedsPaintRequest_page_scale_factor_get(IntPtr jarg1) { }

	public static void BrowserNeedsPaintRequest_page_scale_factor_set(IntPtr jarg1, float jarg2) { }

	public static uint BrowserNeedsPaintRequest_scroll_x_pos_get(IntPtr jarg1) { }

	public static void BrowserNeedsPaintRequest_scroll_x_pos_set(IntPtr jarg1, uint jarg2) { }

	public static uint BrowserNeedsPaintRequest_scroll_y_pos_get(IntPtr jarg1) { }

	public static void BrowserNeedsPaintRequest_scroll_y_pos_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr BrowserNeedsPaintRequest_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr BrowserRenderNavigateResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr BrowserRenderNavigateResult_url_get(IntPtr jarg1) { }

	public static void BrowserRenderNavigateResult_url_set(IntPtr jarg1, string jarg2) { }

	public static bool BrowserRenderStateChanged_can_go_back_get(IntPtr jarg1) { }

	public static void BrowserRenderStateChanged_can_go_back_set(IntPtr jarg1, bool jarg2) { }

	public static bool BrowserRenderStateChanged_can_go_forward_get(IntPtr jarg1) { }

	public static void BrowserRenderStateChanged_can_go_forward_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr BrowserRenderStateChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr BrowserRenderTitleChanged_new_title_get(IntPtr jarg1) { }

	public static void BrowserRenderTitleChanged_new_title_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr BrowserRenderTitleChanged_SWIGUpcast(IntPtr jarg1) { }

	public static bool BrowserTryNavigateNewPageRequest_is_redirect_request_get(IntPtr jarg1) { }

	public static void BrowserTryNavigateNewPageRequest_is_redirect_request_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr BrowserTryNavigateNewPageRequest_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr BrowserTryNavigateNewPageRequest_target_type_get(IntPtr jarg1) { }

	public static void BrowserTryNavigateNewPageRequest_target_type_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr BrowserTryNavigateNewPageRequest_url_get(IntPtr jarg1) { }

	public static void BrowserTryNavigateNewPageRequest_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr CheckAllDlcsStateReadyResult_SWIGUpcast(IntPtr jarg1) { }

	public static ulong ClearRoomMetadataResult_room_id_get(IntPtr jarg1) { }

	public static void ClearRoomMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr ClearRoomMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr CloseBrowserResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr CompleteConsumeAssetsFinished_asset_item_get(IntPtr jarg1) { }

	public static void CompleteConsumeAssetsFinished_asset_item_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr CompleteConsumeAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr CompleteConsumeByExchangeAssetsToFinished_SWIGUpcast(IntPtr jarg1) { }

	public static bool CreateBrowserOptions_allow_alternate_external_browser_get(IntPtr jarg1) { }

	public static void CreateBrowserOptions_allow_alternate_external_browser_set(IntPtr jarg1, bool jarg2) { }

	public static bool CreateBrowserOptions_has_border_get(IntPtr jarg1) { }

	public static void CreateBrowserOptions_has_border_set(IntPtr jarg1, bool jarg2) { }

	public static bool CreateBrowserOptions_has_maximum_button_get(IntPtr jarg1) { }

	public static void CreateBrowserOptions_has_maximum_button_set(IntPtr jarg1, bool jarg2) { }

	public static bool CreateBrowserOptions_has_minimum_button_get(IntPtr jarg1) { }

	public static void CreateBrowserOptions_has_minimum_button_set(IntPtr jarg1, bool jarg2) { }

	public static bool CreateBrowserOptions_is_movable_get(IntPtr jarg1) { }

	public static void CreateBrowserOptions_is_movable_set(IntPtr jarg1, bool jarg2) { }

	public static int CreateBrowserOptions_margin_left_get(IntPtr jarg1) { }

	public static void CreateBrowserOptions_margin_left_set(IntPtr jarg1, int jarg2) { }

	public static int CreateBrowserOptions_margin_top_get(IntPtr jarg1) { }

	public static void CreateBrowserOptions_margin_top_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr CreateBrowserResult_SWIGUpcast(IntPtr jarg1) { }

	public static int CreateCustomerDrawBrowserOptions_content_offset_x_get(IntPtr jarg1) { }

	public static void CreateCustomerDrawBrowserOptions_content_offset_x_set(IntPtr jarg1, int jarg2) { }

	public static int CreateCustomerDrawBrowserOptions_content_offset_y_get(IntPtr jarg1) { }

	public static void CreateCustomerDrawBrowserOptions_content_offset_y_set(IntPtr jarg1, int jarg2) { }

	public static uint CreateCustomerDrawBrowserOptions_content_window_height_get(IntPtr jarg1) { }

	public static void CreateCustomerDrawBrowserOptions_content_window_height_set(IntPtr jarg1, uint jarg2) { }

	public static uint CreateCustomerDrawBrowserOptions_content_window_width_get(IntPtr jarg1) { }

	public static void CreateCustomerDrawBrowserOptions_content_window_width_set(IntPtr jarg1, uint jarg2) { }

	public static bool CreateCustomerDrawBrowserOptions_has_scroll_get(IntPtr jarg1) { }

	public static void CreateCustomerDrawBrowserOptions_has_scroll_set(IntPtr jarg1, bool jarg2) { }

	public static bool CreateGameServerOptions_enable_team_voice_get(IntPtr jarg1) { }

	public static void CreateGameServerOptions_enable_team_voice_set(IntPtr jarg1, bool jarg2) { }

	public static bool CreateGameServerOptions_has_password_get(IntPtr jarg1) { }

	public static void CreateGameServerOptions_has_password_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr CreateGameServerResult_game_server_id_get(IntPtr jarg1) { }

	public static void CreateGameServerResult_game_server_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr CreateGameServerResult_SWIGUpcast(IntPtr jarg1) { }

	public static ulong CreateRoomResult_room_id_get(IntPtr jarg1) { }

	public static void CreateRoomResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr CreateRoomResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr CreateSessionFailed_local_peer_get(IntPtr jarg1) { }

	public static void CreateSessionFailed_local_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr CreateSessionFailed_remote_peer_get(IntPtr jarg1) { }

	public static void CreateSessionFailed_remote_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr CreateSessionFailed_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr CreateSessionRequest_local_peer_get(IntPtr jarg1) { }

	public static void CreateSessionRequest_local_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr CreateSessionRequest_remote_peer_get(IntPtr jarg1) { }

	public static void CreateSessionRequest_remote_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr CreateSessionRequest_SWIGUpcast(IntPtr jarg1) { }

	public static bool CreateVoiceChannelOption_join_channel_after_created_get(IntPtr jarg1) { }

	public static void CreateVoiceChannelOption_join_channel_after_created_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr CreateVoiceChannelResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr CreateVoiceChannelResult_voice_channel_id_get(IntPtr jarg1) { }

	public static void CreateVoiceChannelResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static void CSharpRailRegisterEvent(int jarg1, RailEventCallBackFunction jarg2) { }

	public static void CSharpRailUnRegisterAllEvent() { }

	public static void CSharpRailUnRegisterEvent(int jarg1, RailEventCallBackFunction jarg2) { }

	public static void delete_AcquireSessionTicketResponse(IntPtr jarg1) { }

	public static void delete_AsyncAcquireGameServerSessionTicketResponse(IntPtr jarg1) { }

	public static void delete_AsyncAddFavoriteGameServerResult(IntPtr jarg1) { }

	public static void delete_AsyncDeleteStreamFileResult(IntPtr jarg1) { }

	public static void delete_AsyncGetFavoriteGameServersResult(IntPtr jarg1) { }

	public static void delete_AsyncGetMyFavoritesWorksResult(IntPtr jarg1) { }

	public static void delete_AsyncGetMySubscribedWorksResult(IntPtr jarg1) { }

	public static void delete_AsyncListFileResult(IntPtr jarg1) { }

	public static void delete_AsyncModifyFavoritesWorksResult(IntPtr jarg1) { }

	public static void delete_AsyncQueryQuotaResult(IntPtr jarg1) { }

	public static void delete_AsyncQuerySpaceWorksResult(IntPtr jarg1) { }

	public static void delete_AsyncRateSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_AsyncReadFileResult(IntPtr jarg1) { }

	public static void delete_AsyncReadStreamFileResult(IntPtr jarg1) { }

	public static void delete_AsyncRemoveFavoriteGameServerResult(IntPtr jarg1) { }

	public static void delete_AsyncRemoveSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_AsyncRenameStreamFileResult(IntPtr jarg1) { }

	public static void delete_AsyncSearchSpaceWorksResult(IntPtr jarg1) { }

	public static void delete_AsyncSubscribeSpaceWorksResult(IntPtr jarg1) { }

	public static void delete_AsyncUpdateMetadataResult(IntPtr jarg1) { }

	public static void delete_AsyncVoteSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_AsyncWriteFileResult(IntPtr jarg1) { }

	public static void delete_AsyncWriteStreamFileResult(IntPtr jarg1) { }

	public static void delete_BrowserDamageRectNeedsPaintRequest(IntPtr jarg1) { }

	public static void delete_BrowserNeedsPaintRequest(IntPtr jarg1) { }

	public static void delete_BrowserRenderNavigateResult(IntPtr jarg1) { }

	public static void delete_BrowserRenderStateChanged(IntPtr jarg1) { }

	public static void delete_BrowserRenderTitleChanged(IntPtr jarg1) { }

	public static void delete_BrowserTryNavigateNewPageRequest(IntPtr jarg1) { }

	public static void delete_CheckAllDlcsStateReadyResult(IntPtr jarg1) { }

	public static void delete_ClearRoomMetadataResult(IntPtr jarg1) { }

	public static void delete_CloseBrowserResult(IntPtr jarg1) { }

	public static void delete_CompleteConsumeAssetsFinished(IntPtr jarg1) { }

	public static void delete_CompleteConsumeByExchangeAssetsToFinished(IntPtr jarg1) { }

	public static void delete_CreateBrowserOptions(IntPtr jarg1) { }

	public static void delete_CreateBrowserResult(IntPtr jarg1) { }

	public static void delete_CreateCustomerDrawBrowserOptions(IntPtr jarg1) { }

	public static void delete_CreateGameServerOptions(IntPtr jarg1) { }

	public static void delete_CreateGameServerResult(IntPtr jarg1) { }

	public static void delete_CreateRoomResult(IntPtr jarg1) { }

	public static void delete_CreateSessionFailed(IntPtr jarg1) { }

	public static void delete_CreateSessionRequest(IntPtr jarg1) { }

	public static void delete_CreateVoiceChannelOption(IntPtr jarg1) { }

	public static void delete_CreateVoiceChannelResult(IntPtr jarg1) { }

	public static void delete_DirectConsumeAssetsFinished(IntPtr jarg1) { }

	public static void delete_DlcInstallFinished(IntPtr jarg1) { }

	public static void delete_DlcInstallProgress(IntPtr jarg1) { }

	public static void delete_DlcInstallStart(IntPtr jarg1) { }

	public static void delete_DlcInstallStartResult(IntPtr jarg1) { }

	public static void delete_DlcOwnershipChanged(IntPtr jarg1) { }

	public static void delete_DlcRefundChanged(IntPtr jarg1) { }

	public static void delete_DlcUninstallFinished(IntPtr jarg1) { }

	public static void delete_EventBase(IntPtr jarg1) { }

	public static void delete_ExchangeAssetsFinished(IntPtr jarg1) { }

	public static void delete_ExchangeAssetsToFinished(IntPtr jarg1) { }

	public static void delete_GameServerInfo(IntPtr jarg1) { }

	public static void delete_GameServerListFilter(IntPtr jarg1) { }

	public static void delete_GameServerListFilterKey(IntPtr jarg1) { }

	public static void delete_GameServerListSorter(IntPtr jarg1) { }

	public static void delete_GameServerPlayerInfo(IntPtr jarg1) { }

	public static void delete_GameServerRegisterToServerListResult(IntPtr jarg1) { }

	public static void delete_GameServerStartSessionWithPlayerResponse(IntPtr jarg1) { }

	public static void delete_GetAllRoomDataResult(IntPtr jarg1) { }

	public static void delete_GetAuthenticateURLResult(IntPtr jarg1) { }

	public static void delete_GetGameServerListResult(IntPtr jarg1) { }

	public static void delete_GetGameServerMetadataResult(IntPtr jarg1) { }

	public static void delete_GetGameServerPlayerListResult(IntPtr jarg1) { }

	public static void delete_GetMemberMetadataResult(IntPtr jarg1) { }

	public static void delete_GetRoomListResult(IntPtr jarg1) { }

	public static void delete_GetRoomMembersResult(IntPtr jarg1) { }

	public static void delete_GetRoomMetadataResult(IntPtr jarg1) { }

	public static void delete_GetRoomTagResult(IntPtr jarg1) { }

	public static void delete_GetUserRoomListResult(IntPtr jarg1) { }

	public static void delete_GlobalAchievementReceived(IntPtr jarg1) { }

	public static void delete_GlobalStatsRequestReceived(IntPtr jarg1) { }

	public static void delete_IRailAchievementHelper(IntPtr jarg1) { }

	public static void delete_IRailApps(IntPtr jarg1) { }

	public static void delete_IRailAssets(IntPtr jarg1) { }

	public static void delete_IRailAssetsHelper(IntPtr jarg1) { }

	public static void delete_IRailBrowser(IntPtr jarg1) { }

	public static void delete_IRailBrowserHelper(IntPtr jarg1) { }

	public static void delete_IRailBrowserRender(IntPtr jarg1) { }

	public static void delete_IRailDlcHelper(IntPtr jarg1) { }

	public static void delete_IRailEvent(IntPtr jarg1) { }

	public static void delete_IRailFactory(IntPtr jarg1) { }

	public static void delete_IRailFile(IntPtr jarg1) { }

	public static void delete_IRailFloatingWindow(IntPtr jarg1) { }

	public static void delete_IRailFriends(IntPtr jarg1) { }

	public static void delete_IRailGame(IntPtr jarg1) { }

	public static void delete_IRailGameServer(IntPtr jarg1) { }

	public static void delete_IRailGameServerHelper(IntPtr jarg1) { }

	public static void delete_IRailGlobalAchievement(IntPtr jarg1) { }

	public static void delete_IRailGlobalStats(IntPtr jarg1) { }

	public static void delete_IRailGroupChat(IntPtr jarg1) { }

	public static void delete_IRailGroupChatHelper(IntPtr jarg1) { }

	public static void delete_IRailHttpResponse(IntPtr jarg1) { }

	public static void delete_IRailHttpSession(IntPtr jarg1) { }

	public static void delete_IRailHttpSessionHelper(IntPtr jarg1) { }

	public static void delete_IRailIMEHelper(IntPtr jarg1) { }

	public static void delete_IRailInGameCoin(IntPtr jarg1) { }

	public static void delete_IRailInGamePurchase(IntPtr jarg1) { }

	public static void delete_IRailInGameStorePurchaseHelper(IntPtr jarg1) { }

	public static void delete_IRailLeaderboard(IntPtr jarg1) { }

	public static void delete_IRailLeaderboardEntries(IntPtr jarg1) { }

	public static void delete_IRailLeaderboardHelper(IntPtr jarg1) { }

	public static void delete_IRailNetwork(IntPtr jarg1) { }

	public static void delete_IRailPlayer(IntPtr jarg1) { }

	public static void delete_IRailPlayerAchievement(IntPtr jarg1) { }

	public static void delete_IRailPlayerStats(IntPtr jarg1) { }

	public static void delete_IRailRoom(IntPtr jarg1) { }

	public static void delete_IRailRoomHelper(IntPtr jarg1) { }

	public static void delete_IRailScreenshot(IntPtr jarg1) { }

	public static void delete_IRailScreenshotHelper(IntPtr jarg1) { }

	public static void delete_IRailSmallObjectServiceHelper(IntPtr jarg1) { }

	public static void delete_IRailSpaceWork(IntPtr jarg1) { }

	public static void delete_IRailStatisticHelper(IntPtr jarg1) { }

	public static void delete_IRailStorageHelper(IntPtr jarg1) { }

	public static void delete_IRailStreamFile(IntPtr jarg1) { }

	public static void delete_IRailSystemHelper(IntPtr jarg1) { }

	public static void delete_IRailTextInputHelper(IntPtr jarg1) { }

	public static void delete_IRailUsersHelper(IntPtr jarg1) { }

	public static void delete_IRailUserSpaceHelper(IntPtr jarg1) { }

	public static void delete_IRailUtils(IntPtr jarg1) { }

	public static void delete_IRailVoiceChannel(IntPtr jarg1) { }

	public static void delete_IRailVoiceHelper(IntPtr jarg1) { }

	public static void delete_IRailZoneServer(IntPtr jarg1) { }

	public static void delete_IRailZoneServerHelper(IntPtr jarg1) { }

	public static void delete_JavascriptEventResult(IntPtr jarg1) { }

	public static void delete_JoinRoomResult(IntPtr jarg1) { }

	public static void delete_JoinVoiceChannelResult(IntPtr jarg1) { }

	public static void delete_KickOffMemberResult(IntPtr jarg1) { }

	public static void delete_LeaderboardAttachSpaceWork(IntPtr jarg1) { }

	public static void delete_LeaderboardCreated(IntPtr jarg1) { }

	public static void delete_LeaderboardData(IntPtr jarg1) { }

	public static void delete_LeaderboardEntry(IntPtr jarg1) { }

	public static void delete_LeaderboardEntryReceived(IntPtr jarg1) { }

	public static void delete_LeaderboardParameters(IntPtr jarg1) { }

	public static void delete_LeaderboardReceived(IntPtr jarg1) { }

	public static void delete_LeaderboardUploaded(IntPtr jarg1) { }

	public static void delete_LeaveRoomResult(IntPtr jarg1) { }

	public static void delete_LeaveVoiceChannelResult(IntPtr jarg1) { }

	public static void delete_MergeAssetsFinished(IntPtr jarg1) { }

	public static void delete_MergeAssetsToFinished(IntPtr jarg1) { }

	public static void delete_NetworkCreateRawSessionFailed(IntPtr jarg1) { }

	public static void delete_NetworkCreateRawSessionRequest(IntPtr jarg1) { }

	public static void delete_NotifyMetadataChange(IntPtr jarg1) { }

	public static void delete_NotifyRoomDestroy(IntPtr jarg1) { }

	public static void delete_NotifyRoomGameServerChange(IntPtr jarg1) { }

	public static void delete_NotifyRoomMemberChange(IntPtr jarg1) { }

	public static void delete_NotifyRoomMemberKicked(IntPtr jarg1) { }

	public static void delete_NotifyRoomOwnerChange(IntPtr jarg1) { }

	public static void delete_NumberOfPlayerReceived(IntPtr jarg1) { }

	public static void delete_OpenRoomResult(IntPtr jarg1) { }

	public static void delete_PlayerAchievementReceived(IntPtr jarg1) { }

	public static void delete_PlayerAchievementStored(IntPtr jarg1) { }

	public static void delete_PlayerGetGamePurchaseKeyResult(IntPtr jarg1) { }

	public static void delete_PlayerPersonalInfo(IntPtr jarg1) { }

	public static void delete_PlayerStatsReceived(IntPtr jarg1) { }

	public static void delete_PlayerStatsStored(IntPtr jarg1) { }

	public static void delete_PublishScreenshotResult(IntPtr jarg1) { }

	public static void delete_QueryIsOwnedDlcsResult(IntPtr jarg1) { }

	public static void delete_QueryMySubscribedSpaceWorksResult(IntPtr jarg1) { }

	public static void delete_QueryPlayerBannedStatus(IntPtr jarg1) { }

	public static void delete_QuerySubscribeWishPlayStateResult(IntPtr jarg1) { }

	public static void delete_RailAntiAddictionGameOnlineTimeChanged(IntPtr jarg1) { }

	public static void delete_RailArrayEnumRailSpaceWorkType(IntPtr jarg1) { }

	public static void delete_RailArrayEnumRailUsersLimits(IntPtr jarg1) { }

	public static void delete_RailArrayEnumRailWorkFileClass(IntPtr jarg1) { }

	public static void delete_RailArrayGameServerInfo(IntPtr jarg1) { }

	public static void delete_RailArrayGameServerListFilter(IntPtr jarg1) { }

	public static void delete_RailArrayGameServerListFilterKey(IntPtr jarg1) { }

	public static void delete_RailArrayGameServerListSorter(IntPtr jarg1) { }

	public static void delete_RailArrayGameServerPlayerInfo(IntPtr jarg1) { }

	public static void delete_RailArrayPlayerPersonalInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRailAssetInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRailAssetItem(IntPtr jarg1) { }

	public static void delete_RailArrayRailAssetProperty(IntPtr jarg1) { }

	public static void delete_RailArrayRailCoinInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRailDlcID(IntPtr jarg1) { }

	public static void delete_RailArrayRailDlcOwned(IntPtr jarg1) { }

	public static void delete_RailArrayRailFriendInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRailFriendMetadata(IntPtr jarg1) { }

	public static void delete_RailArrayRailFriendPlayedGameInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRailGameDefineGamePlayingState(IntPtr jarg1) { }

	public static void delete_RailArrayRailGameID(IntPtr jarg1) { }

	public static void delete_RailArrayRailGeneratedAssetItem(IntPtr jarg1) { }

	public static void delete_RailArrayRailID(IntPtr jarg1) { }

	public static void delete_RailArrayRailKeyValue(IntPtr jarg1) { }

	public static void delete_RailArrayRailKeyValueResult(IntPtr jarg1) { }

	public static void delete_RailArrayRailPlayedWithFriendsGameItem(IntPtr jarg1) { }

	public static void delete_RailArrayRailPlayedWithFriendsTimeItem(IntPtr jarg1) { }

	public static void delete_RailArrayRailProductItem(IntPtr jarg1) { }

	public static void delete_RailArrayRailPurchaseProductInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRailSmallObjectDownloadInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRailSmallObjectState(IntPtr jarg1) { }

	public static void delete_RailArrayRailSpaceWorkDescriptor(IntPtr jarg1) { }

	public static void delete_RailArrayRailSpaceWorkVoteDetail(IntPtr jarg1) { }

	public static void delete_RailArrayRailStreamFileInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRailString(IntPtr jarg1) { }

	public static void delete_RailArrayRailUserPlayedWith(IntPtr jarg1) { }

	public static void delete_RailArrayRailUserSpaceDownloadProgress(IntPtr jarg1) { }

	public static void delete_RailArrayRailUserSpaceDownloadResult(IntPtr jarg1) { }

	public static void delete_RailArrayRailVoiceChannelUserSpeakingState(IntPtr jarg1) { }

	public static void delete_RailArrayRailZoneID(IntPtr jarg1) { }

	public static void delete_RailArrayRoomInfo(IntPtr jarg1) { }

	public static void delete_RailArrayRoomInfoListFilter(IntPtr jarg1) { }

	public static void delete_RailArrayRoomInfoListFilterKey(IntPtr jarg1) { }

	public static void delete_RailArrayRoomInfoListSorter(IntPtr jarg1) { }

	public static void delete_RailArrayRoomMemberInfo(IntPtr jarg1) { }

	public static void delete_RailArraySpaceWorkID(IntPtr jarg1) { }

	public static void delete_RailArrayuint32_t(IntPtr jarg1) { }

	public static void delete_RailArrayuint64_t(IntPtr jarg1) { }

	public static void delete_RailArrayuint8_t(IntPtr jarg1) { }

	public static void delete_RailAssetInfo(IntPtr jarg1) { }

	public static void delete_RailAssetItem(IntPtr jarg1) { }

	public static void delete_RailAssetProperty(IntPtr jarg1) { }

	public static void delete_RailAssetsChanged(IntPtr jarg1) { }

	public static void delete_RailBranchInfo(IntPtr jarg1) { }

	public static void delete_RailCoinInfo(IntPtr jarg1) { }

	public static void delete_RailCoins(IntPtr jarg1) { }

	public static void delete_RailCrashBuffer(IntPtr jarg1) { }

	public static void delete_RailCrashInfo(IntPtr jarg1) { }

	public static void delete_RailCurrencyExchangeCoinRate(IntPtr jarg1) { }

	public static void delete_RailDirtyWordsCheckResult(IntPtr jarg1) { }

	public static void delete_RailDiscountInfo(IntPtr jarg1) { }

	public static void delete_RailDlcID(IntPtr jarg1) { }

	public static void delete_RailDlcInfo(IntPtr jarg1) { }

	public static void delete_RailDlcInstallProgress(IntPtr jarg1) { }

	public static void delete_RailDlcOwned(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAchievementGlobalAchievementReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAchievementPlayerAchievementReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAchievementPlayerAchievementStored(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAppQuerySubscribeWishPlayStateResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsAssetsChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsCompleteConsumeFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsDirectConsumeFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsExchangeAssetsFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsExchangeAssetsToFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsMergeFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsMergeToFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsRequestAllAssetsFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsSplitFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsSplitToFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsStartConsumeFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsUpdateAssetPropertyFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventAssetsUpdateConsumeFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserCloseResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserCreateResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserDamageRectPaint(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserJavascriptEvent(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserNavigeteResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserPaint(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserReloadResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserStateChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserTitleChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventBrowserTryNavigateNewPageRequest(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcCheckAllDlcsStateReadyResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcInstallFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcInstallProgress(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcInstallStart(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcInstallStartResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcOwnershipChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcQueryIsOwnedDlcsResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcRefundChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventDlcUninstallFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFinalize(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsAddFriendResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsClearMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsFriendsListChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsGetFriendPlayedGamesResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsGetInviteCommandLine(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsGetMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsMetadataChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsOnlineStateChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsQueryPlayedWithFriendsListResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsReportPlayedWithUserListResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventFriendsSetMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerAddFavoriteGameServer(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerAuthSessionTicket(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerCreated(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerFavoriteGameServers(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerGetMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerGetSessionTicket(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerListResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerPlayerListResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerRegisterToServerListResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerRemoveFavoriteGameServer(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGameServerSetMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGroupChatOpenGroupChatResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventGroupChatQueryGroupsInfoResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventHttpSessionResponseResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventIMEHelperTextInputCompositionStateChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventIMEHelperTextInputSelectedResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGameCoinPurchaseCoinsResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGameCoinRequestCoinInfoResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGamePurchaseAllProductsInfoReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGamePurchaseFinishOrderResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGamePurchasePurchaseProductsResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGameStorePurchasePaymentResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGameStorePurchasePayWindowClosed(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventInGameStorePurchasePayWindowDisplayed(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventLeaderboardAsyncCreated(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventLeaderboardAttachSpaceWork(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventLeaderboardEntryReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventLeaderboardReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventLeaderboardUploaded(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventNetworkCreateRawSessionFailed(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventNetworkCreateRawSessionRequest(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventNetworkCreateSessionFailed(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventNetworkCreateSessionRequest(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventPlayerGetAuthenticateURL(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventPlayerGetEncryptedGameTicketResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventPlayerGetGamePurchaseKey(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventPlayerGetPlayerMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventQueryPlayerBannedStatus(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomClearRoomMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomCreated(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomGetAllDataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomGetMemberMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomGetRoomListResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomGetRoomMembersResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomGetRoomMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomGetRoomTagResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomGetUserRoomListResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomJoinRoomResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomKickOffMemberResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomLeaveRoomResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomNotifyMemberChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomNotifyMemberkicked(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomNotifyMetadataChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomNotifyRoomDataReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomNotifyRoomDestroyed(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomNotifyRoomGameServerChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomNotifyRoomOwnerChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomOpenRoomResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomSetMemberMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomSetNewRoomOwnerResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomSetRoomMaxMemberResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomSetRoomMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomSetRoomTagResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventRoomSetRoomTypeResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventScreenshotPublishScreenshotFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventScreenshotTakeScreenshotFinished(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventScreenshotTakeScreenshotRequest(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventSessionTicketAuthSessionTicket(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventSessionTicketGetSessionTicket(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventShowFloatingNotifyWindow(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventShowFloatingWindow(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventSmallObjectServiceDownloadResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventSmallObjectServiceQueryObjectStateResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStatsGlobalStatsReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStatsNumOfPlayerReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStatsPlayerStatsReceived(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStatsPlayerStatsStored(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageAsyncDeleteStreamFileResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageAsyncListStreamFileResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageAsyncReadFileResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageAsyncReadStreamFileResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageAsyncRenameStreamFileResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageAsyncWriteFileResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageAsyncWriteStreamFileResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageQueryQuotaResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventStorageShareToSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventSystemStateChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventTextInputShowTextInputWindowResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersCancelInviteResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersGetInviteDetailResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersGetUserLimitsResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersGetUsersInfo(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersInviteJoinGameResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersInviteUsersResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersNotifyInviter(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceDownloadProgress(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceDownloadResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceGetMyFavoritesWorksResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceGetMySubscribedWorksResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceModifyFavoritesWorksResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceQuerySpaceWorksResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceRateSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceRemoveSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceSearchSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceSubscribeResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceSyncResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceUpdateMetadataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUserSpaceVoteSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersRespondInvitation(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersShowChatWindowWithFriendResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUsersShowUserHomepageWindowResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUtilsGameSettingMetadataChanged(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventUtilsGetImageDataResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelAddUsersResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelCreateResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelDataCaptured(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelInviteEvent(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelJoinedResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelLeaveResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelMemberChangedEvent(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelRemoveUsersResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent(IntPtr jarg1) { }

	public static void delete_RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult(IntPtr jarg1) { }

	public static void delete_RailEventkRailPlatformNotifyEventJoinGameByGameServer(IntPtr jarg1) { }

	public static void delete_RailEventkRailPlatformNotifyEventJoinGameByRoom(IntPtr jarg1) { }

	public static void delete_RailEventkRailPlatformNotifyEventJoinGameByUser(IntPtr jarg1) { }

	public static void delete_RailFinalize(IntPtr jarg1) { }

	public static void delete_RailFriendInfo(IntPtr jarg1) { }

	public static void delete_RailFriendMetadata(IntPtr jarg1) { }

	public static void delete_RailFriendOnLineState(IntPtr jarg1) { }

	public static void delete_RailFriendPlayedGameInfo(IntPtr jarg1) { }

	public static void delete_RailFriendsAddFriendRequest(IntPtr jarg1) { }

	public static void delete_RailFriendsAddFriendResult(IntPtr jarg1) { }

	public static void delete_RailFriendsClearMetadataResult(IntPtr jarg1) { }

	public static void delete_RailFriendsGetInviteCommandLine(IntPtr jarg1) { }

	public static void delete_RailFriendsGetMetadataResult(IntPtr jarg1) { }

	public static void delete_RailFriendsListChanged(IntPtr jarg1) { }

	public static void delete_RailFriendsMetadataChanged(IntPtr jarg1) { }

	public static void delete_RailFriendsOnlineStateChanged(IntPtr jarg1) { }

	public static void delete_RailFriendsQueryFriendPlayedGamesResult(IntPtr jarg1) { }

	public static void delete_RailFriendsQueryPlayedWithFriendsGamesResult(IntPtr jarg1) { }

	public static void delete_RailFriendsQueryPlayedWithFriendsListResult(IntPtr jarg1) { }

	public static void delete_RailFriendsQueryPlayedWithFriendsTimeResult(IntPtr jarg1) { }

	public static void delete_RailFriendsReportPlayedWithUserListResult(IntPtr jarg1) { }

	public static void delete_RailFriendsSetMetadataResult(IntPtr jarg1) { }

	public static void delete_RailGameDefineGamePlayingState(IntPtr jarg1) { }

	public static void delete_RailGameID(IntPtr jarg1) { }

	public static void delete_RailGamePeer(IntPtr jarg1) { }

	public static void delete_RailGameSettingMetadataChanged(IntPtr jarg1) { }

	public static void delete_RailGeneratedAssetItem(IntPtr jarg1) { }

	public static void delete_RailGetAuthenticateURLOptions(IntPtr jarg1) { }

	public static void delete_RailGetEncryptedGameTicketResult(IntPtr jarg1) { }

	public static void delete_RailGetImageDataResult(IntPtr jarg1) { }

	public static void delete_RailGetPlayerMetadataResult(IntPtr jarg1) { }

	public static void delete_RailGroupInfo(IntPtr jarg1) { }

	public static void delete_RailHttpSessionResponse(IntPtr jarg1) { }

	public static void delete_RailID(IntPtr jarg1) { }

	public static void delete_RailImageDataDescriptor(IntPtr jarg1) { }

	public static void delete_RailIMEHelperTextInputCompositionState(IntPtr jarg1) { }

	public static void delete_RailIMEHelperTextInputSelectedResult(IntPtr jarg1) { }

	public static void delete_RailInGameCoinPurchaseCoinsResponse(IntPtr jarg1) { }

	public static void delete_RailInGameCoinRequestCoinInfoResponse(IntPtr jarg1) { }

	public static void delete_RailInGamePurchaseFinishOrderResponse(IntPtr jarg1) { }

	public static void delete_RailInGamePurchasePurchaseProductsResponse(IntPtr jarg1) { }

	public static void delete_RailInGamePurchasePurchaseProductsToAssetsResponse(IntPtr jarg1) { }

	public static void delete_RailInGamePurchaseRequestAllProductsResponse(IntPtr jarg1) { }

	public static void delete_RailInGamePurchaseRequestAllPurchasableProductsResponse(IntPtr jarg1) { }

	public static void delete_RailInGameStorePurchasePayWindowClosed(IntPtr jarg1) { }

	public static void delete_RailInGameStorePurchasePayWindowDisplayed(IntPtr jarg1) { }

	public static void delete_RailInGameStorePurchaseResult(IntPtr jarg1) { }

	public static void delete_RailInviteOptions(IntPtr jarg1) { }

	public static void delete_RailKeyValue(IntPtr jarg1) { }

	public static void delete_RailKeyValueResult(IntPtr jarg1) { }

	public static void delete_RailListStreamFileOption(IntPtr jarg1) { }

	public static void delete_RailNetworkSessionState(IntPtr jarg1) { }

	public static void delete_RailOpenGroupChatResult(IntPtr jarg1) { }

	public static void delete_RailPlatformNotifyEventJoinGameByGameServer(IntPtr jarg1) { }

	public static void delete_RailPlatformNotifyEventJoinGameByRoom(IntPtr jarg1) { }

	public static void delete_RailPlatformNotifyEventJoinGameByUser(IntPtr jarg1) { }

	public static void delete_RailPlayedWithFriendsGameItem(IntPtr jarg1) { }

	public static void delete_RailPlayedWithFriendsTimeItem(IntPtr jarg1) { }

	public static void delete_RailProductItem(IntPtr jarg1) { }

	public static void delete_RailPublishFileToUserSpaceOption(IntPtr jarg1) { }

	public static void delete_RailPurchaseProductExtraInfo(IntPtr jarg1) { }

	public static void delete_RailPurchaseProductInfo(IntPtr jarg1) { }

	public static void delete_RailQueryGroupsInfoResult(IntPtr jarg1) { }

	public static void delete_RailQueryWorkFileOptions(IntPtr jarg1) { }

	public static void delete_RailSessionTicket(IntPtr jarg1) { }

	public static void delete_RailShowChatWindowWithFriendResult(IntPtr jarg1) { }

	public static void delete_RailShowUserHomepageWindowResult(IntPtr jarg1) { }

	public static void delete_RailSmallObjectDownloadInfo(IntPtr jarg1) { }

	public static void delete_RailSmallObjectDownloadResult(IntPtr jarg1) { }

	public static void delete_RailSmallObjectState(IntPtr jarg1) { }

	public static void delete_RailSmallObjectStateQueryResult(IntPtr jarg1) { }

	public static void delete_RailSpaceWorkDescriptor(IntPtr jarg1) { }

	public static void delete_RailSpaceWorkFilter(IntPtr jarg1) { }

	public static void delete_RailSpaceWorkSearchFilter(IntPtr jarg1) { }

	public static void delete_RailSpaceWorkSyncProgress(IntPtr jarg1) { }

	public static void delete_RailSpaceWorkUpdateOptions(IntPtr jarg1) { }

	public static void delete_RailSpaceWorkVoteDetail(IntPtr jarg1) { }

	public static void delete_RailStoreOptions(IntPtr jarg1) { }

	public static void delete_RailStreamFileInfo(IntPtr jarg1) { }

	public static void delete_RailStreamFileOption(IntPtr jarg1) { }

	public static void delete_RailString(IntPtr jarg1) { }

	public static void delete_RailSwitchPlayerSelectedZoneResult(IntPtr jarg1) { }

	public static void delete_RailSyncFileOption(IntPtr jarg1) { }

	public static void delete_RailSystemStateChanged(IntPtr jarg1) { }

	public static void delete_RailTextInputImeWindowOption(IntPtr jarg1) { }

	public static void delete_RailTextInputResult(IntPtr jarg1) { }

	public static void delete_RailTextInputWindowOption(IntPtr jarg1) { }

	public static void delete_RailUserPlayedWith(IntPtr jarg1) { }

	public static void delete_RailUsersCancelInviteResult(IntPtr jarg1) { }

	public static void delete_RailUsersGetInviteDetailResult(IntPtr jarg1) { }

	public static void delete_RailUsersGetUserLimitsResult(IntPtr jarg1) { }

	public static void delete_RailUsersInfoData(IntPtr jarg1) { }

	public static void delete_RailUsersInviteJoinGameResult(IntPtr jarg1) { }

	public static void delete_RailUsersInviteUsersResult(IntPtr jarg1) { }

	public static void delete_RailUsersNotifyInviter(IntPtr jarg1) { }

	public static void delete_RailUserSpaceDownloadProgress(IntPtr jarg1) { }

	public static void delete_RailUserSpaceDownloadResult(IntPtr jarg1) { }

	public static void delete_RailUsersRespondInvitation(IntPtr jarg1) { }

	public static void delete_RailVoiceCaptureOption(IntPtr jarg1) { }

	public static void delete_RailVoiceCaptureSpecification(IntPtr jarg1) { }

	public static void delete_RailVoiceChannelID(IntPtr jarg1) { }

	public static void delete_RailVoiceChannelUserSpeakingState(IntPtr jarg1) { }

	public static void delete_RailWindowLayout(IntPtr jarg1) { }

	public static void delete_RailWindowPosition(IntPtr jarg1) { }

	public static void delete_RailZoneID(IntPtr jarg1) { }

	public static void delete_ReloadBrowserResult(IntPtr jarg1) { }

	public static void delete_RequestAllAssetsFinished(IntPtr jarg1) { }

	public static void delete_RequestLeaderboardEntryParam(IntPtr jarg1) { }

	public static void delete_RoomDataReceived(IntPtr jarg1) { }

	public static void delete_RoomInfo(IntPtr jarg1) { }

	public static void delete_RoomInfoListFilter(IntPtr jarg1) { }

	public static void delete_RoomInfoListFilterKey(IntPtr jarg1) { }

	public static void delete_RoomInfoListSorter(IntPtr jarg1) { }

	public static void delete_RoomMemberInfo(IntPtr jarg1) { }

	public static void delete_RoomOptions(IntPtr jarg1) { }

	public static void delete_ScreenshotRequestInfo(IntPtr jarg1) { }

	public static void delete_SetGameServerMetadataResult(IntPtr jarg1) { }

	public static void delete_SetMemberMetadataResult(IntPtr jarg1) { }

	public static void delete_SetNewRoomOwnerResult(IntPtr jarg1) { }

	public static void delete_SetRoomMaxMemberResult(IntPtr jarg1) { }

	public static void delete_SetRoomMetadataResult(IntPtr jarg1) { }

	public static void delete_SetRoomTagResult(IntPtr jarg1) { }

	public static void delete_SetRoomTypeResult(IntPtr jarg1) { }

	public static void delete_ShareStorageToSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_ShowFloatingWindowResult(IntPtr jarg1) { }

	public static void delete_ShowNotifyWindow(IntPtr jarg1) { }

	public static void delete_SpaceWorkID(IntPtr jarg1) { }

	public static void delete_SplitAssetsFinished(IntPtr jarg1) { }

	public static void delete_SplitAssetsToFinished(IntPtr jarg1) { }

	public static void delete_StartConsumeAssetsFinished(IntPtr jarg1) { }

	public static void delete_StartSessionWithPlayerResponse(IntPtr jarg1) { }

	public static void delete_SyncSpaceWorkResult(IntPtr jarg1) { }

	public static void delete_TakeScreenshotResult(IntPtr jarg1) { }

	public static void delete_UpdateAssetsPropertyFinished(IntPtr jarg1) { }

	public static void delete_UpdateConsumeAssetsFinished(IntPtr jarg1) { }

	public static void delete_UploadLeaderboardParam(IntPtr jarg1) { }

	public static void delete_UserSpaceDownloadProgress(IntPtr jarg1) { }

	public static void delete_UserSpaceDownloadResult(IntPtr jarg1) { }

	public static void delete_VoiceChannelAddUsersResult(IntPtr jarg1) { }

	public static void delete_VoiceChannelInviteEvent(IntPtr jarg1) { }

	public static void delete_VoiceChannelMemeberChangedEvent(IntPtr jarg1) { }

	public static void delete_VoiceChannelPushToTalkKeyChangedEvent(IntPtr jarg1) { }

	public static void delete_VoiceChannelRemoveUsersResult(IntPtr jarg1) { }

	public static void delete_VoiceChannelSpeakingUsersChangedEvent(IntPtr jarg1) { }

	public static void delete_VoiceChannelUsersSpeakingStateChangedEvent(IntPtr jarg1) { }

	public static void delete_VoiceDataCapturedEvent(IntPtr jarg1) { }

	public static void DeleteInt(IntPtr jarg1) { }

	public static void DeleteInt64(IntPtr jarg1) { }

	public static IntPtr DirectConsumeAssetsFinished_assets_get(IntPtr jarg1) { }

	public static void DirectConsumeAssetsFinished_assets_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr DirectConsumeAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr DlcInstallFinished_dlc_id_get(IntPtr jarg1) { }

	public static void DlcInstallFinished_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int DlcInstallFinished_result_get(IntPtr jarg1) { }

	public static void DlcInstallFinished_result_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr DlcInstallFinished_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr DlcInstallProgress_dlc_id_get(IntPtr jarg1) { }

	public static void DlcInstallProgress_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr DlcInstallProgress_progress_get(IntPtr jarg1) { }

	public static void DlcInstallProgress_progress_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr DlcInstallProgress_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr DlcInstallStart_dlc_id_get(IntPtr jarg1) { }

	public static void DlcInstallStart_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr DlcInstallStart_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr DlcInstallStartResult_dlc_id_get(IntPtr jarg1) { }

	public static void DlcInstallStartResult_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int DlcInstallStartResult_result_get(IntPtr jarg1) { }

	public static void DlcInstallStartResult_result_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr DlcInstallStartResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr DlcOwnershipChanged_dlc_id_get(IntPtr jarg1) { }

	public static void DlcOwnershipChanged_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool DlcOwnershipChanged_is_active_get(IntPtr jarg1) { }

	public static void DlcOwnershipChanged_is_active_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr DlcOwnershipChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr DlcRefundChanged_dlc_id_get(IntPtr jarg1) { }

	public static void DlcRefundChanged_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int DlcRefundChanged_refund_state_get(IntPtr jarg1) { }

	public static void DlcRefundChanged_refund_state_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr DlcRefundChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr DlcUninstallFinished_dlc_id_get(IntPtr jarg1) { }

	public static void DlcUninstallFinished_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int DlcUninstallFinished_result_get(IntPtr jarg1) { }

	public static void DlcUninstallFinished_result_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr DlcUninstallFinished_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr EventBase_game_id_get(IntPtr jarg1) { }

	public static void EventBase_game_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int EventBase_get_event_id(IntPtr jarg1) { }

	public static IntPtr EventBase_rail_id_get(IntPtr jarg1) { }

	public static void EventBase_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int EventBase_result_get(IntPtr jarg1) { }

	public static void EventBase_result_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr EventBase_user_data_get(IntPtr jarg1) { }

	public static void EventBase_user_data_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr ExchangeAssetsFinished_new_asset_item_list_get(IntPtr jarg1) { }

	public static void ExchangeAssetsFinished_new_asset_item_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr ExchangeAssetsFinished_old_assets_get(IntPtr jarg1) { }

	public static void ExchangeAssetsFinished_old_assets_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr ExchangeAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static ulong ExchangeAssetsToFinished_exchange_to_asset_id_get(IntPtr jarg1) { }

	public static void ExchangeAssetsToFinished_exchange_to_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr ExchangeAssetsToFinished_old_assets_get(IntPtr jarg1) { }

	public static void ExchangeAssetsToFinished_old_assets_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr ExchangeAssetsToFinished_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr ExchangeAssetsToFinished_to_product_info_get(IntPtr jarg1) { }

	public static void ExchangeAssetsToFinished_to_product_info_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint GameServerInfo_bot_players_get(IntPtr jarg1) { }

	public static void GameServerInfo_bot_players_set(IntPtr jarg1, uint jarg2) { }

	public static uint GameServerInfo_current_players_get(IntPtr jarg1) { }

	public static void GameServerInfo_current_players_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr GameServerInfo_game_server_map_get(IntPtr jarg1) { }

	public static void GameServerInfo_game_server_map_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerInfo_game_server_name_get(IntPtr jarg1) { }

	public static void GameServerInfo_game_server_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerInfo_game_server_rail_id_get(IntPtr jarg1) { }

	public static void GameServerInfo_game_server_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool GameServerInfo_has_password_get(IntPtr jarg1) { }

	public static void GameServerInfo_has_password_set(IntPtr jarg1, bool jarg2) { }

	public static bool GameServerInfo_is_dedicated_get(IntPtr jarg1) { }

	public static void GameServerInfo_is_dedicated_set(IntPtr jarg1, bool jarg2) { }

	public static bool GameServerInfo_is_friend_only_get(IntPtr jarg1) { }

	public static void GameServerInfo_is_friend_only_set(IntPtr jarg1, bool jarg2) { }

	public static uint GameServerInfo_max_players_get(IntPtr jarg1) { }

	public static void GameServerInfo_max_players_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr GameServerInfo_owner_rail_id_get(IntPtr jarg1) { }

	public static void GameServerInfo_owner_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static void GameServerInfo_Reset(IntPtr jarg1) { }

	public static IntPtr GameServerInfo_server_description_get(IntPtr jarg1) { }

	public static void GameServerInfo_server_description_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerInfo_server_fullname_get(IntPtr jarg1) { }

	public static void GameServerInfo_server_fullname_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerInfo_server_host_get(IntPtr jarg1) { }

	public static void GameServerInfo_server_host_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerInfo_server_info_get(IntPtr jarg1) { }

	public static void GameServerInfo_server_info_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerInfo_server_kvs_get(IntPtr jarg1) { }

	public static void GameServerInfo_server_kvs_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GameServerInfo_server_mods_get(IntPtr jarg1) { }

	public static void GameServerInfo_server_mods_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GameServerInfo_server_tags_get(IntPtr jarg1) { }

	public static void GameServerInfo_server_tags_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerInfo_server_version_get(IntPtr jarg1) { }

	public static void GameServerInfo_server_version_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerInfo_spectator_host_get(IntPtr jarg1) { }

	public static void GameServerInfo_spectator_host_set(IntPtr jarg1, string jarg2) { }

	public static int GameServerListFilter_filter_dedicated_server_get(IntPtr jarg1) { }

	public static void GameServerListFilter_filter_dedicated_server_set(IntPtr jarg1, int jarg2) { }

	public static int GameServerListFilter_filter_friends_created_get(IntPtr jarg1) { }

	public static void GameServerListFilter_filter_friends_created_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr GameServerListFilter_filter_game_server_host_get(IntPtr jarg1) { }

	public static void GameServerListFilter_filter_game_server_host_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerListFilter_filter_game_server_map_get(IntPtr jarg1) { }

	public static void GameServerListFilter_filter_game_server_map_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerListFilter_filter_game_server_name_get(IntPtr jarg1) { }

	public static void GameServerListFilter_filter_game_server_name_set(IntPtr jarg1, string jarg2) { }

	public static int GameServerListFilter_filter_password_get(IntPtr jarg1) { }

	public static void GameServerListFilter_filter_password_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr GameServerListFilter_filters_get(IntPtr jarg1) { }

	public static void GameServerListFilter_filters_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GameServerListFilter_owner_id_get(IntPtr jarg1) { }

	public static void GameServerListFilter_owner_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GameServerListFilter_tags_contained_get(IntPtr jarg1) { }

	public static void GameServerListFilter_tags_contained_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerListFilter_tags_not_contained_get(IntPtr jarg1) { }

	public static void GameServerListFilter_tags_not_contained_set(IntPtr jarg1, string jarg2) { }

	public static int GameServerListFilterKey_comparison_type_get(IntPtr jarg1) { }

	public static void GameServerListFilterKey_comparison_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr GameServerListFilterKey_filter_value_get(IntPtr jarg1) { }

	public static void GameServerListFilterKey_filter_value_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GameServerListFilterKey_key_name_get(IntPtr jarg1) { }

	public static void GameServerListFilterKey_key_name_set(IntPtr jarg1, string jarg2) { }

	public static int GameServerListFilterKey_value_type_get(IntPtr jarg1) { }

	public static void GameServerListFilterKey_value_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr GameServerListSorter_sort_key_get(IntPtr jarg1) { }

	public static void GameServerListSorter_sort_key_set(IntPtr jarg1, string jarg2) { }

	public static int GameServerListSorter_sort_type_get(IntPtr jarg1) { }

	public static void GameServerListSorter_sort_type_set(IntPtr jarg1, int jarg2) { }

	public static int GameServerListSorter_sort_value_type_get(IntPtr jarg1) { }

	public static void GameServerListSorter_sort_value_type_set(IntPtr jarg1, int jarg2) { }

	public static int GameServerListSorter_sorter_key_type_get(IntPtr jarg1) { }

	public static void GameServerListSorter_sorter_key_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr GameServerPlayerInfo_member_id_get(IntPtr jarg1) { }

	public static void GameServerPlayerInfo_member_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GameServerPlayerInfo_member_nickname_get(IntPtr jarg1) { }

	public static void GameServerPlayerInfo_member_nickname_set(IntPtr jarg1, string jarg2) { }

	public static long GameServerPlayerInfo_member_score_get(IntPtr jarg1) { }

	public static void GameServerPlayerInfo_member_score_set(IntPtr jarg1, long jarg2) { }

	public static IntPtr GameServerRegisterToServerListResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr GameServerStartSessionWithPlayerResponse_remote_rail_id_get(IntPtr jarg1) { }

	public static void GameServerStartSessionWithPlayerResponse_remote_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GameServerStartSessionWithPlayerResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr GetAllRoomDataResult_room_info_get(IntPtr jarg1) { }

	public static void GetAllRoomDataResult_room_info_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GetAllRoomDataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr GetAuthenticateURLResult_authenticate_url_get(IntPtr jarg1) { }

	public static void GetAuthenticateURLResult_authenticate_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GetAuthenticateURLResult_source_url_get(IntPtr jarg1) { }

	public static void GetAuthenticateURLResult_source_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GetAuthenticateURLResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint GetAuthenticateURLResult_ticket_expire_time_get(IntPtr jarg1) { }

	public static void GetAuthenticateURLResult_ticket_expire_time_set(IntPtr jarg1, uint jarg2) { }

	public static uint GetGameServerListResult_end_index_get(IntPtr jarg1) { }

	public static void GetGameServerListResult_end_index_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr GetGameServerListResult_server_info_get(IntPtr jarg1) { }

	public static void GetGameServerListResult_server_info_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint GetGameServerListResult_start_index_get(IntPtr jarg1) { }

	public static void GetGameServerListResult_start_index_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr GetGameServerListResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint GetGameServerListResult_total_num_get(IntPtr jarg1) { }

	public static void GetGameServerListResult_total_num_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr GetGameServerMetadataResult_game_server_id_get(IntPtr jarg1) { }

	public static void GetGameServerMetadataResult_game_server_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GetGameServerMetadataResult_key_value_get(IntPtr jarg1) { }

	public static void GetGameServerMetadataResult_key_value_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GetGameServerMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr GetGameServerPlayerListResult_game_server_id_get(IntPtr jarg1) { }

	public static void GetGameServerPlayerListResult_game_server_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GetGameServerPlayerListResult_server_player_info_get(IntPtr jarg1) { }

	public static void GetGameServerPlayerListResult_server_player_info_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GetGameServerPlayerListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int GetInt(IntPtr jarg1) { }

	public static long GetInt64(IntPtr jarg1) { }

	public static sbyte GetInt8(IntPtr jarg1) { }

	public static IntPtr GetMemberMetadataResult_key_value_get(IntPtr jarg1) { }

	public static void GetMemberMetadataResult_key_value_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GetMemberMetadataResult_member_id_get(IntPtr jarg1) { }

	public static void GetMemberMetadataResult_member_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong GetMemberMetadataResult_room_id_get(IntPtr jarg1) { }

	public static void GetMemberMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr GetMemberMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint GetRoomListResult_begin_index_get(IntPtr jarg1) { }

	public static void GetRoomListResult_begin_index_set(IntPtr jarg1, uint jarg2) { }

	public static uint GetRoomListResult_end_index_get(IntPtr jarg1) { }

	public static void GetRoomListResult_end_index_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr GetRoomListResult_room_infos_get(IntPtr jarg1) { }

	public static void GetRoomListResult_room_infos_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GetRoomListResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint GetRoomListResult_total_room_num_get(IntPtr jarg1) { }

	public static void GetRoomListResult_total_room_num_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr GetRoomMembersResult_member_infos_get(IntPtr jarg1) { }

	public static void GetRoomMembersResult_member_infos_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint GetRoomMembersResult_member_num_get(IntPtr jarg1) { }

	public static void GetRoomMembersResult_member_num_set(IntPtr jarg1, uint jarg2) { }

	public static ulong GetRoomMembersResult_room_id_get(IntPtr jarg1) { }

	public static void GetRoomMembersResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr GetRoomMembersResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr GetRoomMetadataResult_key_value_get(IntPtr jarg1) { }

	public static void GetRoomMetadataResult_key_value_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong GetRoomMetadataResult_room_id_get(IntPtr jarg1) { }

	public static void GetRoomMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr GetRoomMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr GetRoomTagResult_room_tag_get(IntPtr jarg1) { }

	public static void GetRoomTagResult_room_tag_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr GetRoomTagResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr GetUserRoomListResult_room_info_get(IntPtr jarg1) { }

	public static void GetUserRoomListResult_room_info_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr GetUserRoomListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int GlobalAchievementReceived_count_get(IntPtr jarg1) { }

	public static void GlobalAchievementReceived_count_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr GlobalAchievementReceived_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr GlobalStatsRequestReceived_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr IRailAchievementHelper_CreatePlayerAchievement(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailAchievementHelper_GetGlobalAchievement(IntPtr jarg1) { }

	public static int IRailApps_AsyncQuerySubscribeWishPlayState(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static bool IRailApps_IsGameInstalled(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailAssets_AsyncCompleteConsumeAsset(IntPtr jarg1, ulong jarg2, uint jarg3, string jarg4) { }

	public static int IRailAssets_AsyncDirectConsumeAssets(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailAssets_AsyncExchangeAssets(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4) { }

	public static int IRailAssets_AsyncExchangeAssetsTo(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, ulong jarg4, string jarg5) { }

	public static int IRailAssets_AsyncMergeAsset(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailAssets_AsyncMergeAssetTo(IntPtr jarg1, IntPtr jarg2, ulong jarg3, string jarg4) { }

	public static int IRailAssets_AsyncRequestAllAssets(IntPtr jarg1, string jarg2) { }

	public static int IRailAssets_AsyncSplitAsset(IntPtr jarg1, ulong jarg2, uint jarg3, string jarg4) { }

	public static int IRailAssets_AsyncSplitAssetTo(IntPtr jarg1, ulong jarg2, uint jarg3, ulong jarg4, string jarg5) { }

	public static int IRailAssets_AsyncStartConsumeAsset(IntPtr jarg1, ulong jarg2, string jarg3) { }

	public static int IRailAssets_AsyncUpdateAssetsProperty(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailAssets_AsyncUpdateConsumeProgress(IntPtr jarg1, ulong jarg2, string jarg3, string jarg4) { }

	public static int IRailAssets_DeserializeAssetsFromBuffer(IntPtr jarg1, IntPtr jarg2, string jarg3, IntPtr jarg4) { }

	public static int IRailAssets_QueryAssetInfo(IntPtr jarg1, ulong jarg2, IntPtr jarg3) { }

	public static int IRailAssets_SerializeAssetsToBuffer__SWIG_0(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailAssets_SerializeAssetsToBuffer__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) { }

	public static IntPtr IRailAssets_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr IRailAssetsHelper_OpenAssets(IntPtr jarg1) { }

	public static IntPtr IRailAssetsHelper_OpenGameServerAssets(IntPtr jarg1) { }

	public static bool IRailBrowser_AddJavascriptEventListener(IntPtr jarg1, string jarg2) { }

	public static void IRailBrowser_AllowNavigateNewPage(IntPtr jarg1, bool jarg2) { }

	public static void IRailBrowser_Close(IntPtr jarg1) { }

	public static bool IRailBrowser_GetCurrentUrl(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailBrowser_ReloadWithUrl__SWIG_0(IntPtr jarg1, string jarg2) { }

	public static bool IRailBrowser_ReloadWithUrl__SWIG_1(IntPtr jarg1) { }

	public static bool IRailBrowser_RemoveAllJavascriptEventListener(IntPtr jarg1) { }

	public static void IRailBrowser_StopLoad(IntPtr jarg1) { }

	public static IntPtr IRailBrowser_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr IRailBrowserHelper_AsyncCreateBrowser__SWIG_0(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5, IntPtr jarg6, out RailResult jarg7) { }

	public static IntPtr IRailBrowserHelper_AsyncCreateBrowser__SWIG_1(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5, IntPtr jarg6) { }

	public static IntPtr IRailBrowserHelper_AsyncCreateBrowser__SWIG_2(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5) { }

	public static IntPtr IRailBrowserHelper_CreateCustomerDrawBrowser__SWIG_0(IntPtr jarg1, string jarg2, string jarg3, IntPtr jarg4, out RailResult jarg5) { }

	public static IntPtr IRailBrowserHelper_CreateCustomerDrawBrowser__SWIG_1(IntPtr jarg1, string jarg2, string jarg3, IntPtr jarg4) { }

	public static IntPtr IRailBrowserHelper_CreateCustomerDrawBrowser__SWIG_2(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailBrowserHelper_NavigateWebPage(IntPtr jarg1, string jarg2, bool jarg3) { }

	public static bool IRailBrowserRender_AddJavascriptEventListener(IntPtr jarg1, string jarg2) { }

	public static void IRailBrowserRender_AllowNavigateNewPage(IntPtr jarg1, bool jarg2) { }

	public static void IRailBrowserRender_Close(IntPtr jarg1) { }

	public static void IRailBrowserRender_DispatchMouseMessage(IntPtr jarg1, int jarg2, uint jarg3, uint jarg4, uint jarg5) { }

	public static void IRailBrowserRender_DispatchWindowsMessage(IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4) { }

	public static bool IRailBrowserRender_ExecuteJavascript(IntPtr jarg1, string jarg2, string jarg3) { }

	public static bool IRailBrowserRender_GetCurrentUrl(IntPtr jarg1, IntPtr jarg2) { }

	public static void IRailBrowserRender_GoBack(IntPtr jarg1) { }

	public static void IRailBrowserRender_GoForward(IntPtr jarg1) { }

	public static void IRailBrowserRender_KeyChar(IntPtr jarg1, uint jarg2, bool jarg3) { }

	public static void IRailBrowserRender_KeyDown(IntPtr jarg1, uint jarg2) { }

	public static void IRailBrowserRender_KeyUp(IntPtr jarg1, uint jarg2) { }

	public static void IRailBrowserRender_MouseWheel(IntPtr jarg1, int jarg2, uint jarg3, uint jarg4, uint jarg5) { }

	public static bool IRailBrowserRender_ReloadWithUrl__SWIG_0(IntPtr jarg1, string jarg2) { }

	public static bool IRailBrowserRender_ReloadWithUrl__SWIG_1(IntPtr jarg1) { }

	public static bool IRailBrowserRender_RemoveAllJavascriptEventListener(IntPtr jarg1) { }

	public static void IRailBrowserRender_SetBrowserActive(IntPtr jarg1, bool jarg2) { }

	public static void IRailBrowserRender_SetFocus(IntPtr jarg1, bool jarg2) { }

	public static void IRailBrowserRender_StopLoad(IntPtr jarg1) { }

	public static IntPtr IRailBrowserRender_SWIGUpcast(IntPtr jarg1) { }

	public static void IRailBrowserRender_UpdateCustomDrawWindowPos(IntPtr jarg1, int jarg2, int jarg3, uint jarg4, uint jarg5) { }

	public static ulong IRailComponent_GetComponentVersion(IntPtr jarg1) { }

	public static void IRailComponent_Release(IntPtr jarg1) { }

	public static int IRailDlcHelper_AsyncCheckAllDlcsStateReady(IntPtr jarg1, string jarg2) { }

	public static bool IRailDlcHelper_AsyncInstallDlc(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailDlcHelper_AsyncQueryIsOwnedDlcsOnServer(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static bool IRailDlcHelper_AsyncRemoveDlc(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static uint IRailDlcHelper_GetDlcCount(IntPtr jarg1) { }

	public static bool IRailDlcHelper_GetDlcInfo(IntPtr jarg1, uint jarg2, IntPtr jarg3) { }

	public static bool IRailDlcHelper_IsDlcInstalled__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) { }

	public static bool IRailDlcHelper_IsDlcInstalled__SWIG_1(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailDlcHelper_IsOwnedDlc(IntPtr jarg1, IntPtr jarg2) { }

	public static void IRailEvent_OnRailEvent(IntPtr jarg1, int jarg2, IntPtr jarg3) { }

	public static IntPtr IRailFactory_RailAchievementHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailApps(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailAssetsHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailBrowserHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailDlcHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailFloatingWindow(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailFriends(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailGame(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailGameServerHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailGroupChatHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailHttpSessionHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailIMETextInputHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailInGameCoin(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailInGamePurchase(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailInGameStorePurchaseHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailLeaderboardHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailNetworkHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailPlayer(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailRoomHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailScreenshotHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailSmallObjectServiceHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailStatisticHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailStorageHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailSystemHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailTextInputHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailUsersHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailUserSpaceHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailUtils(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailVoiceHelper(IntPtr jarg1) { }

	public static IntPtr IRailFactory_RailZoneServerHelper(IntPtr jarg1) { }

	public static int IRailFile_AsyncRead(IntPtr jarg1, uint jarg2, string jarg3) { }

	public static int IRailFile_AsyncWrite(IntPtr jarg1, out Byte[] jarg2, uint jarg3, string jarg4) { }

	public static void IRailFile_Close(IntPtr jarg1) { }

	public static IntPtr IRailFile_GetFilename(IntPtr jarg1) { }

	public static uint IRailFile_GetSize(IntPtr jarg1) { }

	public static uint IRailFile_Read__SWIG_0(IntPtr jarg1, out Byte[] jarg2, uint jarg3, out RailResult jarg4) { }

	public static uint IRailFile_Read__SWIG_1(IntPtr jarg1, out Byte[] jarg2, uint jarg3) { }

	public static IntPtr IRailFile_SWIGUpcast(IntPtr jarg1) { }

	public static uint IRailFile_Write__SWIG_0(IntPtr jarg1, out Byte[] jarg2, uint jarg3, out RailResult jarg4) { }

	public static uint IRailFile_Write__SWIG_1(IntPtr jarg1, out Byte[] jarg2, uint jarg3) { }

	public static int IRailFloatingWindow_AsyncCloseRailFloatingWindow(IntPtr jarg1, int jarg2, string jarg3) { }

	public static int IRailFloatingWindow_AsyncShowDefaultGameStoreWindow(IntPtr jarg1, string jarg2) { }

	public static int IRailFloatingWindow_AsyncShowRailFloatingWindow(IntPtr jarg1, int jarg2, string jarg3) { }

	public static int IRailFloatingWindow_AsyncShowStoreWindow(IntPtr jarg1, ulong jarg2, IntPtr jarg3, string jarg4) { }

	public static bool IRailFloatingWindow_IsFloatingWindowAvailable(IntPtr jarg1) { }

	public static int IRailFloatingWindow_SetNotifyWindowEnable(IntPtr jarg1, int jarg2, bool jarg3) { }

	public static int IRailFloatingWindow_SetNotifyWindowPosition(IntPtr jarg1, int jarg2, IntPtr jarg3) { }

	public static int IRailFriends_AsyncAddFriend(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailFriends_AsyncClearAllMyMetadata(IntPtr jarg1, string jarg2) { }

	public static int IRailFriends_AsyncGetFriendMetadata(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4) { }

	public static int IRailFriends_AsyncGetInviteCommandLine(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailFriends_AsyncGetPersonalInfo(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailFriends_AsyncQueryFriendPlayedGamesInfo(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailFriends_AsyncQueryPlayedWithFriendsGames(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailFriends_AsyncQueryPlayedWithFriendsList(IntPtr jarg1, string jarg2) { }

	public static int IRailFriends_AsyncQueryPlayedWithFriendsTime(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailFriends_AsyncReportPlayedWithUserList(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailFriends_AsyncSetInviteCommandLine(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailFriends_AsyncSetMyMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailFriends_AsyncUpdateFriendsData(IntPtr jarg1, string jarg2) { }

	public static int IRailFriends_GetFriendsList(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGame_AsyncQuerySubscribeWishPlayState(IntPtr jarg1, string jarg2) { }

	public static int IRailGame_EndGameTimeCounting(IntPtr jarg1, string jarg2) { }

	public static int IRailGame_GetBranchBuildNumber(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGame_GetCurrentBranchInfo(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGame_GetGameDefineGamePlayingState(IntPtr jarg1, out uint jarg2) { }

	public static uint IRailGame_GetGameEarliestPurchaseTime(IntPtr jarg1) { }

	public static IntPtr IRailGame_GetGameID(IntPtr jarg1) { }

	public static int IRailGame_GetGameInstallPath(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailGame_GetGamePurchasePlayerRailID(IntPtr jarg1) { }

	public static int IRailGame_GetGameState(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGame_GetGameSupportedLanguageCodes(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGame_GetPlayerSelectedLanguageCode(IntPtr jarg1, IntPtr jarg2) { }

	public static uint IRailGame_GetTimeCountSinceGameActivated(IntPtr jarg1) { }

	public static uint IRailGame_GetTimeCountSinceLastMouseMoved(IntPtr jarg1) { }

	public static int IRailGame_RegisterGameDefineGamePlayingState(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGame_ReportGameContentDamaged(IntPtr jarg1, int jarg2) { }

	public static int IRailGame_SetGameDefineGamePlayingState(IntPtr jarg1, uint jarg2) { }

	public static int IRailGame_SetGameState(IntPtr jarg1, int jarg2) { }

	public static int IRailGame_StartGameTimeCounting(IntPtr jarg1, string jarg2) { }

	public static void IRailGameServer_AbandonGameServerSessionTicket(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGameServer_AsyncAcquireGameServerSessionTicket(IntPtr jarg1, string jarg2) { }

	public static int IRailGameServer_AsyncGetAllMetadata(IntPtr jarg1, string jarg2) { }

	public static int IRailGameServer_AsyncGetMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailGameServer_AsyncSetMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailGameServer_AsyncStartSessionWithPlayer(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4) { }

	public static bool IRailGameServer_ClearAllMetadata(IntPtr jarg1) { }

	public static int IRailGameServer_CloseGameServer(IntPtr jarg1) { }

	public static int IRailGameServer_EnableTeamVoice(IntPtr jarg1, bool jarg2) { }

	public static uint IRailGameServer_GetBotPlayers(IntPtr jarg1) { }

	public static uint IRailGameServer_GetCurrentPlayers(IntPtr jarg1) { }

	public static int IRailGameServer_GetFriendsInGameServer(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailGameServer_GetGameServerDescription(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGameServer_GetGameServerFullName(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGameServer_GetGameServerName(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailGameServer_GetGameServerRailID(IntPtr jarg1) { }

	public static bool IRailGameServer_GetGameServerTags(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailGameServer_GetGameServerVersion(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailGameServer_GetHost(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailGameServer_GetIsFriendOnly(IntPtr jarg1) { }

	public static bool IRailGameServer_GetMapName(IntPtr jarg1, IntPtr jarg2) { }

	public static uint IRailGameServer_GetMaxPlayers(IntPtr jarg1) { }

	public static int IRailGameServer_GetMetadata(IntPtr jarg1, string jarg2, IntPtr jarg3) { }

	public static bool IRailGameServer_GetMods(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailGameServer_GetOwnerRailID(IntPtr jarg1) { }

	public static bool IRailGameServer_GetPasswordProtect(IntPtr jarg1) { }

	public static bool IRailGameServer_GetServerInfo(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailGameServer_GetSpectatorHost(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailGameServer_IsUserInGameServer(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGameServer_RegisterToGameServerList(IntPtr jarg1) { }

	public static void IRailGameServer_RemoveAllPlayers(IntPtr jarg1) { }

	public static int IRailGameServer_ReportPlayerJoinGameServer(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGameServer_ReportPlayerQuitGameServer(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailGameServer_SetBotPlayers(IntPtr jarg1, uint jarg2) { }

	public static bool IRailGameServer_SetGameServerDescription(IntPtr jarg1, string jarg2) { }

	public static bool IRailGameServer_SetGameServerTags(IntPtr jarg1, string jarg2) { }

	public static bool IRailGameServer_SetGameServerVersion(IntPtr jarg1, string jarg2) { }

	public static bool IRailGameServer_SetHost(IntPtr jarg1, string jarg2) { }

	public static bool IRailGameServer_SetIsFriendOnly(IntPtr jarg1, bool jarg2) { }

	public static bool IRailGameServer_SetMapName(IntPtr jarg1, string jarg2) { }

	public static bool IRailGameServer_SetMaxPlayers(IntPtr jarg1, uint jarg2) { }

	public static int IRailGameServer_SetMetadata(IntPtr jarg1, string jarg2, string jarg3) { }

	public static bool IRailGameServer_SetMods(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailGameServer_SetPasswordProtect(IntPtr jarg1, bool jarg2) { }

	public static bool IRailGameServer_SetServerInfo(IntPtr jarg1, string jarg2) { }

	public static bool IRailGameServer_SetSpectatorHost(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailGameServer_SWIGUpcast(IntPtr jarg1) { }

	public static void IRailGameServer_TerminateSessionOfPlayer(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGameServer_UnregisterFromGameServerList(IntPtr jarg1) { }

	public static int IRailGameServer_UpdateGameServerPlayerList(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGameServerHelper_AsyncAddFavoriteGameServer__SWIG_0(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailGameServerHelper_AsyncAddFavoriteGameServer__SWIG_1(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailGameServerHelper_AsyncCreateGameServer__SWIG_0(IntPtr jarg1, IntPtr jarg2, string jarg3, string jarg4) { }

	public static IntPtr IRailGameServerHelper_AsyncCreateGameServer__SWIG_1(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static IntPtr IRailGameServerHelper_AsyncCreateGameServer__SWIG_2(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailGameServerHelper_AsyncCreateGameServer__SWIG_3(IntPtr jarg1) { }

	public static int IRailGameServerHelper_AsyncGetFavoriteGameServers__SWIG_0(IntPtr jarg1, string jarg2) { }

	public static int IRailGameServerHelper_AsyncGetFavoriteGameServers__SWIG_1(IntPtr jarg1) { }

	public static int IRailGameServerHelper_AsyncGetGameServerList(IntPtr jarg1, uint jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, string jarg6) { }

	public static int IRailGameServerHelper_AsyncGetGameServerPlayerList(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailGameServerHelper_AsyncRemoveFavoriteGameServer__SWIG_0(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailGameServerHelper_AsyncRemoveFavoriteGameServer__SWIG_1(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGlobalAchievement_AsyncRequestAchievement(IntPtr jarg1, string jarg2) { }

	public static int IRailGlobalAchievement_GetGlobalAchievedPercent(IntPtr jarg1, string jarg2, out double jarg3) { }

	public static int IRailGlobalAchievement_GetGlobalAchievedPercentDescending(IntPtr jarg1, int jarg2, IntPtr jarg3, out double jarg4) { }

	public static IntPtr IRailGlobalAchievement_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailGlobalStats_AsyncRequestGlobalStats(IntPtr jarg1, string jarg2) { }

	public static int IRailGlobalStats_GetGlobalStatValue__SWIG_0(IntPtr jarg1, string jarg2, out long jarg3) { }

	public static int IRailGlobalStats_GetGlobalStatValue__SWIG_1(IntPtr jarg1, string jarg2, out double jarg3) { }

	public static int IRailGlobalStats_GetGlobalStatValueHistory__SWIG_0(IntPtr jarg1, string jarg2, out Int64[] jarg3, uint jarg4, out int jarg5) { }

	public static int IRailGlobalStats_GetGlobalStatValueHistory__SWIG_1(IntPtr jarg1, string jarg2, out Double[] jarg3, uint jarg4, out int jarg5) { }

	public static IntPtr IRailGlobalStats_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailGroupChat_GetGroupInfo(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailGroupChat_OpenGroupWindow(IntPtr jarg1) { }

	public static IntPtr IRailGroupChat_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr IRailGroupChatHelper_AsyncOpenGroupChat(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailGroupChatHelper_AsyncQueryGroupsInfo(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailHttpResponse_GetContentEncoding(IntPtr jarg1) { }

	public static IntPtr IRailHttpResponse_GetContentLanguage(IntPtr jarg1) { }

	public static uint IRailHttpResponse_GetContentLength(IntPtr jarg1) { }

	public static IntPtr IRailHttpResponse_GetContentRange(IntPtr jarg1) { }

	public static IntPtr IRailHttpResponse_GetContentType(IntPtr jarg1) { }

	public static int IRailHttpResponse_GetHttpResponseCode(IntPtr jarg1) { }

	public static IntPtr IRailHttpResponse_GetLastModified(IntPtr jarg1) { }

	public static IntPtr IRailHttpResponse_GetResponseBodyData(IntPtr jarg1) { }

	public static int IRailHttpResponse_GetResponseHeaderKeys(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailHttpResponse_GetResponseHeaderValue(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailHttpResponse_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailHttpSession_AsyncSendRequest(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailHttpSession_SetParameters(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailHttpSession_SetPostBodyContent(IntPtr jarg1, string jarg2) { }

	public static int IRailHttpSession_SetRequestHeaders(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailHttpSession_SetRequestMethod(IntPtr jarg1, int jarg2) { }

	public static int IRailHttpSession_SetRequestTimeOut(IntPtr jarg1, uint jarg2) { }

	public static IntPtr IRailHttpSession_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr IRailHttpSessionHelper_CreateHttpResponse(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailHttpSessionHelper_CreateHttpSession(IntPtr jarg1) { }

	public static int IRailIMEHelper_EnableIMEHelperTextInputWindow(IntPtr jarg1, bool jarg2, IntPtr jarg3) { }

	public static int IRailIMEHelper_UpdateIMEHelperTextInputWindowPosition(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailInGameCoin_AsyncPurchaseCoins(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailInGameCoin_AsyncRequestCoinInfo(IntPtr jarg1, string jarg2) { }

	public static int IRailInGamePurchase_AsyncFinishOrder(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailInGamePurchase_AsyncPurchaseProducts(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailInGamePurchase_AsyncPurchaseProductsToAssets(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailInGamePurchase_AsyncRequestAllProducts(IntPtr jarg1, string jarg2) { }

	public static int IRailInGamePurchase_AsyncRequestAllPurchasableProducts(IntPtr jarg1, string jarg2) { }

	public static int IRailInGamePurchase_GetProductInfo(IntPtr jarg1, uint jarg2, IntPtr jarg3) { }

	public static int IRailInGameStorePurchaseHelper_AsyncShowPaymentWindow(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailLeaderboard_AsyncAttachSpaceWork(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailLeaderboard_AsyncGetLeaderboard(IntPtr jarg1, string jarg2) { }

	public static int IRailLeaderboard_AsyncUploadLeaderboard(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static IntPtr IRailLeaderboard_CreateLeaderboardEntries(IntPtr jarg1) { }

	public static int IRailLeaderboard_GetLeaderboardDisplayType(IntPtr jarg1, out int jarg2) { }

	public static IntPtr IRailLeaderboard_GetLeaderboardName(IntPtr jarg1) { }

	public static int IRailLeaderboard_GetLeaderboardParameters(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailLeaderboard_GetLeaderboardSortType(IntPtr jarg1, out int jarg2) { }

	public static int IRailLeaderboard_GetTotalEntriesCount(IntPtr jarg1) { }

	public static IntPtr IRailLeaderboard_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailLeaderboardEntries_AsyncRequestLeaderboardEntries(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4) { }

	public static int IRailLeaderboardEntries_GetEntriesCount(IntPtr jarg1) { }

	public static IntPtr IRailLeaderboardEntries_GetEntriesParam(IntPtr jarg1) { }

	public static int IRailLeaderboardEntries_GetLeaderboardEntry(IntPtr jarg1, int jarg2, IntPtr jarg3) { }

	public static IntPtr IRailLeaderboardEntries_GetLeaderboardName(IntPtr jarg1) { }

	public static IntPtr IRailLeaderboardEntries_GetRailID(IntPtr jarg1) { }

	public static IntPtr IRailLeaderboardEntries_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr IRailLeaderboardHelper_AsyncCreateLeaderboard(IntPtr jarg1, string jarg2, int jarg3, int jarg4, string jarg5, out RailResult jarg6) { }

	public static IntPtr IRailLeaderboardHelper_OpenLeaderboard(IntPtr jarg1, string jarg2) { }

	public static int IRailNetwork_AcceptRawSessionRequest(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) { }

	public static int IRailNetwork_AcceptSessionRequest(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) { }

	public static int IRailNetwork_BlockMessageType(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static int IRailNetwork_CloseSession(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) { }

	public static int IRailNetwork_ForbidSessionRelay(IntPtr jarg1, bool jarg2) { }

	public static int IRailNetwork_GetSessionState(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) { }

	public static bool IRailNetwork_IsDataReady__SWIG_0(IntPtr jarg1, IntPtr jarg2, out uint jarg3, out uint jarg4) { }

	public static bool IRailNetwork_IsDataReady__SWIG_1(IntPtr jarg1, IntPtr jarg2, out uint jarg3) { }

	public static int IRailNetwork_ReadData__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5, uint jarg6) { }

	public static int IRailNetwork_ReadData__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5) { }

	public static int IRailNetwork_ReadRawData__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5, uint jarg6) { }

	public static int IRailNetwork_ReadRawData__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5) { }

	public static int IRailNetwork_ResolveHostname(IntPtr jarg1, string jarg2, IntPtr jarg3) { }

	public static int IRailNetwork_SendData__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5, uint jarg6) { }

	public static int IRailNetwork_SendData__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5) { }

	public static int IRailNetwork_SendRawData(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5, bool jarg6, uint jarg7) { }

	public static int IRailNetwork_SendReliableData__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5, uint jarg6) { }

	public static int IRailNetwork_SendReliableData__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, out Byte[] jarg4, uint jarg5) { }

	public static int IRailNetwork_UnblockMessageType(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static void IRailPlayer_AbandonSessionTicket(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailPlayer_AlreadyLoggedIn(IntPtr jarg1) { }

	public static int IRailPlayer_AsyncAcquireSessionTicket(IntPtr jarg1, string jarg2) { }

	public static int IRailPlayer_AsyncGetAuthenticateURL(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailPlayer_AsyncGetEncryptedGameTicket(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailPlayer_AsyncGetGamePurchaseKey(IntPtr jarg1, string jarg2) { }

	public static int IRailPlayer_AsyncGetPlayerMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailPlayer_AsyncQueryPlayerBannedStatus(IntPtr jarg1, string jarg2) { }

	public static int IRailPlayer_AsyncStartSessionWithPlayer(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4) { }

	public static int IRailPlayer_GetPlayerDataPath(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailPlayer_GetPlayerName(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailPlayer_GetPlayerOwnershipType(IntPtr jarg1) { }

	public static IntPtr IRailPlayer_GetRailID(IntPtr jarg1) { }

	public static float IRailPlayer_GetRateOfGameRevenue(IntPtr jarg1) { }

	public static bool IRailPlayer_IsGameRevenueLimited(IntPtr jarg1) { }

	public static void IRailPlayer_TerminateSessionOfPlayer(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailPlayerAchievement_AsyncRequestAchievement(IntPtr jarg1, string jarg2) { }

	public static int IRailPlayerAchievement_AsyncStoreAchievement(IntPtr jarg1, string jarg2) { }

	public static int IRailPlayerAchievement_AsyncTriggerAchievementProgress__SWIG_0(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5) { }

	public static int IRailPlayerAchievement_AsyncTriggerAchievementProgress__SWIG_1(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4) { }

	public static int IRailPlayerAchievement_AsyncTriggerAchievementProgress__SWIG_2(IntPtr jarg1, string jarg2, uint jarg3) { }

	public static int IRailPlayerAchievement_CancelAchievement(IntPtr jarg1, string jarg2) { }

	public static int IRailPlayerAchievement_GetAchievementInfo(IntPtr jarg1, string jarg2, IntPtr jarg3) { }

	public static int IRailPlayerAchievement_GetAllAchievementsName(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailPlayerAchievement_GetRailID(IntPtr jarg1) { }

	public static int IRailPlayerAchievement_HasAchieved(IntPtr jarg1, string jarg2, out bool jarg3) { }

	public static int IRailPlayerAchievement_MakeAchievement(IntPtr jarg1, string jarg2) { }

	public static int IRailPlayerAchievement_ResetAllAchievements(IntPtr jarg1) { }

	public static IntPtr IRailPlayerAchievement_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailPlayerStats_AsyncRequestStats(IntPtr jarg1, string jarg2) { }

	public static int IRailPlayerStats_AsyncStoreStats(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailPlayerStats_GetRailID(IntPtr jarg1) { }

	public static int IRailPlayerStats_GetStatValue__SWIG_0(IntPtr jarg1, string jarg2, out int jarg3) { }

	public static int IRailPlayerStats_GetStatValue__SWIG_1(IntPtr jarg1, string jarg2, out double jarg3) { }

	public static int IRailPlayerStats_ResetAllStats(IntPtr jarg1) { }

	public static int IRailPlayerStats_SetStatValue__SWIG_0(IntPtr jarg1, string jarg2, int jarg3) { }

	public static int IRailPlayerStats_SetStatValue__SWIG_1(IntPtr jarg1, string jarg2, double jarg3) { }

	public static IntPtr IRailPlayerStats_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailPlayerStats_UpdateAverageStatValue(IntPtr jarg1, string jarg2, double jarg3) { }

	public static int IRailRoom_AsyncClearRoomMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailRoom_AsyncGetAllRoomData(IntPtr jarg1, string jarg2) { }

	public static int IRailRoom_AsyncGetMemberMetadata(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4) { }

	public static int IRailRoom_AsyncGetRoomMembers(IntPtr jarg1, string jarg2) { }

	public static int IRailRoom_AsyncGetRoomMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailRoom_AsyncGetRoomTag(IntPtr jarg1, string jarg2) { }

	public static int IRailRoom_AsyncJoinRoom(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailRoom_AsyncKickOffMember(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailRoom_AsyncSetMemberMetadata(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4) { }

	public static int IRailRoom_AsyncSetNewRoomOwner(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailRoom_AsyncSetRoomMaxMember(IntPtr jarg1, uint jarg2, string jarg3) { }

	public static int IRailRoom_AsyncSetRoomMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailRoom_AsyncSetRoomTag(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailRoom_AsyncSetRoomType(IntPtr jarg1, int jarg2, string jarg3) { }

	public static int IRailRoom_EnableTeamVoice(IntPtr jarg1, bool jarg2) { }

	public static int IRailRoom_GetFriendsInRoom(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailRoom_GetGameServerID(IntPtr jarg1) { }

	public static uint IRailRoom_GetMaxMembers(IntPtr jarg1) { }

	public static IntPtr IRailRoom_GetMemberByIndex(IntPtr jarg1, uint jarg2) { }

	public static int IRailRoom_GetMemberNameByIndex(IntPtr jarg1, uint jarg2, IntPtr jarg3) { }

	public static uint IRailRoom_GetMembers(IntPtr jarg1) { }

	public static IntPtr IRailRoom_GetOwnerID(IntPtr jarg1) { }

	public static ulong IRailRoom_GetRoomID(IntPtr jarg1) { }

	public static int IRailRoom_GetRoomName(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailRoom_GetRoomType(IntPtr jarg1) { }

	public static bool IRailRoom_HasPassword(IntPtr jarg1) { }

	public static bool IRailRoom_IsRoomJoinable(IntPtr jarg1) { }

	public static bool IRailRoom_IsUserInRoom(IntPtr jarg1, IntPtr jarg2) { }

	public static void IRailRoom_Leave(IntPtr jarg1) { }

	public static int IRailRoom_SendDataToMember__SWIG_0(IntPtr jarg1, IntPtr jarg2, out Byte[] jarg3, uint jarg4, uint jarg5) { }

	public static int IRailRoom_SendDataToMember__SWIG_1(IntPtr jarg1, IntPtr jarg2, out Byte[] jarg3, uint jarg4) { }

	public static int IRailRoom_SetGameServerID(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailRoom_SetRoomJoinable(IntPtr jarg1, bool jarg2) { }

	public static IntPtr IRailRoom_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr IRailRoomHelper_AsyncCreateRoom(IntPtr jarg1, IntPtr jarg2, string jarg3, string jarg4) { }

	public static int IRailRoomHelper_AsyncGetRoomList(IntPtr jarg1, uint jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, string jarg6) { }

	public static int IRailRoomHelper_AsyncGetRoomListByTags(IntPtr jarg1, uint jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, string jarg6) { }

	public static int IRailRoomHelper_AsyncGetUserRoomList(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailRoomHelper_AsyncOpenRoom(IntPtr jarg1, ulong jarg2, string jarg3) { }

	public static IntPtr IRailRoomHelper_CreateRoom(IntPtr jarg1, IntPtr jarg2, string jarg3, out RailResult jarg4) { }

	public static IntPtr IRailRoomHelper_OpenRoom(IntPtr jarg1, ulong jarg2, out RailResult jarg3) { }

	public static bool IRailScreenshot_AssociatePublishedFiles(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailScreenshot_AsyncPublishScreenshot(IntPtr jarg1, string jarg2, string jarg3) { }

	public static bool IRailScreenshot_SetLocation(IntPtr jarg1, string jarg2) { }

	public static bool IRailScreenshot_SetUsers(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailScreenshot_SWIGUpcast(IntPtr jarg1) { }

	public static void IRailScreenshotHelper_AsyncTakeScreenshot(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailScreenshotHelper_CreateScreenshotWithLocalImage(IntPtr jarg1, string jarg2, string jarg3) { }

	public static IntPtr IRailScreenshotHelper_CreateScreenshotWithRawData(IntPtr jarg1, out Byte[] jarg2, uint jarg3, uint jarg4, uint jarg5) { }

	public static void IRailScreenshotHelper_HookScreenshotHotKey(IntPtr jarg1, bool jarg2) { }

	public static bool IRailScreenshotHelper_IsScreenshotHotKeyHooked(IntPtr jarg1) { }

	public static int IRailSmallObjectServiceHelper_AsyncDownloadObjects(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailSmallObjectServiceHelper_AsyncQueryObjectState(IntPtr jarg1, string jarg2) { }

	public static int IRailSmallObjectServiceHelper_GetObjectContent(IntPtr jarg1, uint jarg2, IntPtr jarg3) { }

	public static int IRailSpaceWork_AddAssociatedGameIDs(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_AsyncUpdateMetadata(IntPtr jarg1, string jarg2) { }

	public static int IRailSpaceWork_CancelSync(IntPtr jarg1) { }

	public static void IRailSpaceWork_Close(IntPtr jarg1) { }

	public static bool IRailSpaceWork_Editable(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetAdditionalPreviewUrls(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetAllMetadata(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetAssociatedGameIDs(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetAssociatedSpaceWorks(IntPtr jarg1, IntPtr jarg2) { }

	public static uint IRailSpaceWork_GetCreateTime(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetDescription(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong IRailSpaceWork_GetDownloadCount(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetLanguages(IntPtr jarg1, IntPtr jarg2) { }

	public static uint IRailSpaceWork_GetLastUpdateTime(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetLocalVersion(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetMetadata(IntPtr jarg1, string jarg2, IntPtr jarg3) { }

	public static int IRailSpaceWork_GetMyVote(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetName(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetPreviewImage(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetPreviewUrl__SWIG_0(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static int IRailSpaceWork_GetPreviewUrl__SWIG_1(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong IRailSpaceWork_GetScore(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetShareLevel(IntPtr jarg1) { }

	public static IntPtr IRailSpaceWork_GetSpaceWorkID(IntPtr jarg1) { }

	public static uint IRailSpaceWork_GetState(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetStatistic(IntPtr jarg1, int jarg2, out ulong jarg3) { }

	public static ulong IRailSpaceWork_GetSubscribedCount(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetSyncProgress(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetTags(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetUploaderIDs(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetUrl(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetVersion(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_GetVoteDetail(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong IRailSpaceWork_GetWorkFileSize(IntPtr jarg1) { }

	public static int IRailSpaceWork_GetWorkLocalFolder(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailSpaceWork_IsFavorite(IntPtr jarg1) { }

	public static bool IRailSpaceWork_IsSubscribed(IntPtr jarg1) { }

	public static int IRailSpaceWork_RemoveAssociatedGameIDs(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_RemoveMetadata(IntPtr jarg1, string jarg2) { }

	public static int IRailSpaceWork_RemovePreviewImage(IntPtr jarg1) { }

	public static int IRailSpaceWork_SetAdditionalPreviews(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_SetAssociatedSpaceWorks(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_SetContentFromFolder(IntPtr jarg1, string jarg2) { }

	public static int IRailSpaceWork_SetDescription(IntPtr jarg1, string jarg2) { }

	public static int IRailSpaceWork_SetLanguages(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_SetMetadata(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailSpaceWork_SetName(IntPtr jarg1, string jarg2) { }

	public static int IRailSpaceWork_SetPreviewImage(IntPtr jarg1, string jarg2) { }

	public static int IRailSpaceWork_SetShareLevel__SWIG_0(IntPtr jarg1, int jarg2) { }

	public static int IRailSpaceWork_SetShareLevel__SWIG_1(IntPtr jarg1) { }

	public static int IRailSpaceWork_SetTags(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_SetUpdateOptions(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailSpaceWork_SetVersion(IntPtr jarg1, string jarg2) { }

	public static int IRailSpaceWork_StartSync(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailSpaceWork_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailStatisticHelper_AsyncGetNumberOfPlayer(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailStatisticHelper_CreatePlayerStats(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailStatisticHelper_GetGlobalStats(IntPtr jarg1) { }

	public static int IRailStorageHelper_AsyncDeleteStreamFile(IntPtr jarg1, string jarg2, string jarg3) { }

	public static int IRailStorageHelper_AsyncListStreamFiles(IntPtr jarg1, string jarg2, IntPtr jarg3, string jarg4) { }

	public static int IRailStorageHelper_AsyncPublishFileToUserSpace(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailStorageHelper_AsyncQueryQuota(IntPtr jarg1) { }

	public static int IRailStorageHelper_AsyncRenameStreamFile(IntPtr jarg1, string jarg2, string jarg3, string jarg4) { }

	public static IntPtr IRailStorageHelper_CreateFile__SWIG_0(IntPtr jarg1, string jarg2, out RailResult jarg3) { }

	public static IntPtr IRailStorageHelper_CreateFile__SWIG_1(IntPtr jarg1, string jarg2) { }

	public static uint IRailStorageHelper_GetFileCount(IntPtr jarg1) { }

	public static int IRailStorageHelper_GetFileNameAndSize(IntPtr jarg1, uint jarg2, IntPtr jarg3, out ulong jarg4) { }

	public static int IRailStorageHelper_GetFileTimestamp(IntPtr jarg1, string jarg2, out ulong jarg3) { }

	public static uint IRailStorageHelper_GetRailFileEnabledOS(IntPtr jarg1, string jarg2) { }

	public static bool IRailStorageHelper_IsCloudStorageEnabledForApp(IntPtr jarg1) { }

	public static bool IRailStorageHelper_IsCloudStorageEnabledForPlayer(IntPtr jarg1) { }

	public static bool IRailStorageHelper_IsFileExist(IntPtr jarg1, string jarg2) { }

	public static bool IRailStorageHelper_IsFileSyncedToCloud(IntPtr jarg1, string jarg2) { }

	public static bool IRailStorageHelper_ListFiles(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailStorageHelper_OpenFile__SWIG_0(IntPtr jarg1, string jarg2, out RailResult jarg3) { }

	public static IntPtr IRailStorageHelper_OpenFile__SWIG_1(IntPtr jarg1, string jarg2) { }

	public static IntPtr IRailStorageHelper_OpenStreamFile__SWIG_0(IntPtr jarg1, string jarg2, IntPtr jarg3, out RailResult jarg4) { }

	public static IntPtr IRailStorageHelper_OpenStreamFile__SWIG_1(IntPtr jarg1, string jarg2, IntPtr jarg3) { }

	public static int IRailStorageHelper_RemoveFile(IntPtr jarg1, string jarg2) { }

	public static int IRailStorageHelper_SetRailFileEnabledOS(IntPtr jarg1, string jarg2, int jarg3) { }

	public static int IRailStorageHelper_SetSyncFileOption(IntPtr jarg1, string jarg2, IntPtr jarg3) { }

	public static int IRailStreamFile_AsyncRead(IntPtr jarg1, int jarg2, uint jarg3, string jarg4) { }

	public static int IRailStreamFile_AsyncWrite(IntPtr jarg1, out Byte[] jarg2, uint jarg3, string jarg4) { }

	public static void IRailStreamFile_Cancel(IntPtr jarg1) { }

	public static int IRailStreamFile_Close(IntPtr jarg1) { }

	public static IntPtr IRailStreamFile_GetFilename(IntPtr jarg1) { }

	public static ulong IRailStreamFile_GetSize(IntPtr jarg1) { }

	public static IntPtr IRailStreamFile_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailSystemHelper_GetPlatformSystemState(IntPtr jarg1) { }

	public static int IRailSystemHelper_SetTerminationTimeoutOwnershipExpired(IntPtr jarg1, int jarg2) { }

	public static void IRailTextInputHelper_GetTextInputContent(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailTextInputHelper_HideTextInputWindow(IntPtr jarg1) { }

	public static int IRailTextInputHelper_ShowTextInputWindow(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailUsersHelper_AsyncCancelAllInvites(IntPtr jarg1, string jarg2) { }

	public static int IRailUsersHelper_AsyncCancelInvite(IntPtr jarg1, int jarg2, string jarg3) { }

	public static int IRailUsersHelper_AsyncGetInviteDetail(IntPtr jarg1, IntPtr jarg2, int jarg3, string jarg4) { }

	public static int IRailUsersHelper_AsyncGetUserLimits(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailUsersHelper_AsyncGetUsersInfo(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailUsersHelper_AsyncInviteUsers(IntPtr jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, string jarg5) { }

	public static int IRailUsersHelper_AsyncShowChatWindowWithFriend(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailUsersHelper_AsyncShowUserHomepageWindow(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailUserSpaceHelper_AsyncGetMyFavoritesWorks__SWIG_0(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5, string jarg6) { }

	public static int IRailUserSpaceHelper_AsyncGetMyFavoritesWorks__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5) { }

	public static int IRailUserSpaceHelper_AsyncGetMyFavoritesWorks__SWIG_2(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4) { }

	public static int IRailUserSpaceHelper_AsyncGetMySubscribedWorks__SWIG_0(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5, string jarg6) { }

	public static int IRailUserSpaceHelper_AsyncGetMySubscribedWorks__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5) { }

	public static int IRailUserSpaceHelper_AsyncGetMySubscribedWorks__SWIG_2(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4) { }

	public static int IRailUserSpaceHelper_AsyncModifyFavoritesWorks(IntPtr jarg1, IntPtr jarg2, int jarg3, string jarg4) { }

	public static int IRailUserSpaceHelper_AsyncQuerySpaceWorks__SWIG_0(IntPtr jarg1, IntPtr jarg2, uint jarg3, uint jarg4, int jarg5, IntPtr jarg6, string jarg7) { }

	public static int IRailUserSpaceHelper_AsyncQuerySpaceWorks__SWIG_1(IntPtr jarg1, IntPtr jarg2, uint jarg3, uint jarg4, int jarg5, IntPtr jarg6) { }

	public static int IRailUserSpaceHelper_AsyncQuerySpaceWorks__SWIG_2(IntPtr jarg1, IntPtr jarg2, uint jarg3, uint jarg4, int jarg5) { }

	public static int IRailUserSpaceHelper_AsyncQuerySpaceWorks__SWIG_3(IntPtr jarg1, IntPtr jarg2, uint jarg3, uint jarg4) { }

	public static int IRailUserSpaceHelper_AsyncRateSpaceWork(IntPtr jarg1, IntPtr jarg2, int jarg3, string jarg4) { }

	public static int IRailUserSpaceHelper_AsyncRemoveSpaceWork(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailUserSpaceHelper_AsyncSearchSpaceWork(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5, uint jarg6, int jarg7, string jarg8) { }

	public static int IRailUserSpaceHelper_AsyncSubscribeSpaceWorks(IntPtr jarg1, IntPtr jarg2, bool jarg3, string jarg4) { }

	public static int IRailUserSpaceHelper_AsyncVoteSpaceWork(IntPtr jarg1, IntPtr jarg2, int jarg3, string jarg4) { }

	public static IntPtr IRailUserSpaceHelper_CreateSpaceWork(IntPtr jarg1, int jarg2) { }

	public static int IRailUserSpaceHelper_GetMySubscribedWorks(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5) { }

	public static uint IRailUserSpaceHelper_GetMySubscribedWorksCount(IntPtr jarg1, int jarg2, out RailResult jarg3) { }

	public static IntPtr IRailUserSpaceHelper_OpenSpaceWork(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailUtils_AsyncGetImageData(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5) { }

	public static int IRailUtils_DirtyWordsFilter(IntPtr jarg1, string jarg2, bool jarg3, IntPtr jarg4) { }

	public static int IRailUtils_GetCountryCodeOfCurrentLoggedInIP(IntPtr jarg1, IntPtr jarg2) { }

	public static void IRailUtils_GetErrorString(IntPtr jarg1, int jarg2, IntPtr jarg3) { }

	public static int IRailUtils_GetLaunchAppParameters(IntPtr jarg1, int jarg2, IntPtr jarg3) { }

	public static int IRailUtils_GetPlatformLanguageCode(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailUtils_GetRailPlatformType(IntPtr jarg1) { }

	public static uint IRailUtils_GetTimeCountSinceComputerLaunch(IntPtr jarg1) { }

	public static uint IRailUtils_GetTimeCountSinceGameLaunch(IntPtr jarg1) { }

	public static uint IRailUtils_GetTimeFromServer(IntPtr jarg1) { }

	public static int IRailUtils_SetWarningMessageCallback(IntPtr jarg1, RailWarningMessageCallbackFunction jarg2) { }

	public static int IRailVoiceChannel_AsyncAddUsers(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailVoiceChannel_AsyncJoinVoiceChannel(IntPtr jarg1, string jarg2) { }

	public static int IRailVoiceChannel_AsyncLeaveVoiceChannel(IntPtr jarg1, string jarg2) { }

	public static int IRailVoiceChannel_AsyncRemoveUsers(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailVoiceChannel_AsyncSetUsersSpeakingState(IntPtr jarg1, IntPtr jarg2, string jarg3) { }

	public static int IRailVoiceChannel_CloseChannel(IntPtr jarg1) { }

	public static int IRailVoiceChannel_GetJoinState(IntPtr jarg1) { }

	public static int IRailVoiceChannel_GetSpeakingUsers(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) { }

	public static int IRailVoiceChannel_GetUsers(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailVoiceChannel_GetUsersSpeakingState(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailVoiceChannel_GetVoiceChannelID(IntPtr jarg1) { }

	public static IntPtr IRailVoiceChannel_GetVoiceChannelName(IntPtr jarg1) { }

	public static bool IRailVoiceChannel_IsOwner(IntPtr jarg1) { }

	public static bool IRailVoiceChannel_IsSelfSpeaking(IntPtr jarg1) { }

	public static int IRailVoiceChannel_SetSelfSpeaking(IntPtr jarg1, bool jarg2) { }

	public static IntPtr IRailVoiceChannel_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr IRailVoiceHelper_AsyncCreateVoiceChannel(IntPtr jarg1, IntPtr jarg2, string jarg3, string jarg4, out RailResult jarg5) { }

	public static int IRailVoiceHelper_DecodeVoice(IntPtr jarg1, out Byte[] jarg2, uint jarg3, out Byte[] jarg4, uint jarg5, out uint jarg6) { }

	public static int IRailVoiceHelper_EnableInGameVoiceSpeaking(IntPtr jarg1, bool jarg2) { }

	public static int IRailVoiceHelper_GetCapturedVoiceData(IntPtr jarg1, out Byte[] jarg2, uint jarg3, out uint jarg4) { }

	public static uint IRailVoiceHelper_GetPushToTalkKeyInVoiceChannel(IntPtr jarg1) { }

	public static int IRailVoiceHelper_GetSpeakerState(IntPtr jarg1) { }

	public static int IRailVoiceHelper_GetVoiceCaptureSpecification(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailVoiceHelper_MuteSpeaker(IntPtr jarg1) { }

	public static IntPtr IRailVoiceHelper_OpenVoiceChannel(IntPtr jarg1, IntPtr jarg2, string jarg3, out RailResult jarg4) { }

	public static int IRailVoiceHelper_ResumeSpeaker(IntPtr jarg1) { }

	public static int IRailVoiceHelper_SetMicroVolume(IntPtr jarg1, uint jarg2) { }

	public static int IRailVoiceHelper_SetPlayerNicknameInVoiceChannel(IntPtr jarg1, string jarg2) { }

	public static int IRailVoiceHelper_SetPushToTalkKeyInVoiceChannel(IntPtr jarg1, uint jarg2) { }

	public static int IRailVoiceHelper_SetSpeakerVolume(IntPtr jarg1, uint jarg2) { }

	public static int IRailVoiceHelper_SetupVoiceCapture__SWIG_0(IntPtr jarg1, IntPtr jarg2, RailCaptureVoiceCallback jarg3) { }

	public static int IRailVoiceHelper_SetupVoiceCapture__SWIG_1(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailVoiceHelper_ShowOverlayUI(IntPtr jarg1, bool jarg2) { }

	public static int IRailVoiceHelper_StartVoiceCapturing__SWIG_0(IntPtr jarg1, uint jarg2, bool jarg3) { }

	public static int IRailVoiceHelper_StartVoiceCapturing__SWIG_1(IntPtr jarg1, uint jarg2) { }

	public static int IRailVoiceHelper_StartVoiceCapturing__SWIG_2(IntPtr jarg1) { }

	public static int IRailVoiceHelper_StopVoiceCapturing(IntPtr jarg1) { }

	public static int IRailZoneServer_GetChildrenZoneIDs(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailZoneServer_GetGameServerAddresses(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailZoneServer_GetZoneDescription(IntPtr jarg1, string jarg2, IntPtr jarg3) { }

	public static int IRailZoneServer_GetZoneDescriptionLanguages(IntPtr jarg1, IntPtr jarg2) { }

	public static uint IRailZoneServer_GetZoneEnableEndTime(IntPtr jarg1) { }

	public static uint IRailZoneServer_GetZoneEnableStartTime(IntPtr jarg1) { }

	public static IntPtr IRailZoneServer_GetZoneID(IntPtr jarg1) { }

	public static int IRailZoneServer_GetZoneMetadatas(IntPtr jarg1, IntPtr jarg2) { }

	public static int IRailZoneServer_GetZoneName(IntPtr jarg1, string jarg2, IntPtr jarg3) { }

	public static int IRailZoneServer_GetZoneNameLanguages(IntPtr jarg1, IntPtr jarg2) { }

	public static bool IRailZoneServer_IsZoneJoinable(IntPtr jarg1) { }

	public static bool IRailZoneServer_IsZoneVisiable(IntPtr jarg1) { }

	public static IntPtr IRailZoneServer_SWIGUpcast(IntPtr jarg1) { }

	public static int IRailZoneServerHelper_AsyncSwitchPlayerSelectedZone(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr IRailZoneServerHelper_GetPlayerSelectedZoneID(IntPtr jarg1) { }

	public static IntPtr IRailZoneServerHelper_GetRootZoneID(IntPtr jarg1) { }

	public static IntPtr IRailZoneServerHelper_OpenZoneServer(IntPtr jarg1, IntPtr jarg2, out RailResult jarg3) { }

	public static IntPtr JavascriptEventResult_event_name_get(IntPtr jarg1) { }

	public static void JavascriptEventResult_event_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr JavascriptEventResult_event_value_get(IntPtr jarg1) { }

	public static void JavascriptEventResult_event_value_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr JavascriptEventResult_SWIGUpcast(IntPtr jarg1) { }

	public static ulong JoinRoomResult_room_id_get(IntPtr jarg1) { }

	public static void JoinRoomResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr JoinRoomResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr JoinVoiceChannelResult_already_joined_channel_id_get(IntPtr jarg1) { }

	public static void JoinVoiceChannelResult_already_joined_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr JoinVoiceChannelResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr JoinVoiceChannelResult_voice_channel_id_get(IntPtr jarg1) { }

	public static void JoinVoiceChannelResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr KickOffMemberResult_kicked_id_get(IntPtr jarg1) { }

	public static void KickOffMemberResult_kicked_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong KickOffMemberResult_room_id_get(IntPtr jarg1) { }

	public static void KickOffMemberResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr KickOffMemberResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint kRailMaxGameDefinePlayingStateValue_get() { }

	public static uint kRailMaxQueryPlayedWithFriendsTimeLimit_get() { }

	public static uint kRailRoomDataKeyValuePairsLimit_get() { }

	public static uint kRailRoomDefaultMaxMemberNumber_get() { }

	public static IntPtr LeaderboardAttachSpaceWork_leaderboard_name_get(IntPtr jarg1) { }

	public static void LeaderboardAttachSpaceWork_leaderboard_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr LeaderboardAttachSpaceWork_spacework_id_get(IntPtr jarg1) { }

	public static void LeaderboardAttachSpaceWork_spacework_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr LeaderboardAttachSpaceWork_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr LeaderboardCreated_leaderboard_name_get(IntPtr jarg1) { }

	public static void LeaderboardCreated_leaderboard_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr LeaderboardCreated_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr LeaderboardData_additional_infomation_get(IntPtr jarg1) { }

	public static void LeaderboardData_additional_infomation_set(IntPtr jarg1, string jarg2) { }

	public static int LeaderboardData_rank_get(IntPtr jarg1) { }

	public static void LeaderboardData_rank_set(IntPtr jarg1, int jarg2) { }

	public static double LeaderboardData_score_get(IntPtr jarg1) { }

	public static void LeaderboardData_score_set(IntPtr jarg1, double jarg2) { }

	public static IntPtr LeaderboardData_spacework_id_get(IntPtr jarg1) { }

	public static void LeaderboardData_spacework_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr LeaderboardEntry_data_get(IntPtr jarg1) { }

	public static void LeaderboardEntry_data_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr LeaderboardEntry_player_id_get(IntPtr jarg1) { }

	public static void LeaderboardEntry_player_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr LeaderboardEntryReceived_leaderboard_name_get(IntPtr jarg1) { }

	public static void LeaderboardEntryReceived_leaderboard_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr LeaderboardEntryReceived_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr LeaderboardParameters_param_get(IntPtr jarg1) { }

	public static void LeaderboardParameters_param_set(IntPtr jarg1, string jarg2) { }

	public static bool LeaderboardReceived_does_exist_get(IntPtr jarg1) { }

	public static void LeaderboardReceived_does_exist_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr LeaderboardReceived_leaderboard_name_get(IntPtr jarg1) { }

	public static void LeaderboardReceived_leaderboard_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr LeaderboardReceived_SWIGUpcast(IntPtr jarg1) { }

	public static bool LeaderboardUploaded_better_score_get(IntPtr jarg1) { }

	public static void LeaderboardUploaded_better_score_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr LeaderboardUploaded_leaderboard_name_get(IntPtr jarg1) { }

	public static void LeaderboardUploaded_leaderboard_name_set(IntPtr jarg1, string jarg2) { }

	public static int LeaderboardUploaded_new_rank_get(IntPtr jarg1) { }

	public static void LeaderboardUploaded_new_rank_set(IntPtr jarg1, int jarg2) { }

	public static int LeaderboardUploaded_old_rank_get(IntPtr jarg1) { }

	public static void LeaderboardUploaded_old_rank_set(IntPtr jarg1, int jarg2) { }

	public static double LeaderboardUploaded_score_get(IntPtr jarg1) { }

	public static void LeaderboardUploaded_score_set(IntPtr jarg1, double jarg2) { }

	public static IntPtr LeaderboardUploaded_SWIGUpcast(IntPtr jarg1) { }

	public static int LeaveRoomResult_reason_get(IntPtr jarg1) { }

	public static void LeaveRoomResult_reason_set(IntPtr jarg1, int jarg2) { }

	public static ulong LeaveRoomResult_room_id_get(IntPtr jarg1) { }

	public static void LeaveRoomResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr LeaveRoomResult_SWIGUpcast(IntPtr jarg1) { }

	public static int LeaveVoiceChannelResult_reason_get(IntPtr jarg1) { }

	public static void LeaveVoiceChannelResult_reason_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr LeaveVoiceChannelResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr LeaveVoiceChannelResult_voice_channel_id_get(IntPtr jarg1) { }

	public static void LeaveVoiceChannelResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong MergeAssetsFinished_new_asset_id_get(IntPtr jarg1) { }

	public static void MergeAssetsFinished_new_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr MergeAssetsFinished_source_assets_get(IntPtr jarg1) { }

	public static void MergeAssetsFinished_source_assets_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr MergeAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static ulong MergeAssetsToFinished_merge_to_asset_id_get(IntPtr jarg1) { }

	public static void MergeAssetsToFinished_merge_to_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr MergeAssetsToFinished_source_assets_get(IntPtr jarg1) { }

	public static void MergeAssetsToFinished_source_assets_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr MergeAssetsToFinished_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr NetworkCreateRawSessionFailed_local_peer_get(IntPtr jarg1) { }

	public static void NetworkCreateRawSessionFailed_local_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr NetworkCreateRawSessionFailed_remote_game_peer_get(IntPtr jarg1) { }

	public static void NetworkCreateRawSessionFailed_remote_game_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr NetworkCreateRawSessionFailed_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr NetworkCreateRawSessionRequest_local_peer_get(IntPtr jarg1) { }

	public static void NetworkCreateRawSessionRequest_local_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr NetworkCreateRawSessionRequest_remote_game_peer_get(IntPtr jarg1) { }

	public static void NetworkCreateRawSessionRequest_remote_game_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr NetworkCreateRawSessionRequest_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr new_AcquireSessionTicketResponse__SWIG_0() { }

	public static IntPtr new_AcquireSessionTicketResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncAcquireGameServerSessionTicketResponse__SWIG_0() { }

	public static IntPtr new_AsyncAcquireGameServerSessionTicketResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncAddFavoriteGameServerResult__SWIG_0() { }

	public static IntPtr new_AsyncAddFavoriteGameServerResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncDeleteStreamFileResult__SWIG_0() { }

	public static IntPtr new_AsyncDeleteStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncGetFavoriteGameServersResult__SWIG_0() { }

	public static IntPtr new_AsyncGetFavoriteGameServersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncGetMyFavoritesWorksResult__SWIG_0() { }

	public static IntPtr new_AsyncGetMyFavoritesWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncGetMySubscribedWorksResult__SWIG_0() { }

	public static IntPtr new_AsyncGetMySubscribedWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncListFileResult__SWIG_0() { }

	public static IntPtr new_AsyncListFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncModifyFavoritesWorksResult__SWIG_0() { }

	public static IntPtr new_AsyncModifyFavoritesWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncQueryQuotaResult__SWIG_0() { }

	public static IntPtr new_AsyncQueryQuotaResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncQuerySpaceWorksResult__SWIG_0() { }

	public static IntPtr new_AsyncQuerySpaceWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncRateSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_AsyncRateSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncReadFileResult__SWIG_0() { }

	public static IntPtr new_AsyncReadFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncReadStreamFileResult__SWIG_0() { }

	public static IntPtr new_AsyncReadStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncRemoveFavoriteGameServerResult__SWIG_0() { }

	public static IntPtr new_AsyncRemoveFavoriteGameServerResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncRemoveSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_AsyncRemoveSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncRenameStreamFileResult__SWIG_0() { }

	public static IntPtr new_AsyncRenameStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncSearchSpaceWorksResult__SWIG_0() { }

	public static IntPtr new_AsyncSearchSpaceWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncSubscribeSpaceWorksResult__SWIG_0() { }

	public static IntPtr new_AsyncSubscribeSpaceWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncUpdateMetadataResult__SWIG_0() { }

	public static IntPtr new_AsyncUpdateMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncVoteSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_AsyncVoteSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncWriteFileResult__SWIG_0() { }

	public static IntPtr new_AsyncWriteFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_AsyncWriteStreamFileResult__SWIG_0() { }

	public static IntPtr new_AsyncWriteStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_BrowserDamageRectNeedsPaintRequest__SWIG_0() { }

	public static IntPtr new_BrowserDamageRectNeedsPaintRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_BrowserNeedsPaintRequest__SWIG_0() { }

	public static IntPtr new_BrowserNeedsPaintRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_BrowserRenderNavigateResult__SWIG_0() { }

	public static IntPtr new_BrowserRenderNavigateResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_BrowserRenderStateChanged__SWIG_0() { }

	public static IntPtr new_BrowserRenderStateChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_BrowserRenderTitleChanged__SWIG_0() { }

	public static IntPtr new_BrowserRenderTitleChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_BrowserTryNavigateNewPageRequest__SWIG_0() { }

	public static IntPtr new_BrowserTryNavigateNewPageRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CheckAllDlcsStateReadyResult__SWIG_0() { }

	public static IntPtr new_CheckAllDlcsStateReadyResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_ClearRoomMetadataResult__SWIG_0() { }

	public static IntPtr new_ClearRoomMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CloseBrowserResult__SWIG_0() { }

	public static IntPtr new_CloseBrowserResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CompleteConsumeAssetsFinished__SWIG_0() { }

	public static IntPtr new_CompleteConsumeAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CompleteConsumeByExchangeAssetsToFinished__SWIG_0() { }

	public static IntPtr new_CompleteConsumeByExchangeAssetsToFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateBrowserOptions__SWIG_0() { }

	public static IntPtr new_CreateBrowserOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateBrowserResult__SWIG_0() { }

	public static IntPtr new_CreateBrowserResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateCustomerDrawBrowserOptions__SWIG_0() { }

	public static IntPtr new_CreateCustomerDrawBrowserOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateGameServerOptions__SWIG_0() { }

	public static IntPtr new_CreateGameServerOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateGameServerResult__SWIG_0() { }

	public static IntPtr new_CreateGameServerResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateRoomResult__SWIG_0() { }

	public static IntPtr new_CreateRoomResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateSessionFailed__SWIG_0() { }

	public static IntPtr new_CreateSessionFailed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateSessionRequest__SWIG_0() { }

	public static IntPtr new_CreateSessionRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateVoiceChannelOption__SWIG_0() { }

	public static IntPtr new_CreateVoiceChannelOption__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_CreateVoiceChannelResult__SWIG_0() { }

	public static IntPtr new_CreateVoiceChannelResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_DirectConsumeAssetsFinished__SWIG_0() { }

	public static IntPtr new_DirectConsumeAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_DlcInstallFinished__SWIG_0() { }

	public static IntPtr new_DlcInstallFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_DlcInstallProgress__SWIG_0() { }

	public static IntPtr new_DlcInstallProgress__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_DlcInstallStart__SWIG_0() { }

	public static IntPtr new_DlcInstallStart__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_DlcInstallStartResult__SWIG_0() { }

	public static IntPtr new_DlcInstallStartResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_DlcOwnershipChanged__SWIG_0() { }

	public static IntPtr new_DlcOwnershipChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_DlcRefundChanged__SWIG_0() { }

	public static IntPtr new_DlcRefundChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_DlcUninstallFinished__SWIG_0() { }

	public static IntPtr new_DlcUninstallFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_ExchangeAssetsFinished__SWIG_0() { }

	public static IntPtr new_ExchangeAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_ExchangeAssetsToFinished__SWIG_0() { }

	public static IntPtr new_ExchangeAssetsToFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GameServerInfo__SWIG_0() { }

	public static IntPtr new_GameServerInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GameServerListFilter__SWIG_0() { }

	public static IntPtr new_GameServerListFilter__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GameServerListFilterKey__SWIG_0() { }

	public static IntPtr new_GameServerListFilterKey__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GameServerListSorter__SWIG_0() { }

	public static IntPtr new_GameServerListSorter__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GameServerPlayerInfo__SWIG_0() { }

	public static IntPtr new_GameServerPlayerInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GameServerRegisterToServerListResult__SWIG_0() { }

	public static IntPtr new_GameServerRegisterToServerListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GameServerStartSessionWithPlayerResponse__SWIG_0() { }

	public static IntPtr new_GameServerStartSessionWithPlayerResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetAllRoomDataResult__SWIG_0() { }

	public static IntPtr new_GetAllRoomDataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetAuthenticateURLResult__SWIG_0() { }

	public static IntPtr new_GetAuthenticateURLResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetGameServerListResult__SWIG_0() { }

	public static IntPtr new_GetGameServerListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetGameServerMetadataResult__SWIG_0() { }

	public static IntPtr new_GetGameServerMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetGameServerPlayerListResult__SWIG_0() { }

	public static IntPtr new_GetGameServerPlayerListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetMemberMetadataResult__SWIG_0() { }

	public static IntPtr new_GetMemberMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetRoomListResult__SWIG_0() { }

	public static IntPtr new_GetRoomListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetRoomMembersResult__SWIG_0() { }

	public static IntPtr new_GetRoomMembersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetRoomMetadataResult__SWIG_0() { }

	public static IntPtr new_GetRoomMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetRoomTagResult__SWIG_0() { }

	public static IntPtr new_GetRoomTagResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GetUserRoomListResult__SWIG_0() { }

	public static IntPtr new_GetUserRoomListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GlobalAchievementReceived__SWIG_0() { }

	public static IntPtr new_GlobalAchievementReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_GlobalStatsRequestReceived__SWIG_0() { }

	public static IntPtr new_GlobalStatsRequestReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_JavascriptEventResult__SWIG_0() { }

	public static IntPtr new_JavascriptEventResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_JoinRoomResult__SWIG_0() { }

	public static IntPtr new_JoinRoomResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_JoinVoiceChannelResult__SWIG_0() { }

	public static IntPtr new_JoinVoiceChannelResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_KickOffMemberResult__SWIG_0() { }

	public static IntPtr new_KickOffMemberResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaderboardAttachSpaceWork__SWIG_0() { }

	public static IntPtr new_LeaderboardAttachSpaceWork__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaderboardCreated__SWIG_0() { }

	public static IntPtr new_LeaderboardCreated__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaderboardData__SWIG_0() { }

	public static IntPtr new_LeaderboardData__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaderboardEntry__SWIG_0() { }

	public static IntPtr new_LeaderboardEntry__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaderboardEntryReceived__SWIG_0() { }

	public static IntPtr new_LeaderboardEntryReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaderboardParameters__SWIG_0() { }

	public static IntPtr new_LeaderboardParameters__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaderboardReceived__SWIG_0() { }

	public static IntPtr new_LeaderboardReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaderboardUploaded__SWIG_0() { }

	public static IntPtr new_LeaderboardUploaded__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaveRoomResult__SWIG_0() { }

	public static IntPtr new_LeaveRoomResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_LeaveVoiceChannelResult__SWIG_0() { }

	public static IntPtr new_LeaveVoiceChannelResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_MergeAssetsFinished__SWIG_0() { }

	public static IntPtr new_MergeAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_MergeAssetsToFinished__SWIG_0() { }

	public static IntPtr new_MergeAssetsToFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NetworkCreateRawSessionFailed__SWIG_0() { }

	public static IntPtr new_NetworkCreateRawSessionFailed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NetworkCreateRawSessionRequest__SWIG_0() { }

	public static IntPtr new_NetworkCreateRawSessionRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NotifyMetadataChange__SWIG_0() { }

	public static IntPtr new_NotifyMetadataChange__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NotifyRoomDestroy__SWIG_0() { }

	public static IntPtr new_NotifyRoomDestroy__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NotifyRoomGameServerChange__SWIG_0() { }

	public static IntPtr new_NotifyRoomGameServerChange__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NotifyRoomMemberChange__SWIG_0() { }

	public static IntPtr new_NotifyRoomMemberChange__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NotifyRoomMemberKicked__SWIG_0() { }

	public static IntPtr new_NotifyRoomMemberKicked__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NotifyRoomOwnerChange__SWIG_0() { }

	public static IntPtr new_NotifyRoomOwnerChange__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_NumberOfPlayerReceived__SWIG_0() { }

	public static IntPtr new_NumberOfPlayerReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_OpenRoomResult__SWIG_0() { }

	public static IntPtr new_OpenRoomResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_PlayerAchievementReceived__SWIG_0() { }

	public static IntPtr new_PlayerAchievementReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_PlayerAchievementStored__SWIG_0() { }

	public static IntPtr new_PlayerAchievementStored__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_PlayerGetGamePurchaseKeyResult__SWIG_0() { }

	public static IntPtr new_PlayerGetGamePurchaseKeyResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_PlayerPersonalInfo__SWIG_0() { }

	public static IntPtr new_PlayerPersonalInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_PlayerStatsReceived__SWIG_0() { }

	public static IntPtr new_PlayerStatsReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_PlayerStatsStored__SWIG_0() { }

	public static IntPtr new_PlayerStatsStored__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_PublishScreenshotResult__SWIG_0() { }

	public static IntPtr new_PublishScreenshotResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_QueryIsOwnedDlcsResult__SWIG_0() { }

	public static IntPtr new_QueryIsOwnedDlcsResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_QueryMySubscribedSpaceWorksResult__SWIG_0() { }

	public static IntPtr new_QueryMySubscribedSpaceWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_QueryPlayerBannedStatus__SWIG_0() { }

	public static IntPtr new_QueryPlayerBannedStatus__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_QuerySubscribeWishPlayStateResult__SWIG_0() { }

	public static IntPtr new_QuerySubscribeWishPlayStateResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailAntiAddictionGameOnlineTimeChanged__SWIG_0() { }

	public static IntPtr new_RailAntiAddictionGameOnlineTimeChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_0() { }

	public static IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_4(IntPtr jarg1) { }

	public static IntPtr new_RailArrayEnumRailUsersLimits__SWIG_0() { }

	public static IntPtr new_RailArrayEnumRailUsersLimits__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayEnumRailUsersLimits__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayEnumRailUsersLimits__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayEnumRailUsersLimits__SWIG_4(IntPtr jarg1) { }

	public static IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_0() { }

	public static IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_4(IntPtr jarg1) { }

	public static IntPtr new_RailArrayGameServerInfo__SWIG_0() { }

	public static IntPtr new_RailArrayGameServerInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayGameServerInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayGameServerInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayGameServerListFilter__SWIG_0() { }

	public static IntPtr new_RailArrayGameServerListFilter__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayGameServerListFilter__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayGameServerListFilter__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayGameServerListFilterKey__SWIG_0() { }

	public static IntPtr new_RailArrayGameServerListFilterKey__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayGameServerListFilterKey__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayGameServerListFilterKey__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayGameServerListSorter__SWIG_0() { }

	public static IntPtr new_RailArrayGameServerListSorter__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayGameServerListSorter__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayGameServerListSorter__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayGameServerPlayerInfo__SWIG_0() { }

	public static IntPtr new_RailArrayGameServerPlayerInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayGameServerPlayerInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayGameServerPlayerInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayPlayerPersonalInfo__SWIG_0() { }

	public static IntPtr new_RailArrayPlayerPersonalInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayPlayerPersonalInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayPlayerPersonalInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailAssetInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRailAssetInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailAssetInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailAssetInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailAssetItem__SWIG_0() { }

	public static IntPtr new_RailArrayRailAssetItem__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailAssetItem__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailAssetItem__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailAssetProperty__SWIG_0() { }

	public static IntPtr new_RailArrayRailAssetProperty__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailAssetProperty__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailAssetProperty__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailCoinInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRailCoinInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailCoinInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailCoinInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailDlcID__SWIG_0() { }

	public static IntPtr new_RailArrayRailDlcID__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailDlcID__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailDlcID__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailDlcOwned__SWIG_0() { }

	public static IntPtr new_RailArrayRailDlcOwned__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailDlcOwned__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailDlcOwned__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailFriendInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRailFriendInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailFriendInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailFriendInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailFriendMetadata__SWIG_0() { }

	public static IntPtr new_RailArrayRailFriendMetadata__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailFriendMetadata__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailFriendMetadata__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailFriendPlayedGameInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRailFriendPlayedGameInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailFriendPlayedGameInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailFriendPlayedGameInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailGameDefineGamePlayingState__SWIG_0() { }

	public static IntPtr new_RailArrayRailGameDefineGamePlayingState__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailGameDefineGamePlayingState__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailGameDefineGamePlayingState__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailGameID__SWIG_0() { }

	public static IntPtr new_RailArrayRailGameID__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailGameID__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailGameID__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailGeneratedAssetItem__SWIG_0() { }

	public static IntPtr new_RailArrayRailGeneratedAssetItem__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailGeneratedAssetItem__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailGeneratedAssetItem__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailID__SWIG_0() { }

	public static IntPtr new_RailArrayRailID__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailID__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailID__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailKeyValue__SWIG_0() { }

	public static IntPtr new_RailArrayRailKeyValue__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailKeyValue__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailKeyValue__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailKeyValueResult__SWIG_0() { }

	public static IntPtr new_RailArrayRailKeyValueResult__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailKeyValueResult__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailKeyValueResult__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailPlayedWithFriendsGameItem__SWIG_0() { }

	public static IntPtr new_RailArrayRailPlayedWithFriendsGameItem__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailPlayedWithFriendsGameItem__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailPlayedWithFriendsGameItem__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailPlayedWithFriendsTimeItem__SWIG_0() { }

	public static IntPtr new_RailArrayRailPlayedWithFriendsTimeItem__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailPlayedWithFriendsTimeItem__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailPlayedWithFriendsTimeItem__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailProductItem__SWIG_0() { }

	public static IntPtr new_RailArrayRailProductItem__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailProductItem__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailProductItem__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailPurchaseProductInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRailPurchaseProductInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailPurchaseProductInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailPurchaseProductInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailSmallObjectDownloadInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRailSmallObjectDownloadInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailSmallObjectDownloadInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailSmallObjectDownloadInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailSmallObjectState__SWIG_0() { }

	public static IntPtr new_RailArrayRailSmallObjectState__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailSmallObjectState__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailSmallObjectState__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailSpaceWorkDescriptor__SWIG_0() { }

	public static IntPtr new_RailArrayRailSpaceWorkDescriptor__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailSpaceWorkDescriptor__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailSpaceWorkDescriptor__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailSpaceWorkVoteDetail__SWIG_0() { }

	public static IntPtr new_RailArrayRailSpaceWorkVoteDetail__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailSpaceWorkVoteDetail__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailSpaceWorkVoteDetail__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailStreamFileInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRailStreamFileInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailStreamFileInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailStreamFileInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailString__SWIG_0() { }

	public static IntPtr new_RailArrayRailString__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailString__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailString__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailString__SWIG_4(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailUserPlayedWith__SWIG_0() { }

	public static IntPtr new_RailArrayRailUserPlayedWith__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailUserPlayedWith__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailUserPlayedWith__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailUserSpaceDownloadProgress__SWIG_0() { }

	public static IntPtr new_RailArrayRailUserSpaceDownloadProgress__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailUserSpaceDownloadProgress__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailUserSpaceDownloadProgress__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailUserSpaceDownloadResult__SWIG_0() { }

	public static IntPtr new_RailArrayRailUserSpaceDownloadResult__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailUserSpaceDownloadResult__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailUserSpaceDownloadResult__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailVoiceChannelUserSpeakingState__SWIG_0() { }

	public static IntPtr new_RailArrayRailVoiceChannelUserSpeakingState__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailVoiceChannelUserSpeakingState__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailVoiceChannelUserSpeakingState__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRailZoneID__SWIG_0() { }

	public static IntPtr new_RailArrayRailZoneID__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRailZoneID__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRailZoneID__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRoomInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRoomInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRoomInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRoomInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRoomInfoListFilter__SWIG_0() { }

	public static IntPtr new_RailArrayRoomInfoListFilter__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRoomInfoListFilter__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRoomInfoListFilter__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRoomInfoListFilterKey__SWIG_0() { }

	public static IntPtr new_RailArrayRoomInfoListFilterKey__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRoomInfoListFilterKey__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRoomInfoListFilterKey__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRoomInfoListSorter__SWIG_0() { }

	public static IntPtr new_RailArrayRoomInfoListSorter__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRoomInfoListSorter__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRoomInfoListSorter__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayRoomMemberInfo__SWIG_0() { }

	public static IntPtr new_RailArrayRoomMemberInfo__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayRoomMemberInfo__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayRoomMemberInfo__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArraySpaceWorkID__SWIG_0() { }

	public static IntPtr new_RailArraySpaceWorkID__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArraySpaceWorkID__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArraySpaceWorkID__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayuint32_t__SWIG_0() { }

	public static IntPtr new_RailArrayuint32_t__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayuint32_t__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayuint32_t__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayuint64_t__SWIG_0() { }

	public static IntPtr new_RailArrayuint64_t__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayuint64_t__SWIG_2(out ulong jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayuint64_t__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailArrayuint8_t__SWIG_0() { }

	public static IntPtr new_RailArrayuint8_t__SWIG_1(uint jarg1) { }

	public static IntPtr new_RailArrayuint8_t__SWIG_2(IntPtr jarg1, uint jarg2) { }

	public static IntPtr new_RailArrayuint8_t__SWIG_3(IntPtr jarg1) { }

	public static IntPtr new_RailAssetInfo__SWIG_0() { }

	public static IntPtr new_RailAssetInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailAssetItem__SWIG_0() { }

	public static IntPtr new_RailAssetItem__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailAssetProperty__SWIG_0() { }

	public static IntPtr new_RailAssetProperty__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailAssetsChanged__SWIG_0() { }

	public static IntPtr new_RailAssetsChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailBranchInfo__SWIG_0() { }

	public static IntPtr new_RailBranchInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailCoinInfo__SWIG_0() { }

	public static IntPtr new_RailCoinInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailCoins__SWIG_0() { }

	public static IntPtr new_RailCoins__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailCrashInfo__SWIG_0() { }

	public static IntPtr new_RailCrashInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailCurrencyExchangeCoinRate__SWIG_0() { }

	public static IntPtr new_RailCurrencyExchangeCoinRate__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailDirtyWordsCheckResult__SWIG_0() { }

	public static IntPtr new_RailDirtyWordsCheckResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailDiscountInfo__SWIG_0() { }

	public static IntPtr new_RailDiscountInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailDlcID__SWIG_0() { }

	public static IntPtr new_RailDlcID__SWIG_1(ulong jarg1) { }

	public static IntPtr new_RailDlcInfo__SWIG_0() { }

	public static IntPtr new_RailDlcInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailDlcInstallProgress__SWIG_0() { }

	public static IntPtr new_RailDlcInstallProgress__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailDlcOwned__SWIG_0() { }

	public static IntPtr new_RailDlcOwned__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAchievementGlobalAchievementReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAchievementGlobalAchievementReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAchievementPlayerAchievementReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAchievementPlayerAchievementReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAchievementPlayerAchievementStored__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAchievementPlayerAchievementStored__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAppQuerySubscribeWishPlayStateResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAppQuerySubscribeWishPlayStateResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsAssetsChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsAssetsChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsCompleteConsumeFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsCompleteConsumeFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsDirectConsumeFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsDirectConsumeFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsExchangeAssetsFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsExchangeAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsExchangeAssetsToFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsExchangeAssetsToFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsMergeFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsMergeFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsMergeToFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsMergeToFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsRequestAllAssetsFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsRequestAllAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsSplitFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsSplitFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsSplitToFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsSplitToFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsStartConsumeFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsStartConsumeFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsUpdateAssetPropertyFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsUpdateAssetPropertyFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventAssetsUpdateConsumeFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventAssetsUpdateConsumeFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserCloseResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserCloseResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserCreateResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserCreateResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserDamageRectPaint__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserDamageRectPaint__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserJavascriptEvent__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserJavascriptEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserNavigeteResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserNavigeteResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserPaint__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserPaint__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserReloadResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserReloadResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserStateChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserStateChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserTitleChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserTitleChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventBrowserTryNavigateNewPageRequest__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventBrowserTryNavigateNewPageRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcCheckAllDlcsStateReadyResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcCheckAllDlcsStateReadyResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcInstallFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcInstallFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcInstallProgress__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcInstallProgress__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcInstallStart__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcInstallStart__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcInstallStartResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcInstallStartResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcOwnershipChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcOwnershipChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcQueryIsOwnedDlcsResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcQueryIsOwnedDlcsResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcRefundChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcRefundChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventDlcUninstallFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventDlcUninstallFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFinalize__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFinalize__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsAddFriendResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsAddFriendResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsClearMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsClearMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsFriendsListChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsFriendsListChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsGetFriendPlayedGamesResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsGetFriendPlayedGamesResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsGetInviteCommandLine__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsGetInviteCommandLine__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsGetMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsGetMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsMetadataChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsMetadataChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsOnlineStateChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsOnlineStateChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsListResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsReportPlayedWithUserListResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsReportPlayedWithUserListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventFriendsSetMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventFriendsSetMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerAddFavoriteGameServer__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerAddFavoriteGameServer__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerAuthSessionTicket__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerAuthSessionTicket__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerCreated__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerCreated__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerFavoriteGameServers__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerFavoriteGameServers__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerGetMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerGetMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerGetSessionTicket__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerGetSessionTicket__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerListResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerPlayerListResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerPlayerListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerRegisterToServerListResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerRegisterToServerListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerRemoveFavoriteGameServer__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerRemoveFavoriteGameServer__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGameServerSetMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGameServerSetMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGroupChatOpenGroupChatResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGroupChatOpenGroupChatResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventGroupChatQueryGroupsInfoResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventGroupChatQueryGroupsInfoResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventHttpSessionResponseResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventHttpSessionResponseResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventIMEHelperTextInputCompositionStateChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventIMEHelperTextInputCompositionStateChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventIMEHelperTextInputSelectedResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventIMEHelperTextInputSelectedResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGameCoinPurchaseCoinsResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGameCoinPurchaseCoinsResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGameCoinRequestCoinInfoResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGameCoinRequestCoinInfoResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGamePurchaseAllProductsInfoReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGamePurchaseAllProductsInfoReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGamePurchaseFinishOrderResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGamePurchaseFinishOrderResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGamePurchasePurchaseProductsResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGamePurchasePurchaseProductsResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGameStorePurchasePaymentResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGameStorePurchasePaymentResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGameStorePurchasePayWindowClosed__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGameStorePurchasePayWindowClosed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventInGameStorePurchasePayWindowDisplayed__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventInGameStorePurchasePayWindowDisplayed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventLeaderboardAsyncCreated__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventLeaderboardAsyncCreated__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventLeaderboardAttachSpaceWork__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventLeaderboardAttachSpaceWork__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventLeaderboardEntryReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventLeaderboardEntryReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventLeaderboardReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventLeaderboardReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventLeaderboardUploaded__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventLeaderboardUploaded__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventNetworkCreateRawSessionFailed__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventNetworkCreateRawSessionFailed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventNetworkCreateRawSessionRequest__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventNetworkCreateRawSessionRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventNetworkCreateSessionFailed__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventNetworkCreateSessionFailed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventNetworkCreateSessionRequest__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventNetworkCreateSessionRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventPlayerGetAuthenticateURL__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventPlayerGetAuthenticateURL__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventPlayerGetEncryptedGameTicketResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventPlayerGetEncryptedGameTicketResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventPlayerGetGamePurchaseKey__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventPlayerGetGamePurchaseKey__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventPlayerGetPlayerMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventPlayerGetPlayerMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventQueryPlayerBannedStatus__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventQueryPlayerBannedStatus__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomClearRoomMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomClearRoomMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomCreated__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomCreated__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomGetAllDataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomGetAllDataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomGetMemberMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomGetMemberMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomGetRoomListResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomGetRoomListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomGetRoomMembersResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomGetRoomMembersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomGetRoomMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomGetRoomMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomGetRoomTagResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomGetRoomTagResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomGetUserRoomListResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomGetUserRoomListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomJoinRoomResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomJoinRoomResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomKickOffMemberResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomKickOffMemberResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomLeaveRoomResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomLeaveRoomResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomNotifyMemberChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomNotifyMemberChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomNotifyMemberkicked__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomNotifyMemberkicked__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomNotifyMetadataChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomNotifyMetadataChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomNotifyRoomDataReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomNotifyRoomDataReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomNotifyRoomDestroyed__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomNotifyRoomDestroyed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomNotifyRoomGameServerChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomNotifyRoomGameServerChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomNotifyRoomOwnerChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomNotifyRoomOwnerChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomOpenRoomResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomOpenRoomResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomSetMemberMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomSetMemberMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomSetNewRoomOwnerResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomSetNewRoomOwnerResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomSetRoomMaxMemberResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomSetRoomMaxMemberResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomSetRoomMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomSetRoomMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomSetRoomTagResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomSetRoomTagResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventRoomSetRoomTypeResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventRoomSetRoomTypeResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventScreenshotPublishScreenshotFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventScreenshotPublishScreenshotFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventScreenshotTakeScreenshotFinished__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventScreenshotTakeScreenshotFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventScreenshotTakeScreenshotRequest__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventScreenshotTakeScreenshotRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventSessionTicketAuthSessionTicket__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventSessionTicketAuthSessionTicket__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventSessionTicketGetSessionTicket__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventSessionTicketGetSessionTicket__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventShowFloatingNotifyWindow__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventShowFloatingNotifyWindow__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventShowFloatingWindow__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventShowFloatingWindow__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventSmallObjectServiceDownloadResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventSmallObjectServiceDownloadResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventSmallObjectServiceQueryObjectStateResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventSmallObjectServiceQueryObjectStateResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStatsGlobalStatsReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStatsGlobalStatsReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStatsNumOfPlayerReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStatsNumOfPlayerReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStatsPlayerStatsReceived__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStatsPlayerStatsReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStatsPlayerStatsStored__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStatsPlayerStatsStored__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageAsyncDeleteStreamFileResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageAsyncDeleteStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageAsyncListStreamFileResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageAsyncListStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageAsyncReadFileResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageAsyncReadFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageAsyncReadStreamFileResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageAsyncReadStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageAsyncRenameStreamFileResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageAsyncRenameStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageAsyncWriteFileResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageAsyncWriteFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageAsyncWriteStreamFileResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageAsyncWriteStreamFileResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageQueryQuotaResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageQueryQuotaResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventStorageShareToSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventStorageShareToSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventSystemStateChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventSystemStateChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventTextInputShowTextInputWindowResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventTextInputShowTextInputWindowResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersCancelInviteResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersCancelInviteResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersGetInviteDetailResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersGetInviteDetailResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersGetUserLimitsResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersGetUserLimitsResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersGetUsersInfo__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersGetUsersInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersInviteJoinGameResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersInviteJoinGameResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersInviteUsersResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersInviteUsersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersNotifyInviter__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersNotifyInviter__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceDownloadProgress__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceDownloadProgress__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceDownloadResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceDownloadResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceGetMyFavoritesWorksResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceGetMyFavoritesWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceGetMySubscribedWorksResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceGetMySubscribedWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceModifyFavoritesWorksResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceModifyFavoritesWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceQuerySpaceWorksResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceQuerySpaceWorksResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceRateSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceRateSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceRemoveSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceRemoveSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceSearchSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceSearchSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceSubscribeResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceSubscribeResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceSyncResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceSyncResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceUpdateMetadataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceUpdateMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUserSpaceVoteSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUserSpaceVoteSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersRespondInvitation__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersRespondInvitation__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersShowChatWindowWithFriendResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersShowChatWindowWithFriendResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUsersShowUserHomepageWindowResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUsersShowUserHomepageWindowResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUtilsGameSettingMetadataChanged__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUtilsGameSettingMetadataChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventUtilsGetImageDataResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventUtilsGetImageDataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelAddUsersResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelAddUsersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelCreateResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelCreateResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelDataCaptured__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelDataCaptured__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelInviteEvent__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelInviteEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelJoinedResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelJoinedResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelLeaveResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelLeaveResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelMemberChangedEvent__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelMemberChangedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelRemoveUsersResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelRemoveUsersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult__SWIG_0() { }

	public static IntPtr new_RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByGameServer__SWIG_0() { }

	public static IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByGameServer__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByRoom__SWIG_0() { }

	public static IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByRoom__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByUser__SWIG_0() { }

	public static IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByUser__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFinalize__SWIG_0() { }

	public static IntPtr new_RailFinalize__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendInfo__SWIG_0() { }

	public static IntPtr new_RailFriendInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendMetadata__SWIG_0() { }

	public static IntPtr new_RailFriendMetadata__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendOnLineState__SWIG_0() { }

	public static IntPtr new_RailFriendOnLineState__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendPlayedGameInfo__SWIG_0() { }

	public static IntPtr new_RailFriendPlayedGameInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsAddFriendRequest__SWIG_0() { }

	public static IntPtr new_RailFriendsAddFriendRequest__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsAddFriendResult__SWIG_0() { }

	public static IntPtr new_RailFriendsAddFriendResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsClearMetadataResult__SWIG_0() { }

	public static IntPtr new_RailFriendsClearMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsGetInviteCommandLine__SWIG_0() { }

	public static IntPtr new_RailFriendsGetInviteCommandLine__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsGetMetadataResult__SWIG_0() { }

	public static IntPtr new_RailFriendsGetMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsListChanged__SWIG_0() { }

	public static IntPtr new_RailFriendsListChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsMetadataChanged__SWIG_0() { }

	public static IntPtr new_RailFriendsMetadataChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsOnlineStateChanged__SWIG_0() { }

	public static IntPtr new_RailFriendsOnlineStateChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsQueryFriendPlayedGamesResult__SWIG_0() { }

	public static IntPtr new_RailFriendsQueryFriendPlayedGamesResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsQueryPlayedWithFriendsGamesResult__SWIG_0() { }

	public static IntPtr new_RailFriendsQueryPlayedWithFriendsGamesResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsQueryPlayedWithFriendsListResult__SWIG_0() { }

	public static IntPtr new_RailFriendsQueryPlayedWithFriendsListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsQueryPlayedWithFriendsTimeResult__SWIG_0() { }

	public static IntPtr new_RailFriendsQueryPlayedWithFriendsTimeResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsReportPlayedWithUserListResult__SWIG_0() { }

	public static IntPtr new_RailFriendsReportPlayedWithUserListResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailFriendsSetMetadataResult__SWIG_0() { }

	public static IntPtr new_RailFriendsSetMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGameDefineGamePlayingState__SWIG_0() { }

	public static IntPtr new_RailGameDefineGamePlayingState__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGameID__SWIG_0() { }

	public static IntPtr new_RailGameID__SWIG_1(ulong jarg1) { }

	public static IntPtr new_RailGamePeer__SWIG_0() { }

	public static IntPtr new_RailGamePeer__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGameSettingMetadataChanged__SWIG_0() { }

	public static IntPtr new_RailGameSettingMetadataChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGeneratedAssetItem__SWIG_0() { }

	public static IntPtr new_RailGeneratedAssetItem__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGetAuthenticateURLOptions__SWIG_0() { }

	public static IntPtr new_RailGetAuthenticateURLOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGetEncryptedGameTicketResult__SWIG_0() { }

	public static IntPtr new_RailGetEncryptedGameTicketResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGetImageDataResult__SWIG_0() { }

	public static IntPtr new_RailGetImageDataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGetPlayerMetadataResult__SWIG_0() { }

	public static IntPtr new_RailGetPlayerMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailGroupInfo__SWIG_0() { }

	public static IntPtr new_RailGroupInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailHttpSessionResponse__SWIG_0() { }

	public static IntPtr new_RailHttpSessionResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailID__SWIG_0() { }

	public static IntPtr new_RailID__SWIG_1(ulong jarg1) { }

	public static IntPtr new_RailImageDataDescriptor__SWIG_0() { }

	public static IntPtr new_RailImageDataDescriptor__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailIMEHelperTextInputCompositionState__SWIG_0() { }

	public static IntPtr new_RailIMEHelperTextInputCompositionState__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailIMEHelperTextInputSelectedResult__SWIG_0() { }

	public static IntPtr new_RailIMEHelperTextInputSelectedResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGameCoinPurchaseCoinsResponse__SWIG_0() { }

	public static IntPtr new_RailInGameCoinPurchaseCoinsResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGameCoinRequestCoinInfoResponse__SWIG_0() { }

	public static IntPtr new_RailInGameCoinRequestCoinInfoResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGamePurchaseFinishOrderResponse__SWIG_0() { }

	public static IntPtr new_RailInGamePurchaseFinishOrderResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGamePurchasePurchaseProductsResponse__SWIG_0() { }

	public static IntPtr new_RailInGamePurchasePurchaseProductsResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGamePurchasePurchaseProductsToAssetsResponse__SWIG_0() { }

	public static IntPtr new_RailInGamePurchasePurchaseProductsToAssetsResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGamePurchaseRequestAllProductsResponse__SWIG_0() { }

	public static IntPtr new_RailInGamePurchaseRequestAllProductsResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGamePurchaseRequestAllPurchasableProductsResponse__SWIG_0() { }

	public static IntPtr new_RailInGamePurchaseRequestAllPurchasableProductsResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGameStorePurchasePayWindowClosed__SWIG_0() { }

	public static IntPtr new_RailInGameStorePurchasePayWindowClosed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGameStorePurchasePayWindowDisplayed__SWIG_0() { }

	public static IntPtr new_RailInGameStorePurchasePayWindowDisplayed__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInGameStorePurchaseResult__SWIG_0() { }

	public static IntPtr new_RailInGameStorePurchaseResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailInviteOptions__SWIG_0() { }

	public static IntPtr new_RailInviteOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailKeyValue() { }

	public static IntPtr new_RailKeyValueResult__SWIG_0() { }

	public static IntPtr new_RailKeyValueResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailListStreamFileOption__SWIG_0() { }

	public static IntPtr new_RailListStreamFileOption__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailNetworkSessionState__SWIG_0() { }

	public static IntPtr new_RailNetworkSessionState__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailOpenGroupChatResult__SWIG_0() { }

	public static IntPtr new_RailOpenGroupChatResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailPlatformNotifyEventJoinGameByGameServer__SWIG_0() { }

	public static IntPtr new_RailPlatformNotifyEventJoinGameByGameServer__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailPlatformNotifyEventJoinGameByRoom__SWIG_0() { }

	public static IntPtr new_RailPlatformNotifyEventJoinGameByRoom__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailPlatformNotifyEventJoinGameByUser__SWIG_0() { }

	public static IntPtr new_RailPlatformNotifyEventJoinGameByUser__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailPlayedWithFriendsGameItem__SWIG_0() { }

	public static IntPtr new_RailPlayedWithFriendsGameItem__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailPlayedWithFriendsTimeItem__SWIG_0() { }

	public static IntPtr new_RailPlayedWithFriendsTimeItem__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailProductItem__SWIG_0() { }

	public static IntPtr new_RailProductItem__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailPublishFileToUserSpaceOption__SWIG_0() { }

	public static IntPtr new_RailPublishFileToUserSpaceOption__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailPurchaseProductExtraInfo__SWIG_0() { }

	public static IntPtr new_RailPurchaseProductExtraInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailPurchaseProductInfo__SWIG_0() { }

	public static IntPtr new_RailPurchaseProductInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailQueryGroupsInfoResult__SWIG_0() { }

	public static IntPtr new_RailQueryGroupsInfoResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailQueryWorkFileOptions__SWIG_0() { }

	public static IntPtr new_RailQueryWorkFileOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSessionTicket() { }

	public static IntPtr new_RailShowChatWindowWithFriendResult__SWIG_0() { }

	public static IntPtr new_RailShowChatWindowWithFriendResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailShowUserHomepageWindowResult__SWIG_0() { }

	public static IntPtr new_RailShowUserHomepageWindowResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSmallObjectDownloadInfo__SWIG_0() { }

	public static IntPtr new_RailSmallObjectDownloadInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSmallObjectDownloadResult__SWIG_0() { }

	public static IntPtr new_RailSmallObjectDownloadResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSmallObjectState__SWIG_0() { }

	public static IntPtr new_RailSmallObjectState__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSmallObjectStateQueryResult__SWIG_0() { }

	public static IntPtr new_RailSmallObjectStateQueryResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSpaceWorkDescriptor__SWIG_0() { }

	public static IntPtr new_RailSpaceWorkDescriptor__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSpaceWorkFilter__SWIG_0() { }

	public static IntPtr new_RailSpaceWorkFilter__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSpaceWorkSearchFilter__SWIG_0() { }

	public static IntPtr new_RailSpaceWorkSearchFilter__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSpaceWorkSyncProgress__SWIG_0() { }

	public static IntPtr new_RailSpaceWorkSyncProgress__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSpaceWorkUpdateOptions__SWIG_0() { }

	public static IntPtr new_RailSpaceWorkUpdateOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSpaceWorkVoteDetail__SWIG_0() { }

	public static IntPtr new_RailSpaceWorkVoteDetail__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailStoreOptions__SWIG_0() { }

	public static IntPtr new_RailStoreOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailStreamFileInfo__SWIG_0() { }

	public static IntPtr new_RailStreamFileInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailStreamFileOption__SWIG_0() { }

	public static IntPtr new_RailStreamFileOption__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailString__SWIG_0() { }

	public static IntPtr new_RailString__SWIG_1(string jarg1) { }

	public static IntPtr new_RailSwitchPlayerSelectedZoneResult__SWIG_0() { }

	public static IntPtr new_RailSwitchPlayerSelectedZoneResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSyncFileOption__SWIG_0() { }

	public static IntPtr new_RailSyncFileOption__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailSystemStateChanged__SWIG_0() { }

	public static IntPtr new_RailSystemStateChanged__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailTextInputImeWindowOption__SWIG_0() { }

	public static IntPtr new_RailTextInputImeWindowOption__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailTextInputResult__SWIG_0() { }

	public static IntPtr new_RailTextInputResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailTextInputWindowOption__SWIG_0() { }

	public static IntPtr new_RailTextInputWindowOption__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUserPlayedWith__SWIG_0() { }

	public static IntPtr new_RailUserPlayedWith__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUsersCancelInviteResult__SWIG_0() { }

	public static IntPtr new_RailUsersCancelInviteResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUsersGetInviteDetailResult__SWIG_0() { }

	public static IntPtr new_RailUsersGetInviteDetailResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUsersGetUserLimitsResult__SWIG_0() { }

	public static IntPtr new_RailUsersGetUserLimitsResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUsersInfoData__SWIG_0() { }

	public static IntPtr new_RailUsersInfoData__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUsersInviteJoinGameResult__SWIG_0() { }

	public static IntPtr new_RailUsersInviteJoinGameResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUsersInviteUsersResult__SWIG_0() { }

	public static IntPtr new_RailUsersInviteUsersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUsersNotifyInviter__SWIG_0() { }

	public static IntPtr new_RailUsersNotifyInviter__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUserSpaceDownloadProgress__SWIG_0() { }

	public static IntPtr new_RailUserSpaceDownloadProgress__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUserSpaceDownloadResult__SWIG_0() { }

	public static IntPtr new_RailUserSpaceDownloadResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailUsersRespondInvitation__SWIG_0() { }

	public static IntPtr new_RailUsersRespondInvitation__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailVoiceCaptureOption__SWIG_0() { }

	public static IntPtr new_RailVoiceCaptureOption__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailVoiceCaptureSpecification__SWIG_0() { }

	public static IntPtr new_RailVoiceCaptureSpecification__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailVoiceChannelID__SWIG_0() { }

	public static IntPtr new_RailVoiceChannelID__SWIG_1(ulong jarg1) { }

	public static IntPtr new_RailVoiceChannelUserSpeakingState__SWIG_0() { }

	public static IntPtr new_RailVoiceChannelUserSpeakingState__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailWindowLayout__SWIG_0() { }

	public static IntPtr new_RailWindowLayout__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailWindowPosition__SWIG_0() { }

	public static IntPtr new_RailWindowPosition__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RailZoneID__SWIG_0() { }

	public static IntPtr new_RailZoneID__SWIG_1(ulong jarg1) { }

	public static IntPtr new_ReloadBrowserResult__SWIG_0() { }

	public static IntPtr new_ReloadBrowserResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RequestAllAssetsFinished__SWIG_0() { }

	public static IntPtr new_RequestAllAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RequestLeaderboardEntryParam__SWIG_0() { }

	public static IntPtr new_RequestLeaderboardEntryParam__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RoomDataReceived__SWIG_0() { }

	public static IntPtr new_RoomDataReceived__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RoomInfo__SWIG_0() { }

	public static IntPtr new_RoomInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RoomInfoListFilter__SWIG_0() { }

	public static IntPtr new_RoomInfoListFilter__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RoomInfoListFilterKey__SWIG_0() { }

	public static IntPtr new_RoomInfoListFilterKey__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RoomInfoListSorter__SWIG_0() { }

	public static IntPtr new_RoomInfoListSorter__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RoomMemberInfo__SWIG_0() { }

	public static IntPtr new_RoomMemberInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_RoomOptions__SWIG_0() { }

	public static IntPtr new_RoomOptions__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_ScreenshotRequestInfo__SWIG_0() { }

	public static IntPtr new_ScreenshotRequestInfo__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SetGameServerMetadataResult__SWIG_0() { }

	public static IntPtr new_SetGameServerMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SetMemberMetadataResult__SWIG_0() { }

	public static IntPtr new_SetMemberMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SetNewRoomOwnerResult__SWIG_0() { }

	public static IntPtr new_SetNewRoomOwnerResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SetRoomMaxMemberResult__SWIG_0() { }

	public static IntPtr new_SetRoomMaxMemberResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SetRoomMetadataResult__SWIG_0() { }

	public static IntPtr new_SetRoomMetadataResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SetRoomTagResult__SWIG_0() { }

	public static IntPtr new_SetRoomTagResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SetRoomTypeResult__SWIG_0() { }

	public static IntPtr new_SetRoomTypeResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_ShareStorageToSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_ShareStorageToSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_ShowFloatingWindowResult__SWIG_0() { }

	public static IntPtr new_ShowFloatingWindowResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_ShowNotifyWindow__SWIG_0() { }

	public static IntPtr new_ShowNotifyWindow__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SpaceWorkID__SWIG_0() { }

	public static IntPtr new_SpaceWorkID__SWIG_1(ulong jarg1) { }

	public static IntPtr new_SpaceWorkID__SWIG_2(IntPtr jarg1) { }

	public static IntPtr new_SplitAssetsFinished__SWIG_0() { }

	public static IntPtr new_SplitAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SplitAssetsToFinished__SWIG_0() { }

	public static IntPtr new_SplitAssetsToFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_StartConsumeAssetsFinished__SWIG_0() { }

	public static IntPtr new_StartConsumeAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_StartSessionWithPlayerResponse__SWIG_0() { }

	public static IntPtr new_StartSessionWithPlayerResponse__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_SyncSpaceWorkResult__SWIG_0() { }

	public static IntPtr new_SyncSpaceWorkResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_TakeScreenshotResult__SWIG_0() { }

	public static IntPtr new_TakeScreenshotResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_UpdateAssetsPropertyFinished__SWIG_0() { }

	public static IntPtr new_UpdateAssetsPropertyFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_UpdateConsumeAssetsFinished__SWIG_0() { }

	public static IntPtr new_UpdateConsumeAssetsFinished__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_UploadLeaderboardParam__SWIG_0() { }

	public static IntPtr new_UploadLeaderboardParam__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_UserSpaceDownloadProgress__SWIG_0() { }

	public static IntPtr new_UserSpaceDownloadProgress__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_UserSpaceDownloadResult__SWIG_0() { }

	public static IntPtr new_UserSpaceDownloadResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_VoiceChannelAddUsersResult__SWIG_0() { }

	public static IntPtr new_VoiceChannelAddUsersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_VoiceChannelInviteEvent__SWIG_0() { }

	public static IntPtr new_VoiceChannelInviteEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_VoiceChannelMemeberChangedEvent__SWIG_0() { }

	public static IntPtr new_VoiceChannelMemeberChangedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_VoiceChannelPushToTalkKeyChangedEvent__SWIG_0() { }

	public static IntPtr new_VoiceChannelPushToTalkKeyChangedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_VoiceChannelRemoveUsersResult__SWIG_0() { }

	public static IntPtr new_VoiceChannelRemoveUsersResult__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_VoiceChannelSpeakingUsersChangedEvent__SWIG_0() { }

	public static IntPtr new_VoiceChannelSpeakingUsersChangedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_VoiceChannelUsersSpeakingStateChangedEvent__SWIG_0() { }

	public static IntPtr new_VoiceChannelUsersSpeakingStateChangedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr new_VoiceDataCapturedEvent__SWIG_0() { }

	public static IntPtr new_VoiceDataCapturedEvent__SWIG_1(IntPtr jarg1) { }

	public static IntPtr NewInt() { }

	public static IntPtr NewInt64() { }

	public static IntPtr NotifyMetadataChange_changer_id_get(IntPtr jarg1) { }

	public static void NotifyMetadataChange_changer_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong NotifyMetadataChange_room_id_get(IntPtr jarg1) { }

	public static void NotifyMetadataChange_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr NotifyMetadataChange_SWIGUpcast(IntPtr jarg1) { }

	public static ulong NotifyRoomDestroy_room_id_get(IntPtr jarg1) { }

	public static void NotifyRoomDestroy_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr NotifyRoomDestroy_SWIGUpcast(IntPtr jarg1) { }

	public static ulong NotifyRoomGameServerChange_game_server_channel_id_get(IntPtr jarg1) { }

	public static void NotifyRoomGameServerChange_game_server_channel_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr NotifyRoomGameServerChange_game_server_rail_id_get(IntPtr jarg1) { }

	public static void NotifyRoomGameServerChange_game_server_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong NotifyRoomGameServerChange_room_id_get(IntPtr jarg1) { }

	public static void NotifyRoomGameServerChange_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr NotifyRoomGameServerChange_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr NotifyRoomMemberChange_changer_id_get(IntPtr jarg1) { }

	public static void NotifyRoomMemberChange_changer_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr NotifyRoomMemberChange_id_for_making_change_get(IntPtr jarg1) { }

	public static void NotifyRoomMemberChange_id_for_making_change_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong NotifyRoomMemberChange_room_id_get(IntPtr jarg1) { }

	public static void NotifyRoomMemberChange_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static int NotifyRoomMemberChange_state_change_get(IntPtr jarg1) { }

	public static void NotifyRoomMemberChange_state_change_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr NotifyRoomMemberChange_SWIGUpcast(IntPtr jarg1) { }

	public static uint NotifyRoomMemberKicked_due_to_kicker_lost_connect_get(IntPtr jarg1) { }

	public static void NotifyRoomMemberKicked_due_to_kicker_lost_connect_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr NotifyRoomMemberKicked_id_for_making_kick_get(IntPtr jarg1) { }

	public static void NotifyRoomMemberKicked_id_for_making_kick_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr NotifyRoomMemberKicked_kicked_id_get(IntPtr jarg1) { }

	public static void NotifyRoomMemberKicked_kicked_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong NotifyRoomMemberKicked_room_id_get(IntPtr jarg1) { }

	public static void NotifyRoomMemberKicked_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr NotifyRoomMemberKicked_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr NotifyRoomOwnerChange_new_owner_id_get(IntPtr jarg1) { }

	public static void NotifyRoomOwnerChange_new_owner_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr NotifyRoomOwnerChange_old_owner_id_get(IntPtr jarg1) { }

	public static void NotifyRoomOwnerChange_old_owner_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int NotifyRoomOwnerChange_reason_get(IntPtr jarg1) { }

	public static void NotifyRoomOwnerChange_reason_set(IntPtr jarg1, int jarg2) { }

	public static ulong NotifyRoomOwnerChange_room_id_get(IntPtr jarg1) { }

	public static void NotifyRoomOwnerChange_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr NotifyRoomOwnerChange_SWIGUpcast(IntPtr jarg1) { }

	public static int NumberOfPlayerReceived_offline_number_get(IntPtr jarg1) { }

	public static void NumberOfPlayerReceived_offline_number_set(IntPtr jarg1, int jarg2) { }

	public static int NumberOfPlayerReceived_online_number_get(IntPtr jarg1) { }

	public static void NumberOfPlayerReceived_online_number_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr NumberOfPlayerReceived_SWIGUpcast(IntPtr jarg1) { }

	public static ulong OpenRoomResult_room_id_get(IntPtr jarg1) { }

	public static void OpenRoomResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr OpenRoomResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr PlayerAchievementReceived_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr PlayerAchievementStored_achievement_name_get(IntPtr jarg1) { }

	public static void PlayerAchievementStored_achievement_name_set(IntPtr jarg1, string jarg2) { }

	public static uint PlayerAchievementStored_current_progress_get(IntPtr jarg1) { }

	public static void PlayerAchievementStored_current_progress_set(IntPtr jarg1, uint jarg2) { }

	public static bool PlayerAchievementStored_group_achievement_get(IntPtr jarg1) { }

	public static void PlayerAchievementStored_group_achievement_set(IntPtr jarg1, bool jarg2) { }

	public static uint PlayerAchievementStored_max_progress_get(IntPtr jarg1) { }

	public static void PlayerAchievementStored_max_progress_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr PlayerAchievementStored_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr PlayerGetGamePurchaseKeyResult_purchase_key_get(IntPtr jarg1) { }

	public static void PlayerGetGamePurchaseKeyResult_purchase_key_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr PlayerGetGamePurchaseKeyResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr PlayerPersonalInfo_avatar_url_get(IntPtr jarg1) { }

	public static void PlayerPersonalInfo_avatar_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr PlayerPersonalInfo_email_address_get(IntPtr jarg1) { }

	public static void PlayerPersonalInfo_email_address_set(IntPtr jarg1, string jarg2) { }

	public static int PlayerPersonalInfo_error_code_get(IntPtr jarg1) { }

	public static void PlayerPersonalInfo_error_code_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr PlayerPersonalInfo_rail_id_get(IntPtr jarg1) { }

	public static void PlayerPersonalInfo_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint PlayerPersonalInfo_rail_level_get(IntPtr jarg1) { }

	public static void PlayerPersonalInfo_rail_level_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr PlayerPersonalInfo_rail_name_get(IntPtr jarg1) { }

	public static void PlayerPersonalInfo_rail_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr PlayerStatsReceived_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr PlayerStatsStored_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr PublishScreenshotResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr PublishScreenshotResult_work_id_get(IntPtr jarg1) { }

	public static void PublishScreenshotResult_work_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr QueryIsOwnedDlcsResult_dlc_owned_list_get(IntPtr jarg1) { }

	public static void QueryIsOwnedDlcsResult_dlc_owned_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr QueryIsOwnedDlcsResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr QueryMySubscribedSpaceWorksResult_spacework_descriptors_get(IntPtr jarg1) { }

	public static void QueryMySubscribedSpaceWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int QueryMySubscribedSpaceWorksResult_spacework_type_get(IntPtr jarg1) { }

	public static void QueryMySubscribedSpaceWorksResult_spacework_type_set(IntPtr jarg1, int jarg2) { }

	public static uint QueryMySubscribedSpaceWorksResult_total_available_works_get(IntPtr jarg1) { }

	public static void QueryMySubscribedSpaceWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2) { }

	public static int QueryPlayerBannedStatus_status_get(IntPtr jarg1) { }

	public static void QueryPlayerBannedStatus_status_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr QueryPlayerBannedStatus_SWIGUpcast(IntPtr jarg1) { }

	public static bool QuerySubscribeWishPlayStateResult_is_subscribed_get(IntPtr jarg1) { }

	public static void QuerySubscribeWishPlayStateResult_is_subscribed_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr QuerySubscribeWishPlayStateResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RAIL_SDK_PACKING_get() { }

	public static uint RailAntiAddictionGameOnlineTimeChanged_game_online_time_count_minutes_get(IntPtr jarg1) { }

	public static void RailAntiAddictionGameOnlineTimeChanged_game_online_time_count_minutes_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailAntiAddictionGameOnlineTimeChanged_SWIGUpcast(IntPtr jarg1) { }

	public static void RailArrayEnumRailSpaceWorkType_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayEnumRailSpaceWorkType_buf(IntPtr jarg1) { }

	public static void RailArrayEnumRailSpaceWorkType_clear(IntPtr jarg1) { }

	public static void RailArrayEnumRailSpaceWorkType_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayEnumRailSpaceWorkType_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayEnumRailSpaceWorkType_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayEnumRailSpaceWorkType_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayEnumRailSpaceWorkType_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayEnumRailSpaceWorkType_size(IntPtr jarg1) { }

	public static void RailArrayEnumRailUsersLimits_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayEnumRailUsersLimits_buf(IntPtr jarg1) { }

	public static void RailArrayEnumRailUsersLimits_clear(IntPtr jarg1) { }

	public static void RailArrayEnumRailUsersLimits_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayEnumRailUsersLimits_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayEnumRailUsersLimits_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayEnumRailUsersLimits_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayEnumRailUsersLimits_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayEnumRailUsersLimits_size(IntPtr jarg1) { }

	public static void RailArrayEnumRailWorkFileClass_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayEnumRailWorkFileClass_buf(IntPtr jarg1) { }

	public static void RailArrayEnumRailWorkFileClass_clear(IntPtr jarg1) { }

	public static void RailArrayEnumRailWorkFileClass_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayEnumRailWorkFileClass_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayEnumRailWorkFileClass_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayEnumRailWorkFileClass_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayEnumRailWorkFileClass_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayEnumRailWorkFileClass_size(IntPtr jarg1) { }

	public static void RailArrayGameServerInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayGameServerInfo_buf(IntPtr jarg1) { }

	public static void RailArrayGameServerInfo_clear(IntPtr jarg1) { }

	public static void RailArrayGameServerInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayGameServerInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayGameServerInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayGameServerInfo_size(IntPtr jarg1) { }

	public static void RailArrayGameServerListFilter_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayGameServerListFilter_buf(IntPtr jarg1) { }

	public static void RailArrayGameServerListFilter_clear(IntPtr jarg1) { }

	public static void RailArrayGameServerListFilter_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerListFilter_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayGameServerListFilter_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayGameServerListFilter_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerListFilter_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayGameServerListFilter_size(IntPtr jarg1) { }

	public static void RailArrayGameServerListFilterKey_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayGameServerListFilterKey_buf(IntPtr jarg1) { }

	public static void RailArrayGameServerListFilterKey_clear(IntPtr jarg1) { }

	public static void RailArrayGameServerListFilterKey_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerListFilterKey_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayGameServerListFilterKey_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayGameServerListFilterKey_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerListFilterKey_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayGameServerListFilterKey_size(IntPtr jarg1) { }

	public static void RailArrayGameServerListSorter_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayGameServerListSorter_buf(IntPtr jarg1) { }

	public static void RailArrayGameServerListSorter_clear(IntPtr jarg1) { }

	public static void RailArrayGameServerListSorter_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerListSorter_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayGameServerListSorter_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayGameServerListSorter_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerListSorter_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayGameServerListSorter_size(IntPtr jarg1) { }

	public static void RailArrayGameServerPlayerInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayGameServerPlayerInfo_buf(IntPtr jarg1) { }

	public static void RailArrayGameServerPlayerInfo_clear(IntPtr jarg1) { }

	public static void RailArrayGameServerPlayerInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerPlayerInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayGameServerPlayerInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayGameServerPlayerInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayGameServerPlayerInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayGameServerPlayerInfo_size(IntPtr jarg1) { }

	public static void RailArrayPlayerPersonalInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayPlayerPersonalInfo_buf(IntPtr jarg1) { }

	public static void RailArrayPlayerPersonalInfo_clear(IntPtr jarg1) { }

	public static void RailArrayPlayerPersonalInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayPlayerPersonalInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayPlayerPersonalInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayPlayerPersonalInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayPlayerPersonalInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayPlayerPersonalInfo_size(IntPtr jarg1) { }

	public static void RailArrayRailAssetInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailAssetInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRailAssetInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRailAssetInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailAssetInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailAssetInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailAssetInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailAssetInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailAssetInfo_size(IntPtr jarg1) { }

	public static void RailArrayRailAssetItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailAssetItem_buf(IntPtr jarg1) { }

	public static void RailArrayRailAssetItem_clear(IntPtr jarg1) { }

	public static void RailArrayRailAssetItem_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailAssetItem_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailAssetItem_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailAssetItem_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailAssetItem_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailAssetItem_size(IntPtr jarg1) { }

	public static void RailArrayRailAssetProperty_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailAssetProperty_buf(IntPtr jarg1) { }

	public static void RailArrayRailAssetProperty_clear(IntPtr jarg1) { }

	public static void RailArrayRailAssetProperty_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailAssetProperty_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailAssetProperty_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailAssetProperty_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailAssetProperty_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailAssetProperty_size(IntPtr jarg1) { }

	public static void RailArrayRailCoinInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailCoinInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRailCoinInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRailCoinInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailCoinInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailCoinInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailCoinInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailCoinInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailCoinInfo_size(IntPtr jarg1) { }

	public static void RailArrayRailDlcID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailDlcID_buf(IntPtr jarg1) { }

	public static void RailArrayRailDlcID_clear(IntPtr jarg1) { }

	public static void RailArrayRailDlcID_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailDlcID_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailDlcID_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailDlcID_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailDlcID_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailDlcID_size(IntPtr jarg1) { }

	public static void RailArrayRailDlcOwned_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailDlcOwned_buf(IntPtr jarg1) { }

	public static void RailArrayRailDlcOwned_clear(IntPtr jarg1) { }

	public static void RailArrayRailDlcOwned_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailDlcOwned_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailDlcOwned_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailDlcOwned_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailDlcOwned_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailDlcOwned_size(IntPtr jarg1) { }

	public static void RailArrayRailFriendInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailFriendInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRailFriendInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRailFriendInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailFriendInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailFriendInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailFriendInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailFriendInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailFriendInfo_size(IntPtr jarg1) { }

	public static void RailArrayRailFriendMetadata_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailFriendMetadata_buf(IntPtr jarg1) { }

	public static void RailArrayRailFriendMetadata_clear(IntPtr jarg1) { }

	public static void RailArrayRailFriendMetadata_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailFriendMetadata_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailFriendMetadata_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailFriendMetadata_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailFriendMetadata_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailFriendMetadata_size(IntPtr jarg1) { }

	public static void RailArrayRailFriendPlayedGameInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailFriendPlayedGameInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRailFriendPlayedGameInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRailFriendPlayedGameInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailFriendPlayedGameInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailFriendPlayedGameInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailFriendPlayedGameInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailFriendPlayedGameInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailFriendPlayedGameInfo_size(IntPtr jarg1) { }

	public static void RailArrayRailGameDefineGamePlayingState_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailGameDefineGamePlayingState_buf(IntPtr jarg1) { }

	public static void RailArrayRailGameDefineGamePlayingState_clear(IntPtr jarg1) { }

	public static void RailArrayRailGameDefineGamePlayingState_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailGameDefineGamePlayingState_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailGameDefineGamePlayingState_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailGameDefineGamePlayingState_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailGameDefineGamePlayingState_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailGameDefineGamePlayingState_size(IntPtr jarg1) { }

	public static void RailArrayRailGameID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailGameID_buf(IntPtr jarg1) { }

	public static void RailArrayRailGameID_clear(IntPtr jarg1) { }

	public static void RailArrayRailGameID_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailGameID_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailGameID_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailGameID_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailGameID_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailGameID_size(IntPtr jarg1) { }

	public static void RailArrayRailGeneratedAssetItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailGeneratedAssetItem_buf(IntPtr jarg1) { }

	public static void RailArrayRailGeneratedAssetItem_clear(IntPtr jarg1) { }

	public static void RailArrayRailGeneratedAssetItem_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailGeneratedAssetItem_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailGeneratedAssetItem_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailGeneratedAssetItem_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailGeneratedAssetItem_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailGeneratedAssetItem_size(IntPtr jarg1) { }

	public static void RailArrayRailID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailID_buf(IntPtr jarg1) { }

	public static void RailArrayRailID_clear(IntPtr jarg1) { }

	public static void RailArrayRailID_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailID_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailID_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailID_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailID_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailID_size(IntPtr jarg1) { }

	public static void RailArrayRailKeyValue_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailKeyValue_buf(IntPtr jarg1) { }

	public static void RailArrayRailKeyValue_clear(IntPtr jarg1) { }

	public static void RailArrayRailKeyValue_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailKeyValue_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailKeyValue_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailKeyValue_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailKeyValue_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailKeyValue_size(IntPtr jarg1) { }

	public static void RailArrayRailKeyValueResult_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailKeyValueResult_buf(IntPtr jarg1) { }

	public static void RailArrayRailKeyValueResult_clear(IntPtr jarg1) { }

	public static void RailArrayRailKeyValueResult_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailKeyValueResult_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailKeyValueResult_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailKeyValueResult_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailKeyValueResult_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailKeyValueResult_size(IntPtr jarg1) { }

	public static void RailArrayRailPlayedWithFriendsGameItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailPlayedWithFriendsGameItem_buf(IntPtr jarg1) { }

	public static void RailArrayRailPlayedWithFriendsGameItem_clear(IntPtr jarg1) { }

	public static void RailArrayRailPlayedWithFriendsGameItem_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailPlayedWithFriendsGameItem_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailPlayedWithFriendsGameItem_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailPlayedWithFriendsGameItem_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailPlayedWithFriendsGameItem_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailPlayedWithFriendsGameItem_size(IntPtr jarg1) { }

	public static void RailArrayRailPlayedWithFriendsTimeItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailPlayedWithFriendsTimeItem_buf(IntPtr jarg1) { }

	public static void RailArrayRailPlayedWithFriendsTimeItem_clear(IntPtr jarg1) { }

	public static void RailArrayRailPlayedWithFriendsTimeItem_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailPlayedWithFriendsTimeItem_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailPlayedWithFriendsTimeItem_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailPlayedWithFriendsTimeItem_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailPlayedWithFriendsTimeItem_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailPlayedWithFriendsTimeItem_size(IntPtr jarg1) { }

	public static void RailArrayRailProductItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailProductItem_buf(IntPtr jarg1) { }

	public static void RailArrayRailProductItem_clear(IntPtr jarg1) { }

	public static void RailArrayRailProductItem_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailProductItem_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailProductItem_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailProductItem_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailProductItem_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailProductItem_size(IntPtr jarg1) { }

	public static void RailArrayRailPurchaseProductInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailPurchaseProductInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRailPurchaseProductInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRailPurchaseProductInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailPurchaseProductInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailPurchaseProductInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailPurchaseProductInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailPurchaseProductInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailPurchaseProductInfo_size(IntPtr jarg1) { }

	public static void RailArrayRailSmallObjectDownloadInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailSmallObjectDownloadInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRailSmallObjectDownloadInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRailSmallObjectDownloadInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailSmallObjectDownloadInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailSmallObjectDownloadInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailSmallObjectDownloadInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailSmallObjectDownloadInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailSmallObjectDownloadInfo_size(IntPtr jarg1) { }

	public static void RailArrayRailSmallObjectState_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailSmallObjectState_buf(IntPtr jarg1) { }

	public static void RailArrayRailSmallObjectState_clear(IntPtr jarg1) { }

	public static void RailArrayRailSmallObjectState_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailSmallObjectState_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailSmallObjectState_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailSmallObjectState_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailSmallObjectState_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailSmallObjectState_size(IntPtr jarg1) { }

	public static void RailArrayRailSpaceWorkDescriptor_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailSpaceWorkDescriptor_buf(IntPtr jarg1) { }

	public static void RailArrayRailSpaceWorkDescriptor_clear(IntPtr jarg1) { }

	public static void RailArrayRailSpaceWorkDescriptor_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailSpaceWorkDescriptor_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailSpaceWorkDescriptor_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailSpaceWorkDescriptor_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailSpaceWorkDescriptor_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailSpaceWorkDescriptor_size(IntPtr jarg1) { }

	public static void RailArrayRailSpaceWorkVoteDetail_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailSpaceWorkVoteDetail_buf(IntPtr jarg1) { }

	public static void RailArrayRailSpaceWorkVoteDetail_clear(IntPtr jarg1) { }

	public static void RailArrayRailSpaceWorkVoteDetail_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailSpaceWorkVoteDetail_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailSpaceWorkVoteDetail_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailSpaceWorkVoteDetail_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailSpaceWorkVoteDetail_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailSpaceWorkVoteDetail_size(IntPtr jarg1) { }

	public static void RailArrayRailStreamFileInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailStreamFileInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRailStreamFileInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRailStreamFileInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailStreamFileInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailStreamFileInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailStreamFileInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailStreamFileInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailStreamFileInfo_size(IntPtr jarg1) { }

	public static void RailArrayRailString_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailString_buf(IntPtr jarg1) { }

	public static void RailArrayRailString_clear(IntPtr jarg1) { }

	public static void RailArrayRailString_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailString_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailString_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailString_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailString_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailString_size(IntPtr jarg1) { }

	public static void RailArrayRailUserPlayedWith_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailUserPlayedWith_buf(IntPtr jarg1) { }

	public static void RailArrayRailUserPlayedWith_clear(IntPtr jarg1) { }

	public static void RailArrayRailUserPlayedWith_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailUserPlayedWith_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailUserPlayedWith_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailUserPlayedWith_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailUserPlayedWith_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailUserPlayedWith_size(IntPtr jarg1) { }

	public static void RailArrayRailUserSpaceDownloadProgress_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailUserSpaceDownloadProgress_buf(IntPtr jarg1) { }

	public static void RailArrayRailUserSpaceDownloadProgress_clear(IntPtr jarg1) { }

	public static void RailArrayRailUserSpaceDownloadProgress_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailUserSpaceDownloadProgress_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailUserSpaceDownloadProgress_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailUserSpaceDownloadProgress_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailUserSpaceDownloadProgress_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailUserSpaceDownloadProgress_size(IntPtr jarg1) { }

	public static void RailArrayRailUserSpaceDownloadResult_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailUserSpaceDownloadResult_buf(IntPtr jarg1) { }

	public static void RailArrayRailUserSpaceDownloadResult_clear(IntPtr jarg1) { }

	public static void RailArrayRailUserSpaceDownloadResult_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailUserSpaceDownloadResult_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailUserSpaceDownloadResult_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailUserSpaceDownloadResult_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailUserSpaceDownloadResult_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailUserSpaceDownloadResult_size(IntPtr jarg1) { }

	public static void RailArrayRailVoiceChannelUserSpeakingState_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailVoiceChannelUserSpeakingState_buf(IntPtr jarg1) { }

	public static void RailArrayRailVoiceChannelUserSpeakingState_clear(IntPtr jarg1) { }

	public static void RailArrayRailVoiceChannelUserSpeakingState_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailVoiceChannelUserSpeakingState_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailVoiceChannelUserSpeakingState_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailVoiceChannelUserSpeakingState_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailVoiceChannelUserSpeakingState_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailVoiceChannelUserSpeakingState_size(IntPtr jarg1) { }

	public static void RailArrayRailZoneID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRailZoneID_buf(IntPtr jarg1) { }

	public static void RailArrayRailZoneID_clear(IntPtr jarg1) { }

	public static void RailArrayRailZoneID_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailZoneID_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRailZoneID_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRailZoneID_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRailZoneID_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRailZoneID_size(IntPtr jarg1) { }

	public static void RailArrayRoomInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRoomInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRoomInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRoomInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRoomInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRoomInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRoomInfo_size(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListFilter_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRoomInfoListFilter_buf(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListFilter_clear(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListFilter_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomInfoListFilter_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRoomInfoListFilter_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRoomInfoListFilter_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomInfoListFilter_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRoomInfoListFilter_size(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListFilterKey_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRoomInfoListFilterKey_buf(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListFilterKey_clear(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListFilterKey_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomInfoListFilterKey_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRoomInfoListFilterKey_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRoomInfoListFilterKey_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomInfoListFilterKey_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRoomInfoListFilterKey_size(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListSorter_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRoomInfoListSorter_buf(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListSorter_clear(IntPtr jarg1) { }

	public static void RailArrayRoomInfoListSorter_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomInfoListSorter_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRoomInfoListSorter_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRoomInfoListSorter_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomInfoListSorter_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRoomInfoListSorter_size(IntPtr jarg1) { }

	public static void RailArrayRoomMemberInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayRoomMemberInfo_buf(IntPtr jarg1) { }

	public static void RailArrayRoomMemberInfo_clear(IntPtr jarg1) { }

	public static void RailArrayRoomMemberInfo_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomMemberInfo_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayRoomMemberInfo_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArrayRoomMemberInfo_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayRoomMemberInfo_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayRoomMemberInfo_size(IntPtr jarg1) { }

	public static void RailArraySpaceWorkID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArraySpaceWorkID_buf(IntPtr jarg1) { }

	public static void RailArraySpaceWorkID_clear(IntPtr jarg1) { }

	public static void RailArraySpaceWorkID_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArraySpaceWorkID_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArraySpaceWorkID_push_back(IntPtr jarg1, IntPtr jarg2) { }

	public static void RailArraySpaceWorkID_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArraySpaceWorkID_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArraySpaceWorkID_size(IntPtr jarg1) { }

	public static void RailArrayuint32_t_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayuint32_t_buf(IntPtr jarg1) { }

	public static void RailArrayuint32_t_clear(IntPtr jarg1) { }

	public static void RailArrayuint32_t_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayuint32_t_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayuint32_t_push_back(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayuint32_t_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayuint32_t_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayuint32_t_size(IntPtr jarg1) { }

	public static void RailArrayuint64_t_assign(IntPtr jarg1, out ulong jarg2, uint jarg3) { }

	public static IntPtr RailArrayuint64_t_buf(IntPtr jarg1) { }

	public static void RailArrayuint64_t_clear(IntPtr jarg1) { }

	public static void RailArrayuint64_t_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayuint64_t_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayuint64_t_push_back(IntPtr jarg1, ulong jarg2) { }

	public static void RailArrayuint64_t_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayuint64_t_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayuint64_t_size(IntPtr jarg1) { }

	public static void RailArrayuint8_t_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3) { }

	public static IntPtr RailArrayuint8_t_buf(IntPtr jarg1) { }

	public static void RailArrayuint8_t_clear(IntPtr jarg1) { }

	public static void RailArrayuint8_t_erase(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayuint8_t_Item(IntPtr jarg1, uint jarg2) { }

	public static void RailArrayuint8_t_push_back(IntPtr jarg1, byte jarg2) { }

	public static void RailArrayuint8_t_resize(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailArrayuint8_t_SetValue(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailArrayuint8_t_size(IntPtr jarg1) { }

	public static ulong RailAssetInfo_asset_id_get(IntPtr jarg1) { }

	public static void RailAssetInfo_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static ulong RailAssetInfo_container_id_get(IntPtr jarg1) { }

	public static void RailAssetInfo_container_id_set(IntPtr jarg1, ulong jarg2) { }

	public static uint RailAssetInfo_expire_time_get(IntPtr jarg1) { }

	public static void RailAssetInfo_expire_time_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailAssetInfo_flag_get(IntPtr jarg1) { }

	public static void RailAssetInfo_flag_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailAssetInfo_origin_get(IntPtr jarg1) { }

	public static void RailAssetInfo_origin_set(IntPtr jarg1, uint jarg2) { }

	public static int RailAssetInfo_position_get(IntPtr jarg1) { }

	public static void RailAssetInfo_position_set(IntPtr jarg1, int jarg2) { }

	public static uint RailAssetInfo_product_id_get(IntPtr jarg1) { }

	public static void RailAssetInfo_product_id_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailAssetInfo_product_name_get(IntPtr jarg1) { }

	public static void RailAssetInfo_product_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailAssetInfo_progress_get(IntPtr jarg1) { }

	public static void RailAssetInfo_progress_set(IntPtr jarg1, string jarg2) { }

	public static uint RailAssetInfo_quantity_get(IntPtr jarg1) { }

	public static void RailAssetInfo_quantity_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailAssetInfo_state_get(IntPtr jarg1) { }

	public static void RailAssetInfo_state_set(IntPtr jarg1, uint jarg2) { }

	public static ulong RailAssetItem_asset_id_get(IntPtr jarg1) { }

	public static void RailAssetItem_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static uint RailAssetItem_quantity_get(IntPtr jarg1) { }

	public static void RailAssetItem_quantity_set(IntPtr jarg1, uint jarg2) { }

	public static ulong RailAssetProperty_asset_id_get(IntPtr jarg1) { }

	public static void RailAssetProperty_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static uint RailAssetProperty_position_get(IntPtr jarg1) { }

	public static void RailAssetProperty_position_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailAssetsChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailBranchInfo_branch_id_get(IntPtr jarg1) { }

	public static void RailBranchInfo_branch_id_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailBranchInfo_branch_name_get(IntPtr jarg1) { }

	public static void RailBranchInfo_branch_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailBranchInfo_branch_type_get(IntPtr jarg1) { }

	public static void RailBranchInfo_branch_type_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailBranchInfo_build_number_get(IntPtr jarg1) { }

	public static void RailBranchInfo_build_number_set(IntPtr jarg1, string jarg2) { }

	public static uint RailCoinInfo_coin_class_id_get(IntPtr jarg1) { }

	public static void RailCoinInfo_coin_class_id_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailCoinInfo_description_get(IntPtr jarg1) { }

	public static void RailCoinInfo_description_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailCoinInfo_exchange_rate_get(IntPtr jarg1) { }

	public static void RailCoinInfo_exchange_rate_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailCoinInfo_icon_url_get(IntPtr jarg1) { }

	public static void RailCoinInfo_icon_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailCoinInfo_metadata_get(IntPtr jarg1) { }

	public static void RailCoinInfo_metadata_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailCoinInfo_name_get(IntPtr jarg1) { }

	public static void RailCoinInfo_name_set(IntPtr jarg1, string jarg2) { }

	public static uint RailCoins_coin_class_id_get(IntPtr jarg1) { }

	public static void RailCoins_coin_class_id_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailCoins_quantity_get(IntPtr jarg1) { }

	public static void RailCoins_quantity_set(IntPtr jarg1, uint jarg2) { }

	public static float RailCoins_total_price_get(IntPtr jarg1) { }

	public static void RailCoins_total_price_set(IntPtr jarg1, float jarg2) { }

	public static uint RailCrashBuffer_AppendData(IntPtr jarg1, string jarg2, uint jarg3) { }

	public static uint RailCrashBuffer_GetBufferLength(IntPtr jarg1) { }

	public static IntPtr RailCrashBuffer_GetData(IntPtr jarg1) { }

	public static uint RailCrashBuffer_GetValidLength(IntPtr jarg1) { }

	public static uint RailCrashBuffer_SetData__SWIG_0(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4) { }

	public static uint RailCrashBuffer_SetData__SWIG_1(IntPtr jarg1, string jarg2, uint jarg3) { }

	public static int RailCrashInfo_exception_type_get(IntPtr jarg1) { }

	public static void RailCrashInfo_exception_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailCurrencyExchangeCoinRate_currency_get(IntPtr jarg1) { }

	public static void RailCurrencyExchangeCoinRate_currency_set(IntPtr jarg1, string jarg2) { }

	public static float RailCurrencyExchangeCoinRate_pay_price_get(IntPtr jarg1) { }

	public static void RailCurrencyExchangeCoinRate_pay_price_set(IntPtr jarg1, float jarg2) { }

	public static uint RailCurrencyExchangeCoinRate_to_exchange_coins_get(IntPtr jarg1) { }

	public static void RailCurrencyExchangeCoinRate_to_exchange_coins_set(IntPtr jarg1, uint jarg2) { }

	public static int RailDirtyWordsCheckResult_dirty_type_get(IntPtr jarg1) { }

	public static void RailDirtyWordsCheckResult_dirty_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailDirtyWordsCheckResult_replace_string_get(IntPtr jarg1) { }

	public static void RailDirtyWordsCheckResult_replace_string_set(IntPtr jarg1, string jarg2) { }

	public static float RailDiscountInfo_discount_price_get(IntPtr jarg1) { }

	public static void RailDiscountInfo_discount_price_set(IntPtr jarg1, float jarg2) { }

	public static uint RailDiscountInfo_end_time_get(IntPtr jarg1) { }

	public static void RailDiscountInfo_end_time_set(IntPtr jarg1, uint jarg2) { }

	public static float RailDiscountInfo_off_get(IntPtr jarg1) { }

	public static void RailDiscountInfo_off_set(IntPtr jarg1, float jarg2) { }

	public static uint RailDiscountInfo_start_time_get(IntPtr jarg1) { }

	public static void RailDiscountInfo_start_time_set(IntPtr jarg1, uint jarg2) { }

	public static int RailDiscountInfo_type_get(IntPtr jarg1) { }

	public static void RailDiscountInfo_type_set(IntPtr jarg1, int jarg2) { }

	public static ulong RailDlcID_get_id(IntPtr jarg1) { }

	public static bool RailDlcID_IsValid(IntPtr jarg1) { }

	public static void RailDlcID_set_id(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr RailDlcInfo_description_get(IntPtr jarg1) { }

	public static void RailDlcInfo_description_set(IntPtr jarg1, string jarg2) { }

	public static double RailDlcInfo_discount_price_get(IntPtr jarg1) { }

	public static void RailDlcInfo_discount_price_set(IntPtr jarg1, double jarg2) { }

	public static IntPtr RailDlcInfo_dlc_id_get(IntPtr jarg1) { }

	public static void RailDlcInfo_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailDlcInfo_game_id_get(IntPtr jarg1) { }

	public static void RailDlcInfo_game_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailDlcInfo_name_get(IntPtr jarg1) { }

	public static void RailDlcInfo_name_set(IntPtr jarg1, string jarg2) { }

	public static double RailDlcInfo_original_price_get(IntPtr jarg1) { }

	public static void RailDlcInfo_original_price_set(IntPtr jarg1, double jarg2) { }

	public static IntPtr RailDlcInfo_version_get(IntPtr jarg1) { }

	public static void RailDlcInfo_version_set(IntPtr jarg1, string jarg2) { }

	public static ulong RailDlcInstallProgress_finished_bytes_get(IntPtr jarg1) { }

	public static void RailDlcInstallProgress_finished_bytes_set(IntPtr jarg1, ulong jarg2) { }

	public static uint RailDlcInstallProgress_progress_get(IntPtr jarg1) { }

	public static void RailDlcInstallProgress_progress_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailDlcInstallProgress_speed_get(IntPtr jarg1) { }

	public static void RailDlcInstallProgress_speed_set(IntPtr jarg1, uint jarg2) { }

	public static ulong RailDlcInstallProgress_total_bytes_get(IntPtr jarg1) { }

	public static void RailDlcInstallProgress_total_bytes_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr RailDlcOwned_dlc_id_get(IntPtr jarg1) { }

	public static void RailDlcOwned_dlc_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool RailDlcOwned_is_owned_get(IntPtr jarg1) { }

	public static void RailDlcOwned_is_owned_set(IntPtr jarg1, bool jarg2) { }

	public static int RailEventkRailEventAchievementGlobalAchievementReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAchievementGlobalAchievementReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAchievementGlobalAchievementReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAchievementPlayerAchievementReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAchievementPlayerAchievementReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAchievementPlayerAchievementReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAchievementPlayerAchievementStored_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAchievementPlayerAchievementStored_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAchievementPlayerAchievementStored_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAppQuerySubscribeWishPlayStateResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAppQuerySubscribeWishPlayStateResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAppQuerySubscribeWishPlayStateResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsAssetsChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsAssetsChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsAssetsChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsCompleteConsumeFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsCompleteConsumeFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsCompleteConsumeFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsDirectConsumeFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsDirectConsumeFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsDirectConsumeFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsExchangeAssetsFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsExchangeAssetsFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsExchangeAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsExchangeAssetsToFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsExchangeAssetsToFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsExchangeAssetsToFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsMergeFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsMergeFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsMergeFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsMergeToFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsMergeToFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsMergeToFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsRequestAllAssetsFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsRequestAllAssetsFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsRequestAllAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsSplitFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsSplitFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsSplitFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsSplitToFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsSplitToFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsSplitToFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsStartConsumeFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsStartConsumeFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsStartConsumeFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsUpdateAssetPropertyFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsUpdateAssetPropertyFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsUpdateAssetPropertyFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsUpdateConsumeFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventAssetsUpdateConsumeFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventAssetsUpdateConsumeFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserCloseResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserCloseResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserCloseResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserCreateResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserCreateResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserCreateResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserDamageRectPaint_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserDamageRectPaint_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserDamageRectPaint_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserJavascriptEvent_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserJavascriptEvent_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserJavascriptEvent_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserNavigeteResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserNavigeteResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserNavigeteResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserPaint_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserPaint_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserPaint_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserReloadResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserReloadResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserReloadResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserStateChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserStateChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserStateChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserTitleChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserTitleChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserTitleChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserTryNavigateNewPageRequest_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventBrowserTryNavigateNewPageRequest_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventBrowserTryNavigateNewPageRequest_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcCheckAllDlcsStateReadyResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcCheckAllDlcsStateReadyResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcCheckAllDlcsStateReadyResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcInstallFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcInstallFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcInstallFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcInstallProgress_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcInstallProgress_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcInstallProgress_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcInstallStart_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcInstallStart_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcInstallStart_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcInstallStartResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcInstallStartResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcInstallStartResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcOwnershipChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcOwnershipChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcOwnershipChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcQueryIsOwnedDlcsResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcQueryIsOwnedDlcsResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcQueryIsOwnedDlcsResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcRefundChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcRefundChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcRefundChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcUninstallFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventDlcUninstallFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventDlcUninstallFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFinalize_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFinalize_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFinalize_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsAddFriendResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsAddFriendResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsAddFriendResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsClearMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsClearMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsClearMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsFriendsListChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsFriendsListChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsFriendsListChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsGetFriendPlayedGamesResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsGetFriendPlayedGamesResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsGetFriendPlayedGamesResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsGetInviteCommandLine_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsGetInviteCommandLine_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsGetInviteCommandLine_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsGetMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsGetMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsGetMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsMetadataChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsMetadataChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsMetadataChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsOnlineStateChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsOnlineStateChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsOnlineStateChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsQueryPlayedWithFriendsListResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsQueryPlayedWithFriendsListResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsQueryPlayedWithFriendsListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsReportPlayedWithUserListResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsReportPlayedWithUserListResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsReportPlayedWithUserListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsSetMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventFriendsSetMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventFriendsSetMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerAddFavoriteGameServer_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerAddFavoriteGameServer_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerAddFavoriteGameServer_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerAuthSessionTicket_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerAuthSessionTicket_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerAuthSessionTicket_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerCreated_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerCreated_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerCreated_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerFavoriteGameServers_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerFavoriteGameServers_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerFavoriteGameServers_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerGetMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerGetMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerGetMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerGetSessionTicket_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerGetSessionTicket_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerGetSessionTicket_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerListResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerListResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerPlayerListResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerPlayerListResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerPlayerListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerRegisterToServerListResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerRegisterToServerListResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerRegisterToServerListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerRemoveFavoriteGameServer_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerRemoveFavoriteGameServer_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerRemoveFavoriteGameServer_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerSetMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGameServerSetMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGameServerSetMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGroupChatOpenGroupChatResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGroupChatOpenGroupChatResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGroupChatOpenGroupChatResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventGroupChatQueryGroupsInfoResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventGroupChatQueryGroupsInfoResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventGroupChatQueryGroupsInfoResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventHttpSessionResponseResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventHttpSessionResponseResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventHttpSessionResponseResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventIMEHelperTextInputCompositionStateChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventIMEHelperTextInputCompositionStateChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventIMEHelperTextInputCompositionStateChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventIMEHelperTextInputSelectedResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventIMEHelperTextInputSelectedResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventIMEHelperTextInputSelectedResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameCoinPurchaseCoinsResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameCoinPurchaseCoinsResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGameCoinPurchaseCoinsResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameCoinRequestCoinInfoResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameCoinRequestCoinInfoResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGameCoinRequestCoinInfoResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchaseAllProductsInfoReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchaseAllProductsInfoReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGamePurchaseAllProductsInfoReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchaseFinishOrderResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchaseFinishOrderResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGamePurchaseFinishOrderResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchasePurchaseProductsResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchasePurchaseProductsResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGamePurchasePurchaseProductsResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameStorePurchasePaymentResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameStorePurchasePaymentResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGameStorePurchasePaymentResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameStorePurchasePayWindowClosed_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameStorePurchasePayWindowClosed_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGameStorePurchasePayWindowClosed_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameStorePurchasePayWindowDisplayed_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventInGameStorePurchasePayWindowDisplayed_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventInGameStorePurchasePayWindowDisplayed_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardAsyncCreated_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardAsyncCreated_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventLeaderboardAsyncCreated_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardAttachSpaceWork_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardAttachSpaceWork_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventLeaderboardAttachSpaceWork_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardEntryReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardEntryReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventLeaderboardEntryReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventLeaderboardReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardUploaded_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventLeaderboardUploaded_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventLeaderboardUploaded_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventNetworkCreateRawSessionFailed_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventNetworkCreateRawSessionFailed_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventNetworkCreateRawSessionFailed_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventNetworkCreateRawSessionRequest_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventNetworkCreateRawSessionRequest_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventNetworkCreateRawSessionRequest_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventNetworkCreateSessionFailed_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventNetworkCreateSessionFailed_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventNetworkCreateSessionFailed_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventNetworkCreateSessionRequest_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventNetworkCreateSessionRequest_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventNetworkCreateSessionRequest_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerGetAuthenticateURL_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerGetAuthenticateURL_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventPlayerGetAuthenticateURL_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerGetEncryptedGameTicketResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerGetEncryptedGameTicketResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventPlayerGetEncryptedGameTicketResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerGetGamePurchaseKey_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerGetGamePurchaseKey_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventPlayerGetGamePurchaseKey_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerGetPlayerMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventPlayerGetPlayerMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventPlayerGetPlayerMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventQueryPlayerBannedStatus_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventQueryPlayerBannedStatus_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventQueryPlayerBannedStatus_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomClearRoomMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomClearRoomMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomClearRoomMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomCreated_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomCreated_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomCreated_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetAllDataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetAllDataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomGetAllDataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetMemberMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetMemberMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomGetMemberMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetRoomListResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetRoomListResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomGetRoomListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetRoomMembersResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetRoomMembersResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomGetRoomMembersResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetRoomMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetRoomMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomGetRoomMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetRoomTagResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetRoomTagResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomGetRoomTagResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetUserRoomListResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomGetUserRoomListResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomGetUserRoomListResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomJoinRoomResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomJoinRoomResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomJoinRoomResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomKickOffMemberResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomKickOffMemberResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomKickOffMemberResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomLeaveRoomResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomLeaveRoomResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomLeaveRoomResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyMemberChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyMemberChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomNotifyMemberChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyMemberkicked_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyMemberkicked_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomNotifyMemberkicked_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyMetadataChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyMetadataChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomNotifyMetadataChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyRoomDataReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyRoomDataReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomNotifyRoomDataReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyRoomDestroyed_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyRoomDestroyed_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomNotifyRoomDestroyed_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyRoomGameServerChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyRoomGameServerChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomNotifyRoomGameServerChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyRoomOwnerChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomNotifyRoomOwnerChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomNotifyRoomOwnerChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomOpenRoomResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomOpenRoomResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomOpenRoomResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetMemberMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetMemberMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomSetMemberMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetNewRoomOwnerResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetNewRoomOwnerResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomSetNewRoomOwnerResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetRoomMaxMemberResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetRoomMaxMemberResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomSetRoomMaxMemberResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetRoomMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetRoomMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomSetRoomMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetRoomTagResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetRoomTagResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomSetRoomTagResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetRoomTypeResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventRoomSetRoomTypeResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventRoomSetRoomTypeResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventScreenshotPublishScreenshotFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventScreenshotPublishScreenshotFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventScreenshotPublishScreenshotFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventScreenshotTakeScreenshotFinished_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventScreenshotTakeScreenshotFinished_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventScreenshotTakeScreenshotFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventScreenshotTakeScreenshotRequest_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventScreenshotTakeScreenshotRequest_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventScreenshotTakeScreenshotRequest_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventSessionTicketAuthSessionTicket_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventSessionTicketAuthSessionTicket_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventSessionTicketAuthSessionTicket_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventSessionTicketGetSessionTicket_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventSessionTicketGetSessionTicket_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventSessionTicketGetSessionTicket_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventShowFloatingNotifyWindow_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventShowFloatingNotifyWindow_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventShowFloatingNotifyWindow_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventShowFloatingWindow_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventShowFloatingWindow_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventShowFloatingWindow_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventSmallObjectServiceDownloadResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventSmallObjectServiceDownloadResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventSmallObjectServiceDownloadResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventSmallObjectServiceQueryObjectStateResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventSmallObjectServiceQueryObjectStateResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventSmallObjectServiceQueryObjectStateResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStatsGlobalStatsReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStatsGlobalStatsReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStatsGlobalStatsReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStatsNumOfPlayerReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStatsNumOfPlayerReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStatsNumOfPlayerReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStatsPlayerStatsReceived_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStatsPlayerStatsReceived_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStatsPlayerStatsReceived_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStatsPlayerStatsStored_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStatsPlayerStatsStored_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStatsPlayerStatsStored_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncDeleteStreamFileResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncDeleteStreamFileResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageAsyncDeleteStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncListStreamFileResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncListStreamFileResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageAsyncListStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncReadFileResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncReadFileResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageAsyncReadFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncReadStreamFileResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncReadStreamFileResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageAsyncReadStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncRenameStreamFileResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncRenameStreamFileResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageAsyncRenameStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncWriteFileResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncWriteFileResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageAsyncWriteFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncWriteStreamFileResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageAsyncWriteStreamFileResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageAsyncWriteStreamFileResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageQueryQuotaResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageQueryQuotaResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageQueryQuotaResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageShareToSpaceWorkResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventStorageShareToSpaceWorkResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventStorageShareToSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventSystemStateChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventSystemStateChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventSystemStateChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventTextInputShowTextInputWindowResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventTextInputShowTextInputWindowResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventTextInputShowTextInputWindowResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersCancelInviteResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersCancelInviteResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersCancelInviteResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersGetInviteDetailResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersGetInviteDetailResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersGetInviteDetailResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersGetUserLimitsResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersGetUserLimitsResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersGetUserLimitsResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersGetUsersInfo_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersGetUsersInfo_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersGetUsersInfo_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersInviteJoinGameResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersInviteJoinGameResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersInviteJoinGameResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersInviteUsersResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersInviteUsersResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersInviteUsersResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersNotifyInviter_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersNotifyInviter_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersNotifyInviter_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceDownloadProgress_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceDownloadProgress_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceDownloadProgress_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceDownloadResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceDownloadResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceDownloadResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceGetMyFavoritesWorksResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceGetMyFavoritesWorksResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceGetMyFavoritesWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceGetMySubscribedWorksResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceGetMySubscribedWorksResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceGetMySubscribedWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceModifyFavoritesWorksResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceModifyFavoritesWorksResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceModifyFavoritesWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceQuerySpaceWorksResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceQuerySpaceWorksResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceQuerySpaceWorksResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceRateSpaceWorkResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceRateSpaceWorkResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceRateSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceRemoveSpaceWorkResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceRemoveSpaceWorkResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceRemoveSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceSearchSpaceWorkResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceSearchSpaceWorkResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceSearchSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceSubscribeResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceSubscribeResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceSubscribeResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceSyncResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceSyncResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceSyncResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceUpdateMetadataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceUpdateMetadataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceUpdateMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceVoteSpaceWorkResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUserSpaceVoteSpaceWorkResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUserSpaceVoteSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersRespondInvitation_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersRespondInvitation_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersRespondInvitation_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersShowChatWindowWithFriendResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersShowChatWindowWithFriendResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersShowChatWindowWithFriendResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersShowUserHomepageWindowResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUsersShowUserHomepageWindowResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUsersShowUserHomepageWindowResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUtilsGameSettingMetadataChanged_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUtilsGameSettingMetadataChanged_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUtilsGameSettingMetadataChanged_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventUtilsGetImageDataResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventUtilsGetImageDataResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventUtilsGetImageDataResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelAddUsersResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelAddUsersResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelAddUsersResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelCreateResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelCreateResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelCreateResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelDataCaptured_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelDataCaptured_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelDataCaptured_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelInviteEvent_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelInviteEvent_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelInviteEvent_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelJoinedResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelJoinedResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelJoinedResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelLeaveResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelLeaveResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelLeaveResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelMemberChangedEvent_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelMemberChangedEvent_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelMemberChangedEvent_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelRemoveUsersResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelRemoveUsersResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelRemoveUsersResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailPlatformNotifyEventJoinGameByGameServer_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailPlatformNotifyEventJoinGameByGameServer_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailPlatformNotifyEventJoinGameByGameServer_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailPlatformNotifyEventJoinGameByRoom_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailPlatformNotifyEventJoinGameByRoom_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailPlatformNotifyEventJoinGameByRoom_SWIGUpcast(IntPtr jarg1) { }

	public static int RailEventkRailPlatformNotifyEventJoinGameByUser_get_event_id(IntPtr jarg1) { }

	public static int RailEventkRailPlatformNotifyEventJoinGameByUser_kInternalRailEventEventId_get() { }

	public static IntPtr RailEventkRailPlatformNotifyEventJoinGameByUser_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFactory() { }

	public static void RailFinalize() { }

	public static IntPtr RailFinalize_SWIGUpcast(IntPtr jarg1) { }

	public static void RailFireEvents() { }

	public static IntPtr RailFriendInfo_friend_rail_id_get(IntPtr jarg1) { }

	public static void RailFriendInfo_friend_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailFriendInfo_friend_type_get(IntPtr jarg1) { }

	public static void RailFriendInfo_friend_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailFriendInfo_online_state_get(IntPtr jarg1) { }

	public static void RailFriendInfo_online_state_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendMetadata_friend_rail_id_get(IntPtr jarg1) { }

	public static void RailFriendMetadata_friend_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendMetadata_metadatas_get(IntPtr jarg1) { }

	public static void RailFriendMetadata_metadatas_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailFriendOnLineState_friend_online_state_get(IntPtr jarg1) { }

	public static void RailFriendOnLineState_friend_online_state_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailFriendOnLineState_friend_rail_id_get(IntPtr jarg1) { }

	public static void RailFriendOnLineState_friend_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailFriendOnLineState_game_define_game_playing_state_get(IntPtr jarg1) { }

	public static void RailFriendOnLineState_game_define_game_playing_state_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailFriendPlayedGameInfo_friend_id_get(IntPtr jarg1) { }

	public static void RailFriendPlayedGameInfo_friend_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailFriendPlayedGameInfo_friend_played_game_play_state_get(IntPtr jarg1) { }

	public static void RailFriendPlayedGameInfo_friend_played_game_play_state_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailFriendPlayedGameInfo_game_id_get(IntPtr jarg1) { }

	public static void RailFriendPlayedGameInfo_game_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendPlayedGameInfo_game_server_id_list_get(IntPtr jarg1) { }

	public static void RailFriendPlayedGameInfo_game_server_id_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool RailFriendPlayedGameInfo_in_game_server_get(IntPtr jarg1) { }

	public static void RailFriendPlayedGameInfo_in_game_server_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailFriendPlayedGameInfo_in_room_get(IntPtr jarg1) { }

	public static void RailFriendPlayedGameInfo_in_room_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailFriendPlayedGameInfo_room_id_list_get(IntPtr jarg1) { }

	public static void RailFriendPlayedGameInfo_room_id_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsAddFriendRequest_target_rail_id_get(IntPtr jarg1) { }

	public static void RailFriendsAddFriendRequest_target_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsAddFriendResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsAddFriendResult_target_rail_id_get(IntPtr jarg1) { }

	public static void RailFriendsAddFriendResult_target_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsClearMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsGetInviteCommandLine_friend_id_get(IntPtr jarg1) { }

	public static void RailFriendsGetInviteCommandLine_friend_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsGetInviteCommandLine_invite_command_line_get(IntPtr jarg1) { }

	public static void RailFriendsGetInviteCommandLine_invite_command_line_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailFriendsGetInviteCommandLine_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsGetMetadataResult_friend_id_get(IntPtr jarg1) { }

	public static void RailFriendsGetMetadataResult_friend_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsGetMetadataResult_friend_kvs_get(IntPtr jarg1) { }

	public static void RailFriendsGetMetadataResult_friend_kvs_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsGetMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsListChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsMetadataChanged_friends_changed_metadata_get(IntPtr jarg1) { }

	public static void RailFriendsMetadataChanged_friends_changed_metadata_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsMetadataChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsOnlineStateChanged_friend_online_state_get(IntPtr jarg1) { }

	public static void RailFriendsOnlineStateChanged_friend_online_state_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsOnlineStateChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsQueryFriendPlayedGamesResult_friend_played_games_info_list_get(IntPtr jarg1) { }

	public static void RailFriendsQueryFriendPlayedGamesResult_friend_played_games_info_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsQueryFriendPlayedGamesResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsQueryPlayedWithFriendsGamesResult_played_with_friends_game_list_get(IntPtr jarg1) { }

	public static void RailFriendsQueryPlayedWithFriendsGamesResult_played_with_friends_game_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsQueryPlayedWithFriendsGamesResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsQueryPlayedWithFriendsListResult_played_with_friends_list_get(IntPtr jarg1) { }

	public static void RailFriendsQueryPlayedWithFriendsListResult_played_with_friends_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsQueryPlayedWithFriendsListResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsQueryPlayedWithFriendsTimeResult_played_with_friends_time_list_get(IntPtr jarg1) { }

	public static void RailFriendsQueryPlayedWithFriendsTimeResult_played_with_friends_time_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailFriendsQueryPlayedWithFriendsTimeResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsReportPlayedWithUserListResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailFriendsSetMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint RailGameDefineGamePlayingState_game_define_game_playing_state_get(IntPtr jarg1) { }

	public static void RailGameDefineGamePlayingState_game_define_game_playing_state_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailGameDefineGamePlayingState_state_name_en_us_get(IntPtr jarg1) { }

	public static void RailGameDefineGamePlayingState_state_name_en_us_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailGameDefineGamePlayingState_state_name_zh_cn_get(IntPtr jarg1) { }

	public static void RailGameDefineGamePlayingState_state_name_zh_cn_set(IntPtr jarg1, string jarg2) { }

	public static ulong RailGameID_get_id(IntPtr jarg1) { }

	public static bool RailGameID_IsValid(IntPtr jarg1) { }

	public static void RailGameID_set_id(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr RailGamePeer_game_id_get(IntPtr jarg1) { }

	public static void RailGamePeer_game_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailGamePeer_peer_get(IntPtr jarg1) { }

	public static void RailGamePeer_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailGameSettingMetadataChanged_key_values_get(IntPtr jarg1) { }

	public static void RailGameSettingMetadataChanged_key_values_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailGameSettingMetadataChanged_source_get(IntPtr jarg1) { }

	public static void RailGameSettingMetadataChanged_source_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailGameSettingMetadataChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailGeneratedAssetItem_asset_get(IntPtr jarg1) { }

	public static void RailGeneratedAssetItem_asset_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong RailGeneratedAssetItem_container_id_get(IntPtr jarg1) { }

	public static void RailGeneratedAssetItem_container_id_set(IntPtr jarg1, ulong jarg2) { }

	public static uint RailGeneratedAssetItem_product_id_get(IntPtr jarg1) { }

	public static void RailGeneratedAssetItem_product_id_set(IntPtr jarg1, uint jarg2) { }

	public static ulong RailGetAuthenticateURLOptions_client_id_get(IntPtr jarg1) { }

	public static void RailGetAuthenticateURLOptions_client_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr RailGetAuthenticateURLOptions_oauth2_state_get(IntPtr jarg1) { }

	public static void RailGetAuthenticateURLOptions_oauth2_state_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailGetAuthenticateURLOptions_url_get(IntPtr jarg1) { }

	public static void RailGetAuthenticateURLOptions_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailGetEncryptedGameTicketResult_encrypted_game_ticket_get(IntPtr jarg1) { }

	public static void RailGetEncryptedGameTicketResult_encrypted_game_ticket_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailGetEncryptedGameTicketResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailGetImageDataResult_image_data_descriptor_get(IntPtr jarg1) { }

	public static void RailGetImageDataResult_image_data_descriptor_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailGetImageDataResult_image_data_get(IntPtr jarg1) { }

	public static void RailGetImageDataResult_image_data_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailGetImageDataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailGetPlayerMetadataResult_key_values_get(IntPtr jarg1) { }

	public static void RailGetPlayerMetadataResult_key_values_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailGetPlayerMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static void RailGetSdkVersion(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailGroupInfo_group_icon_url_get(IntPtr jarg1) { }

	public static void RailGroupInfo_group_icon_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailGroupInfo_group_id_get(IntPtr jarg1) { }

	public static void RailGroupInfo_group_id_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailGroupInfo_group_name_get(IntPtr jarg1) { }

	public static void RailGroupInfo_group_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailHttpSessionResponse_http_response_data_get(IntPtr jarg1) { }

	public static void RailHttpSessionResponse_http_response_data_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailHttpSessionResponse_SWIGUpcast(IntPtr jarg1) { }

	public static ulong RailID_get_id(IntPtr jarg1) { }

	public static int RailID_GetDomain(IntPtr jarg1) { }

	public static bool RailID_IsValid(IntPtr jarg1) { }

	public static void RailID_set_id(IntPtr jarg1, ulong jarg2) { }

	public static uint RailImageDataDescriptor_bits_per_pixel_get(IntPtr jarg1) { }

	public static void RailImageDataDescriptor_bits_per_pixel_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailImageDataDescriptor_image_height_get(IntPtr jarg1) { }

	public static void RailImageDataDescriptor_image_height_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailImageDataDescriptor_image_width_get(IntPtr jarg1) { }

	public static void RailImageDataDescriptor_image_width_set(IntPtr jarg1, uint jarg2) { }

	public static int RailImageDataDescriptor_pixel_format_get(IntPtr jarg1) { }

	public static void RailImageDataDescriptor_pixel_format_set(IntPtr jarg1, int jarg2) { }

	public static uint RailImageDataDescriptor_stride_in_bytes_get(IntPtr jarg1) { }

	public static void RailImageDataDescriptor_stride_in_bytes_set(IntPtr jarg1, uint jarg2) { }

	public static int RailIMEHelperTextInputCompositionState_composition_state_get(IntPtr jarg1) { }

	public static void RailIMEHelperTextInputCompositionState_composition_state_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailIMEHelperTextInputCompositionState_composition_text_get(IntPtr jarg1) { }

	public static void RailIMEHelperTextInputCompositionState_composition_text_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailIMEHelperTextInputCompositionState_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailIMEHelperTextInputSelectedResult_content_get(IntPtr jarg1) { }

	public static void RailIMEHelperTextInputSelectedResult_content_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailIMEHelperTextInputSelectedResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGameCoinPurchaseCoinsResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGameCoinRequestCoinInfoResponse_coin_infos_get(IntPtr jarg1) { }

	public static void RailInGameCoinRequestCoinInfoResponse_coin_infos_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailInGameCoinRequestCoinInfoResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGamePurchaseFinishOrderResponse_order_id_get(IntPtr jarg1) { }

	public static void RailInGamePurchaseFinishOrderResponse_order_id_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailInGamePurchaseFinishOrderResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGamePurchasePurchaseProductsResponse_delivered_products_get(IntPtr jarg1) { }

	public static void RailInGamePurchasePurchaseProductsResponse_delivered_products_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailInGamePurchasePurchaseProductsResponse_order_id_get(IntPtr jarg1) { }

	public static void RailInGamePurchasePurchaseProductsResponse_order_id_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailInGamePurchasePurchaseProductsResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGamePurchasePurchaseProductsToAssetsResponse_delivered_assets_get(IntPtr jarg1) { }

	public static void RailInGamePurchasePurchaseProductsToAssetsResponse_delivered_assets_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailInGamePurchasePurchaseProductsToAssetsResponse_order_id_get(IntPtr jarg1) { }

	public static void RailInGamePurchasePurchaseProductsToAssetsResponse_order_id_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailInGamePurchasePurchaseProductsToAssetsResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGamePurchaseRequestAllProductsResponse_all_products_get(IntPtr jarg1) { }

	public static void RailInGamePurchaseRequestAllProductsResponse_all_products_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailInGamePurchaseRequestAllProductsResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGamePurchaseRequestAllPurchasableProductsResponse_purchasable_products_get(IntPtr jarg1) { }

	public static void RailInGamePurchaseRequestAllPurchasableProductsResponse_purchasable_products_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailInGamePurchaseRequestAllPurchasableProductsResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGameStorePurchasePayWindowClosed_order_id_get(IntPtr jarg1) { }

	public static void RailInGameStorePurchasePayWindowClosed_order_id_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailInGameStorePurchasePayWindowClosed_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGameStorePurchasePayWindowDisplayed_order_id_get(IntPtr jarg1) { }

	public static void RailInGameStorePurchasePayWindowDisplayed_order_id_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailInGameStorePurchasePayWindowDisplayed_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailInGameStorePurchaseResult_order_id_get(IntPtr jarg1) { }

	public static void RailInGameStorePurchaseResult_order_id_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailInGameStorePurchaseResult_SWIGUpcast(IntPtr jarg1) { }

	public static bool RailInitialize() { }

	public static IntPtr RailInviteOptions_additional_message_get(IntPtr jarg1) { }

	public static void RailInviteOptions_additional_message_set(IntPtr jarg1, string jarg2) { }

	public static uint RailInviteOptions_expire_time_get(IntPtr jarg1) { }

	public static void RailInviteOptions_expire_time_set(IntPtr jarg1, uint jarg2) { }

	public static int RailInviteOptions_invite_type_get(IntPtr jarg1) { }

	public static void RailInviteOptions_invite_type_set(IntPtr jarg1, int jarg2) { }

	public static bool RailInviteOptions_need_respond_in_game_get(IntPtr jarg1) { }

	public static void RailInviteOptions_need_respond_in_game_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailKeyValue_key_get(IntPtr jarg1) { }

	public static void RailKeyValue_key_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailKeyValue_value_get(IntPtr jarg1) { }

	public static void RailKeyValue_value_set(IntPtr jarg1, string jarg2) { }

	public static int RailKeyValueResult_error_code_get(IntPtr jarg1) { }

	public static void RailKeyValueResult_error_code_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailKeyValueResult_key_get(IntPtr jarg1) { }

	public static void RailKeyValueResult_key_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailKeyValueResult_value_get(IntPtr jarg1) { }

	public static void RailKeyValueResult_value_set(IntPtr jarg1, string jarg2) { }

	public static uint RailListStreamFileOption_num_files_get(IntPtr jarg1) { }

	public static void RailListStreamFileOption_num_files_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailListStreamFileOption_start_index_get(IntPtr jarg1) { }

	public static void RailListStreamFileOption_start_index_set(IntPtr jarg1, uint jarg2) { }

	public static bool RailNeedRestartAppForCheckingEnvironment(IntPtr jarg1, int jarg2, in String[] jarg3) { }

	public static uint RailNetworkSessionState_bytes_in_send_buffer_get(IntPtr jarg1) { }

	public static void RailNetworkSessionState_bytes_in_send_buffer_set(IntPtr jarg1, uint jarg2) { }

	public static bool RailNetworkSessionState_is_connecting_get(IntPtr jarg1) { }

	public static void RailNetworkSessionState_is_connecting_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailNetworkSessionState_is_connection_active_get(IntPtr jarg1) { }

	public static void RailNetworkSessionState_is_connection_active_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailNetworkSessionState_is_using_relay_get(IntPtr jarg1) { }

	public static void RailNetworkSessionState_is_using_relay_set(IntPtr jarg1, bool jarg2) { }

	public static uint RailNetworkSessionState_packets_in_send_buffer_get(IntPtr jarg1) { }

	public static void RailNetworkSessionState_packets_in_send_buffer_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailNetworkSessionState_remote_ip_get(IntPtr jarg1) { }

	public static void RailNetworkSessionState_remote_ip_set(IntPtr jarg1, uint jarg2) { }

	public static ushort RailNetworkSessionState_remote_port_get(IntPtr jarg1) { }

	public static void RailNetworkSessionState_remote_port_set(IntPtr jarg1, ushort jarg2) { }

	public static int RailNetworkSessionState_session_error_get(IntPtr jarg1) { }

	public static void RailNetworkSessionState_session_error_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailOpenGroupChatResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailPlatformNotifyEventJoinGameByGameServer_commandline_info_get(IntPtr jarg1) { }

	public static void RailPlatformNotifyEventJoinGameByGameServer_commandline_info_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPlatformNotifyEventJoinGameByGameServer_gameserver_railid_get(IntPtr jarg1) { }

	public static void RailPlatformNotifyEventJoinGameByGameServer_gameserver_railid_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailPlatformNotifyEventJoinGameByGameServer_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailPlatformNotifyEventJoinGameByRoom_commandline_info_get(IntPtr jarg1) { }

	public static void RailPlatformNotifyEventJoinGameByRoom_commandline_info_set(IntPtr jarg1, string jarg2) { }

	public static ulong RailPlatformNotifyEventJoinGameByRoom_room_id_get(IntPtr jarg1) { }

	public static void RailPlatformNotifyEventJoinGameByRoom_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr RailPlatformNotifyEventJoinGameByRoom_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailPlatformNotifyEventJoinGameByUser_commandline_info_get(IntPtr jarg1) { }

	public static void RailPlatformNotifyEventJoinGameByUser_commandline_info_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPlatformNotifyEventJoinGameByUser_rail_id_to_join_get(IntPtr jarg1) { }

	public static void RailPlatformNotifyEventJoinGameByUser_rail_id_to_join_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailPlatformNotifyEventJoinGameByUser_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailPlayedWithFriendsGameItem_game_ids_get(IntPtr jarg1) { }

	public static void RailPlayedWithFriendsGameItem_game_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailPlayedWithFriendsGameItem_rail_id_get(IntPtr jarg1) { }

	public static void RailPlayedWithFriendsGameItem_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailPlayedWithFriendsTimeItem_play_time_get(IntPtr jarg1) { }

	public static void RailPlayedWithFriendsTimeItem_play_time_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailPlayedWithFriendsTimeItem_rail_id_get(IntPtr jarg1) { }

	public static void RailPlayedWithFriendsTimeItem_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailProductItem_product_id_get(IntPtr jarg1) { }

	public static void RailProductItem_product_id_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailProductItem_quantity_get(IntPtr jarg1) { }

	public static void RailProductItem_quantity_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailPublishFileToUserSpaceOption_description_get(IntPtr jarg1) { }

	public static void RailPublishFileToUserSpaceOption_description_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPublishFileToUserSpaceOption_key_value_get(IntPtr jarg1) { }

	public static void RailPublishFileToUserSpaceOption_key_value_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailPublishFileToUserSpaceOption_level_get(IntPtr jarg1) { }

	public static void RailPublishFileToUserSpaceOption_level_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailPublishFileToUserSpaceOption_preview_path_filename_get(IntPtr jarg1) { }

	public static void RailPublishFileToUserSpaceOption_preview_path_filename_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPublishFileToUserSpaceOption_space_work_name_get(IntPtr jarg1) { }

	public static void RailPublishFileToUserSpaceOption_space_work_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPublishFileToUserSpaceOption_tags_get(IntPtr jarg1) { }

	public static void RailPublishFileToUserSpaceOption_tags_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailPublishFileToUserSpaceOption_type_get(IntPtr jarg1) { }

	public static void RailPublishFileToUserSpaceOption_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailPublishFileToUserSpaceOption_version_get(IntPtr jarg1) { }

	public static void RailPublishFileToUserSpaceOption_version_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPurchaseProductExtraInfo_bundle_rule_get(IntPtr jarg1) { }

	public static void RailPurchaseProductExtraInfo_bundle_rule_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPurchaseProductExtraInfo_exchange_rule_get(IntPtr jarg1) { }

	public static void RailPurchaseProductExtraInfo_exchange_rule_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPurchaseProductInfo_category_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_category_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPurchaseProductInfo_currency_type_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_currency_type_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPurchaseProductInfo_description_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_description_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailPurchaseProductInfo_discount_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_discount_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailPurchaseProductInfo_extra_info_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_extra_info_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool RailPurchaseProductInfo_is_purchasable_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_is_purchasable_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailPurchaseProductInfo_name_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_name_set(IntPtr jarg1, string jarg2) { }

	public static float RailPurchaseProductInfo_original_price_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_original_price_set(IntPtr jarg1, float jarg2) { }

	public static uint RailPurchaseProductInfo_product_id_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_product_id_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailPurchaseProductInfo_product_thumbnail_get(IntPtr jarg1) { }

	public static void RailPurchaseProductInfo_product_thumbnail_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailQueryGroupsInfoResult_group_ids_get(IntPtr jarg1) { }

	public static void RailQueryGroupsInfoResult_group_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailQueryGroupsInfoResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint RailQueryWorkFileOptions_preview_scaling_rate_get(IntPtr jarg1) { }

	public static void RailQueryWorkFileOptions_preview_scaling_rate_set(IntPtr jarg1, uint jarg2) { }

	public static bool RailQueryWorkFileOptions_query_total_only_get(IntPtr jarg1) { }

	public static void RailQueryWorkFileOptions_query_total_only_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailQueryWorkFileOptions_with_description_get(IntPtr jarg1) { }

	public static void RailQueryWorkFileOptions_with_description_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailQueryWorkFileOptions_with_preview_url_get(IntPtr jarg1) { }

	public static void RailQueryWorkFileOptions_with_preview_url_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailQueryWorkFileOptions_with_uploader_ids_get(IntPtr jarg1) { }

	public static void RailQueryWorkFileOptions_with_uploader_ids_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailQueryWorkFileOptions_with_url_get(IntPtr jarg1) { }

	public static void RailQueryWorkFileOptions_with_url_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailQueryWorkFileOptions_with_vote_detail_get(IntPtr jarg1) { }

	public static void RailQueryWorkFileOptions_with_vote_detail_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailSessionTicket_ticket_get(IntPtr jarg1) { }

	public static void RailSessionTicket_ticket_set(IntPtr jarg1, string jarg2) { }

	public static bool RailShowChatWindowWithFriendResult_is_show_get(IntPtr jarg1) { }

	public static void RailShowChatWindowWithFriendResult_is_show_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailShowChatWindowWithFriendResult_SWIGUpcast(IntPtr jarg1) { }

	public static bool RailShowUserHomepageWindowResult_is_show_get(IntPtr jarg1) { }

	public static void RailShowUserHomepageWindowResult_is_show_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailShowUserHomepageWindowResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint RailSmallObjectDownloadInfo_index_get(IntPtr jarg1) { }

	public static void RailSmallObjectDownloadInfo_index_set(IntPtr jarg1, uint jarg2) { }

	public static int RailSmallObjectDownloadInfo_result_get(IntPtr jarg1) { }

	public static void RailSmallObjectDownloadInfo_result_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailSmallObjectDownloadResult_download_infos_get(IntPtr jarg1) { }

	public static void RailSmallObjectDownloadResult_download_infos_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSmallObjectDownloadResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint RailSmallObjectState_index_get(IntPtr jarg1) { }

	public static void RailSmallObjectState_index_set(IntPtr jarg1, uint jarg2) { }

	public static int RailSmallObjectState_update_state_get(IntPtr jarg1) { }

	public static void RailSmallObjectState_update_state_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailSmallObjectStateQueryResult_objects_state_get(IntPtr jarg1) { }

	public static void RailSmallObjectStateQueryResult_objects_state_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSmallObjectStateQueryResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint RailSpaceWorkDescriptor_create_time_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_create_time_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_description_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_description_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_detail_url_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_detail_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_id_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_name_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_preview_scaling_url_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_preview_scaling_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_preview_url_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_preview_url_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_recommendation_rate_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_recommendation_rate_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_uploader_ids_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_uploader_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkDescriptor_vote_details_get(IntPtr jarg1) { }

	public static void RailSpaceWorkDescriptor_vote_details_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkFilter_classes_get(IntPtr jarg1) { }

	public static void RailSpaceWorkFilter_classes_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkFilter_collector_list_get(IntPtr jarg1) { }

	public static void RailSpaceWorkFilter_collector_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkFilter_creator_list_get(IntPtr jarg1) { }

	public static void RailSpaceWorkFilter_creator_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkFilter_subscriber_list_get(IntPtr jarg1) { }

	public static void RailSpaceWorkFilter_subscriber_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkFilter_type_get(IntPtr jarg1) { }

	public static void RailSpaceWorkFilter_type_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkSearchFilter_excluded_metadata_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSearchFilter_excluded_metadata_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkSearchFilter_excluded_tags_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSearchFilter_excluded_tags_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool RailSpaceWorkSearchFilter_match_all_required_metadata_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSearchFilter_match_all_required_metadata_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailSpaceWorkSearchFilter_match_all_required_tags_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSearchFilter_match_all_required_tags_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailSpaceWorkSearchFilter_required_metadata_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSearchFilter_required_metadata_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkSearchFilter_required_tags_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSearchFilter_required_tags_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailSpaceWorkSearchFilter_search_text_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSearchFilter_search_text_set(IntPtr jarg1, string jarg2) { }

	public static int RailSpaceWorkSyncProgress_current_state_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSyncProgress_current_state_set(IntPtr jarg1, int jarg2) { }

	public static ulong RailSpaceWorkSyncProgress_finished_bytes_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSyncProgress_finished_bytes_set(IntPtr jarg1, ulong jarg2) { }

	public static float RailSpaceWorkSyncProgress_progress_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSyncProgress_progress_set(IntPtr jarg1, float jarg2) { }

	public static ulong RailSpaceWorkSyncProgress_total_bytes_get(IntPtr jarg1) { }

	public static void RailSpaceWorkSyncProgress_total_bytes_set(IntPtr jarg1, ulong jarg2) { }

	public static bool RailSpaceWorkUpdateOptions_check_has_favorited_get(IntPtr jarg1) { }

	public static void RailSpaceWorkUpdateOptions_check_has_favorited_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailSpaceWorkUpdateOptions_check_has_subscribed_get(IntPtr jarg1) { }

	public static void RailSpaceWorkUpdateOptions_check_has_subscribed_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailSpaceWorkUpdateOptions_with_detail_get(IntPtr jarg1) { }

	public static void RailSpaceWorkUpdateOptions_with_detail_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailSpaceWorkUpdateOptions_with_metadata_get(IntPtr jarg1) { }

	public static void RailSpaceWorkUpdateOptions_with_metadata_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailSpaceWorkUpdateOptions_with_my_vote_get(IntPtr jarg1) { }

	public static void RailSpaceWorkUpdateOptions_with_my_vote_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailSpaceWorkUpdateOptions_with_vote_detail_get(IntPtr jarg1) { }

	public static void RailSpaceWorkUpdateOptions_with_vote_detail_set(IntPtr jarg1, bool jarg2) { }

	public static int RailSpaceWorkVoteDetail_vote_value_get(IntPtr jarg1) { }

	public static void RailSpaceWorkVoteDetail_vote_value_set(IntPtr jarg1, int jarg2) { }

	public static uint RailSpaceWorkVoteDetail_voted_players_get(IntPtr jarg1) { }

	public static void RailSpaceWorkVoteDetail_voted_players_set(IntPtr jarg1, uint jarg2) { }

	public static int RailStoreOptions_store_type_get(IntPtr jarg1) { }

	public static void RailStoreOptions_store_type_set(IntPtr jarg1, int jarg2) { }

	public static int RailStoreOptions_window_margin_left_get(IntPtr jarg1) { }

	public static void RailStoreOptions_window_margin_left_set(IntPtr jarg1, int jarg2) { }

	public static int RailStoreOptions_window_margin_top_get(IntPtr jarg1) { }

	public static void RailStoreOptions_window_margin_top_set(IntPtr jarg1, int jarg2) { }

	public static ulong RailStreamFileInfo_file_size_get(IntPtr jarg1) { }

	public static void RailStreamFileInfo_file_size_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr RailStreamFileInfo_filename_get(IntPtr jarg1) { }

	public static void RailStreamFileInfo_filename_set(IntPtr jarg1, string jarg2) { }

	public static int RailStreamFileOption_open_type_get(IntPtr jarg1) { }

	public static void RailStreamFileOption_open_type_set(IntPtr jarg1, int jarg2) { }

	public static bool RailStreamFileOption_unavaliabe_when_new_file_writing_get(IntPtr jarg1) { }

	public static void RailStreamFileOption_unavaliabe_when_new_file_writing_set(IntPtr jarg1, bool jarg2) { }

	public static void RailString_assign(IntPtr jarg1, string jarg2, uint jarg3) { }

	public static IntPtr RailString_c_str(IntPtr jarg1) { }

	public static void RailString_clear(IntPtr jarg1) { }

	public static IntPtr RailString_data(IntPtr jarg1) { }

	public static IntPtr RailString_SetValue(IntPtr jarg1, string jarg2) { }

	public static uint RailString_size(IntPtr jarg1) { }

	public static IntPtr RailSwitchPlayerSelectedZoneResult_SWIGUpcast(IntPtr jarg1) { }

	public static bool RailSyncFileOption_sync_file_not_to_remote_get(IntPtr jarg1) { }

	public static void RailSyncFileOption_sync_file_not_to_remote_set(IntPtr jarg1, bool jarg2) { }

	public static int RailSystemStateChanged_state_get(IntPtr jarg1) { }

	public static void RailSystemStateChanged_state_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailSystemStateChanged_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailTextInputImeWindowOption_position_get(IntPtr jarg1) { }

	public static void RailTextInputImeWindowOption_position_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool RailTextInputImeWindowOption_show_rail_ime_window_get(IntPtr jarg1) { }

	public static void RailTextInputImeWindowOption_show_rail_ime_window_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailTextInputResult_content_get(IntPtr jarg1) { }

	public static void RailTextInputResult_content_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailTextInputResult_SWIGUpcast(IntPtr jarg1) { }

	public static bool RailTextInputWindowOption_auto_cancel_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_auto_cancel_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailTextInputWindowOption_caption_text_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_caption_text_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailTextInputWindowOption_content_placeholder_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_content_placeholder_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RailTextInputWindowOption_description_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_description_set(IntPtr jarg1, string jarg2) { }

	public static bool RailTextInputWindowOption_enable_multi_line_edit_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_enable_multi_line_edit_set(IntPtr jarg1, bool jarg2) { }

	public static bool RailTextInputWindowOption_is_min_window_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_is_min_window_set(IntPtr jarg1, bool jarg2) { }

	public static uint RailTextInputWindowOption_position_left_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_position_left_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailTextInputWindowOption_position_top_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_position_top_set(IntPtr jarg1, uint jarg2) { }

	public static bool RailTextInputWindowOption_show_password_input_get(IntPtr jarg1) { }

	public static void RailTextInputWindowOption_show_password_input_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RailUserPlayedWith_rail_id_get(IntPtr jarg1) { }

	public static void RailUserPlayedWith_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailUserPlayedWith_user_rich_content_get(IntPtr jarg1) { }

	public static void RailUserPlayedWith_user_rich_content_set(IntPtr jarg1, string jarg2) { }

	public static int RailUsersCancelInviteResult_invite_type_get(IntPtr jarg1) { }

	public static void RailUsersCancelInviteResult_invite_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailUsersCancelInviteResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailUsersGetInviteDetailResult_command_line_get(IntPtr jarg1) { }

	public static void RailUsersGetInviteDetailResult_command_line_set(IntPtr jarg1, string jarg2) { }

	public static int RailUsersGetInviteDetailResult_invite_type_get(IntPtr jarg1) { }

	public static void RailUsersGetInviteDetailResult_invite_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailUsersGetInviteDetailResult_inviter_id_get(IntPtr jarg1) { }

	public static void RailUsersGetInviteDetailResult_inviter_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailUsersGetInviteDetailResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailUsersGetUserLimitsResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailUsersGetUserLimitsResult_user_id_get(IntPtr jarg1) { }

	public static void RailUsersGetUserLimitsResult_user_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailUsersGetUserLimitsResult_user_limits_get(IntPtr jarg1) { }

	public static void RailUsersGetUserLimitsResult_user_limits_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailUsersInfoData_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailUsersInfoData_user_info_list_get(IntPtr jarg1) { }

	public static void RailUsersInfoData_user_info_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailUsersInviteJoinGameResult_invite_type_get(IntPtr jarg1) { }

	public static void RailUsersInviteJoinGameResult_invite_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailUsersInviteJoinGameResult_invitee_id_get(IntPtr jarg1) { }

	public static void RailUsersInviteJoinGameResult_invitee_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailUsersInviteJoinGameResult_response_value_get(IntPtr jarg1) { }

	public static void RailUsersInviteJoinGameResult_response_value_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailUsersInviteJoinGameResult_SWIGUpcast(IntPtr jarg1) { }

	public static int RailUsersInviteUsersResult_invite_type_get(IntPtr jarg1) { }

	public static void RailUsersInviteUsersResult_invite_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailUsersInviteUsersResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RailUsersNotifyInviter_invitee_id_get(IntPtr jarg1) { }

	public static void RailUsersNotifyInviter_invitee_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailUsersNotifyInviter_SWIGUpcast(IntPtr jarg1) { }

	public static ulong RailUserSpaceDownloadProgress_finidshed_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadProgress_finidshed_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr RailUserSpaceDownloadProgress_id_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadProgress_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RailUserSpaceDownloadProgress_progress_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadProgress_progress_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailUserSpaceDownloadProgress_speed_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadProgress_speed_set(IntPtr jarg1, uint jarg2) { }

	public static ulong RailUserSpaceDownloadProgress_total_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadProgress_total_set(IntPtr jarg1, ulong jarg2) { }

	public static uint RailUserSpaceDownloadResult_err_code_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadResult_err_code_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailUserSpaceDownloadResult_err_msg_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadResult_err_msg_set(IntPtr jarg1, string jarg2) { }

	public static ulong RailUserSpaceDownloadResult_finished_bytes_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadResult_finished_bytes_set(IntPtr jarg1, ulong jarg2) { }

	public static uint RailUserSpaceDownloadResult_finished_files_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadResult_finished_files_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailUserSpaceDownloadResult_id_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadResult_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong RailUserSpaceDownloadResult_total_bytes_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadResult_total_bytes_set(IntPtr jarg1, ulong jarg2) { }

	public static uint RailUserSpaceDownloadResult_total_files_get(IntPtr jarg1) { }

	public static void RailUserSpaceDownloadResult_total_files_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RailUsersRespondInvitation_inviter_id_get(IntPtr jarg1) { }

	public static void RailUsersRespondInvitation_inviter_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RailUsersRespondInvitation_original_invite_option_get(IntPtr jarg1) { }

	public static void RailUsersRespondInvitation_original_invite_option_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailUsersRespondInvitation_response_get(IntPtr jarg1) { }

	public static void RailUsersRespondInvitation_response_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailUsersRespondInvitation_SWIGUpcast(IntPtr jarg1) { }

	public static int RailVoiceCaptureOption_voice_data_format_get(IntPtr jarg1) { }

	public static void RailVoiceCaptureOption_voice_data_format_set(IntPtr jarg1, int jarg2) { }

	public static uint RailVoiceCaptureSpecification_bits_per_sample_get(IntPtr jarg1) { }

	public static void RailVoiceCaptureSpecification_bits_per_sample_set(IntPtr jarg1, uint jarg2) { }

	public static int RailVoiceCaptureSpecification_capture_format_get(IntPtr jarg1) { }

	public static void RailVoiceCaptureSpecification_capture_format_set(IntPtr jarg1, int jarg2) { }

	public static int RailVoiceCaptureSpecification_channels_get(IntPtr jarg1) { }

	public static void RailVoiceCaptureSpecification_channels_set(IntPtr jarg1, int jarg2) { }

	public static uint RailVoiceCaptureSpecification_samples_per_second_get(IntPtr jarg1) { }

	public static void RailVoiceCaptureSpecification_samples_per_second_set(IntPtr jarg1, uint jarg2) { }

	public static ulong RailVoiceChannelID_get_id(IntPtr jarg1) { }

	public static bool RailVoiceChannelID_IsValid(IntPtr jarg1) { }

	public static void RailVoiceChannelID_set_id(IntPtr jarg1, ulong jarg2) { }

	public static int RailVoiceChannelUserSpeakingState_speaking_limit_get(IntPtr jarg1) { }

	public static void RailVoiceChannelUserSpeakingState_speaking_limit_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RailVoiceChannelUserSpeakingState_user_id_get(IntPtr jarg1) { }

	public static void RailVoiceChannelUserSpeakingState_user_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int RailWindowLayout_position_type_get(IntPtr jarg1) { }

	public static void RailWindowLayout_position_type_set(IntPtr jarg1, int jarg2) { }

	public static uint RailWindowLayout_x_margin_get(IntPtr jarg1) { }

	public static void RailWindowLayout_x_margin_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailWindowLayout_y_margin_get(IntPtr jarg1) { }

	public static void RailWindowLayout_y_margin_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailWindowPosition_position_left_get(IntPtr jarg1) { }

	public static void RailWindowPosition_position_left_set(IntPtr jarg1, uint jarg2) { }

	public static uint RailWindowPosition_position_top_get(IntPtr jarg1) { }

	public static void RailWindowPosition_position_top_set(IntPtr jarg1, uint jarg2) { }

	public static ulong RailZoneID_get_id(IntPtr jarg1) { }

	public static bool RailZoneID_IsValid(IntPtr jarg1) { }

	public static void RailZoneID_set_id(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr ReloadBrowserResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr RequestAllAssetsFinished_assetinfo_list_get(IntPtr jarg1) { }

	public static void RequestAllAssetsFinished_assetinfo_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RequestAllAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static int RequestLeaderboardEntryParam_range_end_get(IntPtr jarg1) { }

	public static void RequestLeaderboardEntryParam_range_end_set(IntPtr jarg1, int jarg2) { }

	public static int RequestLeaderboardEntryParam_range_start_get(IntPtr jarg1) { }

	public static void RequestLeaderboardEntryParam_range_start_set(IntPtr jarg1, int jarg2) { }

	public static int RequestLeaderboardEntryParam_type_get(IntPtr jarg1) { }

	public static void RequestLeaderboardEntryParam_type_set(IntPtr jarg1, int jarg2) { }

	public static bool RequestLeaderboardEntryParam_user_coordinate_get(IntPtr jarg1) { }

	public static void RequestLeaderboardEntryParam_user_coordinate_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr RoomDataReceived_data_buf_get(IntPtr jarg1) { }

	public static void RoomDataReceived_data_buf_set(IntPtr jarg1, string jarg2) { }

	public static uint RoomDataReceived_data_len_get(IntPtr jarg1) { }

	public static void RoomDataReceived_data_len_set(IntPtr jarg1, uint jarg2) { }

	public static uint RoomDataReceived_message_type_get(IntPtr jarg1) { }

	public static void RoomDataReceived_message_type_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RoomDataReceived_remote_peer_get(IntPtr jarg1) { }

	public static void RoomDataReceived_remote_peer_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RoomDataReceived_SWIGUpcast(IntPtr jarg1) { }

	public static uint RoomInfo_create_time_get(IntPtr jarg1) { }

	public static void RoomInfo_create_time_set(IntPtr jarg1, uint jarg2) { }

	public static uint RoomInfo_current_members_get(IntPtr jarg1) { }

	public static void RoomInfo_current_members_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RoomInfo_game_server_rail_id_get(IntPtr jarg1) { }

	public static void RoomInfo_game_server_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool RoomInfo_has_password_get(IntPtr jarg1) { }

	public static void RoomInfo_has_password_set(IntPtr jarg1, bool jarg2) { }

	public static bool RoomInfo_is_joinable_get(IntPtr jarg1) { }

	public static void RoomInfo_is_joinable_set(IntPtr jarg1, bool jarg2) { }

	public static uint RoomInfo_max_members_get(IntPtr jarg1) { }

	public static void RoomInfo_max_members_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RoomInfo_owner_id_get(IntPtr jarg1) { }

	public static void RoomInfo_owner_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong RoomInfo_room_id_get(IntPtr jarg1) { }

	public static void RoomInfo_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr RoomInfo_room_kvs_get(IntPtr jarg1) { }

	public static void RoomInfo_room_kvs_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RoomInfo_room_name_get(IntPtr jarg1) { }

	public static void RoomInfo_room_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RoomInfo_room_tag_get(IntPtr jarg1) { }

	public static void RoomInfo_room_tag_set(IntPtr jarg1, string jarg2) { }

	public static int RoomInfo_type_get(IntPtr jarg1) { }

	public static void RoomInfo_type_set(IntPtr jarg1, int jarg2) { }

	public static uint RoomInfoListFilter_available_slot_at_least_get(IntPtr jarg1) { }

	public static void RoomInfoListFilter_available_slot_at_least_set(IntPtr jarg1, uint jarg2) { }

	public static int RoomInfoListFilter_filter_friends_in_room_get(IntPtr jarg1) { }

	public static void RoomInfoListFilter_filter_friends_in_room_set(IntPtr jarg1, int jarg2) { }

	public static int RoomInfoListFilter_filter_friends_owned_get(IntPtr jarg1) { }

	public static void RoomInfoListFilter_filter_friends_owned_set(IntPtr jarg1, int jarg2) { }

	public static int RoomInfoListFilter_filter_password_get(IntPtr jarg1) { }

	public static void RoomInfoListFilter_filter_password_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RoomInfoListFilter_key_filters_get(IntPtr jarg1) { }

	public static void RoomInfoListFilter_key_filters_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RoomInfoListFilter_room_name_contained_get(IntPtr jarg1) { }

	public static void RoomInfoListFilter_room_name_contained_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RoomInfoListFilter_room_tag_get(IntPtr jarg1) { }

	public static void RoomInfoListFilter_room_tag_set(IntPtr jarg1, string jarg2) { }

	public static int RoomInfoListFilterKey_comparison_type_get(IntPtr jarg1) { }

	public static void RoomInfoListFilterKey_comparison_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RoomInfoListFilterKey_filter_value_get(IntPtr jarg1) { }

	public static void RoomInfoListFilterKey_filter_value_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RoomInfoListFilterKey_key_name_get(IntPtr jarg1) { }

	public static void RoomInfoListFilterKey_key_name_set(IntPtr jarg1, string jarg2) { }

	public static int RoomInfoListFilterKey_value_type_get(IntPtr jarg1) { }

	public static void RoomInfoListFilterKey_value_type_set(IntPtr jarg1, int jarg2) { }

	public static double RoomInfoListSorter_close_to_value_get(IntPtr jarg1) { }

	public static void RoomInfoListSorter_close_to_value_set(IntPtr jarg1, double jarg2) { }

	public static IntPtr RoomInfoListSorter_property_key_get(IntPtr jarg1) { }

	public static void RoomInfoListSorter_property_key_set(IntPtr jarg1, string jarg2) { }

	public static int RoomInfoListSorter_property_sort_type_get(IntPtr jarg1) { }

	public static void RoomInfoListSorter_property_sort_type_set(IntPtr jarg1, int jarg2) { }

	public static int RoomInfoListSorter_property_value_type_get(IntPtr jarg1) { }

	public static void RoomInfoListSorter_property_value_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr RoomMemberInfo_member_id_get(IntPtr jarg1) { }

	public static void RoomMemberInfo_member_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint RoomMemberInfo_member_index_get(IntPtr jarg1) { }

	public static void RoomMemberInfo_member_index_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RoomMemberInfo_member_kvs_get(IntPtr jarg1) { }

	public static void RoomMemberInfo_member_kvs_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr RoomMemberInfo_member_name_get(IntPtr jarg1) { }

	public static void RoomMemberInfo_member_name_set(IntPtr jarg1, string jarg2) { }

	public static ulong RoomMemberInfo_room_id_get(IntPtr jarg1) { }

	public static void RoomMemberInfo_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static bool RoomOptions_enable_team_voice_get(IntPtr jarg1) { }

	public static void RoomOptions_enable_team_voice_set(IntPtr jarg1, bool jarg2) { }

	public static uint RoomOptions_max_members_get(IntPtr jarg1) { }

	public static void RoomOptions_max_members_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr RoomOptions_password_get(IntPtr jarg1) { }

	public static void RoomOptions_password_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr RoomOptions_room_tag_get(IntPtr jarg1) { }

	public static void RoomOptions_room_tag_set(IntPtr jarg1, string jarg2) { }

	public static int RoomOptions_type_get(IntPtr jarg1) { }

	public static void RoomOptions_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr ScreenshotRequestInfo_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr SetGameServerMetadataResult_game_server_id_get(IntPtr jarg1) { }

	public static void SetGameServerMetadataResult_game_server_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr SetGameServerMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static void SetInt(IntPtr jarg1, int jarg2) { }

	public static void SetInt64(IntPtr jarg1, long jarg2) { }

	public static IntPtr SetMemberMetadataResult_member_id_get(IntPtr jarg1) { }

	public static void SetMemberMetadataResult_member_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static ulong SetMemberMetadataResult_room_id_get(IntPtr jarg1) { }

	public static void SetMemberMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr SetMemberMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr SetNewRoomOwnerResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr SetRoomMaxMemberResult_SWIGUpcast(IntPtr jarg1) { }

	public static ulong SetRoomMetadataResult_room_id_get(IntPtr jarg1) { }

	public static void SetRoomMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr SetRoomMetadataResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr SetRoomTagResult_SWIGUpcast(IntPtr jarg1) { }

	public static int SetRoomTypeResult_room_type_get(IntPtr jarg1) { }

	public static void SetRoomTypeResult_room_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr SetRoomTypeResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr ShareStorageToSpaceWorkResult_space_work_id_get(IntPtr jarg1) { }

	public static void ShareStorageToSpaceWorkResult_space_work_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr ShareStorageToSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static bool ShowFloatingWindowResult_is_show_get(IntPtr jarg1) { }

	public static void ShowFloatingWindowResult_is_show_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr ShowFloatingWindowResult_SWIGUpcast(IntPtr jarg1) { }

	public static int ShowFloatingWindowResult_window_type_get(IntPtr jarg1) { }

	public static void ShowFloatingWindowResult_window_type_set(IntPtr jarg1, int jarg2) { }

	public static IntPtr ShowNotifyWindow_json_content_get(IntPtr jarg1) { }

	public static void ShowNotifyWindow_json_content_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr ShowNotifyWindow_SWIGUpcast(IntPtr jarg1) { }

	public static int ShowNotifyWindow_window_type_get(IntPtr jarg1) { }

	public static void ShowNotifyWindow_window_type_set(IntPtr jarg1, int jarg2) { }

	public static ulong SpaceWorkID_get_id(IntPtr jarg1) { }

	public static bool SpaceWorkID_IsValid(IntPtr jarg1) { }

	public static void SpaceWorkID_set_id(IntPtr jarg1, ulong jarg2) { }

	public static ulong SplitAssetsFinished_new_asset_id_get(IntPtr jarg1) { }

	public static void SplitAssetsFinished_new_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static ulong SplitAssetsFinished_source_asset_get(IntPtr jarg1) { }

	public static void SplitAssetsFinished_source_asset_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr SplitAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static uint SplitAssetsFinished_to_quantity_get(IntPtr jarg1) { }

	public static void SplitAssetsFinished_to_quantity_set(IntPtr jarg1, uint jarg2) { }

	public static ulong SplitAssetsToFinished_source_asset_get(IntPtr jarg1) { }

	public static void SplitAssetsToFinished_source_asset_set(IntPtr jarg1, ulong jarg2) { }

	public static ulong SplitAssetsToFinished_split_to_asset_id_get(IntPtr jarg1) { }

	public static void SplitAssetsToFinished_split_to_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr SplitAssetsToFinished_SWIGUpcast(IntPtr jarg1) { }

	public static uint SplitAssetsToFinished_to_quantity_get(IntPtr jarg1) { }

	public static void SplitAssetsToFinished_to_quantity_set(IntPtr jarg1, uint jarg2) { }

	public static ulong StartConsumeAssetsFinished_asset_id_get(IntPtr jarg1) { }

	public static void StartConsumeAssetsFinished_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr StartConsumeAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr StartSessionWithPlayerResponse_remote_rail_id_get(IntPtr jarg1) { }

	public static void StartSessionWithPlayerResponse_remote_rail_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr StartSessionWithPlayerResponse_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr SyncSpaceWorkResult_id_get(IntPtr jarg1) { }

	public static void SyncSpaceWorkResult_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr SyncSpaceWorkResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr TakeScreenshotResult_image_file_path_get(IntPtr jarg1) { }

	public static void TakeScreenshotResult_image_file_path_set(IntPtr jarg1, string jarg2) { }

	public static uint TakeScreenshotResult_image_file_size_get(IntPtr jarg1) { }

	public static void TakeScreenshotResult_image_file_size_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr TakeScreenshotResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint TakeScreenshotResult_thumbnail_file_size_get(IntPtr jarg1) { }

	public static void TakeScreenshotResult_thumbnail_file_size_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr TakeScreenshotResult_thumbnail_filepath_get(IntPtr jarg1) { }

	public static void TakeScreenshotResult_thumbnail_filepath_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr UpdateAssetsPropertyFinished_asset_property_list_get(IntPtr jarg1) { }

	public static void UpdateAssetsPropertyFinished_asset_property_list_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr UpdateAssetsPropertyFinished_SWIGUpcast(IntPtr jarg1) { }

	public static ulong UpdateConsumeAssetsFinished_asset_id_get(IntPtr jarg1) { }

	public static void UpdateConsumeAssetsFinished_asset_id_set(IntPtr jarg1, ulong jarg2) { }

	public static IntPtr UpdateConsumeAssetsFinished_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr UploadLeaderboardParam_data_get(IntPtr jarg1) { }

	public static void UploadLeaderboardParam_data_set(IntPtr jarg1, IntPtr jarg2) { }

	public static int UploadLeaderboardParam_type_get(IntPtr jarg1) { }

	public static void UploadLeaderboardParam_type_set(IntPtr jarg1, int jarg2) { }

	public static int USE_MANUAL_ALLOC_get() { }

	public static IntPtr UserSpaceDownloadProgress_progress_get(IntPtr jarg1) { }

	public static void UserSpaceDownloadProgress_progress_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr UserSpaceDownloadProgress_SWIGUpcast(IntPtr jarg1) { }

	public static uint UserSpaceDownloadProgress_total_progress_get(IntPtr jarg1) { }

	public static void UserSpaceDownloadProgress_total_progress_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr UserSpaceDownloadResult_results_get(IntPtr jarg1) { }

	public static void UserSpaceDownloadResult_results_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr UserSpaceDownloadResult_SWIGUpcast(IntPtr jarg1) { }

	public static uint UserSpaceDownloadResult_total_results_get(IntPtr jarg1) { }

	public static void UserSpaceDownloadResult_total_results_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr VoiceChannelAddUsersResult_failed_ids_get(IntPtr jarg1) { }

	public static void VoiceChannelAddUsersResult_failed_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelAddUsersResult_success_ids_get(IntPtr jarg1) { }

	public static void VoiceChannelAddUsersResult_success_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelAddUsersResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr VoiceChannelAddUsersResult_voice_channel_id_get(IntPtr jarg1) { }

	public static void VoiceChannelAddUsersResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelInviteEvent_channel_name_get(IntPtr jarg1) { }

	public static void VoiceChannelInviteEvent_channel_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr VoiceChannelInviteEvent_inviter_name_get(IntPtr jarg1) { }

	public static void VoiceChannelInviteEvent_inviter_name_set(IntPtr jarg1, string jarg2) { }

	public static IntPtr VoiceChannelInviteEvent_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr VoiceChannelInviteEvent_voice_channel_id_get(IntPtr jarg1) { }

	public static void VoiceChannelInviteEvent_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelMemeberChangedEvent_member_ids_get(IntPtr jarg1) { }

	public static void VoiceChannelMemeberChangedEvent_member_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelMemeberChangedEvent_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr VoiceChannelMemeberChangedEvent_voice_channel_id_get(IntPtr jarg1) { }

	public static void VoiceChannelMemeberChangedEvent_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static uint VoiceChannelPushToTalkKeyChangedEvent_push_to_talk_hot_key_get(IntPtr jarg1) { }

	public static void VoiceChannelPushToTalkKeyChangedEvent_push_to_talk_hot_key_set(IntPtr jarg1, uint jarg2) { }

	public static IntPtr VoiceChannelPushToTalkKeyChangedEvent_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr VoiceChannelRemoveUsersResult_failed_ids_get(IntPtr jarg1) { }

	public static void VoiceChannelRemoveUsersResult_failed_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelRemoveUsersResult_success_ids_get(IntPtr jarg1) { }

	public static void VoiceChannelRemoveUsersResult_success_ids_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelRemoveUsersResult_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr VoiceChannelRemoveUsersResult_voice_channel_id_get(IntPtr jarg1) { }

	public static void VoiceChannelRemoveUsersResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelSpeakingUsersChangedEvent_not_speaking_users_get(IntPtr jarg1) { }

	public static void VoiceChannelSpeakingUsersChangedEvent_not_speaking_users_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelSpeakingUsersChangedEvent_speaking_users_get(IntPtr jarg1) { }

	public static void VoiceChannelSpeakingUsersChangedEvent_speaking_users_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelSpeakingUsersChangedEvent_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr VoiceChannelSpeakingUsersChangedEvent_voice_channel_id_get(IntPtr jarg1) { }

	public static void VoiceChannelSpeakingUsersChangedEvent_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelUsersSpeakingStateChangedEvent_SWIGUpcast(IntPtr jarg1) { }

	public static IntPtr VoiceChannelUsersSpeakingStateChangedEvent_users_speaking_state_get(IntPtr jarg1) { }

	public static void VoiceChannelUsersSpeakingStateChangedEvent_users_speaking_state_set(IntPtr jarg1, IntPtr jarg2) { }

	public static IntPtr VoiceChannelUsersSpeakingStateChangedEvent_voice_channel_id_get(IntPtr jarg1) { }

	public static void VoiceChannelUsersSpeakingStateChangedEvent_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2) { }

	public static bool VoiceDataCapturedEvent_is_last_package_get(IntPtr jarg1) { }

	public static void VoiceDataCapturedEvent_is_last_package_set(IntPtr jarg1, bool jarg2) { }

	public static IntPtr VoiceDataCapturedEvent_SWIGUpcast(IntPtr jarg1) { }

}

