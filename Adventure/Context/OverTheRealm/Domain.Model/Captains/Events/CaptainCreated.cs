
using System;
using CQRSlite.Domain;
using CQRSlite.Events;

namespace HRSaga.Adventure.Context.OverTheRealm.Domain.Model.Captains.Events
{
    public class CaptainCreated : IEvent
    {

        public CaptainCreated(CaptainId captainId)
        {
            this.Identity = captainId;
            System.Console.WriteLine("Event: CaptainCreated");
        }

        public Identity Identity { get; set;}
        public int Version { get; set;}
        public DateTimeOffset TimeStamp { get; set;}

        public CaptainId captainId(){
            return (CaptainId)Identity;
        }
    }
}