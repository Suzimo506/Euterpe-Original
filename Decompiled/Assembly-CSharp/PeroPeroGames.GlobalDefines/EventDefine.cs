using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000526")]
public struct EventDefine
{
	[Token(Token = "0x4001D20")]
	public const uint none = 0u;

	[Token(Token = "0x4001D21")]
	public const uint on_reward = 100u;

	[Token(Token = "0x4001D22")]
	public const uint on_remote_purchased_refresh = 101u;

	[Token(Token = "0x4001D23")]
	public const uint switch_to_dlc = 102u;

	[Token(Token = "0x4001D24")]
	public const uint switch_to_dlc_by_pnl_role = 103u;

	[Token(Token = "0x4001D25")]
	public const uint switch_to_dlc_by_pnl_elfin = 104u;

	[Token(Token = "0x4001D26")]
	public const uint on_exp_added = 105u;

	[Token(Token = "0x4001D27")]
	public const uint on_exp_ui_set = 1051u;

	[Token(Token = "0x4001D28")]
	public const uint on_level_up = 106u;

	[Token(Token = "0x4001D29")]
	public const uint on_task_refresh = 107u;

	[Token(Token = "0x4001D2A")]
	public const uint on_delete_task = 108u;

	[Token(Token = "0x4001D2B")]
	public const uint invoke_main_show_express = 109u;

	[Token(Token = "0x4001D2C")]
	public const uint change_expression = 1091u;

	[Token(Token = "0x4001D2D")]
	public const uint on_role_applied = 1100u;

	[Token(Token = "0x4001D2E")]
	public const uint on_language_changed = 110u;

	[Token(Token = "0x4001D2F")]
	public const uint ui_set_all_input = 111u;

	[Token(Token = "0x4001D30")]
	public const uint on_logout = 112u;

	[Token(Token = "0x4001D31")]
	public const uint on_login_succeed = 113u;

	[Token(Token = "0x4001D32")]
	public const uint on_click_preview = 114u;

	[Token(Token = "0x4001D33")]
	public const uint on_click_pnl_music_tag_ok_btn = 115u;

	[Token(Token = "0x4001D34")]
	public const uint add_or_remove_hide_like = 116u;

	[Token(Token = "0x4001D35")]
	public const uint pnl_dlc_out = 117u;

	[Token(Token = "0x4001D36")]
	public const uint on_dlc_music_selected = 118u;

	[Token(Token = "0x4001D37")]
	public const uint on_login_again_request = 119u;

	[Token(Token = "0x4001D38")]
	public const uint finish_message = 120u;

	[Token(Token = "0x4001D39")]
	public const uint show_pnl_bulletin = 121u;

	[Token(Token = "0x4001D3A")]
	public const uint difficulty_changed = 122u;

	[Token(Token = "0x4001D3B")]
	public const uint on_item_selected = 123u;

	[Token(Token = "0x4001D3C")]
	public const uint on_item_double_clicked = 124u;

	[Token(Token = "0x4001D3D")]
	public const uint editor_destroy = 125u;

	[Token(Token = "0x4001D3E")]
	public const uint on_unlock_stage = 126u;

	[Token(Token = "0x4001D3F")]
	public const uint refresh_use_img = 127u;

	[Token(Token = "0x4001D40")]
	public const uint on_special_song_unlock = 128u;

	[Token(Token = "0x4001D41")]
	public const uint on_pnl_tutorial_tips = 129u;

	[Token(Token = "0x4001D42")]
	public const uint enable_continue_btn = 130u;

	[Token(Token = "0x4001D43")]
	public const uint disable_continue_btn = 131u;

	[Token(Token = "0x4001D44")]
	public const uint stage_unlock_or_not = 132u;

	[Token(Token = "0x4001D45")]
	public const uint on_specials_music = 133u;

	[Token(Token = "0x4001D46")]
	public const uint set_camera_fog = 134u;

	[Token(Token = "0x4001D47")]
	public const uint on_socket = 135u;

	[Token(Token = "0x4001D48")]
	public const uint on_pnl_dlc_product_info_refresh = 136u;

	[Token(Token = "0x4001D49")]
	public const uint switch_to_shop = 137u;

	[Token(Token = "0x4001D4A")]
	public const uint on_user_create = 138u;

	[Token(Token = "0x4001D4B")]
	public const uint on_user_cancel = 139u;

	[Token(Token = "0x4001D4C")]
	public const uint on_login_finished = 140u;

	[Token(Token = "0x4001D4D")]
	public const uint enter_main_scene = 141u;

	[Token(Token = "0x4001D4E")]
	public const uint egg_before_enter = 142u;

	[Token(Token = "0x4001D4F")]
	public const uint on_handle_purchase_after_update_product_info = 143u;

	[Token(Token = "0x4001D50")]
	public const uint on_items_change = 145u;

	[Token(Token = "0x4001D51")]
	public const uint show_pnl_stage_bulletin = 146u;

	[Token(Token = "0x4001D52")]
	public const uint pnl_dlc_play_song = 147u;

	[Token(Token = "0x4001D53")]
	public const uint show_Navigation_or_not = 148u;

	[Token(Token = "0x4001D54")]
	public const uint pnl_dlc_set_enable_scr = 149u;

	[Token(Token = "0x4001D55")]
	public const uint on_leave_ui_system = 150u;

	[Token(Token = "0x4001D56")]
	public const uint purchase_state_failed = 151u;

	[Token(Token = "0x4001D57")]
	public const uint refresh_tag_weekfree = 152u;

	[Token(Token = "0x4001D58")]
	public const uint fps_display = 153u;

	[Token(Token = "0x4001D59")]
	public const uint on_got_user_info_after_login = 154u;

	[Token(Token = "0x4001D5A")]
	public const uint on_player_agree_privacy_police = 155u;

	[Token(Token = "0x4001D5B")]
	public const uint on_main_managaer_inited = 156u;

	[Token(Token = "0x4001D5C")]
	public const uint enter_uisystem = 157u;

	[Token(Token = "0x4001D5D")]
	public const uint on_vip_active = 158u;

	[Token(Token = "0x4001D5E")]
	public const uint iap_product_refresh = 159u;

	[Token(Token = "0x4001D5F")]
	public const uint refresh_after_hotfix = 201u;

	[Token(Token = "0x4001D60")]
	public const uint hotfix_download_completed = 202u;

	[Token(Token = "0x4001D61")]
	public const uint download_status_change = 203u;

	[Token(Token = "0x4001D62")]
	public const uint on_judged = 3001u;

	[Token(Token = "0x4001D63")]
	public const uint on_game_start = 3002u;

	[Token(Token = "0x4001D64")]
	public const uint on_pnl_dlc_click_purchased_successful = 3102u;

	[Token(Token = "0x4001D65")]
	public const uint on_pnl_dlc_refresh_album_list = 3103u;

	[Token(Token = "0x4001D66")]
	public const uint on_pnl_dlc_album_time_out = 3104u;

	[Token(Token = "0x4001D67")]
	public const uint on_pnl_dlc_dicount_change = 3105u;

	[Token(Token = "0x4001D68")]
	public const uint on_pnl_dlc_arknight_ani_end = 3106u;

	[Token(Token = "0x4001D69")]
	public const uint on_pnl_dlc_select_change = 3107u;

	[Token(Token = "0x4001D6A")]
	public const uint on_pnl_stage_select_change = 3018u;

	[Token(Token = "0x4001D6B")]
	public const uint on_pnl_dlc_refresh_select_cell = 3019u;

	[Token(Token = "0x4001D6C")]
	public const uint on_fever_rate_changed = 4001u;

	[Token(Token = "0x4001D6D")]
	public const uint on_score_changed = 4002u;

	[Token(Token = "0x4001D6E")]
	public const uint on_combo_changed = 4003u;

	[Token(Token = "0x4001D6F")]
	public const uint on_multi_hit_changed = 4004u;

	[Token(Token = "0x4001D70")]
	public const uint on_hp_rate_changed = 4005u;

	[Token(Token = "0x4001D71")]
	public const uint on_fever = 4006u;

	[Token(Token = "0x4001D72")]
	public const uint on_fever_add = 4007u;

	[Token(Token = "0x4001D73")]
	public const uint on_fever_end = 4008u;

	[Token(Token = "0x4001D74")]
	public const uint on_fever_max = 4009u;

	[Token(Token = "0x4001D75")]
	public const uint on_fever_reduce = 4023u;

	[Token(Token = "0x4001D76")]
	public const uint on_wisadel_skill_on = 4033u;

	[Token(Token = "0x4001D77")]
	public const uint on_wisadel_skill_off = 4034u;

	[Token(Token = "0x4001D78")]
	public const uint on_boss_in = 4010u;

	[Token(Token = "0x4001D79")]
	public const uint on_boss_out = 4011u;

	[Token(Token = "0x4001D7A")]
	public const uint on_girl_in = 4012u;

	[Token(Token = "0x4001D7B")]
	public const uint on_hp_add = 4013u;

	[Token(Token = "0x4001D7C")]
	public const uint on_hp_deduct = 4014u;

	[Token(Token = "0x4001D7D")]
	public const uint on_mul_hit_note_enter = 4019u;

	[Token(Token = "0x4001D7E")]
	public const uint on_mul_hit_note_exit = 4020u;

	[Token(Token = "0x4001D7F")]
	public const uint on_multi_hit_tip = 4021u;

	[Token(Token = "0x4001D80")]
	public const uint on_character_hurt = 4022u;

	[Token(Token = "0x4001D81")]
	public const uint on_character_jump_state_change = 4024u;

	[Token(Token = "0x4001D82")]
	public const uint on_note_great_air_hit = 4050u;

	[Token(Token = "0x4001D83")]
	public const uint on_note_great_hit = 4051u;

	[Token(Token = "0x4001D84")]
	public const uint on_note_perfect_air_hit = 4052u;

	[Token(Token = "0x4001D85")]
	public const uint on_note_perfect_hit = 4053u;

	[Token(Token = "0x4001D86")]
	public const uint on_note_gold_great_air_hit = 4054u;

	[Token(Token = "0x4001D87")]
	public const uint on_note_gold_great_hit = 4055u;

	[Token(Token = "0x4001D88")]
	public const uint on_note_gold_perfect_air_hit = 4056u;

	[Token(Token = "0x4001D89")]
	public const uint on_note_gold_perfect_hit = 4057u;

	[Token(Token = "0x4001D8A")]
	public const uint on_double_note_great_hit = 4058u;

	[Token(Token = "0x4001D8B")]
	public const uint on_double_note_perfect_hit = 4059u;

	[Token(Token = "0x4001D8C")]
	public const uint on_double_note_gold_great_hit = 4060u;

	[Token(Token = "0x4001D8D")]
	public const uint on_double_note_gold_perfect_hit = 4061u;

	[Token(Token = "0x4001D8E")]
	public const uint on_note_miss_air = 4062u;

	[Token(Token = "0x4001D8F")]
	public const uint on_note_miss = 4063u;

	[Token(Token = "0x4001D90")]
	public const uint on_note_pass_air = 4064u;

	[Token(Token = "0x4001D91")]
	public const uint on_note_pass = 4065u;

	[Token(Token = "0x4001D92")]
	public const uint on_score_get_air = 4066u;

	[Token(Token = "0x4001D93")]
	public const uint on_score_get = 4067u;

	[Token(Token = "0x4001D94")]
	public const uint on_hp_get_air = 4068u;

	[Token(Token = "0x4001D95")]
	public const uint on_hp_get = 4069u;

	[Token(Token = "0x4001D96")]
	public const uint on_boss_shot = 4100u;

	[Token(Token = "0x4001D97")]
	public const uint on_boss_01_shot = 4101u;

	[Token(Token = "0x4001D98")]
	public const uint on_boss_01_shot_02 = 4102u;

	[Token(Token = "0x4001D99")]
	public const uint on_boss_02_shot = 4103u;

	[Token(Token = "0x4001D9A")]
	public const uint on_boss_02_shot_02 = 4104u;

	[Token(Token = "0x4001D9B")]
	public const uint on_boss_03_shot = 4105u;

	[Token(Token = "0x4001D9C")]
	public const uint on_boss_03_shot_02 = 4106u;

	[Token(Token = "0x4001D9D")]
	public const uint on_boss_04_shot = 4107u;

	[Token(Token = "0x4001D9E")]
	public const uint on_boss_04_shot_02 = 4108u;

	[Token(Token = "0x4001D9F")]
	public const uint on_boss_05_shot = 4109u;

	[Token(Token = "0x4001DA0")]
	public const uint on_boss_05_shot_02 = 4110u;

	[Token(Token = "0x4001DA1")]
	public const uint on_boss_06_shot = 4111u;

	[Token(Token = "0x4001DA2")]
	public const uint on_boss_06_shot_02 = 4112u;

	[Token(Token = "0x4001DA3")]
	public const uint on_boss_07_shot = 4113u;

	[Token(Token = "0x4001DA4")]
	public const uint on_boss_07_shot_02 = 4114u;

	[Token(Token = "0x4001DA5")]
	public const uint on_boss_08_shot = 4115u;

	[Token(Token = "0x4001DA6")]
	public const uint on_boss_08_shot_02 = 4116u;

	[Token(Token = "0x4001DA7")]
	public const uint on_boss_09_shot = 4117u;

	[Token(Token = "0x4001DA8")]
	public const uint on_boss_09_shot_02 = 4118u;

	[Token(Token = "0x4001DA9")]
	public const uint on_boss_10_shot = 4119u;

	[Token(Token = "0x4001DAA")]
	public const uint on_boss_10_shot_02 = 4120u;

	[Token(Token = "0x4001DAB")]
	public const uint on_fail = 4200u;

	[Token(Token = "0x4001DAC")]
	public const uint on_victory = 4201u;

	[Token(Token = "0x4001DAD")]
	public const uint on_full_combo = 4202u;

	[Token(Token = "0x4001DAE")]
	public const uint on_set_auto_fever = 4203u;

	[Token(Token = "0x4001DAF")]
	public const uint on_show_victory = 4204u;

	[Token(Token = "0x4001DB0")]
	public const uint on_stage_start = 4205u;

	[Token(Token = "0x4001DB1")]
	public const uint on_pause = 4206u;

	[Token(Token = "0x4001DB2")]
	public const uint on_resume = 4207u;

	[Token(Token = "0x4001DB3")]
	public const uint on_show_pnl_pause = 4208u;

	[Token(Token = "0x4001DB4")]
	public const uint on_ghost_attack = 4500u;

	[Token(Token = "0x4001DB5")]
	public const uint on_scene_changed = 5000u;

	[Token(Token = "0x4001DB6")]
	public const uint boss_set_hide = 5001u;

	[Token(Token = "0x4001DB7")]
	public const uint note_set_hide = 5002u;

	[Token(Token = "0x4001DB8")]
	public const uint on_touhou_fever = 5003u;

	[Token(Token = "0x4001DB9")]
	public const uint touhou_fever_changed = 5004u;

	[Token(Token = "0x4001DBA")]
	public const uint scene_event = 5005u;

	[Token(Token = "0x4001DBB")]
	public const uint display_layer = 5006u;

	[Token(Token = "0x4001DBC")]
	public const uint disappear_note = 5007u;

	[Token(Token = "0x4001DBD")]
	public const uint on_miss_2_great = 5008u;

	[Token(Token = "0x4001DBE")]
	public const uint on_robot_double_hit = 5009u;

	[Token(Token = "0x4001DBF")]
	public const uint on_robot_up_hit = 5010u;

	[Token(Token = "0x4001DC0")]
	public const uint on_robot_down_hit = 5011u;

	[Token(Token = "0x4001DC1")]
	public const uint on_fan_robot_start_revive = 5012u;

	[Token(Token = "0x4001DC2")]
	public const uint on_neko_skill_trigger = 5013u;

	[Token(Token = "0x4001DC3")]
	public const uint on_great2_perfect = 5014u;

	[Token(Token = "0x4001DC4")]
	public const uint on_rhythm_skill = 5015u;

	[Token(Token = "0x4001DC5")]
	public const uint invoke_dialog = 5500u;

	[Token(Token = "0x4001DC6")]
	public const uint on_peropero_top_painter_welcome = 10001u;

	[Token(Token = "0x4001DC7")]
	public const uint on_cytus_hideen = 10002u;

	[Token(Token = "0x4001DC8")]
	public const uint on_cytus_hideen_close = 10003u;

	[Token(Token = "0x4001DC9")]
	public const uint close_pnl_illuscheck = 10004u;

	[Token(Token = "0x4001DCA")]
	public const uint refresh_trove_select = 10005u;

	[Token(Token = "0x4001DCB")]
	public const uint refresh_trove_content_layout = 10006u;

	[Token(Token = "0x4001DCC")]
	public const uint jump_to_target_music = 10007u;

	[Token(Token = "0x4001DCD")]
	public const uint close_pnl_dlc = 10008u;

	[Token(Token = "0x4001DCE")]
	public const uint refresh_pnl_dlc_btn_purchase = 10009u;

	[Token(Token = "0x4001DCF")]
	public const uint on_input_select_key_custom_start = 8001u;

	[Token(Token = "0x4001DD0")]
	public const uint on_input_select_key_custom_complete = 8002u;

	[Token(Token = "0x4001DD1")]
	public const uint on_input_select_key_custom_listening = 8003u;

	[Token(Token = "0x4001DD2")]
	public const uint on_input_select_key_custom_has_repeat = 8004u;

	[Token(Token = "0x4001DD3")]
	public const uint on_pnl_dlc_click_just_as_planned_qa = 8005u;

	[Token(Token = "0x4001DD4")]
	public const uint set_pnl_unlock_mask = 8006u;

	[Token(Token = "0x4001DD5")]
	public const uint lock_pnl_unlock_mask = 8007u;

	[Token(Token = "0x4001DD6")]
	public const uint select_assign_dpi = 8008u;

	[Token(Token = "0x4001DD7")]
	public const uint refresh_dlc_info_sub_control = 8009u;

	[Token(Token = "0x4001DD8")]
	public const uint refresh_head = 8010u;

	[Token(Token = "0x4001DD9")]
	public const uint refresh_achv_select = 8011u;

	[Token(Token = "0x4001DDA")]
	public const uint set_pnl_menu_open = 8012u;

	[Token(Token = "0x4001DDB")]
	public const uint close_pnl_menu = 8013u;

	[Token(Token = "0x4001DDC")]
	public const uint on_start_game_btn_click = 8014u;

	[Token(Token = "0x4001DDD")]
	public const uint hide_bg_root_tips = 8015u;

	[Token(Token = "0x4001DDE")]
	public const uint close_pnl_vip_tip = 8016u;

	[Token(Token = "0x4001DDF")]
	public const uint on_pnl_rank_refresh_level_config = 8017u;

	[Token(Token = "0x4001DE0")]
	public const uint on_pnl_level_config_select_show_open = 8018u;

	[Token(Token = "0x4001DE1")]
	public const uint on_pnl_level_config_select_show_close = 8019u;

	[Token(Token = "0x4001DE2")]
	public const uint on_diver_talk = 8020u;

	[Token(Token = "0x4001DE3")]
	public const uint on_diver_talk_bgCharacter = 8021u;

	[Token(Token = "0x4001DE4")]
	public const uint on_background_selected_and_confirm = 9001u;

	[Token(Token = "0x4001DE5")]
	public const uint on_background_limit_free_data_got_and_force_apply = 9002u;

	[Token(Token = "0x4001DE6")]
	public const uint on_get_recommend_update_version = 9101u;

	[Token(Token = "0x4001DE7")]
	public const uint on_lobby_menu_navigation_back_btn_clicked = 9102u;

	[Token(Token = "0x4001DE8")]
	public const uint on_multi_girl_empty_attack = 20000u;

	[Token(Token = "0x4001DE9")]
	public const uint on_multi_girl_come_out = 20001u;

	[Token(Token = "0x4001DEA")]
	public const uint on_multi_girl_attacked = 20002u;

	[Token(Token = "0x4001DEB")]
	public const uint on_multi_girl_hurt = 20003u;

	[Token(Token = "0x4001DEC")]
	public const uint on_multi_girl_dead = 20004u;

	[Token(Token = "0x4001DED")]
	public const uint on_multi_girl_hurt_end = 20005u;

	[Token(Token = "0x4001DEE")]
	public const uint on_multi_girl_long_press = 20006u;

	[Token(Token = "0x4001DEF")]
	public const uint on_multi_girl_multi_hits = 20007u;

	[Token(Token = "0x4001DF0")]
	public const uint on_multi_girl_multi_hit_end = 20008u;

	[Token(Token = "0x4001DF1")]
	public const uint on_multi_girl_double_hit = 20009u;

	[Token(Token = "0x4001DF2")]
	public const uint on_multi_girl_switch_actor = 20010u;

	[Token(Token = "0x4001DF3")]
	public const uint on_multi_girl_synergy_attack = 20011u;

	[Token(Token = "0x4001DF4")]
	public const uint on_multi_girl_double_missed_note_judge = 20012u;

	[Token(Token = "0x4001DF5")]
	public const uint on_multi_girl_hurt_state_boradcast = 20013u;

	[Token(Token = "0x4001DF6")]
	public const uint on_multi_girl_dead_state_boardcast = 20014u;

	[Token(Token = "0x4001DF7")]
	public const uint on_multi_girl_long_press_end = 20015u;

	[Token(Token = "0x4001DF8")]
	public const uint on_multi_girl_invicinble = 20016u;

	[Token(Token = "0x4001DF9")]
	public const uint on_multi_girl_change_to_press_after_multi_hit = 20017u;

	[Token(Token = "0x4001DFA")]
	public const uint on_announce_state_update = 21000u;

	[Token(Token = "0x4001DFB")]
	public const uint on_tutorial_read_update = 21001u;

	[Token(Token = "0x4001DFC")]
	public const uint on_stage_background_list_update = 21002u;

	[Token(Token = "0x4001DFD")]
	public const uint on_head_update = 22000u;

	[Token(Token = "0x4001DFE")]
	public const uint on_message_manager_pop_msg_state_change = 20020u;

	[Token(Token = "0x4001DFF")]
	public const uint on_question_note_showed = 20030u;

	[Token(Token = "0x4001E00")]
	public const uint on_question_note_attacked = 20031u;

	[Token(Token = "0x4001E01")]
	public const uint on_question_show_completed = 20032u;

	[Token(Token = "0x4001E02")]
	public const uint on_question_answer_completed = 20033u;

	[Token(Token = "0x4001E03")]
	public const uint on_auto_play_state_changed = 20040u;

	[Token(Token = "0x4001E04")]
	public const uint on_hide_or_show_scene_combo = 20041u;

	[Token(Token = "0x4001E05")]
	public const uint on_fool_day_send_select_character_vic_img = 20042u;

	[Token(Token = "0x4001E06")]
	public const uint on_special_blood_note_hit = 20050u;

	[Token(Token = "0x4001E07")]
	public const uint on_special_blood_note_miss = 20051u;

	[Token(Token = "0x4001E08")]
	public const uint on_bloodheir_skill_on = 20052u;

	[Token(Token = "0x4001E09")]
	public const uint on_bloodheir_skill_off = 20053u;

	[Token(Token = "0x4001E0A")]
	public const uint on_bloodheir_role_inited = 20054u;

	[Token(Token = "0x4001E0B")]
	public const uint on_tgl_random_role_config_changed = 20060u;

	[Token(Token = "0x4001E0C")]
	public const uint on_tgl_prepare_role_config_lock_changed = 20061u;

	[Token(Token = "0x4001E0D")]
	public const uint on_dave_fish_changed = 20043u;
}
