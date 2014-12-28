﻿using kOS.Persistence;
using kOS.Safe.Persistence;

namespace kOS.AddOns.RemoteTech2
{
    public class RemoteTechArchive : Archive
    {
        public bool CheckRange(Vessel vessel)
        {
            // return true if RemoteTech reports a connection to KSC, or if the vessel is currently in "PRELAUNCH" situation
            return vessel != null && (RemoteTechHook.Instance.HasConnectionToKSC(vessel.id) || vessel.situation == Vessel.Situations.PRELAUNCH);
        }
    }
}
