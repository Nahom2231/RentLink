namespace RentLink.Core.Enums;

public enum UserRole
{
    Renter=1, Landlord =2, MunicipalityOfficer = 3
}

public enum PropertyStatus
{
    Draft =1, Available =2, Rented=3,  UnderMaintenance =4
}

public enum LeaseStatus
{
    PendingLandlordSignature = 1, PendingRenterSignature =2, Active =3, Terminated =4 
}

public enum InspectionType
{
    MoveIn =1, MoveOut =2
}

public enum PaymentStatus
{
    Pending = 1, Success =2, Failed =3
}

public enum TicketStatus
{

    Open =1, InProgress =2, Resolved = 3, Escalated = 4
}