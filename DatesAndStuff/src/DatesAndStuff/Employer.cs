namespace DatesAndStuff;

public class Employer
{
    readonly string taxId;
    readonly string address;
    readonly string ownername;
    readonly List<int>? activityDomains;

    public Employer(
        string taxId,
        string address,
        string ownername,
        List<int>? activityDomains) // Allow null for activityDomains
    {
        this.taxId = taxId;
        this.address = address;
        this.ownername = ownername;
        this.activityDomains = activityDomains;
    }

    internal Employer Clone()
    {
        return new Employer(taxId, address, ownername, activityDomains != null ? [.. activityDomains] : null);
    }
}