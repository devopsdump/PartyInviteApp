using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInviteApp.Models
{
    public static class PartyDb
    {

        public static List<PartyInvitation> invitations = new List<PartyInvitation> ();
        public static IEnumerable<PartyInvitation> Invites => invitations;
        public static void AddInvite(PartyInvitation invitation)
        {
            invitations.Add(invitation);
        }
    }
}
