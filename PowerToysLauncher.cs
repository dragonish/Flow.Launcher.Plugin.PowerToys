using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Flow.Launcher.Plugin.PowerToys;

public static class Events
{
    public const string PowerToysRunInvokeEvent = "Local\\PowerToysRunInvokeEvent-30f26ad7-d36d-4c0e-ab02-68bb5ff3c4ab";
    public const string ShowPowerToysCmdPalEvent = "Local\\PowerToysCmdPal-ShowEvent-62336fcd-8611-4023-9b30-091a6af4cc5a";
    public const string ShowColorPickerSharedEvent = "Local\\ShowColorPickerEvent-8c46be2a-3e05-4186-b56b-4ae986ef2525";
    public const string FZEToggleEvent = "Local\\FancyZones-ToggleEditorEvent-1e174338-06a3-472b-874d-073b21c62f14";
    public const string ShowHostsSharedEvent = "Local\\Hosts-ShowHostsEvent-5a0c0aae-5ff5-40f5-95c2-20e37ed671f0";
    public const string ShowHostsAdminEvent = "Local\\Hosts-ShowHostsAdminEvent-60ff44e2-efd3-43bf-928a-f4d269f98bec";
    public const string MeasureToolTriggerEvent = "Local\\MeasureToolEvent-3d46745f-09b3-4671-a577-236be7abd199";
    public const string ShortcutGuideTriggerEvent = "Local\\ShortcutGuide-TriggerEvent-d4275ad3-2531-4d19-9252-c0becbd9b496";
    public const string RegistryPreviewTriggerEvent = "Local\\RegistryPreviewEvent-4C559468-F75A-4E7F-BC4F-9C9688316687";
    public const string CropAndLockThumbnailEvent = "Local\\PowerToysCropAndLockThumbnailEvent-1637be50-da72-46b2-9220-b32b206b2434";
    public const string CropAndLockReparentEvent = "Local\\PowerToysCropAndLockReparentEvent-6060860a-76a1-44e8-8d0e-6355785e9c36";
    public const string CropAndLockScreenshotEvent = "Local\\PowerToysCropAndLockScreenshotEvent-ff077ab2-8360-4bd1-864a-637389d35593";
    public const string ShowEnvironmentVariablesSharedEvent = "Local\\PowerToysEnvironmentVariables-ShowEnvironmentVariablesEvent-1021f616-e951-4d64-b231-a8f972159978";
    public const string ShowEnvironmentVarablesAdminEvent = "Local\\PowerToysEnvironmentVariables-EnvironmentVariablesAdminEvent-8c95d2ad-047c-49a2-9e8b-b4656326cfb2";
    public const string AlwaysOnTopPinEvent = "Local\\AlwaysOnTopPinEvent-892e0aa2-cfa8-4cc4-b196-ddeb32314ce8";
    public const string AlwaysOnTopIncreaseOpacityEvent = "Local\\AlwaysOnTopIncreaseOpacityEvent-a1b2c3d4-e5f6-7890-abcd-ef1234567890";
    public const string AlwaysOnTopDecreaseOpacityEvent = "Local\\AlwaysOnTopDecreaseOpacityEvent-b2c3d4e5-f6a7-8901-bcde-f12345678901";
    public const string ShowPowerOcrEvent = "Local\\PowerOCREvent-dc864e06-e1af-4ecc-9078-f98bee745e3a";
    public const string LaunchWorkspacesEditorEvent = "Local\\Workspaces-LaunchEditorEvent-a55ff427-cf62-4994-a2cd-9f72139296bf";
    public const string PowerToysAwakeExitEvent = "Local\\PowerToysAwakeExitEvent-c0d5e305-35fc-4fb5-83ec-f6070cfaf7fe";
    public const string AdvancedPasteShowUIEvent = "Local\\PowerToys_AdvancedPaste_ShowUI";
    public const string FindMyMouseTriggerEvent = "Local\\FindMyMouseTriggerEvent-5a9dc5f4-1c74-4f2f-a66f-1b9b6a2f9b23";
    public const string MouseHighlighterTriggerEvent = "Local\\MouseHighlighterTriggerEvent-1e3c9c3d-3fdf-4f9a-9a52-31c9b3c3a8f4";
    public const string MouseCrosshairsTriggerEvent = "Local\\MouseCrosshairsTriggerEvent-0d4c7f92-0a5c-4f5c-b64b-8a2a2f7e0b21";
    public const string CursorWrapTriggerEvent = "Local\\CursorWrapTriggerEvent-1f8452b5-4e6e-45b3-8b09-13f14a5900c9";
    public const string LightSwitchToggleEvent = "Local\\PowerToys-LightSwitch-ToggleEvent-d8dc2f29-8c94-4ca1-8c5f-3e2b1e3c4f5a";
    public const string LightSwitchLightThemeEvent = "Local\\PowerToysLightSwitch-LightThemeEvent-50077121-2ffc-4841-9c86-ab1bd3f9baca";
    public const string LightSwitchDarkThemeEvent = "Local\\PowerToysLightSwitch-DarkThemeEvent-b3a835c0-eaa2-49b0-b8eb-f793e3df3368";
    public const string ZoomItRefreshSettingsEvent = "Local\\PowerToysZoomIt-RefreshSettingsEvent-f053a563-d519-4b0d-8152-a54489c13324";
    public const string ZoomItExitEvent = "Local\\PowerToysZoomIt-ExitEvent-36641ce6-df02-4eac-abea-a3fbf9138220";
    public const string ZoomItZoomEvent = "Local\\PowerToysZoomIt-ZoomEvent-1e4190d7-94bc-4ad5-adc0-9a8fd07cb393";
    public const string ZoomItDrawEvent = "Local\\PowerToysZoomIt-DrawEvent-56338997-404d-4549-bd9a-d132b6766975";
    public const string ZoomItBreakEvent = "Local\\PowerToysZoomIt-BreakEvent-17f2e63c-4c56-41dd-90a0-2d12f9f50c6b";
    public const string ZoomItLiveZoomEvent = "Local\\PowerToysZoomIt-LiveZoomEvent-390bf0c7-616f-47dc-bafe-a2d228add20d";
    public const string ZoomItSnipEvent = "Local\\PowerToysZoomIt-SnipEvent-2fd9c211-436d-4f17-a902-2528aaae3e30";
    public const string ZoomItSnipOcrEvent = "Local\\PowerToysZoomIt-SnipOcrEvent-a7c3b1d2-9e4f-4a6b-8d5c-1f2e3a4b5c6d";
    public const string ZoomItRecordEvent = "Local\\PowerToysZoomIt-RecordEvent-74539344-eaad-4711-8e83-23946e424512";
    public const string OpenNewKeyboardManagerEvent = "Local\\PowerToysOpenNewKeyboardManagerEvent-9c1d2e3f-4b5a-6c7d-8e9f-0a1b2c3d4e5f";
    public const string ToggleEasyMouseEvent = "Local\\PowerToysMWB-ToggleEasyMouseEvent-a9c8d7b6-e5f4-3c2a-1b0d-9e8f7a6b5c4d";
    public const string ReconnectEvent = "Local\\PowerToysMWB-ReconnectEvent-b8d7c6a5-f4e3-2b1c-0a9d-8e7f6a5b4c3d";
    public const string PowerDisplayToggleEvent = "Local\\PowerToysPowerDisplay-ToggleEvent-5f1a9c3e-7d2b-4e8f-9a6c-3b5d7e9f1a2c";
    public const string PowerDisplayTerminateEvent = "Local\\PowerToysPowerDisplay-TerminateEvent-7b9c2e1f-8a5d-4c3e-9f6b-2a1d8c5e3b7a";
    public const string PowerDisplayRefreshMonitorsEvent = "Local\\PowerToysPowerDisplay-RefreshMonitorsEvent-a3f5c8e7-9d1b-4e2f-8c6a-3b5d7e9f1a2c";
    public const string GrabAndMoveExitEvent = "Local\\PowerToysGrabAndMove-ExitEvent-b8c4d2e3-5f6a-7b8c-9d0e-1f2a3b4c5d6e";
}

public class PowerToysLauncher
{
    public IEnumerable<IAction> EnabledActions => Actions.Where(ActionEnabled);
    private PowerToysSettings _settings = new();
    public async Task ApplySettings()
    {
        await _settings.RefreshSettings();
    }

    public bool IsPowerToysRunning()
    {
        var processes = Process.GetProcessesByName("PowerToys");
        return processes.Length != 0;
    }

    private bool ActionEnabled(IAction action)
    {
        return action switch
        {
            PowerToysUtilityActionWithSettings s => _settings.IsEnabled(s.SettingsEnabledName),
            _ => true
        };
    }

    private static IAction[] Actions =
    [
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.MeasureToolTriggerEvent,
            Keywords = ["screen", "ruler", "measure", "tool"],
            TitleKey = "screen_ruler",
            Icon = "ScreenRuler.png",
            SettingsLinkName = "MeasureTool",
            SettingsEnabledNameOverride = "Measure Tool"
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.ShortcutGuideTriggerEvent,
            Keywords = ["shortcut", "guide"],
            TitleKey = "shortcut_guide",
            Icon = "ShortcutGuide.png",
            SettingsLinkName = "ShortcutGuide",
            SettingsEnabledNameOverride = "Shortcut Guide"
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.ShowColorPickerSharedEvent,
            Keywords = ["color", "picker"],
            TitleKey = "color_picker",
            Icon = "ColorPicker.png",
            SettingsLinkName = "ColorPicker"
        },
        new DelayedPowerToysUtilityAction
        {
            EventKey = Events.AlwaysOnTopPinEvent,
            Keywords = ["always", "top", "pin"],
            TitleKey = "always_on_top_pin",
            Icon = "AlwaysOnTop.png",
            SettingsLinkName = "AlwaysOnTop"
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.AlwaysOnTopIncreaseOpacityEvent,
            Keywords = ["always", "top", "increase", "opacity"],
            TitleKey = "always_on_top_increase_opacity",
            Icon = "AlwaysOnTop.png",
            SettingsLinkName = "AlwaysOnTop"
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.AlwaysOnTopDecreaseOpacityEvent,
            Keywords = ["always", "top", "decrease", "opacity"],
            TitleKey = "always_on_top_decrease_opacity",
            Icon = "AlwaysOnTop.png",
            SettingsLinkName = "AlwaysOnTop"
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.ShowPowerOcrEvent,
            Keywords = ["text", "extract", "ocr"],
            TitleKey = "text_extractor",
            Icon = "TextExtractor.png",
            SettingsLinkName = "PowerOcr",
            SettingsEnabledNameOverride = "TextExtractor"
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.FZEToggleEvent,
            Keywords = ["fancy", "zones"],
            TitleKey = "fancy_zones",
            Icon = "FancyZones.png",
            SettingsLinkName = "FancyZones"
        },
        new PowerToysUtilityActionWithAsAdmin
        {
            EventKey = Events.ShowHostsSharedEvent,
            Keywords = ["hosts"],
            TitleKey = "hosts_file_editor",
            Icon = "Hosts.png",
            SettingsLinkName = "Hosts",
            RunAsAdminEventKey = Events.ShowHostsAdminEvent
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.RegistryPreviewTriggerEvent,
            Keywords = ["registry", "preview"],
            TitleKey = "registry_preview",
            Icon = "RegistryPreview.png",
            SettingsLinkName = "RegistryPreview"
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.LaunchWorkspacesEditorEvent,
            Keywords = ["workspaces"],
            TitleKey = "workspaces",
            Icon = "Workspaces.png",
            SettingsLinkName = "Workspaces"
        },
        new DelayedPowerToysUtilityAction
        {
            EventKey = Events.CropAndLockReparentEvent,
            Keywords = ["crop", "lock", "reparent"],
            TitleKey = "crop_and_lock_reparent",
            Icon = "CropAndLock.png",
            SettingsLinkName = "CropAndLock"
        },
        new DelayedPowerToysUtilityAction
        {
            EventKey = Events.CropAndLockThumbnailEvent,
            Keywords = ["crop", "lock", "thumbnail"],
            TitleKey = "crop_and_lock_thumbnail",
            Icon = "CropAndLock.png",
            SettingsLinkName = "CropAndLock"
        },
        new DelayedPowerToysUtilityAction
        {
            EventKey = Events.CropAndLockScreenshotEvent,
            Keywords = ["crop", "lock", "screenshot"],
            TitleKey = "crop_and_lock_screenshot",
            Icon = "CropAndLock.png",
            SettingsLinkName = "CropAndLock"
        },
        new PowerToysUtilityActionWithAsAdmin
        {
            EventKey = Events.ShowEnvironmentVariablesSharedEvent,
            Keywords = ["environment", "variables"],
            TitleKey = "environment_variables",
            Icon = "EnvironmentVariables.png",
            SettingsLinkName = "EnvironmentVariables",
            RunAsAdminEventKey = Events.ShowEnvironmentVarablesAdminEvent
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.PowerToysRunInvokeEvent,
            Keywords = ["powertoys", "run"],
            TitleKey = "powertoys_run",
            Icon = "PowerToysRun.png",
            SettingsLinkName = "Run",
            SettingsEnabledNameOverride = "PowerToys Run",
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.ShowPowerToysCmdPalEvent,
            Keywords = ["command", "palette", "cmd"],
            TitleKey = "command_palette",
            Icon = "CmdPal.png",
            SettingsLinkName = "CmdPal",
        },
        new PowerToysUtilityActionWithSettings
        {
            EventKey = Events.PowerToysAwakeExitEvent,
            Keywords = ["exit", "awake"],
            TitleKey = "awake_exit",
            Icon = "Awake.png",
            SettingsLinkName = "Awake",
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.AdvancedPasteShowUIEvent,
            Keywords = ["advanced", "paste"],
            TitleKey = "advanced_paste_show_ui",
            Icon = "AdvancedPaste.png",
            SettingsLinkName = "AdvancedPaste"
        },
        new DelayedPowerToysUtilityAction {
            EventKey = Events.FindMyMouseTriggerEvent,
            Keywords = ["find", "mouse"],
            TitleKey = "find_my_mouse",
            Icon = "FindMyMouse.png",
            SettingsLinkName = "MouseUtils",
            SettingsEnabledNameOverride = "FindMyMouse"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.MouseHighlighterTriggerEvent,
            Keywords = ["mouse", "highlighter"],
            TitleKey = "mouse_highlighter",
            Icon = "MouseHighlighter.png",
            SettingsLinkName = "MouseUtils",
            SettingsEnabledNameOverride = "MouseHighlighter"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.MouseCrosshairsTriggerEvent,
            Keywords = ["mouse", "crosshairs"],
            TitleKey = "mouse_crosshairs",
            Icon = "MouseCrosshairs.png",
            SettingsLinkName = "MouseUtils",
            SettingsEnabledNameOverride = "MousePointerCrosshairs"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.CursorWrapTriggerEvent,
            Keywords = ["cursor", "wrap"],
            TitleKey = "cursor_wrap",
            Icon = "CursorWrap.png",
            SettingsLinkName = "MouseUtils",
            SettingsEnabledNameOverride = "CursorWrap"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.LightSwitchToggleEvent,
            Keywords = ["light", "switch", "toggle", "theme"],
            TitleKey = "light_switch_toggle",
            Icon = "LightSwitch.png",
            SettingsLinkName = "LightSwitch"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.LightSwitchLightThemeEvent,
            Keywords = ["light", "switch", "light", "theme"],
            TitleKey = "light_switch_light_theme",
            Icon = "LightSwitch.png",
            SettingsLinkName = "LightSwitch"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.LightSwitchDarkThemeEvent,
            Keywords = ["light", "switch", "dark", "theme"],
            TitleKey = "light_switch_dark_theme",
            Icon = "LightSwitch.png",
            SettingsLinkName = "LightSwitch"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItRefreshSettingsEvent,
            Keywords = ["zoomit", "refresh", "settings"],
            TitleKey = "zoomit_refresh_settings",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItExitEvent,
            Keywords = ["zoomit", "exit"],
            TitleKey = "zoomit_exit",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItZoomEvent,
            Keywords = ["zoomit", "zoom"],
            TitleKey = "zoomit_zoom",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItDrawEvent,
            Keywords = ["zoomit", "draw"],
            TitleKey = "zoomit_draw",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItBreakEvent,
            Keywords = ["zoomit", "break"],
            TitleKey = "zoomit_break",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItLiveZoomEvent,
            Keywords = ["zoomit", "live", "zoom"],
            TitleKey = "zoomit_live_zoom",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItSnipEvent,
            Keywords = ["zoomit", "snip"],
            TitleKey = "zoomit_snip",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItSnipOcrEvent,
            Keywords = ["zoomit", "snip", "ocr"],
            TitleKey = "zoomit_snip_ocr",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ZoomItRecordEvent,
            Keywords = ["zoomit", "record"],
            TitleKey = "zoomit_record",
            Icon = "ZoomIt.png",
            SettingsLinkName = "ZoomIt"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.OpenNewKeyboardManagerEvent,
            Keywords = ["keyboard", "manager"],
            TitleKey = "open_new_keyboard_manager",
            Icon = "KeyboardManager.png",
            SettingsLinkName = "KBM",
            SettingsEnabledNameOverride = "Keyboard Manager"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ToggleEasyMouseEvent,
            Keywords = ["toggle", "easy", "mouse"],
            TitleKey = "toggle_easy_mouse",
            Icon = "MouseWithoutBorders.png",
            SettingsLinkName = "MouseWithoutBorders"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.ReconnectEvent,
            Keywords = ["reconnect", "mouse"],
            TitleKey = "reconnect_mouse",
            Icon = "MouseWithoutBorders.png",
            SettingsLinkName = "MouseWithoutBorders"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.PowerDisplayToggleEvent,
            Keywords = ["display", "tooggle"],
            TitleKey = "power_display_tooggle",
            Icon = "PowerDisplay.png",
            SettingsLinkName = "PowerDisplay"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.PowerDisplayTerminateEvent,
            Keywords = ["display", "terminate"],
            TitleKey = "power_display_terminate",
            Icon = "PowerDisplay.png",
            SettingsLinkName = "PowerDisplay"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.PowerDisplayRefreshMonitorsEvent,
            Keywords = ["display", "refresh", "monitors"],
            TitleKey = "power_display_refresh_monitors",
            Icon = "PowerDisplay.png",
            SettingsLinkName = "PowerDisplay"
        },
        new PowerToysUtilityActionWithSettings {
            EventKey = Events.GrabAndMoveExitEvent,
            Keywords = ["grab", "move", "exit"],
            TitleKey = "grab_and_move_exit",
            Icon = "GrabAndMove.png",
            SettingsLinkName = "GrabAndMove"
        },
        new OpenPowerToysSettingsAction
        {
            Icon = "PowerToys.png",
            Keywords = ["settings"],
            SettingsLinkName = "PowerToys",
            TitleKey = "settings"
        }
    ];
}
