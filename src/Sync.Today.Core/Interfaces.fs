namespace Sync.Today.Core

module Interfaces =

    /// Simple named item
    ///
    type INamed =
        abstract member Name : string with get

    /// Application e.g. Exchange, Google, SAP BusinessOne, Flores or Microsoft Dynamics CRM
    ///
    type IService =
        inherit( INamed )

    /// Generally known entity or entity combination e.g. Appointments, Products or Firms
    ///
    type IAdapter =
        inherit( INamed )

    /// Registered login information (real or technical user) that can be used to access the application (IService)
    ///
    type IAccount = 
        inherit( INamed )

    /// Real user or device the information belong to
    ///
    type IConsumer = 
        inherit( INamed )

