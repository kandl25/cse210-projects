using System;
using System.Collections.Generic;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_rsvpEmail}";
    }
}