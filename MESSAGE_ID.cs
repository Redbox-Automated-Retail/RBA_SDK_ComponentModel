namespace RBA_SDK_ComponentModel
{
  public enum MESSAGE_ID
  {
    M00_OFFLINE,
    M01_ONLINE,
    M02_RESERVED,
    M03_SET_SESSION_KEY,
    M04_SET_PAYMENT_TYPE,
    M05_ASYNC_STATUS_NOT_IN_USE,
    M06_RESERVED,
    M07_UNIT_DATA,
    M08_HEALTH_STAT,
    M09_SET_ALLOWED_PAYMENT,
    M10_HARD_RESET,
    M11_STATUS,
    M12_ACCOUNT,
    M13_AMOUNT,
    M14_SET_TXN_TYPE,
    M15_SOFT_RESET,
    M16_CONTACTLESS_MODE,
    M17_MERCHANT_DATA_WRITE,
    M18_INFO_CARD,
    M19_BIN_LOOKUP,
    M20_SIGNATURE,
    M21_NUMERIC_INPUT,
    M22_APPLICATION_ID,
    M23_CARD_READ,
    M24_FORM_ENTRY,
    M25_TERMS_AND_CONDITIONS,
    M26_RUN_SCRIPT,
    M27_ALPHA_INPUT,
    M28_SET_VARIABLE,
    M29_GET_VARIABLE,
    M30_ADVERTISING,
    M31_PIN_ENTRY,
    M32_RESERVED,
    M33_EMV_NOT_IN_USE,
    M34_STATE_SAVE_RESTORE,
    M35_MENU,
    M36_CONTACTLESS_NOTIFY,
    M37_RATING_REQUEST,
    M38_RESERVED,
    M39_RESERVED,
    M40_SURVEY,
    M41_CARD_READ,
    M42_RESERVED,
    M43_RESERVED,
    M44_RESERVED,
    M45_RESERVED,
    M46_RESERVED,
    M47_RESERVED,
    M48_RESERVED,
    M49_RESERVED,
    M50_AUTHORIZATION,
    M51_BEEP,
    M52_PAYPAL_PREAUTHORIZE,
    M53_RESERVED,
    M54_RESERVED,
    M55_STATE_INFORMATION,
    M56_RESERVED,
    M57_RESERVED,
    M58_DISCOVER_DEVICES,
    M59_RESERVED,
    M60_CONFIGURATION_WRITE,
    M61_CONFIGURATION_READ,
    M62_FILE_WRITE,
    M63_FIND_FILE,
    M64_DELETE_FILE,
    M65_RETRIEVE_FILE,
    M66_COPY_FILE,
    M67_RESERVED,
    M68_RESERVED,
    M69_RESERVED,
    M70_UPDATE_FORM_ELEMENT,
    M71_RESERVED,
    M72_AUDIO_PLAY,
    M73_CVV_CSC_INPUT,
    M74_RESERVED,
    M75_RESERVED,
    M76_RESERVED,
    M77_SLINGSHOT,
    M78_RESERVED,
    M79_RESERVED,
    M80_MAC_CALCULATION,
    M81_MAC_VERIFICATION,
    M82_KME_SESSION_KEY_INJECTION,
    M83_E2EE_ENABLE,
    M84_FSA_CARD_BIN_RANGE,
    M85_E2EE_INFO,
    M86_E2EE_BIN_LOOKUP,
    M87_E2EE_CARD_READ,
    M88_E2EE_TRANSLATE_ENCR_CARD_DATA,
    M89_E2EE_BIN_RECORD,
    M90_MSR_ENCRYPTION,
    M91_PRINTER,
    M92_LIGHT_CONTROL,
    M93_CHALLENGE,
    M94_BARCODE_SET,
    M95_BARCODE_GET,
    M96_RESERVED,
    M97_REBOOT,
    M98_RESERVED,
    M99_RESERVED,
    M05_20_ASYNC_STATUS_SIGNATURE,
    M05_21_ASYNC_STATUS_NUMERIC_INPUT,
    M05_23_ASYNC_STATUS_CARD_READ,
    M05_24_ASYNC_STATUS_FORM_ENTRY,
    M05_25_ASYNC_STATUS_TERMS_AND_CONDITIONS,
    M05_27_ASYNC_STATUS_ALPHA_INPUT,
    M05_31_ASYNC_STATUS_PIN_ENTRY,
    M05_35_ASYNC_STATUS_MENU,
    M05_41_ASYNC_STATUS_CARD_READ,
    M05_70_ASYNC_STATUS_UPDATE_FORM,
    M05_73_ASYNC_STATUS_CVV_CSC_INPUT,
    M05_87_ASYNC_STATUS_E2EE_CARD_READ,
    M33_00_EMV_TRANSACTION_INITIATION,
    M33_01_EMV_STATUS,
    M33_02_EMV_TRANSACTION_PREPARATION_RESPONSE,
    M33_03_EMV_AUTHORIZATION_REQUEST,
    M33_04_EMV_AUTHORIZATION_RESPONSE,
    M33_05_EMV_AUTHORIZATION_CONFIRMATION,
    M33_06_EMV_TERMINATE,
    M33_07_EMV_TERMINAL_CAPABILITIES,
    M33_08_EMV_SET_VARIABLES,
    M33_09_EMV_SET_DATA,
    M33_10_EMV_GET_DATA,
    M33_11_EMV_EXTERNAL_AID_SELECT_NOTIFICATION,
    M33_12_EMV_EXTERNAL_AID_SELECT,
    MWIC_00_ACTIVATION,
    MWIC_10_GET_PAN_CARD_NUMBER,
    MWIC_20_READ_BALANCE,
    MWIC_30_DEBIT_BALANCE,
    MWIC_40_BLOCK_CARD,
    MWIC_50_END_TRANSACTION,
    MWIC_56_EXTENDED_END_TRANSACTION,
    MWIC_60_AUTHENTICATE_USER,
    MWIC_70_DEACTIVATE,
    MWIC_80_REMOVE_CARD_REQUEST,
    MWIC_90_RESTORE_BALANCE,
    MWIC_99_RBA_CANCEL_DEBIT_TRANSACTION,
    FILE_WRITE,
    PRINT_FILE,
    SCREEN_DUMP,
    MOCK_ETALON_REQ_RES,
    RAW_PINPAD_RESPONSE,
    MXX_UNKNOWN,
  }
}
