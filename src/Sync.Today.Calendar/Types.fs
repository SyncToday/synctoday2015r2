namespace Sync.Today.Calendar

open System

[<CLIMutable>]
type AppointmentDTO =
    {   AppointmentId : int
        InternalId : Guid
        LastModified : DateTime
        Category : string option
        Location : string option
        Content : string option
        Title : string option
        DateFrom: DateTime
        DateTo: DateTime
        ReminderMinutesBeforeStart: int
        Notification : bool
        IsPrivate : bool
        Priority : byte
        ConsumerId : int
    }
