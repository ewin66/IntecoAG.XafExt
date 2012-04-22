using System.Collections.Generic;

namespace IntecoAG.XAFExt.StateMachine {
    public interface IStateMachineTransitionPermission {
        StateMachineTransitionModifier Modifier { get; set; }
        string StateMachineName { get; set; }
        string StateCaption { get; set; }
        void SyncStateCaptions(IList<string> stateCaptions, string machineName);
    }
}