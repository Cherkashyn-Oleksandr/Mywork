namespace LoginPageAndSmartID
{
    public enum Trouble
    {
        InterfaceAuthenticationFailed,
        NoPermissionToIssueRequest,
        UserDoesNotHaveAccountInSmartIdSystem,
        NoSuitableAccountOfRequestedTypeFoundButUserHasSomeOtherAccounts,
        PersonShouldViewSmartIdAppOrSmartIdSelfServicePortalNow,
        TheClientIsTooOldAndNotSupportedAnyMore,
        SystemIsUnderMaintenance,
        SessionDoesNotExistOrHasExpired,
        UserRefused,
        Timeout,
        DocumentUnusable,
        WrongVc,
        RequiredInteractionNotSupportedByApp,
        UserRefusedDisplayTextAndPin,
        UserRefusedVcChoice,
        UserRefusedConfirmationMessage,
        UserRefusedConfirmationMessageWithVcChoice,
        UserRefusedCertChoice,
        ResponseSignatureValidationFailed,
        ResponseSignersCertificateHasExpired,
        ResponseSignersCertificateIsNotTrusted,
        Unknown
    }
}